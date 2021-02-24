using SecureLine.ClientServerClasses;
using SecureLine.Data_Access;
using SecureLine.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Net;
using System.Net.Sockets;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace SecureLine
{
    public partial class ChatDialogForm : Form
    {
        //Create a RSA Key pair
        private RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(2048);

        //A flag that indicates whether the symmetric key has been 
        //received from the client yet.
        private bool symmetricKeyReceived = false;
        //Stores the symmetric key received from the client.
        private string symmetricKey;

        /// <summary>
        /// Converts the RSA public key to an XML string.
        /// </summary>
        /// <returns>The public key as an XML string.</returns>
        private string GetPublicKeyString()
        {
            return rsa.ToXmlString(false);
        }

        private TcpClient client;
        //The stream of data on the network.
        private NetworkStream clientStream;

        //Delegate functions used to access a UI control from a 
        //thread that is not the owner of that UI control
        private delegate void SetTextCallback(string s);
        private delegate void SetSendButtonCallBack(bool b);
        private delegate void SetTextBoxConnectionStatusCallBack(Color c);
        private delegate void SetTextBoxStudentNameCallBack();

        //The parent form of this form. 
        private StaffChatForm ownerForm;
        //An object for reading data asynchronously 
        private StateObject state;

        //Stores the information of the staff member who is operating the server now
        private StaffModel staffMember;

        //A flag that indicates whether the student's name has been received.
        private bool studentNameReceived = false;

        //Definining properties
        public TcpClient connectedClient
        {
            get { return client; }
            set { client = value; }
        }

        //Properties specific to each chat dialog form
        public string remoteEndPoint
        {
            get; set;
        }

        public string remotePort
        {
            get; set;
        }

        //The StaffChatForm needs to display 
        //each connected user in the TreeView.
        //So, it accesses the connectedStudent 
        //property to find their name and display it.
        public StudentModel connectedStudent
        {
            get;set;
        }

        public ChatDialogForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Constructor which accepts Client TCP object.
        /// </summary>
        /// <param name="parentForm"></param>
        /// <param name="tcpClient"></param>
        public ChatDialogForm(StaffChatForm parentForm, TcpClient tcpClient, StaffModel s)
        {
            InitializeComponent();

            this.ownerForm = parentForm;

            staffMember = s;
            connectedStudent = null;

            //Get stream object
            connectedClient = tcpClient;
            clientStream = tcpClient.GetStream();

            //Create the state object
            state = new StateObject();
            state.workSocket = connectedClient.Client;

            //Set properties
            remoteEndPoint = ((IPEndPoint)state.workSocket.RemoteEndPoint).Address.ToString();
            remotePort = ((IPEndPoint)state.workSocket.RemoteEndPoint).Port.ToString();

            //Send the RSA public key
            SendPublicKey();

            //Call asynchronous receive function 
            connectedClient.Client.BeginReceive(state.buffer, 0, StateObject.BufferSize, 0,
                new AsyncCallback(OnReceive), state);

            TextBoxConnectionStatus.BackColor = Color.Green;
        }

        //The public key must be send to the client so they can 
        //encrypt their symmetric key and send it back without the key being compromised
        private void SendPublicKey()
        {
            byte[] bt;
            bt = Encoding.UTF8.GetBytes(GetPublicKeyString());
            try
            {
                connectedClient.Client.Send(bt);
            }
            catch (Exception ex)
            {
                MyMessageBox.ShowMessage("Failed to send RSA public key: " + ex.ToString());
            }
        }

        //Staff name must be sent before the client and server begin chatting, 
        //so the users know who they're communicating with
        private void SendStaffName()
        {
            string encryptedMessage = ClassLibrary.SymmetricEncryptDecrypt(staffMember.StaffFirstName, symmetricKey);
            byte[] bt = Encoding.UTF8.GetBytes(encryptedMessage);

            try
            {
                connectedClient.Client.Send(bt);
            }
            catch (Exception ex)
            {
                MyMessageBox.ShowMessage("Failed to send staff first name: " + ex.ToString());
            }
        }

        /// <summary>
        /// Callback function called when data is received on the socket
        /// </summary>
        /// <param name="ar"></param>
        public void OnReceive(IAsyncResult ar)
        {
            string content = string.Empty;
            int bytesRead;

            // Retrieve the state object and the handler socket 
            //from the asynchronous state object. 
            StateObject state = (StateObject)ar.AsyncState;
            Socket clientSocket = state.workSocket;

            if (clientSocket.Connected)
            {
                // Read data from the client socket. 
                try
                {
                    bytesRead = clientSocket.EndReceive(ar);
                    if (bytesRead > 0)
                    {

                        if (!symmetricKeyReceived)
                        {
                            byte[] temp = state.buffer;
                            int i = temp.Length - 1;
                            while (temp[i] == 0)
                            {
                                --i;
                            }
                            // now data[i] is the last non-zero byte
                            byte[] receivedData = new byte[i + 1];
                            Array.Copy(temp, receivedData, i + 1);

                            //Get the symmetric key after decrypting it using RSA
                            byte[] decryptedKey = rsa.Decrypt(receivedData, false);
                            string decryptedKeyString = Convert.ToBase64String(decryptedKey);

                            symmetricKey = decryptedKeyString;
                            symmetricKeyReceived = true;

                            SendStaffName();

                            clientSocket.BeginReceive(state.buffer, 0, StateObject.BufferSize,
                                             0, new AsyncCallback(OnReceive), state);

                            return;
                        }

                        // There might be more data, so store the data received so far.
                        state.sb.Remove(0, state.sb.Length);
                        state.sb.Append(Encoding.UTF8.GetString(state.buffer, 0, bytesRead));

                        if (!studentNameReceived)
                        {
                            string encryptedStudentID = state.sb.ToString();
                            string sID = ClassLibrary.SymmetricEncryptDecrypt(encryptedStudentID, symmetricKey);

                            try
                            {
                                SqlConnector db = new SqlConnector();
                                List<StudentModel> listStudents = db.GetStudent_ByStudentID(sID);
                                connectedStudent = listStudents[0];
                            }
                            catch
                            {
                                MyMessageBox.ShowMessage("Access to the database failed.");
                                return;
                            }

                            SetTextBoxStudentName();
                            studentNameReceived = true;

                            clientSocket.BeginReceive(state.buffer, 0, StateObject.BufferSize,
                                             0, new AsyncCallback(OnReceive), state);

                            return;
                        }

                        // Display text in rich text box
                        string received = state.sb.ToString();
                        content = ClassLibrary.SymmetricEncryptDecrypt(received, symmetricKey);
                        SetText(content);
                        clientSocket.BeginReceive(state.buffer, 0, StateObject.BufferSize,
                                             0, new AsyncCallback(OnReceive), state);
                    }
                    else
                    {
                        //Disconnect request has 0 bytes.
                        //So if 0 byte message detected: disable further communication.
                        SetSendButton(false);
                        SetTextBoxConnectionStatus(Color.Red);

                        clientStream.Dispose();
                        clientStream.Close();
                        connectedClient.Client.Dispose();
                        connectedClient.Client.Close();
                    }
                }
                catch (SocketException socketException)
                {
                    //WSAECONNRESET, the other side closed impolitely 
                    if (socketException.ErrorCode == 10054 || ((socketException.ErrorCode != 10004) && (socketException.ErrorCode != 10053)))
                    {
                        // Complete the disconnect request.
                        string remoteIP =
                          ((IPEndPoint)clientSocket.RemoteEndPoint).Address.ToString();
                        string remotePort =
                          ((IPEndPoint)clientSocket.RemoteEndPoint).Port.ToString();
                        this.ownerForm.DisconnectClient(remoteIP, remotePort);
                        clientSocket.Close();
                        clientSocket = null;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        #region Invoke Method Functions

        /// <summary>
        /// This function is used to display data in the chat ListBox.
        /// </summary>
        /// <param name="text"></param>
        private void SetText(string text)
        {
            // InvokeRequired compares the thread ID of the calling 
            // thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.ListBoxChat.InvokeRequired)
            {
                //Use a delegate function to access a UI control from a thread 
                //that is not the owner of that UI control.
                //Now the text in the TextBox is updated by a thread that calls 
                //the callback function, OnReceive.
                //This is a system spawned thread.
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.ListBoxChat.Items.Add(connectedStudent.StudentFirstName + ": " + text + Environment.NewLine);
            }
        }

        private void SetTextBoxStudentName()
        {
            if (this.TextBoxStudentName.InvokeRequired)
            {
                SetTextBoxStudentNameCallBack d = new SetTextBoxStudentNameCallBack(SetTextBoxStudentName);
                this.Invoke(d);
            }
            else
            {
                this.TextBoxStudentName.Text = connectedStudent.StudentFirstName + " " + connectedStudent.StudentLastName;
            }
        }

        /// <summary>
        /// This function is used to change the background colour of the text box showing the connection status.
        /// </summary>
        /// <param name="c"></param>
        private void SetTextBoxConnectionStatus(Color c)
        {
            if (this.TextBoxConnectionStatus.InvokeRequired)
            {
                SetTextBoxConnectionStatusCallBack s = new SetTextBoxConnectionStatusCallBack(SetTextBoxConnectionStatus);
                this.Invoke(s, new object[] { c });
            }
            else
            {
                this.TextBoxConnectionStatus.BackColor = c;
            }
        }

        /// <summary>
        /// This function is used to set the send button as enabled or disabled.
        /// </summary>
        private void SetSendButton(bool b)
        {
            if (this.ButtonSendMessage.InvokeRequired)
            {
                SetSendButtonCallBack c = new SetSendButtonCallBack(SetSendButton);
                this.Invoke(c, new object[] { b });
            }
            else
            {
                this.ButtonSendMessage.Enabled = b;
            }
        }

        #endregion

        /// <summary>
        /// Function to send data to the client.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonSendMessage_Click(object sender, EventArgs e)
        {
            const string NULLDATAERRORMESSAGE = "Field cannot be left empty";

            //If there is no message to send, display an error message in the ErrorProvider 
            ClassLibrary.CheckTextBoxNotNull(TextBoxTypeMessage, ErrorProvider);
            if (ErrorProvider.GetError(TextBoxTypeMessage) == NULLDATAERRORMESSAGE)
            {
                return;
            }

            //Encrypt the message and transmit it
            string encryptedMessage = ClassLibrary.SymmetricEncryptDecrypt(TextBoxTypeMessage.Text, symmetricKey);
            byte[] bt = Encoding.UTF8.GetBytes(encryptedMessage);
            try
            {
                connectedClient.Client.Send(bt);
            }
            catch (Exception ex)
            {
                MyMessageBox.ShowMessage(ex.ToString());
                return;
            }

            //Display the text in the list box
            ListBoxChat.Items.Add(staffMember.StaffFirstName + ": " + TextBoxTypeMessage.Text + Environment.NewLine);
            TextBoxTypeMessage.Clear();
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            //Hide from tree list on ServerForm and close ChatDialog
            ownerForm.DisconnectClient(remoteEndPoint, remotePort);

            clientStream.Dispose();
            clientStream.Close();
            connectedClient.Client.Dispose();
            connectedClient.Client.Close();

            this.Hide();
            this.Close();
        }

        private void ChatDialogForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        private void ButtonPinMessage_Click(object sender, EventArgs e)
        {
            if (ListBoxChat.SelectedItem != null)
            {
                MessageModel m = new MessageModel(ListBoxChat.SelectedItem.ToString(), DateTime.Now, DateTime.Now);
                try
                {
                    GlobalConfig.Connection.CreateMessage(m, connectedStudent.StudentID);
                    MyMessageBox.ShowMessage($"Message successfully pinned to {connectedStudent.StudentFirstName} {connectedStudent.StudentLastName}.");
                }
                catch
                {
                    MyMessageBox.ShowMessage("Failed to pin message.");
                }
            }
            else
            {
                MyMessageBox.ShowMessage("Error: no message selected. Please select a message and try again.");
            }
        }
    }
}

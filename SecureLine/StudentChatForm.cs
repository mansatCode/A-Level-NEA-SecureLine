﻿using SecureLine.Models;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Text;
using SecureLine.ClientServerClasses;
using System.Security.Cryptography;
using System.Collections.Generic;
using System.Linq;

namespace SecureLine
{
    public partial class StudentChatForm : Form
    {
        //A public/private key pair will be generated by the server and sent to the client.
        private RSACryptoServiceProvider rsa;
        //The symmetric key will be created by the client and transmitted to the server.
        private string symmetricKey;
        //A flag that indicates whether the client has received the public key from the server yet.
        private bool publicKeyReceived = false;

        //A local IP and a set port are being used for now, but this 
        //could be easily changed in the future.
        //These will make up the socket that this client will send and listen to.
        private const string LOCALIP = "127.0.0.1";
        private const string LOCALPORT = "9000";

        private TcpClient server;
        //The stream of data on the network.
        private NetworkStream serverStream;
        //An object for reading data asynchronously 
        private StateObject state = new StateObject();

        //Delegate functions
        //used to access a UI control from a thread that is not the owner of that UI control
        private delegate void SetTextCallback(string s);
        private delegate void SetTextBoxConnectionStatusCallBack(Color c);
        private delegate void SetSendButtonCallBack(bool b);
        private delegate void SetConnectButtonCallBack(bool b);
        private delegate void SetDisconnectButtonCallBack(bool b);

        //Represents the logged in student.
        private StudentModel student;
        //String builders to save memory when concatenating strings.
        private StringBuilder sbReceive = new StringBuilder();
        private StringBuilder sbSend = new StringBuilder();

        //A flag that indicates whether the staff name sent by the server has been received yet.
        private bool nameReceived = false;
        //The name displayed next to each message from the server.
        private string staffName;

        public StudentChatForm(StudentModel s)
        {
            InitializeComponent();
            student = s;

            //Set the back colour of TextBoxConnectionStatus to red
            //to indicate the client is not connected
            TextBoxConnectionStatus.BackColor = Color.Red;

            //Disable certain UI controls
            ButtonSendMessage.Enabled = false;
            ButtonDisconnect.Enabled = false;
        }

        /// <summary>
        /// A callback function triggered when data is received on the socket.
        /// </summary>
        /// <param name="ar"></param>
        public void OnReceive(IAsyncResult ar)
        {
            string content = string.Empty;

            //Retrieve the state object and the handler socket from the asynchronous state object
            state = (StateObject)ar.AsyncState;
            Socket handler = state.workSocket;

            int bytesRead;

            if (handler.Connected)
            {
                //Read data from the client socket
                try
                {
                    bytesRead = handler.EndReceive(ar);

                    if (bytesRead > 0)
                    {
                        //There might be more data, so store the data received so far
                        state.sb.Remove(0, state.sb.Length);
                        //Translate the bytes into a readable format
                        state.sb.Append(Encoding.UTF8.GetString(state.buffer, 0, bytesRead));
                        string s = state.sb.ToString();
                        //Before the server and client can begin chatting, the server must send its 
                        //public key over, the client then sends a generated symmetric key back, encrypted 
                        //using the public key. Then the server must send the staff member's name while 
                        //the client must send the student ID.
                        if (!publicKeyReceived)
                        {
                            rsa = new RSACryptoServiceProvider(2048);
                            //Save the public key received to rsa
                            rsa.FromXmlString(state.sb.ToString());

                            SendSymmetricKey();

                            publicKeyReceived = true;
                            
                            //Continue to asynchronously receive data from the server
                            handler.BeginReceive(state.buffer, 0, StateObject.BufferSize, 0,
                            new AsyncCallback(OnReceive), state);

                            return;
                        }

                        if (!nameReceived)
                        {
                            SendStudentID();

                            string encryptedStaffName = state.sb.ToString();
                            staffName = ClassLibrary.SymmetricEncryptDecrypt(encryptedStaffName, symmetricKey);
                            nameReceived = true;

                            handler.BeginReceive(state.buffer, 0, StateObject.BufferSize, 0,
                            new AsyncCallback(OnReceive), state);

                            return;
                        }

                        //Display text in TextBox
                        string received = state.sb.ToString();
                        content = ClassLibrary.SymmetricEncryptDecrypt(received, symmetricKey);
                        //Function used to display text in the rich text box. A delegate function 
                        //must be used as we're not on the main thread.
                        SetText(content);
                        handler.BeginReceive(state.buffer, 0, StateObject.BufferSize, 0,
                            new AsyncCallback(OnReceive), state);
                    }
                    else
                    {
                        //If no data is received, then an error has occured as null messages cannot be sent.
                        MyMessageBox.ShowMessage("Error occured: no data was supplied.");
                    }
                }
                catch (SocketException socketEx)
                {
                    //WSAECONNRESET: if the other side closes impolitely 
                    //(they shut down the server or crash for some reason)
                    //Cut the connection and reset everything 
                    if (socketEx.ErrorCode == 10054 || ((socketEx.ErrorCode != 10004) && (socketEx.ErrorCode != 10053)))
                    {
                        handler.Close();
                        SetTextBoxConnectionStatusBackgroundColour(Color.Red);
                        SetSendButton(false);
                        SetConnectButton(true);
                        SetDisconnectButton(false);
                        serverStream.Close();
                        server.Close();
                        nameReceived = false;
                        publicKeyReceived = false;
                    }
                }
                catch (Exception ex)
                {
                    //Anyother unexpected error is displayed here
                    MyMessageBox.ShowMessage(ex.Message);
                }
            }
            else
            {
                handler.Close();
            }
        }

        #region Invoke Method Functions

        /// <summary>
        /// This function is used to display data in the text box.
        /// </summary>
        /// <param name="text"></param>
        private void SetText(string text)
        {
            // InvokeRequired compares the thread ID of the calling thread to the thread ID 
            // of the creating thread.
            // If these threads are different, it returns true.
            if (this.RichTextBoxChatWindow.InvokeRequired)
            {
                //Use a delegate function to access a UI control from a thread that is not the owner 
                //of that UI control. Now the text in the TextBox is updated by a thread that calls 
                //the callback function, OnReceive. This is a system spawned thread.
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                sbReceive.Clear();
                sbReceive.Append(staffName);
                sbReceive.Append(": ");
                sbReceive.Append(text);
                sbReceive.Append(Environment.NewLine);

                RichTextBoxChatWindow.SelectionColor = Color.HotPink;
                this.RichTextBoxChatWindow.AppendText(sbReceive.ToString());
            }
        }

        /// <summary>
        /// This function is used to set the connect button as enabled or disabled.
        /// </summary>
        /// <param name="b"></param>
        private void SetConnectButton(bool b)
        {
            if (this.ButtonConnect.InvokeRequired)
            {
                SetConnectButtonCallBack c = new SetConnectButtonCallBack(SetConnectButton);
                this.Invoke(c, new object[] { b });
            }
            else
            {
                this.ButtonConnect.Enabled = b;
            }
        }

        /// <summary>
        /// This function is used to set the disconnect button as enabled or disabled.
        /// </summary>
        /// <param name="b"></param>
        private void SetDisconnectButton(bool b)
        {
            if (this.ButtonDisconnect.InvokeRequired)
            {
                SetDisconnectButtonCallBack c = new SetDisconnectButtonCallBack(SetDisconnectButton);
                this.Invoke(c, new object[] { b });
            }
            else
            {
                this.ButtonDisconnect.Enabled = b;
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

        /// <summary>
        /// This function is used to change the background colour of the text box 
        /// showing the connection status.
        /// </summary>
        /// <param name="c"></param>
        private void SetTextBoxConnectionStatusBackgroundColour(Color c)
        {
            if (this.TextBoxConnectionStatus.InvokeRequired)
            {
                SetTextBoxConnectionStatusCallBack s = new SetTextBoxConnectionStatusCallBack(SetTextBoxConnectionStatusBackgroundColour);
                this.Invoke(s, new object[] { c });
            }
            else
            {
                this.TextBoxConnectionStatus.BackColor = c;
            }
        }

        #endregion

        private void ButtonConnect_Click(object sender, EventArgs e)
        {
            try
            {
                //When the user presses the connect button, we try to connect to the server
                // using the specified host and port
                server = new TcpClient(LOCALIP, Int32.Parse(LOCALPORT));
                state.workSocket = server.Client;
                serverStream = server.GetStream();
            }
            catch (SocketException)
            {
                MyMessageBox.ShowMessage("Action failed: the server is currently offline. Please re-attempt later. \nWorking hours are: 09:00 - 16:00 \nMonday - Friday.");
                return;
            }
            catch (Exception ex)
            {
                MyMessageBox.ShowMessage(ex.ToString());
                return;
            }

            TextBoxConnectionStatus.BackColor = Color.Green;
            ButtonSendMessage.Enabled = true;
            ButtonConnect.Enabled = false;
            ButtonDisconnect.Enabled = true;

            server.Client.BeginReceive(state.buffer, 0, StateObject.BufferSize, 0,
                new AsyncCallback(OnReceive), state);
        }

        /// <summary>
        /// Generates the symmetric key used for encrypting messages between the server and client.
        /// </summary>
        /// <param name="length"></param>
        /// <returns></returns>
        private string GenerateRandomKey(int length)
        {
            //Define the character set used to generate the key
            //Only Base64 Accepted Characters can be used
            IEnumerable<char> characterSet =
                "ABCDEFGHIJKLMNOPQRSTUVWXYZ" +
                "abcdefghijklmnopqrstuvwxyz" +
                "0123456789" +
                "+/";

            //Convert the IEnumberable to a array of type character
            var characterArray = characterSet.ToArray();
            //Create a new byte array
            var bytes = new byte[length * 8];
            //Fill the byte array with *cryptographically strong* sequence of random numbers
            new RNGCryptoServiceProvider().GetBytes(bytes);
            //Create a new character array to store the password
            var result = new char[length];

            for (int i = 0; i < length; i++)
            {
                //ulong used to store a large unsigned integer
                ulong value = BitConverter.ToUInt64(bytes, i * 8);
                //Populate the result array
                result[i] = characterArray[value % (uint)characterArray.Length];
            }

            StringBuilder sb = new StringBuilder();
            foreach (char c in result)
            {
                sb.Append(c);
            }

            return sb.ToString();
        }

        private void SendSymmetricKey()
        {
            //Has to be multiple of 8
            const int MAXMESSAGESIZE = 152;

            //Generate a symmetric key of length 200, which is the maximum 
            //length of a message that can be sent.
            string key = GenerateRandomKey(MAXMESSAGESIZE);
            symmetricKey = key;
            //Convert the string to a byte array
            byte[] bt = Convert.FromBase64String(key);

            //Encrypt the byte array with the public key
            byte[] keyEncrypted = rsa.Encrypt(bt, false);
            //Send it
            serverStream.Write(keyEncrypted, 0, Buffer.ByteLength(keyEncrypted));
            serverStream.Flush();
        }

        private void SendStudentID()
        {
            string sID = ClassLibrary.SymmetricEncryptDecrypt(student.StudentID, symmetricKey);
            serverStream.Write(Encoding.UTF8.GetBytes(sID), 0, Encoding.UTF8.GetByteCount(sID));
            serverStream.Flush();
        }

        private void ButtonSendMessage_Click(object sender, EventArgs e)
        {
            const string NULLDATAERRORMESSAGE = "Field cannot be left empty";

            ClassLibrary.CheckTextBoxNotNull(TextBoxTypeMessage, ErrorProvider);
            //As long as the user has some sort of input in the textbox, the message will send
            if (ErrorProvider.GetError(TextBoxTypeMessage) == NULLDATAERRORMESSAGE)
            {
                return;
            }

            //Encrypt the message
            string encryptedMessage = ClassLibrary.SymmetricEncryptDecrypt(TextBoxTypeMessage.Text, symmetricKey);
            //Encode the message and send it
            serverStream.Write(Encoding.UTF8.GetBytes(encryptedMessage), 0, Encoding.UTF8.GetByteCount(encryptedMessage));
            serverStream.Flush();

            //Display the message to the rich text box
            sbSend.Clear();
            sbSend.Append(student.StudentFirstName);
            sbSend.Append(": ");
            sbSend.Append(TextBoxTypeMessage.Text);
            sbSend.Append(Environment.NewLine);

            RichTextBoxChatWindow.SelectionColor = Color.Blue;
            RichTextBoxChatWindow.AppendText(sbSend.ToString());
            TextBoxTypeMessage.Clear();
        }

        private void ButtonDisconnect_Click(object sender, EventArgs e)
        {
            TextBoxConnectionStatus.BackColor = Color.Red;
            ButtonSendMessage.Enabled = false;
            //The connect button is disabled. The user can reconnect if they close the form 
            //and reopen it, but this is done to make it more difficult for a client to 
            //repeatedly connect and disconnect, as this would keep opening new ChatDialog 
            //forms for the server.
            ButtonConnect.Enabled = false;
            ButtonDisconnect.Enabled = false;
            ErrorProvider.SetError(TextBoxTypeMessage, null);

            serverStream.Dispose();
            serverStream.Close();
            server.Close();
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void StudentChatForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Disconnect if not already disconnected
            if (!(TextBoxConnectionStatus.BackColor == Color.Red))
            {
                serverStream.Dispose();
                serverStream.Close();
                server.Close();
            }
        }
    }
}

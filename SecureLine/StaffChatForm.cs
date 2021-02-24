using SecureLine.Models;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using SecureLine.ClientServerClasses;

namespace SecureLine
{
    public partial class StaffChatForm : Form
    {
        //A local IP and a set port are being used for now, but this 
        //could be easily changed in the future.
        //These will make up the socket that the TcpServer will listen and trasnmit to.
        private const string LOCALIP = "127.0.0.1";
        private const string LOCALPORT = "9000";

        StaffModel staffMember;

        private TcpListener tcpServer;
        private TcpClient tcpClient;
        //New threads created each time a TCP connection is made
        private Thread th;
        //The form that will opened upon every new connection
        private ChatDialogForm chatForm;
        //List of the open forms
        private List<Form> formList = new List<Form>();
        //List of open threads
        private List<Thread> threadList = new List<Thread>();

        //Delegate functions
        //used to access a UI control from a thread that 
        //is not the owner of that UI control
        private delegate void ChangedEventHandler(object sender, EventArgs e);
        private event ChangedEventHandler Changed;
        private delegate void SetListBoxItem(string str, string type);
        private delegate int GetTreeViewClientListIndexCallBack();

        /// <summary>
        /// Constructor: adds event to handle when the 
        /// client is connected and initalises tree view.
        /// </summary>
        public StaffChatForm(StaffModel s)
        {
            InitializeComponent();
            staffMember = s;

            //Set the controls
            TextBoxServerStatus.BackColor = Color.Red;
            ButtonStopServer.Enabled = false;

            //Add event to handle when a client is connected
            Changed += new ChangedEventHandler(ClientAdded);

            //Create the first tree node
            TreeNode node;
            node = TreeViewClientList.Nodes.Add("Open chats");
            node.Name = "OriginalNode";
        }

        private void ButtonStartServer_Click(object sender, EventArgs e)
        {
            try
            {
                StartServer();
            }
            catch (Exception ex)
            {
                MyMessageBox.ShowMessage(ex.ToString());
                return;
            }

            //Set the controls to show the server is operational
            TextBoxServerStatus.BackColor = Color.Green;
            ButtonStartServer.Enabled = false;
            ButtonStopServer.Enabled = true;
            TreeViewClientList.Enabled = true;
        }

        /// <summary>
        /// Spawns a new thread for TCP communication.
        /// </summary>
        private void StartServer()
        {
            try
            {
                th = new Thread(new ThreadStart(StartListen));
                th.Start();
            }
            catch (Exception ex)
            {
                MyMessageBox.ShowMessage("Failed to start the server: " + ex.ToString());
            }
        }

        /// <summary>
        /// Event to handle when new client is added
        /// </summary>
        /// <param name="obj"></param>
        private void NewClient(Object obj)
        {
            ClientAdded(this, new MyEventArgs((TcpClient)obj));
        }

        /// <summary>
        /// Event: fired when a client gets connected. Performs following actions:
        /// 1. Update tree view
        /// 2. Open a chat box to chat with client
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClientAdded(object sender, EventArgs e)
        {
            tcpClient = ((MyEventArgs)e).clientSock;

            //Show dialog box to facilitate chat
            chatForm = new ChatDialogForm(this, tcpClient, staffMember);

            //Add dialog box object to formList
            //Add current thread to threadList
            //Call delegate function to update tree view
            for (int i = 0; i < 100; i++)
            {
                try
                {
                    UpdateTreeView(chatForm.connectedStudent.StudentFirstName + " " + chatForm.connectedStudent.StudentLastName, "Add");
                    break;
                }
                catch (System.NullReferenceException)
                {
                    //Free the processor to do other things
                    Thread.Sleep(100);
                }
                catch (Exception ex)
                {
                    MyMessageBox.ShowMessage("An error occurred: " + ex.ToString());
                    break;
                }
            }
            
            formList.Add(chatForm);
            threadList.Add(Thread.CurrentThread);

            chatForm.ShowDialog();

        }

        /// <summary>
        /// Calls delegate function to update list box.
        /// IF parameter is "Add", then client information is added in Tree View,
        /// ELSE entry is deleted from Tree View.
        /// </summary>
        /// <param name="str"></param>
        /// <param name="type"></param>
        private void UpdateTreeView(string str, string type)
        {
            //InvokeRequired compares the thread ID of the 
            //calling thread to that of the current thread.
            //If these threads are different, it returns true.
            if (this.TreeViewClientList.InvokeRequired)
            {
                //System spawned thread
                SetListBoxItem d = new SetListBoxItem(UpdateTreeView);
                this.Invoke(d, new object[] { str, type });
            }
            else
            {
                //If type is "Add", then add client info in Tree View
                if (type.Equals("Add"))
                {
                    this.TreeViewClientList.Nodes[0].Nodes.Add(str);
                }
                else //Delete client information from tree view
                {
                    foreach (TreeNode n in this.TreeViewClientList.Nodes[0].Nodes)
                    {
                        if (n == null)
                        {
                            return;
                        }

                        if (n.Text.Equals(str))
                        {
                            this.TreeViewClientList.Nodes.Remove(n);
                        }  
                    }
                }
            }
        }

        /// <summary>
        /// The server listens on the given port and accepts the 
        /// connection from the client.
        /// As soon as the connection is made, a dialog box opens to enable chatting.
        /// </summary>
        private void StartListen()
        {
            IPAddress localAddr = IPAddress.Parse(LOCALIP);

            tcpServer = new TcpListener(localAddr, Int32.Parse(LOCALPORT));
            tcpServer.Start();

            //Continue accepting Client Connection
            while (true)
            {

                //New client connected: call event to handle it
                Thread t = new Thread(new ParameterizedThreadStart(NewClient));
                tcpClient = tcpServer.AcceptTcpClient();
                t.Start(tcpClient);

            }
        }

        /// <summary>
        /// Halts the TCP communication. It kills the thread and 
        /// closes the client connection.
        /// </summary>
        private void StopServer()
        {
            if (tcpServer != null)
            {
                //Close all socket connections
                foreach (ChatDialogForm c in formList)
                {
                    c.connectedClient.Client.Close();
                }

                //Abort all running threads
                foreach (Thread t in threadList)
                {
                    t.Abort();
                }

                //Clear lists
                formList.Clear();
                threadList.Clear();
                TreeViewClientList.Nodes[0].Nodes.Clear();

                //Abort listening thread and stop listening
                th.Abort();

                tcpServer.Stop();
            }
        }

        /// <summary>
        /// Called from within ChatDialogForm to disconnect 
        /// the client and remove them from TreeView.
        /// </summary>
        /// <param name="remoteIP"></param>
        /// <param name="remotePort"></param>
        public void DisconnectClient(string remoteIP, string remotePort)
        {
            Socket selectedSocket;

            //Delete the client from Tree View
            UpdateTreeView(chatForm.connectedStudent.StudentFirstName + " " + chatForm.connectedStudent.StudentLastName, "Delete");

            //Find client ChatDialog box corresponding to this socket
            int counter = 0;
            foreach (ChatDialogForm c in formList)
            {

                if (c.remoteEndPoint.Equals(remoteIP) && c.remotePort.Equals(remotePort))
                {
                    selectedSocket = c.connectedClient.Client;
                    selectedSocket.Close();

                    break;
                }
                counter++;
            }

            //Terminate ChatDialog box
            ChatDialogForm cd = (ChatDialogForm)formList[counter];
            formList.RemoveAt(counter);

            ((Thread)(threadList[counter])).Abort();
            threadList.RemoveAt(counter);
        }

        /// <summary>
        /// Function to stop the server.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonStopServer_Click(object sender, EventArgs e)
        {
            try
            {
                StopServer();
            }
            catch (Exception ex)
            {
                MyMessageBox.ShowMessage("Failed to stop the server: " + ex.ToString());
                return;
            }

            //Set the controls to show the server is offline
            TextBoxServerStatus.BackColor = Color.Red;
            ButtonStartServer.Enabled = true;
            ButtonStopServer.Enabled = false;
        }

        /// <summary>
        /// Event called when Tree View Client list is double clicked. 
        /// When a node is double clicked, corresponding chat dialog box is made visible.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TreeViewClientList_DoubleClick(object sender, EventArgs e)
        {
            int index = 0;

            if (TreeViewClientList.SelectedNode.Index != 0)
            {
                index = TreeViewClientList.SelectedNode.Index;
            }

            //If the original node is selected, do nothing.
            if (TreeViewClientList.SelectedNode.Name == "OriginalNode")
            {
                return;
            }

            // Open Hidden Dialog Box
            if (!((ChatDialogForm)formList[index]).Visible)
            {
                try
                {
                    ((ChatDialogForm)formList[index]).Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }
        private void ButtonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void StaffChatForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            StopServer();
        }
    }
}

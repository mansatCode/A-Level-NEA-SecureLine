using System;
using System.Net.Sockets;

namespace SecureLine.ClientServerClasses
{
    //Create a custom event to handle when a client is added
    class MyEventArgs : EventArgs
    {
        private TcpClient socket;

        public TcpClient clientSock
        {
            get { return socket; }
            set { socket = value; }
        }

        public MyEventArgs(TcpClient tcpClient)
        {
            socket = tcpClient;
        }
    }
}

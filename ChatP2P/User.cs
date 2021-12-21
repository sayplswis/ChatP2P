﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ChatP2P
{
    class User
    {
        public string Name;
        public IPAddress IP;
        public int tcpPort;

        private TcpClient _tcpClient;
        public NetworkStream messageStream;

        public User(string login, IPEndPoint endPoint, int port)
        {
            IP = endPoint.Address;
            tcpPort = port;
            this.Name = login;
        }
        public User(TcpClient tcpClient, int port)
        {
            _tcpClient = tcpClient;
            tcpPort = port;
            IP = ((IPEndPoint)_tcpClient.Client.RemoteEndPoint).Address;
            messageStream = _tcpClient.GetStream();
        }
        public void EstablishConnection()
        {
            _tcpClient = new TcpClient();
            _tcpClient.Connect(new IPEndPoint(IP, tcpPort));
            messageStream = _tcpClient.GetStream();
        }

        public void SendMessage(string message)
        {
            byte[] data = Encoding.UTF8.GetBytes(message);
            this.messageStream.Write(data, 0, data.Length);
        }

        public string ReceiveMessage()
        {
            StringBuilder message = new StringBuilder();
            byte[] buff = new byte[1024];
            do
            {
                try
                {
                    int size = messageStream.Read(buff, 0, buff.Length);
                    message.Append(Encoding.UTF8.GetString(buff, 0, size));
                }
                catch
                {
                    return "1";
                }

            }
            while (messageStream.DataAvailable);

            string receiveMessage = message.ToString();

            return receiveMessage;
        }

        public void Disconnect()
        {
            _tcpClient.Close();
        }
    }
}

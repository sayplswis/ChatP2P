using System.Collections.Generic;
using System.Net;

namespace ChatP2P
{
    class ChatBehaviour
    {
        public List<User> UserList = new List<User>();

        //public string AddUser(string Name, IPEndPoint IP, int port)
        //{
        //    UserList.Add(new User(Name, IP, port));
        //    return Name;
        //}

        public void RemoveUser(IPEndPoint endPoint)
        {
            for (int i = 0; i < UserList.Count; i++)
            {
                if ((endPoint.Address == UserList[i].IP) && (endPoint.Port == UserList[i].tcpPort))
                {
                    UserList.RemoveAt(i);
                }
            }
        }

        public string WhatIsThis(string message, IPEndPoint adress)
        {
            if (message[0] == '0')
            {
                string name;
                name = message.Substring(1);
                return name + " подключился к чату";
            }
            return "";
        }
    }
}

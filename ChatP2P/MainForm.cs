using System;
using System.Collections.Generic;
using System.Drawing;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatP2P
{
    public partial class MainForm : Form
    {
        private string _myName;
        private IPAddress _myIP;
        private bool _alive = true;
        private int _UDPPort = 8001;
        private int _TCPPort;

        private static Task receiveThreadUDP;
        private static Task receiveThreadTCP;

        private ChatBehaviour _chatUsers = new ChatBehaviour();
        public MainForm()
        {
            InitializeComponent();

            new List<Control> { HeaderPanel }.ForEach(x =>
            {
                x.MouseDown += (s, a) =>
                {
                    x.Capture = false; Capture = false; Message m = Message.Create(Handle, 0xA1, new IntPtr(2), IntPtr.Zero); base.WndProc(ref m);
                };
            });

            SendButton.Enabled = false;
            MessageTextBox.Enabled = false;
            MyIPTextBox.Text = GetIP().MapToIPv4().ToString();
            OtherIPTextBox.Text = GetIP().MapToIPv4().ToString();
        }
        
        private void ReceiveTCP()
        {
            TcpListener tcpListener = new TcpListener(_myIP, _TCPPort);
            tcpListener.Start();

            while (true)
            {
                TcpClient tcpNewClient = tcpListener.AcceptTcpClient();
                User newUser = new User(tcpNewClient, _TCPPort);

                Task.Factory.StartNew(() => ListenClient(newUser));
            }
        }

        private void ListenClient(User client)
        {
            while (_alive)
            {
                string tcpMessage = client.ReceiveMessage();
                switch (tcpMessage[0])
                {
                    case '0':
                        {
                            client.Name = tcpMessage.Substring(1);
                            _chatUsers.UserList.Add(client);
                            break;
                        }
                    case '1':
                        this.Invoke(new MethodInvoker(() =>
                        {
                            ChatTextBox.Text = $"{DateTime.Now.ToLongTimeString()} :  {client.Name} [{client.IP}] покинул чат\r\n" + ChatTextBox.Text;
                        }));

                        _chatUsers.UserList.Remove(client);
                        return;

                    case '2':
                        this.Invoke(new MethodInvoker(() =>
                        {
                            ChatTextBox.Text = $"{DateTime.Now.ToLongTimeString()} :  {client.Name} [{client.IP}]: {tcpMessage.Substring(1)}\r\n" + ChatTextBox.Text;
                        }));
                        break;
                }
            }
        }
        private void SendMessageUDP(string message)
        {
            UdpClient sender = new UdpClient();
            try
            {
                byte[] data = Encoding.UTF8.GetBytes(message);
                sender.Send(data, data.Length, GetBroadcastAdr(_myIP).ToString(), _UDPPort);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                sender.Close();
            }
        }

        private void ReceiveMessageUDP()
        {
            IPEndPoint remoteIp = new IPEndPoint(IPAddress.Any, _UDPPort);

            using(UdpClient receiver = new UdpClient(new IPEndPoint(_myIP, _UDPPort)))
            {
                while (_alive)
                {
                    byte[] data = receiver.Receive(ref remoteIp);
                    string message = Encoding.UTF8.GetString(data);

                    string toPrint = _chatUsers.WhatIsThis(message, remoteIp);

                    User newUser = new User(message.Substring(1), remoteIp, int.Parse(OtherPortTextBox.Text));
                    newUser.EstablishConnection();
                    _chatUsers.UserList.Add(newUser);
                    newUser.SendMessage("0" + _myName);
                    this.Invoke(new MethodInvoker(() =>
                    {
                        string time = DateTime.Now.ToLongTimeString();
                        ChatTextBox.Text = $"{time} [{remoteIp.Address}] {toPrint}\r\n {ChatTextBox.Text}";
                    }));
                    Task.Factory.StartNew(() => ListenClient(newUser));

                }
                receiver.Close();
            }
        }
        public void SendMessageToAllClients(string tcpMessage)
        {
            foreach (var user in _chatUsers.UserList)
            {
                try
                {
                    user.SendMessage(tcpMessage);
                }
                catch
                {
                    MessageBox.Show($"Не удалось отправить сообщение пользователю {user.Name}.");
                }
            }

            if (tcpMessage[0] == '2')
            {
                this.Invoke(new MethodInvoker(() =>
                {
                    ChatTextBox.Text = $"{DateTime.Now.ToLongTimeString()} :  Вы [{_myIP}]: {tcpMessage.Substring(1)}\r\n" + ChatTextBox.Text;
                }));
            }

        }
        public IPAddress GetIP()
        {
            string hostName = Dns.GetHostName();
            IPAddress[] ipAddrs = Dns.GetHostAddresses(hostName);
            foreach (var item in ipAddrs)
            {
                if (item.AddressFamily == AddressFamily.InterNetwork)
                    return item;
            }
            return ipAddrs[0];
        }
        private IPAddress GetBroadcastAdr(IPAddress ip)
        {
            string broadcastAddr = ip.ToString();
            broadcastAddr = broadcastAddr.Substring(0, broadcastAddr.LastIndexOf('.') + 1) + "255";

            return IPAddress.Parse(broadcastAddr);
        }
        private void SendMessage()
        {
            SendMessageToAllClients("2" + MessageTextBox.Text);
            MessageTextBox.Text = "";
        }

        private void ChatButton_Click(object sender, EventArgs e)
        {
            SettingsButton.BackColor = Color.FromArgb(53, 77, 183);
            ChatButton.BackColor = Color.FromArgb(1, 10, 88);
            ChatPanel.Visible = true;
            SettingsPanel.Visible = false;
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            SettingsButton.BackColor = Color.FromArgb(1, 10, 88);
            ChatButton.BackColor = Color.FromArgb(53, 77, 183);
            ChatPanel.Visible = false;
            SettingsPanel.Visible = true;
        }

        private void MessageTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (MessageTextBox.Text == "")
                {
                    MessageBox.Show("Пустое сообщение");
                }
                else
                {
                    SendMessage();
                }
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _alive = false;
            SendMessageToAllClients("1");
            foreach (var user in _chatUsers.UserList)
            {
                user.Disconnect();
            }
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            SendMessage();
        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            _TCPPort = int.Parse(MyPortTextBox.Text);

            ConnectButton.Enabled = false;
            NicknameTextBox.ReadOnly = true;
            SendButton.Enabled = true;
            MessageTextBox.Enabled = true;

            _myName = NicknameTextBox.Text;
            _myIP = GetIP();
            _alive = true;

            SendMessageUDP("0" + _myName);

            receiveThreadUDP = new Task(ReceiveMessageUDP);
            receiveThreadUDP.Start();

            ChatTextBox.Text = $"{DateTime.Now.ToLongTimeString()} : Вы [{_myIP}] подключились к чату\r\n" + ChatTextBox.Text;
            receiveThreadTCP = new Task(ReceiveTCP);
            receiveThreadTCP.Start();

            SettingsPanel.Visible = false;
            SettingsButton.Enabled = false;
            ChatPanel.Visible = true;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net; // 추가
using System.Net.Sockets;
using System.IO;
using System.Threading;

namespace ChatServer
{
    public partial class Form1 : Form
    {
        private TcpListener server;
        private List<TcpClient> clients = new List<TcpClient>();
        private Dictionary<TcpClient, string> clientNames = new Dictionary<TcpClient, string>();


        public Form1()
        {
            InitializeComponent();
            server = new TcpListener(IPAddress.Any, 9000);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            server.Start();
            txtServer.AppendText("Server started...\r\n");
            AcceptClientsAsync();
        }

        private async void AcceptClientsAsync()
        {
            while (true)
            {
                TcpClient client = await server.AcceptTcpClientAsync();
                clients.Add(client);
                txtServer.AppendText("New client connected...\r\n");

                // 첫 메시지를 통해 닉네임을 받음
                ReceiveNickname(client);

                //HandleClientAsync(client);
            }
        }

        private async void ReceiveNickname(TcpClient client)
        {
            NetworkStream stream = client.GetStream();
            byte[] buffer = new byte[1024];

            int bytesRead = await stream.ReadAsync(buffer, 0, buffer.Length);
            string nickname = Encoding.UTF8.GetString(buffer, 0, bytesRead);

            // 클라이언트의 닉네임 저장 및 서버에 출력
            clientNames[client] = nickname;
            txtServer.Invoke((Action)(() =>
            {
                //txtServer.AppendText($"{nickname} 접속중\r\n");
                DisplayClientList();
            }));

            HandleClientAsync(client);
        }


        private async void HandleClientAsync(TcpClient client)
        {
            NetworkStream stream = client.GetStream();
            byte[] buffer = new byte[1024];

            try
            {
                while (true)
                {
                    int bytesRead = await stream.ReadAsync(buffer, 0, buffer.Length); // 클라이언트 나갔을 때 예외 처리 필요
                    if (bytesRead == 0) break;  // 연결 종료 시

                    string message = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                    //txtServer.AppendText($"{message}\r\n"); // 서버엔 출력할 필요 없음
                    BroadcastMessage(message, client);

                } 
            }
            catch (IOException e)
            {
                Invoke((Action)(() =>
                {
                    txtServer.AppendText($"Network error: {e.Message}\r\n");
                }));
            }
            finally
            {
                clients.Remove(client);
                clientNames.Remove(client);
                client.Close();
                DisplayClientList();  // 클라이언트가 나가면 리스트 업데이트
            }

        }

        private void SendClientList()
        {
            // 접속 중인 클라이언트　목록
            string clientListMessage = "[접속중] " + string.Join(" | ", clientNames.Values);

            // 모든 클라이언트에게 전송
            byte[] data = Encoding.UTF8.GetBytes(clientListMessage);
            foreach (var client in clients)
            {
                client.GetStream().Write(data, 0, data.Length);
            }
        }

        private void BroadcastMessage(string message, TcpClient sender)
        {
            byte[] data = Encoding.UTF8.GetBytes(message);

            foreach (var client in clients)
            {
                //if (client != sender)
                //{
                    client.GetStream().Write(data, 0, data.Length);
                //}
            }
        }
        private void DisplayClientList()
        {
            txtServer.Clear();
            //txtServer.AppendText("Connected clients:\r\n");
            foreach (var name in clientNames.Values)
            {
                txtServer.AppendText($"[{name}] 접속중 (^-^)\r\n\r\n");
            }

            // 클라이언트들에게 목록 전송
            SendClientList();
        }

    }
}

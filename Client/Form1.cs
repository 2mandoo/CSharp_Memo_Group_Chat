using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatClient
{
    public partial class Form1 : Form
    {
        private TcpClient client;
        private NetworkStream stream;
        private string IP = "192.168.0.25";

        public Form1()
        {
            InitializeComponent();
        }

        private async void lblChat_Click(object sender, EventArgs e)
        {
            try
            {
                client = new TcpClient();
                await client.ConnectAsync(IP, 9000);  // 서버 IP와 포트
                txtChat.AppendText("Connected to the server...\r\n");

                // 연결 후 즉시 닉네임을 전송
                string nickname = txtNick.Text;
                byte[] nicknameData = Encoding.UTF8.GetBytes(nickname);
                await client.GetStream().WriteAsync(nicknameData, 0, nicknameData.Length);

                // 메시지 수신 처리
                ReceiveMessagesAsync();
            
            }
            catch (Exception ex)
            {
                txtChat.AppendText($"Error receiving message: {ex.Message}\r\n");
            }
        }

        private async void SendMessage(string message)
        {
            if (client.Connected)
            {
                // 닉네임과 메시지 결합
                string nickname = txtNick.Text;
                string fullMessage = $"[{nickname}] {message}";
                byte[] data = Encoding.UTF8.GetBytes(fullMessage);
                await client.GetStream().WriteAsync(data, 0, data.Length);
            }
        }

        private async void ReceiveMessagesAsync()
        {
            stream = client.GetStream();
            byte[] buffer = new byte[1024];

            try
            {
                while (client?.Connected == true && stream?.CanRead == true)
                {
                    int bytesRead = await stream.ReadAsync(buffer, 0, buffer.Length);

                    if (bytesRead == 0)
                    {
                        // 서버가 연결을 끊었을 때
                        Invoke((Action)(() =>
                        {
                            txtChat.AppendText("Disconnected from server.\r\n");
                        }));
                        break;
                    }

                    string message = Encoding.UTF8.GetString(buffer, 0, bytesRead);

                    if (message.StartsWith("[접속중]"))
                    {
                        // 접속 중인 클라이언트 목록을 표시
                        string clientList = message;
                        Invoke((Action)(() =>
                        {
                            lblClientList.Text = clientList;
                        }));
                    }
                    else
                    {
                        // 일반 채팅 메시지인 경우
                        Invoke((Action)(() =>
                        {
                            txtChat.AppendText($"{message}\r\n");
                        }));
                    }
                }
            
            }
            catch (Exception ex)
            {
                // 예외 발생 시
                Invoke((Action)(() =>
                {
                    txtChat.AppendText($"Error receiving message: {ex.Message}\r\n");
                }));
            }
        }

        private void txtInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string message = txtInput.Text.TrimStart();

                if (message == "cls")
                {
                    txtChat.Clear();
                }
                else if (!string.IsNullOrEmpty(message))
                {
                    SendMessage(message);
                }

                txtInput.Clear();
            }
        }

        private void txtNick_Enter(object sender, EventArgs e)
        {
        }

        private void txtNick_Click(object sender, EventArgs e)
        {
            txtNick.Clear();
        }

        private void lblDisconnect_Click(object sender, EventArgs e)
        {
            stream.Close();
            client.Close();
            txtChat.AppendText("Disconnected from the server.\r\n");
        }

        private void lblClear_Click(object sender, EventArgs e)
        {
            txtChat.Clear();
        }

        private void txtChat_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

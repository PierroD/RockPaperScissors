using RPSMessage;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RockPaperScissors
{
    public partial class Form1 : Form
    {

        private enum Choice
        {
            Rock,
            Paper,
            Scissors
        }

        private Choice current_choice;
        private TcpClients _client;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _client = new TcpClients("127.0.0.1", 4444);
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            Task.Run(() => ConnectToServer());
        }


        private void Choice_Click(object sender, EventArgs e)
        {
            Guna.UI2.WinForms.Guna2CirclePictureBox ImageClicked = (Guna.UI2.WinForms.Guna2CirclePictureBox)sender;
            lbl_youChoose.Visible = true;
            Enum.TryParse(ImageClicked.Name.Substring(4), out Choice current_choice);
            lbl_choice.Text = current_choice.ToString();
        }

        private void ChangelblConnectionStatus(bool connected)
        {
            if (connected)
            {
                this.Invoke(new MethodInvoker(delegate
                {
                    lbl_connectionStatus.Text = "Connected";
                    lbl_connectionStatus.ForeColor = Color.Green;
                }));
            }
            else
            {
                this.Invoke(new MethodInvoker(delegate
                {
                    lbl_connectionStatus.Text = "Not Connected";
                    lbl_connectionStatus.ForeColor = Color.Red;
                }));
            }
        }
        private async void ConnectToServer()
        {
            while (true)
            {
                if (_client.IsConnected)
                {
                    ChangelblConnectionStatus(true);
                    // TODO : Delete message send after validation
                    SendMessage();
                    ReadMessage();
                }
                else
                {
                    ChangelblConnectionStatus(false);
                    _client.Retry();
                }
                await Task.Delay(TimeSpan.FromSeconds(2), default(CancellationToken));
            }
        }

        private void pnl_Matchmaking_VisibleChanged(object sender, EventArgs e)
        {
            if (pnl_Matchmaking.Visible)
                timer_macthmaking.Start();

        }

        int direction = 1;
        private void timer_macthmaking_Tick(object sender, EventArgs e)
        {
            if (pbar_loading.Value == 70 || pbar_loading.Value == 0)
                direction = (direction == 1) ? -1 : 1; // change direction

            pbar_loading.Value += direction;

        }

        private void ReadMessage()
        {
            byte[] buffer = new byte[4096];
            int byteRead = 0;

            while ((byteRead = _client.tcpClient.GetStream().Read(buffer, 0, 4096)) > 0)
            {
                string message = Encoding.UTF8.GetString(buffer, 0, byteRead);
            }
        }

        private void SendMessage()
        {
/*            byte[] buffer = Encoding.UTF8.GetBytes("Hello server from client");
            _client.tcpClient.GetStream().Write(buffer, 0, buffer.Length);
*/        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SocketHelper.WriteToServer(_client, Encapsulation.Serialize(Encapsulation.FromValue(new Test { nom = "test"}, MessageType.Disconnect)));
        }

        public class Test
        {
            public string nom { get; set; }
        }
    }

}
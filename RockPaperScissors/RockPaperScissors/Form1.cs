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
using SharedClasses;
using RockPaperScissors.Views;
using RockPaperScissors.Configs;
using System.IO;
using System.Reflection;

namespace RockPaperScissors
{
    public partial class Form1 : Form
    {


        private Choice playerChoice;
        public TcpClients _client { get; set; }


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Config config = new Config($"{Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)}\\client.ini");
            _client = new TcpClients(config.serverIpAddress, config.serverPort);
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            Task.Run(() => ConnectToServer());
        }


        private void Choice_Click(object sender, EventArgs e)
        {
            Guna.UI2.WinForms.Guna2CirclePictureBox ImageClicked = (Guna.UI2.WinForms.Guna2CirclePictureBox)sender;
            playerChoice = (Choice)Enum.Parse(typeof(Choice), ImageClicked.Name.Substring(5)); // delete pbox_ in the name of the button 
            pbox_answer.Location = new Point((ImageClicked.Location.X + (ImageClicked.Width/2) - (pbox_answer.Width/2)), pbox_answer.Location.Y);

        }

        private void ChangelblConnectionStatus(bool connected)
        {
            try
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
            catch { }
        }
        private async void ConnectToServer()
        {
            Thread readThread = new Thread(ReadMessage);
            while (true)
            {
                if (_client.IsConnected)
                {
                    ChangelblConnectionStatus(true);
                    if (readThread.ThreadState != ThreadState.Running && !readThread.IsAlive)
                        readThread.Start();
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
            byte[] buffer = new byte[Constants.BUFFER_SIZE];
            int byteLength = 0;
            try
            {
                while ((byteLength = _client.tcpClient.Client.Receive(buffer, 0, Constants.BUFFER_SIZE, SocketFlags.None)) > 0)
                {
                    byte[] message = new byte[Constants.BUFFER_SIZE];
                    Array.Copy(buffer, message, byteLength);
                    buffer = new byte[Constants.BUFFER_SIZE];
                    Encapsulation encapsulation = Encapsulation.Deserialize(message);
                    Processor.MessageProcessor(this, encapsulation, _client);
                }
            }
            catch
            {

            }

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Response.DisconnectMessage(_client);
            _client.tcpClient.Close();
        }

        private void btn_play_Click(object sender, EventArgs e)
        {
            Response.AnswerResponse(_client, playerChoice, 0);
            Processor.toogleGame_View(this, false, "Wait ...");

        }
    }

}
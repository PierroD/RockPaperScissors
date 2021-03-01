using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using TestRPSServer.Models;
using static TestRPSServer.Constants;

namespace TestRPSServer
{
    public class TcpServer
    {
        private TcpListener _server;
        private int _clients_number;
        private List<Player> _players = new List<Player>();
        public TcpServer(int port)
        {
            _server = new TcpListener(IPAddress.Any, port);
            _server.Start();
            Thread listeningThread = new Thread(listenClients);
            listeningThread.Start();
        }


        private void listenClients()
        {
            while (_server.Server.IsBound)
            {
                try
                {
                    TcpClient newClient = _server.AcceptTcpClient();
                    Thread clientThread = new Thread(new ParameterizedThreadStart(HandleClient));
                    Player newPlayer = new Player(newClient, _clients_number++);
                    _players.Add(newPlayer);
                    clientThread.Start(newClient);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        private void HandleClient(object obj)
        {
            TcpClient client = (TcpClient)obj;
            byte[] buffer = new byte[Constants.Constants.BUFFER_SIZE];
            int byteRead = 0;
            Console.WriteLine($"Client connected");
            while ((byteRead = client.GetStream().Read(buffer, 0, 4096)) > 0)
            {
                Console.WriteLine($"Message received : {Encoding.UTF8.GetString(buffer, 0, byteRead)}");
            }
        }
    }
}

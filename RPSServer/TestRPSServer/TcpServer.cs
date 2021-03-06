using RPSMessage;
using SharedClasses;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using TestRPSServer.Models;

namespace TestRPSServer
{
    public class TcpServer
    {
        private TcpListener _server;
        private int _clients_number;
        private List<Player> _players = new List<Player>();
        public TcpServer(string ipAddress, int port)
        {
            _server = new TcpListener(IPAddress.Parse(ipAddress), port);
            _server.Start();
            Thread listeningThread = new Thread(listenClients);
            Thread MatchMakingThread = new Thread(MatchMakingHandle);
            listeningThread.Start();
            MatchMakingThread.Start();
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
                    clientThread.Start(newPlayer);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        private void HandleClient(object obj)
        {
            Player player = (Player)obj;
            byte[] buffer = new byte[Constants.BUFFER_SIZE];
            int byteLength = 0;
            Console.WriteLine($"Client {player.id} connected");
            Response.DiscoverResponse(player);
            try
            {
                while (player.tcpClient != null && (byteLength = player.tcpClient.GetStream().Read(buffer, 0, Constants.BUFFER_SIZE)) > 0)
                {
                    Encapsulation message = Encapsulation.Deserialize(buffer);
                    Processor.MessageProcessor(message, player);
                }
            }
            catch
            {

            }
        }

        private void MatchMakingHandle()
        {
            while (true)
            {
                List<Player> MatchMakingQueue = new List<Player>();
                List<Player> players = new List<Player>(_players);
                if (_players.Count > 0)
                    foreach (Player player in players)
                    {
                        if (player.status == Status.Searching && !MatchMakingQueue.Contains(player))
                            MatchMakingQueue.Add(player);
                        if (MatchMakingQueue.Count >= Configs.Config.numberOfPlayerPerGame)
                        {
                            foreach (Player game_player in MatchMakingQueue)
                                game_player.status = Status.Alive;
                            new Game(MatchMakingQueue);
                        }

                    }
                Thread.Sleep(TimeSpan.FromSeconds(1));
            }
        }


    }

}

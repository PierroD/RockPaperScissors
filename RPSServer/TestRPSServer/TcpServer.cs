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
        public TcpServer(int port)
        {
            _server = new TcpListener(IPAddress.Any, port);
            _server.Start();
            Thread listeningThread = new Thread(listenClients);
            listeningThread.Start();
            Thread MatchMakingThread = new Thread(MatchMakingHandle);
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
            List<Player> MatchMakingQueue = new List<Player>();
            foreach (Player player in _players)
            {
                if (player.status == Status.Searching)
                    MatchMakingQueue.Add(player);
                if (MatchMakingQueue.Count >= 2) // 2 is the number of player but will be stored in a .ini file
                    Console.WriteLine("A game will be created");

            }
        }


    }

}

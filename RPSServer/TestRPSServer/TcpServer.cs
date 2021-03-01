using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.IO;
using RPSMessage;

namespace TestRPSServer
{
    public class TcpServer
    {
        private TcpListener _server;
        
        public TcpServer(int port)
        {
            _server = new TcpListener(IPAddress.Any, port);
            _server.Start();
            Thread listeningThread = new Thread(listenClients);
            listeningThread.Start();
        }


        private void listenClients()
        {
            while(_server.Server.IsBound)
            {
                try
                {
                    TcpClient newClient = _server.AcceptTcpClient();
                    Thread clientThread = new Thread(new ParameterizedThreadStart(HandleClient));
                    clientThread.Start(newClient);
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        private void HandleClient(object obj)
        {
            TcpClient client = (TcpClient)obj;
            byte[] buffer = new byte[1000];
            int byteRead = 0;
            Console.WriteLine($"Client connected");
            /*            StreamWriter sWriter = new StreamWriter(client.GetStream(), Encoding.ASCII);
                        StreamReader sReader = new StreamReader(client.GetStream(), Encoding.ASCII);
                        string datas = sReader.ReadLine();

                        if(!string.IsNullOrEmpty(datas))
                        {
                            // receive the messsage
                        }*/
            while ((byteRead = client.GetStream().Read(buffer , 0, 1000)) > 0)
            {
                Message message = Serialization.Deserialize((Message)buffer);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using TestRPSServer.Configs;

namespace TestRPSServer
{
    class Program
    {
        static void Main(string[] args)
        {
            Config config = new Config($"{Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)}\\server.ini");
            TcpServer server = new TcpServer(Config.serverIpAddress, Config.serverPort);
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace TestRPSServer
{
    class Program
    {
        static void Main(string[] args)
        {
            TcpServer server = new TcpServer(4444);

        }

    }
}

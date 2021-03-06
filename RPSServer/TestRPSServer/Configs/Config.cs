using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestRPSServer.Configs
{
    class Config
    {
        public Config(string fileName)
        {
            INIFile ini = new INIFile(fileName);
            serverIpAddress = ini.IniReadValue("SERVER", "IpAddress");
            serverPort = int.Parse(ini.IniReadValue("SERVER", "Port"));
            numberOfPlayerPerGame = int.Parse(ini.IniReadValue("SERVER", "numberOfPlayerPerGame"));
        }

        public static string  serverIpAddress {get; set;}
        public static int  serverPort {get; set;}
        public static int  numberOfPlayerPerGame {get; set;}
    }
}

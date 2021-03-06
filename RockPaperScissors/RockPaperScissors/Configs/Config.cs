using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RockPaperScissors.Utils;

namespace RockPaperScissors.Configs
{
    class Config
    {
        public Config(string fileName)
        {
            INIFile ini = new INIFile(fileName);
            serverIpAddress = ini.IniReadValue("SERVER", "IpAddress");
            serverPort = int.Parse(ini.IniReadValue("SERVER", "Port"));
        }

        public string serverIpAddress { get; set; }

        public int serverPort { get; set; }

        public int numberOfPlayerInAGame { get; set; }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    public class TcpClients
    {
        private TcpClient _tcpClient;
        private string _ipAdress;
        private int _port;

        public TcpClients(string IpAdress, int port)
        {
            _ipAdress = IpAdress;
            _port = port;
            Retry();
        }

        public void Retry()
        {
            try
            {
                _tcpClient = new TcpClient();
                _tcpClient.Connect(_ipAdress, _port);
            }
            catch
            {
            }
        }

        public bool IsConnected
        {
            get
            {
                try
                {
                    if (_tcpClient != null && _tcpClient.Client != null && _tcpClient.Client.Connected)
                    {
                        /* pear to the documentation on Poll:
                         * When passing SelectMode.SelectRead as a parameter to the Poll method it will return 
                         * -either- true if Socket.Listen(Int32) has been called and a connection is pending;
                         * -or- true if data is available for reading; 
                         * -or- true if the connection has been closed, reset, or terminated; 
                         * otherwise, returns false
                         */

                        // Detect if client disconnected
                        if (_tcpClient.Client.Poll(0, SelectMode.SelectRead))
                        {
                            byte[] buff = new byte[1];
                            if (_tcpClient.Client.Receive(buff, SocketFlags.Peek) == 0)
                            {
                                // Client disconnected
                                return false;
                            }
                            else
                            {
                                return true;
                            }
                        }

                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                catch
                {
                    return false;
                }
            }
        }
    }
}

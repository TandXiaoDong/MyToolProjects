using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;

namespace RC_InterfaceService
{
    public class PortDataConfig
    {
        public string PortName { get; set; }
        public int BaudRate { get; set; }
        public int ServerPort { get; set; }
        public Parity Parity { get; set; }
        public int DataBits { get; set; }
        public StopBits StopBits { get; set; }
        public string Serverforward { get; set; }
    }
}

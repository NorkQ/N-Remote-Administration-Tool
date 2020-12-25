using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NRat
{
    [System.Serializable]
    public class ConnectionData
    {
        public string ip;
        public int port;

        public ConnectionData() { }

        public ConnectionData(string ip, int port)
        {
            this.ip = ip;
            this.port = port;
        }
    }
}

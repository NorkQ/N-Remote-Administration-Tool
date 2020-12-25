using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NRat
{
    [Serializable]
    public class ClientElement
    {
        public string ip;
        public string os;
        public string name;

        public ClientElement() { }

        public ClientElement(string ip, string os, string name)
        {
            this.ip = ip;
            this.os = os;
            this.name = name;

        }
    }
}

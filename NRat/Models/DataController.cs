using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.IO;

namespace NRat
{
    class DataController
    {
        public static void SaveConnData(ConnectionData connData)
        {
            File.WriteAllText("conn.dat", new JavaScriptSerializer().Serialize(connData));
        }

        public static ConnectionData LoadConnData()
        {
            if (File.Exists("conn.dat"))
            {
                return new JavaScriptSerializer().Deserialize<ConnectionData>(File.ReadAllText("conn.dat"));
            }
            else return new ConnectionData("Null", 0000);
        }
    }
}

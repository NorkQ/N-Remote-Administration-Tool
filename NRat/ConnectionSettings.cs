using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NRat
{
    public partial class ConnectionSettings : Form
    {
        public ConnectionSettings()
        {
            InitializeComponent();
        }

        private void save_Click(object sender, EventArgs e)
        {
            string ip = ipAddr.Text;
            int portNumber = (int)port.Value;

            if(ip != "" && portNumber > 0)
            {
                DialogResult dialog = new DialogResult();
                dialog = MessageBox.Show("Bütün bağlantıların gidecek. Emin misin ?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialog == DialogResult.Yes)
                {
                    ConnectionData connData = new ConnectionData(ip, portNumber);
                    DataController.SaveConnData(connData);

                    MessageBox.Show("Kaydedildi ! Şimdi yazılımı yeniden başlatmalısın.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    Console.WriteLine("Onaylanmadı");
                }
   
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NRat.Models.Server;

namespace NRat
{
    public partial class MainWindow : Form
    {
        private int selectedRow;
        private Server server;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            ConnectionData connData = DataController.LoadConnData();
            this.connDataLabel.Text = "IP : " + connData.ip + " - " + "PORT : " + connData.port.ToString();

            server = new Server(this);
        }

        private void Clients_RightClicked(object sender, MouseEventArgs e)
        {
            try
            {
                if (e.Button == MouseButtons.Right)
                {
                    var hti = this.Clients.HitTest(e.X, e.Y);
                    this.Clients.ClearSelection();
                    this.Clients.Rows[hti.RowIndex].Selected = true;
                    selectedRow = hti.RowIndex;

                    clientRightClick.Show(Cursor.Position);
                }
            }
            catch
            {
                Console.WriteLine("Sağ");
            }
        }

        private void copyIPAddress_Click(object sender, EventArgs e)
        {
            string value = this.Clients.Rows[selectedRow].Cells["ip_addr"].Value.ToString();
            Clipboard.SetDataObject(value);
        }

        private void copyOS_Click(object sender, EventArgs e)
        {
            string value = this.Clients.Rows[selectedRow].Cells["os_info"].Value.ToString();
            Clipboard.SetDataObject(value);
        }

        private void copyName_Click(object sender, EventArgs e)
        {
            string value = this.Clients.Rows[selectedRow].Cells["username"].Value.ToString();
            Clipboard.SetDataObject(value);
        }

        private void ButtonBG(object sender, EventArgs e)
        {
            Button _sender = sender as Button;
            _sender.BackColor = this.panel1.BackColor;
        }

        private void conn_settings_Click(object sender, EventArgs e)
        {
            ConnectionSettings connSett = new ConnectionSettings();
            connSett.Show();
        }
    }
}
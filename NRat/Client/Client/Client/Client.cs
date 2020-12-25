using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class ClientMain : Form
    {
        private ClientBack client;

        public ClientMain()
        {
            InitializeComponent();
        }

        private void ClientMain_Load(object sender, EventArgs e)
        {
            client = new ClientBack(this);
        }
    }
}

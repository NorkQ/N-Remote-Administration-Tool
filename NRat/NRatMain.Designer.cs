using System.Drawing;

namespace NRat
{
    partial class MainWindow
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Clients = new System.Windows.Forms.DataGridView();
            this.ip_addr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.os_info = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientRightClick = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyToolContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyIPAddress = new System.Windows.Forms.ToolStripMenuItem();
            this.copyOS = new System.Windows.Forms.ToolStripMenuItem();
            this.copyName = new System.Windows.Forms.ToolStripMenuItem();
            this.uyarıGönderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.conn_settings = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.connDataLabel = new System.Windows.Forms.Label();
            this.create_client = new System.Windows.Forms.Button();
            this.console = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Clients)).BeginInit();
            this.clientRightClick.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Clients
            // 
            this.Clients.BackgroundColor = System.Drawing.Color.White;
            this.Clients.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.Clients.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Clients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Clients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ip_addr,
            this.os_info,
            this.username});
            this.Clients.EnableHeadersVisualStyles = false;
            this.Clients.GridColor = System.Drawing.Color.Black;
            this.Clients.Location = new System.Drawing.Point(12, 42);
            this.Clients.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Clients.Name = "Clients";
            this.Clients.RowTemplate.Height = 40;
            this.Clients.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Clients.Size = new System.Drawing.Size(760, 427);
            this.Clients.TabIndex = 1;
            this.Clients.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Clients_RightClicked);
            // 
            // ip_addr
            // 
            this.ip_addr.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ip_addr.HeaderText = "IP Adresi";
            this.ip_addr.Name = "ip_addr";
            this.ip_addr.ReadOnly = true;
            this.ip_addr.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // os_info
            // 
            this.os_info.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.os_info.HeaderText = "İşletim Sistemi";
            this.os_info.Name = "os_info";
            this.os_info.ReadOnly = true;
            this.os_info.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // username
            // 
            this.username.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.username.HeaderText = "Kullanıcı Adı";
            this.username.Name = "username";
            this.username.ReadOnly = true;
            this.username.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // clientRightClick
            // 
            this.clientRightClick.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolContextMenuItem,
            this.uyarıGönderToolStripMenuItem});
            this.clientRightClick.Name = "clientRightClick";
            this.clientRightClick.Size = new System.Drawing.Size(144, 48);
            // 
            // copyToolContextMenuItem
            // 
            this.copyToolContextMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyIPAddress,
            this.copyOS,
            this.copyName});
            this.copyToolContextMenuItem.Name = "copyToolContextMenuItem";
            this.copyToolContextMenuItem.Size = new System.Drawing.Size(143, 22);
            this.copyToolContextMenuItem.Text = "Kopyala";
            // 
            // copyIPAddress
            // 
            this.copyIPAddress.Name = "copyIPAddress";
            this.copyIPAddress.Size = new System.Drawing.Size(150, 22);
            this.copyIPAddress.Text = "IP Adres";
            this.copyIPAddress.Click += new System.EventHandler(this.copyIPAddress_Click);
            // 
            // copyOS
            // 
            this.copyOS.Name = "copyOS";
            this.copyOS.Size = new System.Drawing.Size(150, 22);
            this.copyOS.Text = "İşletim Sistemi";
            this.copyOS.Click += new System.EventHandler(this.copyOS_Click);
            // 
            // copyName
            // 
            this.copyName.Name = "copyName";
            this.copyName.Size = new System.Drawing.Size(150, 22);
            this.copyName.Text = "İsim";
            this.copyName.Click += new System.EventHandler(this.copyName_Click);
            // 
            // uyarıGönderToolStripMenuItem
            // 
            this.uyarıGönderToolStripMenuItem.Name = "uyarıGönderToolStripMenuItem";
            this.uyarıGönderToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.uyarıGönderToolStripMenuItem.Text = "Uyarı Gönder";
            // 
            // conn_settings
            // 
            this.conn_settings.BackColor = System.Drawing.Color.Transparent;
            this.conn_settings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.conn_settings.FlatAppearance.BorderSize = 0;
            this.conn_settings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.conn_settings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.conn_settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.conn_settings.ForeColor = System.Drawing.Color.White;
            this.conn_settings.Location = new System.Drawing.Point(3, 1);
            this.conn_settings.Name = "conn_settings";
            this.conn_settings.Size = new System.Drawing.Size(139, 25);
            this.conn_settings.TabIndex = 2;
            this.conn_settings.Text = "Bağlantı Ayarları";
            this.conn_settings.UseVisualStyleBackColor = false;
            this.conn_settings.Click += new System.EventHandler(this.conn_settings_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.connDataLabel);
            this.panel1.Controls.Add(this.create_client);
            this.panel1.Controls.Add(this.conn_settings);
            this.panel1.Location = new System.Drawing.Point(12, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(760, 31);
            this.panel1.TabIndex = 3;
            // 
            // connDataLabel
            // 
            this.connDataLabel.AutoSize = true;
            this.connDataLabel.ForeColor = System.Drawing.Color.Tomato;
            this.connDataLabel.Location = new System.Drawing.Point(293, 5);
            this.connDataLabel.Name = "connDataLabel";
            this.connDataLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.connDataLabel.Size = new System.Drawing.Size(182, 17);
            this.connDataLabel.TabIndex = 4;
            this.connDataLabel.Text = "IP : 192.168.1.1 - PORT : 4545";
            this.connDataLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // create_client
            // 
            this.create_client.BackColor = System.Drawing.Color.Transparent;
            this.create_client.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.create_client.FlatAppearance.BorderSize = 0;
            this.create_client.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.create_client.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.create_client.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.create_client.ForeColor = System.Drawing.Color.White;
            this.create_client.Location = new System.Drawing.Point(148, 1);
            this.create_client.Name = "create_client";
            this.create_client.Size = new System.Drawing.Size(139, 25);
            this.create_client.TabIndex = 3;
            this.create_client.Text = "İstemci Oluştur";
            this.create_client.UseVisualStyleBackColor = false;
            this.create_client.MouseHover += new System.EventHandler(this.ButtonBG);
            // 
            // console
            // 
            this.console.BackColor = System.Drawing.Color.Black;
            this.console.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.console.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.console.ForeColor = System.Drawing.Color.Lime;
            this.console.Location = new System.Drawing.Point(12, 476);
            this.console.Name = "console";
            this.console.ReadOnly = true;
            this.console.Size = new System.Drawing.Size(760, 123);
            this.console.TabIndex = 4;
            this.console.Text = "";
            this.console.UseWaitCursor = true;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 611);
            this.ContextMenuStrip = this.clientRightClick;
            this.Controls.Add(this.console);
            this.Controls.Add(this.Clients);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainWindow";
            this.Text = "NorkQ Remote Administration Tool";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Clients)).EndInit();
            this.clientRightClick.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView Clients;
        private System.Windows.Forms.ContextMenuStrip clientRightClick;
        private System.Windows.Forms.ToolStripMenuItem copyToolContextMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyIPAddress;
        private System.Windows.Forms.ToolStripMenuItem copyOS;
        private System.Windows.Forms.ToolStripMenuItem copyName;
        private System.Windows.Forms.Button conn_settings;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ip_addr;
        private System.Windows.Forms.DataGridViewTextBoxColumn os_info;
        private System.Windows.Forms.DataGridViewTextBoxColumn username;
        private System.Windows.Forms.Button create_client;
        private System.Windows.Forms.ToolStripMenuItem uyarıGönderToolStripMenuItem;
        private System.Windows.Forms.Label connDataLabel;
        private System.Windows.Forms.RichTextBox console;

        public void WriteConsole(string text)
        {
            console.AppendText(text + "\r\n");
            console.ScrollToCaret();
        }
    }
}


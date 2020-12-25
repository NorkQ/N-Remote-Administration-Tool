
namespace NRat
{
    partial class ConnectionSettings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ipAddr = new System.Windows.Forms.TextBox();
            this.port = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.save = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.port)).BeginInit();
            this.SuspendLayout();
            // 
            // ipAddr
            // 
            this.ipAddr.Location = new System.Drawing.Point(12, 23);
            this.ipAddr.Name = "ipAddr";
            this.ipAddr.Size = new System.Drawing.Size(171, 20);
            this.ipAddr.TabIndex = 0;
            // 
            // port
            // 
            this.port.Location = new System.Drawing.Point(189, 23);
            this.port.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.port.Name = "port";
            this.port.Size = new System.Drawing.Size(91, 20);
            this.port.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "IP Adresi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(254, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Port";
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.Color.Black;
            this.save.FlatAppearance.BorderSize = 0;
            this.save.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save.ForeColor = System.Drawing.Color.White;
            this.save.Location = new System.Drawing.Point(12, 49);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(268, 23);
            this.save.TabIndex = 4;
            this.save.Text = "Kaydet";
            this.save.UseVisualStyleBackColor = false;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // ConnectionSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 77);
            this.Controls.Add(this.save);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.port);
            this.Controls.Add(this.ipAddr);
            this.Name = "ConnectionSettings";
            this.Text = "Bağlantı Ayarlarını Düzenle";
            ((System.ComponentModel.ISupportInitialize)(this.port)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ipAddr;
        private System.Windows.Forms.NumericUpDown port;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button save;
    }
}
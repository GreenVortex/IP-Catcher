namespace Ofi
{
    partial class ServerConfig
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
            this.Hostname = new System.Windows.Forms.TextBox();
            this.HostReolve = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.IPList = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Hostname
            // 
            this.Hostname.Location = new System.Drawing.Point(12, 47);
            this.Hostname.Name = "Hostname";
            this.Hostname.Size = new System.Drawing.Size(181, 20);
            this.Hostname.TabIndex = 0;
            this.Hostname.TextChanged += new System.EventHandler(this.Hostname_TextChanged);
            // 
            // HostReolve
            // 
            this.HostReolve.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(104)))), ((int)(((byte)(162)))));
            this.HostReolve.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.HostReolve.Location = new System.Drawing.Point(14, 277);
            this.HostReolve.Name = "HostReolve";
            this.HostReolve.Size = new System.Drawing.Size(181, 34);
            this.HostReolve.TabIndex = 1;
            this.HostReolve.Text = "Resolve";
            this.HostReolve.UseVisualStyleBackColor = false;
            this.HostReolve.Click += new System.EventHandler(this.HostReolve_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(88, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Host";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // IPList
            // 
            this.IPList.FormattingEnabled = true;
            this.IPList.Location = new System.Drawing.Point(14, 98);
            this.IPList.Name = "IPList";
            this.IPList.Size = new System.Drawing.Size(181, 173);
            this.IPList.TabIndex = 3;
            this.IPList.SelectedIndexChanged += new System.EventHandler(this.IPList_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = global::Ofi.Properties.Resources.closebtn;
            this.pictureBox1.Location = new System.Drawing.Point(159, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 42);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // ServerConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(207, 323);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.IPList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.HostReolve);
            this.Controls.Add(this.Hostname);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ServerConfig";
            this.Text = "ServerConfig";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ServerConfig_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ServerConfig_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Hostname;
        private System.Windows.Forms.Button HostReolve;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox IPList;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
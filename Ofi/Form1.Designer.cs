namespace Ofi
{
    partial class window
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
            this.ipshow = new System.Windows.Forms.Label();
            this.ipbox = new System.Windows.Forms.TextBox();
            this.ServerCheck = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Refresh = new System.Windows.Forms.Button();
            this.NetReport = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ServerBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.GatewayBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ipshow
            // 
            this.ipshow.AutoSize = true;
            this.ipshow.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ipshow.Location = new System.Drawing.Point(105, 63);
            this.ipshow.Name = "ipshow";
            this.ipshow.Size = new System.Drawing.Size(46, 13);
            this.ipshow.TabIndex = 0;
            this.ipshow.Text = "Local IP";
            // 
            // ipbox
            // 
            this.ipbox.Location = new System.Drawing.Point(29, 40);
            this.ipbox.Name = "ipbox";
            this.ipbox.ReadOnly = true;
            this.ipbox.Size = new System.Drawing.Size(203, 20);
            this.ipbox.TabIndex = 1;
            this.ipbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ServerCheck
            // 
            this.ServerCheck.ForeColor = System.Drawing.Color.White;
            this.ServerCheck.Location = new System.Drawing.Point(29, 79);
            this.ServerCheck.Name = "ServerCheck";
            this.ServerCheck.ReadOnly = true;
            this.ServerCheck.Size = new System.Drawing.Size(203, 20);
            this.ServerCheck.TabIndex = 3;
            this.ServerCheck.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(82, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Internet Connection";
            // 
            // Refresh
            // 
            this.Refresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(104)))), ((int)(((byte)(162)))));
            this.Refresh.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Refresh.Location = new System.Drawing.Point(29, 130);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(203, 42);
            this.Refresh.TabIndex = 5;
            this.Refresh.Text = "Refresh";
            this.Refresh.UseVisualStyleBackColor = false;
            this.Refresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // NetReport
            // 
            this.NetReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(104)))), ((int)(((byte)(162)))));
            this.NetReport.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.NetReport.Location = new System.Drawing.Point(29, 178);
            this.NetReport.Name = "NetReport";
            this.NetReport.Size = new System.Drawing.Size(203, 42);
            this.NetReport.TabIndex = 6;
            this.NetReport.Text = "NetReport";
            this.NetReport.UseVisualStyleBackColor = false;
            this.NetReport.Click += new System.EventHandler(this.NetReport_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Ofi.Properties.Resources.closebtn;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(240, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 35);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // ServerBtn
            // 
            this.ServerBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(104)))), ((int)(((byte)(162)))));
            this.ServerBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ServerBtn.Location = new System.Drawing.Point(15, 276);
            this.ServerBtn.Name = "ServerBtn";
            this.ServerBtn.Size = new System.Drawing.Size(238, 25);
            this.ServerBtn.TabIndex = 12;
            this.ServerBtn.Text = "Resolve Hostname";
            this.ServerBtn.UseVisualStyleBackColor = false;
            this.ServerBtn.Click += new System.EventHandler(this.ServerBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Version: Beta 1.8";
            // 
            // GatewayBtn
            // 
            this.GatewayBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(104)))), ((int)(((byte)(162)))));
            this.GatewayBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.GatewayBtn.Location = new System.Drawing.Point(29, 226);
            this.GatewayBtn.Name = "GatewayBtn";
            this.GatewayBtn.Size = new System.Drawing.Size(203, 42);
            this.GatewayBtn.TabIndex = 14;
            this.GatewayBtn.Text = "Login Gateway";
            this.GatewayBtn.UseVisualStyleBackColor = false;
            this.GatewayBtn.Click += new System.EventHandler(this.GatewayBtn_Click);
            // 
            // window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(30)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(274, 313);
            this.Controls.Add(this.GatewayBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ServerBtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.NetReport);
            this.Controls.Add(this.Refresh);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ServerCheck);
            this.Controls.Add(this.ipbox);
            this.Controls.Add(this.ipshow);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "window";
            this.Text = "IP Catcher";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.window_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.window_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ipshow;
        private System.Windows.Forms.TextBox ipbox;
        private System.Windows.Forms.MaskedTextBox ServerCheck;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Refresh;
        private System.Windows.Forms.Button NetReport;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button ServerBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button GatewayBtn;
    }
}


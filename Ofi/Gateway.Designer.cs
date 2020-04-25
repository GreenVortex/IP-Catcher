namespace Ofi
{
    partial class Gateway
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Browser = new System.Windows.Forms.WebBrowser();
            this.IpDisplay = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Access = new System.Windows.Forms.Button();
            this.ZoomOut = new System.Windows.Forms.Button();
            this.ZoomIn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Ofi.Properties.Resources.closebtn;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(1152, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 35);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Browser
            // 
            this.Browser.Location = new System.Drawing.Point(12, 44);
            this.Browser.MinimumSize = new System.Drawing.Size(20, 20);
            this.Browser.Name = "Browser";
            this.Browser.Size = new System.Drawing.Size(1166, 489);
            this.Browser.TabIndex = 1;
            // 
            // IpDisplay
            // 
            this.IpDisplay.Location = new System.Drawing.Point(998, 562);
            this.IpDisplay.Name = "IpDisplay";
            this.IpDisplay.ReadOnly = true;
            this.IpDisplay.Size = new System.Drawing.Size(136, 20);
            this.IpDisplay.TabIndex = 2;
            this.IpDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(1039, 585);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Gateway IP";
            // 
            // Access
            // 
            this.Access.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(104)))), ((int)(((byte)(162)))));
            this.Access.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Access.Location = new System.Drawing.Point(443, 554);
            this.Access.Name = "Access";
            this.Access.Size = new System.Drawing.Size(203, 42);
            this.Access.TabIndex = 4;
            this.Access.Text = "Access";
            this.Access.UseVisualStyleBackColor = false;
            this.Access.Click += new System.EventHandler(this.Access_Click);
            // 
            // ZoomOut
            // 
            this.ZoomOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(104)))), ((int)(((byte)(162)))));
            this.ZoomOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ZoomOut.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ZoomOut.Location = new System.Drawing.Point(160, 550);
            this.ZoomOut.Name = "ZoomOut";
            this.ZoomOut.Size = new System.Drawing.Size(42, 42);
            this.ZoomOut.TabIndex = 5;
            this.ZoomOut.Text = "-";
            this.ZoomOut.UseVisualStyleBackColor = false;
            this.ZoomOut.Click += new System.EventHandler(this.ZoomOut_Click);
            // 
            // ZoomIn
            // 
            this.ZoomIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(104)))), ((int)(((byte)(162)))));
            this.ZoomIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ZoomIn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ZoomIn.Location = new System.Drawing.Point(98, 550);
            this.ZoomIn.Name = "ZoomIn";
            this.ZoomIn.Size = new System.Drawing.Size(42, 42);
            this.ZoomIn.TabIndex = 6;
            this.ZoomIn.Text = "+";
            this.ZoomIn.UseVisualStyleBackColor = false;
            this.ZoomIn.Click += new System.EventHandler(this.ZoomIn_Click);
            // 
            // Gateway
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(30)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(1190, 615);
            this.Controls.Add(this.ZoomIn);
            this.Controls.Add(this.ZoomOut);
            this.Controls.Add(this.Access);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IpDisplay);
            this.Controls.Add(this.Browser);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Gateway";
            this.Text = "Gateway";
            this.Load += new System.EventHandler(this.Gateway_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Gateway_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Gateway_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.WebBrowser Browser;
        private System.Windows.Forms.TextBox IpDisplay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Access;
        private System.Windows.Forms.Button ZoomOut;
        private System.Windows.Forms.Button ZoomIn;
    }
}
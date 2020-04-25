using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Net.NetworkInformation;
using System.IO;
using System.Diagnostics;

namespace Ofi
{
    public partial class window : Form
    {
        public window()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            IPGet();
            OnlineCheck();
        }

        public void NetReportGen()
        {
            //Report Storage Management
            string Today = DateTime.Today.ToString("dd-MM-yyyy");
            string ReportFile = "Report " + Today + ".log";
            if (File.Exists(ReportFile))
            {
                File.Delete(ReportFile);
            }
            //Report managment
            using (FileStream fs = File.Create(ReportFile))
            {
                Process IpConfig = new Process();
                IpConfig.StartInfo.UseShellExecute = false;
                IpConfig.StartInfo.RedirectStandardOutput = true;
                IpConfig.StartInfo.FileName = "ipconfig.exe";
                IpConfig.StartInfo.CreateNoWindow = true;
                IpConfig.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                IpConfig.Start();
                IpConfig.WaitForExit();
                string IpConfigOutput = IpConfig.StandardOutput.ReadToEnd();
                Byte[] info = new UTF8Encoding(true).GetBytes(IpConfigOutput);
                fs.Write(info, 0, info.Length);
            }
            //Open Report
            System.Diagnostics.Process.Start(ReportFile);
        }
        public void IPGet()
        {
            //Local IP Start
            ipbox.ResetText();
            IPHostEntry IPHost;
            IPHost = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in IPHost.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                   ipbox.AppendText(ip.ToString());
                }
            }
            
        }
        //Local IP End

        public void OnlineCheck()
        {
            //User Online?
            try
            {
                Ping pingSender = new Ping();
                string PingedHost = "1.1.1.1";
                PingReply reply = pingSender.Send(PingedHost);
                if (reply.Status == IPStatus.Success)
                {
                    ServerCheck.BackColor = Color.ForestGreen;
                    ServerCheck.ResetText();
                    ServerCheck.AppendText("Online");
                    NetReport.BackColor = Color.ForestGreen;
                    NetReport.Enabled = true;
                }
                else
                {
                    ServerCheck.BackColor = Color.OrangeRed;
                    ServerCheck.ResetText();
                    ServerCheck.AppendText("Offline");
                    NetReport.BackColor = Color.OrangeRed;
                    NetReport.ForeColor = Color.White;                  
                    NetReport.Enabled = false;
                }
            }
            catch (System.Net.NetworkInformation.PingException)
            {
                Console.Write("A Network related  error ocuured");
            }
            //User Online? End
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            IPGet();
            OnlineCheck();
        }

        private void NetReport_Click(object sender, EventArgs e)
        {
            NetReportGen();
        }

        //Window Functions 
        //(Dragable)
        Point lastPoint;
        private void window_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void window_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
        //Window Fuction End

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ServerBtn_Click(object sender, EventArgs e)
        {
            ServerConfig ServerConfiguration = new ServerConfig();
            ServerConfiguration.Show();
        }

        private void GatewayBtn_Click(object sender, EventArgs e)
        {
            Gateway GatewayAccess = new Gateway();
            GatewayAccess.Show();
        }
    }
}

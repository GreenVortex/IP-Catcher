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
    public partial class ServerConfig : Form
    {
        public ServerConfig()
        {
            InitializeComponent();
        }

        Point lastPoint;
        private void ServerConfig_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void ServerConfig_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void HostReolve_Click(object sender, EventArgs e)
        {
            IPList.Items.Clear();
            string Host = null;
            Host = Hostname.Text;
            IPAddress[] addresslist = Dns.GetHostAddresses(Host);

            foreach (IPAddress theaddress in addresslist)
            {
               IPList.Items.Add(theaddress.ToString());
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Hostname_TextChanged(object sender, EventArgs e)
        {

        }

        private void IPList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

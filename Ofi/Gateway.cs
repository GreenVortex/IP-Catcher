using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ofi
{
    public partial class Gateway : Form
    {
        public Gateway()
        {
            InitializeComponent();
        }

        private void Gateway_Load(object sender, EventArgs e)
        {
            //On Form Load
        }

        public static IPAddress GetDefaultGateway()
        {
            return NetworkInterface
                .GetAllNetworkInterfaces() //Gets all network adapters
                .Where(n => n.OperationalStatus == OperationalStatus.Up) //Selects from enabled
                .Where(n => n.NetworkInterfaceType != NetworkInterfaceType.Loopback) 
                .SelectMany(n => n.GetIPProperties()?.GatewayAddresses) //Gets Gateway IP
                .Select(g => g?.Address)
                .Where(a => a != null)
                .FirstOrDefault(); //Selectsfirst or default
        }

        private void Access_Click(object sender, EventArgs e)
        {
            var GatewayIP = GetDefaultGateway(); //Assaign value from GetDefaultGateway Function to a variable 
            String GatewayString = GatewayIP.ToString(); //Convert from IPAddress objecttype to string
            this.Browser.Navigate(GatewayString); //Pass the value to the browser (Automatically converts string to URI)
            IpDisplay.Text = GatewayString; //Display Gateway IP in text box
        }

        //Selet Browser Componment and simulate Ctr + (+) input for zoom in
        private void ZoomIn_Click(object sender, EventArgs e)
        {
            Browser.Focus();
            SendKeys.Send("^{+}");
        }

        //Selet Browser Componment and simulate Ctr + (-) input for zoom out
        private void ZoomOut_Click(object sender, EventArgs e)
        {
            Browser.Focus();
            SendKeys.Send("^{-}");
        }

        //Exit Button
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        //Borderless Window
        Point lastPoint;
        private void Gateway_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void Gateway_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
    }
}

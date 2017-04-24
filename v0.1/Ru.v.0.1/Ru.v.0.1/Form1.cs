using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.NetworkInformation;

namespace Ru.v._0._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool pinging = false;
            Ping isPing = new Ping();

            try
            {

                PingReply reply = isPing.Send(textBox1.Text);
                pinging = reply.Status == IPStatus.Success;

            }
            catch (PingException)
            {
                // Return False


            }
        }
    }
}

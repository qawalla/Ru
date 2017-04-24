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


namespace Ru.v._0._1b
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 1; ++i)
            {

                using (Ping p = new Ping())
                {
                    listView1.Items.Add(p.Send(textBox1.Text).RoundtripTime.ToString() + "ms/n");
                }
            }
        }
    }
}

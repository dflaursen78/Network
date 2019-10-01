using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Osi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rb_Layer1_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            if (sender.Equals(rb_Layer1))
            {
                if( ((RadioButton)sender).Checked)
                {
                    richTextBox1.AppendText("Physical" + Environment.NewLine + Environment.NewLine);
                    richTextBox1.AppendText("Cables RJ45, Connectors and Hubs" + Environment.NewLine + Environment.NewLine);
                    richTextBox1.AppendText("Bits are moved here");
                }
            }
           
            else if (sender.Equals(rb_Layer2))
            {
                if (((RadioButton)sender).Checked)
                {
                    richTextBox1.AppendText("Data Link" + Environment.NewLine + Environment.NewLine);
                    richTextBox1.AppendText("Ethernet, MAC Adresses and Switches" + Environment.NewLine + Environment.NewLine);
                    richTextBox1.AppendText("Frames are moved here");

                }
            }
            else if (sender.Equals(rb_Layer3))
            {
                if (((RadioButton)sender).Checked)
                {
                    richTextBox1.AppendText("Network" + Environment.NewLine + Environment.NewLine);
                    richTextBox1.AppendText("Router, Ipv4, Ipv6, Arp" + Environment.NewLine + Environment.NewLine);
                    richTextBox1.AppendText("Packets are moved here");
                }
            }
            else if (sender.Equals(rb_Layer4))
            {
                if (((RadioButton)sender).Checked)
                {
                    richTextBox1.AppendText("Transport" + Environment.NewLine + Environment.NewLine);
                    richTextBox1.AppendText("TCP, UDP" + Environment.NewLine + Environment.NewLine);
                    richTextBox1.AppendText("Segments are moved here");
                }
            }
            else if (sender.Equals(rb_Layer5))
            {
                if (((RadioButton)sender).Checked)
                {
                    richTextBox1.AppendText("Session" + Environment.NewLine + Environment.NewLine);
                    richTextBox1.AppendText("Netbios, Provides dialog control between hosts");
                }
            }
            if (sender.Equals(rb_Layer6))
            {
                if (((RadioButton)sender).Checked)
                {
                    richTextBox1.AppendText("Presentation" + Environment.NewLine + Environment.NewLine);
                    richTextBox1.AppendText("Presents Data, Handles incryptions and decryption");
                }
            }
            else if (sender.Equals(rb_Layer7))
            {
                if (((RadioButton)sender).Checked)
                {
                    richTextBox1.AppendText("Application" + Environment.NewLine + Environment.NewLine);
                    richTextBox1.AppendText("Provides a user interface, DNS, HTTP, ");
                }
            }
            else
            {

            }
        }
    }
}

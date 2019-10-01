using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IP_GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cb_SubnetBits.SelectedIndex = 0;
            cb_HostPerSubnet.Items.Add("16777214");
            cb_HostPerSubnet.Items.Add("8388606");
            cb_HostPerSubnet.Items.Add("4194302");
            cb_HostPerSubnet.Items.Add("2097150");
            cb_HostPerSubnet.Items.Add("1048574");
            cb_HostPerSubnet.Items.Add("524286");
            cb_HostPerSubnet.Items.Add("262142");
            cb_HostPerSubnet.Items.Add("131070");
        }

        private void cb_SubnetMask_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cb_HostPerSubnet_SelectedIndexChanged(object sender, EventArgs e)
        {

       

        }
    }
}

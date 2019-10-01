using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IP_Classes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void EmptyAllTBS()
        {
            tb_IPRange.Text = "";
            tb_PIPRange.Text = "";
            tb_SRange.Text = "";
            tb_Res.Text = "";
        }
        private void RB_A_CheckedChanged(object sender, EventArgs e)
        {
            //empty all tbs
            EmptyAllTBS();
            
            //fill tb accordingly
            if (sender.Equals(rb_A))
            {
                if (((RadioButton)sender).Checked)
                {
                    tb_IPRange.Text = "0.0.0.0 - 127.255.255.255";
                    tb_PIPRange.Text = "14728 - 14214314";
                    tb_SRange.Text = " 255.0.0.0 ";
                }
                
            }
            if (sender.Equals(rb_B))
            {
                if (((RadioButton)sender).Checked)
                {
                    tb_IPRange.Text = "128.0.0.0 - 171.255.255.255";
                    tb_PIPRange.Text = "62736952";
                    tb_SRange.Text = "255.255.0.0";
                }
            }
            
        }

        private void rb_C_CheckedChanged(object sender, EventArgs e)
        {
            EmptyAllTBS();
            if (((RadioButton)sender).Checked)
            {
                tb_IPRange.Text = "172.0.0.0 - 191.255.255.255";
                tb_PIPRange.Text = "17483294";
                tb_SRange.Text = "255.255.255.0";
            }
        }
        private void rb_D_CheckedChanged(object sender, EventArgs e)
        {
            EmptyAllTBS();
            if (((RadioButton)sender).Checked)
            {
                tb_IPRange.Text = "71843";
                tb_Res.Text = "Multicasting";
            }
        }

        private void rb_E_CheckedChanged(object sender, EventArgs e)
        {
            //EmptyAllTBS();
            if (((RadioButton)sender).Checked)
            {
                /*tb_IPRange.Text = "123145";
                tb_Res.Text = "Recearch";*/
                FillAllTBS("123145", "", "", "Recearch");
            }
        }
        private void FillAllTBS( String ipRange, String ipPipRange, String sRange, String res)
        {
            tb_IPRange.Text = ipRange;
            tb_PIPRange.Text = ipPipRange;
            tb_SRange.Text = sRange;
            tb_Res.Text = res;
        }
    }
}

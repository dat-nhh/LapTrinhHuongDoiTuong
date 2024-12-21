using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab6
{
    public partial class Form6_2 : Form
    {
        public Form6_2()
        {
            InitializeComponent();
        }
        
        private void Form6_2_Load(object sender, EventArgs e)
        {
            rB_PTB1.Checked = true;
            txtSoC.Enabled = false;
        }

        private void btnExe_Click(object sender, EventArgs e)
        {
            float a, b, c;
            if (rB_PTB1.Checked == true)
            {
                a = float.Parse(txtSoA.Text);
                b = float.Parse(txtSoB.Text);
                PTB1 pt1 = new PTB1(a, b);
                txtKetQua.Text = pt1.Giai();
            }

                if (rB_PTB2.Checked == true)
                {
                    a = float.Parse(txtSoA.Text);
                    b = float.Parse(txtSoB.Text);
                    c = float.Parse(txtSoC.Text);
                    PTB2 pt2 = new PTB2(a, b, c);
                    txtKetQua.Text = pt2.Giai();
                }
            
        }

        private void rB_PTB2_CheckedChanged(object sender, EventArgs e)
        {
            if(rB_PTB2.Checked)
                txtSoC.Enabled = true;
            else
                txtSoC.Enabled = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

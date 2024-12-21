using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace De1
{
    public partial class Phi : Form
    {
        public Phi()
        {
            InitializeComponent();
            XeVF xe = new XeVF();
            xe.nhap();
            float phitruocba()
            {
                return a * xe.giaban();
            }
            b = phitruocba();
            xe.xuat();
            Console.WriteLine($",Phi tb: {b}");
        }
        float a, b;
        
        private void txtPhi_Leave(object sender, EventArgs e)
        {
            bool chka = float.TryParse(txtPhi.Text, out a);
            if (!chka)
                if (MessageBox.Show("Loi dinh dang\nVui long nhap lai", "Thong Bao", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    txtPhi.Clear();
                    txtPhi.Focus();
                }
            if (a<0 || a>100)
                if (MessageBox.Show("Loi dinh dang\nVui long nhap lai", "Thong Bao", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    txtPhi.Clear();
                    txtPhi.Focus();
                }
        }
        private void btnExe_Click(object sender, EventArgs e)
        {
            txtKq.Text =  (b).ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

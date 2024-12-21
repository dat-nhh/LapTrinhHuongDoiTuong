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
    public partial class Form6_1 : Form
    {
        public Form6_1()
        {
            InitializeComponent();
        }
        float a, b;
        private void congClick(object sender, EventArgs e)
        {
            txtKetQua.Text = (a + b).ToString();
        }

        private void truClick(object sender, EventArgs e)
        {
            txtKetQua.Text = (a - b).ToString();
        }

        private void nhanClick(object sender, EventArgs e)
        {
            txtKetQua.Text = (a * b).ToString();
        }

        private void chiaClick(object sender, EventArgs e)
        {
            if (b == 0)
            {
                if (MessageBox.Show("Loi dinh dang\nVui long nhap lai", "Thong Bao", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    txtSoB.Clear();
                    txtSoB.Focus();
                }
            }
            txtKetQua.Text = (a / b).ToString();
        }

        private void clearClick(object sender, EventArgs e)
        {
            txtSoA.Clear();
            txtSoB.Clear();
            txtKetQua.Clear();
        }

        private void txtA_Leave(object sender, EventArgs e)
        {
            bool chka = float.TryParse(txtSoA.Text, out a);
            if (!chka)
                if (MessageBox.Show("Loi dinh dang\nVui long nhap lai", "Thong Bao", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    txtSoA.Clear();
                    txtSoA.Focus();
                }
        }

        private void txtB_Leave(object sender, EventArgs e)
        {
            bool chkb = float.TryParse(txtSoB.Text, out b);
            if (!chkb)
                if (MessageBox.Show("Loi dinh dang\nVui long nhap lai", "Thong Bao", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    txtSoB.Clear();
                    txtSoB.Focus();
                }
        }

        private void closeClick(object sender, EventArgs e)
        {
            Close();
        }
    }
}

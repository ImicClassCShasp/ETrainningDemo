using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SECURITYs
{
    public partial class frmSecurity : Form
    {
        public frmSecurity()
        {
            InitializeComponent();
        }

        private void btnXuLy_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNhapGiaTri.Text))
            {
                MessageBox.Show("Giá trị đầu vào ko được để trống", "Thông báo");
            }
            else {
                if (chkOptions.Checked)
                {
                    txtKQ.Text = new SecurityUltils().DecryptInfo(txtNhapGiaTri.Text);
                }
                else {
                    txtKQ.Text = new SecurityUltils().EncryptInfo(txtNhapGiaTri.Text);
                }
            }
        }

        private void chkOptions_CheckedChanged(object sender, EventArgs e)
        {
            if (chkOptions.Checked)
            {
                chkOptions.Text = "Giải mã thông tin";
            }
            else {
                chkOptions.Text = "Mã hóa thông tin";
            }
        }
    }
}

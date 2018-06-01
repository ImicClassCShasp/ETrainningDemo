using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace eCenterTrainning
{
    public partial class frmEncrypt : Form
    {
        public frmEncrypt()
        {
            InitializeComponent();
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrEmpty(txtInput.Text))
            {
                MessageBox.Show("Giá trị đầu vào ko được để trống", "Thông báo");
            }
            else
            {
                MessageBox.Show("");
            }
        }

        private void frmEncrypt_Load(object sender, EventArgs e)
        {
            
            txtInput.Clear();
            txtOutput.Clear();
        }
    }
}

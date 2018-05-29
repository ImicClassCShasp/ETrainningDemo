using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Linq;

namespace eCenterTrainning
{
    public partial class frmSupportDetails : DevExpress.XtraEditors.XtraForm
    {
        public frmSupportDetails()
        {
            InitializeComponent();
        }        

        private void frmSupportDetails_Load(object sender, EventArgs e)
        {
            this.Text = "Chi tiết lịch sử hỗ trợ";
           
            lblNameHV.Enabled = false;
            lblNamHoTro.Enabled = false;
            lblInfo.Enabled = false;
            lblEmail.Enabled = false;
            lblDate.Enabled = false;
            textBoxNoiDung.Enabled = false;
        }
    }
}
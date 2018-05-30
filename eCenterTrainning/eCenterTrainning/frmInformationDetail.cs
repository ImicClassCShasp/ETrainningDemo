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
    public partial class frmInformationDetail : DevExpress.XtraEditors.XtraForm
    {
        public frmInformationDetail()
        {
            InitializeComponent();
        }        
        private void frmInformationDetail_Load(object sender, EventArgs e)
        {

        }
        void actionUpdateCV_PressHelp(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng này chưa được cập nhật", "Thông báo");
        }

        void actionUpdateCV_PressClose(object sender, EventArgs e)
        {
            this.Close();
        }

        void actionUpdateCV_PressUpdate(object sender, EventArgs e)
        {
            MessageBox.Show("");
            try
            {
                MessageBox.Show("");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace, ex.Message);
            }
        }

    }
}
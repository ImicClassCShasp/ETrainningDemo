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
    public partial class frmAddMonHoc : DevExpress.XtraEditors.XtraForm
    {        
        public frmAddMonHoc()
        {
            InitializeComponent();
        }

        private void frmAddMonHoc_Load(object sender, EventArgs e)
        {
            actionUpdateMonHoc.PressSave += new EventHandler(actionUpdateMonHoc_PressSave);
            actionUpdateMonHoc.PressRefresh += new EventHandler(actionUpdateMonHoc_PressRefresh);
            actionUpdateMonHoc.PressClose += new EventHandler(actionUpdateMonHoc_PressClose);
            actionUpdateMonHoc.PressHelp += new EventHandler(actionUpdateMonHoc_PressHelp);
            this.Text = "Thêm thông tin môn học";            
        }

        void actionUpdateMonHoc_PressHelp(object sender, EventArgs e)
        {
           
        }

        void actionUpdateMonHoc_PressClose(object sender, EventArgs e)
        {
            this.Close();
        }

        void actionUpdateMonHoc_PressRefresh(object sender, EventArgs e)
        {
            foreach (Control c in groupControl1.Controls)
            {
                if (c is DevExpress.XtraEditors.LabelControl)
                {

                }
                else
                {
                    c.Text = "";
                }
            }            
        }

        void actionUpdateMonHoc_PressSave(object sender, EventArgs e)
        {
            msgError.Dispose();
            if (string.IsNullOrEmpty(txtSubjectname.Text))
            {
                msgError.SetError(txtSubjectname, "Xin mời bạn nhập tên môn học");
                txtSubjectname.Focus();
                return;
            }
            try
            {
               
                MessageBox.Show("Cập nhật thông tin thành công", "Thông báo");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra. Chi tiết lỗi : " + ex.Message);
            }
        }          
    }
}
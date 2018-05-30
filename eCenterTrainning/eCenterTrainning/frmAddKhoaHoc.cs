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
    public partial class frmAddKhoaHoc : DevExpress.XtraEditors.XtraForm
    {        
        public frmAddKhoaHoc()
        {
            InitializeComponent();
        }

        private void frmAddKhoaHoc_Load(object sender, EventArgs e)
        {
            actionAddKhoaHoc.PressSave += new EventHandler(actionAddKhoaHoc_PressSave);
            actionAddKhoaHoc.PressRefresh += new EventHandler(actionAddKhoaHoc_PressRefresh);
            actionAddKhoaHoc.PressClose += new EventHandler(actionAddKhoaHoc_PressClose);
            actionAddKhoaHoc.PressHelp += new EventHandler(actionAddKhoaHoc_PressHelp);
            this.Text = "Thêm thông tin khóa học";            
        }

        void actionAddKhoaHoc_PressHelp(object sender, EventArgs e)
        {
            
        }

        void actionAddKhoaHoc_PressClose(object sender, EventArgs e)
        {
            this.Close();
        }

        void actionAddKhoaHoc_PressRefresh(object sender, EventArgs e)
        {
            foreach (Control c in groupControl1.Controls)
            {
                if (c is DevExpress.XtraEditors.TextEdit)
                {
                    c.Text = "";
                }
                else if (c is System.Windows.Forms.TextBox)
                {
                    c.Text = "";
                }
            }           
        }

        void actionAddKhoaHoc_PressSave(object sender, EventArgs e)
        {
            msgError.Dispose();           
            
            if (string.IsNullOrEmpty(txtCourseName.Text))
            {
                msgError.SetError(txtCourseName, "Bạn cần nhập tên khóa học trước khi thực hiện");
                txtCourseName.Focus();
                return;
            }
            if (lookUpEditSubject.Text == "---Chọn môn học---")
            {
                msgError.SetError(lookUpEditSubject, "Bạn cần chọn môn học trước khi thực hiện");
                lookUpEditSubject.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtTotalPrice.Text))
            {
                msgError.SetError(txtTotalPrice, "Bạn cần nhập tên khóa học trước khi thực hiện");
                txtTotalPrice.Focus();
                return;
            }
            try
            {
                MessageBox.Show("");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Có lỗi xảy ra. Chi tiết lỗi : " + ex.Message);
            }
        }
        /// <summary>
        /// Hiển thị học viên
        /// Author          Date            Comment
        /// hungld      03/02/2013          Tạo mới
        /// </summary>
        private void HienThiThongTinMonHoc()
        {
            MessageBox.Show("");
            lookUpEditSubject.Properties.DisplayMember = "SubjectName";
            lookUpEditSubject.Properties.ValueMember = "Id";
            
        }
    }
}
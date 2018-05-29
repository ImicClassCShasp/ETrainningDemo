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
    public partial class frmEmployee : Base.frmIMICBase
    {        
        private void frmEmployee_Load(object sender, EventArgs e)
        {
            actionUpdateEmolyee.PressUpdate += new EventHandler(actionUpdateEmolyee_PressUpdate);
            actionUpdateEmolyee.PressHelp += new EventHandler(actionUpdateEmolyee_PressHelp);
            actionUpdateEmolyee.PressClose += new EventHandler(actionUpdateEmolyee_PressClose);
            actionUpdateEmolyee.PressNew += new EventHandler(actionUpdateEmolyee_PressNew);           
            this.Text = "Thêm mới thông tin nhân viên";          
        }

        void actionUpdateEmolyee_PressNew(object sender, EventArgs e)
        {
            
        }

        void actionUpdateEmolyee_PressClose(object sender, EventArgs e)
        {
            this.Close();
        }

        void actionUpdateEmolyee_PressHelp(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng này chưa được cập nhật", "thông báo");
        }
        /// <summary>
        /// Author          Date        Comment
        /// BONGVX                      Them hoac sua thong tin nhan vien
        /// </summary>
        void actionUpdateEmolyee_PressUpdate(object sender, EventArgs e)
        {
            msgMessage.Clear();
            if (string.IsNullOrEmpty("" + txtHoTen.Text))
            {
                msgMessage.SetError(txtHoTen, "Bạn cần nhập họ tên");
                txtHoTen.Focus();
                return;
            }
            if (string.IsNullOrEmpty("" + txtEmail.Text))
            {
                msgMessage.SetError(txtEmail, "Bạn cần nhập email");
                txtEmail.Focus();
                return;
            }
            else
            {
                MessageBox.Show("");
            }

            if (string.IsNullOrEmpty("" + txtMobile.Text))
            {
                msgMessage.SetError(txtMobile, "Bạn cần nhập số di động");
                txtMobile.Focus();
                return;
            }

            if (string.IsNullOrEmpty("" + txtDiaChi.Text))
            {
                msgMessage.SetError(txtDiaChi, "Bạn cần nhập địa chỉ");
                txtDiaChi.Focus();
                return;
            }
            if (string.IsNullOrEmpty("" + lookUpEditTrungTam.EditValue))
            {
                msgMessage.SetError(lookUpEditTrungTam, "Bạn cần chọn trung tâm");
                return;
            }
            if (string.IsNullOrEmpty("" + lookUpEditPhongBan.EditValue))
            {
                msgMessage.SetError(lookUpEditPhongBan, "Bạn cần chọn phòng ban");
                return;
            }
            if (string.IsNullOrEmpty("" + lookUpEditChucVu.EditValue))
            {
                msgMessage.SetError(lookUpEditChucVu, "Bạn cần chọn chức vụ");
                return;
            }           
            this.Close();
        }
        /// <summary>
        /// Author          Date            Comment
        /// BONGVX          31/1/2013       Them moi nhan vien
        /// </summary>
        /// <returns></returns>
        private int insertEmployee()
        {
            try
            {
                MessageBox.Show("");
                return 1;
            }
            catch (Exception)
            {
                return 0;
                throw;
            }
        }        
        /// <summary>
        /// Author          Date        Comment
        /// BONGVX                      khong chinh sua thong tin cac field
        /// </summary>
        private void disablefiled()
        {
            foreach (Control c in groupControlNhanVien.Controls)
            {
                if (c is DevExpress.XtraEditors.TextEdit)
                {
                    c.Enabled = false;
                }
            }
            actionUpdateEmolyee.Enabled = false;
            btnAddMoreCenter.Enabled = false;
            btnAddMoreDepartment.Enabled = false;
            btnAddMoreJob.Enabled = false;
            txtMoTa.Enabled = false;
        }
        /// <summary>
        /// Author          Date        Comment
        /// BONGVX                      Xoa thong tin tren cac field
        /// </summary>
        private void resetAllField()
        {
            foreach (Control c in groupControlNhanVien.Controls)
            {
                if (c is DevExpress.XtraEditors.TextEdit)
                {
                    c.Text = "";
                }
            }
            txtMoTa.Text = "";
            lookUpEditChucVu.RefreshEditValue();
            lookUpEditPhongBan.RefreshEditValue();
            lookUpEditTrungTam.RefreshEditValue();
            txtHoTen.Focus();            
        }        
    }
}
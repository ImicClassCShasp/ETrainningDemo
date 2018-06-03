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
    public partial class frmThongTinChucVu : Base.frmIMICBase
    {       
        public frmThongTinChucVu()
        {
            InitializeComponent();
        }        
        private void frmThongTinChucVu_Load(object sender, EventArgs e)
        {
            actionUpdateChucVu.PressUpdate += new EventHandler(actionUpdateChucVu_PressUpdate);
            actionUpdateChucVu.PressClose += new EventHandler(actionUpdateChucVu_PressClose);
            actionUpdateChucVu.PressHelp += new EventHandler(actionUpdateChucVu_PressHelp);
            actionUpdateChucVu.PressNew += new EventHandler(actionUpdateChucVu_PressNew);
            this.Text = "Thêm mới thông tin chức vụ";
        }

        void actionUpdateChucVu_PressNew(object sender, EventArgs e)
        {
            resetAllField();
        }


        void actionUpdateChucVu_PressHelp(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng này chưa cập nhật", "Thông báo");
        }

        void actionUpdateChucVu_PressClose(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Author          Date        Comment
        /// BONGVX                      Them hoac sua thong tin chuc vu
        /// </summary>
        void actionUpdateChucVu_PressUpdate(object sender, EventArgs e)
        {
            msgMessage.Clear();
            if (string.IsNullOrEmpty("" + txtTen.Text))
            {
                msgMessage.SetError(txtTen, " Bạn cần nhập tên chức vụ trước khi thực hiện");
                this.txtTen.Focus();
                return;
            }                    
        }
        /// <summary>
        /// Author          Date        Comment
        /// BONGX           1/2/2013    them moi chuc vu
        /// </summary>
        private int insertChucVu()
        {
            try
            {                
               
                return 1;
            }
            catch (Exception)
            {
                throw;
                return 0;
            }

        }
        
        /// <summary>
        /// Author          Date        Comment
        /// BONGX           1/2/2013    Cap nhat chuc vu
        /// </summary>
        private int UpdateChucVu()
        {
            try
            {
                
                return 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace,ex.Message);
                return 0;
            }
        }
        /// <summary>
        /// Author          Date        Comment
        /// BONGX           1/2/2013    load du lieu
        /// </summary>
        private void prUpdateChucVu() {
           
        }
        
        private void btnChonLink_Click(object sender, EventArgs e)
        {
           
        }
        /// <summary>
        /// Author          Date        Comment
        /// BONGVX                      Khong chinh sua thong tin chuc vu tren field
        /// </summary>
        private void disablefiled()
        {
            foreach (Control c in groupControlChucVu.Controls)
            {
                if (c is DevExpress.XtraEditors.TextEdit)
                {
                    c.Enabled = false;
                }

            }
            actionUpdateChucVu.Enabled = false;
            btnChonLink.Enabled = false;
            txtMoTa.Enabled = false;

        }
        /// <summary>
        /// Author          Date        Comment
        /// BONGVX                      Xoa thong tin chuc vu tren field
        /// </summary>
        private void resetAllField()
        {
            foreach (Control c in groupControlChucVu.Controls)
            {
                if (c is DevExpress.XtraEditors.TextEdit)
                {
                    c.Text = "";
                }
            }
            actionUpdateChucVu.Enabled = false;
            txtMoTa.Text = "";
            txtTen.Focus();            
        } 
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Base;
using System.Collections;

namespace eCenterTrainning
{
    public partial class frmKhachHang : Base.frmIMICBase
    {
        public frmKhachHang()
        {
            InitializeComponent();
        }        
        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            actionUpdateCustomer.PressUpdate += new EventHandler(actionUpdateCustomer_PressUpdate);
            actionUpdateCustomer.PressNew += new EventHandler(actionUpdateCustomer_PressNew);
            actionUpdateCustomer.PressClose += new EventHandler(actionUpdateCustomer_PressClose);
            actionUpdateCustomer.PressHelp += new EventHandler(actionUpdateCustomer_PressHelp);            
        }

        void actionUpdateCustomer_PressHelp(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng này chưa được cập nhật","Thông Báo");
        }

        void actionUpdateCustomer_PressClose(object sender, EventArgs e)
        {
            this.Close();
        }

        void actionUpdateCustomer_PressNew(object sender, EventArgs e)
        {
            resetAllField();
        }
        /// <summary>
        /// Author          Date        Comment
        /// BONGVX                      them hoac sua thong tin khach hang
        /// </summary>
        void actionUpdateCustomer_PressUpdate(object sender, EventArgs e)
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
            else {
                MessageBox.Show("");
            }
            if (string.IsNullOrEmpty("" + txtMobile.Text))
            {
                msgMessage.SetError(txtMobile, "Bạn cần nhập số di động");
                return;
            }

            if (string.IsNullOrEmpty("" + txtDiaChi.Text))
            {
                msgMessage.SetError(txtDiaChi, "Bạn cần nhập địa chỉ");
                txtDiaChi.Focus();
                return;
            }           
            this.Close();
        }
        /// <summary>
        /// Author          Date            Comment
        /// BONGVX          24/2/2013       Them moi khach hang
        /// </summary>
        /// <returns></returns>
        private int insertCustomer()
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
        /// Author          Date            Comment
        /// BONGVX          24/2/2013       cap nhat khach hang
        /// </summary>
        private int updateCustomer()
        {
            try
            {
                MessageBox.Show("");
                return 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace, ex.Message);
                return 0;
            }
        }
        
        /// <summary>
        /// Author          Date            Comment
        /// BONGVX          24/2/2013       load thong tin khach hang vao field
        /// </summary>
        private void preUpdateCustomer()
        {
            
        }
        /// <summary>
        /// Author          Date            Comment
        /// BONGVX          24/2/2013       xoa du lieu tai cac field
        /// </summary>
        private void resetAllField()
        {
            foreach (Control c in groupControlCustomer.Controls)
            {
                if (c is DevExpress.XtraEditors.TextEdit)
                    c.Text = "";
            }
            txtGhiChu.Text = "";
            
        }
        
        /// <summary>
        /// Author          Date            Comment
        /// BONGVX          24/2/2013       an toan bao cac field
        /// </summary>
        private void disableAllField()
        {
            foreach (Control c in groupControlCustomer.Controls)
            {
                if (c is DevExpress.XtraEditors.TextEdit)
                    c.Enabled = false;
            }
            actionUpdateCustomer.Enabled = false;
            txtGhiChu.Enabled = false;
        }
    
    }

}

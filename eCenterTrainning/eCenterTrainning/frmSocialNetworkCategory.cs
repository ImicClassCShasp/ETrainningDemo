using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Linq;
using System.Collections;

namespace eCenterTrainning
{
    public partial class frmSocialNetworkCategory : Base.frmIMICBase
    {
        public frmSocialNetworkCategory()
        {
            InitializeComponent();
        }        
        private void frmSocialNetworkCategory_Load(object sender, EventArgs e)
        {
            actionUpdateSocialNetworkCategory.PressNew += new EventHandler(actionUpdateSocialNetworkCategory_PressNew);
            actionUpdateSocialNetworkCategory.PressUpdate += new EventHandler(actionUpdateSocialNetworkCategory_PressUpdate);
            actionUpdateSocialNetworkCategory.PressClose += new EventHandler(actionUpdateSocialNetworkCategory_PressClose);
            actionUpdateSocialNetworkCategory.PressHelp += new EventHandler(actionUpdateSocialNetworkCategory_PressHelp);
            this.Text = "Thêm mới danh mục";
        }

        void actionUpdateSocialNetworkCategory_PressHelp(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng này chưa được cập nhật", "Thông báo");
        }

        void actionUpdateSocialNetworkCategory_PressClose(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>     
        /// Author          Date           Comment
        /// BONGVX          18-3-2013       them moi hoac cap nhat danh muc
        /// </summary>
        void actionUpdateSocialNetworkCategory_PressUpdate(object sender, EventArgs e)
        {
            bool flagInsert = true;            
            
            msgMessage.Clear();
            if (string.IsNullOrEmpty("" + txtNameCategory.Text))
            {
                msgMessage.SetError(txtNameCategory, "Bạn hãy nhập tên danh mục trước khi thực hiện");
                txtNameCategory.Focus();
                return;
            }
            MessageBox.Show("");
            this.Close();
        }
        /// <summary>     
        /// Author          Date           Comment
        /// BONGVX          18-3-2013       lam moi
        /// </summary>
        void actionUpdateSocialNetworkCategory_PressNew(object sender, EventArgs e)
        {
            
        }

        private void checkEditChooseParent_CheckedChanged(object sender, EventArgs e)
        {
            
        }
        /// <summary>     
        /// Author          Date           Comment
        /// BONGVX          18-3-2013       kiem tra danh muc da ton tai hay chua
        /// </summary>
        private bool isExistSocialNetworkCategory() {
            try
            {                
                string param = txtNameCategory.Text.Trim().ToLower();
                
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show( ex.StackTrace,ex.Message);
                return false;
            }
        }
    }
}
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
    public partial class frmSocialNetworkAccount : Base.frmIMICBase
    {
        public frmSocialNetworkAccount()
        {
            InitializeComponent();
        }        
        private void frmSocialNetworkAccount_Load(object sender, EventArgs e)
        {
            actionUpdateSocialNetworkAccount.PressNew += new EventHandler(actionUpdateSocialNetworkAccount_PressNew);
            actionUpdateSocialNetworkAccount.PressUpdate += new EventHandler(actionUpdateSocialNetworkAccount_PressUpdate);
            actionUpdateSocialNetworkAccount.PressClose += new EventHandler(actionUpdateSocialNetworkAccount_PressClose);
            actionUpdateSocialNetworkAccount.PressHelp += new EventHandler(actionUpdateSocialNetworkAccount_PressHelp);
            loadCategory();
            this.Text = "Thêm mới tài khoản quảng bá";            
        }

        void actionUpdateSocialNetworkAccount_PressHelp(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng này chưa được cập nhật", "Thông báo");
        }

        void actionUpdateSocialNetworkAccount_PressClose(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Them moi tai khoan quang ba
        /// Author          Date           Comment
        /// BONGVX          18-3-2013       Them moi tai khoan
        /// </summary>

        void actionUpdateSocialNetworkAccount_PressUpdate(object sender, EventArgs e)
        {
            try
            {
                
                msgMessage.Clear();
                
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace, ex.Message);
            }
        }

        void actionUpdateSocialNetworkAccount_PressNew(object sender, EventArgs e)
        {

        }
        /// <summary>     
        /// Author          Date           Comment
        /// BONGVX          18-3-2013       chon anh
        /// </summary>
        OpenFileDialog ofd = new OpenFileDialog();
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            ofd.Filter = "JPEG Files (*.jpeg)|*.jpeg|PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif|All files (*.*)|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txtImagePath.Text = ofd.FileName;
            }
        }
        private bool _IsAddMore = false;

        public bool IsAddMore
        {
            get { return _IsAddMore; }
            set { _IsAddMore = value; }
        }  
        /// <summary>     
        /// Author          Date           Comment
        /// BONGVX          18-3-2013       them danh muc 
        /// </summary>
        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            frmSocialNetworkCategory frm = new frmSocialNetworkCategory();
            _IsAddMore = true;
            frm.ShowDialog();
            loadCategory();
        }
        /// <summary>     
        /// Author          Date           Comment
        /// BONGVX          18-3-2013      load danh muc cuoi cung
        /// </summary>
        private void loadCategory()
        {
            MessageBox.Show("");
            //lookUpEditCategory.Properties.DataSource = listDep;
            lookUpEditCategory.Properties.DisplayMember = "CategoryName";
            lookUpEditCategory.Properties.ValueMember = "Id";
            if (_IsAddMore)
            {
                MessageBox.Show("");
            }
        }
        /// <summary>     
        /// Author          Date           Comment
        /// BONGVX          18-3-2013       load du lieu
        /// </summary>
        private void preUpdateSocialNetworkAccount() {
            MessageBox.Show("");
        }
      
    }
}
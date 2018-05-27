using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using IMIC.SyncModule;
using IMIC.VALUEOBJECTS;
using IMIC.BUSINESSLOGICLAYERS;
using System.Configuration;

namespace eCenterTrainning
{
    public partial class frmLogin : Base.frmIMICBase
    {        
        AccountBill mAccountBill;

        public frmLogin(Account oAccount) : base(oAccount)
        {
            InitializeComponent();
            mAccountBill = new AccountBill(mAccount);
        }        

        private void frmLogin_Load(object sender, EventArgs e)
        {
            this.Text = "Đăng nhập";
            txtUserName.Text = "admin";
            txtPassword.Text = "123456";
            cboPDT.SelectedIndex = 0;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            msgMessage.Clear();
            if (string.IsNullOrEmpty("" + txtUserName.Text))
            {
                msgMessage.SetError(txtUserName, "Bạn cần nhập tên tài khoản trước khi thực hiện");
                txtUserName.Focus();
                return;
            }
            if (string.IsNullOrEmpty("" + txtPassword.Text))
            {
                msgMessage.SetError(txtPassword, "Bạn cần nhập mật khẩu trước khi thực hiện");
                txtPassword.Focus();
                return;
            }
            try
            {
                if (chkServer.Checked)
                    mAccount.isOnline = true;
                else
                    mAccount.isOnline = false;
                               
                if (cboPDT.SelectedIndex == 0)
                    mAccount.sLocation = "HaNoi";
                else
                    mAccount.sLocation = "HoChiMinh";
                mAccount.UserName = txtUserName.Text;
                mAccount.Password = Common.EncodePassword(txtPassword.Text);
                CheckLogin(mAccount);
            }
            catch (Exception ex)
            {               
                MessageBox.Show(ex.StackTrace, ex.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            mAccount.isClose = true;
            mAccount.IsSuperUser = false;
            mAccount.isSuccess = false;
            mAccount.UserId = 0;
            DialogResult h = MessageBox.Show("Bạn có muốn thoát chương trình?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (h == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        void CheckLogin(Account oAccount)
        {
            List<Account> lisAccount = mAccountBill.CheckElementByObject(oAccount);
            if (lisAccount != null && lisAccount.Count > 0)
            {
                mAccount.UserId = lisAccount[0].UserId;
                mAccount.Email = lisAccount[0].Email;
                mAccount.Phone = lisAccount[0].Phone;
                mAccount.IsSuperUser = lisAccount[0].IsSuperUser;
                mAccount.isSuccess = true;
                mAccount.Sex = lisAccount[0].Sex;
                mAccount.DisplayName = lisAccount[0].DisplayName;
                this.Close();
            }
            else
            {
                MessageBox.Show("Thông tin tài khoản không đúng vui lòng nhập lại. Tài khoản của bạn sẽ bị khóa nếu sai quá 03 lần", 
                                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtUserName.Text = "";
                txtPassword.Text = "";
                txtUserName.Focus();
            }
        }

        private void frmLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)Keys.Enter)
            {
                btnLogin_Click(sender, e);
            }
        }

        private void pictureEdit1_Click(object sender, EventArgs e)
        {
            frmAdminConfigSystem frm = new frmAdminConfigSystem();
            frm.ShowDialog();
        }
    }
}

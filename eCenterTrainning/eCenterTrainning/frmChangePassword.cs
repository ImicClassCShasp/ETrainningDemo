using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Linq;
using IMIC.SyncModule;
using IMIC.VALUEOBJECTS;
using IMIC.BUSINESSLOGICLAYERS;
namespace eCenterTrainning
{
    public partial class frmChangePassword : Base.frmIMICBase
    {
        Account ChangePassAcc;
        AccountBill mAccountBill;
        public frmChangePassword(Account oAccount, Account oChangePassAcc) : base(oAccount)
        {
            InitializeComponent();
            ChangePassAcc = oChangePassAcc;
            mAccountBill = new AccountBill(mAccount);
            txtOldPassword.Enabled = true;

        }              
        private void frmChangePassword_Load(object sender, EventArgs e)
        {
            this.Text = "Thay đổi mật khẩu người dùng";
            actionUpdateChangepassword.PressNew += new EventHandler(actionUpdateChangepassword_PressNew);
            actionUpdateChangepassword.PressUpdate += new EventHandler(actionUpdateChangepassword_PressUpdate);
            actionUpdateChangepassword.PressClose += new EventHandler(actionUpdateChangepassword_PressClose);
            actionUpdateChangepassword.PressHelp += new EventHandler(actionUpdateChangepassword_PressHelp);
        }

        void actionUpdateChangepassword_PressHelp(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng này chưa được cập nhật", "Thông báo");
        }

        void actionUpdateChangepassword_PressClose(object sender, EventArgs e)
        {
            this.Close();
        }

        void actionUpdateChangepassword_PressUpdate(object sender, EventArgs e)
        {
            msgMessage.Clear();            
            if (string.IsNullOrEmpty("" + txtPassword.Text))
            {
                msgMessage.SetError(txtPassword, "Bạn cần nhập mật khẩu trước khi thực hiện");
                txtPassword.Focus();
                return;
            }
            else if (string.IsNullOrEmpty("" + txtPasswordAfter.Text))
            {
                msgMessage.SetError(txtPasswordAfter, "Bạn cần nhập mật khẩu nhập lại trước khi thực hiện");
                txtPasswordAfter.Focus();
                return;
            }
            else if (!string.IsNullOrEmpty("" + txtPassword.Text) 
                    && !string.IsNullOrEmpty("" + txtPasswordAfter.Text) 
                        && !txtPassword.Text.Equals(txtPasswordAfter.Text))
            {
                msgMessage.SetError(txtPasswordAfter, "Mật khẩu nhập lại không chính xác");
                txtPasswordAfter.Focus();
                return;
            }
            else
            {
                if(Common.EncodePassword(txtOldPassword.Text) == ChangePassAcc.Password)
                {
                    ChangePassAcc.Password = Common.EncodePassword(txtPasswordAfter.Text);
                    if (mAccountBill.UpdateElement(ChangePassAcc))
                    {
                        MessageBox.Show("Cập nhật mới mật khẩu thành công", "Thông báo");
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật mới mật khẩu thất bại", "Thông báo");
                    }
                }
                else
                {
                    MessageBox.Show("Mật khẩu không đúng!", "Thông báo");
                    txtOldPassword.Controls.Clear();
                    txtOldPassword.Focus();
                    return;
                }
                //MessageBox.Show("Cập nhật mới mật khẩu thành công", "Thông báo");
                this.Close();
            }            
        }

        void actionUpdateChangepassword_PressNew(object sender, EventArgs e)
        {
            resetForm();
        }
        private void resetForm()
        {
            txtOldPassword.Text = "";
            txtPassword.Text = "";
            txtPasswordAfter.Text = "";
        }
    }
}
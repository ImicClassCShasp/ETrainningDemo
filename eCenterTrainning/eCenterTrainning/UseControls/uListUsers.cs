using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Linq;
using IMIC.SyncModule;
using IMIC.BUSINESSLOGICLAYERS;
using IMIC.VALUEOBJECTS;

namespace eCenterTrainning.UseControls
{
    public partial class uListUsers : DevExpress.XtraEditors.XtraUserControl
    {
        cConfigParams mcConfigParams;
        AccountBill mAccountBiLL;
        Account mAccount;
        public uListUsers(Account oAccount)
        {
            InitializeComponent();
            mAccount = oAccount;
            mAccountBiLL = new AccountBill(mAccount);
        }
        public uListUsers() { }
        public uListUsers(cConfigParams oConfigParams)
        {
            InitializeComponent();
            mcConfigParams = oConfigParams;
        }
        private int idUser = 0;
        private void uEmployee_Load(object sender, EventArgs e)
        {
            actionMenuUsers.PressNew += new EventHandler(actionMenuUsers_PressNew);
            actionMenuUsers.PressEdit += new EventHandler(actionMenuUsers_PressEdit);
            actionMenuUsers.PressDelete += new EventHandler(actionMenuUsers_PressDelete);
            actionMenuUsers.PressRefresh += new EventHandler(actionMenuUsers_PressRefresh);
            actionMenuUsers.PressClose += new EventHandler(actionMenuUsers_PressClose);
            actionMenuUsers.PressHelp += new EventHandler(actionMenuUsers_PressHelp);
            txtTuKhoa.Focus();
            DisplayListUsers();
        }
        void actionMenuUsers_PressHelp(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng này chưa cập nhật", "Thông Báo");
        }

        void actionMenuUsers_PressClose(object sender, EventArgs e)
        {
            this.Dispose();
        }

        void actionMenuUsers_PressRefresh(object sender, EventArgs e)
        {
            DisplayListUsers();
        }
        /// <summary>
        /// Author          Date        Comment
        /// BONGVX                      xoa thong tin user
        /// </summary>
        void actionMenuUsers_PressDelete(object sender, EventArgs e)
        {
            
            String value = "" + gridViewUser.GetFocusedRowCellValue("UserId");
            Account objAcc = new Account()
            {
                UserId = int.Parse(value),
            };
            
            if (objAcc.UserId > 0)
            {
                
                DialogResult dr = MessageBox.Show("Bạn chắc muốn xóa người dùng này", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    //if (eCenterSystem.UserName.Trim().ToLower() != "admin")
                    //{
                    //    MessageBox.Show("Bạn không có quyền hạn để xóa tài khoản này", "Thông báo");
                    //    return;
                    //}
                    if(mAccountBiLL.DeleteElement(objAcc))
                    {
                        MessageBox.Show("Xóa tài khoản thành công!");
                        DisplayListUsers();
                        return;
                    }
                    MessageBox.Show("Xóa tài khoản thất bại!");
                }
            }
            else
            {
                MessageBox.Show("Hãy chọn người dùng cần xóa", "Thông báo");
            }
            


        }
        /// <summary>
        /// Author          Date        Comment
        /// BONGVX                      Sua thong tin user
        /// </summary>
        void actionMenuUsers_PressEdit(object sender, EventArgs e)
        {
            String value = "" + gridViewUser.GetFocusedRowCellValue("UserId");
            Account objAcc = new Account()
            {
                UserId = int.Parse(value),
            };
            if (objAcc.UserId > 0)
            {
                frmStanUsers ofrmStanUsers = new frmStanUsers(mAccount, objAcc.UserId);
                ofrmStanUsers.ShowDialog();
            }
            else
            {
                MessageBox.Show("Hãy chọn người dùng cần cập nhật", "Thông báo");
            }
            DisplayListUsers();

        }
        /// <summary>
        /// Author          Date        Comment
        /// BONGVX                      Them thong tin user
        /// </summary>
        void actionMenuUsers_PressNew(object sender, EventArgs e)
        {
            frmStanUsers ofrmStanUsers = new frmStanUsers(mAccount);
            ofrmStanUsers.ShowDialog();
            DisplayListUsers();
        }
        /// <summary>
        /// Author          Date        Comment
        /// BONGVX                      Hien thi thong tin user
        /// </summary>
        private void DisplayListUsers()
        {
            List<Account> lstAcc = mAccountBiLL.getElements();
            //List<string> lstUserType = new List<string>();
            //for(int i = 0; i< lstAcc.Count(); i++)
            //{
            //    if(lstAcc[i].IsSuperUser == 0)
            //    {
            //        lstAcc[i].Sex = int.Parse("Nu");
            //    }
            //    else
            //    {
            //        lstAcc[i].IsSuperUser = int.Parse("SuperUser");
            //    }
            //}
            gridControlUser.DataSource = lstAcc;
            


            this.Dock = DockStyle.Fill;
        }

        private void gridControlEmployee_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            String value = "" + gridViewUser.GetFocusedRowCellValue("Id");
            int.TryParse(value, out idUser);
            if (idUser > 0)
            {
                MessageBox.Show("");
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            DisplayListUsers();
        }
    }
}

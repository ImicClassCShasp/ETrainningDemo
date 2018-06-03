using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Linq;

namespace eCenterTrainning.UseControls
{
    public partial class uSocialNetworkAccount : DevExpress.XtraEditors.XtraUserControl
    {
        public uSocialNetworkAccount()
        {
            InitializeComponent();
        }
        
        private void uSocialNetworkAccount_Load(object sender, EventArgs e)
        {
            actionMenuSocialNetworkAccount.PressNew += new EventHandler(actionMenuSocialNetworkAccount_PressNew);
            actionMenuSocialNetworkAccount.PressEdit += new EventHandler(actionMenuSocialNetworkAccount_PressEdit);
            actionMenuSocialNetworkAccount.PressDelete += new EventHandler(actionMenuSocialNetworkAccount_PressDelete);
            actionMenuSocialNetworkAccount.PressRefresh += new EventHandler(actionMenuSocialNetworkAccount_PressRefresh);
            actionMenuSocialNetworkAccount.PressClose += new EventHandler(actionMenuSocialNetworkAccount_PressClose);
            actionMenuSocialNetworkAccount.PressHelp += new EventHandler(actionMenuSocialNetworkAccount_PressHelp);
            displaySocialNetworkAccount();
        }
        void actionMenuSocialNetworkAccount_PressHelp(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng này chưa được cập nhật", "Thông báo");
        }

        void actionMenuSocialNetworkAccount_PressClose(object sender, EventArgs e)
        {
            this.Dispose();
        }

        void actionMenuSocialNetworkAccount_PressRefresh(object sender, EventArgs e)
        {
            displaySocialNetworkAccount();
        }
        /// <summary>     
        /// Author          Date           Comment
        /// BONGVX          18-3-2013       delete tai khoan quang ba
        /// </summary>
        void actionMenuSocialNetworkAccount_PressDelete(object sender, EventArgs e)
        {
            int idSocialNetworkAccount = 0;
            int.TryParse("" + gridViewSocialNetworkAccount.GetFocusedRowCellValue("Id"), out idSocialNetworkAccount);
            DialogResult dr = MessageBox.Show("Bạn có chắc là muốn xóa tài khoản quảng bá này ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                if (idSocialNetworkAccount > 0)
                {
                    MessageBox.Show("");
                }
            }
        }
        /// <summary>     
        /// Author          Date           Comment
        /// BONGVX          18-3-2013       sua tai khoan quang ba
        /// </summary>
        void actionMenuSocialNetworkAccount_PressEdit(object sender, EventArgs e)
        {
            int idSocialNetworkAccount = 0;
            int.TryParse("" + gridViewSocialNetworkAccount.GetFocusedRowCellValue("Id"), out idSocialNetworkAccount);
            if (idSocialNetworkAccount > 0)
            {
                MessageBox.Show("");
            }
        }
        /// <summary>     
        /// Author          Date           Comment
        /// BONGVX          18-3-2013       them moi tai khoan quang ba
        /// </summary>
        void actionMenuSocialNetworkAccount_PressNew(object sender, EventArgs e)
        {
            MessageBox.Show("");
        }
        /// <summary>     
        /// Author          Date           Comment
        /// BONGVX          18-3-2013      hien thi tai khoan quang ba
        /// </summary>
        private void displaySocialNetworkAccount()
        {
            MessageBox.Show("");
        }
    }
}

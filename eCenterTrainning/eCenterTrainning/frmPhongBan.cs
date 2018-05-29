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
    public partial class frmPhongBan : Base.frmIMICBase
    {
        public frmPhongBan()
        {
            InitializeComponent();
        }        
        private void frmPhongBan_Load(object sender, EventArgs e)
        {
            actionUpdatePhongBan.PressUpdate += new EventHandler(actionUpdatePhongBan_PressUpdate);
            actionUpdatePhongBan.PressHelp += new EventHandler(actionUpdatePhongBan_PressHelp);
            actionUpdatePhongBan.PressClose += new EventHandler(actionUpdatePhongBan_PressClose);
            actionUpdatePhongBan.PressNew += new EventHandler(actionUpdatePhongBan_PressNew);
            this.Text = "Thêm mới thông tin phòng ban";            
        }

        void actionUpdatePhongBan_PressNew(object sender, EventArgs e)
        {
            resetAllField();
        }

        void actionUpdatePhongBan_PressClose(object sender, EventArgs e)
        {
            this.Close();
        }

        void actionUpdatePhongBan_PressHelp(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Author          Date        Comment
        /// BONGVX                      Them hoac sua thong tin phong ban
        /// </summary>
        void actionUpdatePhongBan_PressUpdate(object sender, EventArgs e)
        {
            msgMessage.Clear();
            if (string.IsNullOrEmpty("" + txtTenPhongBan.Text))
            {
                msgMessage.SetError(txtTenPhongBan, " Bạn cần nhập tên phòng ban trước khi thực hiện");
                txtTenPhongBan.Focus();
                return;

            }
            if (!string.IsNullOrEmpty("" + txtEmail.Text))
            {
                MessageBox.Show("");
            }
            if (string.IsNullOrEmpty("" + txtDienThoai.Text))
            {
                msgMessage.SetError(txtDienThoai, " Bạn cần nhập số điện thoại phòng ban trước khi thực hiện");
                txtDienThoai.Focus();
                return;
            }            
        }
        private string RandomString(int size)
        {
            StringBuilder builder = new StringBuilder();
            Random random = new Random();
            char ch;
            for (int i = 0; i < size; i++)
            {
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                builder.Append(ch);
            }
            return builder.ToString();
        }        
        /// <summary>
        /// Author          Date        Comment
        /// BONGVX                      Khong chinh sua thong tin phong ban tren field
        /// </summary>
        private void disablefiled()
        {
            foreach (Control c in groupControlPhongBan.Controls)
            {
                if (c is DevExpress.XtraEditors.TextEdit)
                {
                    c.Enabled = false;
                }
            }
            btnOpenDialog.Enabled = false;
            txtMoTa.Enabled = false;
        }
        /// <summary>
        /// Author          Date        Comment
        /// BONGVX                      Xoa thong tin phong ban tren cac field
        /// </summary>
        private void resetAllField()
        {
            foreach (Control c in groupControlPhongBan.Controls)
            {
                if (c is DevExpress.XtraEditors.TextEdit)
                {
                    c.Text = "";
                }
            }            
        } 
    }
}
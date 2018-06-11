using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Linq;
using IMIC.VALUEOBJECTS;
using IMIC.BUSINESSLOGICLAYERS;

namespace eCenterTrainning
{
    public partial class frmCenterInfo : Base.frmIMICBase
    {
        CenterInfo oCen;
        public frmCenterInfo()
        {
            InitializeComponent();
        }

        public frmCenterInfo(Account oAccount) : base(oAccount)
        {
            InitializeComponent();
            oCen = new CenterInfo();
        }

        private void frmCenterInfo_Load(object sender, EventArgs e)
        {
            actionUpdateCenter.PressUpdate += new EventHandler(actionUpdateCenter_PressUpdate);
            actionUpdateCenter.PressClose += new EventHandler(actionUpdateCenter_PressClose);
            actionUpdateCenter.PressHelp += new EventHandler(actionUpdateCenter_PressHelp);
            actionUpdateCenter.PressNew += new EventHandler(actionUpdateCenter_PressNew);
            this.Text = "Thêm mới thông tin trung tâm";
            this.Dock = DockStyle.Fill;
        }

        void actionUpdateCenter_PressNew(object sender, EventArgs e)
        {
            txtDiaChi.Text = "";
            txtDienThoai.Text = "";
            txtEmail.Text = "";
            txtFax.Text = "";
            txtMoTa.Text = "";
            txtTen.Text = "";
            txtWebSite.Text = "";
        }

        void actionUpdateCenter_PressHelp(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng này chưa cập nhật", "Thông báo");
        }

        void actionUpdateCenter_PressClose(object sender, EventArgs e)
        {
            this.Close();
        }

        void actionUpdateCenter_PressUpdate(object sender, EventArgs e)
        {
            msgMessage.Clear();
            if (string.IsNullOrEmpty("" + txtTen.Text))
            {
                msgMessage.SetError(txtTen, " Bạn cần nhập thông tin tên trung tâm trước khi thực hiện");
                txtTen.Focus();
                return;
            }
            if (string.IsNullOrEmpty("" + txtEmail.Text))
            {
                msgMessage.SetError(txtEmail, " Bạn cần nhập thông tin email trước khi thực hiện");
                txtEmail.Focus();
                return;
            }
            else
            {
                if (CheckEmailFormat("" + txtEmail.Text))
                {
                    msgMessage.SetError(txtEmail, "Email không đúng định dạng!");
                    txtEmail.Focus();
                    return;
                }
            }

            oCen.Address= txtDiaChi.Text;
            oCen.Phone= txtDienThoai.Text;
            oCen.Email= txtEmail.Text;

            oCen.Fax= txtFax.Text;
            oCen.Description= txtMoTa.Text;
            oCen.CenterName= txtTen.Text;
            oCen.Website= txtWebSite.Text;

            if (new CenterInfoBLL(mAccount).InsertElement(oCen))
                MessageBox.Show("Thêm trung tâm thành công!");
            else MessageBox.Show("Thêm trung tâm thất bại!");
            this.Close();
        }        
        /// <summary>
        /// Author          Date        Comment
        /// BONGVX                      khong cho sua thong tin tren field
        /// </summary>
        private void disablefiled() 
        {
            foreach (Control c in groupControlCenter.Controls)
            {
                if (c is DevExpress.XtraEditors.TextEdit)
                {
                    c.Enabled = false;
                }

            }
            actionUpdateCenter.Enabled = false;
            txtMoTa.Enabled = false;
        }
        public bool CheckEmailFormat(string Email)
        {
            string Format = "@gmail.com";
            if (Email.Contains(Format)) return false;
            return true;
        }
    }
}
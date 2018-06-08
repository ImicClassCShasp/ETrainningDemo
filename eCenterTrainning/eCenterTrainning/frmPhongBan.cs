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
    public partial class frmPhongBan : Base.frmIMICBase
    {
        Ou mOu;

        public frmPhongBan()
        {
            InitializeComponent();
        }

        public frmPhongBan(Account oAccount) : base(oAccount)
        {
            InitializeComponent();
            mOu = new Ou();
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
            MessageBox.Show("Chức năng hiện chưa được cập nhật!", "Thông báo");
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
            if (string.IsNullOrEmpty("" + txtDienThoai.Text))
            {
                msgMessage.SetError(txtDienThoai, " Bạn cần nhập số điện thoại phòng ban trước khi thực hiện");
                txtDienThoai.Focus();
                return;
            }
            mOu.OuName = txtTenPhongBan.Text;
            mOu.Email = txtEmail.Text;
            mOu.Fax = txtFax.Text;
            mOu.Phone = txtDienThoai.Text;
            mOu.Description = txtMoTa.Text;
            mOu.Website = txtWebsite.Text;
            if (new OuBLL(mAccount).InsertElement(mOu)) MessageBox.Show("Thêm phòng ban thành công!");
            else MessageBox.Show("Thêm thất bại!");
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

        OpenFileDialog openFile = new OpenFileDialog();
        private void btnOpenDialog_Click(object sender, EventArgs e)
        {
            openFile.Filter = "JPEG Files (*.jpeg)|*.jpeg|PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif|All files (*.*)|*.*";

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                mOu.ImagePath = openFile.FileName;
                txtLinkAnh.Text = "Đã có link ảnh!";
            }
        }
        bool CheckEmailFormat(string Email)
        {
            string Format = "@gmail.com";
            if (Email.Contains(Format)) return false;
            return true;
        }
    }
}
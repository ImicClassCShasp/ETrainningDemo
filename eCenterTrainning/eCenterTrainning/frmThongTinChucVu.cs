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
    public partial class frmThongTinChucVu : Base.frmIMICBase
    {
        JobTitle mJob;

        public frmThongTinChucVu()
        {
            InitializeComponent();
        }

        public frmThongTinChucVu(Account oAccount) : base(oAccount)
        {
            InitializeComponent();
            mJob = new JobTitle();
        }

        private void frmThongTinChucVu_Load(object sender, EventArgs e)
        {
            actionUpdateChucVu.PressUpdate += new EventHandler(actionUpdateChucVu_PressUpdate);
            actionUpdateChucVu.PressClose += new EventHandler(actionUpdateChucVu_PressClose);
            actionUpdateChucVu.PressHelp += new EventHandler(actionUpdateChucVu_PressHelp);
            actionUpdateChucVu.PressNew += new EventHandler(actionUpdateChucVu_PressNew);
            this.Text = "Thêm mới thông tin chức vụ";
        }

        void actionUpdateChucVu_PressNew(object sender, EventArgs e)
        {
            resetAllField();
        }


        void actionUpdateChucVu_PressHelp(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng này chưa cập nhật", "Thông báo");
        }

        void actionUpdateChucVu_PressClose(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Author          Date        Comment
        /// BONGVX                      Them hoac sua thong tin chuc vu
        /// </summary>
        void actionUpdateChucVu_PressUpdate(object sender, EventArgs e)
        {
            msgMessage.Clear();
            if (string.IsNullOrEmpty("" + txtTen.Text))
            {
                msgMessage.SetError(txtTen, " Bạn cần nhập tên chức vụ trước khi thực hiện");
                this.txtTen.Focus();
                return;
            }
            mJob.JobTitle1 = txtTen.Text;
            mJob.Description = txtMoTa.Text;
            insertChucVu(mJob);
        }
        /// <summary>
        /// Author          Date        Comment
        /// BONGX           1/2/2013    them moi chuc vu
        /// </summary>
        private void insertChucVu(JobTitle oJob)
        {
            if (new JobTitleBLL(mAccount).InsertElement(oJob)) MessageBox.Show("Thêm chức vụ thành công!");
            else MessageBox.Show("Thêm thất bại!");
        }

        /// <summary>
        /// Author          Date        Comment
        /// BONGX           1/2/2013    Cap nhat chuc vu
        /// </summary>
        private void UpdateChucVu()
        {
            
        }
        /// <summary>
        /// Author          Date        Comment
        /// BONGX           1/2/2013    load du lieu
        /// </summary>
        private void prUpdateChucVu()
        {

        }
        OpenFileDialog ofd = new OpenFileDialog();
        private void btnChonLink_Click(object sender, EventArgs e)
        {
            ofd.Filter = "JPEG Files (*.jpeg)|*.jpeg|PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif|All files (*.*)|*.*";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                mJob.ImagePath = ofd.FileName;
                txtDuongDan.Text = "Đã có đường dẫn!";
            }
        }
        /// <summary>
        /// Author          Date        Comment
        /// BONGVX                      Khong chinh sua thong tin chuc vu tren field
        /// </summary>
        private void disablefiled()
        {
            foreach (Control c in groupControlChucVu.Controls)
            {
                if (c is DevExpress.XtraEditors.TextEdit)
                {
                    c.Enabled = false;
                }

            }
            actionUpdateChucVu.Enabled = false;
            btnChonLink.Enabled = false;
            txtMoTa.Enabled = false;

        }
        /// <summary>
        /// Author          Date        Comment
        /// BONGVX                      Xoa thong tin chuc vu tren field
        /// </summary>
        private void resetAllField()
        {
            foreach (Control c in groupControlChucVu.Controls)
            {
                if (c is DevExpress.XtraEditors.TextEdit)
                {
                    c.Text = "";
                }
            }
            actionUpdateChucVu.Enabled = false;
            txtMoTa.Text = "";
            txtTen.Focus();            
        } 
    }
}
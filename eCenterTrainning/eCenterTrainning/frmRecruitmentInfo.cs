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
    public partial class frmRecruitmentInfo : Base.frmIMICBase
    {
        public frmRecruitmentInfo()
        {
            InitializeComponent();
        }
        OpenFileDialog ofd = new OpenFileDialog();
        private void frmRecruitmentInfo_Load(object sender, EventArgs e)
        {
            this.Text = "Thêm mới thông tin tuyển dụng";            
            loadCenter();
            actionUpdateRecruitmentInfo.PressUpdate += new EventHandler(actionUpdateRecruitmentInfo_PressUpdate);
            actionUpdateRecruitmentInfo.PressNew += new EventHandler(actionUpdateRecruitmentInfo_PressNew);
            actionUpdateRecruitmentInfo.PressClose += new EventHandler(actionUpdateRecruitmentInfo_PressClose);
            actionUpdateRecruitmentInfo.PressHelp += new EventHandler(actionUpdateRecruitmentInfo_PressHelp);
            this.txtTen.Focus();

            dateEditBegin.EditValue = DateTime.Now;
            DateTime dateEnd = DateTime.Now.AddMonths(1);
            dateEditEnd.EditValue = dateEnd;

        }
        void actionUpdateRecruitmentInfo_PressHelp(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng này chưa được cập nhật", "Thông Báo");
        }
        void actionUpdateRecruitmentInfo_PressClose(object sender, EventArgs e)
        {
            this.Close();
        }
        void actionUpdateRecruitmentInfo_PressNew(object sender, EventArgs e)
        {
            resetAllField();
        }
        /// <summary>
        /// Author          Date        Comment
        /// BONGVX                      Them hoac sua thong tin phong ban
        /// </summary>
        void actionUpdateRecruitmentInfo_PressUpdate(object sender, EventArgs e)
        {
            msgMessage.Clear();
            if (string.IsNullOrEmpty("" + txtTen.Text))
            {
                msgMessage.SetError(txtTen, " Bạn cần nhập tiêu đề tuyển dụng trước khi thực hiện");
                txtTen.Focus();
                return;
            }
            if (string.IsNullOrEmpty("" + lookUpEditCenter.EditValue))
            {
                msgMessage.SetError(lookUpEditCenter, " Bạn cần chọn trung tâm trước khi thực hiện");
                return;
            }
            
            if (string.IsNullOrEmpty("" + txtSoLuong.Text))
            {
                msgMessage.SetError(txtSoLuong, " Bạn cần nhập số lượng trước khi thực hiện");
                txtSoLuong.Focus();
                return;
            }
            else
            {
                /*if (Common.validateExp(txtSoLuong.Text) != 1)
                {
                    msgMessage.SetError(txtSoLuong, " Bạn cần nhập số lượng là số ");
                    txtSoLuong.Focus();
                    return;
                }*/
            }
            if (string.IsNullOrEmpty("" + dateEditBegin.Text))
            {
                msgMessage.SetError(dateEditBegin, " Bạn cần chọn ngày bắt đầu tuyển dụng trước khi thực hiện");
                return;
            }
            if (string.IsNullOrEmpty("" + dateEditEnd.Text))
            {
                msgMessage.SetError(dateEditEnd, " Bạn cần chọn ngày kết thúc tuyển dụng trước khi thực hiện");
                return;
            }
            /*int resultEnd = DateTime.Compare(DateTime.Parse("" + dateEditBegin.Text, Common.ci), DateTime.Parse("" + dateEditEnd.Text, Common.ci));
            if (resultEnd >= 0)
            {
                msgMessage.SetError(dateEditEnd, " Bạn cần chọn ngày kết thúc sau ngày bắt đầu tuyển dụng trước khi thực hiện");
                return;
            }*/            
            this.Close();
        }
        /// <summary>
        /// Author      date        Comment
        /// BONGVX      24/2/2013    tạo mới
        /// </summary>
        private int insertRecruitmentInfo()
        {
            try
            {                
               
                return 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace, ex.Message);
                return 0;
            }
        }
        /// <summary>
        /// Author      date        Comment
        /// BONGVX      24/2/2013    cập nhật 
        /// </summary>
        private int updateRecruitmentInfo()
        {
            try
            {
                
                return 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace, ex.Message);
                return 0;
            }
        }
        
        /// <summary>
        /// Author      date        Comment
        /// BONGVX      24/2/2013    load dữ liệu lên các field
        /// </summary>
        private void preUpdateRecruitmentInfo() {
           
        }

        private void btnImage_Click(object sender, EventArgs e)
        {
            ofd.Filter = "JPEG Files (*.jpeg)|*.jpeg|PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif|All files (*.*)|*.*";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txtImagePath.Text = ofd.FileName;
            }
        }

        private void loadCenter()
        {
           
        }

        private void btnAddMoreCenter_Click(object sender, EventArgs e)
        {
            frmCenterInfo frm = new frmCenterInfo();
            frm.ShowDialog();           
        }
        /// <summary>
        /// Author      date        Comment
        /// BONGVX      24/2/2013    reset các field
        /// </summary>
        private void resetAllField()
        {
            foreach (Control c in groupControlRecruitmentInfo.Controls)
            {
                if (c is DevExpress.XtraEditors.TextEdit)
                {
                    c.Text = "";
                }
            }
            txtMota.Text = "";
            txtNoiDung.Text = "";
            txtTen.Focus();
        }
        /// <summary>
        /// Author      date        Comment
        /// BONGVX      24/2/2013    
        /// </summary>
        private void disablefiled()
        {
            foreach (Control c in groupControlRecruitmentInfo.Controls)
            {
                if (c is DevExpress.XtraEditors.TextEdit)
                {
                    c.Enabled = false;
                }
            }
            actionUpdateRecruitmentInfo.Enabled = false;
            btnAddMoreCenter.Enabled = false;
            btnImage.Enabled = false;
            txtMota.Enabled = false;
            txtNoiDung.Enabled = false;
        }         
    }
}
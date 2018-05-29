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
    public partial class frmPromotionInfo : Base.frmIMICBase
    {
        public frmPromotionInfo()
        {
            InitializeComponent();
        }
        private void frmPromotionInfo_Load(object sender, EventArgs e)
        {
            this.Text = "Thông tin quảng bá khóa học";
            actionUpdatePromotion.PressUpdate += new EventHandler(actionUpdatePromotion_PressUpdate);
            actionUpdatePromotion.PressNew += new EventHandler(actionUpdatePromotion_PressNew);
            actionUpdatePromotion.PressClose += new EventHandler(actionUpdatePromotion_PressClose);
            actionUpdatePromotion.PressHelp += new EventHandler(actionUpdatePromotion_PressHelp);
            this.Text = "Thêm mới thông tin quảng bá khóa học";
                    
            dateEditDateStart.EditValue = DateTime.Now;
            DateTime dateEnd = DateTime.Now.AddMonths(1);
            dateEditDateEnd.EditValue = dateEnd;
        }

        void actionUpdatePromotion_PressHelp(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng này chưa được cập nhật","Thông Báo");
        }

        void actionUpdatePromotion_PressClose(object sender, EventArgs e)
        {
            this.Close();
        }

        void actionUpdatePromotion_PressNew(object sender, EventArgs e)
        {
            resetAllField();
        }
        /// <summary>
        /// Author          Date        Comment
        /// BONGVX                      Them hoac sua thong tin quang ba khoa hoc
        /// </summary>
        void actionUpdatePromotion_PressUpdate(object sender, EventArgs e)
        {
            msgMessage.Clear();
            if (string.IsNullOrEmpty(txtTieuDe.Text))
            {
                msgMessage.SetError(txtTieuDe, "Bạn cần nhập thông tin quảng bá khóa học trước khi thực hiện");
                txtTieuDe.Focus();
                return;
            }
            if (string.IsNullOrEmpty("" + dateEditDateStart.Text))
            {
                msgMessage.SetError(dateEditDateStart, "Bạn cần chọn ngày bắt đầu quảng bá khóa học trước khi thực hiện");
                return;
            }
            if (string.IsNullOrEmpty("" + dateEditDateEnd.Text))
            {
                msgMessage.SetError(dateEditDateEnd, "Bạn cần chọn ngày kết thức quảng bá khóa học trước khi thực hiện");
                return;
            }
            
            if (string.IsNullOrEmpty(txtAddress.Text))
            {
                msgMessage.SetError(txtAddress, "Bạn cần nhập địa chỉ quảng bá khóa học trước khi thực hiện");
                txtAddress.Focus();
                return;
            }
            
            if (string.IsNullOrEmpty("" + lookUpEditCenter.EditValue))
            {
                msgMessage.SetError(lookUpEditCenter, "Bạn cần chọn trung tâm trước khi thực hiện");
                lookUpEditCenter.Focus();
                return;
            }
            //int resultEnd = DateTime.Compare(DateTime.Parse("" + dateEditDateStart.Text, Common.ci), DateTime.Parse("" + dateEditDateEnd.Text, Common.ci));
            /*if (resultEnd >= 0)
            {
                msgMessage.SetError(dateEditDateEnd, " Bạn cần chọn ngày kết thúc sau ngày bắt đầu quảng bá khóa học");
                return;
            }*/            
            this.Close();
        }
        /// <summary>
        /// Author          Date        Comment
        /// BONGVX                      Them thong tin quang ba khoa
        /// </summary>
        private int insertPromotion() {
            try
            {                
                
                return 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace,ex.Message);
                return 0;
            }
        }
        /// <summary>
        /// Author          Date        Comment
        /// BONGVX                      Cap nhat thong tin quang ba khoa hoc
        /// </summary>
        private int updatePromotion()
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
        OpenFileDialog ofd = new OpenFileDialog();
        
        /// <summary>
        /// Author          Date        Comment
        /// BONGVX                      load du lieu
        /// </summary>
        private void preUpdatePromotion() {
            
        }
        private void btnImagePath_Click(object sender, EventArgs e)
        {
            ofd.Filter = "JPEG Files (*.jpeg)|*.jpeg|PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif|All files (*.*)|*.*";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txtImagePath.Text = ofd.FileName;
            }
            
        }        
        /// <summary>
        /// Author          Date        Comment
        /// BONGVX                      Xoa thong tin tren field
        /// </summary>
        private void resetAllField()
        {
            foreach (Control c in groupControlPromotion.Controls)
            {
                if (c is DevExpress.XtraEditors.TextEdit)
                {
                    c.Text = "";
                }
            }
            txtDescription.Text = "";
            txtNote.Text = "";
            txtLink.Text = "";
            txtContent.Text = "";           
        }
        /// <summary>
        /// Author          Date        Comment
        /// BONGVX                      khong chinh sua thong tin tren cac field
        /// </summary>
        private void disableAllField()
        {
            foreach (Control c in groupControlPromotion.Controls)
            {
                if (c is DevExpress.XtraEditors.TextEdit)
                {
                    c.Enabled = false;
                }
            }
            actionUpdatePromotion.Enabled = false;
            txtDescription.Enabled = false;
            txtContent.Enabled = false;
            txtNote.Enabled = false;
            txtLink.Enabled = false;
            btnAddMoreCenter.Enabled = false;
            btnImagePath.Enabled = false;
        }                     
    }
}
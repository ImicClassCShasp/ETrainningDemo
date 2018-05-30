using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Collections;
using System.Linq;
namespace eCenterTrainning
{
    public partial class frmCandidate : Base.frmIMICBase
    {
        public frmCandidate()
        {
            InitializeComponent();
        }
        OpenFileDialog ofd = new OpenFileDialog();
        private void frmCandidate_Load(object sender, EventArgs e)
        {            
            
            txtHoTen.Focus();
            actionUpdateCandidates.PressNew += new EventHandler(actionUpdateCandidates_PressNew);
            actionUpdateCandidates.PressUpdate += new EventHandler(actionUpdateCandidates_PressUpdate);
            actionUpdateCandidates.PressClose += new EventHandler(actionUpdateCandidates_PressClose);
            actionUpdateCandidates.PressHelp += new EventHandler(actionUpdateCandidates_PressHelp);
            dateEditDateSent.EditValue = DateTime.Now;
        }

        void actionUpdateCandidates_PressHelp(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng này chưa được cập nhật", "Thông Báo");
        }

        void actionUpdateCandidates_PressClose(object sender, EventArgs e)
        {
            this.Close();
        }

        void actionUpdateCandidates_PressUpdate(object sender, EventArgs e)
        {
            msgMessage.Clear();
            if (string.IsNullOrEmpty("" + txtHoTen.Text))
            {
                msgMessage.SetError(txtHoTen, " Bạn cần nhập họ tên trước khi thực hiện");
                txtHoTen.Focus();
                return;
            }
            if (string.IsNullOrEmpty("" + txtNamKinhNghiem.Text))
            {
                msgMessage.SetError(txtNamKinhNghiem, " Bạn cần nhập số năm kinh nghiệm trước khi thực hiện");
                txtNamKinhNghiem.Focus();
                return;
            }
            else
            {
                MessageBox.Show("");
            }
            if (string.IsNullOrEmpty("" + lookUpEditUngTuyen.EditValue))
            {
                msgMessage.SetError(lookUpEditUngTuyen, " Bạn cần chọn vị trí ứng tuyển trước khi thực hiện");
                return;
            }
            if (string.IsNullOrEmpty("" + dateEditDateSent.Text))
            {
                msgMessage.SetError(dateEditDateSent, " Bạn cần chọn ngày ứng tuyển trước khi thực hiện");
                return;
            }            
            MessageBox.Show("Thêm mới ứng viên thành công ", "Thông báo");           
            this.Close();
        }
        void actionUpdateCandidates_PressNew(object sender, EventArgs e)
        {
            resetAllField();
        }
        private void resetAllField()
        {
            foreach (Control c in groupControlCandidate.Controls)
            {
                if (c is DevExpress.XtraEditors.TextEdit)
                    c.Text = "";
            }
            txtMoTa.Text = "";
            txtNoiDung.Text = "";
            txtGhiChu.Text = "";
        }
        private void disableAllField()
        {
            foreach (Control c in groupControlCandidate.Controls)
            {
                if (c is DevExpress.XtraEditors.TextEdit)
                    c.Enabled = false;
            }
            actionUpdateCandidates.Enabled = false;
            txtMoTa.Enabled = false;
            txtNoiDung.Enabled = false;
            txtGhiChu.Enabled = false;
        }
        private int insertCandiates() {
            try
            {
                MessageBox.Show("");
                return 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace,ex.Message);
                return 0;
            }
        }
        private int updateCandiates()
        {
            try
            {
                MessageBox.Show("");
                return 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace, ex.Message);
                return 0;
            }
        }        
        private void btnImagePath_Click(object sender, EventArgs e)
        {
            ofd.Filter = "JPEG Files (*.jpeg)|*.jpeg|PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif|All files (*.*)|*.*";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txtImagePath.Text = ofd.FileName;
            }
        }
        private void btnCV_Click(object sender, EventArgs e)
        {
            frmInformationDetail frm = new frmInformationDetail();            
            txtNoiDung.Text = "Đã có sơ yếu lý lịch ứng viên";
        }
    }
}
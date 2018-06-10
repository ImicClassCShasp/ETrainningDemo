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
using IMIC.VALUEOBJECTS;
using IMIC.BUSINESSLOGICLAYERS;

namespace eCenterTrainning
{
    public partial class frmCandidate : Base.frmIMICBase
    {
        int Flag;
        int idCan;
        Candidate oCandidate = null;

        public frmCandidate()
        {
            InitializeComponent();
        }

        public frmCandidate(Account oAccount) : base(oAccount)
        {
            InitializeComponent();
            Flag = 0;
            oCandidate = new Candidate();
        }

        public frmCandidate(Account oAccount, int Id) : base(oAccount)
        {
            InitializeComponent();
            Flag = 1;
            oCandidate = new Candidate();
            idCan = Id;
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
            DisplayCandidateNow(idCan);
            loadRecuitmentInfo();
            loadChucVu();
        }
        void loadRecuitmentInfo()
        {
            List<RecruitmentInfo> lstRec = new RecruitmantBLL(mAccount).getElements();
            lookUpEditUngTuyen.Properties.DataSource = lstRec;
            lookUpEditUngTuyen.Properties.DisplayMember = "Name";
            lookUpEditUngTuyen.Properties.ValueMember = "Id";
        }
        void loadChucVu()
        {
            List<JobTitle> lstJob = new JobTitleBLL(mAccount).getElements();
            lookUpEditChucVu.Properties.DataSource = lstJob;
            lookUpEditChucVu.Properties.DisplayMember = "JobTitle1";
            lookUpEditChucVu.Properties.ValueMember = "Id";
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
            if (Flag == 0)
            {
                oCandidate.Address=txtDiaChi.Text;
                oCandidate.Notes=txtGhiChu.Text;
                oCandidate.FullName=txtHoTen.Text;
                oCandidate.ImagePath=txtImagePath.Text;
                oCandidate.DocumentPath=txtLinkTaiLieu.Text;
                oCandidate.Description=txtMoTa.Text;
                oCandidate.YearsExperience=int.Parse(""+txtNamKinhNghiem.Text);

                oCandidate.UniversityDegree=txtTruongTotNghiep.Text;
                if (cboGioiTinh.Text == "Nam") oCandidate.Sex = 1;
                else oCandidate.Sex = 0;
                oCandidate.DateBirthday = dateEditNgaySinh.DateTime;
                oCandidate.DateSent = dateEditDateSent.DateTime;

                oCandidate.JobTitleId = int.Parse("" + lookUpEditChucVu.EditValue);
                oCandidate.RecruitmentId = int.Parse("" + lookUpEditUngTuyen.EditValue);

                if (new CandidatesBLL(mAccount).InsertElement(oCandidate))
                    MessageBox.Show("Thêm mới ứng viên thành công!", "Thông báo");
                else MessageBox.Show("Thêm mới thất bại!");
            }
            else if (Flag==1)
            {
                oCandidate.Id = idCan;
                oCandidate.Address = txtDiaChi.Text;
                oCandidate.Notes = txtGhiChu.Text;
                oCandidate.FullName = txtHoTen.Text;
                oCandidate.ImagePath = txtImagePath.Text;
                oCandidate.DocumentPath = txtLinkTaiLieu.Text;
                oCandidate.Description = txtMoTa.Text;
                oCandidate.YearsExperience = int.Parse("" + txtNamKinhNghiem.Text);

                oCandidate.UniversityDegree = txtTruongTotNghiep.Text;
                if (cboGioiTinh.Text == "Nam") oCandidate.Sex = 1;
                else oCandidate.Sex = 0;
                oCandidate.DateBirthday = dateEditNgaySinh.DateTime;
                oCandidate.DateSent = dateEditDateSent.DateTime;

                oCandidate.JobTitleId = int.Parse("" + lookUpEditChucVu.EditValue);
                oCandidate.RecruitmentId = int.Parse("" + lookUpEditUngTuyen.EditValue);

                if (new CandidatesBLL(mAccount).InsertAndUpdateElement(oCandidate))
                    MessageBox.Show("Sửa ứng viên thành công!", "Thông báo");
                else MessageBox.Show("Sửa thất bại!");
            }
                      
            this.Close();
        }
        void DisplayCandidateNow(int id)
        {
            Candidate oCan = new CandidatesBLL(mAccount).getElementById(id);
            txtDiaChi.Text=""+oCan.Address;
            txtGhiChu.Text=""+oCan.Notes;
            txtHoTen.Text=""+oCan.FullName;
            txtImagePath.Text=""+oCan.ImagePath;
            txtLinkTaiLieu.Text=""+oCan.DocumentPath;
            txtMoTa.Text=""+oCan.Description;
            txtNamKinhNghiem.Text=""+oCan.YearsExperience;

            dateEditDateSent.Text = ""+oCan.DateSent;
            dateEditNgaySinh.Text = "" + oCan.DateBirthday;

            lookUpEditChucVu.EditValue = oCan.JobTitleId;
            lookUpEditUngTuyen.EditValue = oCan.RecruitmentId;
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
            frmInformationDetail frm = new frmInformationDetail(oCandidate);
            frm.ShowDialog();
            MessageBox.Show("" + oCandidate.Contents);
            txtNoiDung.Text = "Đã có sơ yếu lý lịch ứng viên";
        }
    }
}
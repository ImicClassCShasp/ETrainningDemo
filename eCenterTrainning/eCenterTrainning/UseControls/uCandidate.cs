using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Linq;
using IMIC.VALUEOBJECTS;
using IMIC.BUSINESSLOGICLAYERS;

namespace eCenterTrainning.UseControls
{
    public partial class uCandidate : ucRightForm
    {
        public uCandidate()
        {
            InitializeComponent();
        }

        public uCandidate(Account oAccount) : base(oAccount)
        {
            InitializeComponent();
        }

        private int idCan = 0;
        private void uCandidate_Load(object sender, EventArgs e)
        {
            this.Text = "Quản lý danh sách ứng viên";
            //loadJob();
            loadRecuitmentInfo();
            actionMenuCandidate.PressNew += new EventHandler(actionMenuCandidate_PressNew);
            actionMenuCandidate.PressEdit += new EventHandler(actionMenuCandidate_PressEdit);
            actionMenuCandidate.PressDelete += new EventHandler(actionMenuCandidate_PressDelete);
            actionMenuCandidate.PressClose += new EventHandler(actionMenuCandidate_PressClose);
            actionMenuCandidate.PressHelp += new EventHandler(actionMenuCandidate_PressHelp);
            actionMenuCandidate.PressRefresh += new EventHandler(actionMenuCandidate_PressRefresh);
            displayCandidate();
        }
        void actionMenuCandidate_PressRefresh(object sender, EventArgs e)
        {
            displayCandidate();
        }

        void actionMenuCandidate_PressHelp(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng này chưa được cập nhật", "Thông báo");
        }

        void actionMenuCandidate_PressClose(object sender, EventArgs e)
        {
            this.Dispose();
        }
        /// <summary>
        /// Author          Date        Comment
        /// BONGVX                      Xoa thong tin ung vien
        /// </summary>
        void actionMenuCandidate_PressDelete(object sender, EventArgs e)
        {
            String value = "" + gridViewCandidates.GetFocusedRowCellValue("Id");
            int.TryParse(value, out idCan);
            if (idCan > 0)
            {
                DialogResult dr = MessageBox.Show("Bạn chắc muốn xóa ứng viên này ", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    Candidate oCan = new Candidate() { Id = idCan };
                    if (new CandidatesBLL(mAccount).DeleteElement(oCan.Id))
                        MessageBox.Show("Xóa ứng viên thành công!");
                    else MessageBox.Show("Xóa thất bại!");
                }
            }
            else
            {
                MessageBox.Show("Hãy chọn ứng viên cần xóa", "Thông báo");
            }
            displayCandidate();
        }
        /// <summary>
        /// Author          Date        Comment
        /// BONGVX                      Sua thong tin ung vien
        /// </summary>
        void actionMenuCandidate_PressEdit(object sender, EventArgs e)
        {
            String value = "" + gridViewCandidates.GetFocusedRowCellValue("Id");
            int.TryParse(value, out idCan);
            if (idCan > 0)
            {
                frmCandidate frm = new frmCandidate(mAccount, idCan);
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Hãy chọn ứng viên cần cập nhật", "Thông báo");
            }
            displayCandidate();
        }
        /// <summary>
        /// Author          Date        Comment
        /// BONGVX                      Them thong tin ung vien
        /// </summary>
        void actionMenuCandidate_PressNew(object sender, EventArgs e)
        {
            frmCandidate frm = new frmCandidate(mAccount);
            frm.ShowDialog();
        }
        /// <summary>
        /// Author          Date        Comment
        /// BONGVX                      Hien thi thong tin ung vien
        /// </summary>
        private void displayCandidate()
        {
            List<Candidate> lstCan = new CandidatesBLL(mAccount).getElements();
            gridControlCandidates.DataSource = lstCan;
            this.Dock = DockStyle.Fill;
        }
        /// <summary>
        /// Author          Date        Comment
        /// BONGVX                      Hien thi thong tin ung vien chi tiet
        /// </summary>
        private void gridControlCandidates_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            String value = "" + gridViewCandidates.GetFocusedRowCellValue("Id");
            int.TryParse(value, out idCan);
            if (idCan > 0)
            {
                MessageBox.Show("");
            }
        }
        // load chuc vu
        private void loadJob()
        {
            MessageBox.Show("");

        }
        //load tuyen dung
        private void loadRecuitmentInfo()
        {
            List<RecruitmentInfo> lstRec = new RecruitmantBLL(mAccount).getElements();
            lookUpEditRecruiment.Properties.DataSource = lstRec;
            lookUpEditRecruiment.Properties.DisplayMember = "Name";
            lookUpEditRecruiment.Properties.ValueMember = "Id";
        }

        //private void lookUpEditChucVu_TextChanged(object sender, EventArgs e)
        //{
        //    displayCandidate();
        //}
        //private void lookUpEditRecruiment_TextChanged(object sender, EventArgs e)
        //{
        //    displayCandidate();
        //}
        /// <summary>
        /// Author          Date        Comment
        /// BONGVX                      Hien thi ho so ung vien
        /// </summary>
        private void gridViewCandidates_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            if (e.Column == colHoSo)
            {
                int idCandidate = 0;
                string value = "" + gridViewCandidates.GetFocusedRowCellValue("Id");
                int.TryParse(value, out idCandidate);
                if (idCandidate > 0)
                {
                    Candidate oCan = new CandidatesBLL(mAccount).getElementById(idCandidate);
                    MessageBox.Show(
                        "Họ tên: " +oCan.FullName + "\n" +
                        "Tuổi: " + (DateTime.Now.Year-oCan.DateBirthday.Value.Year) + "\n" +
                        "Chức vụ: " +oCan.JobTitle + "\n" +
                        "------------------------------\n" +
                        "Mô tả: "+oCan.Description, "Hồ Sơ");
                }
            }
            
        }
        /// <summary>
        /// Author          Date        Comment
        /// BONGVX                      search theo tuyen dung
        /// </summary>
        private void lookUpEditRecruiment_EditValueChanged(object sender, EventArgs e)
        {
            int idRec;
            int.TryParse("" + lookUpEditRecruiment.EditValue, out idRec);
            List<Candidate> ListCan = new CandidatesBLL(mAccount).GetElementByIDRecruitment(idRec);
            gridControlCandidates.DataSource = ListCan;
            this.Dock = DockStyle.Fill;
        }
        /// <summary>
        /// Author          Date        Comment
        /// BONGVX                      search theo chu vu 
        /// </summary>
        //private void lookUpEditChucVu_EditValueChanged(object sender, EventArgs e)
        //{
        //    displayCandidate();
        //}

       
    }
}

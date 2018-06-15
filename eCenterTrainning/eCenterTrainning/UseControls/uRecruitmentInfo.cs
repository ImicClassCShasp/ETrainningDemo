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
    public partial class uRecruitmentInfo : ucRightForm
    {
        public uRecruitmentInfo()
        {
            InitializeComponent();
        }

        public uRecruitmentInfo(Account oAccount) : base(oAccount)
        {
            InitializeComponent();
        }

        private int idRe = 0;
        private String RecruimentName = "";
        private void uRecruitmentInfo_Load(object sender, EventArgs e)
        {
            
            
            
            actionMenuRecruitmentInfo.PressRefresh += new EventHandler(actionMenuRecruitmentInfo_PressRefresh);
            actionMenuRecruitmentInfo.PressClose += new EventHandler(actionMenuRecruitmentInfo_PressClose);
            actionMenuRecruitmentInfo.PressHelp += new EventHandler(actionMenuRecruitmentInfo_PressHelp);
            this.Text = "Thông Tin Tuyển Dụng";
            checkExpiredRecruitment();
            displayRecruitmentInfo();
            stanfTabPermission mStanfTabPermission = new stanfTabPermission();
            foreach (stanfTabPermission item in mAccount.ListTabPermissions)
            {
                if (item.UserId == mAccount.UserId && item.DisplayRoleName == "Đợt Tuyển Dụng")
                {
                    mStanfTabPermission.IsAdd = item.IsAdd;
                    mStanfTabPermission.IsDelete = item.IsDelete;
                    mStanfTabPermission.IsEdit = item.IsEdit;
                    mStanfTabPermission.IsList = item.IsList;
                    mStanfTabPermission.IsReport = item.IsReport;
                }
            }
            if (mAccount.IsSuperUser == false)
            {
                int temp = 0;
                gridControlRecruitmentInfo.Visible = false;
                if (mStanfTabPermission.IsAdd == true)
                {
                    actionMenuRecruitmentInfo.PressNew += new EventHandler(actionMenuRecruitmentInfo_PressNew);
                    temp++;
                }
                if (mStanfTabPermission.IsDelete == true)
                {
                    actionMenuRecruitmentInfo.PressDelete += new EventHandler(actionMenuRecruitmentInfo_PressDelete);
                    temp++;
                }
                if (mStanfTabPermission.IsEdit == true)
                {
                    actionMenuRecruitmentInfo.PressEdit += new EventHandler(actionMenuRecruitmentInfo_PressEdit);
                    temp++;
                }
                if (mStanfTabPermission.IsList == true)
                {
                    gridControlRecruitmentInfo.Visible = true;
                    temp++;
                }
                if (temp == 0)
                {
                    actionMenuRecruitmentInfo.Enabled = false;
                }
            }
        }
        void actionMenuRecruitmentInfo_PressHelp(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng này chưa cập nhật", "Thông Báo");
        }

        void actionMenuRecruitmentInfo_PressClose(object sender, EventArgs e)
        {
            this.Dispose();
        }

        void actionMenuRecruitmentInfo_PressRefresh(object sender, EventArgs e)
        {
            checkExpiredRecruitment();
            displayRecruitmentInfo();          
        }

        void actionMenuRecruitmentInfo_PressDelete(object sender, EventArgs e)
        {
            String value = "" + gridViewRecruitmentInfo.GetFocusedRowCellValue("Id");
            int.TryParse(value, out idRe);
            
            if (idRe > 0)
            {                
                DialogResult dr = MessageBox.Show("Bạn chắc muốn xóa tuyển dụng này", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    if (new RecruitmantBLL(mAccount).DeleteElement(idRe)) MessageBox.Show("Xóa thành công!");
                    else MessageBox.Show("Xóa thất bại!");
                }
            }
            else
            {
                MessageBox.Show("Hãy chọn tuyển dụng cần xóa", "Thông báo");
            }
           
        }
        /// <summary>
        /// Author          Date        Comment
        /// BONGVX                      Sua thong tin tuyen dung
        /// </summary>
        void actionMenuRecruitmentInfo_PressEdit(object sender, EventArgs e)
        {
            String value = "" + gridViewRecruitmentInfo.GetFocusedRowCellValue("Id");
            int.TryParse(value, out idRe);
            if (idRe > 0)
            {
                frmRecruitmentInfo frm = new frmRecruitmentInfo(mAccount, idRe);
                frm.ShowDialog();
                displayRecruitmentInfo();
            }
            else
            {
                MessageBox.Show("Hãy chọn giảng viên cần cập nhật", "Thông báo");
            }
        }

        /// <summary>
        /// Author          Date        Comment
        /// BONGVX                      Them thong tin tuyen dung
        /// </summary>
        void actionMenuRecruitmentInfo_PressNew(object sender, EventArgs e)
        {
            frmRecruitmentInfo frm = new frmRecruitmentInfo(mAccount);
            frm.ShowDialog();
            displayRecruitmentInfo();
        }
        /// <summary>
        /// Author          Date        Comment
        /// BONGVX                      Hien thi thong tin tuyen dung
        /// </summary>
        private void displayRecruitmentInfo()
        {
            List<RecruitmentInfo> lstRec = new RecruitmantBLL(mAccount).getElements();
            gridControlRecruitmentInfo.DataSource = lstRec;
            this.Dock = DockStyle.Fill;
        }

        
        /// <summary>
        /// Kiểm tra xem 1 đợt tuyển dung đã hết hạn hay chưa
        /// Author          Date            Comment
        /// BONGVX          23/2/2013       Cập nhật lại trang thái
        /// </summary>
        private void checkExpiredRecruitment()
        {
            //MessageBox.Show("");
        }

        private void xtraTabControlRecruitmentCandiidate_Click(object sender, EventArgs e)
        {
            RecruimentName = "" + gridViewRecruitmentInfo.GetFocusedRowCellValue("Name");
            lbTuyenDung.Text = RecruimentName;
            lbTuyenDung.Visible = true;
            loadCandidateByRecruitId();
        }

        private void loadCandidateByRecruitId()
        {
            
        }

        private void btnAddMoreCandidate_Click(object sender, EventArgs e)
        {
            MessageBox.Show("");
        }

        private void gridControlRecruitmentInfo_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            String value = "" + gridViewRecruitmentInfo.GetFocusedRowCellValue("Id");
            int.TryParse(value, out idRe);
            if (idRe > 0)
            {
                frmListCandidate frm = new frmListCandidate();
                //frm.IdRecruitment = idRe;
                frm.ShowDialog();
            }
        }

        private void gridViewRecruitmentInfo_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            if (e.Column == colChiTiet)
            {
                int idRe = 0;
                string id = "" + gridViewRecruitmentInfo.GetFocusedRowCellValue("Id");
                int.TryParse(id, out idRe);
                if (idRe > 0)
                {
                    RecruitmentInfo recruitmentInfo = new RecruitmantBLL(mAccount).GetByID_Recruitment(idRe);
                    MessageBox.Show("Chi tiết tuyển dụng: \n\n" +
                        "" + recruitmentInfo.Description, "Thông tin");
                }
            }
        }

        //private void btnSuaUngVien_Click(object sender, EventArgs e)
        //{
        //    int idCandidate = 0;
        //    int.TryParse(""+gridViewCandidates.GetFocusedRowCellValue("Id"),out idCandidate);
        //    if (idCandidate > 0)
        //    {
        //        MessageBox.Show("");
        //    }
        //}
    }
}

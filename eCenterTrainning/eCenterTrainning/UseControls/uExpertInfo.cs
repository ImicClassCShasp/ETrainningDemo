using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Linq;
using IMIC.SyncModule;
using IMIC.VALUEOBJECTS;
using IMIC.BUSINESSLOGICLAYERS;

namespace eCenterTrainning.UseControls
{
    public partial class uExpertInfo : ucRightForm
    {
        cConfigParams mConfigParams;
        ExpertInfoBll mExpertInfoBll;
        //public uExpertInfo()
        //{
        //    InitializeComponent();
        //}
        public uExpertInfo(cConfigParams oConfigs)
        {
            InitializeComponent();
            mConfigParams = oConfigs;
        }
        public uExpertInfo(Account oAccount) : base(oAccount)
        {
            InitializeComponent();
            mExpertInfoBll = new ExpertInfoBll(mAccount);
        }
        private int idGV=0;
        private void uExpertInfo_Load(object sender, EventArgs e)
        {
            actionMenuExpert.PressNew += new EventHandler(actionMenuExpert_PressNew);
            actionMenuExpert.PressEdit += new EventHandler(actionMenuExpert_PressEdit);
            actionMenuExpert.PressDelete += new EventHandler(actionMenuExpert_PressDelete);
            actionMenuExpert.PressRefresh += new EventHandler(actionMenuExpert_PressRefresh);
            actionMenuExpert.PressClose += new EventHandler(actionMenuExpert_PressClose);
            actionMenuExpert.PressHelp += new EventHandler(actionMenuExpert_PressHelp);
            //if (eCenterSystem.UserId == 40 || eCenterSystem.UserId == 41)
            //{
            //    MessageBox.Show("Bạn chưa có quyền sử dụng danh mục này!", "Thông báo");
            //    this.Hide();
            //    return;
            //}
            this.Dock = DockStyle.Fill;
            displayExpert();
        }

        void actionMenuExpert_PressHelp(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng này chưa cập nhật","Thông Báo");
        }

        void actionMenuExpert_PressClose(object sender, EventArgs e)
        {
            this.Dispose();
        }

        void actionMenuExpert_PressRefresh(object sender, EventArgs e)
        {
            displayExpert();
        }
        /// <summary>
        /// Author          Date        Comment
        /// BONGVX                      Xoa thong tin giang vien
        /// </summary>
        void actionMenuExpert_PressDelete(object sender, EventArgs e)
        {
            String value = "" + gridViewGiangVien.GetFocusedRowCellValue("Id");
            int.TryParse(value, out idGV);
            if (idGV > 0)
            {
                DialogResult dr = MessageBox.Show("Thao tác xóa không thể khôi phục, bạn có chắc muốn xóa Giảng viên này", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    mExpertInfoBll.DeleteElement(idGV);
                    displayExpert();
                }
            }
            else
            {
                MessageBox.Show("Hãy chọn giảng viên cần xóa", "Thông báo");
            }
            
        }
        /// <summary>
        /// Author          Date        Comment
        /// BONGVX                      Sua thong tin GV
        /// </summary>
        void actionMenuExpert_PressEdit(object sender, EventArgs e)
        {
            String value = "" + gridViewGiangVien.GetFocusedRowCellValue("Id");
            int.TryParse(value, out idGV);
            if (idGV > 0)
            {
                frmGiangVienAdd oGVEdit = new frmGiangVienAdd(mAccount,1,idGV);
                oGVEdit.ShowDialog();
                displayExpert();
            }
            else
            {
                MessageBox.Show("Hãy chọn giảng viên cần cập nhật", "Thông báo");
            }
            
        }
        /// <summary>
        /// Author          Date        Comment
        /// BONGVX                      Them thong tin GV
        /// </summary>
        void actionMenuExpert_PressNew(object sender, EventArgs e)
        {
            frmGiangVienAdd oGVAdd = new frmGiangVienAdd(mAccount, 0, idGV);
            oGVAdd.ShowDialog();
            displayExpert();
        }
        /// <summary>
        /// Author          Date        Comment
        /// BONGVX                      Hien thi thong tin GV
        /// </summary>
        public  void displayExpert()
        {
            //MessageBox.Show("");

            //lookUpEditExpert.Properties.DisplayMember = "ExpertName";
            //lookUpEditExpert.Properties.ValueMember = "Id";
            gridControlGiangVien.DataSource = mExpertInfoBll.getElements();
            gridControlGiangVien.Update();
            gridControlGiangVien.Refresh();
        }
        /// <summary>
        /// Author          Date        Comment
        /// BONGVX                      Hien thi thong tin GV chi tiet
        /// </summary>
        private void gridControlGiangVien_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            String value = "" + gridViewGiangVien.GetFocusedRowCellValue("Id");
            int.TryParse(value, out idGV);
            if (idGV > 0)
            {
                actionMenuExpert_PressEdit(sender,e);
            }
            else
            {
                MessageBox.Show("Hãy chọn giảng viên cần cập nhật", "Thông báo");
            }
        }
        /// <summary>
        /// Author          Date        Comment
        /// BONGVX                      Hien thi thong tin CV GV
        /// </summary>
        private void gridViewGiangVien_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            if (e.Column == colChiTiet)
            {
                int idExper = 0;
                string value = "" + gridViewGiangVien.GetFocusedRowCellValue("Id");
                int.TryParse(value,out idExper);
                if (idExper > 0)
                {
                    MessageBox.Show("");
                }
            }
        }
        /// <summary>
        /// Author          Date        Comment
        /// BONGVX                      tim kiem nhan vien theo phong ban
        /// </summary>
        private void xtraTabControlExpert_Click(object sender, EventArgs e)
        {
            if (xtraTabControlExpert.SelectedTabPageIndex == 1) {
                int idExper = 0;
                string value = "" + gridViewGiangVien.GetFocusedRowCellValue("Id");
                int.TryParse(value, out idExper);
                if (idExper > 0) {
                    lookUpEditExpert.EditValue = idExper;
                }
            }
        }

        private void lookUpEditExpert_EditValueChanged(object sender, EventArgs e)
        {
            int idExper = 0;
            string value = "" + lookUpEditExpert.EditValue;
            int.TryParse(value, out idExper);
            if (idExper > 0)
            {
                MessageBox.Show("");
            }
        }
    }
}

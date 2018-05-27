using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Linq;

namespace eCenterTrainning.UseControls
{
    public partial class uScheduleInfo : DevExpress.XtraEditors.XtraUserControl
    {
        public uScheduleInfo()
        {
            InitializeComponent();
        }
        private int idSchedules=0;
        private void uExpertInfo_Load(object sender, EventArgs e)
        {
            actionMenuSchedule.PressNew += new EventHandler(actionMenuSchedule_PressNew);
            actionMenuSchedule.PressEdit += new EventHandler(actionMenuSchedule_PressEdit);
            actionMenuSchedule.PressDelete += new EventHandler(actionMenuSchedule_PressDelete);
            actionMenuSchedule.PressRefresh += new EventHandler(actionMenuSchedule_PressRefresh);
            actionMenuSchedule.PressClose += new EventHandler(actionMenuSchedule_PressClose);
            actionMenuSchedule.PressHelp += new EventHandler(actionMenuSchedule_PressHelp);
            displaySchedules();
        }

        void actionMenuSchedule_PressHelp(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng này chưa cập nhật","Thông Báo");
        }

        void actionMenuSchedule_PressClose(object sender, EventArgs e)
        {
            this.Dispose();
        }

        void actionMenuSchedule_PressRefresh(object sender, EventArgs e)
        {
            displaySchedules();
        }
        /// <summary>
        /// Author          Date        Comment
        /// BONGVX                      Xoa thong tin giang vien
        /// </summary>
        void actionMenuSchedule_PressDelete(object sender, EventArgs e)
        {
            String value = "" + grdviewNhatKyLopHoc.GetFocusedRowCellValue("Id");
            int.TryParse(value, out idSchedules);
            if (idSchedules > 0)
            {               
                DialogResult dr = MessageBox.Show("Bạn chắc muốn xóa thông tin này ", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    MessageBox.Show("");
                }
            }
            else
            {
                MessageBox.Show("Hãy chọn thông tin Nhật ký cần xóa", "Thông báo");
            }
            
        }
        /// <summary>
        /// Author          Date        Comment
        /// BONGVX                      Sua thong tin GV
        /// </summary>
        void actionMenuSchedule_PressEdit(object sender, EventArgs e)
        {
            String value = "" + grdviewNhatKyLopHoc.GetFocusedRowCellValue("Id");
            int.TryParse(value, out idSchedules);
            if (idSchedules > 0)
            {
                MessageBox.Show("");
            }
            else
            {
                MessageBox.Show("Hãy chọn nhật ký cần cập nhật", "Thông báo");
            }            
        }
        /// <summary>
        /// Author          Date        Comment
        /// BONGVX                      Them thong tin GV
        /// </summary>
        void actionMenuSchedule_PressNew(object sender, EventArgs e)
        {
            MessageBox.Show("");
        }
        /// <summary>
        /// Author          Date        Comment
        /// BONGVX                      Hien thi thong tin GV
        /// </summary>
        public void displaySchedules()
        {
            MessageBox.Show("");
        }
        /// <summary>
        /// Author          Date        Comment
        /// BONGVX                      Hien thi thong tin GV chi tiet
        /// </summary>
        private void gridControlGiangVien_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //String value = "" + gridViewNhatKyLopHoc.GetFocusedRowCellValue("Id");
            //int.TryParse(value, out idGV);
            //if (idGV > 0)
            //{
            //    frmGiangVienAdd frmGV = new frmGiangVienAdd();
            //    frmGV.IsViewDetail = true;
            //    frmGV.IdGV = idGV;
            //    frmGV.ShowDialog();
            //}
            //else
            //{
            //    MessageBox.Show("Hãy chọn giảng viên cần cập nhật", "Thông báo");
            //}
        }
        /// <summary>
        /// Author          Date        Comment
        /// BONGVX                      Hien thi thong tin CV GV
        /// </summary>
        private void gridViewGiangVien_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            //if (e.Column == colChiTiet)
            //{
            //    int idExper = 0;
            //    string value = "" + gridViewNhatKyLopHoc.GetFocusedRowCellValue("Id");
            //    int.TryParse(value,out idExper);
            //    if (idExper > 0)
            //    {
            //        ExpertInfo expert = Service.Entities.ExpertInfoes.Where(ex=>ex.Id== idExper).FirstOrDefault<ExpertInfo>();
            //        if (expert != null)
            //        {
            //            frmInformationDetail frm = new frmInformationDetail();
            //            frm.Data = expert.ExpertCV;
            //            frm.IdExpert = idExper;
            //            frm.ShowDialog();
            //        }
            //    }
            //}
        }
        /// <summary>
        /// Author          Date        Comment
        /// BONGVX                      tim kiem nhan vien theo phong ban
        /// </summary>
        private void xtraTabControlExpert_Click(object sender, EventArgs e)
        {
            //if (xtraTabControlExpert.SelectedTabPageIndex == 1) {
            //    int idExper = 0;
            //    string value = "" + gridViewNhatKyLopHoc.GetFocusedRowCellValue("Id");
            //    int.TryParse(value, out idExper);
            //    if (idExper > 0) {
            //        lookUpEditExpert.EditValue = idExper;
            //    }
            //}
        }

        private void lookUpEditExpert_EditValueChanged(object sender, EventArgs e)
        {
            //int idExper = 0;
            //string value = "" + lookUpEditExpert.EditValue;
            //int.TryParse(value, out idExper);
            //if (idExper > 0)
            //{
            //    IQueryable<Class> lstcls = Service.Entities.Classes.Where(c => c.ExpertId == idExper);
            //    gridControlClass.DataSource = lstcls.OrderByDescending(c => c.Id);
            //}
        }

        private void grdNhatKyLopHoc_Click(object sender, EventArgs e)
        {

        }

        private void grdNhatKyLopHoc_DoubleClick(object sender, EventArgs e)
        {
            String value = "" + grdviewNhatKyLopHoc.GetFocusedRowCellValue("Id");
            int.TryParse(value, out idSchedules);
            if (idSchedules > 0)
            {
                MessageBox.Show("");
            }
            else
            {
                MessageBox.Show("Hãy chọn nhật ký cần cập nhật", "Thông báo");
            }            
        }
    }
}

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
    public partial class uCourse : DevExpress.XtraEditors.XtraUserControl
    {
        public uCourse()
        {
            InitializeComponent();
        }

        private void uCourse_Load(object sender, EventArgs e)
        {
            xtraTabPageCourse.Focus();
            actionMenu1.PressNew += new EventHandler(actionMenu1_PressNew);
            actionMenu1.PressEdit += new EventHandler(actionMenu1_PressEdit);
            actionMenu1.PressRefresh += new EventHandler(actionMenu1_PressRefresh);
            actionMenu1.PressDelete += new EventHandler(actionMenu1_PressDelete);
            actionMenu1.PressClose += new EventHandler(actionMenu1_PressClose);
            actionMenu1.PressHelp += new EventHandler(actionMenu1_PressHelp);
            HienThiThongTinKhoaHoc();
        }

        void actionMenu1_PressHelp(object sender, EventArgs e)
        {

        }

        void actionMenu1_PressClose(object sender, EventArgs e)
        {
            this.Dispose();
        }

        void actionMenu1_PressDelete(object sender, EventArgs e)
        {
            int intCourseId = 0;
            int.TryParse("" + gridViewCourse.GetFocusedRowCellValue("Id"), out intCourseId);
           
            if (intCourseId > 0)
            {
                DialogResult dlg = MessageBox.Show("Bạn có chắc chắn muốn xóa thông tin này ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dlg == DialogResult.Yes)
                {
                    MessageBox.Show("");
                }
                HienThiThongTinKhoaHoc();
            }
            else
            {
                MessageBox.Show("Bạn cần chọn thông tin để thực hiện thao tác này !!!", "Thông báo");
            }
        }

        void actionMenu1_PressRefresh(object sender, EventArgs e)
        {
            HienThiThongTinKhoaHoc();
        }

        void actionMenu1_PressEdit(object sender, EventArgs e)
        {
            int intCoursetId = 0;

            int.TryParse("" + gridViewCourse.GetFocusedRowCellValue("Id"), out intCoursetId);


            if (intCoursetId > 0)
            {
                
                frmAddKhoaHoc objSua = new frmAddKhoaHoc();
                //objSua.IdCourse = intCoursetId;
                objSua.ShowDialog();
                HienThiThongTinKhoaHoc();
            }
            else
            {
                MessageBox.Show("Bạn cần chọn thông tin trước khi thực hiện", "Thông báo");
            }
        }

        void actionMenu1_PressNew(object sender, EventArgs e)
        {            
            frmAddKhoaHoc objAddKhoaHoc = new frmAddKhoaHoc();
            objAddKhoaHoc.ShowDialog();
            HienThiThongTinKhoaHoc();
        }
       
        /// <summary>
        /// Hàm hiển thị danh sách khóa học
        /// Author                  CreateDate
        /// hungld                  03/02/2013
        /// </summary>
        private void HienThiThongTinKhoaHoc()
        {
            
        }

        private void xtraTabControlCourse_Click(object sender, EventArgs e)
        {
            
        }
        private void lookUpEditCourse_EditValueChanged(object sender, EventArgs e)
        {

            int _Id = 0;
            int.TryParse("" + lookUpEditCourse.EditValue, out _Id);
            
        }

        private void btnAddClass_Click(object sender, EventArgs e)
        {
           

        }
        private void LoadClass()
        {
            int id = 0;
            int.TryParse("" + lookUpEditCourse.EditValue, out id);
            MessageBox.Show("");
        }

        private void gridViewClass_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            if (e.Column == ColAction)
            {
                DialogResult dg = MessageBox.Show("Bạn có chắc chắn muốn xóa thông tin này", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dg == DialogResult.Yes)
                {
                    MessageBox.Show("");
                    int idClass = 0;
                    int.TryParse("" + gridViewClass.GetFocusedRowCellValue("Id"), out idClass);
                    if (idClass > 0)
                    {
                        MessageBox.Show("");
                    }
                }
            }
        }
    }

}

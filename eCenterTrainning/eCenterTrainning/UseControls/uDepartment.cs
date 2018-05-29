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
    public partial class uDepartment : DevExpress.XtraEditors.XtraUserControl
    {
        public uDepartment()
        {
            InitializeComponent();
        }
        private int idDept = 0;
        private void uDepartment_Load(object sender, EventArgs e)
        {
            actionMenuDepartment.PressNew += new EventHandler(actionMenuDepartment_PressNew);
            actionMenuDepartment.PressEdit += new EventHandler(actionMenuDepartment_PressEdit);
            actionMenuDepartment.PressDelete += new EventHandler(actionMenuDepartment_PressDelete);
            actionMenuDepartment.PressRefresh += new EventHandler(actionMenuDepartment_PressRefresh);
            actionMenuDepartment.PressClose += new EventHandler(actionMenuDepartment_PressClose);
            actionMenuDepartment.PressHelp += new EventHandler(actionMenuDepartment_PressHelp);
            displayDepartment();
        }
        void actionMenuDepartment_PressHelp(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng này chưa cập nhật", "Thông Báo");
        }

        void actionMenuDepartment_PressClose(object sender, EventArgs e)
        {
            this.Dispose();
        }

        void actionMenuDepartment_PressRefresh(object sender, EventArgs e)
        {
            displayDepartment();
        }
        /// <summary>
        /// Author          Date        Comment
        /// BONGVX                      Xoa thong tin phong ban
        /// </summary>
        void actionMenuDepartment_PressDelete(object sender, EventArgs e)
        {
            String value = "" + gridViewDepartment.GetFocusedRowCellValue("Id");
            int.TryParse(value, out idDept);
            MessageBox.Show("");
        }
        /// <summary>
        /// Author          Date        Comment
        /// BONGVX                      Sua thong tin phong ban
        /// </summary>
        void actionMenuDepartment_PressEdit(object sender, EventArgs e)
        {
            String value = "" + gridViewDepartment.GetFocusedRowCellValue("Id");
            int.TryParse(value, out idDept);
            if (idDept > 0)
            {
                frmPhongBan frm = new frmPhongBan();
                //frm.IdDept = idDept;                
            }
            else
            {
                MessageBox.Show("Hãy chọn phòng ban cần cập nhật", "Thông báo");
            }
            displayDepartment();
        }
        /// <summary>
        /// Author          Date        Comment
        /// BONGVX                      Them thong tin phong ban
        /// </summary>
        void actionMenuDepartment_PressNew(object sender, EventArgs e)
        {
            MessageBox.Show("");
        }
        /// <summary>
        /// Author          Date        Comment
        /// BONGVX                      danh sach thong tin phong ban
        /// </summary>
        private void displayDepartment()
        {
            
        }
        /// <summary>
        /// Author          Date        Comment
        /// BONGVX                      Xem chi tiet thong tin phong ban
        /// </summary>
        private void gridControlDepartment_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            String value = "" + gridViewDepartment.GetFocusedRowCellValue("Id");
            int.TryParse(value, out idDept);
            if (idDept > 0)
            {
                MessageBox.Show("");
            }
        }

        private void xtraTabControlDepartment_Click(object sender, EventArgs e)
        {
            if (xtraTabControlDepartment.SelectedTabPageIndex == 1)
            {
                int idDepartmet = 0;
                string value = "" + gridViewDepartment.GetFocusedRowCellValue("Id");
                int.TryParse(value, out idDepartmet);
                if (idDepartmet > 0)
                {
                    lookUpEditDepartment.EditValue = idDepartmet;
                }
            }
        }
        /// <summary>
        /// Author          Date        Comment
        /// BONGVX                      tim kiem nhan vien theo phong ban
        /// </summary>
        private void lookUpEditDepartment_EditValueChanged(object sender, EventArgs e)
        {
            int idDepartmet = 0;
            string value = "" + lookUpEditDepartment.EditValue;
            int.TryParse(value, out idDepartmet);
            if (idDepartmet > 0)
            {
                MessageBox.Show("");
            }
        }
        /// <summary>
        /// Author          Date        Comment
        /// BONGVX                      Xem chi tiet thong tin chi tiet nhan vien
        /// </summary>
        private void gridViewEmployee_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            if (e.Column == colChiTiet)
            {
                int idEmp = 0;
                string value = "" + gridViewEmployee.GetFocusedRowCellValue("Id");
                int.TryParse(value, out idEmp);
                if (idEmp > 0)
                {
                    MessageBox.Show("");
                }
            }
        }

        
    }
}

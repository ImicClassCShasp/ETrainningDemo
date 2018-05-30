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
    public partial class uEmployee : DevExpress.XtraEditors.XtraUserControl
    {
        public uEmployee()
        {
            InitializeComponent();
        }
        private int idEpm = 0;
        private void uEmployee_Load(object sender, EventArgs e)
        {
            actionMenuEmployee.PressNew += new EventHandler(actionMenuEmployee_PressNew);
            actionMenuEmployee.PressEdit += new EventHandler(actionMenuEmployee_PressEdit);
            actionMenuEmployee.PressDelete += new EventHandler(actionMenuEmployee_PressDelete);
            actionMenuEmployee.PressRefresh += new EventHandler(actionMenuEmployee_PressRefresh);
            actionMenuEmployee.PressClose += new EventHandler(actionMenuEmployee_PressClose);
            actionMenuEmployee.PressHelp += new EventHandler(actionMenuEmployee_PressHelp);

            displayEmployee();
        }
        void actionMenuEmployee_PressHelp(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng này chưa cập nhật", "Thông Báo");
        }

        void actionMenuEmployee_PressClose(object sender, EventArgs e)
        {

            this.Dispose();

        }

        void actionMenuEmployee_PressRefresh(object sender, EventArgs e)
        {
            displayEmployee();
        }
        /// <summary>
        /// Author          Date        Comment
        /// BONGVX                      Xoa thong tin NV
        /// </summary>
        void actionMenuEmployee_PressDelete(object sender, EventArgs e)
        {
            String value = "" + gridViewEmployee.GetFocusedRowCellValue("Id");
            int.TryParse(value, out idEpm);
            if (idEpm > 0)
            {
                DialogResult dr = MessageBox.Show("Bạn chắc muốn xóa nhân viên này", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    MessageBox.Show("");
                }
            }
            else
            {
                MessageBox.Show("Hãy chọn nhân viên cần xóa", "Thông báo");
            }
           
        }
        /// <summary>
        /// Author          Date        Comment
        /// BONGVX                      Sua thong tin NV
        /// </summary>
        void actionMenuEmployee_PressEdit(object sender, EventArgs e)
        {
            String value = "" + gridViewEmployee.GetFocusedRowCellValue("Id");
            int.TryParse(value, out idEpm);
            if (idEpm > 0)
            {
                MessageBox.Show("");
            }
            else {
                MessageBox.Show("Hãy chọn nhân viên cần cập nhật","Thông báo");
            }
          
        }

        /// <summary>
        /// Author          Date        Comment
        /// BONGVX                      Them thong tin NV
        /// </summary>
        void actionMenuEmployee_PressNew(object sender, EventArgs e)
        {
            MessageBox.Show("");
        }
        /// <summary>
        /// Author          Date        Comment
        /// BONGVX                      Hien thi thong tin NV
        /// </summary>
        private void displayEmployee()
        {
            
        }
        /// <summary>
        /// Author          Date        Comment
        /// BONGVX                      Hien thi thong tin NV chi tiet
        /// </summary>
        private void gridControlEmployee_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            String value = "" + gridViewEmployee.GetFocusedRowCellValue("Id");
            int.TryParse(value, out idEpm);
            if (idEpm > 0)
            {
                MessageBox.Show("");
            }
        }
        /// <summary>
        /// Author          Date        Comment
        /// BONGVX                      Hien thi thong tin CV NV
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

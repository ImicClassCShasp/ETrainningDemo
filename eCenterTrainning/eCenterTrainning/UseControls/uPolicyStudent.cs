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
    public partial class uPolicyStudent : DevExpress.XtraEditors.XtraUserControl
    {
        public uPolicyStudent()
        {
            InitializeComponent();
        }
        private int idPolicyStu = 0;
        private void uPolicyStudent_Load(object sender, EventArgs e)
        {
            actionMenuPolicyStudent.PressNew += new EventHandler(actionMenuPolicyStudent_PressNew);
            actionMenuPolicyStudent.PressEdit += new EventHandler(actionMenuPolicyStudent_PressEdit);
            actionMenuPolicyStudent.PressDelete += new EventHandler(actionMenuPolicyStudent_PressDelete);
            actionMenuPolicyStudent.PressClose += new EventHandler(actionMenuPolicyStudent_PressClose);
            actionMenuPolicyStudent.PressRefresh += new EventHandler(actionMenuPolicyStudent_PressRefresh);
            actionMenuPolicyStudent.PressHelp += new EventHandler(actionMenuPolicyStudent_PressHelp);
            displayPolicyStudent();
        }

        void actionMenuPolicyStudent_PressHelp(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng này chưa được cập nhật","Thông báo");
        }

        void actionMenuPolicyStudent_PressRefresh(object sender, EventArgs e)
        {
            displayPolicyStudent();
        }

        void actionMenuPolicyStudent_PressClose(object sender, EventArgs e)
        {
            this.Dispose();
        }

        void actionMenuPolicyStudent_PressDelete(object sender, EventArgs e)
        {
            String value = "" + gridViewPolicyStudent.GetFocusedRowCellValue("Id");
            int.TryParse(value, out idPolicyStu);
            
            if (idPolicyStu > 0)
            {
                MessageBox.Show("");
            }
            else
            {
                MessageBox.Show("Hãy chọn chương trình ưu đãi cần xóa", "Thông báo");
            }
           
        }
        /// <summary>
        /// Author          Date        Comment
        /// BONGVX                      sua thong tin uu dai
        /// </summary>
        void actionMenuPolicyStudent_PressEdit(object sender, EventArgs e)
        {
            String value = "" + gridViewPolicyStudent.GetFocusedRowCellValue("Id");
            int.TryParse(value, out idPolicyStu);
            if (idPolicyStu > 0)
            {
                MessageBox.Show("");
            }
            else {
                MessageBox.Show("Hãy chọn chương trình ưu đãi cần cập nhật", "Thông báo");
            }
          
        }
        /// <summary>
        /// Author          Date        Comment
        /// BONGVX                      Them thong tin uu dai
        /// </summary>
        void actionMenuPolicyStudent_PressNew(object sender, EventArgs e)
        {
            MessageBox.Show("");
        }
        /// <summary>
        /// Author          Date        Comment
        /// BONGVX                      Hien thi thong tin uu dai
        /// </summary>
        private void displayPolicyStudent() {
            
        }
        /// <summary>
        /// Author          Date        Comment
        /// BONGVX                      Xem thong tin chi tiet
        /// </summary>
        private void gridControlPolicyStudent_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            String value = "" + gridViewPolicyStudent.GetFocusedRowCellValue("Id");
            int.TryParse(value, out idPolicyStu);
            if (idPolicyStu > 0)
            {
                MessageBox.Show("");
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            displayPolicyStudent();
        }
        /// <summary>
        /// Author          Date        Comment
        /// BONGVX                      Xem noi dung chi tiet chuong trinh
        /// </summary>
        private void gridViewPolicyStudent_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            if (e.Column == colChiTiet)
            {
                int idPol = 0;
                string id = ""+ gridViewPolicyStudent.GetFocusedRowCellValue("Id");
                int.TryParse(id, out idPol);
                if (idPol > 0)
                {
                    MessageBox.Show("");
                }
            }
        }        
    }
}

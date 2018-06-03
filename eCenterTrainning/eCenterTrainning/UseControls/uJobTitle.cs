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
    public partial class uJobTitle : DevExpress.XtraEditors.XtraUserControl
    {
        public uJobTitle()
        {
            InitializeComponent();
        }

        private int idChucVu = 0;
        private void uJobTitle_Load(object sender, EventArgs e)
        {
            actionMenuChucVu.PressNew += new EventHandler(actionMenuChucVu_PressNew);
            actionMenuChucVu.PressEdit += new EventHandler(actionMenuChucVu_PressEdit);
            actionMenuChucVu.PressDelete += new EventHandler(actionMenuChucVu_PressDelete);
            actionMenuChucVu.PressRefresh += new EventHandler(actionMenuChucVu_PressRefresh);
            actionMenuChucVu.PressClose += new EventHandler(actionMenuChucVu_PressClose);
            actionMenuChucVu.PressHelp += new EventHandler(actionMenuChucVu_PressHelp);
            this.Text = "Danh sách chức vụ";
            displaChucVu();
        }

        void actionMenuChucVu_PressHelp(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng này chưa được cập nhật");
        }

        void actionMenuChucVu_PressClose(object sender, EventArgs e)
        {
            this.Dispose();
        }

        void actionMenuChucVu_PressRefresh(object sender, EventArgs e)
        {
            displaChucVu();
        }

        /// <summary>
        /// Author          Date        Comment
        /// BONGVX                      Xoa thong tin chuc vu
        /// </summary>
        void actionMenuChucVu_PressDelete(object sender, EventArgs e)
        {
            String value = "" + gridViewChucVu.GetFocusedRowCellValue("Id");
            int.TryParse(value, out idChucVu);
            MessageBox.Show("");
        }
        /// <summary>
        /// Author          Date        Comment
        /// BONGVX                      Sua thong tin chuc vu
        /// </summary>
        void actionMenuChucVu_PressEdit(object sender, EventArgs e)
        {
            String value = "" + gridViewChucVu.GetFocusedRowCellValue("Id");
            int.TryParse(value, out idChucVu);
            if (idChucVu > 0)
            {
                MessageBox.Show("");
            }
            else
            {
                MessageBox.Show("Hãy chọn chức vụ cần cập nhật", "Thông báo");
            }
            displaChucVu();
        }
        /// <summary>
        /// Author          Date        Comment
        /// BONGVX                      Them thong tin chuc vu
        /// </summary>
        void actionMenuChucVu_PressNew(object sender, EventArgs e)
        {
            MessageBox.Show("");
        }
        /// <summary>
        /// Author          Date        Comment
        /// BONGVX                      Hien thi danh sach thong tin chuc vu
        /// </summary>
        private void displaChucVu()
        {
            
        }
        /// <summary>
        /// Author          Date        Comment
        /// BONGVX                      Xem chi tiet thong tin chuc vu
        /// </summary>
        private void gridControlChucVu_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            String value = "" + gridViewChucVu.GetFocusedRowCellValue("Id");
            int.TryParse(value, out idChucVu);
            if (idChucVu > 0)
            {
                MessageBox.Show("");
            }
        }
    }
}

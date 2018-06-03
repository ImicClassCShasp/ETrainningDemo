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
    public partial class uCustomers : DevExpress.XtraEditors.XtraUserControl
    {
        public uCustomers()
        {
            InitializeComponent();
        }
        private int idCus = 0;
        private void uCustomers_Load(object sender, EventArgs e)
        {
            actionMenuCustomers.PressNew += new EventHandler(actionMenuCustomers_PressNew);
            actionMenuCustomers.PressEdit += new EventHandler(actionMenuCustomers_PressEdit);
            actionMenuCustomers.PressDelete += new EventHandler(actionMenuCustomers_PressDelete);
            actionMenuCustomers.PressClose += new EventHandler(actionMenuCustomers_PressClose);
            actionMenuCustomers.PressRefresh += new EventHandler(actionMenuCustomers_PressRefresh);
            actionMenuCustomers.PressHelp += new EventHandler(actionMenuCustomers_PressHelp);
            displayCustomer();
        }

        void actionMenuCustomers_PressHelp(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng này chưa được cập nhật","Thông Báo");
        }

        void actionMenuCustomers_PressRefresh(object sender, EventArgs e)
        {
            displayCustomer();
        }

        void actionMenuCustomers_PressClose(object sender, EventArgs e)
        {
            this.Dispose();
        }
        /// <summary>
        /// Author          Date        Comment
        /// BONGVX                      xoa thong tin KH
        /// </summary>
        void actionMenuCustomers_PressDelete(object sender, EventArgs e)
        {
            String value = "" + gridViewCustomer.GetFocusedRowCellValue("Id");
            int.TryParse(value, out idCus);
            if (idCus > 0)
            {
                MessageBox.Show("");
                DialogResult dr = MessageBox.Show("Bạn chắc muốn xóa khách hàng này", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    MessageBox.Show("");
                }
            }
            else
            {
                MessageBox.Show("Hãy chọn khách hàng cần xóa", "Thông báo");
            }
        }
        /// <summary>
        /// Author          Date        Comment
        /// BONGVX                      Sua thong tin KH
        /// </summary>
        void actionMenuCustomers_PressEdit(object sender, EventArgs e)
        {
            String value = "" + gridViewCustomer.GetFocusedRowCellValue("Id");
            int.TryParse(value,out idCus);
            if (idCus > 0)
            {
                frmKhachHang frm = new frmKhachHang();
                MessageBox.Show("");
            }
            else
            {
                MessageBox.Show("Hãy chọn khách hàng cần cập nhật", "Thông báo");
            }
        }
        /// <summary>
        /// Author          Date        Comment
        /// BONGVX                      Them thong tin KH
        /// </summary>
        void actionMenuCustomers_PressNew(object sender, EventArgs e)
        {
            frmKhachHang frm = new frmKhachHang();
            MessageBox.Show("");
        }
        /// <summary>
        /// Author          Date        Comment
        /// BONGVX                      Hien thi thong tin KH
        /// </summary>
        private void displayCustomer() {
            MessageBox.Show("");
        }
        /// <summary>
        /// Author          Date        Comment
        /// BONGVX                      Hien thi thong tin KH chi tiet
        /// </summary>
        private void gridControlCustomer_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            String value = "" + gridViewCustomer.GetFocusedRowCellValue("Id");
            int.TryParse(value, out idCus);
            if (idCus > 0)
            {
                MessageBox.Show("");
            }
        }
    }
}

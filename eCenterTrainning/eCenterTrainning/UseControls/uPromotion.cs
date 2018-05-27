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
    public partial class uPromotion : DevExpress.XtraEditors.XtraUserControl
    {
        public uPromotion()
        {
            InitializeComponent();
        }
        private int IdPro = 0;
        private void uPromotion_Load(object sender, EventArgs e)
        {
            this.Text = "Thông tin quảng cáo khóa học";
            actionMenuPromotion.PressNew += new EventHandler(actionMenuPromotion_PressNew);
            actionMenuPromotion.PressEdit += new EventHandler(actionMenuPromotion_PressEdit);
            actionMenuPromotion.PressDelete += new EventHandler(actionMenuPromotion_PressDelete);
            actionMenuPromotion.PressRefresh += new EventHandler(actionMenuPromotion_PressRefresh);
            actionMenuPromotion.PressClose += new EventHandler(actionMenuPromotion_PressClose);
            actionMenuPromotion.PressHelp += new EventHandler(actionMenuPromotion_PressHelp);
            displayPromotion();
        }
        void actionMenuPromotion_PressHelp(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng này chưa được cập nhật", "Thông Báo");
        }

        void actionMenuPromotion_PressClose(object sender, EventArgs e)
        {
            this.Dispose();
        }

        void actionMenuPromotion_PressRefresh(object sender, EventArgs e)
        {
            displayPromotion();
        }
        /// <summary>
        /// Author          Date        Comment
        /// BONGVX                      Xoa thong tin quang ba khoa hoc
        /// </summary>
        void actionMenuPromotion_PressDelete(object sender, EventArgs e)
        {
            String value = "" + gridViewPromotion.GetFocusedRowCellValue("Id");
            int.TryParse(value, out IdPro);
            if (IdPro > 0)
            {
                DialogResult dr = MessageBox.Show("Bạn chắc muốn xóa quảng cáo khóa học này ", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    MessageBox.Show("");
                }
            }
            else
            {
                MessageBox.Show("Hãy chọn quảng cáo khóa học cần xóa", "Thông báo");
            }

        }
        /// <summary>
        /// Author          Date        Comment
        /// BONGVX                      sua thong tin quang ba khoa hoc
        /// </summary>
        void actionMenuPromotion_PressEdit(object sender, EventArgs e)
        {
            String value = "" + gridViewPromotion.GetFocusedRowCellValue("Id");
            int.TryParse(value, out IdPro);
            if (IdPro > 0)
            {
                MessageBox.Show("");
            }
            else
            {
                MessageBox.Show("Hãy chọn quảng cáo khóa học cần cập nhật", "Thông báo");
            }

        }
        /// <summary>
        /// Author          Date        Comment
        /// BONGVX                      Them thong tin quang ba
        /// </summary>
        void actionMenuPromotion_PressNew(object sender, EventArgs e)
        {
            MessageBox.Show("");
        }
        /// <summary>
        /// Author          Date        Comment
        /// BONGVX                      hien thi danh sach quang ba
        /// </summary>
        private void displayPromotion()
        {
            
        }

        private void gridControlPromotion_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            String value = "" + gridViewPromotion.GetFocusedRowCellValue("Id");
            int.TryParse(value, out IdPro);
            if (IdPro > 0)
            {
                MessageBox.Show("");
            }

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            displayPromotion();
        }

        private void gridViewPromotion_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {

            if (e.Column == colChiTiet)
            {
                int idPro = 0;
                string id = "" + gridViewPromotion.GetFocusedRowCellValue("Id");
                int.TryParse(id, out idPro);
                if (idPro > 0)
                {
                    MessageBox.Show("");
                }
            }
        }
    }
}

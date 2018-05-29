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
    public partial class uCenter : DevExpress.XtraEditors.XtraUserControl
    {
        public uCenter()
        {
            InitializeComponent();
        }
        private int idCenter = 0;
        private void uCenter_Load(object sender, EventArgs e)
        {
            this.Text = "Danh sách trung tâm";
            actionMenuCenter.PressNew += new EventHandler(actionMenuCenter_PressNew);
            actionMenuCenter.PressEdit += new EventHandler(actionMenuCenter_PressEdit);
            actionMenuCenter.PressDelete += new EventHandler(actionMenuCenter_PressDelete);
            actionMenuCenter.PressRefresh += new EventHandler(actionMenuCenter_PressRefresh);
            actionMenuCenter.PressClose += new EventHandler(actionMenuCenter_PressClose);
            actionMenuCenter.PressHelp += new EventHandler(actionMenuCenter_PressHelp);

            displayCenter();
 
        }
        void actionMenuCenter_PressHelp(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng này chưa cập nhật", "Thông Báo");
        }

        void actionMenuCenter_PressClose(object sender, EventArgs e)
        {
            this.Dispose();
        }

        void actionMenuCenter_PressRefresh(object sender, EventArgs e)
        {
            displayCenter();
        }
        /// <summary>
        /// Author          Date        Comment
        /// BONGVX                      Xoa thong tin trung tam
        /// </summary>
        void actionMenuCenter_PressDelete(object sender, EventArgs e)
        {
            String value = "" + gridViewCenter.GetFocusedRowCellValue("Id");
            int.TryParse(value, out idCenter);
            MessageBox.Show("");

            if (idCenter > 0)
            {
                DialogResult dr = MessageBox.Show("Bạn chắc muốn xóa trung tâm này", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    MessageBox.Show("");
                }
            }
            else
            {
                MessageBox.Show("Hãy chọn trung tâm cần xóa", "Thông báo");
            }
            displayCenter();
        }
        /// <summary>
        /// Author          Date        Comment
        /// BONGVX                      Sua thong tin trung tam
        /// </summary>

        void actionMenuCenter_PressEdit(object sender, EventArgs e)
        {
            String value = "" + gridViewCenter.GetFocusedRowCellValue("Id");
            int.TryParse(value, out idCenter);
            if (idCenter > 0)
            {
                MessageBox.Show("");
            }
            else
            {
                MessageBox.Show("Hãy chọn trung tâm cần cập nhật", "Thông báo");
            }
            displayCenter();
        }
        /// <summary>
        /// Author          Date        Comment
        /// BONGVX                      Them thong tin trung tam
        /// </summary>
        void actionMenuCenter_PressNew(object sender, EventArgs e)
        {
            MessageBox.Show("");
        }
        /// <summary>
        /// Author          Date        Comment
        /// BONGVX                      hien thi thong tin trung tam
        /// </summary>
        private void displayCenter()
        {
            MessageBox.Show("");
        }

        /// <summary>
        /// Author          Date        Comment
        /// BONGVX                      Xem chi thong tin trung tam
        /// </summary>
        private void gridControlCenter_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            String value = "" + gridViewCenter.GetFocusedRowCellValue("Id");
            int.TryParse(value, out idCenter);
            if (idCenter > 0)
            {
                MessageBox.Show("");
            }

        }
    }
}

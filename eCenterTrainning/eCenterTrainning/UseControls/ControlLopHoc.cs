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
    public partial class ControlLopHoc : DevExpress.XtraEditors.XtraUserControl
    {
        public ControlLopHoc()
        {
            InitializeComponent();
        }

        private void ControlLopHoc_Load(object sender, EventArgs e)
        {
            actionMenu1.PressNew += new EventHandler(actionMenu1_PressNew);
            actionMenu1.PressEdit += new EventHandler(actionMenu1_PressEdit);
            actionMenu1.PressDelete += new EventHandler(actionMenu1_PressDelete);
            actionMenu1.PressClose += new EventHandler(actionMenu1_PressClose);
            actionMenu1.PressHelp += new EventHandler(actionMenu1_PressHelp);
            actionMenu1.PressRefresh += new EventHandler(actionMenu1_PressRefresh);

            HienThiLopHoc();
        }

        void actionMenu1_PressRefresh(object sender, EventArgs e)
        {
            HienThiLopHoc();
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
            int intClassId = 0;
            int.TryParse("" + gridViewClass.GetFocusedRowCellValue("Id"), out intClassId);
            if (intClassId > 0)
            {
                DialogResult dlg = MessageBox.Show("Bạn có chắc chắn muốn xóa thông tin này ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dlg == DialogResult.Yes)
                {
                    MessageBox.Show("");  
                }
                HienThiLopHoc();
            }
            else
            {
                MessageBox.Show("Bạn cần chọn thông tin để thực hiện thao tác này !!!", "Thông báo");
            }
        }

        void actionMenu1_PressEdit(object sender, EventArgs e)
        {
            int intClassId = 0;

            int.TryParse("" + gridViewClass.GetFocusedRowCellValue("Id"), out intClassId);

            if (intClassId > 0)
            { MessageBox.Show(""); }
            else
            {
                MessageBox.Show("Bạn cần chọn thông tin trước khi thực hiện", "Thông báo");
            }
        }

        void actionMenu1_PressNew(object sender, EventArgs e)
        {
            
        }
        private void HienThiLopHoc()
        {
                      
        }
    }
}

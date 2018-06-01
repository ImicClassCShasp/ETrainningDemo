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
    public partial class uViewSchedulesInfo : DevExpress.XtraEditors.XtraUserControl
    {
        public uViewSchedulesInfo()
        {
            InitializeComponent();
        }
        private int idSchedules=0;
        private void uViewSchedulesInfo_Load(object sender, EventArgs e)
        {
            actionMenuSchedule.PressNew += new EventHandler(actionMenuSchedule_PressNew);
            actionMenuSchedule.PressEdit += new EventHandler(actionMenuSchedule_PressEdit);
            actionMenuSchedule.PressDelete += new EventHandler(actionMenuSchedule_PressDelete);
            actionMenuSchedule.PressRefresh += new EventHandler(actionMenuSchedule_PressRefresh);
            actionMenuSchedule.PressClose += new EventHandler(actionMenuSchedule_PressClose);
            actionMenuSchedule.PressHelp += new EventHandler(actionMenuSchedule_PressHelp);
            LoadExpertInfo();
            displaySchedules(3);            
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
            String getValue = uluThongTinChuyenGia.EditValue.ToString();
            int iExperId = 0;
            if (int.TryParse(getValue, out iExperId))
            {
                displaySchedules(iExperId);
            }
            else
            {
                displaySchedules(3);
            }
        }
        /// <summary>
        /// Author          Date        Comment
        /// BONGVX                      Xoa thong tin giang vien
        /// </summary>
        void actionMenuSchedule_PressDelete(object sender, EventArgs e)
        {
            String value = "" + grdViewLichGiangday.GetFocusedRowCellValue("Id");
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
            String value = "" + grdViewLichGiangday.GetFocusedRowCellValue("Id");
            int.TryParse(value, out idSchedules);
            if (idSchedules > 0)
            {
                String expertId = "" + grdViewLichGiangday.GetFocusedRowCellValue("ExpertId");
                MessageBox.Show("");
            }
            else
            {
                MessageBox.Show("Hãy chọn nhật ký cần cập nhật", "Thông báo");
            }            
        }
        
        void actionMenuSchedule_PressNew(object sender, EventArgs e)
        {
            frmSchedulesExpertAdd frmAdd = new frmSchedulesExpertAdd();          
                     
        }

        /// <summary>
        /// Author          Date        Comment
        /// DOANNV                      Hien thi thong tin GV
        /// </summary>
        public void displaySchedules(int iExpertId)
        {
            MessageBox.Show("");
        }

        void LoadExpertInfo() {
            MessageBox.Show("");
            //uluThongTinChuyenGia.Properties.DataSource = lisExpert;
            uluThongTinChuyenGia.Properties.DisplayMember = "ExpertName";
            uluThongTinChuyenGia.Properties.ValueMember = "Id";
        }                             

        private void grdControlLichGiangday_DoubleClick(object sender, EventArgs e)
        {
            String value = "" + grdViewLichGiangday.GetFocusedRowCellValue("Id");
            int.TryParse(value, out idSchedules);
            if (idSchedules > 0)
            {
                String expertId = "" + grdViewLichGiangday.GetFocusedRowCellValue("ExpertId");
                MessageBox.Show("");
            }
            else
            {
                MessageBox.Show("Hãy chọn nhật ký cần cập nhật", "Thông báo");
            }          
        }

        private void btnXemLichGiangDay_Click(object sender, EventArgs e)
        {
            String getValue = ""+uluThongTinChuyenGia.EditValue;
            int iExpertId = 0;
            if (int.TryParse(getValue, out iExpertId))
            {
                displaySchedules(iExpertId);
            }
            else {
                MessageBox.Show("Vui lòng chọn thông tin Chuyên Gia cần xem trước khi thực hiện!",
                            "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);                            
            }            
        }

        private void grdViewLichGiangday_CustomDrawCardCaption(object sender, DevExpress.XtraGrid.Views.Card.CardCaptionCustomDrawEventArgs e)
        {
            DevExpress.XtraGrid.Views.Card.CardView view = sender as DevExpress.XtraGrid.Views.Card.CardView;
            (e.CardInfo as DevExpress.XtraGrid.Views.Card.ViewInfo.CardInfo).CaptionInfo.CardCaption = view.GetRowCellDisplayText(e.RowHandle, view.Columns["ClassName"]);
        }
    }
}

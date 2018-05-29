using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace eCenterTrainning.UseControls
{
    public partial class ucEventFaceBooks : UserControl
    {
        //private tblEventFaceBook m_objEventFaceBook;

        public ucEventFaceBooks()
        {
            InitializeComponent();
            actionMenu1.PressNew += new EventHandler(actionMenu1_PressNew);
            actionMenu1.PressEdit += new EventHandler(actionMenu1_PressEdit);
            actionMenu1.PressRefresh += new EventHandler(actionMenu1_PressRefresh);
            actionMenu1.PressDelete += new EventHandler(actionMenu1_PressDelete);
            actionMenu1.PressClose += new EventHandler(actionMenu1_PressClose);
            actionMenu1.PressHelp += new EventHandler(actionMenu1_PressHelp);

            HienThiThongTinChiTietEventFaceBooks();
            HienThiTaiKhoanFB();
            HienThiChiTietHoiNhom();
            HienThiNgayBaoCao();
            //m_objEventFaceBook = new tblEventFaceBook();
        }

        void actionMenu1_PressHelp(object sender, EventArgs e)
        {
            this.Hide();
        }
        void actionMenu1_PressClose(object sender, EventArgs e)
        {
            this.Hide();
        }
        void actionMenu1_PressDelete(object sender, EventArgs e)
        {
            int EventId = 0;
            int.TryParse("" + grVEventFB.GetFocusedRowCellValue("EventId"), out EventId);
            if (EventId > 0)
            {
                DialogResult dr = MessageBox.Show("Bạn chắc là muốn xóa sự kiện này!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    MessageBox.Show("");
                }
            }
        }
        void actionMenu1_PressRefresh(object sender, EventArgs e)
        {
            HienThiThongTinChiTietEventFaceBooks();
            HienThiNgayBaoCao();
            txtEvents.Text = "";
            txtFind.Text = "";
            uluTKFaces.Text = "";
            uluHoiNhom.Text = "";
        }
        void actionMenu1_PressEdit(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtEvents.Text))
            {
                dxErrorProvider1.SetError(txtEvents, "Yêu cầu nhập vào tên sự kiện mà bạn truyền thông!");
                txtEvents.Focus();
                return;
            }
            else if (String.IsNullOrEmpty(uluTKFaces.Text))
            {
                dxErrorProvider1.SetError(uluTKFaces, "Yêu cầu chọn tài khoản FB!");
                uluTKFaces.Focus();
                return;
            }
            else if (String.IsNullOrEmpty(uluHoiNhom.Text))
            {
                dxErrorProvider1.SetError(uluHoiNhom, "Yêu cầu chọn hội nhóm đã đăng tải!");
                uluHoiNhom.Focus();
                return;
            }
            else {
                MessageBox.Show("");
            }
        }
        void actionMenu1_PressNew(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtEvents.Text))
            {
                dxErrorProvider1.SetError(txtEvents, "Yêu cầu nhập vào tên sự kiện mà bạn truyền thông!");
                txtEvents.Focus();
                return;
            }
            else if (String.IsNullOrEmpty(uluTKFaces.Text))
            {
                dxErrorProvider1.SetError(uluTKFaces, "Yêu cầu chọn tài khoản FB!");
                uluTKFaces.Focus();
                return;
            }
            else if (String.IsNullOrEmpty(uluHoiNhom.Text))
            {
                dxErrorProvider1.SetError(uluHoiNhom, "Yêu cầu chọn hội nhóm đã đăng tải!");
                uluHoiNhom.Focus();
                return;
            }
            else {
                MessageBox.Show("");
            }            
        }
        private void HienThiThongTinChiTietEventFaceBooks()
        {
            MessageBox.Show("");
        }

        void HienThiTaiKhoanFB() {
            MessageBox.Show("");
        }

        void HienThiChiTietHoiNhom() {
            MessageBox.Show("");
        }

        void HienThiNgayBaoCao() {
            MessageBox.Show("");
        }

        private void textEdit2_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            MessageBox.Show("");
        }

        private void textEdit2_EditValueChanged(object sender, EventArgs e)
        {
            //MessageBox.Show("Changed");
        }

        private void grVEventFB_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            int EventID = 0;
            int.TryParse("" + grVEventFB.GetFocusedRowCellValue("EventId"), out EventID);
            if (EventID > 0)
            {
                MessageBox.Show("");
            }
        }
    }
}

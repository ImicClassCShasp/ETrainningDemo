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
    public partial class ucDetailFaceBooks : UserControl
    {
        public ucDetailFaceBooks()
        {
            InitializeComponent();
            actionMenu1.PressNew += new EventHandler(actionMenu1_PressNew);
            actionMenu1.PressEdit += new EventHandler(actionMenu1_PressEdit);
            actionMenu1.PressRefresh += new EventHandler(actionMenu1_PressRefresh);
            actionMenu1.PressDelete += new EventHandler(actionMenu1_PressDelete);
            actionMenu1.PressClose += new EventHandler(actionMenu1_PressClose);
            actionMenu1.PressHelp += new EventHandler(actionMenu1_PressHelp);

            HienThiThongTinChiTietFaceBooks();
            HienThiTaiKhoanFB();
        }
        void actionMenu1_PressNew(object sender, EventArgs e)
        {
             if(String.IsNullOrEmpty(txtHoiNhom.Text)){
                dxErrorProvider1.SetError(txtHoiNhom, "Yêu cầu nhập vào tên của hội nhóm!");
                txtHoiNhom.Focus();
                return;
            }
            else if(String.IsNullOrEmpty(txtLinkFB.Text)){
                dxErrorProvider1.SetError(txtLinkFB, "Yêu cầu nhập vào link của Hội Nhóm này!");
                txtLinkFB.Focus();
                return;
            }
             else if (String.IsNullOrEmpty(uluTaiKhoanFB.Text))
             {
                 dxErrorProvider1.SetError(uluTaiKhoanFB, "Yêu cầu chọn tài khoản FB đã join vào Hội Nhóm này!");
                 uluTaiKhoanFB.Focus();
                 return;
             }
             else {
                MessageBox.Show("");
            }
        }
        void actionMenu1_PressEdit(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(txtHoiNhom.Text)){
                dxErrorProvider1.SetError(txtHoiNhom, "Yêu cầu nhập vào tên của hội nhóm!");
                txtHoiNhom.Focus();
                return;
            }
            else if(String.IsNullOrEmpty(txtLinkFB.Text)){
                dxErrorProvider1.SetError(txtLinkFB, "Yêu cầu nhập vào link của Hội Nhóm này!");
                txtLinkFB.Focus();
                return;
            }
            else if (String.IsNullOrEmpty(uluTaiKhoanFB.Text))
            {
                dxErrorProvider1.SetError(uluTaiKhoanFB, "Yêu cầu chọn tài khoản FB đã join vào Hội Nhóm này!");
                uluTaiKhoanFB.Focus();
                return;
            }
            else {
                MessageBox.Show("");
            }
        }
        void actionMenu1_PressRefresh(object sender, EventArgs e)
        {
            HienThiThongTinChiTietFaceBooks();
        }
        void actionMenu1_PressDelete(object sender, EventArgs e)
        {
            int DetaiId = 0;
            int.TryParse("" + grVDetailFacebooks.GetFocusedRowCellValue("DetailId"), out DetaiId);
            if (DetaiId > 0)
            {
                DialogResult dr = MessageBox.Show("Bạn chắc là muốn xóa Hội NHóm này!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    MessageBox.Show("");
                }
            }
        }
        void actionMenu1_PressClose(object sender, EventArgs e)
        {
            this.Hide();
        }
        void actionMenu1_PressHelp(object sender, EventArgs e)
        {

        }
        private void HienThiThongTinChiTietFaceBooks()
        {
            MessageBox.Show("");
        }

        private void HienThiTaiKhoanFB()
        {
            MessageBox.Show("");
        }

        private void grVDetailFacebooks_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            int DetaiID = 0;
            int.TryParse("" + grVDetailFacebooks.GetFocusedRowCellValue("DetailId"), out DetaiID);
            if (DetaiID > 0)
            {
                lblDetailID.Text = "" + DetaiID;
                txtHoiNhom.Text = "" + grVDetailFacebooks.GetFocusedRowCellValue("GroupName");
                txtLinkFB.Text = "" + grVDetailFacebooks.GetFocusedRowCellValue("Links");
                uluTaiKhoanFB.Text = "" + grVDetailFacebooks.GetFocusedRowCellValue("FaceName");
                txtThanhVien.Text = "" + grVDetailFacebooks.GetFocusedRowCellValue("MemberOf");
                chkStatusFB.Checked = bool.Parse("" + grVDetailFacebooks.GetFocusedRowCellValue("Status"));
            }
        }

        private void grVDetailFacebooks_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            int DetaiID = 0;
            int.TryParse("" + grVDetailFacebooks.GetFocusedRowCellValue("DetailId"), out DetaiID);
            if (DetaiID > 0) {
                lblDetailID.Text = "" + DetaiID;
                txtHoiNhom.Text = "" + grVDetailFacebooks.GetFocusedRowCellValue("GroupName");
                txtLinkFB.Text = "" + grVDetailFacebooks.GetFocusedRowCellValue("Links");
                uluTaiKhoanFB.Text = "" + grVDetailFacebooks.GetFocusedRowCellValue("FaceName");
                txtThanhVien.Text = "" + grVDetailFacebooks.GetFocusedRowCellValue("MemberOf");
                chkStatusFB.Checked = bool.Parse("" + grVDetailFacebooks.GetFocusedRowCellValue("Status"));
            }
        }

        private void grVDetailFacebooks_Click(object sender, EventArgs e)
        {
           
        }
    }
}

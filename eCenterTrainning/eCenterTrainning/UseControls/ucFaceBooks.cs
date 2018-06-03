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
    public partial class ucFaceBooks : UserControl
    {
        private bool bFlag = false;

        public ucFaceBooks()
        {
            InitializeComponent();
            actionMenu1.PressNew += new EventHandler(actionMenu1_PressNew);
            actionMenu1.PressEdit += new EventHandler(actionMenu1_PressEdit);
            actionMenu1.PressRefresh += new EventHandler(actionMenu1_PressRefresh);
            actionMenu1.PressDelete += new EventHandler(actionMenu1_PressDelete);
            actionMenu1.PressClose += new EventHandler(actionMenu1_PressClose);
            actionMenu1.PressHelp += new EventHandler(actionMenu1_PressHelp);

            HienThiThongTinFaceBooks();
        }

        void actionMenu1_PressHelp(object sender, EventArgs e)
        {

        }

        void actionMenu1_PressClose(object sender, EventArgs e)
        {
            this.Hide();
        }
        void actionMenu1_PressDelete(object sender, EventArgs e)
        {
            int faceId = 0;
            int.TryParse("" + grvFaceBooks.GetFocusedRowCellValue("FaceId"), out faceId);
            if (faceId > 0)
            {
                DialogResult dr = MessageBox.Show("Bạn chắc là muốn xóa tài khoản FaceBook này!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    MessageBox.Show("");
                }
            }
        }
        void actionMenu1_PressRefresh(object sender, EventArgs e)
        {
            HienThiThongTinFaceBooks();
        }
        void actionMenu1_PressEdit(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(txtEmail.Text)){
                dxErrorProvider1.SetError(txtEmail, "Yêu cầu nhập vào email!");
                txtEmail.Focus();
                return;
            }
            else if(String.IsNullOrEmpty(txtPWD.Text)){
                dxErrorProvider1.SetError(txtPWD, "Yêu cầu nhập vào mật khẩu!");
                txtPWD.Focus();
                return;
            }
            else if (String.IsNullOrEmpty(txtFBName.Text))
            {
                dxErrorProvider1.SetError(txtFBName, "Yêu cầu nhập vào tên của FB!");
                txtFBName.Focus();
                return;
            }
            else{
                MessageBox.Show("");
            }             
        }
        void actionMenu1_PressNew(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(txtEmail.Text)){
                dxErrorProvider1.SetError(txtEmail, "Yêu cầu nhập vào email!");
                txtEmail.Focus();
                return;
            }
            else if(String.IsNullOrEmpty(txtPWD.Text)){
                dxErrorProvider1.SetError(txtPWD, "Yêu cầu nhập vào mật khẩu!");
                txtPWD.Focus();
                return;
            }
            else if (String.IsNullOrEmpty(txtFBName.Text))
            {
                dxErrorProvider1.SetError(txtFBName, "Yêu cầu nhập vào tên của FB!");
                txtFBName.Focus();
                return;
            }
            else {
                MessageBox.Show("");
            }
        }

        private void HienThiThongTinFaceBooks()
        {
            MessageBox.Show("");
        }

        private void grvFaceBooks_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            int FaceID = 0;
            int.TryParse("" + grvFaceBooks.GetFocusedRowCellValue("FaceId"), out FaceID);
            if(FaceID > 0){
                lblFaceId.Text = "" + FaceID;
                txtEmail.Text = "" + grvFaceBooks.GetFocusedRowCellValue("UserName");
                txtPWD.Text = "" + grvFaceBooks.GetFocusedRowCellValue("PassWord");
                txtFBName.Text = "" + grvFaceBooks.GetFocusedRowCellValue("FaceName");
                txtMobileConf.Text = "" + grvFaceBooks.GetFocusedRowCellValue("MobileConf");
                chkStatusFB.Checked = bool.Parse("" + grvFaceBooks.GetFocusedRowCellValue("Status"));
            }
        }

        private void grvFaceBooks_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            int FaceID = 0;
            int.TryParse("" + grvFaceBooks.GetFocusedRowCellValue("FaceId"), out FaceID);
            if (FaceID > 0)
            {
                lblFaceId.Text = "" + FaceID;
                txtEmail.Text = "" + grvFaceBooks.GetFocusedRowCellValue("UserName");
                txtPWD.Text = "" + grvFaceBooks.GetFocusedRowCellValue("PassWord");
                txtFBName.Text = "" + grvFaceBooks.GetFocusedRowCellValue("FaceName");
                txtMobileConf.Text = "" + grvFaceBooks.GetFocusedRowCellValue("MobileConf");
                chkStatusFB.Checked = bool.Parse("" + grvFaceBooks.GetFocusedRowCellValue("Status"));
            }
        }
    }
}

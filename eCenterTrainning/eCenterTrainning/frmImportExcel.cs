using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace eCenterTrainning
{
    public partial class frmImportExcel : Base.frmIMICBase
    {
        public frmImportExcel()
        {
            InitializeComponent();
        }

        DataTable dtData = new DataTable();

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (openFileDialogExcel.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string strPath = openFileDialogExcel.FileName; // Path.Combine(Application.StartupPath, "DanhSachHocVien.xls");

                    txtFileName.Text = strPath;

                    string strConn = "";
                    //strConn = string.Format("provider=Microsoft.Jet.OLEDB.4.0;Data Source='{0}';Extended Properties=Excel 8.0;", strPath);

                    //Đọc với Excel 2007 trở lên có định dạng mở rộng xlsx
                    strConn = string.Format("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='{0}';Extended Properties=Excel 12.0", strPath);


                    System.Data.OleDb.OleDbConnection MyConnection;

                    System.Data.OleDb.OleDbDataAdapter MyCommand;
                    MyConnection = new System.Data.OleDb.OleDbConnection(strConn);
                    MyCommand = new System.Data.OleDb.OleDbDataAdapter("select * from [Sheet1$]", MyConnection);

                    MyCommand.Fill(dtData);
                    gridControl1.DataSource = dtData;
                    MyConnection.Close();

                    lblCount.Text = string.Format("Tổng số: " + dtData.Rows.Count);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }

        }

        private void frmImportExcel_Load(object sender, EventArgs e)
        {
            rbtnCaNhan.Checked = true;
            btnThucHien.Focus();
        }

        private void btnThucHien_Click(object sender, EventArgs e)
        {

            string strLoaiDuLieu = "";

            if (rbtnCaNhan.Checked)
            {
                strLoaiDuLieu = rbtnCaNhan.Text;
            }
            else
            {
                strLoaiDuLieu = rbtnDonVi.Text;
            }

            if (string.IsNullOrEmpty(txtFileName.Text.Trim()))
            {
                MessageBox.Show("Bạn cần chọn file Excel trước khi thực hiện", "Thông báo");
                return;
            }

            if (gridControl1.DataSource == null)
            {
                MessageBox.Show("Đề nghị bạn chọn file chứa dữ liệu cần nhập trước khi thực hiện", "Thông báo");
                return;
            }

            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn nhập tất cả dữ liệu này vào thông tin liên hệ loại " + strLoaiDuLieu + " ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            int iCount = 0;

            if (dr == DialogResult.Yes)
            {

                if (dtData != null && dtData.Rows.Count > 0)
                {
                    string strDienThoai = "";

                    MessageBox.Show("Số lượng dữ liệu được nhập vào hệ thống SMS-eSMART là: " + iCount);

                }

            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmImportExcel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)Keys.Enter) 
            {
                btnThucHien_Click(sender, e);
            }
        }

    }
}

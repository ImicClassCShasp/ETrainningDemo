using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Linq;

namespace eCenterTrainning
{
    public partial class frmHocVienHeThong : DevExpress.XtraEditors.XtraForm
    {       
        public frmHocVienHeThong()
        {
            InitializeComponent();
        }
        private void frmHocVienHeThong_Load(object sender, EventArgs e)
        {
            this.Text = "Thêm học viên trong hệ thống vào lớp học";            
        }
        private void loadChuongTrinhUuDai()
        {
            MessageBox.Show("");
            lookUpEditPolicy.Properties.DisplayMember = "PolicyName";
            lookUpEditPolicy.Properties.ValueMember = "Id";
            //lookUpEditPolicy.Properties.DataSource = lstPoli;
        }
        private void loadDanhSachLopHoc()
        {
            MessageBox.Show("");
            lookUpEditLopHoc.Properties.DisplayMember = "ClassName";
            lookUpEditLopHoc.Properties.ValueMember = "Id";            
        }       
        private void gridControlHVHeThong_MouseClick(object sender, MouseEventArgs e)
        {
            txtName.Text = "" + gridViewHVHeThong.GetFocusedRowCellValue("FullName");
            txtSex.Text = "" + gridViewHVHeThong.GetFocusedRowCellValue("Sex");
            txtEmail.Text = "" + gridViewHVHeThong.GetFocusedRowCellValue("Email");
            txtMobile.Text = "" + gridViewHVHeThong.GetFocusedRowCellValue("Mobile");
            int idStu = 0;
            int.TryParse("" + gridViewHVHeThong.GetFocusedRowCellValue("Id"), out idStu);
            if (idStu > 0)
            {
                int iClassId = int.Parse(""+lookUpEditLopHoc.EditValue);
                MessageBox.Show("");
            }
        }
        private void btnAddHV_Click(object sender, EventArgs e)
        {
            int idStu = 0;
            int idClass = 0;
            string value = "" + gridViewHVHeThong.GetFocusedRowCellValue("Id");

            int.TryParse(value, out idStu);
            int.TryParse("" + lookUpEditLopHoc.EditValue, out idClass);           
        }
    }
}
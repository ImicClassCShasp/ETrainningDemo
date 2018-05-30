using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Linq;
using System.Collections;

namespace eCenterTrainning.UseControls
{
    public partial class uReports : DevExpress.XtraEditors.XtraUserControl
    {
        public uReports()
        {
            InitializeComponent();
        }

        private void uReports_Load(object sender, EventArgs e)
        {
            dateEditFromDateCheckIn.EditValue = DateTime.Now.AddMonths(-1);
            dateEditToDateCheckIn.EditValue = DateTime.Now;
        }
        
        /// <summary>     
        /// Author          Date           Comment
        /// BONGVX          18-3-2013       hien thi bao cao tong hop khoa hoc
        /// </summary>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }

        }
        private void HienThiDanhSachChuaDangKy()
        {
           
        }

        private void xtraTabControlReport_Click(object sender, EventArgs e)
        {
            if (xtraTabControlReport.SelectedTabPageIndex == 1)
            {
                HienThiDanhSachChuaDangKy();
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            HienThiDanhSachChuaDangKy();
        }

      
     
        private void btnBaoCaoHocDongHocPhiKhoaHoc_Click(object sender, EventArgs e)
        {
            try
            {
                msgError.Clear();
                if (string.IsNullOrEmpty(dateEditFromDateCheckIn.Text))
                {
                    msgError.SetError(dateEditFromDateCheckIn, "Bạn hãy nhập ngày bắt đầu trước khi thực hiện");
                    dateEditFromDateCheckIn.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(dateEditToDateCheckIn.Text))
                {
                    msgError.SetError(dateEditToDateCheckIn, "Bạn hãy nhập ngày kết thúc trước khi thực hiện");
                    dateEditToDateCheckIn.Focus();
                    return;
                }
                if (!string.IsNullOrEmpty(dateEditFromDateCheckIn.Text) && !string.IsNullOrEmpty(dateEditToDateCheckIn.Text))
                {
                    MessageBox.Show("");
                    //rpt.ShowPreviewDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }
        }

        /// <summary>     
        /// Author          Date           Comment
        /// BONGVX          18-3-2013       hien thi bao cao tong hop hoc vien theo hoc tai cac khoa hoc 
        /// </summary>
        private void btnBaoCaoChiTietDangKy_Click(object sender, EventArgs e)
        {
            try
            {
                msgError.Clear();
                if (string.IsNullOrEmpty(dateEditFromDateCheckIn.Text))
                {
                    msgError.SetError(dateEditFromDateCheckIn, "Bạn hãy nhập ngày bắt đầu trước khi thực hiện");
                    dateEditFromDateCheckIn.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(dateEditToDateCheckIn.Text))
                {
                    msgError.SetError(dateEditToDateCheckIn, "Bạn hãy nhập ngày kết thúc trước khi thực hiện");
                    dateEditToDateCheckIn.Focus();
                    return;
                }
                if (!string.IsNullOrEmpty(dateEditFromDateCheckIn.Text) && !string.IsNullOrEmpty(dateEditToDateCheckIn.Text))
                {
                    MessageBox.Show("");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }
        }

        private void btnBaoCaoChiTietHocVienDongHocPhi_Click(object sender, EventArgs e)
        {
            try
            {
                msgError.Clear();
                if (string.IsNullOrEmpty(dateEditFromDateCheckIn.Text))
                {
                    msgError.SetError(dateEditFromDateCheckIn, "Bạn hãy nhập ngày bắt đầu trước khi thực hiện");
                    dateEditFromDateCheckIn.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(dateEditToDateCheckIn.Text))
                {
                    msgError.SetError(dateEditToDateCheckIn, "Bạn hãy nhập ngày kết thúc trước khi thực hiện");
                    dateEditToDateCheckIn.Focus();
                    return;
                }
                if (!string.IsNullOrEmpty(dateEditFromDateCheckIn.Text) && !string.IsNullOrEmpty(dateEditToDateCheckIn.Text))
                {
                    MessageBox.Show("");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }
        }



    }
}

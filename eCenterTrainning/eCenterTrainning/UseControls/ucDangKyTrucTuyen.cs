using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace eCenterTrainning.UseControls
{
    public partial class ucDangKyTrucTuyen : UserControl
    {
        static DataTable objTable = null;
        SqlConnection objConnection = null;
        public ucDangKyTrucTuyen()
        {
            InitializeComponent();
        }
        private void btnLoadData_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if(String.IsNullOrEmpty(dtpTuNgay.Text)){
                errorProvider1.SetError(dtpTuNgay, "Chọn Ngày bắt đầu!");
                return;
            }
            else if (String.IsNullOrEmpty(dtpDenNgay.Text))
            {
                errorProvider1.SetError(dtpDenNgay, "Chọn Ngày kết thúc!");
                return;
            }
            else {
                //Get date
                int ngay = dtpTuNgay.DateTime.Day;
                int thang = dtpTuNgay.DateTime.Month;
                int nam = dtpTuNgay.DateTime.Year;
                string tungay = String.Format("{0}-{1}-{2} 00:00:00", nam, thang, ngay);

                ngay = dtpDenNgay.DateTime.Day + 1;
                thang = dtpDenNgay.DateTime.Month;
                nam = dtpDenNgay.DateTime.Year;
                string denngay = String.Format("{0}-{1}-{2} 00:00:00", nam,thang,ngay);

                //Excecuted SQL                
                try
                {
                    MessageBox.Show("");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            objConnection.Close();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            
        }
        private void btnCoppy_Click(object sender, EventArgs e)
        {            
            int iHocVienId = 0;
            int.TryParse("" + gridView1.GetFocusedRowCellValue("HocVienID"), out iHocVienId);

            if (iHocVienId > 0)
            {
                foreach (DataRow objRow in objTable.Rows)
                {
                    if (iHocVienId == int.Parse("" + objRow["HocVienID"]))
                    {
                        //get row
                        string fullName = objRow["HoTen"].ToString();
                        string[] str = fullName.Split(' ');
                        string firtname = str[0];
                        string lastname = str[1];
                        string email = objRow["Email"].ToString();
                        string mobile = objRow["DienThoai"].ToString();
                        short status = 1;
                        short courseid = 4;

                        //Excecuted SQL                    
                        try
                        {
                            MessageBox.Show("");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }                    
                }
            }
            else {
                MessageBox.Show("Bạn chưa chọn học viên cần coppy!", "iMIC Admin");   
            }
            objConnection.Close();
        }
    }
}

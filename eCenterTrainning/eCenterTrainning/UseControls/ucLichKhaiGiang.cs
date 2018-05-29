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
    public partial class ucLichKhaiGiang : UserControl
    {
        static DataTable objTable = null;
        SqlConnection objConnection = null;
        static string host = "";
        static string tungay = "";
        static string denngay = "";

        public static string _Host
        {
            get { return ucLichKhaiGiang.host; }
            set { ucLichKhaiGiang.host = value; }
        }
        static string User = "";

        public static string _User
        {
            get { return ucLichKhaiGiang.User; }
            set { ucLichKhaiGiang.User = value; }
        }
        static string Pass = "";

        public static string _Pass
        {
            get { return ucLichKhaiGiang.Pass; }
            set { ucLichKhaiGiang.Pass = value; }
        }
        static string Db = "";

        public static string _Db
        {
            get { return ucLichKhaiGiang.Db; }
            set { ucLichKhaiGiang.Db = value; }
        }

        public ucLichKhaiGiang()
        {
            InitializeComponent();

            actionMenu1.PressNew += new EventHandler(actionMenu1_PressNew);
            actionMenu1.PressEdit += new EventHandler(actionMenu1_PressEdit);
            actionMenu1.PressDelete += new EventHandler(actionMenu1_PressDelete);
            actionMenu1.PressClose += new EventHandler(actionMenu1_PressClose);
            actionMenu1.PressRefresh += new EventHandler(actionMenu1_PressRefresh);

            host = ConfigurationManager.AppSettings["imic_host"].ToString();
            User = ConfigurationManager.AppSettings["imic_user"].ToString();
            Pass = ConfigurationManager.AppSettings["imic_pass"].ToString();
            Db = ConfigurationManager.AppSettings["imic_db"].ToString();
        }

        void actionMenu1_PressRefresh(object sender, EventArgs e)
        {
            btnLoadData_Click(sender, null);
        }

        void actionMenu1_PressClose(object sender, EventArgs e)
        {
            
        }

        void actionMenu1_PressDelete(object sender, EventArgs e)
        {
            int iKhoaKhaiGiangId = 0;
            int.TryParse("" + gridView1.GetFocusedRowCellValue("KhoaKhaiGiangId"), out iKhoaKhaiGiangId);

            if (iKhoaKhaiGiangId > 0)
            {
                DialogResult dr = MessageBox.Show("Bạn chắc muốn xóa lịch khai giảng này", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    //Excecuted SQL                
                    try
                    {
                        //Service objS = new Service();                        
                        //objConnection = objS.OpenConection(host, Db, User, Pass);

                        //if (objConnection.State == ConnectionState.Open)
                        //{
                        
                            ////Get data
                            //SqlCommand objCommand = new SqlCommand("SP_DELETE_LICHKHAIGIANG_BY_ID", objConnection);
                            //objCommand.CommandType = CommandType.StoredProcedure;
                            //objCommand.Parameters.Add("@KhoaKhaiGiangId", SqlDbType.BigInt).Value = iKhoaKhaiGiangId;
                            //objCommand.ExecuteNonQuery();
                            //MessageBox.Show("Xóa lịch khai giảng thành công!", "Thông báo");
                        //}

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Hãy chọn lịch khai giảng cần xóa", "Thông báo");
            }
        }

        void actionMenu1_PressEdit(object sender, EventArgs e)
        {
            //Get rows
            int iKhoaKhaiGiangId = 0;
            int.TryParse("" + gridView1.GetFocusedRowCellValue("KhoaKhaiGiangId"), out iKhoaKhaiGiangId);

            if (iKhoaKhaiGiangId > 0)
            {
                DataRow objRow = getLichKhaiGiangRow(objTable, iKhoaKhaiGiangId);
                if (objRow != null)
                {
                    frmLichKhaiGiangAdd obj = new frmLichKhaiGiangAdd(objRow,objTable);
                    //frmLichKhaiGiangAdd._Tungay = tungay;
                    //frmLichKhaiGiangAdd._Denngay = denngay;
                    obj.ShowDialog();
                }
            }
            else {
                MessageBox.Show("Chọn lịch khai giảng trước khi sửa!", "Thông báo");
            }            
        }

        DataRow getLichKhaiGiangRow(DataTable objTable, int pKhoaKhaiGiangId)
        {            
            int i = 0;
            DataRow objRow = null;
            foreach (DataRow row in objTable.Rows)
            {                
                if (pKhoaKhaiGiangId == int.Parse("" + row["KhoaKhaiGiangId"]))
                {
                    objRow = objTable.Rows[i];
                    return objRow;
                }
                i++;
            }
            return objRow;
        } 

        void actionMenu1_PressNew(object sender, EventArgs e)
        {
            errorProvider1.Clear();            
            if(string.IsNullOrEmpty(dtpTuNgay.Text)){
                errorProvider1.SetError(dtpTuNgay, "Chọn thời gian bắt đầu trước khi nhập lịch khai giảng!");
                return;
            }
            else if (string.IsNullOrEmpty(dtpDenNgay.Text))
            {
                errorProvider1.SetError(dtpDenNgay, "Chọn thời gian kết thúc trước khi nhập lịch khai giảng!");
                return;
            }
            //Get date
            int ngay = dtpTuNgay.DateTime.Day;
            int thang = dtpTuNgay.DateTime.Month;
            int nam = dtpTuNgay.DateTime.Year;
            tungay = String.Format("{0}-{1}-{2} 00:00:00", nam, thang, ngay);

            ngay = dtpDenNgay.DateTime.Day + 1;
            thang = dtpDenNgay.DateTime.Month;
            nam = dtpDenNgay.DateTime.Year;
            denngay = String.Format("{0}-{1}-{2} 00:00:00", nam, thang, ngay);
            frmLichKhaiGiangAdd obj = new frmLichKhaiGiangAdd(tungay, denngay);            
            obj.ShowDialog();
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
                tungay = String.Format("{0}-{1}-{2} 00:00:00", nam, thang, ngay);

                ngay = dtpDenNgay.DateTime.Day + 1;
                thang = dtpDenNgay.DateTime.Month;
                nam = dtpDenNgay.DateTime.Year;
                denngay = String.Format("{0}-{1}-{2} 00:00:00", nam,thang,ngay);

                //Excecuted SQL                
                try
                {                    
                    //Get data
                    //SqlCommand objCommand = new SqlCommand("SP_LICHKHAIGIANG_ALL", objConnection);
                    //objCommand.CommandType = CommandType.StoredProcedure;
                    //objCommand.Parameters.Add("@tungay", SqlDbType.NVarChar, 100).Value = tungay;
                    //objCommand.Parameters.Add("@denngay", SqlDbType.NVarChar, 100).Value = denngay;
                    //SqlDataAdapter obj = new SqlDataAdapter(objCommand);
                    //objTable = new DataTable();
                    //obj.Fill(objTable);
                    
                    if (objTable.Rows.Count > 0)
                    {
                        gridControl1.DataSource = objTable;
                        //objConnection.Close();
                        return;
                    }
                    else {
                        MessageBox.Show("Chưa có lịch khai giảng trong thời gian này!");
                        return;
                    }                 
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }            
        }        
    }
}

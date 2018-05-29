using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using eCenterTrainning.UseControls;
using System.Data.SqlClient;

namespace eCenterTrainning
{
    public partial class frmLichKhaiGiangAdd : Form
    {        
        public frmLichKhaiGiangAdd()
        {
            InitializeComponent();                      
        }

        public frmLichKhaiGiangAdd(string pTuNgay, string pDenNgay)
        {
            InitializeComponent();                       
            txtMaKhoaHoc_LichHoc.Enabled = false;
            btnCapNhat.Enabled = false;
            btnCapNhatLich.Enabled = false;
        }

        public frmLichKhaiGiangAdd(DataRow objRow, DataTable objTable)
        {
            InitializeComponent();
            
            //Binding form
            //1. Thong tin khoa hoc
            txtMaKhoaHoc.Text = objRow["MaKhoaHoc"].ToString();
            txtMaKhoaHoc.Enabled = false;
            btnThem.Enabled = false;
            btnThemLich.Enabled = false;
            txtMaKhoaHoc_LichHoc.Enabled = false;
            txtTenKhoaHoc.Text = objRow["TenKhoaHoc"].ToString();
            txtThoiLuong.Text = objRow["ThoiLuong"].ToString();            
            txtLinkNoiDung.Text = objRow["UrlNoiDungKhoaHoc"].ToString();
            txtTenDayDu.Text = objRow["TenKhoaHocFull"].ToString();
            txtTieuDe.Text = objRow["TenLoaiKhoaHoc"].ToString();
            if (objRow["LoaiKhoaHocId"].Equals("1"))
            {
                cboLoaiKhoaHoc.SelectedIndex = 0;
            }
            else if (objRow["LoaiKhoaHocId"].Equals("2"))
            {
                cboLoaiKhoaHoc.SelectedIndex = 1;
            }
            else {
                cboLoaiKhoaHoc.SelectedIndex = 3;
            }
            txtMaKhoaHoc_LichHoc.Text = objRow["KhoaKhaiGiangId"].ToString();
            txtLichHoc.Text = objRow["LichHoc"].ToString();
            dtpNgayKhaiGiang.Text = objRow["NgayKhaiGiang"].ToString();
            txtThoiGian.Text = objRow["ThoiGian"].ToString();
            if (bool.Parse(objRow["tinhtrang"].ToString()))
            {
                cboTinhTrang.SelectedIndex = 0;
            }
            else {
                cboTinhTrang.SelectedIndex = 1;
            }
            txtDaDangKy.Text = objRow["DaDuyet"].ToString();
            txtChuaDangKy.Text = objRow["ChuaDuyet"].ToString();
            txtSoLuongToiDa.Text = objRow["SoLuongToiDa"].ToString();
            cboTrangThaiKH.Text = objRow["TrangThai"].ToString();
            txtLinkAnh.Text = objRow["imgKhoaHoc"].ToString();
            txtMaLop.Text = objRow["MaLop"].ToString();            

            //getImageInfor();            
            grdLichKhaiGiang.DataSource = objTable;
            uluKhoaHoc.EditValue = objRow["MaKhoaHoc"].ToString();             
        }                

        private void gridView2_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            int iKhoaKhaiGiangId = 0;
            int.TryParse("" + gridView2.GetFocusedRowCellValue("KhoaKhaiGiangId"), out iKhoaKhaiGiangId);
            if (iKhoaKhaiGiangId > 0)
            {
                btnCapNhatLich.Enabled = true;
                //Binding controls
                txtMaLop.Text = gridView2.GetFocusedRowCellValue("MaLop").ToString();
                txtMaKhoaHoc_LichHoc.Text = gridView2.GetFocusedRowCellValue("KhoaKhaiGiangId").ToString();
                txtLichHoc.Text = gridView2.GetFocusedRowCellValue("LichHoc").ToString();
                txtThoiGian.Text = gridView2.GetFocusedRowCellValue("ThoiGian").ToString();
                txtDaDangKy.Text = gridView2.GetFocusedRowCellValue("DaDuyet").ToString();
                txtChuaDangKy.Text = gridView2.GetFocusedRowCellValue("ChuaDuyet").ToString();
                txtSoLuongToiDa.Text = gridView2.GetFocusedRowCellValue("SoLuongToiDa").ToString();
                uluKhoaHoc.EditValue = gridView2.GetFocusedRowCellValue("MaKhoaHoc").ToString();
                if (gridView2.GetFocusedRowCellValue("TrangThai").Equals("Đã khai giảng"))
                {
                    cboTrangThaiKH.SelectedIndex = 0;
                }
                else
                {
                    cboTrangThaiKH.SelectedIndex = 1;
                }
                if (bool.Parse(gridView2.GetFocusedRowCellValue("tinhtrang").ToString()))
                {
                    cboTinhTrang.SelectedIndex = 0;
                }
                else
                {
                    cboTinhTrang.SelectedIndex = 1;
                }
                dtpNgayKhaiGiang.DateTime = DateTime.Parse("" + gridView2.GetFocusedRowCellValue("NgayKhaiGiang"));
            }            
        }               

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            //Bind
            txtMaKhoaHoc.Text = gridView1.GetFocusedRowCellValue("MaKhoaHoc").ToString();
            txtTenKhoaHoc.Text = gridView1.GetFocusedRowCellValue("TenKhoaHoc").ToString();
            txtThoiLuong.Text = gridView1.GetFocusedRowCellValue("ThoiLuong").ToString();
            txtLinkAnh.Text = gridView1.GetFocusedRowCellValue("imgKhoaHoc").ToString();
            txtLinkNoiDung.Text = gridView1.GetFocusedRowCellValue("UrlNoiDungKhoaHoc").ToString();
            txtTenDayDu.Text = gridView1.GetFocusedRowCellValue("TenKhoaHocFull").ToString();
            txtTieuDe.Text = gridView1.GetFocusedRowCellValue("TenLoaiKhoaHoc").ToString();
            if (gridView1.GetFocusedRowCellValue("LoaiKhoaHocId").Equals("1"))
            {
                cboLoaiKhoaHoc.SelectedIndex = 0;
            }
            else if (gridView1.GetFocusedRowCellValue("LoaiKhoaHocId").Equals("2"))
            {
                cboLoaiKhoaHoc.SelectedIndex = 1;
            }
            else
            {
                cboLoaiKhoaHoc.SelectedIndex = 2;
            }        
        }                                     

        private void frmLichKhaiGiangAdd_Load(object sender, EventArgs e)
        {
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Linq;
using IMIC.VALUEOBJECTS;
using IMIC.BUSINESSLOGICLAYERS;

namespace eCenterTrainning
{
    public partial class frmEmployee : Base.frmIMICBase
    {
        List<Ou> lstOu;
        List<JobTitle> lstJob;
        List<CenterInfo> lstCenter;
        Employee TempEmployee=null;

        public frmEmployee()
        {
            InitializeComponent();
        }
        public frmEmployee(Account oAccount) : base(oAccount)
        {
            List<JobTitle> lstJob = new List<JobTitle>();
            List<Ou> lstOu = new List<Ou>();
            List<CenterInfo> lstCenter = new List<CenterInfo>();
            Employee oEmployee = new Employee();

            InitializeComponent();
        }
        public frmEmployee(Account oAccount, int IdEmp):base(oAccount)
        {
            List<JobTitle> lstJob = new List<JobTitle>();
            List<Ou> lstOu = new List<Ou>();
            List<CenterInfo> lstCenter = new List<CenterInfo>();
            InitializeComponent();
            DisplayEmployeeNow(IdEmp);
        }

        void DisplayEmployeeNow(int Id)
        {
            TempEmployee = new EmployeeBLL(mAccount).getElementById(Id);

            txtHoTen.Text = TempEmployee.EmployeeName;
            txtEmail.Text = TempEmployee.Email;
            txtDiaChi.Text = TempEmployee.Address;
            txtMobile.Text = TempEmployee.Mobile;
            txtCMND.Text = TempEmployee.IdentityNumber;
            txtDienThoai.Text = TempEmployee.Phone;
            txtMaThue.Text = TempEmployee.PersonalTaxCode;
            txtMoTa.Text = TempEmployee.Description;
            txtNoiCap.Text = TempEmployee.PlaceOfIssue;
            txtNoiDung.Text = TempEmployee.EmployeeCV;
            txtQueQuan.Text = TempEmployee.PlaceBirthday;
            txtTruong.Text = TempEmployee.UniversityName;

            dateEditNgayCap.EditValue = TempEmployee.DateOfIssue;
            dateEditNgaySinh.EditValue = TempEmployee.DateBirhday;

            //lookUpEditChucVu.EditValue
            //lookUpEditPhongBan.EditValue 
            //lookUpEditTrungTam.EditValue 

            if (TempEmployee.Sex == 0)
                cboGioiTinh.Text = "Nam";
            else if (TempEmployee.Sex == 1)
                cboGioiTinh.Text = "Nữ";
        }

        private void frmEmployee_Load(object sender, EventArgs e)
        {
            actionUpdateEmolyee.PressUpdate += new EventHandler(actionUpdateEmolyee_PressUpdate);
            actionUpdateEmolyee.PressHelp += new EventHandler(actionUpdateEmolyee_PressHelp);
            actionUpdateEmolyee.PressClose += new EventHandler(actionUpdateEmolyee_PressClose);
            actionUpdateEmolyee.PressNew += new EventHandler(actionUpdateEmolyee_PressNew);
            this.Text = "Thông tin nhân viên";
            LoadChucVu();
            LoadPhongBan();
            LoadTrungTam();
        }

        void actionUpdateEmolyee_PressNew(object sender, EventArgs e)
        {
            txtHoTen.Text = "";
            txtEmail.Text = "";
            txtDiaChi.Text = "";
            txtMobile.Text = "";
            txtCMND.Text = "";
            txtDienThoai.Text = "";
            txtMaThue.Text = "";
            txtMoTa.Text = "";
            txtNoiCap.Text = "";
            txtNoiDung.Text = "";
            txtQueQuan.Text = "";
            txtTruong.Text = "";

            cboGioiTinh.EditValue = "";

            dateEditNgayCap.EditValue = "";
            dateEditNgaySinh.EditValue = "";

            lookUpEditChucVu.EditValue = lookUpEditChucVu.Properties.GetKeyValueByDisplayText("");
            lookUpEditPhongBan.EditValue = lookUpEditPhongBan.Properties.GetKeyValueByDisplayText("");
            lookUpEditTrungTam.EditValue = lookUpEditTrungTam.Properties.GetKeyValueByDisplayText("");

            txtHoTen.Focus();
        }

        void actionUpdateEmolyee_PressClose(object sender, EventArgs e)
        {
            this.Close();
        }

        void actionUpdateEmolyee_PressHelp(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng này chưa được cập nhật", "thông báo");
        }
        /// <summary>
        /// Author          Date        Comment
        /// BONGVX                      Them hoac sua thong tin nhan vien
        /// </summary>
        void actionUpdateEmolyee_PressUpdate(object sender, EventArgs e)
        {
            msgMessage.Clear();
            if (string.IsNullOrEmpty("" + txtHoTen.Text))
            {
                msgMessage.SetError(txtHoTen, "Bạn cần nhập họ tên");
                txtHoTen.Focus();
                return;
            }
            if (string.IsNullOrEmpty("" + txtEmail.Text))
            {
                msgMessage.SetError(txtEmail, "Bạn cần nhập email");
                txtEmail.Focus();
                return;
            }
            if (string.IsNullOrEmpty("" + txtMobile.Text))
            {
                msgMessage.SetError(txtMobile, "Bạn cần nhập số di động");
                txtMobile.Focus();
                return;
            }
            if (string.IsNullOrEmpty("" + txtDiaChi.Text))
            {
                msgMessage.SetError(txtDiaChi, "Bạn cần nhập địa chỉ");
                txtDiaChi.Focus();
                return;
            }
            if (string.IsNullOrEmpty("" + lookUpEditTrungTam.EditValue))
            {
                msgMessage.SetError(lookUpEditTrungTam, "Bạn cần chọn trung tâm");
                return;
            }
            if (string.IsNullOrEmpty("" + lookUpEditPhongBan.EditValue))
            {
                msgMessage.SetError(lookUpEditPhongBan, "Bạn cần chọn phòng ban");
                return;
            }
            if (string.IsNullOrEmpty("" + lookUpEditChucVu.EditValue))
            {
                msgMessage.SetError(lookUpEditChucVu, "Bạn cần chọn chức vụ");
                return;
            }

            if (TempEmployee==null)
            {
                Employee oEmployee = new Employee
                {
                    EmployeeName = txtHoTen.Text,
                    Email = txtEmail.Text,
                    Mobile = txtMobile.Text,
                    Address = txtDiaChi.Text,
                    Phone = txtDienThoai.Text,

                    OuId = int.Parse("" + lookUpEditPhongBan.EditValue),
                    CenterId = int.Parse("" + lookUpEditTrungTam.EditValue),
                    JobTitleId = int.Parse("" + lookUpEditChucVu.EditValue),

                    Sex = (cboGioiTinh.Text == "Nam") ? 1 : 0,
                    DateBirhday = dateEditNgaySinh.DateTime,
                    UniversityName = txtTruong.Text,
                    PlaceBirthday = txtQueQuan.Text,
                    PersonalTaxCode = txtMaThue.Text,
                    DateRegister = DateTime.Now,
                    DateLastUpdate = DateTime.Now,
                    DateCreate = DateTime.Now,
                    IdentityNumber = txtCMND.Text,
                    DateOfIssue = dateEditNgayCap.DateTime,
                    PlaceOfIssue = txtNoiCap.Text,
                    Description = txtNoiDung.Text
                };
                if (new EmployeeBLL(mAccount).InsertElement(oEmployee)) MessageBox.Show("Thêm thành công!");
                else MessageBox.Show("Thêm thất bại!");
            }
            else
            {
                Employee oEmployee = new Employee
                {
                    Id=TempEmployee.Id,

                    EmployeeName = txtHoTen.Text,
                    Email = txtEmail.Text,
                    Mobile = txtMobile.Text,
                    Address = txtDiaChi.Text,
                    Phone = txtDienThoai.Text,

                    OuId = int.Parse("" + lookUpEditPhongBan.EditValue),
                    CenterId = int.Parse("" + lookUpEditTrungTam.EditValue),
                    JobTitleId = int.Parse("" + lookUpEditChucVu.EditValue),

                    Sex = (cboGioiTinh.Text == "Nam") ? 1 : 0,
                    DateBirhday = dateEditNgaySinh.DateTime,
                    UniversityName = txtTruong.Text,
                    PlaceBirthday = txtQueQuan.Text,
                    PersonalTaxCode = txtMaThue.Text,
                    IdentityNumber = txtCMND.Text,
                    DateOfIssue = dateEditNgayCap.DateTime,
                    PlaceOfIssue = txtNoiCap.Text,
                    Description = txtNoiDung.Text
                };

                if (new EmployeeBLL(mAccount).InsertAndUpdateElement(oEmployee)) MessageBox.Show("Sửa thành công!");
                else MessageBox.Show("Sửa thất bại!");
            }
            this.Close();
        }

        void LoadPhongBan()
        {
            List<Ou> lstOu = new OuBLL(mAccount).getElements();
            lookUpEditPhongBan.Properties.DisplayMember = "OuName";
            lookUpEditPhongBan.Properties.ValueMember = "Id";
            lookUpEditPhongBan.Properties.DataSource = lstOu;
        }

        void LoadChucVu()
        {
            List<JobTitle> lstJob = new JobTitleBLL(mAccount).getElements();
            lookUpEditChucVu.Properties.DisplayMember = "JobTitle1";
            lookUpEditChucVu.Properties.ValueMember = "Id";
            lookUpEditChucVu.Properties.DataSource = lstJob;
        }

        void LoadTrungTam()
        {
            List<CenterInfo> lstCenter = new CenterInfoBLL(mAccount).getElements();
            lookUpEditTrungTam.Properties.DisplayMember = "CenterName";
            lookUpEditTrungTam.Properties.ValueMember = "Id";
            lookUpEditTrungTam.Properties.DataSource = lstCenter;
        }

        /// <summary>
        /// Author          Date            Comment
        /// BONGVX          31/1/2013       Them moi nhan vien
        /// </summary>
        /// <returns></returns>
        private int insertEmployee()
        {
            try
            {
                MessageBox.Show("");
                return 1;
            }
            catch (Exception)
            {
                return 0;
                throw;
            }
        }
        /// <summary>
        /// Author          Date        Comment
        /// BONGVX                      khong chinh sua thong tin cac field
        /// </summary>
        private void disablefiled()
        {
            foreach (Control c in groupControlNhanVien.Controls)
            {
                if (c is DevExpress.XtraEditors.TextEdit)
                {
                    c.Enabled = false;
                }
            }
            actionUpdateEmolyee.Enabled = false;
            btnAddMoreCenter.Enabled = false;
            btnAddMoreDepartment.Enabled = false;
            btnAddMoreJob.Enabled = false;
            txtMoTa.Enabled = false;
        }
        /// <summary>
        /// Author          Date        Comment
        /// BONGVX                      Xoa thong tin tren cac field
        /// </summary>
        private void resetAllField()
        {
            foreach (Control c in groupControlNhanVien.Controls)
            {
                if (c is DevExpress.XtraEditors.TextEdit)
                {
                    c.Text = "";
                }
            }
            txtMoTa.Text = "";
            lookUpEditChucVu.RefreshEditValue();
            lookUpEditPhongBan.RefreshEditValue();
            lookUpEditTrungTam.RefreshEditValue();
            txtHoTen.Focus();
        }
    }
}
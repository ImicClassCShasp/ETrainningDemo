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
        int id;
        List<Ou> lstOu;
        List<JobTitle> lstJob;
        List<CenterInfo> lstCenter;
        Employee mEmployee;
        int Flag;

        public frmEmployee()
        {
            InitializeComponent();
        }
        public frmEmployee(Account oAccount) : base(oAccount)
        {
            Flag = 1;
            lstJob = new List<JobTitle>();
            lstOu = new List<Ou>();
            lstCenter = new List<CenterInfo>();
            mEmployee = new Employee();

            InitializeComponent();
        }
        public frmEmployee(Account oAccount, int IdEmp):base(oAccount)
        {
            Flag = 2;
            lstJob = new List<JobTitle>();
            lstOu = new List<Ou>();
            lstCenter = new List<CenterInfo>();
            mEmployee = new Employee();
            InitializeComponent();
            id = IdEmp;
            DisplayEmployeeNow(IdEmp);
        }

        void DisplayEmployeeNow(int Id)
        {
            Employee oEmp = new EmployeeBLL(mAccount).getElementById(Id);

            txtHoTen.Text = ""+oEmp.EmployeeName;
            txtEmail.Text = "" + oEmp.Email;
            txtDiaChi.Text = "" + oEmp.Address;
            txtMobile.Text = "" + oEmp.Mobile;
            txtCMND.Text = "" + oEmp.IdentityNumber;
            txtDienThoai.Text = "" + oEmp.Phone;
            txtMaThue.Text = "" + oEmp.PersonalTaxCode;
            txtMoTa.Text = "" + oEmp.Description;
            txtNoiCap.Text = "" + oEmp.PlaceOfIssue;
            txtNoiDung.Text = "" + oEmp.EmployeeCV;
            txtQueQuan.Text = "" + oEmp.PlaceBirthday;
            txtTruong.Text = "" + oEmp.UniversityName;

            dateEditNgayCap.EditValue = "" + oEmp.DateOfIssue;
            dateEditNgaySinh.EditValue = "" + oEmp.DateBirhday;

            //lookUpEditChucVu.EditValue
            //lookUpEditPhongBan.EditValue
            //lookUpEditTrungTam.EditValue

            if (oEmp.Sex == 0)
                cboGioiTinh.Text = "Nam";
            else if (oEmp.Sex == 1)
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
        bool CheckEmailFormat(string Email)
        {
            string Format = "@gmail.com";
            if (Email.Contains(Format)) return false;
            return true;
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
                msgMessage.SetError(txtEmail, " Bạn cần nhập thông tin email trước khi thực hiện");
                txtEmail.Focus();
                return;
            }
            else
            {
                if (CheckEmailFormat("" + txtEmail.Text))
                {
                    msgMessage.SetError(txtEmail, "Email không đúng định dạng!");
                    txtEmail.Focus();
                    return;
                }
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

            if (Flag==1)
            {
                mEmployee.EmployeeName = txtHoTen.Text;
                mEmployee.Email = txtEmail.Text;
                mEmployee.Mobile = txtMobile.Text;
                mEmployee.Address = txtDiaChi.Text;
                mEmployee.Phone = txtDienThoai.Text;

                mEmployee.OuId = int.Parse("" + lookUpEditPhongBan.EditValue);
                mEmployee.CenterId = int.Parse("" + lookUpEditTrungTam.EditValue);
                mEmployee.JobTitleId = int.Parse("" + lookUpEditChucVu.EditValue);

                mEmployee.Sex = (cboGioiTinh.Text == "Nam") ? 1 : 0;
                mEmployee.DateBirhday = dateEditNgaySinh.DateTime;
                mEmployee.UniversityName = txtTruong.Text;
                mEmployee.PlaceBirthday = txtQueQuan.Text;
                mEmployee.PersonalTaxCode = txtMaThue.Text;
                mEmployee.DateRegister = DateTime.Now;
                mEmployee.DateLastUpdate = DateTime.Now;
                mEmployee.DateCreate = DateTime.Now;
                mEmployee.IdentityNumber = txtCMND.Text;
                mEmployee.DateOfIssue = dateEditNgayCap.DateTime;
                mEmployee.PlaceOfIssue = txtNoiCap.Text;
                mEmployee.Description = txtNoiDung.Text;
                
                if (new EmployeeBLL(mAccount).InsertElement(mEmployee)) MessageBox.Show("Thêm thành công!");
                else MessageBox.Show("Thêm thất bại!");
            }
            else if(Flag==2)
            {               
                mEmployee.Id=id;

                mEmployee.EmployeeName = txtHoTen.Text;
                mEmployee.Email = txtEmail.Text;
                mEmployee.Mobile = txtMobile.Text;
                mEmployee.Address = txtDiaChi.Text;
                mEmployee.Phone = txtDienThoai.Text;

                mEmployee.OuId = int.Parse("" + lookUpEditPhongBan.EditValue);
                mEmployee.CenterId = int.Parse("" + lookUpEditTrungTam.EditValue);
                mEmployee.JobTitleId = int.Parse("" + lookUpEditChucVu.EditValue);

                mEmployee.Sex = (cboGioiTinh.Text == "Nam") ? 1 : 0;
                mEmployee.DateBirhday = dateEditNgaySinh.DateTime;
                mEmployee.UniversityName = txtTruong.Text;
                mEmployee.PlaceBirthday = txtQueQuan.Text;
                mEmployee.PersonalTaxCode = txtMaThue.Text;
                mEmployee.DateRegister = DateTime.Now;
                mEmployee.DateLastUpdate = DateTime.Now;
                mEmployee.DateCreate = DateTime.Now;
                mEmployee.IdentityNumber = txtCMND.Text;
                mEmployee.DateOfIssue = dateEditNgayCap.DateTime;
                mEmployee.PlaceOfIssue = txtNoiCap.Text;
                mEmployee.Description = txtNoiDung.Text;


                if (new EmployeeBLL(mAccount).InsertAndUpdateElement(mEmployee)) MessageBox.Show("Sửa thành công!");
                else MessageBox.Show("Sửa thất bại!");
            }
            this.Close();
        }

        void LoadPhongBan()
        {
            lstOu = new OuBLL(mAccount).getElements();
            lookUpEditPhongBan.Properties.DisplayMember = "OuName";
            lookUpEditPhongBan.Properties.ValueMember = "Id";
            lookUpEditPhongBan.Properties.DataSource = lstOu;
        }

        void LoadChucVu()
        {
            lstJob = new JobTitleBLL(mAccount).getElements();
            lookUpEditChucVu.Properties.DisplayMember = "JobTitle1";
            lookUpEditChucVu.Properties.ValueMember = "Id";
            lookUpEditChucVu.Properties.DataSource = lstJob;
        }

        void LoadTrungTam()
        {
            lstCenter = new CenterInfoBLL(mAccount).getElements();
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

        private void btnContent_Click(object sender, EventArgs e)
        {
            frmInformationDetail frm = new frmInformationDetail(mEmployee);
            frm.ShowDialog();
            txtNoiDung.Text = "Đã có hồ sơ nhân viên";
        }

        private void btnAddMoreCenter_Click(object sender, EventArgs e)
        {
            frmCenterInfo frm = new frmCenterInfo(mAccount);
            frm.ShowDialog();
            LoadTrungTam();
        }

        private void btnAddMoreJob_Click(object sender, EventArgs e)
        {
            frmThongTinChucVu frm = new frmThongTinChucVu(mAccount);
            frm.ShowDialog();
            LoadChucVu();
        }

        private void btnAddMoreDepartment_Click(object sender, EventArgs e)
        {
            frmPhongBan frm = new frmPhongBan(mAccount);
            frm.ShowDialog();
            LoadPhongBan();
        }
    }
}
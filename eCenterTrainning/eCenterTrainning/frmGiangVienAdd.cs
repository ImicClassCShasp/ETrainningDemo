using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using IMIC.SyncModule;
using IMIC.VALUEOBJECTS;
using IMIC.BUSINESSLOGICLAYERS;
namespace eCenterTrainning
{
    public partial class frmGiangVienAdd : Base.frmIMICBase
    {
        Account mAccount;
        ExpertInfoBll mExpertInfoBll;
        CenterInfoesBll mCenterinfoesBll;
        int iFlag, idGV;
        public frmGiangVienAdd()
        {
            InitializeComponent();
        }      
        public frmGiangVienAdd(Account oAccount, int flag, int idGiangVien)
        {
            InitializeComponent();
            mAccount = oAccount;
            mExpertInfoBll = new ExpertInfoBll(mAccount);
            mCenterinfoesBll = new CenterInfoesBll(mAccount);
            iFlag = flag;
            idGV = idGiangVien;
        }
        private void frmGiangVienAdd_Load(object sender, EventArgs e)
        {
            actionUpdate.PressUpdate += new EventHandler(actionUpdate_PressUpdate);
            actionUpdate.PressHelp += new EventHandler(actionUpdate_PressHelp);
            actionUpdate.PressClose += new EventHandler(actionUpdate_PressClose);
            actionUpdate.PressNew += new EventHandler(actionUpdate_PressNew);
            //iFlag = 0: Thêm mới; iFlag = 1: Sửa
            Load_lookupEditTrungTam();
            if (iFlag == 0)
            {
                this.Text = "Thêm giáo viên mới";
            }else
            {
                ExpertInfo oExpInfo = mExpertInfoBll.getElementById(idGV);
                txtHoten.Text = oExpInfo.ExpertName;
                txtEmail.Text = oExpInfo.Email;
                txtDiaChi.Text = oExpInfo.Address;
                txtMobile.Text = oExpInfo.Mobile;
                txtMota.Text = oExpInfo.Description;
                txtNamKinhNghiem.Text = oExpInfo.YearsExperience.ToString();
                txtNoiDung.Text = "Không có sơ yếu lý lịch thì điền gì?";
                txtTruongTotNghiep.Text = oExpInfo.UniversityDegree;
                cboGioiTinh.EditValue = oExpInfo.sSex;
                dateEditNgaySinh.EditValue = oExpInfo.DateBirthday;
                this.Text = "Sửa thông tin giáo viên " + oExpInfo.ExpertName;
            }

        }
        void Load_lookupEditTrungTam()
        {
            lookupEditTrungTam.Properties.DataSource = mCenterinfoesBll.getElements();
            lookupEditTrungTam.Properties.ValueMember = "Id";
            lookupEditTrungTam.Properties.DisplayMember = "CenterName";
            //lookupEditTrungTam.EditValue = lookupEditTrungTam.Properties.DisplayMember;
        }
        void actionUpdate_PressNew(object sender, EventArgs e)
        {
            //Làm mới

        }
        void actionUpdate_PressClose(object sender, EventArgs e)
        {
            this.Close();
        }
        void actionUpdate_PressHelp(object sender, EventArgs e)
        {
            MessageBox.Show("Chắc năng chưa được cập nhật", "Thông báo");
        }

        void actionUpdate_PressUpdate(object sender, EventArgs e)
        {
            //Lưu giảng viên: 
            ExpertInfo oExpInfo = new ExpertInfo();
            oExpInfo.Id = idGV;
            oExpInfo.ExpertName = txtHoten.Text;
            oExpInfo.Email = txtEmail.Text;
            oExpInfo.Address = txtDiaChi.Text;
            oExpInfo.Mobile = txtMobile.Text;
            oExpInfo.Description = txtMota.Text ;
            oExpInfo.YearsExperience = int.Parse(txtNamKinhNghiem.Text);
            oExpInfo.UniversityDegree = txtTruongTotNghiep.Text ;
            oExpInfo.sSex = cboGioiTinh.EditValue.ToString();
            if (lookupEditTrungTam.EditValue != null) oExpInfo.CenterId = (int)lookupEditTrungTam.EditValue;
            else oExpInfo.CenterId = 1;
            oExpInfo.CenterId = (int)lookupEditTrungTam.EditValue;
            if (dateEditNgaySinh.EditValue != null)
            oExpInfo.DateBirthday = DateTime.Parse(dateEditNgaySinh.EditValue.ToString());
            oExpInfo.iFlag = iFlag;
            var check = mExpertInfoBll.InsertAndUpdateElement(oExpInfo);
            if ((check) & (iFlag == 0))
            {
                MessageBox.Show("Thêm thành công!");
                this.Close();
            }
            else if (check & iFlag == 1)
            {
                MessageBox.Show("Sửa thành công!");
                this.Close();
            }
            else MessageBox.Show("Thao tác không thành công!");

        }          
    }
}

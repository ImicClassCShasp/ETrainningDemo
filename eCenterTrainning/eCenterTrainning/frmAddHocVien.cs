using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Linq;
using System.Globalization;
using DevExpress.Skins;

using IMIC.SyncModule.DAO;
using IMIC.SyncModule.EntityObject;
using IMIC.SyncModule;

//using eCenterTrainning.Objects;
using eCenterTrainning.Base;
using IMIC.VALUEOBJECTS;
using IMIC.BUSINESSLOGICLAYERS;

namespace eCenterTrainning
{
    public partial class frmAddHocVien : frmIMICBase
    {        
        public frmAddHocVien(Account oAccount) : base(oAccount)
        {
            InitializeComponent();            
        }

        private void frmAddHocVien_Load(object sender, EventArgs e)
        {
            ActionUpdateHocVien.PressClose += new EventHandler(ActionUpdateHocVien_PressClose);
            ActionUpdateHocVien.PressSave += new EventHandler(ActionUpdateHocVien_PressSave);
            ActionUpdateHocVien.PressHelp += new EventHandler(ActionUpdateHocVien_PressHelp);
            ActionUpdateHocVien.PressRefresh += new EventHandler(ActionUpdateHocVien_PressRefresh);
            
            this.Text = "Thêm thông tin học viên";            
        }                
        private void LoadStatus()
        {
            List<Status> lisStatus = new StatusBll(mAccount).getElements();            
            lookUpEditStatus.Properties.DisplayMember = "StatusName";
            lookUpEditStatus.Properties.ValueMember = "Id";
            lookUpEditStatus.Properties.DataSource = lisStatus;
        }
        void ActionUpdateHocVien_PressSave(object sender, EventArgs e)
        {
            DateTime dt;
            mAccount.isClose = false;
            dt = DateTime.Parse(dateEditBirth.Text, Common.ci);
            try
            {                
                msgMessage.Clear();
                if (string.IsNullOrEmpty(txtHoTen.Text))
                {
                    msgMessage.SetError(txtHoTen, "Bạn cần nhập tên học viên trước khi thực hiện");
                    txtHoTen.Focus();                    
                }
                else if (string.IsNullOrEmpty(cmbSex.Text))
                {
                    msgMessage.SetError(cmbSex, "Bạn cần nhập giới tính trước khi thực hiện");
                    cmbSex.Focus();                    
                }
                else if (string.IsNullOrEmpty(dateEditBirth.Text))
                {
                    msgMessage.SetError(dateEditBirth, "Bạn cần nhập ngày sinh trước khi thực hiện");                   
                }
                else if (lookUpEditStatus.Text == "---Chọn trạng thái---")
                {
                    msgMessage.SetError(lookUpEditStatus, "Bạn cần chọn trạng thái trước khi thực hiện");
                    lookUpEditStatus.Focus();
                }
                else if (string.IsNullOrEmpty("" + lookUpEditCourse.EditValue))
                {
                    msgMessage.SetError(lookUpEditCourse, "Bạn cần chọn khóa học trước khi thực hiện");
                    lookUpEditCourse.Focus();
                }
                else
                {
                    MessageBox.Show("Lưu thông tin thành công", "Thông báo");                    
                }                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra. Chi tiết lỗi : " + ex.Message);
            }
        }

        void ActionUpdateHocVien_PressRefresh(object sender, EventArgs e)
        {
            
        }

        void ActionUpdateHocVien_PressHelp(object sender, EventArgs e)
        {

        }        

        void ActionUpdateHocVien_PressClose(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Hàm binding dữ liệu lên form để chỉnh sửa
        /// Author            Date           Comment
        /// hungld          04/02/2013      Tạo mới
        /// </summary>
        private void Bindings(StudentLists oStudentLists)
        {
            txtHoTen.Text = oStudentLists.FullName;
            txtDiaChi.Text = oStudentLists.Address;
            if (oStudentLists.Email != null)           
                txtEmail.Text = new Common().DecryptInfo(oStudentLists.Email);           
            else           
                txtEmail.Text = "";          
            if (oStudentLists.Mobile != null)            
                txtDiDong.Text = new Common().DecryptInfo(oStudentLists.Mobile);            
            else           
                txtDiDong.Text = "";           

            txtDescription.Text = oStudentLists.Description;
            dateEditBirth.Text = oStudentLists.DateBirthday != null ? oStudentLists.DateBirthday.Value.ToString("dd/MM/yyyy") : "";
            if (oStudentLists.StatusId.HasValue)
                lookUpEditStatus.EditValue = oStudentLists.StatusId;
            if (oStudentLists.CourseId > 0)
                lookUpEditCourse.EditValue = oStudentLists.CourseId;           
            if (oStudentLists.Sex == 0)            
                cmbSex.Text = "Nam";           
            else          
                cmbSex.Text = "Nữ";          
        }

        /// <summary>
        /// Hàm bắt trùng sinh viên
        /// Author              Date                Comment
        /// hungld            04/02/2013            Tạo mới
        /// </summary>
        private bool BatTrungDuLieu(int HVId)
        {                      
            return true;
        }
        private void LoadCourse()
        {
            List<Cours> lisCourse = new CourseBll(mAccount).getElements();            
            lookUpEditCourse.Properties.DisplayMember = "CourseName";
            lookUpEditCourse.Properties.ValueMember = "Id";
            lookUpEditCourse.Properties.DataSource = lisCourse;
        }

        private void lookUpEditCourse_EditValueChanged(object sender, EventArgs e)
        {
           
        }
        private void lookUpEditClass_TextChanged(object sender, EventArgs e)
        {
            int idClass = 0;
            int.TryParse("" + lookUpEditClass.EditValue, out idClass);
            if (idClass > 0)
            {
                lookUpEditUuDai.Properties.ReadOnly = false;
            }
        }

        private void lookUpEditStatus_EditValueChanged(object sender, EventArgs e)
        {
            int idStatus = 0;
            int.TryParse("" + lookUpEditStatus.EditValue, out idStatus);
            if (idStatus == 1 || idStatus == -1)
            {
                lookUpEditClass.Properties.ReadOnly = true;
                lookUpEditUuDai.Properties.ReadOnly = true;
                lookUpEditClass.EditValue = -1;
                lookUpEditUuDai.EditValue = -1;
            }
            else
            {
                lookUpEditClass.Properties.ReadOnly = false;
            }
        }
    }
}
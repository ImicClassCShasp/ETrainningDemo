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
    public partial class frmPolicyStudent : Base.frmIMICBase
    {
        public frmPolicyStudent()
        {
            InitializeComponent();
        }        
       
        private void frmPolicyStudent_Load(object sender, EventArgs e)
        {
            actionUpdatePolicyStudent.PressNew += new EventHandler(actionUpdatePolicyStudent_PressNew);
            actionUpdatePolicyStudent.PressUpdate += new EventHandler(actionUpdatePolicyStudent_PressUpdate);
            actionUpdatePolicyStudent.PressClose += new EventHandler(actionUpdatePolicyStudent_PressClose);
            actionUpdatePolicyStudent.PressHelp += new EventHandler(actionUpdatePolicyStudent_PressHelp);
            loadCenter();
            this.Text = "Thêm mới thông tin chương trình ưu đãi";
            
            dateEditDateStart.EditValue = DateTime.Now;
            dateEditDateApprove.EditValue = DateTime.Now;
            DateTime dateEnd = DateTime.Now.AddMonths(1);
            dateEditDateEnd.EditValue = dateEnd;
        }

        void actionUpdatePolicyStudent_PressHelp(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng này chưa được cập nhật","Thông Báo");
        }

        void actionUpdatePolicyStudent_PressClose(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Author          Date        Comment
        /// BONGVX                      Them hoac sua thong tin chuong trinh uu dai
        /// </summary>
        void actionUpdatePolicyStudent_PressUpdate(object sender, EventArgs e)
        {
            msgMessage.Clear();
            if (string.IsNullOrEmpty(txtTen.Text))
            {
                msgMessage.SetError(txtTen, "Bạn cần nhập thông tin chương trình ưu đãi trước khi thực hiện");
                txtTen.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtBonus.Text))
            {
                msgMessage.SetError(txtBonus, "Bạn cần nhập thông tin phần trăm ưu đãi trước khi thực hiện");
                txtBonus.Focus();
                return;
            }
            if (string.IsNullOrEmpty("" + dateEditDateStart.Text))
            {
                msgMessage.SetError(dateEditDateStart, "Bạn cần chọn ngày bắt đầu chương trình ưu đãi trước khi thực hiện");
                return;
            }
            if (string.IsNullOrEmpty("" + dateEditDateEnd.Text))
            {
                msgMessage.SetError(dateEditDateEnd, "Bạn cần chọn ngày kết thức chương trình ưu đãi trước khi thực hiện");
                return;
            }
            if (string.IsNullOrEmpty("" + lookUpEditCenter.EditValue))
            {
                msgMessage.SetError(lookUpEditCenter, "Bạn cần chọn trung tâm trước khi thực hiện");
                lookUpEditCenter.Focus();
                return;
            }            
        }

        void actionUpdatePolicyStudent_PressNew(object sender, EventArgs e)
        {
            resetAllField();
        }
        //load center
        private void loadCenter() {
            
            //lookUpEditCenter.Properties.DataSource = lstCenter;
            lookUpEditCenter.Properties.DisplayMember = "CenterName";
            lookUpEditCenter.Properties.ValueMember = "Id";            
        }

        private void btnAddMoreCenter_Click(object sender, EventArgs e)
        {
            frmCenterInfo frm = new frmCenterInfo();
            frm.ShowDialog();            
            loadCenter();
        }

        /// <summary>
        /// Chon anh
        /// </summary>
        
        OpenFileDialog ofd = new OpenFileDialog();
        private void btnImagePath_Click(object sender, EventArgs e)
        {
            ofd.Filter = "JPEG Files (*.jpeg)|*.jpeg|PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif|All files (*.*)|*.*";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txtImagePath.Text = ofd.FileName;
            }
            
        }
        /// <summary>
        /// Author          Date        Comment
        /// BONGVX                      Them thong tin chuong trinh uu dai
        /// </summary>
        private int insertPolicyStudent() {
            try
            {                
                
                return 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace, ex.Message);
                return 0;
            }
        }
        /// <summary>
        /// Author          Date        Comment
        /// BONGVX                      Sua thong tin chuong trinh uu dai
        /// </summary>
        private int updateolicyStudent()
        {
            try
            {
                
                MessageBox.Show("");
                return 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace, ex.Message);
                return 0;
            }
        }
        
        /// <summary>
        /// Author          Date        Comment
        /// BONGVX                      load du lieu
        /// </summary>
        private void preUpdatePolicyStudentData()
        {
            
        }
        private void resetAllField() {
            foreach (Control c in groupControlPolicyStudent.Controls)
            {
                if (c is DevExpress.XtraEditors.TextEdit)
                {
                    c.Text = "";
                }
            }
            txtDescription.Text = "";
            txtContent.Text = "";           
        }
        /// <summary>
        /// Author          Date        Comment
        /// BONGVX                      Khong chinh sua thong tin tren field
        /// </summary>
        private void disableAllField()
        {
            foreach (Control c in groupControlPolicyStudent.Controls)
            {
                if (c is DevExpress.XtraEditors.TextEdit)
                {
                    c.Enabled =false;
                }
            }
            actionUpdatePolicyStudent.Enabled = false;
            txtDescription.Enabled = false;
            txtContent.Enabled = false;
            btnAddMoreCenter.Enabled = false;
            btnImagePath.Enabled = false;
        }
        private string contentPolicyStudents = "";

        public string ContentPolicyStudents
        {
            get { return contentPolicyStudents; }
            set { contentPolicyStudents = value; }
        }
        /// <summary>
        /// Author          Date        Comment
        /// BONGVX                      Lay thong tin chi tiet chuong trinh uu dai
        /// </summary>
        private void getDataInfomation(String data)
        {
            ContentPolicyStudents = data;
            //txtNoiDung.Text = ContentRecruitment;
        }
        private void btnContent_Click(object sender, EventArgs e)
        {
            frmInformationDetail frm = new frmInformationDetail();            
        }
    }
}
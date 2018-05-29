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
    public partial class frmAddCommetSupport : DevExpress.XtraEditors.XtraForm
    {        
        public frmAddCommetSupport()
        {
            InitializeComponent();
        }

        private void frmAddCommetSupport_Load(object sender, EventArgs e)
        {
            actionMenu1.PressNew += new EventHandler(actionMenu1_PressNew);
            actionMenu1.PressEdit += new EventHandler(actionMenu1_PressEdit);
            actionMenu1.PressDelete += new EventHandler(actionMenu1_PressDelete);
            actionMenu1.PressRefresh += new EventHandler(actionMenu1_PressRefresh);
            actionMenu1.PressClose += new EventHandler(actionMenu1_PressClose);
            actionMenu1.PressHelp += new EventHandler(actionMenu1_PressHelp);
                        
            this.Text = "Lịch sử hỗ trợ";            
        }

        void actionMenu1_PressHelp(object sender, EventArgs e)
        {

        }

        void actionMenu1_PressClose(object sender, EventArgs e)
        {
            this.Close();
        }

        void actionMenu1_PressRefresh(object sender, EventArgs e)
        {

        }

        void actionMenu1_PressDelete(object sender, EventArgs e)
        {

        }

        void actionMenu1_PressEdit(object sender, EventArgs e)
        {

        }

        void actionMenu1_PressNew(object sender, EventArgs e)
        {
            msgError.Dispose();
            if (lookUpEditStudent.Text == "---Chọn học viên---")
            {
                msgError.SetError(lookUpEditStudent, "Bạn cần nhập tên học viên trước khi thực hiện");
                lookUpEditStudent.Focus();
                return;
            }
            if (string.IsNullOrEmpty(dateEditSupport.Text))
            {
                msgError.SetError(dateEditSupport, "Bạn cần nhập ngày hỗ trợ trước khi thực hiện");
                dateEditSupport.Focus();
                return;
            }
            if (lookUpEditCourse.Text == "---Chọn thông tin hỗ trợ---")
            {
                msgError.SetError(lookUpEditCourse, "Bạn cần chọn thông tin hỗ trợ trước khi thực hiện");
                lookUpEditCourse.Focus();
                return;
            }
            MessageBox.Show("");
        }   
        private void LoadCourse()
        {                        
            lookUpEditCourse.Properties.DisplayMember = "CourseName";
            lookUpEditCourse.Properties.ValueMember = "Id";
            //lookUpEditCourse.Properties.DataSource = lstCourse;

            //IQueryable<Student> lstStudent = objConnEntities.Students;
            lookUpEditStudent.Properties.DisplayMember = "FullName";
            lookUpEditStudent.Properties.ValueMember = "Id";
            //lookUpEditStudent.Properties.DataSource = lstStudent;
        }        
    }
}
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
using eCenterTrainning.Base;
using IMIC.VALUEOBJECTS;
using IMIC.BUSINESSLOGICLAYERS;
using IMIC.SyncModule;

namespace eCenterTrainning
{
    public partial class frmAddLopHoc : frmIMICBase
    {                
        public frmAddLopHoc(Account oAccount, Classes oClasses) : base(oAccount)
        {
            InitializeComponent();
            actionUpdateLopHoc.PressSave += new EventHandler(actionUpdateLopHoc_PressSave);
            actionUpdateLopHoc.PressRefresh += new EventHandler(actionUpdateLopHoc_PressRefresh);
            actionUpdateLopHoc.PressClose += new EventHandler(actionUpdateLopHoc_PressClose);
            actionUpdateLopHoc.PressHelp += new EventHandler(actionUpdateLopHoc_PressHelp);
        }

        private void BindClassesInfo(Classes oClasses)
        {
            txtClassName.Text = oClasses.ClassName;
            dateEditStart.EditValue = DateTime.Parse(""+oClasses.FromDate, Common.ci);
            dateEditFinish.EditValue = DateTime.Parse("" + oClasses.ToDate, Common.ci);
            txtSoLuongHv.Text = ""+oClasses.NumberStudents;
            txtMoTa.Text = oClasses.Description;
            //lookUpEdit1.EditValue = (int)oClasses.CourseId;
            cboVPDT.Text = oClasses.PlaceTraining;
            cboStatus.Text = oClasses.Status;
        }

        private void frmAddLopHoc_Load(object sender, EventArgs e)
        {            
            dateEditStart.EditValue = DateTime.Now;
            dateEditFinish.EditValue = DateTime.Now.AddMonths(1);
            this.Text = "Thêm mới lớp học";
            LoadCourseData();
        }

        void actionUpdateLopHoc_PressHelp(object sender, EventArgs e)
        {

        }

        void actionUpdateLopHoc_PressClose(object sender, EventArgs e)
        {
            this.Close();
        }

        void actionUpdateLopHoc_PressRefresh(object sender, EventArgs e)
        {
                        
        }

        void actionUpdateLopHoc_PressSave(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                MessageBox.Show("Lưu thông tin thành công!", 
                                "Thông báo", 
                                    MessageBoxButtons.OK, 
                                        MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void LoadCourseData()
        {           
            lookUpEdit1.Properties.DisplayMember = "CourseName";
            lookUpEdit1.Properties.ValueMember = "Id";
            //lookUpEdit1.Properties.DataSource = mLisCourse;
        }       
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Linq;
using eCenterTrainning.Objects;
using IMIC.VALUEOBJECTS;
using IMIC.BUSINESSLOGICLAYERS;
using eCenterTrainning.Base;
using IMIC.SyncModule;

namespace eCenterTrainning
{
    public partial class frmHocVienSearch : frmIMICBase
    {        
        public frmHocVienSearch(Account oAccount) : base(oAccount)
        {
            InitializeComponent();
        }
        private void frmHocVienSearch_Load(object sender, EventArgs e)
        {
            this.Text = "Tìm kiếm học viên theo ngày";            
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty("" + dtpStart.Text) && !string.IsNullOrEmpty("" + dtpEnd.Text))
            {                
                DateTime dtStartTime = DateTime.Parse("" + dtpStart.Value);
                DateTime dtEndTime = DateTime.Parse("" + dtpEnd.Value);
                if (mAccount.IsSuperUser == true)
                {
                    List<StudentLists> lisTemp = new StudentListsBll(mAccount).
                            getElementByTime(dtStartTime, dtEndTime);
                    if (lisTemp != null && lisTemp.Count > 0)
                    {
                        List<StudentLists> lisStudent = new List<StudentLists>();
                        foreach (StudentLists o in lisTemp)
                        {
                            StudentLists oStudentList = new StudentLists();
                            oStudentList.Id = o.Id;
                            oStudentList.FullName = o.FullName;
                            if (!string.IsNullOrEmpty(o.Email))
                            {
                                oStudentList.Email = new Common().DecryptInfo(o.Email);
                            }
                            oStudentList.Address = o.Address;
                            if (!string.IsNullOrEmpty(o.Mobile))
                            {
                                oStudentList.Mobile = new Common().DecryptInfo(o.Mobile);
                            }
                            oStudentList.DateCreate = o.DateCreate;
                            oStudentList.UserName = o.UserName;
                            oStudentList.CourseName = o.CourseName;
                            oStudentList.StatusName = o.StatusName;
                            lisStudent.Add(oStudentList);
                        }
                        gridControlHVHeThong.DataSource = lisStudent;
                    }
                }
                else
                {
                    MessageBox.Show("Bạn ko có quyền sử dụng tính năng này");
                }                
            }
        }              
    }
}
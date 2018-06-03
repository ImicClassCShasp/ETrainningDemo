using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IMIC.VALUEOBJECTS;
using IMIC.BUSINESSLOGICLAYERS;
using eCenterTrainning.Base;

namespace eCenterTrainning
{
    public partial class frmAddStudentIntoClassess : frmIMICBase
    {
        List<StudentLists> lstselected;
        Classes mClasses;
        StudentListsBll mStudentListsBll;
        List<StudentLists> lstStudentLists;
        public frmAddStudentIntoClassess(Account oAccount, Classes oClasses) : base(oAccount)
        {
            InitializeComponent();
            lstselected = new List<StudentLists>();
            mClasses = oClasses;
            mStudentListsBll = new StudentListsBll(mAccount, mClasses);
            dtStartTime.EditValue = DateTime.Now.AddMonths(-4);
            dtEndTime.EditValue = DateTime.Now;
            btnHoanTatChonHv.Enabled = false;
            
            
        }

        public frmAddStudentIntoClassess() : base()
        {
            InitializeComponent();
        }

        private void dtStartTime_EditValueChanged(object sender, EventArgs e)
        {
            dtEndTime.Enabled = true;
            if (!string.IsNullOrEmpty("" + dtStartTime.EditValue)
                    && !string.IsNullOrEmpty("" + dtEndTime.EditValue))
            {
                if (dtEndTime.EditValue == null)
                    dtEndTime.EditValue = DateTime.Now;
                LoadDataStudentByMonth();
            }
        }


        void LoadDataStudentByMonth()
        {
            //try
            //{
            //    this.Cursor = Cursors.WaitCursor;
            //    grCListStudents.DataSource = mStudentListsBll.getElementByTime(DateTime.Parse(dtStartTime.EditValue.ToString()), DateTime.Parse(dtEndTime.EditValue.ToString())).ToList();

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
            //finally
            //{
            //    this.Cursor = Cursors.Default;
            //}
            lstStudentLists = mStudentListsBll.getElementByTime(DateTime.Parse(dtStartTime.EditValue.ToString()), DateTime.Parse(dtEndTime.EditValue.ToString()));
            grCListStudents.DataSource = lstStudentLists;
        }

        private void frmAddStudentIntoClassess_Load(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                LoadDataStudentByMonth();
                
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

        private void grVListStudents_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            if (e.Column == colAction)
            {
                int getId = 0;
                int.TryParse("" + grVListStudents.GetFocusedRowCellValue("Id"), out getId);
               

                if (getId > 0)
                {
                    btnHoanTatChonHv.Enabled = true;
                    StudentLists obj = mStudentListsBll.getElementById(getId);
                    //foreach (StudentLists item in lstselected)
                    //{
                    //    if (item.Id == obj.Id)
                    //        return;
                    //}
                    foreach (StudentLists item in lstStudentLists)
                    {
                        if(obj.Id == item.Id)
                        {
                            lstStudentLists.Remove(item);
                            break;
                        }
                    }
                    grCListStudents.DataSource = lstStudentLists;
                    grCListStudents.RefreshDataSource();
                    grCListStudents.Refresh();

                    lstselected.Add(obj);
                    LoadDataStudentSelected();


                }

            }
        }        
        void LoadDataStudentList()
        {
            //grCListStudents.DataSource = mLisStudent;
            grCListStudents.RefreshDataSource();
            grCListStudents.Update();
        }
        void LoadDataStudentSelected()
        {
            ////Nạp dữ liệu cho GridView
            ////grCStudentSelected.DataSource = mStudentListsTempSelected;
            //grCStudentSelected.RefreshDataSource();
            //grCStudentSelected.Update();
            //lblStuSelected.Visible = true;
            //grCStudentSelected.Refresh();
            
            grCStudentSelected.DataSource = lstselected;
            grCStudentSelected.RefreshDataSource();
            grCListStudents.Refresh();
        }

        private void dtEndTime_EditValueChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    this.Cursor = Cursors.WaitCursor;
            //    if (!string.IsNullOrEmpty("" + dtStartTime.EditValue)
            //        && !string.IsNullOrEmpty("" + dtEndTime.EditValue))
            //    {

            //        LoadDataStudentByMonth();
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
            //finally
            //{
            //    this.Cursor = Cursors.Default;
            //}
            if (!string.IsNullOrEmpty("" + dtStartTime.EditValue)
                    && !string.IsNullOrEmpty("" + dtEndTime.EditValue))
            {

                LoadDataStudentByMonth();
            }
        }

        private void grVStudentSelected_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            if (e.Column == colCAction)
            {
                int getStudentId = 0;
                int.TryParse("" + grVStudentSelected.GetFocusedRowCellValue("Id"), out getStudentId);
                

                if (getStudentId > 0)
                {

                    foreach (StudentLists item in lstselected)
                    {
                        if (item.Id == getStudentId)
                        {
                            lstStudentLists.Add(item);
                            grCListStudents.DataSource = lstStudentLists;
                            grCListStudents.RefreshDataSource();
                            grCListStudents.Refresh();
                            lstselected.Remove(item);
                            break;
                        }
                    }
                    
                    LoadDataStudentSelected();
                }
            }
        }

        private void btnHoanTatChonHv_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    this.Cursor = Cursors.WaitCursor;
            //    mClasses = new ClassesBll(mAccount).getElementById(mClasses.Id);
            //    List<StudentClasses> lstStudentClasses = new List<StudentClasses>();
            //    foreach (StudentLists item in lstselected)
            //    {
            //        StudentClasses obj = new StudentClasses
            //        {
            //            ClassId = mClasses.Id,
            //            StudentId = item.Id,
            //            DateStart = DateTime.Parse(mClasses.DateStart.ToString()),
            //            TotalPrice = (int)mClasses.TotalPrice,
            //            FullName = item.FullName

            //        };
            //        lstStudentClasses.Add(obj);
            //    }
            //    StudentClassesBll mStudentClassesBll = new StudentClassesBll(mAccount);
            //    int i = 0;
            //    foreach (StudentClasses item in lstStudentClasses)
            //    {

            //        if(mStudentClassesBll.InsertElement(item) == false)
            //        {
            //            MessageBox.Show("Thêm học viên" + item.FullName + "Thất bại!");
            //            i++;
            //        }
            //    }
            //    if(i == 0)
            //    {
            //        MessageBox.Show("Tất cả học viên đã thêm thành công!");
            //    }
            //    else
            //    {
            //        MessageBox.Show("Các học viên còn lại đã thêm thành công!");
            //    }
            //    this.Close();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
            //finally
            //{
            //    this.Cursor = Cursors.Default;
            //}
            mClasses = new ClassesBll(mAccount).getElementById(mClasses.Id);
            List<StudentClasses> lstStudentClasses = new List<StudentClasses>();
            //MessageBox.Show(mClasses.FromDate.ToString());
            foreach (StudentLists item in lstselected)
            {
                StudentClasses obj = new StudentClasses();

                obj.ClassId = mClasses.Id;
                obj.StudentId = item.Id;
                obj.DateStart = DateTime.Parse(mClasses.FromDate.ToString());
                if (mClasses.TotalPrice != null)
                    obj.TotalPrice = (int)mClasses.TotalPrice;
                else
                    obj.TotalPrice = 0;
                obj.FullName = item.FullName;

               
                lstStudentClasses.Add(obj);
            }
            StudentClassesBll mStudentClassesBll = new StudentClassesBll(mAccount);
            int i = 0;
            foreach (StudentClasses item in lstStudentClasses)
            {

                if (mStudentClassesBll.InsertElement(item) == false)
                {
                    MessageBox.Show("Thêm học viên" + item.FullName + "Thất bại!");
                    i++;
                }
            }
            if (i == 0)
            {
                MessageBox.Show("Tất cả học viên đã thêm thành công!");
            }
            else
            {
                MessageBox.Show("Các học viên còn lại đã thêm thành công!");
            }
            this.Close();

        }
    }
}

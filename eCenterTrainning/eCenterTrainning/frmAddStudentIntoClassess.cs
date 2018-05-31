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
        public frmAddStudentIntoClassess(Account oAccount, Classes oClasses) : base(oAccount)
        {
            InitializeComponent();            
            dtStartTime.EditValue = DateTime.Now.AddMonths(-4);
            dtEndTime.EditValue = DateTime.Now;
            btnHoanTatChonHv.Enabled = false;
        }

        private void dtStartTime_EditValueChanged(object sender, EventArgs e)
        {
            dtEndTime.Enabled = true;
            if (!string.IsNullOrEmpty("" + dtStartTime.EditValue)
                    && !string.IsNullOrEmpty("" + dtEndTime.EditValue))
            {
                LoadDataStudentByMonth();
            }
        }


        void LoadDataStudentByMonth()
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;                
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
            //Nạp dữ liệu cho GridView
            //grCStudentSelected.DataSource = mStudentListsTempSelected;
            grCStudentSelected.RefreshDataSource();
            grCStudentSelected.Update();
            lblStuSelected.Visible = true;            
        }

        private void dtEndTime_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                if (!string.IsNullOrEmpty("" + dtStartTime.EditValue)
                    && !string.IsNullOrEmpty("" + dtEndTime.EditValue))
                {
                    LoadDataStudentByMonth();
                }
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

        private void grVStudentSelected_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            if (e.Column == colCAction)
            {
                int getStudentId = 0;
                int.TryParse("" + grVStudentSelected.GetFocusedRowCellValue("StudentId"), out getStudentId);

                if (getStudentId > 0)
                {
                    
                }
            }
        }

        private void btnHoanTatChonHv_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;               
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
    }
}

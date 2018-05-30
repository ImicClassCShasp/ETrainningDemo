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
using IMIC.SyncModule;

namespace eCenterTrainning
{
    public partial class frmStudentRegisterOnline : frmIMICBase
    {        
        public frmStudentRegisterOnline(Account oAccount, 
                    List<StudentLists> oLisStudentLists, 
                            Actions oAction) : base(oAccount)
        {
            InitializeComponent();
            dtOffStartTime.EditValue = DateTime.Now.AddDays(-7);
            dtOffEndTime.EditValue = DateTime.Now;
            dtOffEndTime.Enabled = true;
            btnOnAddIntoSystem.Enabled = false;         
        }

        private void btnOffLoadDataOfEtraining_Click(object sender, EventArgs e)
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

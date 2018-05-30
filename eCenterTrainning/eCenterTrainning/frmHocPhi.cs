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
    public partial class frmHocPhi : Base.frmIMICBase
    {        
        public frmHocPhi()
        {
            InitializeComponent();
        }
        private void frmHocPhi_Load(object sender, EventArgs e)
        {
            this.Text = "Thông tin học phí";
            loadClass();
            loadStudentData();
            loadPolicyStudent();            
        }        
        private void loadClass()
        {
            MessageBox.Show("");
            //lookUpEditCourse.Properties.DataSource = cls;
            lookUpEditCourse.Properties.DisplayMember = "CourseName";
            lookUpEditCourse.Properties.ValueMember = "Id";
            //if (IdClass > 0)
            //{
            //    lookUpEditCourse.EditValue = IdClass;
            //}
        }

        private void lookUpEditCourse_EditValueChanged(object sender, EventArgs e)
        {
            int idCourse = 0;
            int.TryParse("" + lookUpEditCourse.EditValue, out idCourse);
            MessageBox.Show("");
        }
        private void loadStudentData()
        {
            MessageBox.Show("");
        }

        private Boolean isCheckMore = false;

        public Boolean IsCheckMore
        {
            get { return isCheckMore; }
            set { isCheckMore = value; }
        }
        private void CheckEditHP_CheckedChanged(object sender, EventArgs e)
        {
            txtPrice2.Properties.ReadOnly = false;
            txtPrice3.Properties.ReadOnly = false;
            if (isCheckMore)
            {
                txtPrice2.Properties.ReadOnly = true;
                txtPrice3.Properties.ReadOnly = true;
                isCheckMore = false;
            }
            isCheckMore = true;
        }
        private int checkExistStudentClass(int idClass)
        {           
            return 0;
        }

        private void loadPolicyStudent()
        {
            //int idClass =0;
            MessageBox.Show("");
            lookUpEditUuDai.Properties.DisplayMember = "PolicyName";
            lookUpEditUuDai.Properties.ValueMember = "Id";
            //lookUpEditUuDai.Properties.DataSource = lstPolicy;

        }

        private void lookUpEditUuDai_EditValueChanged(object sender, EventArgs e)
        {
            calculator();
        }

        private void calculator()
        {
           
            int idpoli = 0;
            int.TryParse("" + lookUpEditUuDai.EditValue, out idpoli);
           
        }


        private void txtGiamHocPhi_TextChanged(object sender, EventArgs e)
        {
            calculator();
        }

        private void txtHP_TextChanged(object sender, EventArgs e)
        {
            calculator();
        }

    }
}

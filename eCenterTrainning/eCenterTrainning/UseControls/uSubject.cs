using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Linq;

namespace eCenterTrainning.UseControls
{
    public partial class uSubject : DevExpress.XtraEditors.XtraUserControl
    {
        public uSubject()
        {
            InitializeComponent();
        }

        private void uSubject_Load(object sender, EventArgs e)
        {

            xtraTabPageSubject.Focus();

            actionMenu1.PressNew += new EventHandler(actionMenu1_PressNew);
            actionMenu1.PressEdit += new EventHandler(actionMenu1_PressEdit);
            actionMenu1.PressRefresh += new EventHandler(actionMenu1_PressRefresh);
            actionMenu1.PressDelete += new EventHandler(actionMenu1_PressDelete);
            actionMenu1.PressClose += new EventHandler(actionMenu1_PressClose);
            actionMenu1.PressHelp += new EventHandler(actionMenu1_PressHelp);
            HienThiThongTinMonHoc();
          
        }

        void actionMenu1_PressHelp(object sender, EventArgs e)
        {

        }

        void actionMenu1_PressClose(object sender, EventArgs e)
        {
            this.Dispose();
        }

        void actionMenu1_PressDelete(object sender, EventArgs e)
        {
            int intLanguageId = 0;
            int.TryParse("" + gridViewSubject.GetFocusedRowCellValue("Id"), out intLanguageId);
            if (intLanguageId > 0)
            {
                DialogResult dlg = MessageBox.Show("Bạn có chắc chắn muốn xóa thông tin này ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dlg == DialogResult.Yes)
                {
                    MessageBox.Show("");
                }
                HienThiThongTinMonHoc();
            }
            else
            {
                MessageBox.Show("Bạn cần chọn thông tin để thực hiện thao tác này !!!", "Thông báo");
            }
        }

        void actionMenu1_PressRefresh(object sender, EventArgs e)
        {
            HienThiThongTinMonHoc();
        }

        void actionMenu1_PressEdit(object sender, EventArgs e)
        {
            int intSubjectId = 0;

            int.TryParse("" + gridViewSubject.GetFocusedRowCellValue("Id"), out intSubjectId);


            if (intSubjectId > 0)
            {
                frmAddMonHoc objSua = new frmAddMonHoc();

                //objSua.IdSub = intSubjectId;
                //objSua.SubjectName = gridViewSubject.GetFocusedRowCellValue("SubjectName").ToString();
                //objSua.Description = gridViewSubject.GetFocusedRowCellValue("SubjectDescription").ToString();

                objSua.ShowDialog();
                HienThiThongTinMonHoc();
            }
            else
            {
                MessageBox.Show("Bạn cần chọn thông tin trước khi thực hiện", "Thông báo");
            }
        }

        void actionMenu1_PressNew(object sender, EventArgs e)
        {            
            frmAddMonHoc objAddMonHoc = new frmAddMonHoc();
            objAddMonHoc.ShowDialog();
            HienThiThongTinMonHoc();
        }

        /// <summary>
        /// Hàm hiển thị thông tin môn học
        /// Author                 CreateDate
        /// hungld                 03/02/2013
        /// </summary>
        private void HienThiThongTinMonHoc()
        {
           
            
        }
        private void xtraTabControlSubject_Click(object sender, EventArgs e)
        {
                      
            lookUpEditSubject.Properties.DisplayMember = "SubjectName";
            lookUpEditSubject.Properties.ValueMember = "Id";
            //lookUpEditSubject.Properties.DataSource = lstSubject;

            string strId = "" + gridViewSubject.GetFocusedRowCellValue("Id");

            lookUpEditSubject.EditValue = int.Parse(strId);
        }

        private void lookUpEditSubject_EditValueChanged(object sender, EventArgs e)
        {
            int _Id = 0;
            int.TryParse("" + lookUpEditSubject.EditValue, out _Id);
            MessageBox.Show("");

        }

    }
}

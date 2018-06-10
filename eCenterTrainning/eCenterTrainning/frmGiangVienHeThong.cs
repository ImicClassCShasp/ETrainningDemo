using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Linq;
using eCenterTrainning.Base;
using IMIC.VALUEOBJECTS;
using IMIC.BUSINESSLOGICLAYERS;

namespace eCenterTrainning
{
    public partial class frmGiangVienHeThong : frmIMICBase
    {
        List<ExpertInfo> mLisExpertInfo;
        Classes mClasses;
        ExpertInfo mExpertInfo;
        public frmGiangVienHeThong(Account oAccount,ExpertInfo oExpertInfo, Classes oClasses) : base(oAccount)
        {
            InitializeComponent();
            mLisExpertInfo = new List<ExpertInfo>();
            mClasses = oClasses;
            mExpertInfo = oExpertInfo;
        }
        private void frmGiangVienHeThong_Load(object sender, EventArgs e)
        {
            this.Text = "Chọn giảng viên vào lớp";           
            loadGiangVien();
        }           
        private void loadGiangVien()
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                mLisExpertInfo = new ExpertInfoBll(mAccount).getElements();
                gridControlGiangVien.DataSource = mLisExpertInfo;
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

        private void gridControlGiangVien_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                int id = 0;
                int.TryParse("" + gridViewGiangVien.GetFocusedRowCellValue("Id"), out id);
                if (id > 0)
                {
                    string FullName = "" + gridViewGiangVien.GetFocusedRowCellValue("ExpertName");
                    btnGiangVien.Visible = true;
                    btnGiangVien.Enabled = true;
                    btnGiangVien.Text = string.Format("Bấm nút để chọn Chuyên gia: {0} sẽ phụ trách lớp: {1}."
                                            , FullName, mClasses.ClassName);
                    mExpertInfo.Id = id;
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

        private void btnGiangVien_Click(object sender, EventArgs e)
        {
            mExpertInfo.iFlag = -1; // messenge box do not open when close form
            this.Close();
        }
    }
}
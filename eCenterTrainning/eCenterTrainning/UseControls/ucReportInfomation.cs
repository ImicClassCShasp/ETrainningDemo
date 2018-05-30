using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using eCenterTrainning.Base;

namespace eCenterTrainning.UseControls
{
    public partial class ucReportInfomation : UserControl
    {
        public ucReportInfomation()
        {
            InitializeComponent();
            actionMenu1.PressNew += new EventHandler(actionMenu1_PressNew);
            actionMenu1.PressEdit += new EventHandler(actionMenu1_PressEdit);
            actionMenu1.PressRefresh += new EventHandler(actionMenu1_PressRefresh);
            actionMenu1.PressDelete += new EventHandler(actionMenu1_PressDelete);
            actionMenu1.PressClose += new EventHandler(actionMenu1_PressClose);
            actionMenu1.PressHelp += new EventHandler(actionMenu1_PressHelp);            
            
        }

        void actionMenu1_PressHelp(object sender, EventArgs e)
        {  }
        void actionMenu1_PressNew(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng này đã bị khóa. Để Báo Cáo bạn cần thực hiện theo các bước bên dưới nhé!");
        }
        void actionMenu1_PressEdit(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng này đã bị khóa. Để Báo Cáo bạn cần thực hiện theo các bước bên dưới nhé!");
        }
        void actionMenu1_PressRefresh(object sender, EventArgs e)
        {
            HienThiBaoCaoNgay();
        }
        void actionMenu1_PressDelete(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng này đã bị khóa. Để Báo Cáo bạn cần thực hiện theo các bước bên dưới nhé!");
        }
        void actionMenu1_PressClose(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {            
        }

        private string contentReportFB = "";

        public string ContentReportFB
        {
            get { return contentReportFB; }
            set { contentReportFB = value; }
        }

        private void getDataInfomation(String data)
        {
            ContentReportFB = data;
            //txtNoiDung.Text = ContentRecruitment;
        }

        private void btnVietBaoCao_Click(object sender, EventArgs e)
        {
            frmInformationDetail frm = new frmInformationDetail();
            //frm.setDataInfo = new frmInformationDetail.SetDataInformation(getDataInfomation);
            /*if (!string.IsNullOrEmpty(ContentReportFB))
            {
                frm.Data = ContentReportFB;
            }*/           
            txtNoiDungBc.Text = string.Format("[{0}] - Đã lưu nội dung. Bấm GỬI BÁO CÁO để hoàn tất!",DateTime.Now);
            btnVietBaoCao.Text = "2 - Cập nhật lại ND";
            btnGuiBaoCao.Enabled = true;
            HienThiBaoCaoNgay();
        }

        void HienThiBaoCaoNgay() {
            MessageBox.Show("");
        }
       
        private void grvBaoCaoNgay_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
        }

        private void grvBaoCaoNgay_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {            
            if (e.Column == colXemChiTiet)
            {
                MessageBox.Show("");
            }            
        }

        private void btnTaoBaoCaoNgay_Click(object sender, EventArgs e)
        {
            MessageBox.Show("");
        }

        private void btnGuiBaoCao_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn chắc chắn muốn gửi email Báo Cáo công việc với các Sếp?", "Thông báo",
                                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    this.Cursor = Cursors.WaitCursor;
                    //MailControllers objMail = new MailControllers();
                    //int userId = eCenterSystem.UserId;
                    MessageBox.Show("");
                }
            }
            catch (Exception ex)
            {                
                MessageBox.Show(string.Format("Có lỗi xảy ra: [{0}]", ex.Message));
            }
            finally {
                this.Cursor = Cursors.Default;
            }           
        }

        private void chkDuyetBaoCao_CheckedChanged(object sender, EventArgs e)
        {
            int reportId = int.Parse("" + lblReportId.Text);
            MessageBox.Show("");
        }

        private void ucReportInfomation_Load(object sender, EventArgs e)
        {
            HienThiBaoCaoNgay();
            KiemTraNgayBaoCao();
        }

        void KiemTraNgayBaoCao() {
            DateTime ngaybaocao = DateTime.Now.Date;         
            //int userId = eCenterSystem.UserId;
            MessageBox.Show("");
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace eCenterTrainning.UseControls
{
    public partial class ucQuanLyQuestionAnswers : UserControl
    {
        SqlConnection m_objConnection;
        static string server, data, userName, password;        

        public ucQuanLyQuestionAnswers()
        {
            InitializeComponent();
           
            //tab answers
            accMenuTraLoi.PressNew += new EventHandler(accMenuTraLoi_PressNew);
            accMenuTraLoi.PressEdit += new EventHandler(accMenuTraLoi_PressEdit);
            accMenuTraLoi.PressDelete += new EventHandler(accMenuTraLoi_PressDelete);
            accMenuTraLoi.PressRefresh += new EventHandler(accMenuTraLoi_PressRefresh);
            accMenuTraLoi.PressClose += new EventHandler(accMenuTraLoi_PressClose);
                       
            //HienThi_Thongtin_CauHoi_All();
            HienThi_DanhSach_TraLoi_All();
        }

        void accMenuTraLoi_PressClose(object sender, EventArgs e)
        {
            this.Dispose();
        }

        void accMenuTraLoi_PressRefresh(object sender, EventArgs e)
        {
            //HienThi_Thongtin_CauHoi_All();
            HienThi_DanhSach_TraLoi_All();
        }

        void accMenuTraLoi_PressDelete(object sender, EventArgs e)
        {
            int iAID = 0;
            int iQID = 0;
            int.TryParse("" + gridViewTraLoi.GetFocusedRowCellValue("AID"), out iAID);
            int.TryParse("" + gridViewTraLoi.GetFocusedRowCellValue("QID"), out iQID);

            if (iAID > 0)
            {
                DialogResult dr = MessageBox.Show("Bạn chắc muốn xóa câu trả lời này", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    MessageBox.Show("");
                }
                HienThi_DanhSach_TraLoi_All();
            }
            else
            {
                MessageBox.Show("Hãy chọn câu hỏi cần xóa", "Thông báo");
            }
        }

        void accMenuTraLoi_PressEdit(object sender, EventArgs e)
        {            
            int iAID = 0;
            int.TryParse("" + gridViewTraLoi.GetFocusedRowCellValue("AID"), out iAID);

            if (iAID > 0)
            {
                MessageBox.Show("");
            }
            else {
                MessageBox.Show("Bạn chưa chọn câu trả lời cần sửa", "Thông báo");
            }
        }

        void accMenuTraLoi_PressNew(object sender, EventArgs e)
        {
            MessageBox.Show("");
        }                
        
        void HienThi_DanhSach_TraLoi_All() {
            MessageBox.Show("");
        }
    }
}

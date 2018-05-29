using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace eCenterTrainning
{
    public partial class frmThemMoiKH : Base.frmIMICBase
    {        
        public frmThemMoiKH()
        {
            InitializeComponent();
        }
        private void frmThemMoiKH_Load(object sender, EventArgs e)
        {           
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("Cập nhật thông tin thành công", "Thông báo");
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

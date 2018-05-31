using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using IMIC.VALUEOBJECTS;

namespace eCenterTrainning.Base
{
    public partial class frmIMICBase : DevExpress.XtraEditors.XtraForm
    {
        protected Account mAccount;
        public frmIMICBase(Account oAccount)
        {
            InitializeComponent();
            mAccount = oAccount;
        }
        public frmIMICBase()
        {
            InitializeComponent();           
        }
        public frmIMICBase(Account oAccount,int Id)
        {
            InitializeComponent();
            mAccount = oAccount;
        }

        /// <summary>
        /// Sử dụng để override sự kiện nhấn nút thêm mới
        /// </summary>
        public virtual void ThemMoiThongTin()
        {
        }

        /// <summary>
        /// Sử dụng để override sự kiện nút sửa thông tin
        /// </summary>
        public virtual void SuaThongTin()
        {
        }

        /// <summary>
        /// Sử dụng để override sự kiện xóa thông tin
        /// </summary>
        public virtual void XoaThongTin()
        {

        }

        /// <summary>
        /// Sử dụng để override hiển thị danh sách thông tin
        /// </summary>
        public virtual void DanhSachThongTin()
        {
        }


        /// <summary>
        /// Sử dụng để override cập nhật thông tin
        /// </summary>
        public virtual void CapNhatThongTin()
        {

        }

        /// <summary>
        /// Sử dụng để override làm mới danh sách
        /// </summary>
        public virtual void LoadLaiDanhSach()
        {
        }
    }
}
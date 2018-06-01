using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace eCenterTrainning.Base
{
    public partial class ActionMenu : DevExpress.XtraEditors.XtraUserControl
    {
        /// <summary>
        /// Sự kiện khi nhấn nút thêm mới
        /// </summary>
        public event EventHandler PressNew = null;
        public event EventHandler PressEdit = null;
        public event EventHandler PressDelete = null;
        public event EventHandler PressRefresh = null;
        public event EventHandler PressClose = null;
        public event EventHandler PressHelp = null;
        public event EventHandler PressReports = null;
        public event EventHandler PressHVTiemNang = null;


        public ActionMenu()
        {
            InitializeComponent();
        }

        private void btnThemMoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (PressNew != null)
            {
                PressNew(sender, null);
            }
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (PressEdit != null)
            {
                PressEdit(sender, null);
            }
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (PressDelete != null)
            {
                PressDelete(sender, null);
            }
            
        }

        private void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (PressRefresh != null)
            {
                PressRefresh(sender, null);
            }
        }

        private void btnDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (PressClose != null)
            {
                PressClose(sender, null);
            }
        }

        private void btnTroGiup_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (PressHelp != null)
            {
                PressHelp(sender, null);
            }
        }

        private void btnBaoCao_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(PressReports != null){
                PressReports(sender, null);
            }
        }

        public void SetVisible()
        {
            btnThemMoi.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnBaoCao.Enabled = true;            
        }

        public void SetVisibleReport()
        {
            btnBaoCao.Enabled = true;
        }
        public void SetHVTiemNangVisible()
        {
            btnHocVienTiemNang.Enabled = true;
        }

        private void btnHocVienTiemNang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (PressHVTiemNang != null)
            {
                PressHVTiemNang(sender, null);
            }
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
    }
}

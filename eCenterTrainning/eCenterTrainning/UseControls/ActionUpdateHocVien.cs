using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace eCenterTrainning.UseControls
{
    public partial class ActionUpdateHocVien : DevExpress.XtraEditors.XtraUserControl
    {
        public event EventHandler PressSave = null;
        public event EventHandler PressClose = null;
        public event EventHandler PressHelp = null;
        public event EventHandler PressRefresh = null;
                
        public ActionUpdateHocVien()
        {
            InitializeComponent();
        }
        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (PressSave != null)
            {
                PressSave(sender, null);
            }
        }
        private void btnLamMoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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
    }
}

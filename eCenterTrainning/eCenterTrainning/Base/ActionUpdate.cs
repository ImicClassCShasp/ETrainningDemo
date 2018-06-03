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
    public partial class ActionUpdate : DevExpress.XtraEditors.XtraUserControl
    {
        public event EventHandler PressUpdate = null;
        public event EventHandler PressClose = null;
        public event EventHandler PressHelp = null;
        public event EventHandler PressNew = null;
        //public event EventHandler PressReset = null;

        private string _nameUpdate = "Lưu lại";

        public ActionUpdate()
        {
            InitializeComponent();
        }

        private void btnCapNhat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (PressUpdate != null)
            {
                PressUpdate(sender, null);
            }
        }

        private void btnTroGiup_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (PressHelp != null)
            {
                PressHelp(sender, null);
            }
        }

        private void btnDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (PressClose != null)
            {
                PressClose(sender, null);
            }
        }

        private void btnLamMoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (PressNew != null)
            {
                PressNew(sender, null);
            }
        }

        public void SetNameUpdate(string strButtonName) 
        {
            btnCapNhat.Caption = strButtonName;
        }

        private void ActionUpdate_Load(object sender, EventArgs e)
        {
            btnCapNhat.Caption = _nameUpdate;
        }
    }
}

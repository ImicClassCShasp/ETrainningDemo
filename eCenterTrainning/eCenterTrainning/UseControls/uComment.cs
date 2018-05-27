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
    public partial class uComment : DevExpress.XtraEditors.XtraUserControl
    {
        public uComment()
        {
            InitializeComponent();
        }
        private event EventHandler PressPasteItem = null;
        private event EventHandler PressCutItem = null;
        private event EventHandler PressCoppyItem = null;
        private event EventHandler PressPasteSpecialItem = null;
        private event EventHandler PressChangeStyleItem = null;
        private event EventHandler PressShowEditStyleFormItem = null;
        private event EventHandler PressChangeFontNameItem = null;
        private event EventHandler PressChangeFontSizeItem = null;
        private event EventHandler PressFontSizeIncreaseItem = null;
        private event EventHandler PressFontSizeDecreaseItem = null;
        private event EventHandler PressToggleFontBoldItem = null;
        private void uComment_Load(object sender, EventArgs e)
        {

        }

        private void pasteItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (PressPasteItem != null)
            {
                PressPasteItem(sender, null);
            }
        }

        private void cutItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (PressCutItem != null)
            {
                PressCutItem(sender, null);
            }
        }

        private void copyItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (PressCoppyItem != null)
            {
                PressCoppyItem(sender, null);
            }
        }

        private void pasteSpecialItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (PressPasteSpecialItem != null)
            {
                PressPasteSpecialItem(sender, null);
            }
        }

        private void changeStyleItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (PressChangeStyleItem != null)
            {
                PressChangeStyleItem(sender, null);
            }
        }

        private void showEditStyleFormItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (PressShowEditStyleFormItem != null)
            {
                PressShowEditStyleFormItem(sender, null);
            }
        }

        private void changeFontNameItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (PressChangeFontNameItem != null)
            {
                PressChangeFontNameItem(sender, null);
            }
        }

        private void changeFontSizeItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (PressChangeFontSizeItem != null)
            {
                PressChangeFontSizeItem(sender, null);
            }
        }

        private void fontSizeIncreaseItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (PressFontSizeIncreaseItem != null)
            {
                PressFontSizeIncreaseItem(sender, null);
            }
        }

        private void fontSizeDecreaseItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (PressFontSizeDecreaseItem != null)
            {
                PressFontSizeDecreaseItem(sender, null);
            }
        }

        private void toggleFontBoldItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (PressToggleFontBoldItem != null)
            {
                PressToggleFontBoldItem(sender, null);
            }
        }

    }
}

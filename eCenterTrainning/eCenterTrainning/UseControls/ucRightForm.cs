using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IMIC.VALUEOBJECTS;

namespace eCenterTrainning.UseControls
{
    public partial class ucRightForm : DevExpress.XtraEditors.XtraUserControl
    {
        protected Account mAccount;
        public ucRightForm(Account oAccount)
        {
            InitializeComponent();
            mAccount = oAccount;
        }
        public ucRightForm() { }
    }
}

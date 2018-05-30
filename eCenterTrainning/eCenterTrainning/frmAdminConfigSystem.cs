using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;

namespace eCenterTrainning
{
    public partial class frmAdminConfigSystem : Form
    {
        public frmAdminConfigSystem()
        {
            InitializeComponent();
        }

        private void cboVPDT_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboVPDT.SelectedIndex == 0)
                txtIPAdress.Text = ConfigurationManager.AppSettings["IMICHN"];
            else
                txtIPAdress.Text = ConfigurationManager.AppSettings["IMICHCM"];
            txtUserName.Text = ConfigurationManager.AppSettings["IMICUserName"];
            txtPassWord.Text = ConfigurationManager.AppSettings["IMICPassWord"];
            txtDatabaseName.Text = ConfigurationManager.AppSettings["IMICDatabaseName"];
        }
    }
}

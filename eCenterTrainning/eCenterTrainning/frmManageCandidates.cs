using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Linq;

namespace eCenterTrainning
{
    public partial class frmManageCandidates : DevExpress.XtraEditors.XtraForm
    {
        public frmManageCandidates()
        {
            InitializeComponent();
        }       
        private void frmManageCandidates_Load(object sender, EventArgs e)
        {
            this.Text = "Quản lý danh sách ứng viên";
            actionMenuCandidate.PressNew += new EventHandler(actionMenuCandidate_PressNew);
            actionMenuCandidate.PressEdit += new EventHandler(actionMenuCandidate_PressEdit);
            actionMenuCandidate.PressDelete += new EventHandler(actionMenuCandidate_PressDelete);
            actionMenuCandidate.PressClose += new EventHandler(actionMenuCandidate_PressClose);
            actionMenuCandidate.PressHelp += new EventHandler(actionMenuCandidate_PressHelp);
            actionMenuCandidate.PressRefresh += new EventHandler(actionMenuCandidate_PressRefresh);            
        }

        void actionMenuCandidate_PressRefresh(object sender, EventArgs e)
        {
           
        }
        void actionMenuCandidate_PressHelp(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng này chưa được cập nhật","Thông báo");
        }
        void actionMenuCandidate_PressClose(object sender, EventArgs e)
        {
            this.Close();
        }
        void actionMenuCandidate_PressDelete(object sender, EventArgs e)
        {
            
        }
        void actionMenuCandidate_PressEdit(object sender, EventArgs e)
        {
            
        }
        void actionMenuCandidate_PressNew(object sender, EventArgs e)
        {
            frmCandidate frm = new frmCandidate();
            frm.ShowDialog();           
        }      
    }
}
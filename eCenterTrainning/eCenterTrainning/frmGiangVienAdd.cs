using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using IMIC.SyncModule;

namespace eCenterTrainning
{
    public partial class frmGiangVienAdd : Base.frmIMICBase
    {              
        public frmGiangVienAdd()
        {
            InitializeComponent();
        }      
        private void frmGiangVienAdd_Load(object sender, EventArgs e)
        {
            actionUpdate.PressUpdate += new EventHandler(actionUpdate_PressUpdate);
            actionUpdate.PressHelp += new EventHandler(actionUpdate_PressHelp);
            actionUpdate.PressClose += new EventHandler(actionUpdate_PressClose);
            actionUpdate.PressNew += new EventHandler(actionUpdate_PressNew);                  
        }
        void actionUpdate_PressNew(object sender, EventArgs e)
        {
            
        }
        void actionUpdate_PressClose(object sender, EventArgs e)
        {
            this.Close();
        }
        void actionUpdate_PressHelp(object sender, EventArgs e)
        {
            MessageBox.Show("Chắc năng chưa được cập nhật", "Thông báo");
        }

        void actionUpdate_PressUpdate(object sender, EventArgs e)
        {
            
        }          
    }
}

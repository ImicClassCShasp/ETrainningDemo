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
    public partial class frmGiangVien : Base.frmIMICBase
    {
        public frmGiangVien()
        {
            InitializeComponent();
        }        
        private void frmGiangVien_Load(object sender, EventArgs e)
        {            
            actionMenuGiangVien.PressNew += new EventHandler(actionMenuGiangVien_PressNew);
            actionMenuGiangVien.PressEdit += new EventHandler(actionMenuGiangVien_PressEdit);
            actionMenuGiangVien.PressDelete += new EventHandler(actionMenuGiangVien_PressDelete);
            actionMenuGiangVien.PressClose += new EventHandler(actionMenuGiangVien_PressClose);           
        }

        void actionMenuGiangVien_PressClose(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        ///     Author          Date            Comments
        ///     BongVX          29/01/2013      Delete Expert
        /// </summary>
        void actionMenuGiangVien_PressDelete(object sender, EventArgs e)
        {
            
        }
        /// <summary>
        ///     Author          Date            Comments
        ///     BongVX          29/01/2013      Edit Expert
        /// </summary>
        void actionMenuGiangVien_PressEdit(object sender, EventArgs e)
        {

        }
        /// <summary>
        ///     Author          Date            Comments
        ///     BongVX          29/01/2013      Add new expert
        /// </summary>
        void actionMenuGiangVien_PressNew(object sender, EventArgs e)
        {
            frmGiangVienAdd frmGV = new frmGiangVienAdd();
            frmGV.ShowDialog();
        }
    }
}

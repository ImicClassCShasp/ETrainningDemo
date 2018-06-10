using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Linq;
using IMIC.VALUEOBJECTS;
namespace eCenterTrainning
{
    public partial class frmInformationDetail : DevExpress.XtraEditors.XtraForm
    {

        RecruitmentInfo mRec;
        Employee mEmp;
        Candidate mCan;
        int Flag;


        public frmInformationDetail()
        {
            InitializeComponent();
        }        
        public frmInformationDetail(RecruitmentInfo oRec)
        {
            InitializeComponent();
            mRec = new RecruitmentInfo();
            mRec = oRec;
            Flag = 1;
        }
        public frmInformationDetail(Candidate oCan)
        {
            InitializeComponent();
            mCan = new Candidate();
            mCan = oCan;
            Flag = 2;
        }
        public frmInformationDetail(Employee oEmp)
        {
            InitializeComponent();
            mEmp = new Employee();
            mEmp = oEmp;
            Flag = 3;
        }
        private void frmInformationDetail_Load(object sender, EventArgs e)
        {
            actionUpdateCV.PressNew += new EventHandler(ActionUpdateCV_PressNew);
            actionUpdateCV.PressUpdate += new EventHandler(actionUpdateCV_PressUpdate);
            actionUpdateCV.PressClose += new EventHandler(actionUpdateCV_PressClose);
            actionUpdateCV.PressHelp += new EventHandler(actionUpdateCV_PressHelp);
        }

        private void ActionUpdateCV_PressNew(object sender, EventArgs e)
        {
            richEditControlContent.Text = "";
        }

        void actionUpdateCV_PressHelp(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng này chưa được cập nhật", "Thông báo");
        }

        void actionUpdateCV_PressClose(object sender, EventArgs e)
        {
            this.Close();
        }

        void actionUpdateCV_PressUpdate(object sender, EventArgs e)
        {
            //MessageBox.Show("");
            if (Flag == 1) //them content vao Dot Ung Tuyen
            {
                if (richEditControlContent.Text == "")
                {
                    MessageBox.Show("Phải nhập nội dung em mới biết tuyển kiểu gì chứ anh êi!");
                    richEditControlContent.Focus();
                }
                else
                {
                    mRec.Contents = richEditControlContent.Text;
                    this.Close();
                }
            } else if (Flag==2) //Them content vao Ung Vien(CV)
            {
                if (richEditControlContent.Text == "")
                {
                    MessageBox.Show("Phải nhập nội dung em mới biết lí lịch ứng viên chứ anh êi!");
                    richEditControlContent.Focus();
                }
                else
                {
                    mCan.Contents = richEditControlContent.Text;
                    this.Close();
                }
            } else if (Flag==3)
            {
                if (richEditControlContent.Text == "")
                {
                    MessageBox.Show("Phải nhập nội dung em mới biết lí lịch nhân viên chứ anh êi!");
                    richEditControlContent.Focus();
                }
                else
                {
                    mEmp.EmployeeCV = richEditControlContent.Text;
                    this.Close();
                }
            }
        }
    }
}
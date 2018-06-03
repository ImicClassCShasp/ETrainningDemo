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
    public partial class frmSchedulesAdd : Base.frmIMICBase
    {        
        public frmSchedulesAdd()
        {
            InitializeComponent();
        }
        private void frmSchedulesAdd_Load(object sender, EventArgs e)
        {
            actionUpdate.PressUpdate += new EventHandler(actionUpdate_PressUpdate);
            actionUpdate.PressHelp += new EventHandler(actionUpdate_PressHelp);
            actionUpdate.PressClose += new EventHandler(actionUpdate_PressClose);
            actionUpdate.PressNew += new EventHandler(actionUpdate_PressNew);
            loadClasses();
            loadGiangVien();            
        }

        void actionUpdate_PressNew(object sender, EventArgs e)
        {
            resetAllField();
        }

        void actionUpdate_PressClose(object sender, EventArgs e)
        {
            this.Close();
        }
        void actionUpdate_PressHelp(object sender, EventArgs e)
        {
            MessageBox.Show("Chắc năng chưa được cập nhật", "Thông báo");
        }
        void resetAllField() {
            uluLopHoc.EditValue = 0;
            uluGiangVien.EditValue = 0;
            txtNoiDung.Text = "";
        }

        void actionUpdate_PressUpdate(object sender, EventArgs e)
        {
            msgMessage.Clear();
            if (string.IsNullOrEmpty("" + uluLopHoc.EditValue))
            {
                msgMessage.SetError(uluLopHoc, " Bạn cần chọn thông tin lớp học trước khi thực hiện");
                return;
            }
            else if (string.IsNullOrEmpty("" + uluGiangVien.EditValue))
            {
                msgMessage.SetError(uluGiangVien, " Bạn cần chọn thông tin Chuyên Gia trước khi thực hiện");
                return;
            }
            else if (string.IsNullOrEmpty(txtNoiDung.Text))
            {
                msgMessage.SetError(txtNoiDung, " Bạn cần nhập nội dung Nhật Ký trước khi thực hiện");
                return;
            }
            else{                
                this.Close();  
            }          
        }

        private void preUpdateSchedules(int idSchedule)
        {
            try
            {
                MessageBox.Show("");
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi hiển thị", "Thông báo");
            }
        }

        /// <summary>
        /// Author          Date        Comment
        /// BongVX          29/1/2013   Load ten trung tam
        /// </summary>

        public void loadClasses()
        {
            MessageBox.Show("");
            //uluLopHoc.Properties.DataSource = lstClassOrder;
            uluLopHoc.Properties.DisplayMember = "ClassName";
            uluLopHoc.Properties.ValueMember = "Id";
        }

        public void loadGiangVien()
        {
            
            //IQueryable<ExpertInfo> lisExpert = objConnEntities.ExpertInfoes;
            //uluGiangVien.Properties.DataSource = lisExpert;
            uluGiangVien.Properties.DisplayMember = "ExpertName";
            uluGiangVien.Properties.ValueMember = "Id";
        }
        /// <summary>
        /// Author          Date        Comment
        /// BongVX          29/1/2013   Them moi giang vien
        /// </summary>

        private bool insertScheduleInfor()
        {
            try
            {
                MessageBox.Show("");
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace, ex.Message);
                return false;
            }
        }
                
        /// <summary>
        /// Author          Date        Comment
        /// BongVX          29/1/2013   cap nhat thong tin giang vien
        /// </summary>

        private bool updateSchedules(int pScheduleId)
        {
            try
            {
                MessageBox.Show("");
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace, ex.Message);
                return false;
            }
        }
                        
        /// <summary>
        /// Author          Date        Comment
        /// BONGVX                      Lay thong tin chi tin chi tiet
        /// </summary>
        private void getDataInfomation(String data)
        {
            // _ExpertCV = data;
        }

        private void btnContent_Click(object sender, EventArgs e)
        {
            //frmInformationDetail frm = new frmInformationDetail();
            //frm.setDataInfo = new frmInformationDetail.SetDataInformation(getDataInfomation);
            //if (!string.IsNullOrEmpty(_ExpertCV))
            //{
            //    frm.Data = _ExpertCV;
            //}
            //frm.ShowDialog();
            //txtNoiDung.Text = "Đã có mô tả chi tiết về giảng viên";
        }
    }
}

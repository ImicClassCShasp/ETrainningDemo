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
    public partial class frmSchedulesExpertAdd : Base.frmIMICBase
    {      
        public frmSchedulesExpertAdd()
        {
            InitializeComponent();
        }

        private void frmSchedulesExpertAdd_Load(object sender, EventArgs e)
        {
            actionUpdate.PressUpdate += new EventHandler(actionUpdate_PressUpdate);
            actionUpdate.PressHelp += new EventHandler(actionUpdate_PressHelp);
            actionUpdate.PressClose += new EventHandler(actionUpdate_PressClose);
            actionUpdate.PressNew += new EventHandler(actionUpdate_PressNew);
            loadClasses();
            loadGiangVien();
            loadKhoaHoc();            
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
            uluLopHoc.EditValue = null;
            uluGiangVien.EditValue = null;
            uluKhoaHoc.EditValue = null;
            txtBuoiHoc.Text = "";
            txtGioHoc.Text = "";
            txtNgayHoc.Text = "";
            chkTrangThai.Checked = false;
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
            else if (string.IsNullOrEmpty("" + uluKhoaHoc.EditValue))
            {
                msgMessage.SetError(uluKhoaHoc, " Bạn cần chọn thông tin Khóa học trước khi thực hiện");
                return;
            }
            else if (string.IsNullOrEmpty(txtBuoiHoc.Text))
            {
                msgMessage.SetError(txtBuoiHoc, " Bạn cần nhập thông tin buổi học trước khi thực hiện");
                return;
            }
            else if (string.IsNullOrEmpty(txtNgayHoc.Text))
            {
                msgMessage.SetError(txtNgayHoc, " Bạn cần nhập thông tin ngày học trước khi thực hiện");
                return;
            }
            else if (string.IsNullOrEmpty(txtGioHoc.Text))
            {
                msgMessage.SetError(txtGioHoc, " Bạn cần nhập thông tin giờ học trước khi thực hiện");
                return;
            }            
            else{                
                this.Close();  
            }          
        }

        private void preUpdateSchedules(int idExSchedule)
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

        void loadClasses()
        {
            MessageBox.Show("");
            //IQueryable<Class> lisClasses = objConnEntities.Classes;
            //uluLopHoc.Properties.DataSource = lisClasses;
            uluLopHoc.Properties.DisplayMember = "ClassName";
            uluLopHoc.Properties.ValueMember = "Id";
        }

        void loadGiangVien()
        {
            MessageBox.Show("");
            //IQueryable<ExpertInfo> lisExpert = objConnEntities.ExpertInfoes;
            //uluGiangVien.Properties.DataSource = lisExpert;
            uluGiangVien.Properties.DisplayMember = "ExpertName";
            uluGiangVien.Properties.ValueMember = "Id";
        }

        void loadKhoaHoc()
        {
            
            //IQueryable<Cours> lisExpert = objConnEntities.Courses;
            //uluKhoaHoc.Properties.DataSource = lisExpert;
            uluKhoaHoc.Properties.DisplayMember = "CourseName";
            uluKhoaHoc.Properties.ValueMember = "Id";
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
    }
}

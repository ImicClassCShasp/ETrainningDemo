﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Linq;
using System.Globalization;
using System.Collections;
using eCenterTrainning.Objects;
using IMIC.SyncModule;
using IMIC.VALUEOBJECTS;
using IMIC.BUSINESSLOGICLAYERS;

namespace eCenterTrainning.UseControls
{
    public partial class uClass : ucRightForm
    {
        ClassesBll mClassesBll;
        List<Classes> mLisClasses;
        Classes mClasses;
        List<StudentClasses> mLisStudentClasses;
        List<ListStudents> mLisListStudents;
        public uClass(Account oAccount) : base(oAccount)
        {
            InitializeComponent();
            mClassesBll = new ClassesBll(mAccount);
            mLisClasses = new List<Classes>();
            mClasses = new Classes();
            mLisStudentClasses = new List<StudentClasses>();
            mLisListStudents = new List<ListStudents>();
        }
        
        private void uClass_Load(object sender, EventArgs e)
        {
            xtraTabPageClass.Focus();
            actionMenu1.PressNew += new EventHandler(actionMenu1_PressNew);
            actionMenu1.PressEdit += new EventHandler(actionMenu1_PressEdit);
            actionMenu1.PressRefresh += new EventHandler(actionMenu1_PressRefresh);
            actionMenu1.PressDelete += new EventHandler(actionMenu1_PressDelete);
            actionMenu1.PressClose += new EventHandler(actionMenu1_PressClose);
            actionMenu1.PressHelp += new EventHandler(actionMenu1_PressHelp);
            dtClassesStartTime.EditValue = DateTime.Now.AddYears(-1);
            dtClassesEndTime.EditValue = DateTime.Now;
            dtClassesEndTime.Enabled = true;
            LoadLookUpEditClass();
            LoadDataClasses();           
        }
        void LoadDataClasses()
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                mLisClasses = mClassesBll.getElements();
                if (mLisClasses != null)
                {
                    gridControlClass.DataSource = mLisClasses;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void LoadLookUpEditClass()
        {            
            try
            {
                this.Cursor = Cursors.WaitCursor;
                lookUpEditClass.Properties.ValueMember = "Id";
                lookUpEditClass.Properties.DisplayMember = "ClassName";
                List<Classes> oLisTemp = new ClassesBll(mAccount).getElements();
                lookUpEditClass.Properties.DataSource = oLisTemp;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        void actionMenu1_PressHelp(object sender, EventArgs e)
        {

        }

        void actionMenu1_PressClose(object sender, EventArgs e)
        {
            this.Dispose();
        }

        void actionMenu1_PressDelete(object sender, EventArgs e)
        {
            int intClassId = 0;
            int.TryParse("" + gridViewClass.GetFocusedRowCellValue("Id"), out intClassId);
            if (intClassId > 0)
            {
                MessageBox.Show("");
            }
            else
            {
                MessageBox.Show("Bạn cần chọn thông tin để thực hiện thao tác này !!!", "Thông báo");
            }
        }
        void actionMenu1_PressRefresh(object sender, EventArgs e)
        {
            
        }
        void actionMenu1_PressEdit(object sender, EventArgs e)
        {
            int intClassId=0;
            int.TryParse("" + gridViewClass.GetFocusedRowCellValue("Id"), out intClassId);

            if (intClassId > 0)
            {
                mClasses.Id = intClassId;
                if (mLisClasses != null && mLisClasses.Count > 0)
                {
                    foreach (var o in mLisClasses)
                    {
                        if (o.Id == mClasses.Id)
                        {
                            mClasses.ClassName = o.ClassName;
                            mClasses.FromDate = o.FromDate;
                            mClasses.ToDate = o.ToDate;
                            mClasses.PlaceTraining = o.PlaceTraining;
                            mClasses.NumberStudents = o.NumberStudents;
                            mClasses.Status = o.Status;
                            mClasses.Description = o.Description;
                            break;
                        }                                             
                    }
                    frmAddLopHoc objAddClass = new frmAddLopHoc(mAccount, mClasses);
                    objAddClass.ShowDialog();
                    RefeshListClasses(mClasses);
                }                
            }
            else
            {
                MessageBox.Show("Bạn cần chọn thông tin trước khi thực hiện", "Thông báo");
            }
        }

        void RefeshListClasses(Classes oClasses)
        {
            int j = 0;
            foreach (var o in mLisClasses)
            {
                if(o.Id == oClasses.Id)
                {
                    mLisClasses.Remove(o);
                    mLisClasses.Insert(j, oClasses);
                    break;
                }
                j++;
            }
            gridControlClass.DataSource = mLisClasses;
            gridControlClass.Update();
        }

        void actionMenu1_PressNew(object sender, EventArgs e)
        {                       
            frmAddLopHoc objAddClass = new frmAddLopHoc(mAccount,null);
            objAddClass.ShowDialog();
        }

        private void xtraTabControlClass_Click(object sender, EventArgs e)
        {
            
        }

        private void lookUpEditClass_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                int iClassId = 0;
                int.TryParse("" + lookUpEditClass.EditValue, out iClassId);
                if (iClassId > 0)
                {
                    LoadData_Student_Of_Classes(iClassId);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }                
        private void btnThemHocVien_Click(object sender, EventArgs e)
        {
            Classes oClasses = new Classes();
            oClasses.Id = string.IsNullOrEmpty(""+lookUpEditClass.EditValue) 
                                ? 0 : int.Parse("" + lookUpEditClass.EditValue);
            oClasses.ClassName = "" + lookUpEditClass.Text;
            if (oClasses.Id > 0)
            {
                frmAddStudentIntoClassess ofrm = new frmAddStudentIntoClassess(mAccount, oClasses);
                ofrm.ShowDialog();
                LoadData_Student_Of_Classes(oClasses.Id);
            }
        }        
        private void gridControlClass_MouseClick(object sender, MouseEventArgs e)
        {
           try
            {
                this.Cursor = Cursors.WaitCursor;
                int iClassId = 0;
                int.TryParse("" + gridViewClass.GetFocusedRowCellValue("Id"), out iClassId);
                if (iClassId > 0)
                {
                    string sClassName = "" + gridViewClass.GetFocusedRowCellValue("ClassName");
                    //LoadData_Student_Of_Classes(iClassId);                    
                    lookUpEditClass.EditValue = iClassId;
                    mClasses.Id = string.IsNullOrEmpty("" + lookUpEditClass.EditValue)
                                ? 0 : int.Parse("" + lookUpEditClass.EditValue);
                    mClasses.ClassName = sClassName;
                    mLisListStudents = new ListStudentsBll(mAccount).CheckElementById(mClasses.Id);
                    grCDanhSachHocVien.DataSource = mLisListStudents;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }
        void LoadData_Student_Of_Classes(int iClassId)
        {
            mLisStudentClasses = new StudentClassesBll(mAccount).CheckElementById(iClassId);
            if (mLisStudentClasses != null)
            {
                gridControlStudent.DataSource = mLisStudentClasses;
            }
        }
        private void btnGiangVien_Click(object sender, EventArgs e)
        {
            ExpertInfo oExpertInfo = new ExpertInfo();            
            frmGiangVienHeThong ofrm = new frmGiangVienHeThong(mAccount, oExpertInfo, mClasses);
            ofrm.ShowDialog();
            if (oExpertInfo.Id > 0)
            {
                //MessageBox.Show("- Ex: " + oExpertInfo.Id);
                mClasses.ExpertId = oExpertInfo.Id;
                bool isResult = new ClassesBll(mAccount).UpdateElement(mClasses);
                //if(isResult)
                MessageBox.Show("Bạn đã chọn Chuyên gia thành công", 
                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }            
        }       
        
        private void gridViewStudent_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            if (e.Column == ColAction)
            {
                Remove_Student_Of_Classes();
            }            
        }

        void Remove_Student_Of_Classes()
        {
            int iStudentId = 0;
            int.TryParse("" + gridViewStudent.GetFocusedRowCellValue("Id"), out iStudentId);
            if (iStudentId > 0)
            {
                string sFullName = "" + gridViewStudent.GetFocusedRowCellValue("FullName");
                DialogResult dr = MessageBox.Show(string.Format("Bạn có chắc muốn đưa học viên: {0} ra khỏi lớp này?", sFullName),
                                    "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    StudentClasses oStudent = new StudentClasses
                    {
                        Id = iStudentId
                    };
                    bool isResult = new StudentClassesBll(mAccount).DeleteElement(oStudent);
                    //MessageBox.Show("- iStudentId: "+ iStudentId);
                    foreach (StudentClasses o in mLisStudentClasses)
                    {
                        if (o.Id == oStudent.Id)
                        {
                            mLisStudentClasses.Remove(o);
                            break;
                        }
                    }
                    gridControlStudent.DataSource = mLisStudentClasses;
                    gridControlStudent.RefreshDataSource();
                    gridControlStudent.Update();
                }
            }
        }

        private void gridViewStudent_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {           
                btnXoaHocVien.Enabled = true;            
        }
        private void btnXoaHocVien_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                Remove_Student_Of_Classes();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void btnXuatDL_Click(object sender, EventArgs e)
        {
            if (mAccount.IsSuperUser == true)
            {
                if (mLisListStudents != null && mLisListStudents.Count > 0)
                {
                    Common oComs = new Common();
                    foreach (var o in mLisListStudents)
                    {
                        o.Email = string.IsNullOrEmpty(o.Email) ? "" : oComs.DecryptInfo(o.Email);
                        o.Mobile = string.IsNullOrEmpty(o.Mobile) ? "" : oComs.DecryptInfo(o.Mobile);
                    }
                    grCDanhSachHocVien.DataSource = mLisListStudents;
                    grCDanhSachHocVien.RefreshDataSource();
                    grCDanhSachHocVien.Update();

                    SaveFileDialog objSave = new SaveFileDialog();
                    objSave.FileName = "[IMIC]DANH SACH LOP " + txtTenLopHoc.Text;
                    objSave.Filter = "txt files (*.txt)|*.txt|Excel 2003 files (*.xls)|*xls|Excel 2007 late (*.xlsx)|*.xlsx|HTML files (*.htm)|*.htm|All files (*.*)|*.*";
                    if (objSave.ShowDialog() == DialogResult.OK)
                    {
                        DevExpress.XtraPrinting.XlsxExportOptions objOptions = new DevExpress.XtraPrinting.XlsxExportOptions();
                        objOptions.SheetName = "DANH SACH LOP " + txtTenLopHoc.Text;
                        grCDanhSachHocVien.ExportToXlsx(objSave.FileName, objOptions);
                        MessageBox.Show(String.Format("Files đã được lưu tại: [{0}]", objSave.FileName), "Thông báo",
                                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MessageBox.Show("Bạn không có quyền kết xuất dữ liệu danh sách học viên.",
                                    "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            }                       
        }

        private void btnChonChuyenGia_Click(object sender, EventArgs e)
        {
            //frmGiangVienHeThong objGiangVien = new frmGiangVienHeThong();
            //objGiangVien.IdGV = ClassId;
            //objGiangVien.ShowDialog();
            //HienThiChiTietDanhSachHocVienTheoLop();
        }                      
    }
}
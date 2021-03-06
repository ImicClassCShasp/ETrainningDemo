﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Linq;
using IMIC.VALUEOBJECTS;
using IMIC.BUSINESSLOGICLAYERS;

namespace eCenterTrainning.UseControls
{
    public partial class uEmployee : DevExpress.XtraEditors.XtraUserControl
    {
        Account mAcc;
        public uEmployee(Account oAcc)
        {
            InitializeComponent();
            mAcc = oAcc;
        }
        private int idEpm = 0;
        private void uEmployee_Load(object sender, EventArgs e)
        {
            
            
            
            actionMenuEmployee.PressRefresh += new EventHandler(actionMenuEmployee_PressRefresh);
            actionMenuEmployee.PressClose += new EventHandler(actionMenuEmployee_PressClose);
            actionMenuEmployee.PressHelp += new EventHandler(actionMenuEmployee_PressHelp);

            displayEmployee();
            stanfTabPermission mStanfTabPermission = new stanfTabPermission();
            foreach (stanfTabPermission item in mAcc.ListTabPermissions)
            {
                if (item.UserId == mAcc.UserId && item.DisplayRoleName == "Danh Sách Nhân Viên")
                {
                    mStanfTabPermission.IsAdd = item.IsAdd;
                    mStanfTabPermission.IsDelete = item.IsDelete;
                    mStanfTabPermission.IsEdit = item.IsEdit;
                    mStanfTabPermission.IsList = item.IsList;
                    mStanfTabPermission.IsReport = item.IsReport;
                }
            }
            if (mAcc.IsSuperUser == false)
            {
                int temp = 0;
                gridControlEmployee.Visible = false;
                if (mStanfTabPermission.IsAdd == true)
                {
                    actionMenuEmployee.PressNew += new EventHandler(actionMenuEmployee_PressNew);
                    temp++;
                }
                if (mStanfTabPermission.IsDelete == true)
                {
                    actionMenuEmployee.PressDelete += new EventHandler(actionMenuEmployee_PressDelete);
                    temp++;
                }
                if (mStanfTabPermission.IsEdit == true)
                {
                    actionMenuEmployee.PressEdit += new EventHandler(actionMenuEmployee_PressEdit);
                    temp++;
                }
                if (mStanfTabPermission.IsList == true)
                {
                    gridControlEmployee.Visible = true;
                    temp++;
                }
                if (temp == 0)
                {
                    actionMenuEmployee.Enabled = false;
                }
            }
            else
            {
                actionMenuEmployee.PressNew += new EventHandler(actionMenuEmployee_PressNew);
                actionMenuEmployee.PressDelete += new EventHandler(actionMenuEmployee_PressDelete);
                actionMenuEmployee.PressEdit += new EventHandler(actionMenuEmployee_PressEdit);
            }
        }
        void actionMenuEmployee_PressHelp(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng này chưa cập nhật", "Thông Báo");
        }

        void actionMenuEmployee_PressClose(object sender, EventArgs e)
        {

            this.Dispose();

        }

        void actionMenuEmployee_PressRefresh(object sender, EventArgs e)
        {
            displayEmployee();
        }
        /// <summary>
        /// Author          Date        Comment
        /// BONGVX                      Xoa thong tin NV
        /// </summary>
        void actionMenuEmployee_PressDelete(object sender, EventArgs e)
        {
            String value = "" + gridViewEmployee.GetFocusedRowCellValue("Id");
            int.TryParse(value, out idEpm);
            if (idEpm > 0)
            {
                DialogResult dr = MessageBox.Show("Bạn chắc muốn xóa nhân viên này", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    int IdEmployee = 0;
                    int.TryParse("" + gridViewEmployee.GetFocusedRowCellValue("Id"), out IdEmployee);

                    if (IdEmployee > 0)
                    {
                        Employee oEmp = new Employee
                        {
                            Id = IdEmployee
                        };

                        List<Employee> lstEmp = new EmployeeBLL(mAcc).getElements();

                        bool isResult = new EmployeeBLL(mAcc).DeleteElement(oEmp);
                        if (isResult)
                        {
                            foreach (Employee item in lstEmp)
                            {
                                if (oEmp.Id == item.Id)
                                {
                                    lstEmp.Remove(item);
                                    break;
                                }
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Hãy chọn nhân viên cần xóa", "Thông báo");
                }
                displayEmployee();
            }
        }
        /// <summary>
        /// Author          Date        Comment
        /// BONGVX                      Sua thong tin NV
        /// </summary>
        void actionMenuEmployee_PressEdit(object sender, EventArgs e)
        {
            String value = "" + gridViewEmployee.GetFocusedRowCellValue("Id");
            int.TryParse(value, out idEpm);
            if (idEpm > 0)
            {
                DialogResult dr = MessageBox.Show("Bạn chắc muốn sửa nhân viên này", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    Employee oEmp = new Employee()
                    {
                        Id = idEpm
                    };

                    frmEmployee frmEmp = new frmEmployee(mAcc, oEmp.Id);
                    frmEmp.ShowDialog();

                    displayEmployee();
                }
            }
            else
            {
                MessageBox.Show("Hãy chọn nhân viên cần cập nhật", "Thông báo");
            }
        }
    

        /// <summary>
        /// Author          Date        Comment
        /// BONGVX                      Them thong tin NV
        /// </summary>
        void actionMenuEmployee_PressNew(object sender, EventArgs e)
        {
            frmEmployee frmEmp = new frmEmployee(mAcc);
            frmEmp.ShowDialog();
            displayEmployee();
        }
        /// <summary>
        /// Author          Date        Comment
        /// BONGVX                      Hien thi thong tin NV
        /// </summary>
        void displayEmployee()
        {
            List<Employee> LstEmp = new EmployeeBLL(mAcc).getElements();
            gridControlEmployee.DataSource = LstEmp;
            this.Dock = DockStyle.Fill;
        }
        /// <summary>
        /// Author          Date        Comment
        /// BONGVX                      Hien thi thong tin NV chi tiet
        /// </summary>
        void gridControlEmployee_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            String value = "" + gridViewEmployee.GetFocusedRowCellValue("Id");
            int.TryParse(value, out idEpm);
            if (idEpm > 0)
            {
                MessageBox.Show("");
                //DialogResult dr = MessageBox.Show("Bạn chắc muốn sửa nhân viên này", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                //if (dr == DialogResult.Yes)
                //{
                //    frmEmployee frmEmp = new frmEmployee(mAcc, idEpm);
                //    frmEmp.ShowDialog();
                //    displayEmployee();
                //}
            }
        }
        /// <summary>
        /// Author          Date        Comment
        /// BONGVX                      Hien thi thong tin CV NV
        /// </summary>
        void gridViewEmployee_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            if (e.Column == colChiTiet)
            {
                int idEmp = 0;
                string value = "" + gridViewEmployee.GetFocusedRowCellValue("Id");
                int.TryParse(value, out idEmp);
                if (idEmp > 0)
                {
                    Employee employee = new EmployeeBLL(mAcc).getElementById(idEmp);
                    MessageBox.Show(
                        "Hồ sơ nhân viên: \n\n"+
                        "  Họ tên: "+employee.EmployeeName+ "\n"+
                        "  Tuổi: "+(DateTime.Now.Year-employee.DateBirhday.Value.Year)+ "\n" +
                        "  Địa chỉ: " +employee.Address+ "\n" +
                        "  Số điện thoại: " +employee.Mobile+ "\n" +
                        "----------------------------------------------"+ "\n" +
                        "  Mô tả: " +employee.Description, "Thông tin chi tiết");
                }
            }
        }
    }
}

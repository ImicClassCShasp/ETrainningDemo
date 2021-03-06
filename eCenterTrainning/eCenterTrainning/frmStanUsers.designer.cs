﻿namespace eCenterTrainning
{
    partial class frmStanUsers
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupControlStanUser = new DevExpress.XtraEditors.GroupControl();
            this.linkLabelChangePassword = new System.Windows.Forms.LinkLabel();
            this.btnAddMoreDepartment = new DevExpress.XtraEditors.SimpleButton();
            this.btnAddMoreEmployee = new DevExpress.XtraEditors.SimpleButton();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.cboUserType = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cboSex = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtPasswordAfter = new DevExpress.XtraEditors.TextEdit();
            this.txtPassword = new DevExpress.XtraEditors.TextEdit();
            this.txtEmail = new DevExpress.XtraEditors.TextEdit();
            this.txtUserName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.txtMobile = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.txtHoTen = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.lookUpEditDepartment = new DevExpress.XtraEditors.LookUpEdit();
            this.lookUpEditEmployee = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.actionUpdateStanUser = new eCenterTrainning.Base.ActionUpdate();
            ((System.ComponentModel.ISupportInitialize)(this.msgMessage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlStanUser)).BeginInit();
            this.groupControlStanUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboUserType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboSex.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPasswordAfter.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMobile.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHoTen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditDepartment.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditEmployee.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControlStanUser
            // 
            this.groupControlStanUser.Controls.Add(this.linkLabelChangePassword);
            this.groupControlStanUser.Controls.Add(this.btnAddMoreDepartment);
            this.groupControlStanUser.Controls.Add(this.btnAddMoreEmployee);
            this.groupControlStanUser.Controls.Add(this.txtAddress);
            this.groupControlStanUser.Controls.Add(this.cboUserType);
            this.groupControlStanUser.Controls.Add(this.cboSex);
            this.groupControlStanUser.Controls.Add(this.txtPasswordAfter);
            this.groupControlStanUser.Controls.Add(this.txtPassword);
            this.groupControlStanUser.Controls.Add(this.txtEmail);
            this.groupControlStanUser.Controls.Add(this.txtUserName);
            this.groupControlStanUser.Controls.Add(this.labelControl11);
            this.groupControlStanUser.Controls.Add(this.txtMobile);
            this.groupControlStanUser.Controls.Add(this.labelControl8);
            this.groupControlStanUser.Controls.Add(this.txtHoTen);
            this.groupControlStanUser.Controls.Add(this.labelControl7);
            this.groupControlStanUser.Controls.Add(this.labelControl6);
            this.groupControlStanUser.Controls.Add(this.labelControl5);
            this.groupControlStanUser.Controls.Add(this.labelControl10);
            this.groupControlStanUser.Controls.Add(this.labelControl9);
            this.groupControlStanUser.Controls.Add(this.labelControl4);
            this.groupControlStanUser.Controls.Add(this.labelControl3);
            this.groupControlStanUser.Controls.Add(this.labelControl2);
            this.groupControlStanUser.Controls.Add(this.lookUpEditDepartment);
            this.groupControlStanUser.Controls.Add(this.lookUpEditEmployee);
            this.groupControlStanUser.Controls.Add(this.labelControl1);
            this.groupControlStanUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControlStanUser.Location = new System.Drawing.Point(0, 62);
            this.groupControlStanUser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupControlStanUser.Name = "groupControlStanUser";
            this.groupControlStanUser.Size = new System.Drawing.Size(701, 392);
            this.groupControlStanUser.TabIndex = 1;
            this.groupControlStanUser.Text = "Thông Tin Người Dùng";
            // 
            // linkLabelChangePassword
            // 
            this.linkLabelChangePassword.AutoSize = true;
            this.linkLabelChangePassword.Location = new System.Drawing.Point(531, 366);
            this.linkLabelChangePassword.Name = "linkLabelChangePassword";
            this.linkLabelChangePassword.Size = new System.Drawing.Size(165, 17);
            this.linkLabelChangePassword.TabIndex = 14;
            this.linkLabelChangePassword.TabStop = true;
            this.linkLabelChangePassword.Text = "Đổi mật khẩu người dùng";
            this.linkLabelChangePassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelChangePassword_LinkClicked);
            // 
            // btnAddMoreDepartment
            // 
            this.btnAddMoreDepartment.ImageOptions.Image = global::eCenterTrainning.Properties.Resources._103;
            this.btnAddMoreDepartment.Location = new System.Drawing.Point(663, 44);
            this.btnAddMoreDepartment.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddMoreDepartment.Name = "btnAddMoreDepartment";
            this.btnAddMoreDepartment.Size = new System.Drawing.Size(27, 25);
            this.btnAddMoreDepartment.TabIndex = 4;
            this.btnAddMoreDepartment.Click += new System.EventHandler(this.btnAddMoreDepartment_Click);
            // 
            // btnAddMoreEmployee
            // 
            this.btnAddMoreEmployee.ImageOptions.Image = global::eCenterTrainning.Properties.Resources._103;
            this.btnAddMoreEmployee.Location = new System.Drawing.Point(331, 44);
            this.btnAddMoreEmployee.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddMoreEmployee.Name = "btnAddMoreEmployee";
            this.btnAddMoreEmployee.Size = new System.Drawing.Size(27, 25);
            this.btnAddMoreEmployee.TabIndex = 2;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(119, 273);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAddress.MaxLength = 500;
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(559, 73);
            this.txtAddress.TabIndex = 13;
            // 
            // cboUserType
            // 
            this.cboUserType.AllowDrop = true;
            this.cboUserType.Location = new System.Drawing.Point(498, 183);
            this.cboUserType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboUserType.Name = "cboUserType";
            this.cboUserType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboUserType.Properties.Items.AddRange(new object[] {
            "Admin",
            "User"});
            this.cboUserType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboUserType.Size = new System.Drawing.Size(187, 22);
            this.cboUserType.TabIndex = 10;
            // 
            // cboSex
            // 
            this.cboSex.Location = new System.Drawing.Point(498, 95);
            this.cboSex.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboSex.Name = "cboSex";
            this.cboSex.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboSex.Properties.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cboSex.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboSex.Size = new System.Drawing.Size(117, 22);
            this.cboSex.TabIndex = 6;
            // 
            // txtPasswordAfter
            // 
            this.txtPasswordAfter.Location = new System.Drawing.Point(498, 228);
            this.txtPasswordAfter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPasswordAfter.Name = "txtPasswordAfter";
            this.txtPasswordAfter.Properties.MaxLength = 150;
            this.txtPasswordAfter.Properties.UseSystemPasswordChar = true;
            this.txtPasswordAfter.Size = new System.Drawing.Size(187, 22);
            this.txtPasswordAfter.TabIndex = 12;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(119, 228);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Properties.MaxLength = 150;
            this.txtPassword.Properties.UseSystemPasswordChar = true;
            this.txtPassword.Size = new System.Drawing.Size(204, 22);
            this.txtPassword.TabIndex = 11;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(498, 139);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Properties.MaxLength = 50;
            this.txtEmail.Size = new System.Drawing.Size(187, 22);
            this.txtEmail.TabIndex = 8;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(119, 183);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Properties.MaxLength = 50;
            this.txtUserName.Size = new System.Drawing.Size(204, 22);
            this.txtUserName.TabIndex = 9;
            // 
            // labelControl11
            // 
            this.labelControl11.Location = new System.Drawing.Point(372, 233);
            this.labelControl11.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(134, 17);
            this.labelControl11.TabIndex = 3;
            this.labelControl11.Text = "Mật Khẩu nhập lại (*):";
            // 
            // txtMobile
            // 
            this.txtMobile.Location = new System.Drawing.Point(119, 139);
            this.txtMobile.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Properties.MaxLength = 20;
            this.txtMobile.Size = new System.Drawing.Size(204, 22);
            this.txtMobile.TabIndex = 7;
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(21, 233);
            this.labelControl8.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(88, 17);
            this.labelControl8.TabIndex = 3;
            this.labelControl8.Text = "Mật Khẩu (*) :";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(119, 95);
            this.txtHoTen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Properties.MaxLength = 50;
            this.txtHoTen.Size = new System.Drawing.Size(204, 22);
            this.txtHoTen.TabIndex = 5;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(21, 187);
            this.labelControl7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(91, 17);
            this.labelControl7.TabIndex = 3;
            this.labelControl7.Text = "Tài Khoản (*) :";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(372, 143);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(66, 16);
            this.labelControl6.TabIndex = 3;
            this.labelControl6.Text = "Email (*)  :";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(21, 143);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(63, 17);
            this.labelControl5.TabIndex = 3;
            this.labelControl5.Text = "Di Động  :";
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(21, 273);
            this.labelControl10.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(55, 17);
            this.labelControl10.TabIndex = 3;
            this.labelControl10.Text = "Địa Chỉ  :";
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(372, 188);
            this.labelControl9.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(119, 17);
            this.labelControl9.TabIndex = 3;
            this.labelControl9.Text = "Loại Tài Khoản (*) :";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(372, 98);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(64, 17);
            this.labelControl4.TabIndex = 3;
            this.labelControl4.Text = "Giới Tính  :";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(21, 98);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(106, 17);
            this.labelControl3.TabIndex = 3;
            this.labelControl3.Text = "Tên Hiển Thị (*) :";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(372, 49);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(73, 16);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Phòng Ban : ";
            // 
            // lookUpEditDepartment
            // 
            this.lookUpEditDepartment.Location = new System.Drawing.Point(498, 44);
            this.lookUpEditDepartment.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lookUpEditDepartment.Name = "lookUpEditDepartment";
            this.lookUpEditDepartment.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditDepartment.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Id", "Id", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("OuName", "Tên Phòng Ban")});
            this.lookUpEditDepartment.Properties.NullText = "--- Chọn Phòng Ban ---";
            this.lookUpEditDepartment.Size = new System.Drawing.Size(153, 22);
            this.lookUpEditDepartment.TabIndex = 3;
            // 
            // lookUpEditEmployee
            // 
            this.lookUpEditEmployee.Enabled = false;
            this.lookUpEditEmployee.Location = new System.Drawing.Point(119, 44);
            this.lookUpEditEmployee.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lookUpEditEmployee.Name = "lookUpEditEmployee";
            this.lookUpEditEmployee.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditEmployee.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Id", "Id", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("EmployeeName", "Tên Nhân Viên")});
            this.lookUpEditEmployee.Properties.NullText = "--- Chọn Nhân Viên ---";
            this.lookUpEditEmployee.Size = new System.Drawing.Size(204, 22);
            this.lookUpEditEmployee.TabIndex = 1;
            this.lookUpEditEmployee.EditValueChanged += new System.EventHandler(this.lookUpEditEmployee_EditValueChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(21, 49);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(71, 16);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Nhân Viên : ";
            // 
            // actionUpdateStanUser
            // 
            this.actionUpdateStanUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.actionUpdateStanUser.Location = new System.Drawing.Point(0, 0);
            this.actionUpdateStanUser.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.actionUpdateStanUser.Name = "actionUpdateStanUser";
            this.actionUpdateStanUser.Size = new System.Drawing.Size(701, 62);
            this.actionUpdateStanUser.TabIndex = 0;
            // 
            // frmStanUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 454);
            this.Controls.Add(this.groupControlStanUser);
            this.Controls.Add(this.actionUpdateStanUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "frmStanUsers";
            this.Text = "frmStanUsers";
            this.Load += new System.EventHandler(this.frmStanUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.msgMessage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlStanUser)).EndInit();
            this.groupControlStanUser.ResumeLayout(false);
            this.groupControlStanUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboUserType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboSex.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPasswordAfter.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMobile.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHoTen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditDepartment.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditEmployee.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Base.ActionUpdate actionUpdateStanUser;
        private DevExpress.XtraEditors.GroupControl groupControlStanUser;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditEmployee;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditDepartment;
        private DevExpress.XtraEditors.TextEdit txtHoTen;
        private DevExpress.XtraEditors.ComboBoxEdit cboSex;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtEmail;
        private DevExpress.XtraEditors.TextEdit txtMobile;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtPassword;
        private DevExpress.XtraEditors.TextEdit txtUserName;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.ComboBoxEdit cboUserType;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private System.Windows.Forms.TextBox txtAddress;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.SimpleButton btnAddMoreDepartment;
        private DevExpress.XtraEditors.SimpleButton btnAddMoreEmployee;
        private DevExpress.XtraEditors.TextEdit txtPasswordAfter;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private System.Windows.Forms.LinkLabel linkLabelChangePassword;
    }
}
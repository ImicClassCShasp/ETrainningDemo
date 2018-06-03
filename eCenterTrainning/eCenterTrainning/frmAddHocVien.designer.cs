namespace eCenterTrainning
{
    partial class frmAddHocVien
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
            this.groupControlHocVien = new DevExpress.XtraEditors.GroupControl();
            this.lookUpEditClass = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.lookUpEditStatus = new DevExpress.XtraEditors.LookUpEdit();
            this.lookUpEditCourse = new DevExpress.XtraEditors.LookUpEdit();
            this.lookUpEditUuDai = new DevExpress.XtraEditors.LookUpEdit();
            this.cmbSex = new DevExpress.XtraEditors.ComboBoxEdit();
            this.dateEditBirth = new DevExpress.XtraEditors.DateEdit();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtEmail = new DevExpress.XtraEditors.TextEdit();
            this.txtDiaChi = new DevExpress.XtraEditors.TextEdit();
            this.txtDiDong = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtHoTen = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.lblHoTen = new DevExpress.XtraEditors.LabelControl();
            this.ActionUpdateHocVien = new eCenterTrainning.UseControls.ActionUpdateHocVien();
            ((System.ComponentModel.ISupportInitialize)(this.msgMessage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlHocVien)).BeginInit();
            this.groupControlHocVien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditClass.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditCourse.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditUuDai.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSex.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditBirth.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditBirth.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaChi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiDong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHoTen.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControlHocVien
            // 
            this.groupControlHocVien.Controls.Add(this.lookUpEditClass);
            this.groupControlHocVien.Controls.Add(this.labelControl5);
            this.groupControlHocVien.Controls.Add(this.lookUpEditStatus);
            this.groupControlHocVien.Controls.Add(this.lookUpEditCourse);
            this.groupControlHocVien.Controls.Add(this.lookUpEditUuDai);
            this.groupControlHocVien.Controls.Add(this.cmbSex);
            this.groupControlHocVien.Controls.Add(this.dateEditBirth);
            this.groupControlHocVien.Controls.Add(this.txtDescription);
            this.groupControlHocVien.Controls.Add(this.txtEmail);
            this.groupControlHocVien.Controls.Add(this.txtDiaChi);
            this.groupControlHocVien.Controls.Add(this.txtDiDong);
            this.groupControlHocVien.Controls.Add(this.labelControl1);
            this.groupControlHocVien.Controls.Add(this.labelControl10);
            this.groupControlHocVien.Controls.Add(this.labelControl9);
            this.groupControlHocVien.Controls.Add(this.labelControl7);
            this.groupControlHocVien.Controls.Add(this.txtHoTen);
            this.groupControlHocVien.Controls.Add(this.labelControl8);
            this.groupControlHocVien.Controls.Add(this.labelControl6);
            this.groupControlHocVien.Controls.Add(this.labelControl2);
            this.groupControlHocVien.Controls.Add(this.labelControl3);
            this.groupControlHocVien.Controls.Add(this.labelControl4);
            this.groupControlHocVien.Controls.Add(this.lblHoTen);
            this.groupControlHocVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControlHocVien.Location = new System.Drawing.Point(0, 52);
            this.groupControlHocVien.Name = "groupControlHocVien";
            this.groupControlHocVien.Size = new System.Drawing.Size(608, 282);
            this.groupControlHocVien.TabIndex = 15;
            this.groupControlHocVien.Text = "Thêm thông tin học viên";
            // 
            // lookUpEditClass
            // 
            this.lookUpEditClass.Location = new System.Drawing.Point(394, 129);
            this.lookUpEditClass.Name = "lookUpEditClass";
            this.lookUpEditClass.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditClass.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Id", "Id", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ClassName", "Lớp học")});
            this.lookUpEditClass.Properties.NullText = "---Chọn lớp học---";
            this.lookUpEditClass.Properties.ReadOnly = true;
            this.lookUpEditClass.Size = new System.Drawing.Size(196, 20);
            this.lookUpEditClass.TabIndex = 11;
            this.lookUpEditClass.TextChanged += new System.EventHandler(this.lookUpEditClass_TextChanged);
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(321, 136);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(44, 13);
            this.labelControl5.TabIndex = 10;
            this.labelControl5.Text = "Lớp học :";
            // 
            // lookUpEditStatus
            // 
            this.lookUpEditStatus.Location = new System.Drawing.Point(394, 96);
            this.lookUpEditStatus.Name = "lookUpEditStatus";
            this.lookUpEditStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditStatus.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Id", "Id", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("StatusName", "Trạng thái")});
            this.lookUpEditStatus.Properties.NullText = "---Chọn trạng thái---";
            this.lookUpEditStatus.Size = new System.Drawing.Size(196, 20);
            this.lookUpEditStatus.TabIndex = 6;
            this.lookUpEditStatus.EditValueChanged += new System.EventHandler(this.lookUpEditStatus_EditValueChanged);
            // 
            // lookUpEditCourse
            // 
            this.lookUpEditCourse.Location = new System.Drawing.Point(85, 161);
            this.lookUpEditCourse.Name = "lookUpEditCourse";
            this.lookUpEditCourse.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditCourse.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Id", "Id", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CourseName", "Khóa học")});
            this.lookUpEditCourse.Properties.NullText = "---Chọn khóa học---";
            this.lookUpEditCourse.Size = new System.Drawing.Size(200, 20);
            this.lookUpEditCourse.TabIndex = 8;
            this.lookUpEditCourse.EditValueChanged += new System.EventHandler(this.lookUpEditCourse_EditValueChanged);
            // 
            // lookUpEditUuDai
            // 
            this.lookUpEditUuDai.Location = new System.Drawing.Point(394, 161);
            this.lookUpEditUuDai.Name = "lookUpEditUuDai";
            this.lookUpEditUuDai.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditUuDai.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Id", "Id", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("PolicyName", "Chương trình ưu đãi")});
            this.lookUpEditUuDai.Properties.NullText = "---Chọn chương trình ưu đãi---";
            this.lookUpEditUuDai.Properties.ReadOnly = true;
            this.lookUpEditUuDai.Size = new System.Drawing.Size(196, 20);
            this.lookUpEditUuDai.TabIndex = 8;
            // 
            // cmbSex
            // 
            this.cmbSex.Location = new System.Drawing.Point(394, 32);
            this.cmbSex.Name = "cmbSex";
            this.cmbSex.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbSex.Properties.Items.AddRange(new object[] {
            "Nam ",
            "Nữ"});
            this.cmbSex.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cmbSex.Size = new System.Drawing.Size(117, 20);
            this.cmbSex.TabIndex = 2;
            // 
            // dateEditBirth
            // 
            this.dateEditBirth.EditValue = null;
            this.dateEditBirth.Location = new System.Drawing.Point(85, 64);
            this.dateEditBirth.Name = "dateEditBirth";
            this.dateEditBirth.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditBirth.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dateEditBirth.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.dateEditBirth.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dateEditBirth.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.dateEditBirth.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dateEditBirth.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dateEditBirth.Size = new System.Drawing.Size(200, 20);
            this.dateEditBirth.TabIndex = 3;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(85, 200);
            this.txtDescription.MaxLength = 2000;
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(505, 69);
            this.txtDescription.TabIndex = 9;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(85, 96);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Properties.MaxLength = 50;
            this.txtEmail.Size = new System.Drawing.Size(200, 20);
            this.txtEmail.TabIndex = 5;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(394, 64);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Properties.MaxLength = 500;
            this.txtDiaChi.Size = new System.Drawing.Size(196, 20);
            this.txtDiaChi.TabIndex = 4;
            // 
            // txtDiDong
            // 
            this.txtDiDong.Location = new System.Drawing.Point(85, 129);
            this.txtDiDong.Name = "txtDiDong";
            this.txtDiDong.Properties.MaxLength = 50;
            this.txtDiDong.Size = new System.Drawing.Size(200, 20);
            this.txtDiDong.TabIndex = 7;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(321, 103);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(70, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Trạng thái (*):";
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(321, 168);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(38, 13);
            this.labelControl10.TabIndex = 0;
            this.labelControl10.Text = "Ưu đãi :";
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(11, 168);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(68, 13);
            this.labelControl9.TabIndex = 0;
            this.labelControl9.Text = "Khóa học (*) :";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(12, 103);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(31, 13);
            this.labelControl7.TabIndex = 0;
            this.labelControl7.Text = "Email :";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(85, 32);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Properties.MaxLength = 50;
            this.txtHoTen.Size = new System.Drawing.Size(200, 20);
            this.txtHoTen.TabIndex = 1;
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(12, 202);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(34, 13);
            this.labelControl8.TabIndex = 0;
            this.labelControl8.Text = "Mô tả :";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(321, 71);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(39, 13);
            this.labelControl6.TabIndex = 0;
            this.labelControl6.Text = "Địa chỉ :";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(322, 37);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(59, 13);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Giới tính (*):";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(12, 67);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(71, 13);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "Ngày sinh (*) :";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(12, 136);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(43, 13);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "Di động :";
            // 
            // lblHoTen
            // 
            this.lblHoTen.Location = new System.Drawing.Point(12, 37);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(56, 13);
            this.lblHoTen.TabIndex = 0;
            this.lblHoTen.Text = "Họ tên (*) :";
            // 
            // ActionUpdateHocVien
            // 
            this.ActionUpdateHocVien.Dock = System.Windows.Forms.DockStyle.Top;
            this.ActionUpdateHocVien.Location = new System.Drawing.Point(0, 0);
            this.ActionUpdateHocVien.Name = "ActionUpdateHocVien";
            this.ActionUpdateHocVien.Size = new System.Drawing.Size(608, 52);
            this.ActionUpdateHocVien.TabIndex = 0;
            // 
            // frmAddHocVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 334);
            this.Controls.Add(this.groupControlHocVien);
            this.Controls.Add(this.ActionUpdateHocVien);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmAddHocVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm Thông Tin Học Viên";
            this.Load += new System.EventHandler(this.frmAddHocVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.msgMessage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlHocVien)).EndInit();
            this.groupControlHocVien.ResumeLayout(false);
            this.groupControlHocVien.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditClass.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditCourse.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditUuDai.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSex.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditBirth.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditBirth.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaChi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiDong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHoTen.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private UseControls.ActionUpdateHocVien ActionUpdateHocVien;
        private DevExpress.XtraEditors.GroupControl groupControlHocVien;
        private DevExpress.XtraEditors.ComboBoxEdit cmbSex;
        private DevExpress.XtraEditors.DateEdit dateEditBirth;
        private System.Windows.Forms.TextBox txtDescription;
        private DevExpress.XtraEditors.TextEdit txtEmail;
        private DevExpress.XtraEditors.TextEdit txtDiaChi;
        private DevExpress.XtraEditors.TextEdit txtDiDong;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit txtHoTen;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl lblHoTen;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditStatus;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditCourse;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditUuDai;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditClass;
        private DevExpress.XtraEditors.LabelControl labelControl5;





    }
}
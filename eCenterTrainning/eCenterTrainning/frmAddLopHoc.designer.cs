namespace eCenterTrainning
{
    partial class frmAddLopHoc
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.cboVPDT = new System.Windows.Forms.ComboBox();
            this.textEdit2 = new DevExpress.XtraEditors.TextEdit();
            this.textEditPrice = new DevExpress.XtraEditors.TextEdit();
            this.lookUpEdit1 = new DevExpress.XtraEditors.LookUpEdit();
            this.lookUpEditKhoaHoc = new DevExpress.XtraEditors.LookUpEdit();
            this.txtMoTa = new System.Windows.Forms.TextBox();
            this.dateEditFinish = new DevExpress.XtraEditors.DateEdit();
            this.dateEditStart = new DevExpress.XtraEditors.DateEdit();
            this.txtSoLuongHv = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtSoLuongHocVien = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtClassName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.actionUpdateLopHoc = new eCenterTrainning.UseControls.ActionUpdateHocVien();
            ((System.ComponentModel.ISupportInitialize)(this.msgMessage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditKhoaHoc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditFinish.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditFinish.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditStart.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditStart.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoLuongHv.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoLuongHocVien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtClassName.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.cboStatus);
            this.groupControl1.Controls.Add(this.cboVPDT);
            this.groupControl1.Controls.Add(this.textEdit2);
            this.groupControl1.Controls.Add(this.textEditPrice);
            this.groupControl1.Controls.Add(this.lookUpEdit1);
            this.groupControl1.Controls.Add(this.lookUpEditKhoaHoc);
            this.groupControl1.Controls.Add(this.txtMoTa);
            this.groupControl1.Controls.Add(this.dateEditFinish);
            this.groupControl1.Controls.Add(this.dateEditStart);
            this.groupControl1.Controls.Add(this.txtSoLuongHv);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.txtSoLuongHocVien);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.txtClassName);
            this.groupControl1.Controls.Add(this.labelControl9);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 47);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(596, 240);
            this.groupControl1.TabIndex = 1;
            // 
            // cboStatus
            // 
            this.cboStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboStatus.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStatus.ForeColor = System.Drawing.Color.White;
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Items.AddRange(new object[] {
            "- Đang triển khai Chương trình Đào tạo",
            "- Đã hoàn thành Chương trình Đào Tạo",
            "- Đã dừng triển khai"});
            this.cboStatus.Location = new System.Drawing.Point(90, 129);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(280, 24);
            this.cboStatus.TabIndex = 10;
            // 
            // cboVPDT
            // 
            this.cboVPDT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cboVPDT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboVPDT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboVPDT.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboVPDT.ForeColor = System.Drawing.Color.White;
            this.cboVPDT.FormattingEnabled = true;
            this.cboVPDT.Items.AddRange(new object[] {
            "IMIC Hà Nội",
            "IMIC Hồ Chí Minh"});
            this.cboVPDT.Location = new System.Drawing.Point(90, 62);
            this.cboVPDT.Name = "cboVPDT";
            this.cboVPDT.Size = new System.Drawing.Size(152, 24);
            this.cboVPDT.TabIndex = 10;
            // 
            // textEdit2
            // 
            this.textEdit2.EditValue = "0";
            this.textEdit2.Location = new System.Drawing.Point(459, 97);
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEdit2.Properties.Appearance.Options.UseFont = true;
            this.textEdit2.Size = new System.Drawing.Size(122, 22);
            this.textEdit2.TabIndex = 9;
            // 
            // textEditPrice
            // 
            this.textEditPrice.Location = new System.Drawing.Point(459, 97);
            this.textEditPrice.Name = "textEditPrice";
            this.textEditPrice.Size = new System.Drawing.Size(122, 20);
            this.textEditPrice.TabIndex = 9;
            // 
            // lookUpEdit1
            // 
            this.lookUpEdit1.Location = new System.Drawing.Point(90, 97);
            this.lookUpEdit1.Name = "lookUpEdit1";
            this.lookUpEdit1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lookUpEdit1.Properties.Appearance.Options.UseFont = true;
            this.lookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit1.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Id", "Id", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CourseName", "Khóa học")});
            this.lookUpEdit1.Properties.NullText = "---Chọn khóa học---";
            this.lookUpEdit1.Size = new System.Drawing.Size(152, 22);
            this.lookUpEdit1.TabIndex = 5;
            //this.lookUpEdit1.TextChanged += new System.EventHandler(this.lookUpEditKhoaHoc_TextChanged);
            // 
            // lookUpEditKhoaHoc
            // 
            this.lookUpEditKhoaHoc.Location = new System.Drawing.Point(90, 97);
            this.lookUpEditKhoaHoc.Name = "lookUpEditKhoaHoc";
            this.lookUpEditKhoaHoc.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditKhoaHoc.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Id", "Id", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CourseName", "Khóa học")});
            this.lookUpEditKhoaHoc.Properties.NullText = "---Chọn khóa học---";
            this.lookUpEditKhoaHoc.Size = new System.Drawing.Size(152, 20);
            this.lookUpEditKhoaHoc.TabIndex = 5;
            //this.lookUpEditKhoaHoc.TextChanged += new System.EventHandler(this.lookUpEditKhoaHoc_TextChanged);
            // 
            // txtMoTa
            // 
            this.txtMoTa.Location = new System.Drawing.Point(90, 162);
            this.txtMoTa.MaxLength = 1000;
            this.txtMoTa.Multiline = true;
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.Size = new System.Drawing.Size(491, 68);
            this.txtMoTa.TabIndex = 7;
            // 
            // dateEditFinish
            // 
            this.dateEditFinish.EditValue = new System.DateTime(2018, 5, 1, 16, 36, 41, 414);
            this.dateEditFinish.Location = new System.Drawing.Point(343, 64);
            this.dateEditFinish.Name = "dateEditFinish";
            this.dateEditFinish.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateEditFinish.Properties.Appearance.Options.UseFont = true;
            this.dateEditFinish.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditFinish.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dateEditFinish.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.dateEditFinish.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dateEditFinish.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.dateEditFinish.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dateEditFinish.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dateEditFinish.Size = new System.Drawing.Size(238, 22);
            this.dateEditFinish.TabIndex = 4;
            // 
            // dateEditStart
            // 
            this.dateEditStart.EditValue = new System.DateTime(2018, 5, 1, 16, 36, 30, 917);
            this.dateEditStart.Location = new System.Drawing.Point(343, 29);
            this.dateEditStart.Name = "dateEditStart";
            this.dateEditStart.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateEditStart.Properties.Appearance.Options.UseFont = true;
            this.dateEditStart.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditStart.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dateEditStart.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.dateEditStart.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dateEditStart.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.dateEditStart.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dateEditStart.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dateEditStart.Size = new System.Drawing.Size(238, 22);
            this.dateEditStart.TabIndex = 2;
            // 
            // txtSoLuongHv
            // 
            this.txtSoLuongHv.EditValue = "0";
            this.txtSoLuongHv.Location = new System.Drawing.Point(343, 97);
            this.txtSoLuongHv.Name = "txtSoLuongHv";
            this.txtSoLuongHv.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoLuongHv.Properties.Appearance.Options.UseFont = true;
            this.txtSoLuongHv.Size = new System.Drawing.Size(39, 22);
            this.txtSoLuongHv.TabIndex = 6;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(271, 71);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(47, 13);
            this.labelControl3.TabIndex = 3;
            this.labelControl3.Text = "Kết thúc :";
            // 
            // txtSoLuongHocVien
            // 
            this.txtSoLuongHocVien.Location = new System.Drawing.Point(343, 97);
            this.txtSoLuongHocVien.Name = "txtSoLuongHocVien";
            this.txtSoLuongHocVien.Size = new System.Drawing.Size(39, 20);
            this.txtSoLuongHocVien.TabIndex = 6;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(397, 100);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(56, 13);
            this.labelControl4.TabIndex = 3;
            this.labelControl4.Text = "Học phí (*):";
            // 
            // txtClassName
            // 
            this.txtClassName.Location = new System.Drawing.Point(90, 29);
            this.txtClassName.Name = "txtClassName";
            this.txtClassName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClassName.Properties.Appearance.Options.UseFont = true;
            this.txtClassName.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.txtClassName.Properties.MaxLength = 250;
            this.txtClassName.Size = new System.Drawing.Size(152, 24);
            this.txtClassName.TabIndex = 1;
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(12, 134);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(53, 13);
            this.labelControl9.TabIndex = 3;
            this.labelControl9.Text = "Trạng thái:";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(274, 100);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(63, 13);
            this.labelControl6.TabIndex = 3;
            this.labelControl6.Text = "Số lượng (*):";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(12, 162);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(34, 13);
            this.labelControl7.TabIndex = 3;
            this.labelControl7.Text = "Mô tả :";
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(12, 100);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(65, 13);
            this.labelControl8.TabIndex = 3;
            this.labelControl8.Text = "Khóa học (*):";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(12, 71);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(42, 13);
            this.labelControl5.TabIndex = 3;
            this.labelControl5.Text = "Nơi học :";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(271, 36);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(56, 13);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Khai giảng :";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 36);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(56, 13);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Tên lớp (*):";
            // 
            // actionUpdateLopHoc
            // 
            this.actionUpdateLopHoc.Dock = System.Windows.Forms.DockStyle.Top;
            this.actionUpdateLopHoc.Location = new System.Drawing.Point(0, 0);
            this.actionUpdateLopHoc.Name = "actionUpdateLopHoc";
            this.actionUpdateLopHoc.Size = new System.Drawing.Size(596, 47);
            this.actionUpdateLopHoc.TabIndex = 0;
            // 
            // frmAddLopHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 287);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.actionUpdateLopHoc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmAddLopHoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAddLopHoc";
            this.Load += new System.EventHandler(this.frmAddLopHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.msgMessage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditKhoaHoc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditFinish.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditFinish.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditStart.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditStart.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoLuongHv.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoLuongHocVien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtClassName.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private UseControls.ActionUpdateHocVien actionUpdateLopHoc;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.TextBox txtMoTa;
        private DevExpress.XtraEditors.DateEdit dateEditFinish;
        private DevExpress.XtraEditors.DateEdit dateEditStart;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtSoLuongHocVien;
        private DevExpress.XtraEditors.TextEdit txtClassName;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditKhoaHoc;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit textEditPrice;
        private System.Windows.Forms.ComboBox cboVPDT;
        private DevExpress.XtraEditors.TextEdit textEdit2;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit1;
        private DevExpress.XtraEditors.TextEdit txtSoLuongHv;
        private System.Windows.Forms.ComboBox cboStatus;
        private DevExpress.XtraEditors.LabelControl labelControl9;
    }
}
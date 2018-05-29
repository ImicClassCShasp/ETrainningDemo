namespace eCenterTrainning
{
    partial class frmHocVienHeThong
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
            this.gridControlHVHeThong = new DevExpress.XtraGrid.GridControl();
            this.gridViewHVHeThong = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ColId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColHoTen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColDateBirthday = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColSex = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColMobile = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.lookUpEditPolicy = new DevExpress.XtraEditors.LookUpEdit();
            this.txtMobile = new DevExpress.XtraEditors.TextEdit();
            this.txtSex = new DevExpress.XtraEditors.TextEdit();
            this.txtName = new DevExpress.XtraEditors.TextEdit();
            this.txtEmail = new DevExpress.XtraEditors.TextEdit();
            this.lookUpEditLopHoc = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnAddHV = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlHVHeThong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewHVHeThong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditPolicy.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMobile.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSex.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditLopHoc.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.gridControlHVHeThong);
            this.groupControl1.Controls.Add(this.panelControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(673, 394);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Danh sách học viên hệ thống";
            // 
            // gridControlHVHeThong
            // 
            this.gridControlHVHeThong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlHVHeThong.Location = new System.Drawing.Point(2, 115);
            this.gridControlHVHeThong.MainView = this.gridViewHVHeThong;
            this.gridControlHVHeThong.Name = "gridControlHVHeThong";
            this.gridControlHVHeThong.Size = new System.Drawing.Size(669, 277);
            this.gridControlHVHeThong.TabIndex = 2;
            this.gridControlHVHeThong.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewHVHeThong});
            this.gridControlHVHeThong.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gridControlHVHeThong_MouseClick);
            // 
            // gridViewHVHeThong
            // 
            this.gridViewHVHeThong.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ColId,
            this.ColHoTen,
            this.ColDateBirthday,
            this.ColSex,
            this.ColAddress,
            this.ColEmail,
            this.ColMobile});
            this.gridViewHVHeThong.GridControl = this.gridControlHVHeThong;
            this.gridViewHVHeThong.Name = "gridViewHVHeThong";
            this.gridViewHVHeThong.OptionsBehavior.Editable = false;
            this.gridViewHVHeThong.OptionsView.ShowAutoFilterRow = true;
            this.gridViewHVHeThong.OptionsView.ShowFooter = true;
            this.gridViewHVHeThong.OptionsView.ShowGroupPanel = false;
            // 
            // ColId
            // 
            this.ColId.Caption = "Id";
            this.ColId.FieldName = "Id";
            this.ColId.Name = "ColId";
            // 
            // ColHoTen
            // 
            this.ColHoTen.Caption = "Họ tên";
            this.ColHoTen.FieldName = "FullName";
            this.ColHoTen.MinWidth = 100;
            this.ColHoTen.Name = "ColHoTen";
            this.ColHoTen.Visible = true;
            this.ColHoTen.VisibleIndex = 0;
            this.ColHoTen.Width = 120;
            // 
            // ColDateBirthday
            // 
            this.ColDateBirthday.Caption = "Ngày sinh";
            this.ColDateBirthday.FieldName = "DateBirthday";
            this.ColDateBirthday.Name = "ColDateBirthday";
            this.ColDateBirthday.Visible = true;
            this.ColDateBirthday.VisibleIndex = 1;
            this.ColDateBirthday.Width = 105;
            // 
            // ColSex
            // 
            this.ColSex.Caption = "Giới tính";
            this.ColSex.FieldName = "Sex";
            this.ColSex.Name = "ColSex";
            this.ColSex.Visible = true;
            this.ColSex.VisibleIndex = 2;
            this.ColSex.Width = 105;
            // 
            // ColAddress
            // 
            this.ColAddress.Caption = "Địa chỉ";
            this.ColAddress.FieldName = "Address";
            this.ColAddress.Name = "ColAddress";
            this.ColAddress.Visible = true;
            this.ColAddress.VisibleIndex = 3;
            this.ColAddress.Width = 105;
            // 
            // ColEmail
            // 
            this.ColEmail.Caption = "Email";
            this.ColEmail.FieldName = "Email";
            this.ColEmail.Name = "ColEmail";
            this.ColEmail.Visible = true;
            this.ColEmail.VisibleIndex = 4;
            this.ColEmail.Width = 105;
            // 
            // ColMobile
            // 
            this.ColMobile.Caption = "Di động";
            this.ColMobile.FieldName = "Mobile";
            this.ColMobile.Name = "ColMobile";
            this.ColMobile.Visible = true;
            this.ColMobile.VisibleIndex = 5;
            this.ColMobile.Width = 113;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.lookUpEditPolicy);
            this.panelControl1.Controls.Add(this.txtMobile);
            this.panelControl1.Controls.Add(this.txtSex);
            this.panelControl1.Controls.Add(this.txtName);
            this.panelControl1.Controls.Add(this.txtEmail);
            this.panelControl1.Controls.Add(this.lookUpEditLopHoc);
            this.panelControl1.Controls.Add(this.labelControl5);
            this.panelControl1.Controls.Add(this.labelControl4);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.labelControl6);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.btnAddHV);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(2, 21);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(669, 94);
            this.panelControl1.TabIndex = 1;
            // 
            // lookUpEditPolicy
            // 
            this.lookUpEditPolicy.Location = new System.Drawing.Point(327, 11);
            this.lookUpEditPolicy.Name = "lookUpEditPolicy";
            this.lookUpEditPolicy.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditPolicy.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Id", "Id", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("PolicyName", "Chương trình ưu đãi")});
            this.lookUpEditPolicy.Properties.NullText = "---Chọn chương trình ưu đãi---";
            this.lookUpEditPolicy.Size = new System.Drawing.Size(187, 20);
            this.lookUpEditPolicy.TabIndex = 5;
            // 
            // txtMobile
            // 
            this.txtMobile.Location = new System.Drawing.Point(340, 68);
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Properties.Appearance.BackColor = System.Drawing.Color.Linen;
            this.txtMobile.Properties.Appearance.Options.UseBackColor = true;
            this.txtMobile.Size = new System.Drawing.Size(164, 20);
            this.txtMobile.TabIndex = 4;
            // 
            // txtSex
            // 
            this.txtSex.Location = new System.Drawing.Point(340, 41);
            this.txtSex.Name = "txtSex";
            this.txtSex.Properties.Appearance.BackColor = System.Drawing.Color.Linen;
            this.txtSex.Properties.Appearance.Options.UseBackColor = true;
            this.txtSex.Size = new System.Drawing.Size(63, 20);
            this.txtSex.TabIndex = 4;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(61, 41);
            this.txtName.Name = "txtName";
            this.txtName.Properties.Appearance.BackColor = System.Drawing.Color.Linen;
            this.txtName.Properties.Appearance.Options.UseBackColor = true;
            this.txtName.Size = new System.Drawing.Size(188, 20);
            this.txtName.TabIndex = 4;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(61, 68);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Properties.Appearance.BackColor = System.Drawing.Color.Linen;
            this.txtEmail.Properties.Appearance.Options.UseBackColor = true;
            this.txtEmail.Size = new System.Drawing.Size(188, 20);
            this.txtEmail.TabIndex = 4;
            // 
            // lookUpEditLopHoc
            // 
            this.lookUpEditLopHoc.Location = new System.Drawing.Point(61, 11);
            this.lookUpEditLopHoc.Name = "lookUpEditLopHoc";
            this.lookUpEditLopHoc.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditLopHoc.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Id", "Id", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ClassName", "Lớp học")});
            this.lookUpEditLopHoc.Properties.NullText = "---Chọn lớp học---";
            this.lookUpEditLopHoc.Size = new System.Drawing.Size(188, 20);
            this.lookUpEditLopHoc.TabIndex = 3;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(11, 75);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(31, 13);
            this.labelControl5.TabIndex = 2;
            this.labelControl5.Text = "Email :";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(283, 75);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(43, 13);
            this.labelControl4.TabIndex = 2;
            this.labelControl4.Text = "Di động :";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(283, 48);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(45, 13);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Giới tính :";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(11, 48);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(39, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Họ tên :";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(283, 18);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(38, 13);
            this.labelControl6.TabIndex = 2;
            this.labelControl6.Text = "Ưu đãi :";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(11, 18);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(44, 13);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Lớp học :";
            // 
            // btnAddHV
            // 
            this.btnAddHV.Image = global::eCenterTrainning.Properties.Resources.add_icon;
            this.btnAddHV.Location = new System.Drawing.Point(520, 8);
            this.btnAddHV.Name = "btnAddHV";
            this.btnAddHV.Size = new System.Drawing.Size(96, 23);
            this.btnAddHV.TabIndex = 0;
            this.btnAddHV.Text = "Thêm học viên";
            this.btnAddHV.Click += new System.EventHandler(this.btnAddHV_Click);
            // 
            // frmHocVienHeThong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 394);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmHocVienHeThong";
            this.Text = "frmHocVienHeThong";
            this.Load += new System.EventHandler(this.frmHocVienHeThong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlHVHeThong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewHVHeThong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditPolicy.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMobile.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSex.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditLopHoc.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditLopHoc;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnAddHV;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraGrid.GridControl gridControlHVHeThong;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewHVHeThong;
        private DevExpress.XtraGrid.Columns.GridColumn ColId;
        private DevExpress.XtraGrid.Columns.GridColumn ColHoTen;
        private DevExpress.XtraGrid.Columns.GridColumn ColDateBirthday;
        private DevExpress.XtraGrid.Columns.GridColumn ColSex;
        private DevExpress.XtraGrid.Columns.GridColumn ColAddress;
        private DevExpress.XtraGrid.Columns.GridColumn ColEmail;
        private DevExpress.XtraGrid.Columns.GridColumn ColMobile;
        private DevExpress.XtraEditors.TextEdit txtMobile;
        private DevExpress.XtraEditors.TextEdit txtSex;
        private DevExpress.XtraEditors.TextEdit txtName;
        private DevExpress.XtraEditors.TextEdit txtEmail;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditPolicy;
        private DevExpress.XtraEditors.LabelControl labelControl6;
    }
}
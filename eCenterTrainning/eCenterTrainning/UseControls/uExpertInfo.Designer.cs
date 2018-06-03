namespace eCenterTrainning.UseControls
{
    partial class uExpertInfo
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uExpertInfo));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.xtraTabControlExpert = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPageExpert = new DevExpress.XtraTab.XtraTabPage();
            this.gridControlGiangVien = new DevExpress.XtraGrid.GridControl();
            this.gridViewGiangVien = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHoTen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgaySinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSex = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYearsExperience = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUniversityDegree = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCenterId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colChiTiet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemImageComboBoxCV = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.actionMenuExpert = new eCenterTrainning.Base.ActionMenu();
            this.xtraTabPageClass = new DevExpress.XtraTab.XtraTabPage();
            this.gridControlClass = new DevExpress.XtraGrid.GridControl();
            this.gridViewClass = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCourse = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColClassName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColKhaiGiang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColKetThuc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColNoiHoc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.lookUpEditExpert = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControlExpert)).BeginInit();
            this.xtraTabControlExpert.SuspendLayout();
            this.xtraTabPageExpert.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlGiangVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewGiangVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBoxCV)).BeginInit();
            this.xtraTabPageClass.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlClass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewClass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditExpert.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "002.png");
            // 
            // xtraTabControlExpert
            // 
            this.xtraTabControlExpert.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControlExpert.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControlExpert.Name = "xtraTabControlExpert";
            this.xtraTabControlExpert.SelectedTabPage = this.xtraTabPageExpert;
            this.xtraTabControlExpert.Size = new System.Drawing.Size(832, 436);
            this.xtraTabControlExpert.TabIndex = 0;
            this.xtraTabControlExpert.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPageExpert,
            this.xtraTabPageClass});
            this.xtraTabControlExpert.Click += new System.EventHandler(this.xtraTabControlExpert_Click);
            // 
            // xtraTabPageExpert
            // 
            this.xtraTabPageExpert.Controls.Add(this.gridControlGiangVien);
            this.xtraTabPageExpert.Controls.Add(this.actionMenuExpert);
            this.xtraTabPageExpert.Name = "xtraTabPageExpert";
            this.xtraTabPageExpert.Size = new System.Drawing.Size(826, 408);
            this.xtraTabPageExpert.Text = "Danh sách giảng viên";
            // 
            // gridControlGiangVien
            // 
            this.gridControlGiangVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlGiangVien.EmbeddedNavigator.TextStringFormat = "Bản ghi {0} of {1}";
            this.gridControlGiangVien.Location = new System.Drawing.Point(0, 50);
            this.gridControlGiangVien.MainView = this.gridViewGiangVien;
            this.gridControlGiangVien.Name = "gridControlGiangVien";
            this.gridControlGiangVien.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemImageComboBoxCV});
            this.gridControlGiangVien.Size = new System.Drawing.Size(826, 358);
            this.gridControlGiangVien.TabIndex = 6;
            this.gridControlGiangVien.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewGiangVien});
            this.gridControlGiangVien.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.gridControlGiangVien_MouseDoubleClick);
            // 
            // gridViewGiangVien
            // 
            this.gridViewGiangVien.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colHoTen,
            this.colNgaySinh,
            this.colSex,
            this.colYearsExperience,
            this.colUniversityDegree,
            this.colCenterId,
            this.colChiTiet});
            this.gridViewGiangVien.GridControl = this.gridControlGiangVien;
            this.gridViewGiangVien.Name = "gridViewGiangVien";
            this.gridViewGiangVien.OptionsBehavior.Editable = false;
            this.gridViewGiangVien.OptionsView.ShowAutoFilterRow = true;
            this.gridViewGiangVien.OptionsView.ShowFooter = true;
            this.gridViewGiangVien.OptionsView.ShowGroupPanel = false;
            this.gridViewGiangVien.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gridViewGiangVien_RowCellClick);
            // 
            // colId
            // 
            this.colId.Caption = "ID";
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            // 
            // colHoTen
            // 
            this.colHoTen.Caption = "Họ Tên";
            this.colHoTen.FieldName = "ExpertName";
            this.colHoTen.Name = "colHoTen";
            this.colHoTen.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colHoTen.Visible = true;
            this.colHoTen.VisibleIndex = 0;
            this.colHoTen.Width = 103;
            // 
            // colNgaySinh
            // 
            this.colNgaySinh.Caption = "Ngày Sinh";
            this.colNgaySinh.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.colNgaySinh.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colNgaySinh.FieldName = "DateBirthday";
            this.colNgaySinh.Name = "colNgaySinh";
            this.colNgaySinh.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colNgaySinh.Visible = true;
            this.colNgaySinh.VisibleIndex = 1;
            this.colNgaySinh.Width = 62;
            // 
            // colSex
            // 
            this.colSex.Caption = "Giới Tính";
            this.colSex.FieldName = "sSex";
            this.colSex.Name = "colSex";
            this.colSex.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colSex.Visible = true;
            this.colSex.VisibleIndex = 2;
            this.colSex.Width = 67;
            // 
            // colYearsExperience
            // 
            this.colYearsExperience.Caption = "Kinh Nghiệm";
            this.colYearsExperience.FieldName = "YearsExperience";
            this.colYearsExperience.Name = "colYearsExperience";
            this.colYearsExperience.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colYearsExperience.Visible = true;
            this.colYearsExperience.VisibleIndex = 3;
            this.colYearsExperience.Width = 58;
            // 
            // colUniversityDegree
            // 
            this.colUniversityDegree.Caption = "Văn Bằng";
            this.colUniversityDegree.FieldName = "UniversityDegree";
            this.colUniversityDegree.Name = "colUniversityDegree";
            this.colUniversityDegree.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colUniversityDegree.Visible = true;
            this.colUniversityDegree.VisibleIndex = 4;
            this.colUniversityDegree.Width = 137;
            // 
            // colCenterId
            // 
            this.colCenterId.Caption = "Trung Tâm";
            this.colCenterId.FieldName = "CenterName";
            this.colCenterId.Name = "colCenterId";
            this.colCenterId.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colCenterId.Visible = true;
            this.colCenterId.VisibleIndex = 5;
            this.colCenterId.Width = 168;
            // 
            // colChiTiet
            // 
            this.colChiTiet.ColumnEdit = this.repositoryItemImageComboBoxCV;
            this.colChiTiet.Name = "colChiTiet";
            this.colChiTiet.Visible = true;
            this.colChiTiet.VisibleIndex = 6;
            this.colChiTiet.Width = 70;
            // 
            // repositoryItemImageComboBoxCV
            // 
            this.repositoryItemImageComboBoxCV.AutoHeight = false;
            this.repositoryItemImageComboBoxCV.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemImageComboBoxCV.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Hồ Sơ", null, 0)});
            this.repositoryItemImageComboBoxCV.Name = "repositoryItemImageComboBoxCV";
            this.repositoryItemImageComboBoxCV.SmallImages = this.imageList1;
            // 
            // actionMenuExpert
            // 
            this.actionMenuExpert.Dock = System.Windows.Forms.DockStyle.Top;
            this.actionMenuExpert.Location = new System.Drawing.Point(0, 0);
            this.actionMenuExpert.Name = "actionMenuExpert";
            this.actionMenuExpert.Size = new System.Drawing.Size(826, 50);
            this.actionMenuExpert.TabIndex = 5;
            // 
            // xtraTabPageClass
            // 
            this.xtraTabPageClass.Controls.Add(this.gridControlClass);
            this.xtraTabPageClass.Controls.Add(this.panelControl1);
            this.xtraTabPageClass.Name = "xtraTabPageClass";
            this.xtraTabPageClass.Size = new System.Drawing.Size(826, 408);
            this.xtraTabPageClass.Text = "Lịch sử giảng dạy";
            // 
            // gridControlClass
            // 
            this.gridControlClass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlClass.Location = new System.Drawing.Point(0, 50);
            this.gridControlClass.MainView = this.gridViewClass;
            this.gridControlClass.Name = "gridControlClass";
            this.gridControlClass.Size = new System.Drawing.Size(826, 358);
            this.gridControlClass.TabIndex = 1;
            this.gridControlClass.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewClass});
            // 
            // gridViewClass
            // 
            this.gridViewClass.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Id,
            this.colCourse,
            this.ColClassName,
            this.ColKhaiGiang,
            this.ColKetThuc,
            this.ColNoiHoc,
            this.ColStatus});
            this.gridViewClass.GridControl = this.gridControlClass;
            this.gridViewClass.Name = "gridViewClass";
            this.gridViewClass.OptionsBehavior.Editable = false;
            this.gridViewClass.OptionsView.ShowAutoFilterRow = true;
            this.gridViewClass.OptionsView.ShowFooter = true;
            this.gridViewClass.OptionsView.ShowGroupPanel = false;
            // 
            // Id
            // 
            this.Id.Caption = "Id";
            this.Id.FieldName = "Id";
            this.Id.Name = "Id";
            // 
            // colCourse
            // 
            this.colCourse.Caption = "Khóa học";
            this.colCourse.FieldName = "Cours.CourseName";
            this.colCourse.Name = "colCourse";
            this.colCourse.Visible = true;
            this.colCourse.VisibleIndex = 0;
            this.colCourse.Width = 143;
            // 
            // ColClassName
            // 
            this.ColClassName.Caption = "Tên lớp";
            this.ColClassName.FieldName = "ClassName";
            this.ColClassName.Name = "ColClassName";
            this.ColClassName.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.ColClassName.Visible = true;
            this.ColClassName.VisibleIndex = 1;
            this.ColClassName.Width = 143;
            // 
            // ColKhaiGiang
            // 
            this.ColKhaiGiang.Caption = "Khai giảng";
            this.ColKhaiGiang.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.ColKhaiGiang.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.ColKhaiGiang.FieldName = "FromDate";
            this.ColKhaiGiang.Name = "ColKhaiGiang";
            this.ColKhaiGiang.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.ColKhaiGiang.Visible = true;
            this.ColKhaiGiang.VisibleIndex = 2;
            this.ColKhaiGiang.Width = 95;
            // 
            // ColKetThuc
            // 
            this.ColKetThuc.Caption = "Kết thúc";
            this.ColKetThuc.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.ColKetThuc.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.ColKetThuc.FieldName = "ToDate";
            this.ColKetThuc.Name = "ColKetThuc";
            this.ColKetThuc.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.ColKetThuc.Visible = true;
            this.ColKetThuc.VisibleIndex = 3;
            this.ColKetThuc.Width = 95;
            // 
            // ColNoiHoc
            // 
            this.ColNoiHoc.Caption = "Nơi học";
            this.ColNoiHoc.FieldName = "PlaceTraining";
            this.ColNoiHoc.Name = "ColNoiHoc";
            this.ColNoiHoc.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.ColNoiHoc.Visible = true;
            this.ColNoiHoc.VisibleIndex = 4;
            this.ColNoiHoc.Width = 186;
            // 
            // ColStatus
            // 
            this.ColStatus.Caption = "Trạng Thái";
            this.ColStatus.FieldName = "Status";
            this.ColStatus.Name = "ColStatus";
            this.ColStatus.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.ColStatus.Visible = true;
            this.ColStatus.VisibleIndex = 5;
            this.ColStatus.Width = 146;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.lookUpEditExpert);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(826, 50);
            this.panelControl1.TabIndex = 0;
            // 
            // lookUpEditExpert
            // 
            this.lookUpEditExpert.Location = new System.Drawing.Point(83, 14);
            this.lookUpEditExpert.Name = "lookUpEditExpert";
            this.lookUpEditExpert.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditExpert.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Id", "Id", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ExpertName", "Tên giảng viên")});
            this.lookUpEditExpert.Properties.NullText = "---Chọn giảng viên ---";
            this.lookUpEditExpert.Size = new System.Drawing.Size(176, 20);
            this.lookUpEditExpert.TabIndex = 1;
            this.lookUpEditExpert.EditValueChanged += new System.EventHandler(this.lookUpEditExpert_EditValueChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(20, 17);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(57, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Giảng viên :";
            // 
            // uExpertInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.xtraTabControlExpert);
            this.Name = "uExpertInfo";
            this.Size = new System.Drawing.Size(832, 436);
            this.Load += new System.EventHandler(this.uExpertInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControlExpert)).EndInit();
            this.xtraTabControlExpert.ResumeLayout(false);
            this.xtraTabPageExpert.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlGiangVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewGiangVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBoxCV)).EndInit();
            this.xtraTabPageClass.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlClass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewClass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditExpert.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private DevExpress.XtraTab.XtraTabControl xtraTabControlExpert;
        private DevExpress.XtraTab.XtraTabPage xtraTabPageExpert;
        private DevExpress.XtraGrid.GridControl gridControlGiangVien;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewGiangVien;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colHoTen;
        private DevExpress.XtraGrid.Columns.GridColumn colNgaySinh;
        private DevExpress.XtraGrid.Columns.GridColumn colSex;
        private DevExpress.XtraGrid.Columns.GridColumn colYearsExperience;
        private DevExpress.XtraGrid.Columns.GridColumn colUniversityDegree;
        private DevExpress.XtraGrid.Columns.GridColumn colCenterId;
        private DevExpress.XtraGrid.Columns.GridColumn colChiTiet;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox repositoryItemImageComboBoxCV;
        private Base.ActionMenu actionMenuExpert;
        private DevExpress.XtraTab.XtraTabPage xtraTabPageClass;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditExpert;
        private DevExpress.XtraGrid.GridControl gridControlClass;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewClass;
        private DevExpress.XtraGrid.Columns.GridColumn Id;
        private DevExpress.XtraGrid.Columns.GridColumn colCourse;
        private DevExpress.XtraGrid.Columns.GridColumn ColClassName;
        private DevExpress.XtraGrid.Columns.GridColumn ColKhaiGiang;
        private DevExpress.XtraGrid.Columns.GridColumn ColKetThuc;
        private DevExpress.XtraGrid.Columns.GridColumn ColNoiHoc;
        private DevExpress.XtraGrid.Columns.GridColumn ColStatus;
    }
}

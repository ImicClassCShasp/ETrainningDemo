namespace eCenterTrainning.UseControls
{
    partial class uDepartment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uDepartment));
            this.xtraTabControlDepartment = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPageDepartment = new DevExpress.XtraTab.XtraTabPage();
            this.gridControlDepartment = new DevExpress.XtraGrid.GridControl();
            this.gridViewDepartment = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPhone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFax = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSite = new DevExpress.XtraGrid.Columns.GridColumn();
            this.actionMenuDepartment = new eCenterTrainning.Base.ActionMenu();
            this.xtraTabPageEmployee = new DevExpress.XtraTab.XtraTabPage();
            this.gridControlEmployee = new DevExpress.XtraGrid.GridControl();
            this.gridViewEmployee = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHoTen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSex = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiaChi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSDT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTrungTam = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPhongBan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colChiTiet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemImageComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.repositoryItemCheckEditSexEmp = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.lookUpEditDepartment = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControlDepartment)).BeginInit();
            this.xtraTabControlDepartment.SuspendLayout();
            this.xtraTabPageDepartment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDepartment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDepartment)).BeginInit();
            this.xtraTabPageEmployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEditSexEmp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditDepartment.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraTabControlDepartment
            // 
            this.xtraTabControlDepartment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControlDepartment.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControlDepartment.Name = "xtraTabControlDepartment";
            this.xtraTabControlDepartment.SelectedTabPage = this.xtraTabPageDepartment;
            this.xtraTabControlDepartment.Size = new System.Drawing.Size(772, 437);
            this.xtraTabControlDepartment.TabIndex = 0;
            this.xtraTabControlDepartment.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPageDepartment,
            this.xtraTabPageEmployee});
            this.xtraTabControlDepartment.Click += new System.EventHandler(this.xtraTabControlDepartment_Click);
            // 
            // xtraTabPageDepartment
            // 
            this.xtraTabPageDepartment.Controls.Add(this.gridControlDepartment);
            this.xtraTabPageDepartment.Controls.Add(this.actionMenuDepartment);
            this.xtraTabPageDepartment.Name = "xtraTabPageDepartment";
            this.xtraTabPageDepartment.Size = new System.Drawing.Size(766, 409);
            this.xtraTabPageDepartment.Text = "Danh sách phòng ban";
            // 
            // gridControlDepartment
            // 
            this.gridControlDepartment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlDepartment.Location = new System.Drawing.Point(0, 50);
            this.gridControlDepartment.MainView = this.gridViewDepartment;
            this.gridControlDepartment.Name = "gridControlDepartment";
            this.gridControlDepartment.Size = new System.Drawing.Size(766, 359);
            this.gridControlDepartment.TabIndex = 7;
            this.gridControlDepartment.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewDepartment});
            this.gridControlDepartment.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.gridControlDepartment_MouseDoubleClick);
            // 
            // gridViewDepartment
            // 
            this.gridViewDepartment.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colName,
            this.colPhone,
            this.colFax,
            this.colSite});
            this.gridViewDepartment.GridControl = this.gridControlDepartment;
            this.gridViewDepartment.Name = "gridViewDepartment";
            this.gridViewDepartment.OptionsBehavior.Editable = false;
            this.gridViewDepartment.OptionsView.ShowAutoFilterRow = true;
            this.gridViewDepartment.OptionsView.ShowGroupPanel = false;
            // 
            // colId
            // 
            this.colId.Caption = "ID";
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            // 
            // colName
            // 
            this.colName.Caption = "Tên";
            this.colName.FieldName = "OuName";
            this.colName.Name = "colName";
            this.colName.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colName.Visible = true;
            this.colName.VisibleIndex = 0;
            // 
            // colPhone
            // 
            this.colPhone.Caption = "Điện Thoại";
            this.colPhone.FieldName = "Phone";
            this.colPhone.Name = "colPhone";
            this.colPhone.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colPhone.Visible = true;
            this.colPhone.VisibleIndex = 1;
            // 
            // colFax
            // 
            this.colFax.Caption = "Fax";
            this.colFax.FieldName = "Fax";
            this.colFax.Name = "colFax";
            this.colFax.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colFax.Visible = true;
            this.colFax.VisibleIndex = 2;
            // 
            // colSite
            // 
            this.colSite.Caption = "Website";
            this.colSite.FieldName = "Website";
            this.colSite.Name = "colSite";
            this.colSite.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colSite.Visible = true;
            this.colSite.VisibleIndex = 3;
            // 
            // actionMenuDepartment
            // 
            this.actionMenuDepartment.Dock = System.Windows.Forms.DockStyle.Top;
            this.actionMenuDepartment.Location = new System.Drawing.Point(0, 0);
            this.actionMenuDepartment.Name = "actionMenuDepartment";
            this.actionMenuDepartment.Size = new System.Drawing.Size(766, 50);
            this.actionMenuDepartment.TabIndex = 6;
            this.actionMenuDepartment.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.gridControlDepartment_MouseDoubleClick);
            // 
            // xtraTabPageEmployee
            // 
            this.xtraTabPageEmployee.Controls.Add(this.gridControlEmployee);
            this.xtraTabPageEmployee.Controls.Add(this.panelControl1);
            this.xtraTabPageEmployee.Name = "xtraTabPageEmployee";
            this.xtraTabPageEmployee.Size = new System.Drawing.Size(766, 409);
            this.xtraTabPageEmployee.Text = "Nhân viên phòng ban";
            // 
            // gridControlEmployee
            // 
            this.gridControlEmployee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlEmployee.Location = new System.Drawing.Point(0, 50);
            this.gridControlEmployee.MainView = this.gridViewEmployee;
            this.gridControlEmployee.Name = "gridControlEmployee";
            this.gridControlEmployee.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEditSexEmp,
            this.repositoryItemImageComboBox1});
            this.gridControlEmployee.Size = new System.Drawing.Size(766, 359);
            this.gridControlEmployee.TabIndex = 3;
            this.gridControlEmployee.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewEmployee});
            this.gridControlEmployee.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.gridControlDepartment_MouseDoubleClick);
            // 
            // gridViewEmployee
            // 
            this.gridViewEmployee.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.colHoTen,
            this.colSex,
            this.colDiaChi,
            this.colEmail,
            this.colSDT,
            this.colTrungTam,
            this.colPhongBan,
            this.colChiTiet});
            this.gridViewEmployee.GridControl = this.gridControlEmployee;
            this.gridViewEmployee.Name = "gridViewEmployee";
            this.gridViewEmployee.OptionsBehavior.Editable = false;
            this.gridViewEmployee.OptionsView.ShowAutoFilterRow = true;
            this.gridViewEmployee.OptionsView.ShowGroupPanel = false;
            this.gridViewEmployee.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gridViewEmployee_RowCellClick);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "ID";
            this.gridColumn1.FieldName = "Id";
            this.gridColumn1.Name = "gridColumn1";
            // 
            // colHoTen
            // 
            this.colHoTen.Caption = "Họ Tên";
            this.colHoTen.FieldName = "EmployeeName";
            this.colHoTen.Name = "colHoTen";
            this.colHoTen.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colHoTen.Visible = true;
            this.colHoTen.VisibleIndex = 0;
            this.colHoTen.Width = 150;
            // 
            // colSex
            // 
            this.colSex.Caption = "Giới Tính";
            this.colSex.FieldName = "Sex";
            this.colSex.Name = "colSex";
            this.colSex.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colSex.Visible = true;
            this.colSex.VisibleIndex = 1;
            this.colSex.Width = 69;
            // 
            // colDiaChi
            // 
            this.colDiaChi.Caption = "Địa Chỉ";
            this.colDiaChi.FieldName = "Address";
            this.colDiaChi.Name = "colDiaChi";
            this.colDiaChi.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colDiaChi.Visible = true;
            this.colDiaChi.VisibleIndex = 2;
            this.colDiaChi.Width = 100;
            // 
            // colEmail
            // 
            this.colEmail.Caption = "Email";
            this.colEmail.FieldName = "Email";
            this.colEmail.Name = "colEmail";
            this.colEmail.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colEmail.Visible = true;
            this.colEmail.VisibleIndex = 3;
            this.colEmail.Width = 100;
            // 
            // colSDT
            // 
            this.colSDT.Caption = "Di Động";
            this.colSDT.FieldName = "Mobile";
            this.colSDT.Name = "colSDT";
            this.colSDT.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colSDT.Visible = true;
            this.colSDT.VisibleIndex = 4;
            this.colSDT.Width = 100;
            // 
            // colTrungTam
            // 
            this.colTrungTam.Caption = "Trung Tâm";
            this.colTrungTam.FieldName = "CenterName";
            this.colTrungTam.Name = "colTrungTam";
            this.colTrungTam.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colTrungTam.Visible = true;
            this.colTrungTam.VisibleIndex = 5;
            this.colTrungTam.Width = 100;
            // 
            // colPhongBan
            // 
            this.colPhongBan.Caption = "Phòng Ban";
            this.colPhongBan.FieldName = "OuName";
            this.colPhongBan.Name = "colPhongBan";
            this.colPhongBan.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colPhongBan.Width = 111;
            // 
            // colChiTiet
            // 
            this.colChiTiet.ColumnEdit = this.repositoryItemImageComboBox1;
            this.colChiTiet.Name = "colChiTiet";
            this.colChiTiet.Visible = true;
            this.colChiTiet.VisibleIndex = 6;
            // 
            // repositoryItemImageComboBox1
            // 
            this.repositoryItemImageComboBox1.AutoHeight = false;
            this.repositoryItemImageComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemImageComboBox1.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Hồ sơ", null, 0)});
            this.repositoryItemImageComboBox1.Name = "repositoryItemImageComboBox1";
            this.repositoryItemImageComboBox1.SmallImages = this.imageList1;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "docs.gif");
            // 
            // repositoryItemCheckEditSexEmp
            // 
            this.repositoryItemCheckEditSexEmp.AutoHeight = false;
            this.repositoryItemCheckEditSexEmp.Name = "repositoryItemCheckEditSexEmp";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.lookUpEditDepartment);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(766, 50);
            this.panelControl1.TabIndex = 1;
            // 
            // lookUpEditDepartment
            // 
            this.lookUpEditDepartment.Location = new System.Drawing.Point(83, 14);
            this.lookUpEditDepartment.Name = "lookUpEditDepartment";
            this.lookUpEditDepartment.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditDepartment.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Id", "Id", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("OuName", "Tên phòng ban")});
            this.lookUpEditDepartment.Properties.NullText = "---Chọn phòng ban ---";
            this.lookUpEditDepartment.Size = new System.Drawing.Size(176, 20);
            this.lookUpEditDepartment.TabIndex = 1;
            this.lookUpEditDepartment.EditValueChanged += new System.EventHandler(this.lookUpEditDepartment_EditValueChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(20, 17);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(58, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Phòng ban :";
            // 
            // uDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.xtraTabControlDepartment);
            this.Name = "uDepartment";
            this.Size = new System.Drawing.Size(772, 437);
            this.Load += new System.EventHandler(this.uDepartment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControlDepartment)).EndInit();
            this.xtraTabControlDepartment.ResumeLayout(false);
            this.xtraTabPageDepartment.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDepartment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDepartment)).EndInit();
            this.xtraTabPageEmployee.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEditSexEmp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditDepartment.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl xtraTabControlDepartment;
        private DevExpress.XtraTab.XtraTabPage xtraTabPageDepartment;
        private DevExpress.XtraGrid.GridControl gridControlDepartment;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewDepartment;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colPhone;
        private DevExpress.XtraGrid.Columns.GridColumn colFax;
        private DevExpress.XtraGrid.Columns.GridColumn colSite;
        private Base.ActionMenu actionMenuDepartment;
        private DevExpress.XtraTab.XtraTabPage xtraTabPageEmployee;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditDepartment;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl gridControlEmployee;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewEmployee;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn colHoTen;
        private DevExpress.XtraGrid.Columns.GridColumn colSex;
        private DevExpress.XtraGrid.Columns.GridColumn colDiaChi;
        private DevExpress.XtraGrid.Columns.GridColumn colEmail;
        private DevExpress.XtraGrid.Columns.GridColumn colSDT;
        private DevExpress.XtraGrid.Columns.GridColumn colTrungTam;
        private DevExpress.XtraGrid.Columns.GridColumn colPhongBan;
        private DevExpress.XtraGrid.Columns.GridColumn colChiTiet;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox repositoryItemImageComboBox1;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEditSexEmp;
        private System.Windows.Forms.ImageList imageList1;


    }
}

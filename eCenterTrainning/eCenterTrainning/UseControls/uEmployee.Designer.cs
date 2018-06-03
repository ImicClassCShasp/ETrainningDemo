namespace eCenterTrainning.UseControls
{
    partial class uEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uEmployee));
            this.actionMenuEmployee = new eCenterTrainning.Base.ActionMenu();
            this.gridControlEmployee = new DevExpress.XtraGrid.GridControl();
            this.gridViewEmployee = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.gridControlEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEditSexEmp)).BeginInit();
            this.SuspendLayout();
            // 
            // actionMenuEmployee
            // 
            this.actionMenuEmployee.Dock = System.Windows.Forms.DockStyle.Top;
            this.actionMenuEmployee.Location = new System.Drawing.Point(0, 0);
            this.actionMenuEmployee.Name = "actionMenuEmployee";
            this.actionMenuEmployee.Size = new System.Drawing.Size(748, 60);
            this.actionMenuEmployee.TabIndex = 0;
            // 
            // gridControlEmployee
            // 
            this.gridControlEmployee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlEmployee.Location = new System.Drawing.Point(0, 60);
            this.gridControlEmployee.MainView = this.gridViewEmployee;
            this.gridControlEmployee.Name = "gridControlEmployee";
            this.gridControlEmployee.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEditSexEmp,
            this.repositoryItemImageComboBox1});
            this.gridControlEmployee.Size = new System.Drawing.Size(748, 360);
            this.gridControlEmployee.TabIndex = 2;
            this.gridControlEmployee.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewEmployee});
            this.gridControlEmployee.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.gridControlEmployee_MouseDoubleClick);
            // 
            // gridViewEmployee
            // 
            this.gridViewEmployee.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
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
            // colID
            // 
            this.colID.Caption = "Id";
            this.colID.FieldName = "Id";
            this.colID.Name = "colID";
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
            this.colSex.FieldName = "SexString";
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
            this.colEmail.Caption = "E-mail";
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
            this.colPhongBan.Visible = true;
            this.colPhongBan.VisibleIndex = 6;
            this.colPhongBan.Width = 111;
            // 
            // colChiTiet
            // 
            this.colChiTiet.ColumnEdit = this.repositoryItemImageComboBox1;
            this.colChiTiet.Name = "colChiTiet";
            this.colChiTiet.Visible = true;
            this.colChiTiet.VisibleIndex = 7;
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
            this.imageList1.Images.SetKeyName(0, "002.png");
            // 
            // repositoryItemCheckEditSexEmp
            // 
            this.repositoryItemCheckEditSexEmp.AutoHeight = false;
            this.repositoryItemCheckEditSexEmp.Name = "repositoryItemCheckEditSexEmp";
            // 
            // uEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControlEmployee);
            this.Controls.Add(this.actionMenuEmployee);
            this.Name = "uEmployee";
            this.Size = new System.Drawing.Size(748, 420);
            this.Load += new System.EventHandler(this.uEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEditSexEmp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Base.ActionMenu actionMenuEmployee;
        private DevExpress.XtraGrid.GridControl gridControlEmployee;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewEmployee;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colHoTen;
        private DevExpress.XtraGrid.Columns.GridColumn colSex;
        private DevExpress.XtraGrid.Columns.GridColumn colDiaChi;
        private DevExpress.XtraGrid.Columns.GridColumn colEmail;
        private DevExpress.XtraGrid.Columns.GridColumn colSDT;
        private DevExpress.XtraGrid.Columns.GridColumn colTrungTam;
        private DevExpress.XtraGrid.Columns.GridColumn colPhongBan;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEditSexEmp;
        private DevExpress.XtraGrid.Columns.GridColumn colChiTiet;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox repositoryItemImageComboBox1;
        private System.Windows.Forms.ImageList imageList1;
    }
}

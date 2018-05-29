namespace eCenterTrainning.UseControls
{
    partial class uPolicyStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uPolicyStudent));
            this.actionMenuPolicyStudent = new eCenterTrainning.Base.ActionMenu();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnTimKiem = new DevExpress.XtraEditors.SimpleButton();
            this.txtTuKhoa = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gridControlPolicyStudent = new DevExpress.XtraGrid.GridControl();
            this.gridViewPolicyStudent = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateStart = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateEnd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTrungTam = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colChiTiet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemImageComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTuKhoa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlPolicyStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPolicyStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // actionMenuPolicyStudent
            // 
            this.actionMenuPolicyStudent.Dock = System.Windows.Forms.DockStyle.Top;
            this.actionMenuPolicyStudent.Location = new System.Drawing.Point(0, 0);
            this.actionMenuPolicyStudent.Name = "actionMenuPolicyStudent";
            this.actionMenuPolicyStudent.Size = new System.Drawing.Size(728, 50);
            this.actionMenuPolicyStudent.TabIndex = 0;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnTimKiem);
            this.groupControl1.Controls.Add(this.txtTuKhoa);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 50);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(728, 68);
            this.groupControl1.TabIndex = 5;
            this.groupControl1.Text = "Thông tin tìm kiếm";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Image = global::eCenterTrainning.Properties.Resources.search;
            this.btnTimKiem.Location = new System.Drawing.Point(460, 32);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(75, 23);
            this.btnTimKiem.TabIndex = 2;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtTuKhoa
            // 
            this.txtTuKhoa.Location = new System.Drawing.Point(78, 33);
            this.txtTuKhoa.Name = "txtTuKhoa";
            this.txtTuKhoa.Size = new System.Drawing.Size(359, 20);
            this.txtTuKhoa.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(18, 37);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(46, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Từ khóa :";
            // 
            // gridControlPolicyStudent
            // 
            this.gridControlPolicyStudent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlPolicyStudent.Location = new System.Drawing.Point(0, 118);
            this.gridControlPolicyStudent.MainView = this.gridViewPolicyStudent;
            this.gridControlPolicyStudent.Name = "gridControlPolicyStudent";
            this.gridControlPolicyStudent.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemImageComboBox1});
            this.gridControlPolicyStudent.Size = new System.Drawing.Size(728, 356);
            this.gridControlPolicyStudent.TabIndex = 6;
            this.gridControlPolicyStudent.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewPolicyStudent});
            // 
            // gridViewPolicyStudent
            // 
            this.gridViewPolicyStudent.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colName,
            this.colDateStart,
            this.colDateEnd,
            this.colTrungTam,
            this.colChiTiet});
            this.gridViewPolicyStudent.GridControl = this.gridControlPolicyStudent;
            this.gridViewPolicyStudent.Name = "gridViewPolicyStudent";
            this.gridViewPolicyStudent.OptionsBehavior.Editable = false;
            this.gridViewPolicyStudent.OptionsView.ShowAutoFilterRow = true;
            this.gridViewPolicyStudent.OptionsView.ShowFooter = true;
            this.gridViewPolicyStudent.OptionsView.ShowGroupPanel = false;
            this.gridViewPolicyStudent.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gridViewPolicyStudent_RowCellClick);
            // 
            // colId
            // 
            this.colId.Caption = "Id";
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            // 
            // colName
            // 
            this.colName.Caption = "Chương trình ưu đãi";
            this.colName.FieldName = "PolicyName";
            this.colName.Name = "colName";
            this.colName.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colName.Visible = true;
            this.colName.VisibleIndex = 0;
            this.colName.Width = 300;
            // 
            // colDateStart
            // 
            this.colDateStart.Caption = "Ngày bắt đầu";
            this.colDateStart.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.colDateStart.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colDateStart.FieldName = "DateStart";
            this.colDateStart.Name = "colDateStart";
            this.colDateStart.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colDateStart.Visible = true;
            this.colDateStart.VisibleIndex = 1;
            this.colDateStart.Width = 94;
            // 
            // colDateEnd
            // 
            this.colDateEnd.Caption = "Ngày kết thúc";
            this.colDateEnd.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.colDateEnd.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colDateEnd.FieldName = "DateEnd";
            this.colDateEnd.Name = "colDateEnd";
            this.colDateEnd.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colDateEnd.Visible = true;
            this.colDateEnd.VisibleIndex = 2;
            this.colDateEnd.Width = 94;
            // 
            // colTrungTam
            // 
            this.colTrungTam.Caption = "Trung tâm";
            this.colTrungTam.FieldName = "CenterInfo.CenterName";
            this.colTrungTam.Name = "colTrungTam";
            this.colTrungTam.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colTrungTam.Visible = true;
            this.colTrungTam.VisibleIndex = 3;
            this.colTrungTam.Width = 132;
            // 
            // colChiTiet
            // 
            this.colChiTiet.ColumnEdit = this.repositoryItemImageComboBox1;
            this.colChiTiet.Name = "colChiTiet";
            this.colChiTiet.Visible = true;
            this.colChiTiet.VisibleIndex = 4;
            this.colChiTiet.Width = 120;
            // 
            // repositoryItemImageComboBox1
            // 
            this.repositoryItemImageComboBox1.AutoHeight = false;
            this.repositoryItemImageComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemImageComboBox1.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Chi tiết ưu đãi", null, 0)});
            this.repositoryItemImageComboBox1.Name = "repositoryItemImageComboBox1";
            this.repositoryItemImageComboBox1.SmallImages = this.imageList1;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "docs.gif");
            // 
            // uPolicyStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControlPolicyStudent);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.actionMenuPolicyStudent);
            this.Name = "uPolicyStudent";
            this.Size = new System.Drawing.Size(728, 474);
            this.Load += new System.EventHandler(this.uPolicyStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTuKhoa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlPolicyStudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPolicyStudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Base.ActionMenu actionMenuPolicyStudent;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnTimKiem;
        private DevExpress.XtraEditors.TextEdit txtTuKhoa;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl gridControlPolicyStudent;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewPolicyStudent;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colDateStart;
        private DevExpress.XtraGrid.Columns.GridColumn colDateEnd;
        private DevExpress.XtraGrid.Columns.GridColumn colTrungTam;
        private DevExpress.XtraGrid.Columns.GridColumn colChiTiet;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox repositoryItemImageComboBox1;
        private System.Windows.Forms.ImageList imageList1;
    }
}

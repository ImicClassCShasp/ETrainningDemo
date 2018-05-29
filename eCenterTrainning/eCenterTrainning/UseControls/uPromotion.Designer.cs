namespace eCenterTrainning.UseControls
{
    partial class uPromotion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uPromotion));
            this.actionMenuPromotion = new eCenterTrainning.Base.ActionMenu();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnTimKiem = new DevExpress.XtraEditors.SimpleButton();
            this.txtTuKhoa = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gridControlPromotion = new DevExpress.XtraGrid.GridControl();
            this.gridViewPromotion = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateFrom = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colChiTiet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemImageComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTuKhoa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlPromotion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPromotion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // actionMenuPromotion
            // 
            this.actionMenuPromotion.Dock = System.Windows.Forms.DockStyle.Top;
            this.actionMenuPromotion.Location = new System.Drawing.Point(0, 0);
            this.actionMenuPromotion.Name = "actionMenuPromotion";
            this.actionMenuPromotion.Size = new System.Drawing.Size(763, 50);
            this.actionMenuPromotion.TabIndex = 2;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnTimKiem);
            this.groupControl1.Controls.Add(this.txtTuKhoa);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 50);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(763, 68);
            this.groupControl1.TabIndex = 4;
            this.groupControl1.Text = "Thông tin tìm kiếm";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Image = global::eCenterTrainning.Properties.Resources.search;
            this.btnTimKiem.Location = new System.Drawing.Point(461, 32);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(75, 23);
            this.btnTimKiem.TabIndex = 2;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtTuKhoa
            // 
            this.txtTuKhoa.Location = new System.Drawing.Point(79, 33);
            this.txtTuKhoa.Name = "txtTuKhoa";
            this.txtTuKhoa.Size = new System.Drawing.Size(359, 20);
            this.txtTuKhoa.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(19, 37);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(46, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Từ khóa :";
            // 
            // gridControlPromotion
            // 
            this.gridControlPromotion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlPromotion.Location = new System.Drawing.Point(0, 118);
            this.gridControlPromotion.MainView = this.gridViewPromotion;
            this.gridControlPromotion.Name = "gridControlPromotion";
            this.gridControlPromotion.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemImageComboBox1});
            this.gridControlPromotion.Size = new System.Drawing.Size(763, 364);
            this.gridControlPromotion.TabIndex = 5;
            this.gridControlPromotion.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewPromotion});
            // 
            // gridViewPromotion
            // 
            this.gridViewPromotion.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colName,
            this.colAddress,
            this.colDateFrom,
            this.colDate,
            this.colChiTiet});
            this.gridViewPromotion.GridControl = this.gridControlPromotion;
            this.gridViewPromotion.Name = "gridViewPromotion";
            this.gridViewPromotion.OptionsBehavior.Editable = false;
            this.gridViewPromotion.OptionsView.ShowAutoFilterRow = true;
            this.gridViewPromotion.OptionsView.ShowFooter = true;
            this.gridViewPromotion.OptionsView.ShowGroupPanel = false;
            this.gridViewPromotion.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gridViewPromotion_RowCellClick);
            // 
            // colId
            // 
            this.colId.Caption = "Id";
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            // 
            // colName
            // 
            this.colName.Caption = "Quảng Bá Khóa Học";
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colName.Visible = true;
            this.colName.VisibleIndex = 0;
            this.colName.Width = 280;
            // 
            // colAddress
            // 
            this.colAddress.Caption = "Địa Chỉ";
            this.colAddress.FieldName = "Address";
            this.colAddress.Name = "colAddress";
            this.colAddress.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colAddress.Visible = true;
            this.colAddress.VisibleIndex = 1;
            this.colAddress.Width = 188;
            // 
            // colDateFrom
            // 
            this.colDateFrom.Caption = "Ngày Bắt Đầu";
            this.colDateFrom.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.colDateFrom.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colDateFrom.FieldName = "DateFrom";
            this.colDateFrom.Name = "colDateFrom";
            this.colDateFrom.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colDateFrom.Visible = true;
            this.colDateFrom.VisibleIndex = 2;
            this.colDateFrom.Width = 91;
            // 
            // colDate
            // 
            this.colDate.Caption = "Ngày Kết Thúc";
            this.colDate.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.colDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colDate.FieldName = "DateTo";
            this.colDate.Name = "colDate";
            this.colDate.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colDate.Visible = true;
            this.colDate.VisibleIndex = 3;
            this.colDate.Width = 99;
            // 
            // colChiTiet
            // 
            this.colChiTiet.ColumnEdit = this.repositoryItemImageComboBox1;
            this.colChiTiet.Name = "colChiTiet";
            this.colChiTiet.Visible = true;
            this.colChiTiet.VisibleIndex = 4;
            this.colChiTiet.Width = 110;
            // 
            // repositoryItemImageComboBox1
            // 
            this.repositoryItemImageComboBox1.AutoHeight = false;
            this.repositoryItemImageComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemImageComboBox1.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Chi tiết quảng bá", null, 0)});
            this.repositoryItemImageComboBox1.Name = "repositoryItemImageComboBox1";
            this.repositoryItemImageComboBox1.SmallImages = this.imageList1;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "docs.gif");
            // 
            // uPromotion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControlPromotion);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.actionMenuPromotion);
            this.Name = "uPromotion";
            this.Size = new System.Drawing.Size(763, 482);
            this.Load += new System.EventHandler(this.uPromotion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTuKhoa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlPromotion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPromotion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Base.ActionMenu actionMenuPromotion;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnTimKiem;
        private DevExpress.XtraEditors.TextEdit txtTuKhoa;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl gridControlPromotion;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewPromotion;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colAddress;
        private DevExpress.XtraGrid.Columns.GridColumn colDateFrom;
        private DevExpress.XtraGrid.Columns.GridColumn colDate;
        private DevExpress.XtraGrid.Columns.GridColumn colChiTiet;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox repositoryItemImageComboBox1;
        private System.Windows.Forms.ImageList imageList1;
    }
}

namespace eCenterTrainning.UseControls
{
    partial class ucReportInfomation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucReportInfomation));
            this.grcBaoCaoNgay = new DevExpress.XtraGrid.GridControl();
            this.grvBaoCaoNgay = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colXemChiTiet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemImageComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.bandedGridView1 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridView();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.gridColumn9 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridColumn11 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridColumn12 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridColumn13 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridColumn14 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateEdit1 = new DevExpress.XtraEditors.DateEdit();
            this.chkDuyetBaoCao = new DevExpress.XtraEditors.CheckEdit();
            this.btnGuiBaoCao = new DevExpress.XtraEditors.SimpleButton();
            this.btnTaoBaoCaoNgay = new DevExpress.XtraEditors.SimpleButton();
            this.btnVietBaoCao = new DevExpress.XtraEditors.SimpleButton();
            this.txtNoiDungBc = new DevExpress.XtraEditors.TextEdit();
            this.lblReportId = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.actionMenu1 = new eCenterTrainning.Base.ActionMenu();
            ((System.ComponentModel.ISupportInitialize)(this.grcBaoCaoNgay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvBaoCaoNgay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandedGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkDuyetBaoCao.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNoiDungBc.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // grcBaoCaoNgay
            // 
            this.grcBaoCaoNgay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grcBaoCaoNgay.Location = new System.Drawing.Point(0, 130);
            this.grcBaoCaoNgay.MainView = this.grvBaoCaoNgay;
            this.grcBaoCaoNgay.Name = "grcBaoCaoNgay";
            this.grcBaoCaoNgay.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemImageComboBox1});
            this.grcBaoCaoNgay.Size = new System.Drawing.Size(1007, 369);
            this.grcBaoCaoNgay.TabIndex = 2;
            this.grcBaoCaoNgay.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvBaoCaoNgay,
            this.bandedGridView1});
            // 
            // grvBaoCaoNgay
            // 
            this.grvBaoCaoNgay.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn8,
            this.colXemChiTiet});
            this.grvBaoCaoNgay.GridControl = this.grcBaoCaoNgay;
            this.grvBaoCaoNgay.GroupCount = 1;
            this.grvBaoCaoNgay.Name = "grvBaoCaoNgay";
            this.grvBaoCaoNgay.OptionsBehavior.Editable = false;
            this.grvBaoCaoNgay.OptionsView.ShowAutoFilterRow = true;
            this.grvBaoCaoNgay.OptionsView.ShowFooter = true;
            this.grvBaoCaoNgay.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.gridColumn3, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.grvBaoCaoNgay.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.grvBaoCaoNgay_RowClick);
            this.grvBaoCaoNgay.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.grvBaoCaoNgay_RowCellClick);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "ReportID";
            this.gridColumn1.FieldName = "ReportID";
            this.gridColumn1.Name = "gridColumn1";
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Ngày Tạo báo cáo";
            this.gridColumn2.FieldName = "CreateDate";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            this.gridColumn2.Width = 83;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Ngày Báo Cáo";
            this.gridColumn3.FieldName = "ReportDate";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 1;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "UserId";
            this.gridColumn4.FieldName = "UserId";
            this.gridColumn4.Name = "gridColumn4";
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Người thực hiện Báo Cáo";
            this.gridColumn5.FieldName = "DisplayName";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 1;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Comments";
            this.gridColumn6.FieldName = "Comments";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 2;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Status";
            this.gridColumn7.FieldName = "Status";
            this.gridColumn7.Name = "gridColumn7";
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "Trạng thái";
            this.gridColumn8.FieldName = "TrangThai";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 3;
            // 
            // colXemChiTiet
            // 
            this.colXemChiTiet.ColumnEdit = this.repositoryItemImageComboBox1;
            this.colXemChiTiet.Name = "colXemChiTiet";
            this.colXemChiTiet.Visible = true;
            this.colXemChiTiet.VisibleIndex = 4;
            // 
            // repositoryItemImageComboBox1
            // 
            this.repositoryItemImageComboBox1.AutoHeight = false;
            this.repositoryItemImageComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemImageComboBox1.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Xem chi tiết", null, 0)});
            this.repositoryItemImageComboBox1.LargeImages = this.imageList1;
            this.repositoryItemImageComboBox1.Name = "repositoryItemImageComboBox1";
            this.repositoryItemImageComboBox1.NullText = "Xem chi tiết";
            this.repositoryItemImageComboBox1.NullValuePrompt = "Xem chi tiết";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "action_settings.gif");
            // 
            // bandedGridView1
            // 
            this.bandedGridView1.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand1});
            this.bandedGridView1.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.gridColumn9,
            this.gridColumn10,
            this.gridColumn11,
            this.gridColumn12,
            this.gridColumn13,
            this.gridColumn14});
            this.bandedGridView1.GridControl = this.grcBaoCaoNgay;
            this.bandedGridView1.GroupCount = 1;
            this.bandedGridView1.Name = "bandedGridView1";
            this.bandedGridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.gridColumn13, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // gridBand1
            // 
            this.gridBand1.Caption = "gridBand1";
            this.gridBand1.Columns.Add(this.gridColumn9);
            this.gridBand1.Columns.Add(this.gridColumn10);
            this.gridBand1.Columns.Add(this.gridColumn11);
            this.gridBand1.Columns.Add(this.gridColumn12);
            this.gridBand1.Columns.Add(this.gridColumn13);
            this.gridBand1.Columns.Add(this.gridColumn14);
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.Width = 450;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "EventId";
            this.gridColumn9.FieldName = "EventId";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.Visible = true;
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "EventName";
            this.gridColumn10.FieldName = "EventName";
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.Visible = true;
            // 
            // gridColumn11
            // 
            this.gridColumn11.Caption = "FaceId";
            this.gridColumn11.FieldName = "FaceId";
            this.gridColumn11.Name = "gridColumn11";
            this.gridColumn11.Visible = true;
            // 
            // gridColumn12
            // 
            this.gridColumn12.Caption = "DetaiId";
            this.gridColumn12.FieldName = "DetaiId";
            this.gridColumn12.Name = "gridColumn12";
            this.gridColumn12.Visible = true;
            // 
            // gridColumn13
            // 
            this.gridColumn13.Caption = "TruyenThongId";
            this.gridColumn13.FieldName = "TruyenThongId";
            this.gridColumn13.Name = "gridColumn13";
            this.gridColumn13.Visible = true;
            // 
            // gridColumn14
            // 
            this.gridColumn14.Caption = "TrangThaiTT";
            this.gridColumn14.FieldName = "TrangThaiTT";
            this.gridColumn14.Name = "gridColumn14";
            this.gridColumn14.Visible = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateEdit1);
            this.groupBox1.Controls.Add(this.chkDuyetBaoCao);
            this.groupBox1.Controls.Add(this.btnGuiBaoCao);
            this.groupBox1.Controls.Add(this.btnTaoBaoCaoNgay);
            this.groupBox1.Controls.Add(this.btnVietBaoCao);
            this.groupBox1.Controls.Add(this.txtNoiDungBc);
            this.groupBox1.Controls.Add(this.lblReportId);
            this.groupBox1.Controls.Add(this.labelControl2);
            this.groupBox1.Controls.Add(this.labelControl1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1007, 86);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nghiệp vụ Báo Cáo Công Việc theo Ngày";
            // 
            // dateEdit1
            // 
            this.dateEdit1.EditValue = null;
            this.dateEdit1.Location = new System.Drawing.Point(147, 16);
            this.dateEdit1.Name = "dateEdit1";
            this.dateEdit1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dateEdit1.Properties.Appearance.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.dateEdit1.Properties.Appearance.Options.UseFont = true;
            this.dateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Properties.DisplayFormat.FormatString = "yyyy-MM-dd";
            this.dateEdit1.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateEdit1.Properties.EditFormat.FormatString = "yyyy-MM-dd";
            this.dateEdit1.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateEdit1.Properties.Mask.EditMask = "yyyy-MM-dd";
            this.dateEdit1.Properties.NullDate = "";
            this.dateEdit1.Properties.NullText = "<Bấm nút Tạo Ngày Báo Cáo để thiết lập Ngày Báo Cáo>";
            this.dateEdit1.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dateEdit1.Size = new System.Drawing.Size(484, 26);
            this.dateEdit1.TabIndex = 4;
            // 
            // chkDuyetBaoCao
            // 
            this.chkDuyetBaoCao.EditValue = true;
            this.chkDuyetBaoCao.Enabled = false;
            this.chkDuyetBaoCao.Location = new System.Drawing.Point(943, 37);
            this.chkDuyetBaoCao.Name = "chkDuyetBaoCao";
            this.chkDuyetBaoCao.Properties.Caption = "Chờ duyệt báo cáo";
            this.chkDuyetBaoCao.Size = new System.Drawing.Size(20, 19);
            this.chkDuyetBaoCao.TabIndex = 3;
            this.chkDuyetBaoCao.CheckedChanged += new System.EventHandler(this.chkDuyetBaoCao_CheckedChanged);
            // 
            // btnGuiBaoCao
            // 
            this.btnGuiBaoCao.Appearance.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuiBaoCao.Appearance.Options.UseFont = true;
            this.btnGuiBaoCao.Enabled = false;
            this.btnGuiBaoCao.Image = global::eCenterTrainning.Properties.Resources._007;
            this.btnGuiBaoCao.Location = new System.Drawing.Point(802, 19);
            this.btnGuiBaoCao.Name = "btnGuiBaoCao";
            this.btnGuiBaoCao.Size = new System.Drawing.Size(135, 55);
            this.btnGuiBaoCao.TabIndex = 2;
            this.btnGuiBaoCao.Text = "3 - GỬI BÁO CÁO";
            this.btnGuiBaoCao.Click += new System.EventHandler(this.btnGuiBaoCao_Click);
            // 
            // btnTaoBaoCaoNgay
            // 
            this.btnTaoBaoCaoNgay.Appearance.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaoBaoCaoNgay.Appearance.Options.UseFont = true;
            this.btnTaoBaoCaoNgay.Image = global::eCenterTrainning.Properties.Resources.table_add;
            this.btnTaoBaoCaoNgay.Location = new System.Drawing.Point(637, 17);
            this.btnTaoBaoCaoNgay.Name = "btnTaoBaoCaoNgay";
            this.btnTaoBaoCaoNgay.Size = new System.Drawing.Size(159, 23);
            this.btnTaoBaoCaoNgay.TabIndex = 2;
            this.btnTaoBaoCaoNgay.Text = "1 - Tạo Ngày Báo Cáo";
            this.btnTaoBaoCaoNgay.Click += new System.EventHandler(this.btnTaoBaoCaoNgay_Click);
            // 
            // btnVietBaoCao
            // 
            this.btnVietBaoCao.Appearance.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVietBaoCao.Appearance.Options.UseFont = true;
            this.btnVietBaoCao.Enabled = false;
            this.btnVietBaoCao.Image = global::eCenterTrainning.Properties.Resources._002;
            this.btnVietBaoCao.Location = new System.Drawing.Point(637, 53);
            this.btnVietBaoCao.Name = "btnVietBaoCao";
            this.btnVietBaoCao.Size = new System.Drawing.Size(159, 23);
            this.btnVietBaoCao.TabIndex = 2;
            this.btnVietBaoCao.Text = "2 - Viết báo cáo";
            this.btnVietBaoCao.Click += new System.EventHandler(this.btnVietBaoCao_Click);
            // 
            // txtNoiDungBc
            // 
            this.txtNoiDungBc.EditValue = "<Nội dung báo cáo Ngày được lưu tại đây>";
            this.txtNoiDungBc.Enabled = false;
            this.txtNoiDungBc.Location = new System.Drawing.Point(147, 52);
            this.txtNoiDungBc.Name = "txtNoiDungBc";
            this.txtNoiDungBc.Properties.Appearance.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoiDungBc.Properties.Appearance.Options.UseFont = true;
            this.txtNoiDungBc.Size = new System.Drawing.Size(484, 26);
            this.txtNoiDungBc.TabIndex = 1;
            // 
            // lblReportId
            // 
            this.lblReportId.Appearance.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReportId.Location = new System.Drawing.Point(945, 55);
            this.lblReportId.Name = "lblReportId";
            this.lblReportId.Size = new System.Drawing.Size(0, 19);
            this.lblReportId.TabIndex = 0;
            this.lblReportId.Visible = false;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Location = new System.Drawing.Point(16, 19);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(127, 19);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Tạo ngày Báo Cáo:";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(16, 55);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(125, 19);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Nội dung báo cáo:";
            // 
            // actionMenu1
            // 
            this.actionMenu1.Dock = System.Windows.Forms.DockStyle.Top;
            this.actionMenu1.Location = new System.Drawing.Point(0, 0);
            this.actionMenu1.Name = "actionMenu1";
            this.actionMenu1.Size = new System.Drawing.Size(1007, 44);
            this.actionMenu1.TabIndex = 0;
            // 
            // ucReportInfomation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grcBaoCaoNgay);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.actionMenu1);
            this.Name = "ucReportInfomation";
            this.Size = new System.Drawing.Size(1007, 499);
            this.Load += new System.EventHandler(this.ucReportInfomation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grcBaoCaoNgay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvBaoCaoNgay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandedGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkDuyetBaoCao.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNoiDungBc.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Base.ActionMenu actionMenu1;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.SimpleButton btnVietBaoCao;
        private DevExpress.XtraEditors.TextEdit txtNoiDungBc;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl grcBaoCaoNgay;
        private DevExpress.XtraGrid.Views.Grid.GridView grvBaoCaoNgay;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn colXemChiTiet;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox repositoryItemImageComboBox1;
        private System.Windows.Forms.ImageList imageList1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridView bandedGridView1;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn gridColumn9;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn gridColumn10;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn gridColumn11;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn gridColumn12;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn gridColumn13;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn gridColumn14;
        private DevExpress.XtraEditors.SimpleButton btnGuiBaoCao;
        private DevExpress.XtraEditors.SimpleButton btnTaoBaoCaoNgay;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.DateEdit dateEdit1;
        private DevExpress.XtraEditors.CheckEdit chkDuyetBaoCao;
        private DevExpress.XtraEditors.LabelControl lblReportId;
    }
}

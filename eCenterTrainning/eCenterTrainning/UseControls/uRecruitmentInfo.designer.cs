namespace eCenterTrainning.UseControls
{
    partial class uRecruitmentInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uRecruitmentInfo));
            this.xtraTabControlRecruitmentCandiidate = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPageManageRecruitment = new DevExpress.XtraTab.XtraTabPage();
            this.gridControlRecruitmentInfo = new DevExpress.XtraGrid.GridControl();
            this.gridViewRecruitmentInfo = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTrungTam = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateStart = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateEnd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colChiTiet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemImageComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.actionMenuRecruitmentInfo = new eCenterTrainning.Base.ActionMenu();
            this.xtraTabPageCandidates = new DevExpress.XtraTab.XtraTabPage();
            this.gridControlCandidates = new DevExpress.XtraGrid.GridControl();
            this.gridViewCandidates = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSex = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateSent = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRecruitment = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colChucVu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnSuaUngVien = new DevExpress.XtraEditors.SimpleButton();
            this.btnAddMoreCandidate = new DevExpress.XtraEditors.SimpleButton();
            this.lbTuyenDung = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControlRecruitmentCandiidate)).BeginInit();
            this.xtraTabControlRecruitmentCandiidate.SuspendLayout();
            this.xtraTabPageManageRecruitment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlRecruitmentInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewRecruitmentInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox1)).BeginInit();
            this.xtraTabPageCandidates.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCandidates)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCandidates)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // xtraTabControlRecruitmentCandiidate
            // 
            this.xtraTabControlRecruitmentCandiidate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControlRecruitmentCandiidate.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControlRecruitmentCandiidate.Name = "xtraTabControlRecruitmentCandiidate";
            this.xtraTabControlRecruitmentCandiidate.SelectedTabPage = this.xtraTabPageManageRecruitment;
            this.xtraTabControlRecruitmentCandiidate.Size = new System.Drawing.Size(700, 450);
            this.xtraTabControlRecruitmentCandiidate.TabIndex = 6;
            this.xtraTabControlRecruitmentCandiidate.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPageManageRecruitment,
            this.xtraTabPageCandidates});
            this.xtraTabControlRecruitmentCandiidate.Click += new System.EventHandler(this.xtraTabControlRecruitmentCandiidate_Click);
            // 
            // xtraTabPageManageRecruitment
            // 
            this.xtraTabPageManageRecruitment.Controls.Add(this.gridControlRecruitmentInfo);
            this.xtraTabPageManageRecruitment.Controls.Add(this.actionMenuRecruitmentInfo);
            this.xtraTabPageManageRecruitment.Name = "xtraTabPageManageRecruitment";
            this.xtraTabPageManageRecruitment.Size = new System.Drawing.Size(694, 422);
            this.xtraTabPageManageRecruitment.Text = "Danh Sách Tuyển Dụng";
            // 
            // gridControlRecruitmentInfo
            // 
            this.gridControlRecruitmentInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlRecruitmentInfo.Location = new System.Drawing.Point(0, 50);
            this.gridControlRecruitmentInfo.MainView = this.gridViewRecruitmentInfo;
            this.gridControlRecruitmentInfo.Name = "gridControlRecruitmentInfo";
            this.gridControlRecruitmentInfo.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemImageComboBox1});
            this.gridControlRecruitmentInfo.Size = new System.Drawing.Size(694, 372);
            this.gridControlRecruitmentInfo.TabIndex = 9;
            this.gridControlRecruitmentInfo.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewRecruitmentInfo});
            this.gridControlRecruitmentInfo.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.gridControlRecruitmentInfo_MouseDoubleClick);
            // 
            // gridViewRecruitmentInfo
            // 
            this.gridViewRecruitmentInfo.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.colTrungTam,
            this.colNumber,
            this.colDateStart,
            this.colDateEnd,
            this.colStatus,
            this.colChiTiet});
            this.gridViewRecruitmentInfo.GridControl = this.gridControlRecruitmentInfo;
            this.gridViewRecruitmentInfo.Name = "gridViewRecruitmentInfo";
            this.gridViewRecruitmentInfo.OptionsBehavior.Editable = false;
            this.gridViewRecruitmentInfo.OptionsView.ShowAutoFilterRow = true;
            this.gridViewRecruitmentInfo.OptionsView.ShowFooter = true;
            this.gridViewRecruitmentInfo.OptionsView.ShowGroupPanel = false;
            this.gridViewRecruitmentInfo.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gridViewRecruitmentInfo_RowCellClick);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Id";
            this.gridColumn1.FieldName = "Id";
            this.gridColumn1.Name = "gridColumn1";
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Tên Tuyển Dụng";
            this.gridColumn2.FieldName = "Name";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            this.gridColumn2.Width = 168;
            // 
            // colTrungTam
            // 
            this.colTrungTam.Caption = "Trung Tâm";
            this.colTrungTam.FieldName = "CenterName";
            this.colTrungTam.Name = "colTrungTam";
            this.colTrungTam.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colTrungTam.Visible = true;
            this.colTrungTam.VisibleIndex = 1;
            this.colTrungTam.Width = 88;
            // 
            // colNumber
            // 
            this.colNumber.Caption = "Số Lượng";
            this.colNumber.FieldName = "Number";
            this.colNumber.Name = "colNumber";
            this.colNumber.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colNumber.Visible = true;
            this.colNumber.VisibleIndex = 2;
            this.colNumber.Width = 60;
            // 
            // colDateStart
            // 
            this.colDateStart.Caption = "Ngày Bắt Đầu";
            this.colDateStart.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.colDateStart.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colDateStart.FieldName = "DateStart";
            this.colDateStart.Name = "colDateStart";
            this.colDateStart.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colDateStart.Visible = true;
            this.colDateStart.VisibleIndex = 3;
            this.colDateStart.Width = 81;
            // 
            // colDateEnd
            // 
            this.colDateEnd.Caption = "Ngày Kết Thúc";
            this.colDateEnd.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.colDateEnd.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colDateEnd.FieldName = "DateEnd";
            this.colDateEnd.Name = "colDateEnd";
            this.colDateEnd.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colDateEnd.Visible = true;
            this.colDateEnd.VisibleIndex = 4;
            this.colDateEnd.Width = 81;
            // 
            // colStatus
            // 
            this.colStatus.Caption = "Trạng Thái";
            this.colStatus.FieldName = "strTrangThai";
            this.colStatus.Name = "colStatus";
            this.colStatus.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colStatus.Visible = true;
            this.colStatus.VisibleIndex = 5;
            this.colStatus.Width = 77;
            // 
            // colChiTiet
            // 
            this.colChiTiet.ColumnEdit = this.repositoryItemImageComboBox1;
            this.colChiTiet.Name = "colChiTiet";
            this.colChiTiet.Visible = true;
            this.colChiTiet.VisibleIndex = 6;
            this.colChiTiet.Width = 121;
            // 
            // repositoryItemImageComboBox1
            // 
            this.repositoryItemImageComboBox1.AutoHeight = false;
            this.repositoryItemImageComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemImageComboBox1.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Chi tiết tuyển dụng", null, 0)});
            this.repositoryItemImageComboBox1.Name = "repositoryItemImageComboBox1";
            this.repositoryItemImageComboBox1.SmallImages = this.imageList1;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "docs.gif");
            // 
            // actionMenuRecruitmentInfo
            // 
            this.actionMenuRecruitmentInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.actionMenuRecruitmentInfo.Location = new System.Drawing.Point(0, 0);
            this.actionMenuRecruitmentInfo.Name = "actionMenuRecruitmentInfo";
            this.actionMenuRecruitmentInfo.Size = new System.Drawing.Size(694, 50);
            this.actionMenuRecruitmentInfo.TabIndex = 8;
            // 
            // xtraTabPageCandidates
            // 
            this.xtraTabPageCandidates.Controls.Add(this.gridControlCandidates);
            this.xtraTabPageCandidates.Controls.Add(this.panelControl1);
            this.xtraTabPageCandidates.Name = "xtraTabPageCandidates";
            this.xtraTabPageCandidates.Size = new System.Drawing.Size(694, 422);
            this.xtraTabPageCandidates.Text = "Danh Sách Ứng Viên";
            // 
            // gridControlCandidates
            // 
            this.gridControlCandidates.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlCandidates.Location = new System.Drawing.Point(0, 40);
            this.gridControlCandidates.MainView = this.gridViewCandidates;
            this.gridControlCandidates.Name = "gridControlCandidates";
            this.gridControlCandidates.Size = new System.Drawing.Size(694, 382);
            this.gridControlCandidates.TabIndex = 12;
            this.gridControlCandidates.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewCandidates});
            // 
            // gridViewCandidates
            // 
            this.gridViewCandidates.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colName,
            this.colSex,
            this.colDateSent,
            this.colRecruitment,
            this.colChucVu});
            this.gridViewCandidates.GridControl = this.gridControlCandidates;
            this.gridViewCandidates.Name = "gridViewCandidates";
            this.gridViewCandidates.OptionsBehavior.Editable = false;
            this.gridViewCandidates.OptionsView.ShowAutoFilterRow = true;
            this.gridViewCandidates.OptionsView.ShowFooter = true;
            this.gridViewCandidates.OptionsView.ShowGroupPanel = false;
            // 
            // colId
            // 
            this.colId.Caption = "Id";
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.Width = 120;
            // 
            // colName
            // 
            this.colName.Caption = "Họ Tên";
            this.colName.FieldName = "FullName";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 0;
            this.colName.Width = 160;
            // 
            // colSex
            // 
            this.colSex.Caption = "Giới Tính";
            this.colSex.FieldName = "Sex";
            this.colSex.Name = "colSex";
            this.colSex.Visible = true;
            this.colSex.VisibleIndex = 1;
            this.colSex.Width = 55;
            // 
            // colDateSent
            // 
            this.colDateSent.Caption = "Ngày Gửi";
            this.colDateSent.FieldName = "DateSent";
            this.colDateSent.Name = "colDateSent";
            this.colDateSent.Visible = true;
            this.colDateSent.VisibleIndex = 2;
            this.colDateSent.Width = 70;
            // 
            // colRecruitment
            // 
            this.colRecruitment.Caption = "Đợt Tuyển Dụng";
            this.colRecruitment.FieldName = "NameRecruitment";
            this.colRecruitment.Name = "colRecruitment";
            this.colRecruitment.Visible = true;
            this.colRecruitment.VisibleIndex = 3;
            this.colRecruitment.Width = 315;
            // 
            // colChucVu
            // 
            this.colChucVu.Caption = "Vị Trí ";
            this.colChucVu.FieldName = "JobTitle1";
            this.colChucVu.Name = "colChucVu";
            this.colChucVu.Visible = true;
            this.colChucVu.VisibleIndex = 4;
            this.colChucVu.Width = 85;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnSuaUngVien);
            this.panelControl1.Controls.Add(this.btnAddMoreCandidate);
            this.panelControl1.Controls.Add(this.lbTuyenDung);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(694, 40);
            this.panelControl1.TabIndex = 11;
            // 
            // btnSuaUngVien
            // 
            this.btnSuaUngVien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSuaUngVien.ImageOptions.Image = global::eCenterTrainning.Properties.Resources.book_edit;
            this.btnSuaUngVien.Location = new System.Drawing.Point(584, 10);
            this.btnSuaUngVien.Name = "btnSuaUngVien";
            this.btnSuaUngVien.Size = new System.Drawing.Size(102, 24);
            this.btnSuaUngVien.TabIndex = 5;
            this.btnSuaUngVien.Text = "Sửa Ứng Viên";
            // 
            // btnAddMoreCandidate
            // 
            this.btnAddMoreCandidate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddMoreCandidate.ImageOptions.Image = global::eCenterTrainning.Properties.Resources._103;
            this.btnAddMoreCandidate.Location = new System.Drawing.Point(476, 10);
            this.btnAddMoreCandidate.Name = "btnAddMoreCandidate";
            this.btnAddMoreCandidate.Size = new System.Drawing.Size(102, 24);
            this.btnAddMoreCandidate.TabIndex = 5;
            this.btnAddMoreCandidate.Text = "Thêm Ứng Viên";
            this.btnAddMoreCandidate.Click += new System.EventHandler(this.btnAddMoreCandidate_Click);
            // 
            // lbTuyenDung
            // 
            this.lbTuyenDung.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lbTuyenDung.Appearance.Options.UseFont = true;
            this.lbTuyenDung.Location = new System.Drawing.Point(111, 12);
            this.lbTuyenDung.Name = "lbTuyenDung";
            this.lbTuyenDung.Size = new System.Drawing.Size(108, 17);
            this.lbTuyenDung.TabIndex = 4;
            this.lbTuyenDung.Text = "Vị trí ứng tuyển";
            this.lbTuyenDung.Visible = false;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(15, 14);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(86, 13);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Đợt Tuyển Dụng :";
            // 
            // uRecruitmentInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.xtraTabControlRecruitmentCandiidate);
            this.Name = "uRecruitmentInfo";
            this.Size = new System.Drawing.Size(700, 450);
            this.Load += new System.EventHandler(this.uRecruitmentInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControlRecruitmentCandiidate)).EndInit();
            this.xtraTabControlRecruitmentCandiidate.ResumeLayout(false);
            this.xtraTabPageManageRecruitment.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlRecruitmentInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewRecruitmentInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox1)).EndInit();
            this.xtraTabPageCandidates.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCandidates)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCandidates)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl xtraTabControlRecruitmentCandiidate;
        private DevExpress.XtraTab.XtraTabPage xtraTabPageManageRecruitment;
        private DevExpress.XtraTab.XtraTabPage xtraTabPageCandidates;
        private Base.ActionMenu actionMenuRecruitmentInfo;
        private DevExpress.XtraGrid.GridControl gridControlRecruitmentInfo;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewRecruitmentInfo;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn colTrungTam;
        private DevExpress.XtraGrid.Columns.GridColumn colNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colDateStart;
        private DevExpress.XtraGrid.Columns.GridColumn colDateEnd;
        private DevExpress.XtraGrid.Columns.GridColumn colStatus;
        private DevExpress.XtraGrid.GridControl gridControlCandidates;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewCandidates;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colSex;
        private DevExpress.XtraGrid.Columns.GridColumn colDateSent;
        private DevExpress.XtraGrid.Columns.GridColumn colRecruitment;
        private DevExpress.XtraGrid.Columns.GridColumn colChucVu;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnAddMoreCandidate;
        private DevExpress.XtraEditors.LabelControl lbTuyenDung;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.Columns.GridColumn colChiTiet;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox repositoryItemImageComboBox1;
        private System.Windows.Forms.ImageList imageList1;
        private DevExpress.XtraEditors.SimpleButton btnSuaUngVien;


    }
}

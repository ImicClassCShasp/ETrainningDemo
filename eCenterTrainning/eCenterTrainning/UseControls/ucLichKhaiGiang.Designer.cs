namespace eCenterTrainning.UseControls
{
    partial class ucLichKhaiGiang
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
            this.actionMenu1 = new eCenterTrainning.Base.ActionMenu();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLoadData = new DevExpress.XtraEditors.SimpleButton();
            this.dtpDenNgay = new DevExpress.XtraEditors.DateEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpTuNgay = new DevExpress.XtraEditors.DateEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colChon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.chkChonId = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.colMaLop = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayKhaiGiang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLichHoc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colThoiGian = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colThoiLuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTrangThai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenKhoaHoc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDangKy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colChuaDangKy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtpDenNgay.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpDenNgay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpTuNgay.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpTuNgay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkChonId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // actionMenu1
            // 
            this.actionMenu1.Dock = System.Windows.Forms.DockStyle.Top;
            this.actionMenu1.Location = new System.Drawing.Point(0, 0);
            this.actionMenu1.Name = "actionMenu1";
            this.actionMenu1.Size = new System.Drawing.Size(815, 47);
            this.actionMenu1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLoadData);
            this.groupBox1.Controls.Add(this.dtpDenNgay);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dtpTuNgay);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(815, 64);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm theo thời gian";
            // 
            // btnLoadData
            // 
            this.btnLoadData.Image = global::eCenterTrainning.Properties.Resources.accept;
            this.btnLoadData.Location = new System.Drawing.Point(15, 26);
            this.btnLoadData.Name = "btnLoadData";
            this.btnLoadData.Size = new System.Drawing.Size(155, 23);
            this.btnLoadData.TabIndex = 2;
            this.btnLoadData.Text = "Load dữ liệu từ Server";
            this.btnLoadData.Click += new System.EventHandler(this.btnLoadData_Click);
            // 
            // dtpDenNgay
            // 
            this.dtpDenNgay.EditValue = null;
            this.dtpDenNgay.Location = new System.Drawing.Point(521, 27);
            this.dtpDenNgay.Name = "dtpDenNgay";
            this.dtpDenNgay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpDenNgay.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dtpDenNgay.Size = new System.Drawing.Size(183, 20);
            this.dtpDenNgay.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(451, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Đến Ngày:";
            // 
            // dtpTuNgay
            // 
            this.dtpTuNgay.EditValue = null;
            this.dtpTuNgay.Location = new System.Drawing.Point(250, 29);
            this.dtpTuNgay.Name = "dtpTuNgay";
            this.dtpTuNgay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpTuNgay.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dtpTuNgay.Size = new System.Drawing.Size(183, 20);
            this.dtpTuNgay.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(189, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Từ Ngày:";
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 111);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.chkChonId});
            this.gridControl1.Size = new System.Drawing.Size(815, 384);
            this.gridControl1.TabIndex = 2;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colChon,
            this.colMaLop,
            this.colNgayKhaiGiang,
            this.colLichHoc,
            this.colThoiGian,
            this.colThoiLuong,
            this.colTrangThai,
            this.colTenKhoaHoc,
            this.colDangKy,
            this.colChuaDangKy});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupCount = 1;
            this.gridView1.Name = "gridView1";
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colTenKhoaHoc, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colChon
            // 
            this.colChon.ColumnEdit = this.chkChonId;
            this.colChon.Name = "colChon";
            this.colChon.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.colChon.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True;
            this.colChon.Visible = true;
            this.colChon.VisibleIndex = 0;
            this.colChon.Width = 62;
            // 
            // chkChonId
            // 
            this.chkChonId.AutoHeight = false;
            this.chkChonId.Name = "chkChonId";
            // 
            // colMaLop
            // 
            this.colMaLop.Caption = "Mã Lớp";
            this.colMaLop.FieldName = "MaLop";
            this.colMaLop.Name = "colMaLop";
            this.colMaLop.Visible = true;
            this.colMaLop.VisibleIndex = 1;
            this.colMaLop.Width = 109;
            // 
            // colNgayKhaiGiang
            // 
            this.colNgayKhaiGiang.Caption = "Ngày Khai Giảng";
            this.colNgayKhaiGiang.FieldName = "NgayKhaiGiang";
            this.colNgayKhaiGiang.Name = "colNgayKhaiGiang";
            this.colNgayKhaiGiang.Visible = true;
            this.colNgayKhaiGiang.VisibleIndex = 2;
            this.colNgayKhaiGiang.Width = 88;
            // 
            // colLichHoc
            // 
            this.colLichHoc.Caption = "Lịch Học";
            this.colLichHoc.FieldName = "LichHoc";
            this.colLichHoc.Name = "colLichHoc";
            this.colLichHoc.Visible = true;
            this.colLichHoc.VisibleIndex = 3;
            this.colLichHoc.Width = 61;
            // 
            // colThoiGian
            // 
            this.colThoiGian.Caption = "Thời Gian";
            this.colThoiGian.FieldName = "ThoiGian";
            this.colThoiGian.Name = "colThoiGian";
            this.colThoiGian.Visible = true;
            this.colThoiGian.VisibleIndex = 4;
            this.colThoiGian.Width = 132;
            // 
            // colThoiLuong
            // 
            this.colThoiLuong.Caption = "Thời Lượng";
            this.colThoiLuong.FieldName = "ThoiLuong";
            this.colThoiLuong.Name = "colThoiLuong";
            this.colThoiLuong.Visible = true;
            this.colThoiLuong.VisibleIndex = 5;
            this.colThoiLuong.Width = 43;
            // 
            // colTrangThai
            // 
            this.colTrangThai.Caption = "Trạng Thái";
            this.colTrangThai.FieldName = "TrangThai";
            this.colTrangThai.Name = "colTrangThai";
            this.colTrangThai.Visible = true;
            this.colTrangThai.VisibleIndex = 6;
            this.colTrangThai.Width = 61;
            // 
            // colTenKhoaHoc
            // 
            this.colTenKhoaHoc.Caption = "Tên Khóa Học";
            this.colTenKhoaHoc.FieldName = "TenKhoaHoc";
            this.colTenKhoaHoc.Name = "colTenKhoaHoc";
            this.colTenKhoaHoc.Visible = true;
            this.colTenKhoaHoc.VisibleIndex = 5;
            this.colTenKhoaHoc.Width = 93;
            // 
            // colDangKy
            // 
            this.colDangKy.Caption = "Đã Đăng Ký";
            this.colDangKy.FieldName = "DaDuyet";
            this.colDangKy.Name = "colDangKy";
            this.colDangKy.Visible = true;
            this.colDangKy.VisibleIndex = 7;
            this.colDangKy.Width = 46;
            // 
            // colChuaDangKy
            // 
            this.colChuaDangKy.Caption = "ChuaDuyet";
            this.colChuaDangKy.FieldName = "ChuaDuyet";
            this.colChuaDangKy.Name = "colChuaDangKy";
            this.colChuaDangKy.Visible = true;
            this.colChuaDangKy.VisibleIndex = 8;
            this.colChuaDangKy.Width = 46;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ucLichKhaiGiang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.actionMenu1);
            this.Name = "ucLichKhaiGiang";
            this.Size = new System.Drawing.Size(815, 495);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtpDenNgay.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpDenNgay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpTuNgay.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpTuNgay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkChonId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Base.ActionMenu actionMenu1;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.DateEdit dtpDenNgay;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.DateEdit dtpTuNgay;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton btnLoadData;
        private DevExpress.XtraGrid.Columns.GridColumn colChon;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit chkChonId;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private DevExpress.XtraGrid.Columns.GridColumn colMaLop;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayKhaiGiang;
        private DevExpress.XtraGrid.Columns.GridColumn colLichHoc;
        private DevExpress.XtraGrid.Columns.GridColumn colThoiGian;
        private DevExpress.XtraGrid.Columns.GridColumn colThoiLuong;
        private DevExpress.XtraGrid.Columns.GridColumn colTrangThai;
        private DevExpress.XtraGrid.Columns.GridColumn colTenKhoaHoc;
        private DevExpress.XtraGrid.Columns.GridColumn colDangKy;
        private DevExpress.XtraGrid.Columns.GridColumn colChuaDangKy;
    }
}

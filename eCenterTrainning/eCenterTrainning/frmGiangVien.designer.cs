namespace eCenterTrainning
{
    partial class frmGiangVien
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
            this.actionMenuGiangVien = new eCenterTrainning.Base.ActionMenu();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.gridControlGiangVien = new DevExpress.XtraGrid.GridControl();
            this.gridViewGiangVien = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHoTen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgaySinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSex = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYearsExperience = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUniversityDegree = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCenterId = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.msgMessage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlGiangVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewGiangVien)).BeginInit();
            this.SuspendLayout();
            // 
            // actionMenuGiangVien
            // 
            this.actionMenuGiangVien.Dock = System.Windows.Forms.DockStyle.Top;
            this.actionMenuGiangVien.Location = new System.Drawing.Point(0, 0);
            this.actionMenuGiangVien.Name = "actionMenuGiangVien";
            this.actionMenuGiangVien.Size = new System.Drawing.Size(742, 51);
            this.actionMenuGiangVien.TabIndex = 0;
            // 
            // panelControl1
            // 
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 385);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(742, 46);
            this.panelControl1.TabIndex = 1;
            // 
            // gridControlGiangVien
            // 
            this.gridControlGiangVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlGiangVien.Location = new System.Drawing.Point(0, 51);
            this.gridControlGiangVien.MainView = this.gridViewGiangVien;
            this.gridControlGiangVien.Name = "gridControlGiangVien";
            this.gridControlGiangVien.Size = new System.Drawing.Size(742, 334);
            this.gridControlGiangVien.TabIndex = 2;
            this.gridControlGiangVien.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewGiangVien});
            // 
            // gridViewGiangVien
            // 
            this.gridViewGiangVien.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colHoTen,
            this.colNgaySinh,
            this.colSex,
            this.colDescription,
            this.colYearsExperience,
            this.colUniversityDegree,
            this.colCenterId});
            this.gridViewGiangVien.GridControl = this.gridControlGiangVien;
            this.gridViewGiangVien.Name = "gridViewGiangVien";
            this.gridViewGiangVien.OptionsView.ShowAutoFilterRow = true;
            this.gridViewGiangVien.OptionsView.ShowGroupPanel = false;
            // 
            // colId
            // 
            this.colId.Caption = "ID";
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.Visible = true;
            this.colId.VisibleIndex = 0;
            // 
            // colHoTen
            // 
            this.colHoTen.Caption = "Họ Tên";
            this.colHoTen.FieldName = "ExpertName";
            this.colHoTen.Name = "colHoTen";
            this.colHoTen.Visible = true;
            this.colHoTen.VisibleIndex = 1;
            // 
            // colNgaySinh
            // 
            this.colNgaySinh.Caption = "Ngày Sinh";
            this.colNgaySinh.FieldName = "DateBirthday";
            this.colNgaySinh.Name = "colNgaySinh";
            this.colNgaySinh.Visible = true;
            this.colNgaySinh.VisibleIndex = 2;
            // 
            // colSex
            // 
            this.colSex.Caption = "Giới Tính";
            this.colSex.FieldName = "Sex";
            this.colSex.Name = "colSex";
            this.colSex.Visible = true;
            this.colSex.VisibleIndex = 3;
            // 
            // colDescription
            // 
            this.colDescription.Caption = "Mô Tả";
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 4;
            // 
            // colYearsExperience
            // 
            this.colYearsExperience.Caption = "Năm Kinh Nghiệm";
            this.colYearsExperience.FieldName = "YearsExperience";
            this.colYearsExperience.Name = "colYearsExperience";
            this.colYearsExperience.Visible = true;
            this.colYearsExperience.VisibleIndex = 5;
            // 
            // colUniversityDegree
            // 
            this.colUniversityDegree.Caption = "Trường Tốt Ngiệp";
            this.colUniversityDegree.FieldName = "UniversityDegree";
            this.colUniversityDegree.Name = "colUniversityDegree";
            this.colUniversityDegree.Visible = true;
            this.colUniversityDegree.VisibleIndex = 6;
            // 
            // colCenterId
            // 
            this.colCenterId.Caption = "Trung Tâm";
            this.colCenterId.FieldName = "CenterInfo.CenterName";
            this.colCenterId.Name = "colCenterId";
            this.colCenterId.Visible = true;
            this.colCenterId.VisibleIndex = 7;
            // 
            // frmGiangVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 431);
            this.Controls.Add(this.gridControlGiangVien);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.actionMenuGiangVien);
            this.Name = "frmGiangVien";
            this.Text = "THÔNG TIN GIẢNG VIÊN";
            this.Load += new System.EventHandler(this.frmGiangVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.msgMessage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlGiangVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewGiangVien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Base.ActionMenu actionMenuGiangVien;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.GridControl gridControlGiangVien;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewGiangVien;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colHoTen;
        private DevExpress.XtraGrid.Columns.GridColumn colNgaySinh;
        private DevExpress.XtraGrid.Columns.GridColumn colSex;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colYearsExperience;
        private DevExpress.XtraGrid.Columns.GridColumn colUniversityDegree;
        private DevExpress.XtraGrid.Columns.GridColumn colCenterId;
    }
}
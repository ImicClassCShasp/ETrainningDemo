namespace eCenterTrainning
{
    partial class frmListCandidate
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
            this.gridControlCandidates = new DevExpress.XtraGrid.GridControl();
            this.gridViewCandidates = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSex = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateSent = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRecruitment = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colChucVu = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCandidates)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCandidates)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.gridControlCandidates);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(689, 451);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Ứng Viên";
            // 
            // gridControlCandidates
            // 
            this.gridControlCandidates.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlCandidates.Location = new System.Drawing.Point(2, 21);
            this.gridControlCandidates.MainView = this.gridViewCandidates;
            this.gridControlCandidates.Name = "gridControlCandidates";
            this.gridControlCandidates.Size = new System.Drawing.Size(685, 428);
            this.gridControlCandidates.TabIndex = 13;
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
            this.colName.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colName.Visible = true;
            this.colName.VisibleIndex = 0;
            this.colName.Width = 160;
            // 
            // colSex
            // 
            this.colSex.Caption = "Giới Tính";
            this.colSex.FieldName = "Sex";
            this.colSex.Name = "colSex";
            this.colSex.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colSex.Visible = true;
            this.colSex.VisibleIndex = 1;
            this.colSex.Width = 55;
            // 
            // colDateSent
            // 
            this.colDateSent.Caption = "Ngày Gửi";
            this.colDateSent.FieldName = "DateSent";
            this.colDateSent.Name = "colDateSent";
            this.colDateSent.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colDateSent.Visible = true;
            this.colDateSent.VisibleIndex = 2;
            this.colDateSent.Width = 70;
            // 
            // colRecruitment
            // 
            this.colRecruitment.Caption = "Đợt Tuyển Dụng";
            this.colRecruitment.FieldName = "NameRecruitment";
            this.colRecruitment.Name = "colRecruitment";
            this.colRecruitment.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colRecruitment.Visible = true;
            this.colRecruitment.VisibleIndex = 3;
            this.colRecruitment.Width = 315;
            // 
            // colChucVu
            // 
            this.colChucVu.Caption = "Vị Trí ";
            this.colChucVu.FieldName = "JobTitle1";
            this.colChucVu.Name = "colChucVu";
            this.colChucVu.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colChucVu.Visible = true;
            this.colChucVu.VisibleIndex = 4;
            this.colChucVu.Width = 85;
            // 
            // frmListCandidate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 451);
            this.Controls.Add(this.groupControl1);
            this.Name = "frmListCandidate";
            this.Text = "frmListCandidate";
            //this.Load += new System.EventHandler(this.frmListCandidate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCandidates)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCandidates)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl gridControlCandidates;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewCandidates;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colSex;
        private DevExpress.XtraGrid.Columns.GridColumn colDateSent;
        private DevExpress.XtraGrid.Columns.GridColumn colRecruitment;
        private DevExpress.XtraGrid.Columns.GridColumn colChucVu;
    }
}
namespace eCenterTrainning
{
    partial class frmManageCandidates
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
            this.actionMenuCandidate = new eCenterTrainning.Base.ActionMenu();
            this.gridControlCandidates = new DevExpress.XtraGrid.GridControl();
            this.gridViewCandidates = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSex = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateSent = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRecruitment = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colViTri = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCandidates)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCandidates)).BeginInit();
            this.SuspendLayout();
            // 
            // actionMenuCandidate
            // 
            this.actionMenuCandidate.Dock = System.Windows.Forms.DockStyle.Top;
            this.actionMenuCandidate.Location = new System.Drawing.Point(0, 0);
            this.actionMenuCandidate.Name = "actionMenuCandidate";
            this.actionMenuCandidate.Size = new System.Drawing.Size(684, 50);
            this.actionMenuCandidate.TabIndex = 1;
            // 
            // gridControlCandidates
            // 
            this.gridControlCandidates.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlCandidates.Location = new System.Drawing.Point(0, 50);
            this.gridControlCandidates.MainView = this.gridViewCandidates;
            this.gridControlCandidates.Name = "gridControlCandidates";
            this.gridControlCandidates.Size = new System.Drawing.Size(684, 421);
            this.gridControlCandidates.TabIndex = 9;
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
            this.colViTri});
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
            // 
            // colName
            // 
            this.colName.Caption = "Tên";
            this.colName.FieldName = "FullName";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 0;
            this.colName.Width = 191;
            // 
            // colSex
            // 
            this.colSex.Caption = "Giới Tính";
            this.colSex.FieldName = "Sex";
            this.colSex.Name = "colSex";
            this.colSex.Visible = true;
            this.colSex.VisibleIndex = 1;
            this.colSex.Width = 61;
            // 
            // colDateSent
            // 
            this.colDateSent.Caption = "Ngày Gửi";
            this.colDateSent.FieldName = "DateSent";
            this.colDateSent.Name = "colDateSent";
            this.colDateSent.Visible = true;
            this.colDateSent.VisibleIndex = 2;
            this.colDateSent.Width = 80;
            // 
            // colRecruitment
            // 
            this.colRecruitment.Caption = "Đợt Tuyển Dụng";
            this.colRecruitment.FieldName = "NameRecruitment";
            this.colRecruitment.Name = "colRecruitment";
            this.colRecruitment.Visible = true;
            this.colRecruitment.VisibleIndex = 3;
            this.colRecruitment.Width = 342;
            // 
            // colViTri
            // 
            this.colViTri.Caption = "Vị Trí";
            this.colViTri.FieldName = "JobTitle1";
            this.colViTri.Name = "colViTri";
            this.colViTri.Visible = true;
            this.colViTri.VisibleIndex = 4;
            // 
            // frmManageCandidates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 471);
            this.Controls.Add(this.gridControlCandidates);
            this.Controls.Add(this.actionMenuCandidate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmManageCandidates";
            this.Text = "frmManageCandidates";
            this.Load += new System.EventHandler(this.frmManageCandidates_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCandidates)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCandidates)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Base.ActionMenu actionMenuCandidate;
        private DevExpress.XtraGrid.GridControl gridControlCandidates;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewCandidates;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colSex;
        private DevExpress.XtraGrid.Columns.GridColumn colDateSent;
        private DevExpress.XtraGrid.Columns.GridColumn colRecruitment;
        private DevExpress.XtraGrid.Columns.GridColumn colViTri;
    }
}
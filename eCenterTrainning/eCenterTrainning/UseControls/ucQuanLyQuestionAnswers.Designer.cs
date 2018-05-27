namespace eCenterTrainning.UseControls
{
    partial class ucQuanLyQuestionAnswers
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
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.tabTraLoi = new DevExpress.XtraTab.XtraTabPage();
            this.gridControlTraLoi = new DevExpress.XtraGrid.GridControl();
            this.gridViewTraLoi = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colA_AID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colA_QID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colA_Questions = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colA_Answers = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colA_Accept = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colA_UserName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colA_StatusAW = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colA_Steps = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colA_Status = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.accMenuTraLoi = new eCenterTrainning.Base.ActionMenu();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.tabTraLoi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlTraLoi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTraLoi)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.tabTraLoi;
            this.xtraTabControl1.Size = new System.Drawing.Size(1063, 488);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tabTraLoi});
            // 
            // tabTraLoi
            // 
            this.tabTraLoi.Controls.Add(this.gridControlTraLoi);
            this.tabTraLoi.Controls.Add(this.panel1);
            this.tabTraLoi.Image = global::eCenterTrainning.Properties.Resources.accept;
            this.tabTraLoi.Name = "tabTraLoi";
            this.tabTraLoi.Size = new System.Drawing.Size(1057, 457);
            this.tabTraLoi.Text = "Danh mục câu trả lời";
            // 
            // gridControlTraLoi
            // 
            this.gridControlTraLoi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlTraLoi.Location = new System.Drawing.Point(0, 44);
            this.gridControlTraLoi.MainView = this.gridViewTraLoi;
            this.gridControlTraLoi.Name = "gridControlTraLoi";
            this.gridControlTraLoi.Size = new System.Drawing.Size(1057, 413);
            this.gridControlTraLoi.TabIndex = 1;
            this.gridControlTraLoi.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewTraLoi});
            // 
            // gridViewTraLoi
            // 
            this.gridViewTraLoi.Appearance.FocusedCell.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.gridViewTraLoi.Appearance.FocusedCell.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewTraLoi.Appearance.FocusedCell.Options.UseFont = true;
            this.gridViewTraLoi.Appearance.FocusedRow.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewTraLoi.Appearance.FocusedRow.Options.UseFont = true;
            this.gridViewTraLoi.Appearance.HeaderPanel.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewTraLoi.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridViewTraLoi.Appearance.OddRow.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewTraLoi.Appearance.OddRow.Options.UseFont = true;
            this.gridViewTraLoi.Appearance.Preview.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewTraLoi.Appearance.Preview.Options.UseFont = true;
            this.gridViewTraLoi.Appearance.Row.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewTraLoi.Appearance.Row.Options.UseFont = true;
            this.gridViewTraLoi.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colA_AID,
            this.colA_QID,
            this.colA_Questions,
            this.colA_Answers,
            this.colA_Accept,
            this.colA_UserName,
            this.colA_StatusAW,
            this.colA_Steps,
            this.colA_Status});
            this.gridViewTraLoi.GridControl = this.gridControlTraLoi;
            this.gridViewTraLoi.GroupCount = 1;
            this.gridViewTraLoi.Name = "gridViewTraLoi";
            this.gridViewTraLoi.OptionsView.ShowAutoFilterRow = true;
            this.gridViewTraLoi.RowHeight = 30;
            this.gridViewTraLoi.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colA_Questions, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colA_AID
            // 
            this.colA_AID.Caption = "AID";
            this.colA_AID.FieldName = "AID";
            this.colA_AID.Name = "colA_AID";
            // 
            // colA_QID
            // 
            this.colA_QID.Caption = "QID";
            this.colA_QID.FieldName = "QID";
            this.colA_QID.Name = "colA_QID";
            // 
            // colA_Questions
            // 
            this.colA_Questions.Caption = "Nội dung câu hỏi";
            this.colA_Questions.FieldName = "Questions";
            this.colA_Questions.Name = "colA_Questions";
            this.colA_Questions.Visible = true;
            this.colA_Questions.VisibleIndex = 0;
            this.colA_Questions.Width = 152;
            // 
            // colA_Answers
            // 
            this.colA_Answers.Caption = "Nội dung câu trả lời";
            this.colA_Answers.FieldName = "Answers";
            this.colA_Answers.Name = "colA_Answers";
            this.colA_Answers.Visible = true;
            this.colA_Answers.VisibleIndex = 1;
            this.colA_Answers.Width = 317;
            // 
            // colA_Accept
            // 
            this.colA_Accept.Caption = "Mã người duyệt";
            this.colA_Accept.FieldName = "Accept";
            this.colA_Accept.Name = "colA_Accept";
            this.colA_Accept.Width = 220;
            // 
            // colA_UserName
            // 
            this.colA_UserName.Caption = "Người Duyệt";
            this.colA_UserName.FieldName = "UserName";
            this.colA_UserName.Name = "colA_UserName";
            this.colA_UserName.Visible = true;
            this.colA_UserName.VisibleIndex = 2;
            this.colA_UserName.Width = 60;
            // 
            // colA_StatusAW
            // 
            this.colA_StatusAW.Caption = "Trạng thái Duyệt";
            this.colA_StatusAW.FieldName = "StatusAW";
            this.colA_StatusAW.Name = "colA_StatusAW";
            this.colA_StatusAW.Visible = true;
            this.colA_StatusAW.VisibleIndex = 3;
            this.colA_StatusAW.Width = 70;
            // 
            // colA_Steps
            // 
            this.colA_Steps.Caption = "Các bước tư vấn";
            this.colA_Steps.FieldName = "Steps";
            this.colA_Steps.Name = "colA_Steps";
            this.colA_Steps.Visible = true;
            this.colA_Steps.VisibleIndex = 0;
            // 
            // colA_Status
            // 
            this.colA_Status.Caption = "Status";
            this.colA_Status.FieldName = "Status";
            this.colA_Status.Name = "colA_Status";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.accMenuTraLoi);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1057, 44);
            this.panel1.TabIndex = 0;
            // 
            // accMenuTraLoi
            // 
            this.accMenuTraLoi.Dock = System.Windows.Forms.DockStyle.Top;
            this.accMenuTraLoi.Location = new System.Drawing.Point(0, 0);
            this.accMenuTraLoi.Name = "accMenuTraLoi";
            this.accMenuTraLoi.Size = new System.Drawing.Size(1057, 42);
            this.accMenuTraLoi.TabIndex = 0;
            // 
            // ucQuanLyQuestionAnswers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.xtraTabControl1);
            this.Name = "ucQuanLyQuestionAnswers";
            this.Size = new System.Drawing.Size(1063, 488);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.tabTraLoi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlTraLoi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTraLoi)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage tabTraLoi;
        private System.Windows.Forms.Panel panel1;
        private Base.ActionMenu accMenuTraLoi;
        private DevExpress.XtraGrid.GridControl gridControlTraLoi;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewTraLoi;
        private DevExpress.XtraGrid.Columns.GridColumn colA_AID;
        private DevExpress.XtraGrid.Columns.GridColumn colA_QID;
        private DevExpress.XtraGrid.Columns.GridColumn colA_Questions;
        private DevExpress.XtraGrid.Columns.GridColumn colA_Answers;
        private DevExpress.XtraGrid.Columns.GridColumn colA_Accept;
        private DevExpress.XtraGrid.Columns.GridColumn colA_UserName;
        private DevExpress.XtraGrid.Columns.GridColumn colA_StatusAW;
        private DevExpress.XtraGrid.Columns.GridColumn colA_Steps;
        private DevExpress.XtraGrid.Columns.GridColumn colA_Status;
    }
}

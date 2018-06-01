namespace eCenterTrainning.UseControls
{
    partial class uJobTitle
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
            this.gridControlChucVu = new DevExpress.XtraGrid.GridControl();
            this.gridViewChucVu = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colChucVu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMoTa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.a = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.actionMenuChucVu = new eCenterTrainning.Base.ActionMenu();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlChucVu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewChucVu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.a)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlChucVu
            // 
            this.gridControlChucVu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlChucVu.Location = new System.Drawing.Point(0, 64);
            this.gridControlChucVu.MainView = this.gridViewChucVu;
            this.gridControlChucVu.Name = "gridControlChucVu";
            this.gridControlChucVu.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.a});
            this.gridControlChucVu.Size = new System.Drawing.Size(653, 353);
            this.gridControlChucVu.TabIndex = 9;
            this.gridControlChucVu.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewChucVu});
            this.gridControlChucVu.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.gridControlChucVu_MouseDoubleClick);
            // 
            // gridViewChucVu
            // 
            this.gridViewChucVu.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colChucVu,
            this.colMoTa});
            this.gridViewChucVu.GridControl = this.gridControlChucVu;
            this.gridViewChucVu.Name = "gridViewChucVu";
            this.gridViewChucVu.OptionsBehavior.Editable = false;
            this.gridViewChucVu.OptionsView.ShowAutoFilterRow = true;
            this.gridViewChucVu.OptionsView.ShowGroupPanel = false;
            // 
            // colId
            // 
            this.colId.Caption = "ID";
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            // 
            // colChucVu
            // 
            this.colChucVu.Caption = "Chức Vụ";
            this.colChucVu.FieldName = "JobTitle1";
            this.colChucVu.MinWidth = 15;
            this.colChucVu.Name = "colChucVu";
            this.colChucVu.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colChucVu.Visible = true;
            this.colChucVu.VisibleIndex = 0;
            this.colChucVu.Width = 160;
            // 
            // colMoTa
            // 
            this.colMoTa.Caption = "Mô Tả";
            this.colMoTa.FieldName = "Description";
            this.colMoTa.Name = "colMoTa";
            this.colMoTa.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colMoTa.Visible = true;
            this.colMoTa.VisibleIndex = 1;
            this.colMoTa.Width = 162;
            // 
            // a
            // 
            this.a.AutoHeight = false;
            this.a.Name = "a";
            // 
            // actionMenuChucVu
            // 
            this.actionMenuChucVu.Dock = System.Windows.Forms.DockStyle.Top;
            this.actionMenuChucVu.Location = new System.Drawing.Point(0, 0);
            this.actionMenuChucVu.Name = "actionMenuChucVu";
            this.actionMenuChucVu.Size = new System.Drawing.Size(653, 64);
            this.actionMenuChucVu.TabIndex = 8;
            // 
            // uJobTitle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControlChucVu);
            this.Controls.Add(this.actionMenuChucVu);
            this.Name = "uJobTitle";
            this.Size = new System.Drawing.Size(653, 417);
            this.Load += new System.EventHandler(this.uJobTitle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlChucVu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewChucVu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.a)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlChucVu;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewChucVu;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colChucVu;
        private DevExpress.XtraGrid.Columns.GridColumn colMoTa;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit a;
        private Base.ActionMenu actionMenuChucVu;
    }
}

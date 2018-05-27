namespace eCenterTrainning.UseControls
{
    partial class uCenter
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
            this.gridControlCenter = new DevExpress.XtraGrid.GridControl();
            this.gridViewCenter = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSDT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSite = new DevExpress.XtraGrid.Columns.GridColumn();
            this.actionMenuCenter = new eCenterTrainning.Base.ActionMenu();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCenter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCenter)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlCenter
            // 
            this.gridControlCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlCenter.Location = new System.Drawing.Point(0, 50);
            this.gridControlCenter.MainView = this.gridViewCenter;
            this.gridControlCenter.Name = "gridControlCenter";
            this.gridControlCenter.Size = new System.Drawing.Size(782, 460);
            this.gridControlCenter.TabIndex = 3;
            this.gridControlCenter.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewCenter});
            this.gridControlCenter.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.gridControlCenter_MouseDoubleClick);
            // 
            // gridViewCenter
            // 
            this.gridViewCenter.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colName,
            this.colSDT,
            this.colEmail,
            this.colSite});
            this.gridViewCenter.GridControl = this.gridControlCenter;
            this.gridViewCenter.Name = "gridViewCenter";
            this.gridViewCenter.OptionsBehavior.Editable = false;
            this.gridViewCenter.OptionsView.ShowAutoFilterRow = true;
            this.gridViewCenter.OptionsView.ShowGroupPanel = false;
            // 
            // colId
            // 
            this.colId.Caption = "ID";
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            // 
            // colName
            // 
            this.colName.Caption = "Tên";
            this.colName.FieldName = "CenterName";
            this.colName.Name = "colName";
            this.colName.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colName.Visible = true;
            this.colName.VisibleIndex = 0;
            // 
            // colSDT
            // 
            this.colSDT.Caption = "Điện thoại";
            this.colSDT.FieldName = "Phone";
            this.colSDT.Name = "colSDT";
            this.colSDT.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colSDT.Visible = true;
            this.colSDT.VisibleIndex = 1;
            // 
            // colEmail
            // 
            this.colEmail.Caption = "Email";
            this.colEmail.FieldName = "Email";
            this.colEmail.Name = "colEmail";
            this.colEmail.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colEmail.Visible = true;
            this.colEmail.VisibleIndex = 2;
            // 
            // colSite
            // 
            this.colSite.Caption = "Website";
            this.colSite.FieldName = "Website";
            this.colSite.Name = "colSite";
            this.colSite.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colSite.Visible = true;
            this.colSite.VisibleIndex = 3;
            // 
            // actionMenuCenter
            // 
            this.actionMenuCenter.Dock = System.Windows.Forms.DockStyle.Top;
            this.actionMenuCenter.Location = new System.Drawing.Point(0, 0);
            this.actionMenuCenter.Name = "actionMenuCenter";
            this.actionMenuCenter.Size = new System.Drawing.Size(782, 50);
            this.actionMenuCenter.TabIndex = 2;
            this.actionMenuCenter.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.gridControlCenter_MouseDoubleClick);
            // 
            // uCenter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControlCenter);
            this.Controls.Add(this.actionMenuCenter);
            this.Name = "uCenter";
            this.Size = new System.Drawing.Size(782, 510);
            this.Load += new System.EventHandler(this.uCenter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCenter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCenter)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlCenter;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewCenter;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colSDT;
        private DevExpress.XtraGrid.Columns.GridColumn colEmail;
        private DevExpress.XtraGrid.Columns.GridColumn colSite;
        private Base.ActionMenu actionMenuCenter;
    }
}

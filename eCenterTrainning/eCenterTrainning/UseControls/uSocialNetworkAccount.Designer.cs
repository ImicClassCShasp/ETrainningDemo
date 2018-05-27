namespace eCenterTrainning.UseControls
{
    partial class uSocialNetworkAccount
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
            this.actionMenuSocialNetworkAccount = new eCenterTrainning.Base.ActionMenu();
            this.gridControlSocialNetworkAccount = new DevExpress.XtraGrid.GridControl();
            this.gridViewSocialNetworkAccount = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCategory = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTitle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAccountName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldPassword = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUserId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLinkName = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlSocialNetworkAccount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSocialNetworkAccount)).BeginInit();
            this.SuspendLayout();
            // 
            // actionMenuSocialNetworkAccount
            // 
            this.actionMenuSocialNetworkAccount.Dock = System.Windows.Forms.DockStyle.Top;
            this.actionMenuSocialNetworkAccount.Location = new System.Drawing.Point(0, 0);
            this.actionMenuSocialNetworkAccount.Name = "actionMenuSocialNetworkAccount";
            this.actionMenuSocialNetworkAccount.Size = new System.Drawing.Size(760, 50);
            this.actionMenuSocialNetworkAccount.TabIndex = 0;
            // 
            // gridControlSocialNetworkAccount
            // 
            this.gridControlSocialNetworkAccount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlSocialNetworkAccount.Location = new System.Drawing.Point(0, 50);
            this.gridControlSocialNetworkAccount.MainView = this.gridViewSocialNetworkAccount;
            this.gridControlSocialNetworkAccount.Name = "gridControlSocialNetworkAccount";
            this.gridControlSocialNetworkAccount.Size = new System.Drawing.Size(760, 459);
            this.gridControlSocialNetworkAccount.TabIndex = 1;
            this.gridControlSocialNetworkAccount.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewSocialNetworkAccount});
            // 
            // gridViewSocialNetworkAccount
            // 
            this.gridViewSocialNetworkAccount.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colCategory,
            this.colTitle,
            this.colAccountName,
            this.coldPassword,
            this.colDescription,
            this.colUserId,
            this.colLinkName});
            this.gridViewSocialNetworkAccount.GridControl = this.gridControlSocialNetworkAccount;
            this.gridViewSocialNetworkAccount.Name = "gridViewSocialNetworkAccount";
            this.gridViewSocialNetworkAccount.OptionsBehavior.Editable = false;
            this.gridViewSocialNetworkAccount.OptionsView.ShowAutoFilterRow = true;
            this.gridViewSocialNetworkAccount.OptionsView.ShowFooter = true;
            this.gridViewSocialNetworkAccount.OptionsView.ShowGroupPanel = false;
            // 
            // colId
            // 
            this.colId.Caption = "Id";
            this.colId.Name = "colId";
            // 
            // colCategory
            // 
            this.colCategory.Caption = "Danh Mục";
            this.colCategory.FieldName = "SocialNetworkCategory.CategoryName";
            this.colCategory.Name = "colCategory";
            this.colCategory.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colCategory.Visible = true;
            this.colCategory.VisibleIndex = 0;
            // 
            // colTitle
            // 
            this.colTitle.Caption = "Tiêu Đề";
            this.colTitle.FieldName = "Title";
            this.colTitle.Name = "colTitle";
            this.colTitle.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colTitle.Visible = true;
            this.colTitle.VisibleIndex = 1;
            // 
            // colAccountName
            // 
            this.colAccountName.Caption = "Tài Khoản";
            this.colAccountName.FieldName = "AccountName";
            this.colAccountName.Name = "colAccountName";
            this.colAccountName.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colAccountName.Visible = true;
            this.colAccountName.VisibleIndex = 2;
            // 
            // coldPassword
            // 
            this.coldPassword.Caption = "Mật Khẩu";
            this.coldPassword.FieldName = "Password";
            this.coldPassword.Name = "coldPassword";
            this.coldPassword.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.coldPassword.Visible = true;
            this.coldPassword.VisibleIndex = 3;
            // 
            // colDescription
            // 
            this.colDescription.Caption = "Mô Tả";
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            // 
            // colUserId
            // 
            this.colUserId.Caption = "Người thêm";
            this.colUserId.Name = "colUserId";
            this.colUserId.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            // 
            // colLinkName
            // 
            this.colLinkName.Caption = "Đường Dẫn";
            this.colLinkName.FieldName = "LinkName";
            this.colLinkName.Name = "colLinkName";
            this.colLinkName.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colLinkName.Visible = true;
            this.colLinkName.VisibleIndex = 5;
            // 
            // uSocialNetworkAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControlSocialNetworkAccount);
            this.Controls.Add(this.actionMenuSocialNetworkAccount);
            this.Name = "uSocialNetworkAccount";
            this.Size = new System.Drawing.Size(760, 509);
            this.Load += new System.EventHandler(this.uSocialNetworkAccount_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlSocialNetworkAccount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSocialNetworkAccount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Base.ActionMenu actionMenuSocialNetworkAccount;
        private DevExpress.XtraGrid.GridControl gridControlSocialNetworkAccount;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewSocialNetworkAccount;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colCategory;
        private DevExpress.XtraGrid.Columns.GridColumn colTitle;
        private DevExpress.XtraGrid.Columns.GridColumn colAccountName;
        private DevExpress.XtraGrid.Columns.GridColumn coldPassword;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colUserId;
        private DevExpress.XtraGrid.Columns.GridColumn colLinkName;
    }
}

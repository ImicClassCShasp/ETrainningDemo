namespace eCenterTrainning.UseControls
{
    partial class uCustomers
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
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.actionMenuCustomers = new eCenterTrainning.Base.ActionMenu();
            this.gridViewCustomer = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHoTen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSex = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiDong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiaChi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControlCustomer = new DevExpress.XtraGrid.GridControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // gridView1
            // 
            this.gridView1.Name = "gridView1";
            // 
            // actionMenuCustomers
            // 
            this.actionMenuCustomers.Dock = System.Windows.Forms.DockStyle.Top;
            this.actionMenuCustomers.Location = new System.Drawing.Point(0, 0);
            this.actionMenuCustomers.Name = "actionMenuCustomers";
            this.actionMenuCustomers.Size = new System.Drawing.Size(730, 50);
            this.actionMenuCustomers.TabIndex = 5;
            // 
            // gridViewCustomer
            // 
            this.gridViewCustomer.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colHoTen,
            this.colSex,
            this.colDiDong,
            this.col,
            this.colEmail,
            this.colDiaChi});
            this.gridViewCustomer.GridControl = this.gridControlCustomer;
            this.gridViewCustomer.Name = "gridViewCustomer";
            this.gridViewCustomer.OptionsBehavior.Editable = false;
            this.gridViewCustomer.OptionsView.ShowAutoFilterRow = true;
            this.gridViewCustomer.OptionsView.ShowFooter = true;
            this.gridViewCustomer.OptionsView.ShowGroupPanel = false;
            // 
            // colId
            // 
            this.colId.Caption = "Id";
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            // 
            // colHoTen
            // 
            this.colHoTen.Caption = "Tên KH";
            this.colHoTen.FieldName = "FullName";
            this.colHoTen.Name = "colHoTen";
            this.colHoTen.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colHoTen.Visible = true;
            this.colHoTen.VisibleIndex = 0;
            this.colHoTen.Width = 120;
            // 
            // colSex
            // 
            this.colSex.Caption = "Giới Tính";
            this.colSex.FieldName = "Sex";
            this.colSex.Name = "colSex";
            this.colSex.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colSex.Visible = true;
            this.colSex.VisibleIndex = 1;
            this.colSex.Width = 53;
            // 
            // colDiDong
            // 
            this.colDiDong.Caption = "Di động";
            this.colDiDong.FieldName = "Mobile";
            this.colDiDong.Name = "colDiDong";
            this.colDiDong.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colDiDong.Visible = true;
            this.colDiDong.VisibleIndex = 2;
            this.colDiDong.Width = 87;
            // 
            // col
            // 
            this.col.Caption = "Điện thoại CĐ";
            this.col.FieldName = "Phone";
            this.col.Name = "col";
            this.col.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.col.Visible = true;
            this.col.VisibleIndex = 3;
            this.col.Width = 90;
            // 
            // colEmail
            // 
            this.colEmail.Caption = "Hòm thư";
            this.colEmail.FieldName = "Email";
            this.colEmail.Name = "colEmail";
            this.colEmail.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colEmail.Visible = true;
            this.colEmail.VisibleIndex = 4;
            this.colEmail.Width = 139;
            // 
            // colDiaChi
            // 
            this.colDiaChi.Caption = "Địa chỉ";
            this.colDiaChi.FieldName = "Address";
            this.colDiaChi.Name = "colDiaChi";
            this.colDiaChi.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colDiaChi.Visible = true;
            this.colDiaChi.VisibleIndex = 5;
            this.colDiaChi.Width = 220;
            // 
            // gridControlCustomer
            // 
            this.gridControlCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlCustomer.Location = new System.Drawing.Point(0, 50);
            this.gridControlCustomer.MainView = this.gridViewCustomer;
            this.gridControlCustomer.Name = "gridControlCustomer";
            this.gridControlCustomer.Size = new System.Drawing.Size(730, 418);
            this.gridControlCustomer.TabIndex = 7;
            this.gridControlCustomer.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewCustomer});
            this.gridControlCustomer.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.gridControlCustomer_MouseDoubleClick);
            // 
            // uCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControlCustomer);
            this.Controls.Add(this.actionMenuCustomers);
            this.Name = "uCustomers";
            this.Size = new System.Drawing.Size(730, 468);
            this.Load += new System.EventHandler(this.uCustomers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCustomer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private Base.ActionMenu actionMenuCustomers;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewCustomer;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colHoTen;
        private DevExpress.XtraGrid.Columns.GridColumn colSex;
        private DevExpress.XtraGrid.Columns.GridColumn colDiDong;
        private DevExpress.XtraGrid.Columns.GridColumn col;
        private DevExpress.XtraGrid.Columns.GridColumn colEmail;
        private DevExpress.XtraGrid.Columns.GridColumn colDiaChi;
        private DevExpress.XtraGrid.GridControl gridControlCustomer;


    }
}

namespace eCenterTrainning.UseControls
{
    partial class uListUsers
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
            this.actionMenuUsers = new eCenterTrainning.Base.ActionMenu();
            this.groupControlTimKiem = new DevExpress.XtraEditors.GroupControl();
            this.btnTimKiem = new DevExpress.XtraEditors.SimpleButton();
            this.txtTuKhoa = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gridControlUser = new DevExpress.XtraGrid.GridControl();
            this.gridViewUser = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHoTen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSex = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiaChi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSDT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPhongBan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTaiKhoan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEditSexEmp = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlTimKiem)).BeginInit();
            this.groupControlTimKiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTuKhoa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEditSexEmp)).BeginInit();
            this.SuspendLayout();
            // 
            // actionMenuUsers
            // 
            this.actionMenuUsers.Dock = System.Windows.Forms.DockStyle.Top;
            this.actionMenuUsers.Location = new System.Drawing.Point(0, 0);
            this.actionMenuUsers.Name = "actionMenuUsers";
            this.actionMenuUsers.Size = new System.Drawing.Size(748, 50);
            this.actionMenuUsers.TabIndex = 0;
            // 
            // groupControlTimKiem
            // 
            this.groupControlTimKiem.Controls.Add(this.btnTimKiem);
            this.groupControlTimKiem.Controls.Add(this.txtTuKhoa);
            this.groupControlTimKiem.Controls.Add(this.labelControl1);
            this.groupControlTimKiem.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControlTimKiem.Location = new System.Drawing.Point(0, 50);
            this.groupControlTimKiem.Name = "groupControlTimKiem";
            this.groupControlTimKiem.Size = new System.Drawing.Size(748, 65);
            this.groupControlTimKiem.TabIndex = 3;
            this.groupControlTimKiem.Text = "Thông tin người dùng";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.ImageOptions.Image = global::eCenterTrainning.Properties.Resources.search;
            this.btnTimKiem.Location = new System.Drawing.Point(497, 31);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(75, 23);
            this.btnTimKiem.TabIndex = 2;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtTuKhoa
            // 
            this.txtTuKhoa.Location = new System.Drawing.Point(85, 32);
            this.txtTuKhoa.Name = "txtTuKhoa";
            this.txtTuKhoa.Size = new System.Drawing.Size(405, 20);
            this.txtTuKhoa.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(33, 36);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(46, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Từ khóa :";
            // 
            // gridControlUser
            // 
            this.gridControlUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlUser.Location = new System.Drawing.Point(0, 115);
            this.gridControlUser.MainView = this.gridViewUser;
            this.gridControlUser.Name = "gridControlUser";
            this.gridControlUser.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEditSexEmp});
            this.gridControlUser.Size = new System.Drawing.Size(748, 305);
            this.gridControlUser.TabIndex = 4;
            this.gridControlUser.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewUser});
            // 
            // gridViewUser
            // 
            this.gridViewUser.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colHoTen,
            this.colSex,
            this.colDiaChi,
            this.colEmail,
            this.colSDT,
            this.colPhongBan,
            this.colTaiKhoan});
            this.gridViewUser.GridControl = this.gridControlUser;
            this.gridViewUser.Name = "gridViewUser";
            this.gridViewUser.OptionsBehavior.Editable = false;
            this.gridViewUser.OptionsView.ShowAutoFilterRow = true;
            this.gridViewUser.OptionsView.ShowFooter = true;
            this.gridViewUser.OptionsView.ShowGroupPanel = false;
            // 
            // colID
            // 
            this.colID.Caption = "ID";
            this.colID.FieldName = "UserId";
            this.colID.Name = "colID";
            // 
            // colHoTen
            // 
            this.colHoTen.Caption = "Tên Hiển Thị";
            this.colHoTen.FieldName = "DisplayName";
            this.colHoTen.Name = "colHoTen";
            this.colHoTen.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colHoTen.Visible = true;
            this.colHoTen.VisibleIndex = 0;
            this.colHoTen.Width = 154;
            // 
            // colSex
            // 
            this.colSex.Caption = "Giới Tính";
            this.colSex.FieldName = "DisplaySex";
            this.colSex.Name = "colSex";
            this.colSex.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colSex.Visible = true;
            this.colSex.VisibleIndex = 1;
            this.colSex.Width = 60;
            // 
            // colDiaChi
            // 
            this.colDiaChi.Caption = "Địa Chỉ";
            this.colDiaChi.FieldName = "Address";
            this.colDiaChi.Name = "colDiaChi";
            this.colDiaChi.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colDiaChi.Visible = true;
            this.colDiaChi.VisibleIndex = 2;
            this.colDiaChi.Width = 105;
            // 
            // colEmail
            // 
            this.colEmail.Caption = "Email";
            this.colEmail.FieldName = "Email";
            this.colEmail.Name = "colEmail";
            this.colEmail.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colEmail.Visible = true;
            this.colEmail.VisibleIndex = 3;
            this.colEmail.Width = 105;
            // 
            // colSDT
            // 
            this.colSDT.Caption = "Di Động";
            this.colSDT.FieldName = "Phone";
            this.colSDT.Name = "colSDT";
            this.colSDT.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colSDT.Visible = true;
            this.colSDT.VisibleIndex = 4;
            this.colSDT.Width = 105;
            // 
            // colPhongBan
            // 
            this.colPhongBan.Caption = "Phòng Ban";
            this.colPhongBan.FieldName = "OuName";
            this.colPhongBan.Name = "colPhongBan";
            this.colPhongBan.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colPhongBan.Visible = true;
            this.colPhongBan.VisibleIndex = 5;
            this.colPhongBan.Width = 116;
            // 
            // colTaiKhoan
            // 
            this.colTaiKhoan.Caption = "Loại Tài Khoản";
            this.colTaiKhoan.Name = "colTaiKhoan";
            this.colTaiKhoan.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colTaiKhoan.Visible = true;
            this.colTaiKhoan.VisibleIndex = 6;
            this.colTaiKhoan.Width = 85;
            // 
            // repositoryItemCheckEditSexEmp
            // 
            this.repositoryItemCheckEditSexEmp.AutoHeight = false;
            this.repositoryItemCheckEditSexEmp.Name = "repositoryItemCheckEditSexEmp";
            // 
            // uListUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControlUser);
            this.Controls.Add(this.groupControlTimKiem);
            this.Controls.Add(this.actionMenuUsers);
            this.Name = "uListUsers";
            this.Size = new System.Drawing.Size(748, 420);
            this.Load += new System.EventHandler(this.uEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControlTimKiem)).EndInit();
            this.groupControlTimKiem.ResumeLayout(false);
            this.groupControlTimKiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTuKhoa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEditSexEmp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Base.ActionMenu actionMenuUsers;
        private DevExpress.XtraEditors.GroupControl groupControlTimKiem;
        private DevExpress.XtraEditors.SimpleButton btnTimKiem;
        private DevExpress.XtraEditors.TextEdit txtTuKhoa;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl gridControlUser;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewUser;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colHoTen;
        private DevExpress.XtraGrid.Columns.GridColumn colDiaChi;
        private DevExpress.XtraGrid.Columns.GridColumn colEmail;
        private DevExpress.XtraGrid.Columns.GridColumn colSDT;
        private DevExpress.XtraGrid.Columns.GridColumn colPhongBan;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEditSexEmp;
        private DevExpress.XtraGrid.Columns.GridColumn colTaiKhoan;
        private DevExpress.XtraGrid.Columns.GridColumn colSex;
    }
}

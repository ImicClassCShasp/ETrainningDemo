namespace eCenterTrainning
{
    partial class frmHocVienSearch
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
            this.gridControlHVHeThong = new DevExpress.XtraGrid.GridControl();
            this.gridViewHVHeThong = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ColId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColHoTen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColMobile = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateCreate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUserName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCourseName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStatusName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblStart = new System.Windows.Forms.Label();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.msgMessage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlHVHeThong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewHVHeThong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.gridControlHVHeThong);
            this.groupControl1.Controls.Add(this.panelControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(885, 475);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Lựa chọn ngày bắt đầu, ngày kết thúc và bấm tìm kiếm";
            // 
            // gridControlHVHeThong
            // 
            this.gridControlHVHeThong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlHVHeThong.Location = new System.Drawing.Point(2, 54);
            this.gridControlHVHeThong.MainView = this.gridViewHVHeThong;
            this.gridControlHVHeThong.Name = "gridControlHVHeThong";
            this.gridControlHVHeThong.Size = new System.Drawing.Size(881, 419);
            this.gridControlHVHeThong.TabIndex = 2;
            this.gridControlHVHeThong.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewHVHeThong});
            // 
            // gridViewHVHeThong
            // 
            this.gridViewHVHeThong.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ColId,
            this.ColHoTen,
            this.ColEmail,
            this.ColMobile,
            this.ColAddress,
            this.colDateCreate,
            this.colUserName,
            this.colCourseName,
            this.colStatusName});
            this.gridViewHVHeThong.GridControl = this.gridControlHVHeThong;
            this.gridViewHVHeThong.Name = "gridViewHVHeThong";
            this.gridViewHVHeThong.OptionsBehavior.Editable = false;
            this.gridViewHVHeThong.OptionsView.ShowAutoFilterRow = true;
            this.gridViewHVHeThong.OptionsView.ShowFooter = true;
            this.gridViewHVHeThong.OptionsView.ShowGroupPanel = false;
            // 
            // ColId
            // 
            this.ColId.Caption = "Id";
            this.ColId.FieldName = "Id";
            this.ColId.Name = "ColId";
            // 
            // ColHoTen
            // 
            this.ColHoTen.Caption = "Họ tên";
            this.ColHoTen.FieldName = "FullName";
            this.ColHoTen.MinWidth = 100;
            this.ColHoTen.Name = "ColHoTen";
            this.ColHoTen.Visible = true;
            this.ColHoTen.VisibleIndex = 0;
            this.ColHoTen.Width = 141;
            // 
            // ColEmail
            // 
            this.ColEmail.Caption = "Email";
            this.ColEmail.FieldName = "Email";
            this.ColEmail.Name = "ColEmail";
            this.ColEmail.Visible = true;
            this.ColEmail.VisibleIndex = 2;
            this.ColEmail.Width = 123;
            // 
            // ColMobile
            // 
            this.ColMobile.Caption = "Di động";
            this.ColMobile.FieldName = "Mobile";
            this.ColMobile.Name = "ColMobile";
            this.ColMobile.Visible = true;
            this.ColMobile.VisibleIndex = 3;
            this.ColMobile.Width = 133;
            // 
            // ColAddress
            // 
            this.ColAddress.Caption = "Địa chỉ";
            this.ColAddress.FieldName = "Address";
            this.ColAddress.Name = "ColAddress";
            this.ColAddress.Visible = true;
            this.ColAddress.VisibleIndex = 1;
            this.ColAddress.Width = 123;
            // 
            // colDateCreate
            // 
            this.colDateCreate.Caption = "Ngày ĐK";
            this.colDateCreate.FieldName = "DateCreate";
            this.colDateCreate.Name = "colDateCreate";
            this.colDateCreate.Visible = true;
            this.colDateCreate.VisibleIndex = 4;
            this.colDateCreate.Width = 98;
            // 
            // colUserName
            // 
            this.colUserName.Caption = "Tư vấn";
            this.colUserName.FieldName = "UserName";
            this.colUserName.Name = "colUserName";
            this.colUserName.Visible = true;
            this.colUserName.VisibleIndex = 5;
            this.colUserName.Width = 97;
            // 
            // colCourseName
            // 
            this.colCourseName.Caption = "Khóa học";
            this.colCourseName.FieldName = "CourseName";
            this.colCourseName.Name = "colCourseName";
            this.colCourseName.Visible = true;
            this.colCourseName.VisibleIndex = 6;
            this.colCourseName.Width = 127;
            // 
            // colStatusName
            // 
            this.colStatusName.Caption = "Trạng thái";
            this.colStatusName.FieldName = "StatusName";
            this.colStatusName.Name = "colStatusName";
            this.colStatusName.Visible = true;
            this.colStatusName.VisibleIndex = 7;
            this.colStatusName.Width = 100;
            // 
            // panelControl1
            // 
            this.panelControl1.AutoSize = true;
            this.panelControl1.Controls.Add(this.btnSearch);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Controls.Add(this.lblStart);
            this.panelControl1.Controls.Add(this.dtpEnd);
            this.panelControl1.Controls.Add(this.dtpStart);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(2, 20);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(881, 34);
            this.panelControl1.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(429, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(116, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(228, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ngày kết thúc";
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Location = new System.Drawing.Point(19, 11);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(72, 13);
            this.lblStart.TabIndex = 1;
            this.lblStart.Text = "Ngày bắt đầu";
            // 
            // dtpEnd
            // 
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEnd.Location = new System.Drawing.Point(312, 5);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(111, 21);
            this.dtpEnd.TabIndex = 0;
            // 
            // dtpStart
            // 
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStart.Location = new System.Drawing.Point(97, 5);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(111, 21);
            this.dtpStart.TabIndex = 0;
            // 
            // frmHocVienSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 475);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmHocVienSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmHocVienHeThong";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmHocVienSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.msgMessage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlHVHeThong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewHVHeThong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        
        
        private DevExpress.XtraGrid.GridControl gridControlHVHeThong;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewHVHeThong;
        private DevExpress.XtraGrid.Columns.GridColumn ColId;
        private DevExpress.XtraGrid.Columns.GridColumn ColHoTen;
        private DevExpress.XtraGrid.Columns.GridColumn ColAddress;
        private DevExpress.XtraGrid.Columns.GridColumn ColEmail;
        private DevExpress.XtraGrid.Columns.GridColumn ColMobile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.Button btnSearch;
        private DevExpress.XtraGrid.Columns.GridColumn colDateCreate;
        private DevExpress.XtraGrid.Columns.GridColumn colUserName;
        private DevExpress.XtraGrid.Columns.GridColumn colCourseName;
        private DevExpress.XtraGrid.Columns.GridColumn colStatusName;
    }
}
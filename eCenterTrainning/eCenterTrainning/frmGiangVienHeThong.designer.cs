namespace eCenterTrainning
{
    partial class frmGiangVienHeThong
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnGiangVien = new DevExpress.XtraEditors.SimpleButton();
            this.gridControlGiangVien = new DevExpress.XtraGrid.GridControl();
            this.gridViewGiangVien = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ColId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColDateBirthday = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColMobile = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.msgMessage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlGiangVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewGiangVien)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnGiangVien);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(672, 47);
            this.panelControl1.TabIndex = 0;
            // 
            // btnGiangVien
            // 
            this.btnGiangVien.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGiangVien.Appearance.Options.UseFont = true;
            this.btnGiangVien.ImageOptions.Image = global::eCenterTrainning.Properties.Resources.add_icon;
            this.btnGiangVien.Location = new System.Drawing.Point(12, 12);
            this.btnGiangVien.Name = "btnGiangVien";
            this.btnGiangVien.Size = new System.Drawing.Size(608, 23);
            this.btnGiangVien.TabIndex = 2;
            this.btnGiangVien.Text = "Chọn Chuyên gia phụ trách lớp";
            this.btnGiangVien.Visible = false;
            this.btnGiangVien.Click += new System.EventHandler(this.btnGiangVien_Click);
            // 
            // gridControlGiangVien
            // 
            this.gridControlGiangVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlGiangVien.Location = new System.Drawing.Point(0, 47);
            this.gridControlGiangVien.MainView = this.gridViewGiangVien;
            this.gridControlGiangVien.Name = "gridControlGiangVien";
            this.gridControlGiangVien.Size = new System.Drawing.Size(672, 261);
            this.gridControlGiangVien.TabIndex = 3;
            this.gridControlGiangVien.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewGiangVien});
            this.gridControlGiangVien.Click += new System.EventHandler(this.gridControlGiangVien_Click);
            // 
            // gridViewGiangVien
            // 
            this.gridViewGiangVien.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ColId,
            this.ColName,
            this.ColDateBirthday,
            this.ColEmail,
            this.ColMobile,
            this.ColAddress});
            this.gridViewGiangVien.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridViewGiangVien.GridControl = this.gridControlGiangVien;
            this.gridViewGiangVien.Name = "gridViewGiangVien";
            this.gridViewGiangVien.OptionsBehavior.Editable = false;
            this.gridViewGiangVien.OptionsView.ShowAutoFilterRow = true;
            this.gridViewGiangVien.OptionsView.ShowFooter = true;
            this.gridViewGiangVien.OptionsView.ShowGroupPanel = false;
            // 
            // ColId
            // 
            this.ColId.Caption = "Id";
            this.ColId.FieldName = "Id";
            this.ColId.Name = "ColId";
            // 
            // ColName
            // 
            this.ColName.Caption = "Giảng viên";
            this.ColName.FieldName = "ExpertName";
            this.ColName.Name = "ColName";
            this.ColName.Visible = true;
            this.ColName.VisibleIndex = 0;
            // 
            // ColDateBirthday
            // 
            this.ColDateBirthday.Caption = "Ngày sinh";
            this.ColDateBirthday.FieldName = "DateBirthday";
            this.ColDateBirthday.Name = "ColDateBirthday";
            this.ColDateBirthday.Visible = true;
            this.ColDateBirthday.VisibleIndex = 1;
            // 
            // ColEmail
            // 
            this.ColEmail.Caption = "Email";
            this.ColEmail.FieldName = "Email";
            this.ColEmail.Name = "ColEmail";
            this.ColEmail.Visible = true;
            this.ColEmail.VisibleIndex = 2;
            // 
            // ColMobile
            // 
            this.ColMobile.Caption = "Mobile";
            this.ColMobile.FieldName = "Mobile";
            this.ColMobile.Name = "ColMobile";
            this.ColMobile.Visible = true;
            this.ColMobile.VisibleIndex = 3;
            // 
            // ColAddress
            // 
            this.ColAddress.Caption = "Địa chỉ";
            this.ColAddress.FieldName = "Address";
            this.ColAddress.Name = "ColAddress";
            this.ColAddress.Visible = true;
            this.ColAddress.VisibleIndex = 4;
            // 
            // frmGiangVienHeThong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 308);
            this.Controls.Add(this.gridControlGiangVien);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmGiangVienHeThong";
            this.Text = "frmGiangVienHeThong";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmGiangVienHeThong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.msgMessage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlGiangVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewGiangVien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnGiangVien;
        private DevExpress.XtraGrid.GridControl gridControlGiangVien;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewGiangVien;
        private DevExpress.XtraGrid.Columns.GridColumn ColId;
        private DevExpress.XtraGrid.Columns.GridColumn ColName;
        private DevExpress.XtraGrid.Columns.GridColumn ColDateBirthday;
        private DevExpress.XtraGrid.Columns.GridColumn ColEmail;
        private DevExpress.XtraGrid.Columns.GridColumn ColMobile;
        private DevExpress.XtraGrid.Columns.GridColumn ColAddress;
    }
}
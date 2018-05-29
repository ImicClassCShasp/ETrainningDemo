namespace eCenterTrainning.UseControls
{
    partial class uViewSchedulesInfo
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uViewSchedulesInfo));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.actionMenuSchedule = new eCenterTrainning.Base.ActionMenu();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnXemLichGiangDay = new DevExpress.XtraEditors.SimpleButton();
            this.uluThongTinChuyenGia = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.grdControlLichGiangday = new DevExpress.XtraGrid.GridControl();
            this.grdViewLichGiangday = new DevExpress.XtraGrid.Views.Card.CardView();
            this.Id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ClassId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ClassName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ExpertId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ExpertName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CourseId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CourseName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DayOf = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DayOfWeed = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TimeOf = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Status = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bandedGridView1 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridView();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uluThongTinChuyenGia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdControlLichGiangday)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdViewLichGiangday)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandedGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "002.png");
            // 
            // actionMenuSchedule
            // 
            this.actionMenuSchedule.Dock = System.Windows.Forms.DockStyle.Top;
            this.actionMenuSchedule.Location = new System.Drawing.Point(0, 0);
            this.actionMenuSchedule.Name = "actionMenuSchedule";
            this.actionMenuSchedule.Size = new System.Drawing.Size(832, 48);
            this.actionMenuSchedule.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnXemLichGiangDay);
            this.groupBox1.Controls.Add(this.uluThongTinChuyenGia);
            this.groupBox1.Controls.Add(this.labelControl1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(832, 61);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin Chuyên Gia cần xem thông tin";
            // 
            // btnXemLichGiangDay
            // 
            this.btnXemLichGiangDay.Image = global::eCenterTrainning.Properties.Resources._007;
            this.btnXemLichGiangDay.Location = new System.Drawing.Point(463, 23);
            this.btnXemLichGiangDay.Name = "btnXemLichGiangDay";
            this.btnXemLichGiangDay.Size = new System.Drawing.Size(208, 23);
            this.btnXemLichGiangDay.TabIndex = 2;
            this.btnXemLichGiangDay.Text = "Xem Lịch Giảng dạy của Chuyên Gia";
            this.btnXemLichGiangDay.Click += new System.EventHandler(this.btnXemLichGiangDay_Click);
            // 
            // uluThongTinChuyenGia
            // 
            this.uluThongTinChuyenGia.Location = new System.Drawing.Point(134, 22);
            this.uluThongTinChuyenGia.Name = "uluThongTinChuyenGia";
            this.uluThongTinChuyenGia.Properties.Appearance.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uluThongTinChuyenGia.Properties.Appearance.Options.UseFont = true;
            this.uluThongTinChuyenGia.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.uluThongTinChuyenGia.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Id", "Id", 20, DevExpress.Utils.FormatType.Custom, "", false, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ExpertName", "ExpertName", 150, DevExpress.Utils.FormatType.Custom, "", true, DevExpress.Utils.HorzAlignment.Default)});
            this.uluThongTinChuyenGia.Properties.NullText = "---- Chọn Chuyên Gia cần xem ----";
            this.uluThongTinChuyenGia.Size = new System.Drawing.Size(323, 24);
            this.uluThongTinChuyenGia.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(19, 25);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(109, 17);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Chọn Chuyên Gia:";
            // 
            // grdControlLichGiangday
            // 
            this.grdControlLichGiangday.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdControlLichGiangday.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdControlLichGiangday.Location = new System.Drawing.Point(0, 109);
            this.grdControlLichGiangday.MainView = this.grdViewLichGiangday;
            this.grdControlLichGiangday.Name = "grdControlLichGiangday";
            this.grdControlLichGiangday.Size = new System.Drawing.Size(832, 327);
            this.grdControlLichGiangday.TabIndex = 3;
            this.grdControlLichGiangday.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdViewLichGiangday,
            this.bandedGridView1});
            this.grdControlLichGiangday.DoubleClick += new System.EventHandler(this.grdControlLichGiangday_DoubleClick);
            // 
            // grdViewLichGiangday
            // 
            this.grdViewLichGiangday.Appearance.CardCaption.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdViewLichGiangday.Appearance.CardCaption.ForeColor = System.Drawing.Color.DodgerBlue;
            this.grdViewLichGiangday.Appearance.CardCaption.Options.UseFont = true;
            this.grdViewLichGiangday.Appearance.CardCaption.Options.UseForeColor = true;
            this.grdViewLichGiangday.Appearance.FieldCaption.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdViewLichGiangday.Appearance.FieldCaption.Options.UseFont = true;
            this.grdViewLichGiangday.Appearance.FieldValue.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdViewLichGiangday.Appearance.FieldValue.Options.UseFont = true;
            this.grdViewLichGiangday.Appearance.FocusedCardCaption.Font = new System.Drawing.Font("Cambria", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdViewLichGiangday.Appearance.FocusedCardCaption.ForeColor = System.Drawing.Color.Red;
            this.grdViewLichGiangday.Appearance.FocusedCardCaption.Options.UseFont = true;
            this.grdViewLichGiangday.Appearance.FocusedCardCaption.Options.UseForeColor = true;
            this.grdViewLichGiangday.Appearance.SelectedCardCaption.Font = new System.Drawing.Font("Cambria", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdViewLichGiangday.Appearance.SelectedCardCaption.ForeColor = System.Drawing.Color.Red;
            this.grdViewLichGiangday.Appearance.SelectedCardCaption.Options.UseFont = true;
            this.grdViewLichGiangday.Appearance.SelectedCardCaption.Options.UseForeColor = true;
            this.grdViewLichGiangday.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Id,
            this.ClassId,
            this.ClassName,
            this.ExpertId,
            this.ExpertName,
            this.CourseId,
            this.CourseName,
            this.DayOf,
            this.DayOfWeed,
            this.TimeOf,
            this.Status});
            this.grdViewLichGiangday.FocusedCardTopFieldIndex = 0;
            this.grdViewLichGiangday.GridControl = this.grdControlLichGiangday;
            this.grdViewLichGiangday.Name = "grdViewLichGiangday";
            this.grdViewLichGiangday.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Auto;
            this.grdViewLichGiangday.CustomDrawCardCaption += new DevExpress.XtraGrid.Views.Card.CardCaptionCustomDrawEventHandler(this.grdViewLichGiangday_CustomDrawCardCaption);
            // 
            // Id
            // 
            this.Id.Caption = "Id";
            this.Id.FieldName = "Id";
            this.Id.Name = "Id";
            // 
            // ClassId
            // 
            this.ClassId.Caption = "ClassId";
            this.ClassId.FieldName = "ClassId";
            this.ClassId.Name = "ClassId";
            // 
            // ClassName
            // 
            this.ClassName.Caption = "Tên lớp";
            this.ClassName.FieldName = "ClassName";
            this.ClassName.Name = "ClassName";
            this.ClassName.Visible = true;
            this.ClassName.VisibleIndex = 0;
            this.ClassName.Width = 80;
            // 
            // ExpertId
            // 
            this.ExpertId.Caption = "ExpertId";
            this.ExpertId.FieldName = "ExpertId";
            this.ExpertId.Name = "ExpertId";
            // 
            // ExpertName
            // 
            this.ExpertName.Caption = "Tên Chuyên Gia";
            this.ExpertName.FieldName = "ExpertName";
            this.ExpertName.Name = "ExpertName";
            this.ExpertName.Visible = true;
            this.ExpertName.VisibleIndex = 1;
            this.ExpertName.Width = 80;
            // 
            // CourseId
            // 
            this.CourseId.Caption = "CourseId";
            this.CourseId.FieldName = "CourseId";
            this.CourseId.Name = "CourseId";
            // 
            // CourseName
            // 
            this.CourseName.Caption = "Tên Khóa Học";
            this.CourseName.FieldName = "CourseName";
            this.CourseName.Name = "CourseName";
            this.CourseName.Visible = true;
            this.CourseName.VisibleIndex = 2;
            this.CourseName.Width = 80;
            // 
            // DayOf
            // 
            this.DayOf.Caption = "Buổi học";
            this.DayOf.FieldName = "DayOf";
            this.DayOf.Name = "DayOf";
            this.DayOf.Visible = true;
            this.DayOf.VisibleIndex = 3;
            this.DayOf.Width = 60;
            // 
            // DayOfWeed
            // 
            this.DayOfWeed.Caption = "Ngày học/tuần";
            this.DayOfWeed.FieldName = "DayOfWeed";
            this.DayOfWeed.Name = "DayOfWeed";
            this.DayOfWeed.Visible = true;
            this.DayOfWeed.VisibleIndex = 4;
            this.DayOfWeed.Width = 80;
            // 
            // TimeOf
            // 
            this.TimeOf.Caption = "Giờ học";
            this.TimeOf.FieldName = "TimeOf";
            this.TimeOf.Name = "TimeOf";
            this.TimeOf.Visible = true;
            this.TimeOf.VisibleIndex = 5;
            this.TimeOf.Width = 70;
            // 
            // Status
            // 
            this.Status.Caption = "Trạng thái";
            this.Status.FieldName = "Status";
            this.Status.Name = "Status";
            this.Status.Visible = true;
            this.Status.VisibleIndex = 6;
            // 
            // bandedGridView1
            // 
            this.bandedGridView1.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand1});
            this.bandedGridView1.GridControl = this.grdControlLichGiangday;
            this.bandedGridView1.Name = "bandedGridView1";
            // 
            // gridBand1
            // 
            this.gridBand1.Caption = "gridBand1";
            this.gridBand1.Name = "gridBand1";
            // 
            // uViewSchedulesInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grdControlLichGiangday);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.actionMenuSchedule);
            this.Name = "uViewSchedulesInfo";
            this.Size = new System.Drawing.Size(832, 436);
            this.Load += new System.EventHandler(this.uViewSchedulesInfo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uluThongTinChuyenGia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdControlLichGiangday)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdViewLichGiangday)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandedGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private Base.ActionMenu actionMenuSchedule;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.SimpleButton btnXemLichGiangDay;
        private DevExpress.XtraEditors.LookUpEdit uluThongTinChuyenGia;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl grdControlLichGiangday;
        private DevExpress.XtraGrid.Views.Card.CardView grdViewLichGiangday;
        private DevExpress.XtraGrid.Columns.GridColumn Id;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridView bandedGridView1;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private DevExpress.XtraGrid.Columns.GridColumn ClassId;
        private DevExpress.XtraGrid.Columns.GridColumn ClassName;
        private DevExpress.XtraGrid.Columns.GridColumn ExpertId;
        private DevExpress.XtraGrid.Columns.GridColumn ExpertName;
        private DevExpress.XtraGrid.Columns.GridColumn CourseId;
        private DevExpress.XtraGrid.Columns.GridColumn CourseName;
        private DevExpress.XtraGrid.Columns.GridColumn DayOf;
        private DevExpress.XtraGrid.Columns.GridColumn DayOfWeed;
        private DevExpress.XtraGrid.Columns.GridColumn TimeOf;
        private DevExpress.XtraGrid.Columns.GridColumn Status;
    }
}

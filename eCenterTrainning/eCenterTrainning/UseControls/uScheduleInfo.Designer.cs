namespace eCenterTrainning.UseControls
{
    partial class uScheduleInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uScheduleInfo));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.actionMenuSchedule = new eCenterTrainning.Base.ActionMenu();
            this.grdNhatKyLopHoc = new DevExpress.XtraGrid.GridControl();
            this.grdviewNhatKyLopHoc = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ClassId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ClassName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ExpertName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TeacherId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Contents = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CreateDate = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdNhatKyLopHoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdviewNhatKyLopHoc)).BeginInit();
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
            // grdNhatKyLopHoc
            // 
            this.grdNhatKyLopHoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdNhatKyLopHoc.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdNhatKyLopHoc.Location = new System.Drawing.Point(0, 48);
            this.grdNhatKyLopHoc.MainView = this.grdviewNhatKyLopHoc;
            this.grdNhatKyLopHoc.Name = "grdNhatKyLopHoc";
            this.grdNhatKyLopHoc.Size = new System.Drawing.Size(832, 388);
            this.grdNhatKyLopHoc.TabIndex = 1;
            this.grdNhatKyLopHoc.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdviewNhatKyLopHoc});
            this.grdNhatKyLopHoc.Click += new System.EventHandler(this.grdNhatKyLopHoc_Click);
            this.grdNhatKyLopHoc.DoubleClick += new System.EventHandler(this.grdNhatKyLopHoc_DoubleClick);
            // 
            // grdviewNhatKyLopHoc
            // 
            this.grdviewNhatKyLopHoc.Appearance.Row.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdviewNhatKyLopHoc.Appearance.Row.Options.UseFont = true;
            this.grdviewNhatKyLopHoc.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Id,
            this.ClassId,
            this.ClassName,
            this.ExpertName,
            this.TeacherId,
            this.Contents,
            this.CreateDate});
            this.grdviewNhatKyLopHoc.GridControl = this.grdNhatKyLopHoc;
            this.grdviewNhatKyLopHoc.GroupCount = 1;
            this.grdviewNhatKyLopHoc.Name = "grdviewNhatKyLopHoc";
            this.grdviewNhatKyLopHoc.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.ClassName, DevExpress.Data.ColumnSortOrder.Ascending)});
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
            this.ClassName.Caption = "ClassName";
            this.ClassName.FieldName = "ClassName";
            this.ClassName.Name = "ClassName";
            this.ClassName.Visible = true;
            this.ClassName.VisibleIndex = 0;
            this.ClassName.Width = 134;
            // 
            // ExpertName
            // 
            this.ExpertName.Caption = "ExpertName";
            this.ExpertName.FieldName = "ExpertName";
            this.ExpertName.Name = "ExpertName";
            this.ExpertName.Visible = true;
            this.ExpertName.VisibleIndex = 0;
            this.ExpertName.Width = 134;
            // 
            // TeacherId
            // 
            this.TeacherId.Caption = "TeacherId";
            this.TeacherId.FieldName = "TeacherId";
            this.TeacherId.Name = "TeacherId";
            this.TeacherId.Width = 80;
            // 
            // Contents
            // 
            this.Contents.Caption = "Contents";
            this.Contents.FieldName = "Contents";
            this.Contents.Name = "Contents";
            this.Contents.Visible = true;
            this.Contents.VisibleIndex = 1;
            this.Contents.Width = 220;
            // 
            // CreateDate
            // 
            this.CreateDate.Caption = "CreateDate";
            this.CreateDate.FieldName = "CreateDate";
            this.CreateDate.Name = "CreateDate";
            this.CreateDate.Visible = true;
            this.CreateDate.VisibleIndex = 2;
            this.CreateDate.Width = 80;
            // 
            // uScheduleInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grdNhatKyLopHoc);
            this.Controls.Add(this.actionMenuSchedule);
            this.Name = "uScheduleInfo";
            this.Size = new System.Drawing.Size(832, 436);
            this.Load += new System.EventHandler(this.uExpertInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdNhatKyLopHoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdviewNhatKyLopHoc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private Base.ActionMenu actionMenuSchedule;
        private DevExpress.XtraGrid.GridControl grdNhatKyLopHoc;
        private DevExpress.XtraGrid.Views.Grid.GridView grdviewNhatKyLopHoc;
        private DevExpress.XtraGrid.Columns.GridColumn Id;
        private DevExpress.XtraGrid.Columns.GridColumn ClassId;
        private DevExpress.XtraGrid.Columns.GridColumn ClassName;
        private DevExpress.XtraGrid.Columns.GridColumn ExpertName;
        private DevExpress.XtraGrid.Columns.GridColumn TeacherId;
        private DevExpress.XtraGrid.Columns.GridColumn Contents;
        private DevExpress.XtraGrid.Columns.GridColumn CreateDate;
    }
}

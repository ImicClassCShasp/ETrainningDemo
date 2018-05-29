namespace eCenterTrainning.UseControls
{
    partial class uCourse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uCourse));
            this.xtraTabControlCourse = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPageCourse = new DevExpress.XtraTab.XtraTabPage();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.gridControlCourse = new DevExpress.XtraGrid.GridControl();
            this.gridViewCourse = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ColCourseName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.actionMenu1 = new eCenterTrainning.Base.ActionMenu();
            this.xtraTabPageClassInfo = new DevExpress.XtraTab.XtraTabPage();
            this.gridControlClass = new DevExpress.XtraGrid.GridControl();
            this.gridViewClass = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ColClassName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColFromDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColToDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColSoLuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColNoiHoc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColAction = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemImageComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnAddClass = new DevExpress.XtraEditors.SimpleButton();
            this.lookUpEditCourse = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControlCourse)).BeginInit();
            this.xtraTabControlCourse.SuspendLayout();
            this.xtraTabPageCourse.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCourse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCourse)).BeginInit();
            this.xtraTabPageClassInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlClass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewClass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditCourse.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraTabControlCourse
            // 
            this.xtraTabControlCourse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControlCourse.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControlCourse.Name = "xtraTabControlCourse";
            this.xtraTabControlCourse.SelectedTabPage = this.xtraTabPageCourse;
            this.xtraTabControlCourse.Size = new System.Drawing.Size(582, 224);
            this.xtraTabControlCourse.TabIndex = 0;
            this.xtraTabControlCourse.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPageCourse,
            this.xtraTabPageClassInfo});
            this.xtraTabControlCourse.Click += new System.EventHandler(this.xtraTabControlCourse_Click);
            // 
            // xtraTabPageCourse
            // 
            this.xtraTabPageCourse.Controls.Add(this.groupControl1);
            this.xtraTabPageCourse.Controls.Add(this.actionMenu1);
            this.xtraTabPageCourse.Name = "xtraTabPageCourse";
            this.xtraTabPageCourse.Size = new System.Drawing.Size(576, 196);
            this.xtraTabPageCourse.Text = "Thông tin khóa học";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.gridControlCourse);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 45);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(576, 151);
            this.groupControl1.TabIndex = 4;
            // 
            // gridControlCourse
            // 
            this.gridControlCourse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlCourse.Location = new System.Drawing.Point(2, 21);
            this.gridControlCourse.MainView = this.gridViewCourse;
            this.gridControlCourse.Name = "gridControlCourse";
            this.gridControlCourse.Size = new System.Drawing.Size(572, 128);
            this.gridControlCourse.TabIndex = 0;
            this.gridControlCourse.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewCourse});
            // 
            // gridViewCourse
            // 
            this.gridViewCourse.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ColCourseName,
            this.ColDescription,
            this.Id});
            this.gridViewCourse.GridControl = this.gridControlCourse;
            this.gridViewCourse.Name = "gridViewCourse";
            this.gridViewCourse.OptionsBehavior.Editable = false;
            this.gridViewCourse.OptionsView.ShowAutoFilterRow = true;
            this.gridViewCourse.OptionsView.ShowFooter = true;
            this.gridViewCourse.OptionsView.ShowGroupPanel = false;
            // 
            // ColCourseName
            // 
            this.ColCourseName.Caption = "Khóa học";
            this.ColCourseName.FieldName = "CourseName";
            this.ColCourseName.Name = "ColCourseName";
            this.ColCourseName.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.ColCourseName.Visible = true;
            this.ColCourseName.VisibleIndex = 0;
            // 
            // ColDescription
            // 
            this.ColDescription.Caption = "Mô tả";
            this.ColDescription.FieldName = "CourseDescription";
            this.ColDescription.Name = "ColDescription";
            this.ColDescription.Visible = true;
            this.ColDescription.VisibleIndex = 1;
            // 
            // Id
            // 
            this.Id.Caption = "Id";
            this.Id.FieldName = "Id";
            this.Id.Name = "Id";
            // 
            // actionMenu1
            // 
            this.actionMenu1.Dock = System.Windows.Forms.DockStyle.Top;
            this.actionMenu1.Location = new System.Drawing.Point(0, 0);
            this.actionMenu1.Name = "actionMenu1";
            this.actionMenu1.Size = new System.Drawing.Size(576, 45);
            this.actionMenu1.TabIndex = 3;
            // 
            // xtraTabPageClassInfo
            // 
            this.xtraTabPageClassInfo.Controls.Add(this.gridControlClass);
            this.xtraTabPageClassInfo.Controls.Add(this.panelControl1);
            this.xtraTabPageClassInfo.Name = "xtraTabPageClassInfo";
            this.xtraTabPageClassInfo.Size = new System.Drawing.Size(576, 196);
            this.xtraTabPageClassInfo.Text = "Thông tin lớp học";
            // 
            // gridControlClass
            // 
            this.gridControlClass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlClass.Location = new System.Drawing.Point(0, 37);
            this.gridControlClass.MainView = this.gridViewClass;
            this.gridControlClass.Name = "gridControlClass";
            this.gridControlClass.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemImageComboBox1});
            this.gridControlClass.Size = new System.Drawing.Size(576, 159);
            this.gridControlClass.TabIndex = 3;
            this.gridControlClass.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewClass});
            // 
            // gridViewClass
            // 
            this.gridViewClass.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ColClassName,
            this.ColFromDate,
            this.ColToDate,
            this.ColSoLuong,
            this.ColNoiHoc,
            this.ColId,
            this.ColAction});
            this.gridViewClass.GridControl = this.gridControlClass;
            this.gridViewClass.Name = "gridViewClass";
            this.gridViewClass.OptionsBehavior.Editable = false;
            this.gridViewClass.OptionsView.ShowAutoFilterRow = true;
            this.gridViewClass.OptionsView.ShowFooter = true;
            this.gridViewClass.OptionsView.ShowGroupPanel = false;
            this.gridViewClass.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gridViewClass_RowCellClick);
            // 
            // ColClassName
            // 
            this.ColClassName.Caption = "Lớp học";
            this.ColClassName.FieldName = "ClassName";
            this.ColClassName.Name = "ColClassName";
            this.ColClassName.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.ColClassName.Visible = true;
            this.ColClassName.VisibleIndex = 0;
            this.ColClassName.Width = 93;
            // 
            // ColFromDate
            // 
            this.ColFromDate.Caption = "Khai giảng";
            this.ColFromDate.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.ColFromDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.ColFromDate.FieldName = "FromDate";
            this.ColFromDate.Name = "ColFromDate";
            this.ColFromDate.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.ColFromDate.Visible = true;
            this.ColFromDate.VisibleIndex = 1;
            this.ColFromDate.Width = 93;
            // 
            // ColToDate
            // 
            this.ColToDate.Caption = "Kết thúc";
            this.ColToDate.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.ColToDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.ColToDate.FieldName = "ToDate";
            this.ColToDate.Name = "ColToDate";
            this.ColToDate.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.ColToDate.Visible = true;
            this.ColToDate.VisibleIndex = 2;
            this.ColToDate.Width = 93;
            // 
            // ColSoLuong
            // 
            this.ColSoLuong.Caption = "Số lượng";
            this.ColSoLuong.FieldName = "NumberStudents";
            this.ColSoLuong.Name = "ColSoLuong";
            this.ColSoLuong.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.ColSoLuong.Visible = true;
            this.ColSoLuong.VisibleIndex = 3;
            this.ColSoLuong.Width = 93;
            // 
            // ColNoiHoc
            // 
            this.ColNoiHoc.Caption = "Nơi học";
            this.ColNoiHoc.FieldName = "PlaceTraining";
            this.ColNoiHoc.Name = "ColNoiHoc";
            this.ColNoiHoc.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.ColNoiHoc.Visible = true;
            this.ColNoiHoc.VisibleIndex = 4;
            this.ColNoiHoc.Width = 93;
            // 
            // ColId
            // 
            this.ColId.Caption = "Id";
            this.ColId.FieldName = "Id";
            this.ColId.Name = "ColId";
            // 
            // ColAction
            // 
            this.ColAction.ColumnEdit = this.repositoryItemImageComboBox1;
            this.ColAction.Name = "ColAction";
            this.ColAction.Visible = true;
            this.ColAction.VisibleIndex = 5;
            this.ColAction.Width = 20;
            // 
            // repositoryItemImageComboBox1
            // 
            this.repositoryItemImageComboBox1.AutoHeight = false;
            this.repositoryItemImageComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemImageComboBox1.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("", null, 0)});
            this.repositoryItemImageComboBox1.Name = "repositoryItemImageComboBox1";
            this.repositoryItemImageComboBox1.SmallImages = this.imageList1;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "delete.gif");
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnAddClass);
            this.panelControl1.Controls.Add(this.lookUpEditCourse);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(576, 37);
            this.panelControl1.TabIndex = 2;
            // 
            // btnAddClass
            // 
            this.btnAddClass.Image = global::eCenterTrainning.Properties.Resources.add_icon;
            this.btnAddClass.Location = new System.Drawing.Point(308, 5);
            this.btnAddClass.Name = "btnAddClass";
            this.btnAddClass.Size = new System.Drawing.Size(100, 23);
            this.btnAddClass.TabIndex = 2;
            this.btnAddClass.Text = "Thêm lớp học";
            this.btnAddClass.Click += new System.EventHandler(this.btnAddClass_Click);
            // 
            // lookUpEditCourse
            // 
            this.lookUpEditCourse.Location = new System.Drawing.Point(97, 8);
            this.lookUpEditCourse.Name = "lookUpEditCourse";
            this.lookUpEditCourse.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditCourse.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Id", "Id", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CourseName", "Khóa học")});
            this.lookUpEditCourse.Properties.NullText = "---Chọn khóa học---";
            this.lookUpEditCourse.Size = new System.Drawing.Size(190, 20);
            this.lookUpEditCourse.TabIndex = 2;
            this.lookUpEditCourse.EditValueChanged += new System.EventHandler(this.lookUpEditCourse_EditValueChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(20, 15);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(51, 13);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Khóa học :";
            // 
            // uCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.xtraTabControlCourse);
            this.Name = "uCourse";
            this.Size = new System.Drawing.Size(582, 224);
            this.Load += new System.EventHandler(this.uCourse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControlCourse)).EndInit();
            this.xtraTabControlCourse.ResumeLayout(false);
            this.xtraTabPageCourse.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCourse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCourse)).EndInit();
            this.xtraTabPageClassInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlClass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewClass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditCourse.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl xtraTabControlCourse;
        private DevExpress.XtraTab.XtraTabPage xtraTabPageCourse;
        private DevExpress.XtraTab.XtraTabPage xtraTabPageClassInfo;
        private Base.ActionMenu actionMenu1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl gridControlCourse;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewCourse;
        private DevExpress.XtraGrid.Columns.GridColumn ColCourseName;
        private DevExpress.XtraGrid.Columns.GridColumn ColDescription;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditCourse;
        private DevExpress.XtraGrid.GridControl gridControlClass;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewClass;
        private DevExpress.XtraGrid.Columns.GridColumn ColClassName;
        private DevExpress.XtraGrid.Columns.GridColumn ColFromDate;
        private DevExpress.XtraGrid.Columns.GridColumn ColToDate;
        private DevExpress.XtraGrid.Columns.GridColumn ColSoLuong;
        private DevExpress.XtraGrid.Columns.GridColumn ColNoiHoc;
        private DevExpress.XtraGrid.Columns.GridColumn ColId;
        private DevExpress.XtraGrid.Columns.GridColumn Id;
        private DevExpress.XtraEditors.SimpleButton btnAddClass;
        private DevExpress.XtraGrid.Columns.GridColumn ColAction;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox repositoryItemImageComboBox1;
        private System.Windows.Forms.ImageList imageList1;

    }
}

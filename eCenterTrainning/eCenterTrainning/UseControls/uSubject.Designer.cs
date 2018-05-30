namespace eCenterTrainning.UseControls
{
    partial class uSubject
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
            this.xtraTabControlSubject = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPageSubject = new DevExpress.XtraTab.XtraTabPage();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.gridControlSubject = new DevExpress.XtraGrid.GridControl();
            this.gridViewSubject = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ColSubjectName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.actionMenu1 = new eCenterTrainning.Base.ActionMenu();
            this.xtraTabPageCourseInfo = new DevExpress.XtraTab.XtraTabPage();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.gridControlCourse = new DevExpress.XtraGrid.GridControl();
            this.gridViewCourse = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ColCourseName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColCourseDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.lookUpEditSubject = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControlSubject)).BeginInit();
            this.xtraTabControlSubject.SuspendLayout();
            this.xtraTabPageSubject.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlSubject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSubject)).BeginInit();
            this.xtraTabPageCourseInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCourse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCourse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditSubject.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraTabControlSubject
            // 
            this.xtraTabControlSubject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControlSubject.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControlSubject.Name = "xtraTabControlSubject";
            this.xtraTabControlSubject.SelectedTabPage = this.xtraTabPageSubject;
            this.xtraTabControlSubject.Size = new System.Drawing.Size(838, 402);
            this.xtraTabControlSubject.TabIndex = 0;
            this.xtraTabControlSubject.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPageSubject,
            this.xtraTabPageCourseInfo});
            this.xtraTabControlSubject.Click += new System.EventHandler(this.xtraTabControlSubject_Click);
            // 
            // xtraTabPageSubject
            // 
            this.xtraTabPageSubject.Controls.Add(this.groupControl1);
            this.xtraTabPageSubject.Controls.Add(this.actionMenu1);
            this.xtraTabPageSubject.Name = "xtraTabPageSubject";
            this.xtraTabPageSubject.Size = new System.Drawing.Size(832, 374);
            this.xtraTabPageSubject.Text = "Thông tin môn học";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.gridControlSubject);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 45);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(832, 329);
            this.groupControl1.TabIndex = 3;
            // 
            // gridControlSubject
            // 
            this.gridControlSubject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlSubject.Location = new System.Drawing.Point(2, 20);
            this.gridControlSubject.MainView = this.gridViewSubject;
            this.gridControlSubject.Name = "gridControlSubject";
            this.gridControlSubject.Size = new System.Drawing.Size(828, 307);
            this.gridControlSubject.TabIndex = 0;
            this.gridControlSubject.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewSubject});
            // 
            // gridViewSubject
            // 
            this.gridViewSubject.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ColSubjectName,
            this.ColDescription});
            this.gridViewSubject.GridControl = this.gridControlSubject;
            this.gridViewSubject.Name = "gridViewSubject";
            this.gridViewSubject.OptionsBehavior.Editable = false;
            this.gridViewSubject.OptionsFind.AlwaysVisible = true;
            this.gridViewSubject.OptionsView.ShowAutoFilterRow = true;
            this.gridViewSubject.OptionsView.ShowFooter = true;
            this.gridViewSubject.OptionsView.ShowGroupPanel = false;
            // 
            // ColSubjectName
            // 
            this.ColSubjectName.Caption = "Môn học";
            this.ColSubjectName.FieldName = "SubjectName";
            this.ColSubjectName.Name = "ColSubjectName";
            this.ColSubjectName.Visible = true;
            this.ColSubjectName.VisibleIndex = 0;
            // 
            // ColDescription
            // 
            this.ColDescription.Caption = "Mô tả";
            this.ColDescription.FieldName = "SubjectDescription";
            this.ColDescription.Name = "ColDescription";
            this.ColDescription.Visible = true;
            this.ColDescription.VisibleIndex = 1;
            // 
            // actionMenu1
            // 
            this.actionMenu1.Dock = System.Windows.Forms.DockStyle.Top;
            this.actionMenu1.Location = new System.Drawing.Point(0, 0);
            this.actionMenu1.Name = "actionMenu1";
            this.actionMenu1.Size = new System.Drawing.Size(832, 45);
            this.actionMenu1.TabIndex = 2;
            // 
            // xtraTabPageCourseInfo
            // 
            this.xtraTabPageCourseInfo.Controls.Add(this.groupControl2);
            this.xtraTabPageCourseInfo.Name = "xtraTabPageCourseInfo";
            this.xtraTabPageCourseInfo.Size = new System.Drawing.Size(602, 214);
            this.xtraTabPageCourseInfo.Text = "Thông tin khóa học";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.gridControlCourse);
            this.groupControl2.Controls.Add(this.panelControl1);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(602, 214);
            this.groupControl2.TabIndex = 2;
            // 
            // gridControlCourse
            // 
            this.gridControlCourse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlCourse.Location = new System.Drawing.Point(2, 61);
            this.gridControlCourse.MainView = this.gridViewCourse;
            this.gridControlCourse.Name = "gridControlCourse";
            this.gridControlCourse.Size = new System.Drawing.Size(598, 151);
            this.gridControlCourse.TabIndex = 1;
            this.gridControlCourse.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewCourse});
            // 
            // gridViewCourse
            // 
            this.gridViewCourse.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ColCourseName,
            this.ColCourseDescription});
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
            this.ColCourseName.Visible = true;
            this.ColCourseName.VisibleIndex = 0;
            // 
            // ColCourseDescription
            // 
            this.ColCourseDescription.Caption = "Mô tả";
            this.ColCourseDescription.FieldName = "CourseDescription";
            this.ColCourseDescription.Name = "ColCourseDescription";
            this.ColCourseDescription.Visible = true;
            this.ColCourseDescription.VisibleIndex = 1;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.lookUpEditSubject);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(2, 20);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(598, 41);
            this.panelControl1.TabIndex = 0;
            // 
            // lookUpEditSubject
            // 
            this.lookUpEditSubject.Location = new System.Drawing.Point(87, 9);
            this.lookUpEditSubject.Name = "lookUpEditSubject";
            this.lookUpEditSubject.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditSubject.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Id", "Id"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SubjectName", "Môn học")});
            this.lookUpEditSubject.Properties.NullText = "---Chọn môn học---";
            this.lookUpEditSubject.Size = new System.Drawing.Size(245, 20);
            this.lookUpEditSubject.TabIndex = 1;
            this.lookUpEditSubject.EditValueChanged += new System.EventHandler(this.lookUpEditSubject_EditValueChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(13, 13);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(47, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Môn học :";
            // 
            // uSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.xtraTabControlSubject);
            this.Name = "uSubject";
            this.Size = new System.Drawing.Size(838, 402);
            this.Load += new System.EventHandler(this.uSubject_Load);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControlSubject)).EndInit();
            this.xtraTabControlSubject.ResumeLayout(false);
            this.xtraTabPageSubject.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlSubject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSubject)).EndInit();
            this.xtraTabPageCourseInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCourse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCourse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditSubject.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl xtraTabControlSubject;
        private DevExpress.XtraTab.XtraTabPage xtraTabPageSubject;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl gridControlSubject;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewSubject;
        private DevExpress.XtraGrid.Columns.GridColumn ColSubjectName;
        private DevExpress.XtraGrid.Columns.GridColumn ColDescription;
        private Base.ActionMenu actionMenu1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPageCourseInfo;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl gridControlCourse;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewCourse;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditSubject;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.Columns.GridColumn ColCourseName;
        private DevExpress.XtraGrid.Columns.GridColumn ColCourseDescription;
    }
}

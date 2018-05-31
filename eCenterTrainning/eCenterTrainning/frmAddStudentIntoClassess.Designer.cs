namespace eCenterTrainning
{
    partial class frmAddStudentIntoClassess
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddStudentIntoClassess));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblStuSelected = new DevExpress.XtraEditors.LabelControl();
            this.btnHoanTatChonHv = new System.Windows.Forms.Button();
            this.dtStartTime = new DevExpress.XtraEditors.DateEdit();
            this.dtEndTime = new DevExpress.XtraEditors.DateEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblSelectedInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.grCStudentSelected = new DevExpress.XtraGrid.GridControl();
            this.grVStudentSelected = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cStudentId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cClassId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cFullName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cSex = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cMobile = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cCourseName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cDateStart = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCAction = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemImageComboBox2 = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.grCListStudents = new DevExpress.XtraGrid.GridControl();
            this.grVListStudents = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.SId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sUserId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sStatusId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sCourseId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sFullName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sSexString = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sMobile = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sCourseName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sStatusName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sDateCreate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sUserName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAction = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemImageComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.sSex = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.msgMessage)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtStartTime.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtStartTime.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtEndTime.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtEndTime.Properties)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grCStudentSelected)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grVStudentSelected)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grCListStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grVListStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblStuSelected);
            this.panel1.Controls.Add(this.btnHoanTatChonHv);
            this.panel1.Controls.Add(this.dtStartTime);
            this.panel1.Controls.Add(this.dtEndTime);
            this.panel1.Controls.Add(this.labelControl2);
            this.panel1.Controls.Add(this.labelControl9);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1140, 41);
            this.panel1.TabIndex = 0;
            // 
            // lblStuSelected
            // 
            this.lblStuSelected.Appearance.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStuSelected.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblStuSelected.Appearance.Options.UseFont = true;
            this.lblStuSelected.Appearance.Options.UseForeColor = true;
            this.lblStuSelected.Location = new System.Drawing.Point(700, 14);
            this.lblStuSelected.Name = "lblStuSelected";
            this.lblStuSelected.Size = new System.Drawing.Size(75, 15);
            this.lblStuSelected.TabIndex = 24;
            this.lblStuSelected.Text = "labelControl1";
            this.lblStuSelected.Visible = false;
            // 
            // btnHoanTatChonHv
            // 
            this.btnHoanTatChonHv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnHoanTatChonHv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHoanTatChonHv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHoanTatChonHv.ForeColor = System.Drawing.Color.White;
            this.btnHoanTatChonHv.Location = new System.Drawing.Point(401, 8);
            this.btnHoanTatChonHv.Name = "btnHoanTatChonHv";
            this.btnHoanTatChonHv.Size = new System.Drawing.Size(293, 23);
            this.btnHoanTatChonHv.TabIndex = 0;
            this.btnHoanTatChonHv.Text = "Hoàn tất việc lựa chọn Học viên tham gia lớp";
            this.btnHoanTatChonHv.UseVisualStyleBackColor = false;
            this.btnHoanTatChonHv.Click += new System.EventHandler(this.btnHoanTatChonHv_Click);
            // 
            // dtStartTime
            // 
            this.dtStartTime.EditValue = null;
            this.dtStartTime.Location = new System.Drawing.Point(62, 10);
            this.dtStartTime.Name = "dtStartTime";
            this.dtStartTime.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.dtStartTime.Properties.Appearance.Options.UseBackColor = true;
            this.dtStartTime.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtStartTime.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dtStartTime.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.dtStartTime.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtStartTime.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dtStartTime.Size = new System.Drawing.Size(138, 20);
            this.dtStartTime.TabIndex = 22;
            this.dtStartTime.EditValueChanged += new System.EventHandler(this.dtStartTime_EditValueChanged);
            // 
            // dtEndTime
            // 
            this.dtEndTime.EditValue = null;
            this.dtEndTime.Enabled = false;
            this.dtEndTime.Location = new System.Drawing.Point(249, 10);
            this.dtEndTime.Name = "dtEndTime";
            this.dtEndTime.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.dtEndTime.Properties.Appearance.Options.UseBackColor = true;
            this.dtEndTime.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtEndTime.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dtEndTime.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.dtEndTime.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtEndTime.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dtEndTime.Size = new System.Drawing.Size(146, 20);
            this.dtEndTime.TabIndex = 23;
            this.dtEndTime.EditValueChanged += new System.EventHandler(this.dtEndTime_EditValueChanged);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(216, 14);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(27, 13);
            this.labelControl2.TabIndex = 20;
            this.labelControl2.Text = "Đến :";
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(9, 14);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(47, 13);
            this.labelControl9.TabIndex = 21;
            this.labelControl9.Text = "Từ ngày :";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblSelectedInfo});
            this.statusStrip1.Location = new System.Drawing.Point(0, 468);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1140, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblSelectedInfo
            // 
            this.lblSelectedInfo.Name = "lblSelectedInfo";
            this.lblSelectedInfo.Size = new System.Drawing.Size(38, 17);
            this.lblSelectedInfo.Text = "ver1.0";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.grCStudentSelected);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 280);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1140, 188);
            this.panel3.TabIndex = 2;
            // 
            // grCStudentSelected
            // 
            this.grCStudentSelected.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grCStudentSelected.Location = new System.Drawing.Point(0, 0);
            this.grCStudentSelected.MainView = this.grVStudentSelected;
            this.grCStudentSelected.Name = "grCStudentSelected";
            this.grCStudentSelected.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemImageComboBox2});
            this.grCStudentSelected.Size = new System.Drawing.Size(1140, 188);
            this.grCStudentSelected.TabIndex = 1;
            this.grCStudentSelected.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grVStudentSelected});
            // 
            // grVStudentSelected
            // 
            this.grVStudentSelected.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.cId,
            this.cStudentId,
            this.cClassId,
            this.cFullName,
            this.cSex,
            this.cEmail,
            this.cMobile,
            this.cCourseName,
            this.cDateStart,
            this.colCAction});
            this.grVStudentSelected.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.grVStudentSelected.GridControl = this.grCStudentSelected;
            this.grVStudentSelected.Name = "grVStudentSelected";
            this.grVStudentSelected.OptionsBehavior.Editable = false;
            this.grVStudentSelected.OptionsView.ShowAutoFilterRow = true;
            this.grVStudentSelected.OptionsView.ShowFooter = true;
            this.grVStudentSelected.OptionsView.ShowGroupPanel = false;
            this.grVStudentSelected.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.grVStudentSelected_RowCellClick);
            // 
            // cId
            // 
            this.cId.Caption = "Id";
            this.cId.Name = "cId";
            // 
            // cStudentId
            // 
            this.cStudentId.Caption = "Mã Học viên";
            this.cStudentId.FieldName = "Id";
            this.cStudentId.Name = "cStudentId";
            // 
            // cClassId
            // 
            this.cClassId.Caption = "Mã lớp học";
            this.cClassId.FieldName = "ClassId";
            this.cClassId.Name = "cClassId";
            // 
            // cFullName
            // 
            this.cFullName.Caption = "Họ và Tên";
            this.cFullName.FieldName = "FullName";
            this.cFullName.Name = "cFullName";
            this.cFullName.Visible = true;
            this.cFullName.VisibleIndex = 0;
            this.cFullName.Width = 130;
            // 
            // cSex
            // 
            this.cSex.Caption = "Giới tính";
            this.cSex.FieldName = "sSex";
            this.cSex.Name = "cSex";
            this.cSex.Visible = true;
            this.cSex.VisibleIndex = 1;
            this.cSex.Width = 100;
            // 
            // cEmail
            // 
            this.cEmail.Caption = "Thư điện tử";
            this.cEmail.FieldName = "Email";
            this.cEmail.Name = "cEmail";
            this.cEmail.Visible = true;
            this.cEmail.VisibleIndex = 2;
            this.cEmail.Width = 130;
            // 
            // cMobile
            // 
            this.cMobile.Caption = "Điện thoại";
            this.cMobile.FieldName = "Mobile";
            this.cMobile.Name = "cMobile";
            this.cMobile.Visible = true;
            this.cMobile.VisibleIndex = 3;
            this.cMobile.Width = 100;
            // 
            // cCourseName
            // 
            this.cCourseName.Caption = "Tên lớp học";
            this.cCourseName.FieldName = "ClassName";
            this.cCourseName.Name = "cCourseName";
            this.cCourseName.Visible = true;
            this.cCourseName.VisibleIndex = 4;
            this.cCourseName.Width = 130;
            // 
            // cDateStart
            // 
            this.cDateStart.Caption = "Ngày vào lớp";
            this.cDateStart.FieldName = "DateStart";
            this.cDateStart.Name = "cDateStart";
            this.cDateStart.Visible = true;
            this.cDateStart.VisibleIndex = 5;
            this.cDateStart.Width = 120;
            // 
            // colCAction
            // 
            this.colCAction.ColumnEdit = this.repositoryItemImageComboBox2;
            this.colCAction.Name = "colCAction";
            this.colCAction.Visible = true;
            this.colCAction.VisibleIndex = 6;
            this.colCAction.Width = 30;
            // 
            // repositoryItemImageComboBox2
            // 
            this.repositoryItemImageComboBox2.AutoHeight = false;
            this.repositoryItemImageComboBox2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemImageComboBox2.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("", null, 1)});
            this.repositoryItemImageComboBox2.Name = "repositoryItemImageComboBox2";
            this.repositoryItemImageComboBox2.SmallImages = this.imageList1;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "add-icon.png");
            this.imageList1.Images.SetKeyName(1, "delete.gif");
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.grCListStudents);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 41);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1140, 239);
            this.panel2.TabIndex = 3;
            // 
            // grCListStudents
            // 
            this.grCListStudents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grCListStudents.Location = new System.Drawing.Point(0, 0);
            this.grCListStudents.MainView = this.grVListStudents;
            this.grCListStudents.Name = "grCListStudents";
            this.grCListStudents.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemImageComboBox1});
            this.grCListStudents.Size = new System.Drawing.Size(1140, 239);
            this.grCListStudents.TabIndex = 1;
            this.grCListStudents.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grVListStudents});
            // 
            // grVListStudents
            // 
            this.grVListStudents.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.SId,
            this.sUserId,
            this.sStatusId,
            this.sCourseId,
            this.sFullName,
            this.sSexString,
            this.sMobile,
            this.sEmail,
            this.sCourseName,
            this.sStatusName,
            this.sDateCreate,
            this.sAddress,
            this.sDescription,
            this.sUserName,
            this.colAction,
            this.sSex});
            this.grVListStudents.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.grVListStudents.GridControl = this.grCListStudents;
            this.grVListStudents.Name = "grVListStudents";
            this.grVListStudents.OptionsBehavior.Editable = false;
            this.grVListStudents.OptionsView.ShowAutoFilterRow = true;
            this.grVListStudents.OptionsView.ShowFooter = true;
            this.grVListStudents.OptionsView.ShowGroupPanel = false;
            this.grVListStudents.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.grVListStudents_RowCellClick);
            // 
            // SId
            // 
            this.SId.Caption = "Id";
            this.SId.FieldName = "Id";
            this.SId.Name = "SId";
            // 
            // sUserId
            // 
            this.sUserId.Caption = "Mã tư vấn";
            this.sUserId.FieldName = "UserId";
            this.sUserId.Name = "sUserId";
            this.sUserId.Width = 73;
            // 
            // sStatusId
            // 
            this.sStatusId.Caption = "Trạng thái";
            this.sStatusId.FieldName = "StatusId";
            this.sStatusId.Name = "sStatusId";
            this.sStatusId.Width = 96;
            // 
            // sCourseId
            // 
            this.sCourseId.Caption = "Mã khóa học";
            this.sCourseId.FieldName = "CourseId";
            this.sCourseId.Name = "sCourseId";
            this.sCourseId.Width = 96;
            // 
            // sFullName
            // 
            this.sFullName.Caption = "Họ và Tên";
            this.sFullName.FieldName = "FullName";
            this.sFullName.Name = "sFullName";
            this.sFullName.Visible = true;
            this.sFullName.VisibleIndex = 0;
            this.sFullName.Width = 120;
            // 
            // sSexString
            // 
            this.sSexString.Caption = "Giới tính";
            this.sSexString.FieldName = "SexString";
            this.sSexString.Name = "sSexString";
            this.sSexString.Visible = true;
            this.sSexString.VisibleIndex = 1;
            this.sSexString.Width = 80;
            // 
            // sMobile
            // 
            this.sMobile.Caption = "Điện thoại";
            this.sMobile.FieldName = "Mobile";
            this.sMobile.Name = "sMobile";
            this.sMobile.Visible = true;
            this.sMobile.VisibleIndex = 2;
            this.sMobile.Width = 110;
            // 
            // sEmail
            // 
            this.sEmail.Caption = "Thư điện tử";
            this.sEmail.FieldName = "Email";
            this.sEmail.Name = "sEmail";
            this.sEmail.Visible = true;
            this.sEmail.VisibleIndex = 3;
            this.sEmail.Width = 150;
            // 
            // sCourseName
            // 
            this.sCourseName.Caption = "Tên khóa học";
            this.sCourseName.FieldName = "CourseName";
            this.sCourseName.Name = "sCourseName";
            this.sCourseName.Visible = true;
            this.sCourseName.VisibleIndex = 4;
            this.sCourseName.Width = 80;
            // 
            // sStatusName
            // 
            this.sStatusName.Caption = "Trạng thái";
            this.sStatusName.FieldName = "StatusName";
            this.sStatusName.Name = "sStatusName";
            this.sStatusName.Visible = true;
            this.sStatusName.VisibleIndex = 5;
            this.sStatusName.Width = 100;
            // 
            // sDateCreate
            // 
            this.sDateCreate.Caption = "Ngày đăng ký";
            this.sDateCreate.FieldName = "DateCreate";
            this.sDateCreate.Name = "sDateCreate";
            this.sDateCreate.Visible = true;
            this.sDateCreate.VisibleIndex = 6;
            this.sDateCreate.Width = 100;
            // 
            // sAddress
            // 
            this.sAddress.Caption = "Địa chỉ";
            this.sAddress.FieldName = "Address";
            this.sAddress.Name = "sAddress";
            this.sAddress.Visible = true;
            this.sAddress.VisibleIndex = 7;
            this.sAddress.Width = 120;
            // 
            // sDescription
            // 
            this.sDescription.Caption = "Mô tả";
            this.sDescription.FieldName = "Description";
            this.sDescription.Name = "sDescription";
            this.sDescription.Visible = true;
            this.sDescription.VisibleIndex = 8;
            this.sDescription.Width = 110;
            // 
            // sUserName
            // 
            this.sUserName.Caption = "Tư vấn viên";
            this.sUserName.FieldName = "UserName";
            this.sUserName.Name = "sUserName";
            this.sUserName.Visible = true;
            this.sUserName.VisibleIndex = 9;
            this.sUserName.Width = 60;
            // 
            // colAction
            // 
            this.colAction.ColumnEdit = this.repositoryItemImageComboBox1;
            this.colAction.Name = "colAction";
            this.colAction.Visible = true;
            this.colAction.VisibleIndex = 10;
            this.colAction.Width = 20;
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
            // sSex
            // 
            this.sSex.Caption = "Sex";
            this.sSex.FieldName = "Sex";
            this.sSex.Name = "sSex";
            // 
            // frmAddStudentIntoClassess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 490);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmAddStudentIntoClassess";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAddStudentIntoClassess";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmAddStudentIntoClassess_Load);
            ((System.ComponentModel.ISupportInitialize)(this.msgMessage)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtStartTime.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtStartTime.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtEndTime.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtEndTime.Properties)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grCStudentSelected)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grVStudentSelected)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grCListStudents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grVListStudents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Button btnHoanTatChonHv;
        private DevExpress.XtraEditors.DateEdit dtStartTime;
        private DevExpress.XtraEditors.DateEdit dtEndTime;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private System.Windows.Forms.ToolStripStatusLabel lblSelectedInfo;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraGrid.GridControl grCStudentSelected;
        private DevExpress.XtraGrid.Views.Grid.GridView grVStudentSelected;
        private DevExpress.XtraGrid.GridControl grCListStudents;
        private DevExpress.XtraGrid.Views.Grid.GridView grVListStudents;
        private DevExpress.XtraGrid.Columns.GridColumn SId;
        private DevExpress.XtraGrid.Columns.GridColumn sFullName;
        private DevExpress.XtraGrid.Columns.GridColumn sSexString;
        private DevExpress.XtraGrid.Columns.GridColumn sMobile;
        private DevExpress.XtraGrid.Columns.GridColumn sEmail;
        private DevExpress.XtraGrid.Columns.GridColumn sAddress;
        private DevExpress.XtraGrid.Columns.GridColumn sDateCreate;
        private DevExpress.XtraGrid.Columns.GridColumn sCourseId;
        private DevExpress.XtraGrid.Columns.GridColumn sStatusId;
        private DevExpress.XtraGrid.Columns.GridColumn sUserId;
        private DevExpress.XtraGrid.Columns.GridColumn sDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colAction;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox repositoryItemImageComboBox1;
        private System.Windows.Forms.ImageList imageList1;
        private DevExpress.XtraGrid.Columns.GridColumn sCourseName;
        private DevExpress.XtraGrid.Columns.GridColumn sStatusName;
        private DevExpress.XtraGrid.Columns.GridColumn sUserName;
        private DevExpress.XtraGrid.Columns.GridColumn cId;
        private DevExpress.XtraGrid.Columns.GridColumn cFullName;
        private DevExpress.XtraGrid.Columns.GridColumn cSex;
        private DevExpress.XtraGrid.Columns.GridColumn cEmail;
        private DevExpress.XtraGrid.Columns.GridColumn cMobile;
        private DevExpress.XtraGrid.Columns.GridColumn cCourseName;
        private DevExpress.XtraGrid.Columns.GridColumn cStudentId;
        private DevExpress.XtraGrid.Columns.GridColumn cClassId;
        private DevExpress.XtraGrid.Columns.GridColumn sSex;
        private DevExpress.XtraGrid.Columns.GridColumn cDateStart;
        private DevExpress.XtraGrid.Columns.GridColumn colCAction;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox repositoryItemImageComboBox2;
        private DevExpress.XtraEditors.LabelControl lblStuSelected;
    }
}
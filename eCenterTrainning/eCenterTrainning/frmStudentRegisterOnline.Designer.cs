namespace eCenterTrainning
{
    partial class frmStudentRegisterOnline
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.taPOnline = new System.Windows.Forms.TabPage();
            this.grCRegisterOnline = new DevExpress.XtraGrid.GridControl();
            this.grVRegisterOnline = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colOnRegisterDetailId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOnFullName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOnEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOnPhone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOnAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOnMessage = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOnCreatedTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblOnMessage = new DevExpress.XtraEditors.LabelControl();
            this.btnOnLoadDataOnline = new DevExpress.XtraEditors.SimpleButton();
            this.btnOnAddIntoSystem = new DevExpress.XtraEditors.SimpleButton();
            this.taPOffline = new System.Windows.Forms.TabPage();
            this.grCOffRegister = new DevExpress.XtraGrid.GridControl();
            this.grVOffRegister = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colRegisterDetailId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFullName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPhone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMessage = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreatedTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUserName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUpdateDateTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtOffStartTime = new DevExpress.XtraEditors.DateEdit();
            this.dtOffEndTime = new DevExpress.XtraEditors.DateEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.btnOffLoadDataOfEtraining = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.msgMessage)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.taPOnline.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grCRegisterOnline)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grVRegisterOnline)).BeginInit();
            this.panel1.SuspendLayout();
            this.taPOffline.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grCOffRegister)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grVOffRegister)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtOffStartTime.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtOffStartTime.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtOffEndTime.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtOffEndTime.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.taPOnline);
            this.tabControl1.Controls.Add(this.taPOffline);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1006, 502);
            this.tabControl1.TabIndex = 0;
            // 
            // taPOnline
            // 
            this.taPOnline.Controls.Add(this.grCRegisterOnline);
            this.taPOnline.Controls.Add(this.panel1);
            this.taPOnline.Location = new System.Drawing.Point(4, 22);
            this.taPOnline.Name = "taPOnline";
            this.taPOnline.Padding = new System.Windows.Forms.Padding(3);
            this.taPOnline.Size = new System.Drawing.Size(998, 476);
            this.taPOnline.TabIndex = 0;
            this.taPOnline.Text = "[ONLINE] Dữ liệu Đăng ký trực tuyến";
            this.taPOnline.UseVisualStyleBackColor = true;
            // 
            // grCRegisterOnline
            // 
            this.grCRegisterOnline.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grCRegisterOnline.Location = new System.Drawing.Point(3, 44);
            this.grCRegisterOnline.MainView = this.grVRegisterOnline;
            this.grCRegisterOnline.Name = "grCRegisterOnline";
            this.grCRegisterOnline.Size = new System.Drawing.Size(992, 429);
            this.grCRegisterOnline.TabIndex = 1;
            this.grCRegisterOnline.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grVRegisterOnline});
            // 
            // grVRegisterOnline
            // 
            this.grVRegisterOnline.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colOnRegisterDetailId,
            this.colOnFullName,
            this.colOnEmail,
            this.colOnPhone,
            this.colOnAddress,
            this.colOnMessage,
            this.colOnCreatedTime});
            this.grVRegisterOnline.GridControl = this.grCRegisterOnline;
            this.grVRegisterOnline.Name = "grVRegisterOnline";
            // 
            // colOnRegisterDetailId
            // 
            this.colOnRegisterDetailId.Caption = "Mã đk";
            this.colOnRegisterDetailId.FieldName = "RegisterDetailId";
            this.colOnRegisterDetailId.Name = "colOnRegisterDetailId";
            // 
            // colOnFullName
            // 
            this.colOnFullName.Caption = "Họ và Tên";
            this.colOnFullName.FieldName = "FullName";
            this.colOnFullName.Name = "colOnFullName";
            this.colOnFullName.Visible = true;
            this.colOnFullName.VisibleIndex = 0;
            this.colOnFullName.Width = 150;
            // 
            // colOnEmail
            // 
            this.colOnEmail.Caption = "Thư điện tử";
            this.colOnEmail.FieldName = "Email";
            this.colOnEmail.Name = "colOnEmail";
            this.colOnEmail.Visible = true;
            this.colOnEmail.VisibleIndex = 1;
            this.colOnEmail.Width = 120;
            // 
            // colOnPhone
            // 
            this.colOnPhone.Caption = "Điện thoại";
            this.colOnPhone.FieldName = "Phone";
            this.colOnPhone.Name = "colOnPhone";
            this.colOnPhone.Visible = true;
            this.colOnPhone.VisibleIndex = 2;
            this.colOnPhone.Width = 130;
            // 
            // colOnAddress
            // 
            this.colOnAddress.Caption = "Địa chỉ";
            this.colOnAddress.FieldName = "Address";
            this.colOnAddress.Name = "colOnAddress";
            this.colOnAddress.Visible = true;
            this.colOnAddress.VisibleIndex = 3;
            this.colOnAddress.Width = 150;
            // 
            // colOnMessage
            // 
            this.colOnMessage.Caption = "Tin nhắn";
            this.colOnMessage.FieldName = "Message";
            this.colOnMessage.Name = "colOnMessage";
            this.colOnMessage.Visible = true;
            this.colOnMessage.VisibleIndex = 4;
            this.colOnMessage.Width = 230;
            // 
            // colOnCreatedTime
            // 
            this.colOnCreatedTime.Caption = "Ngày đăng ký";
            this.colOnCreatedTime.FieldName = "CreatedTime";
            this.colOnCreatedTime.Name = "colOnCreatedTime";
            this.colOnCreatedTime.Visible = true;
            this.colOnCreatedTime.VisibleIndex = 5;
            this.colOnCreatedTime.Width = 130;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblOnMessage);
            this.panel1.Controls.Add(this.btnOnLoadDataOnline);
            this.panel1.Controls.Add(this.btnOnAddIntoSystem);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(992, 41);
            this.panel1.TabIndex = 0;
            // 
            // lblOnMessage
            // 
            this.lblOnMessage.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOnMessage.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblOnMessage.Appearance.Options.UseFont = true;
            this.lblOnMessage.Appearance.Options.UseForeColor = true;
            this.lblOnMessage.Location = new System.Drawing.Point(372, 13);
            this.lblOnMessage.Name = "lblOnMessage";
            this.lblOnMessage.Size = new System.Drawing.Size(51, 16);
            this.lblOnMessage.TabIndex = 4;
            this.lblOnMessage.Text = "message";
            this.lblOnMessage.Visible = false;
            // 
            // btnOnLoadDataOnline
            // 
            this.btnOnLoadDataOnline.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOnLoadDataOnline.Appearance.ForeColor = System.Drawing.Color.Green;
            this.btnOnLoadDataOnline.Appearance.Options.UseFont = true;
            this.btnOnLoadDataOnline.Appearance.Options.UseForeColor = true;
            this.btnOnLoadDataOnline.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnOnLoadDataOnline.Location = new System.Drawing.Point(5, 9);
            this.btnOnLoadDataOnline.Name = "btnOnLoadDataOnline";
            this.btnOnLoadDataOnline.Size = new System.Drawing.Size(176, 23);
            this.btnOnLoadDataOnline.TabIndex = 2;
            this.btnOnLoadDataOnline.Text = "Lấy dữ liệu từ Website IMIC";
            //this.btnOnLoadDataOnline.Click += new System.EventHandler(this.btnOnLoadDataOnline_Click);
            // 
            // btnOnAddIntoSystem
            // 
            this.btnOnAddIntoSystem.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOnAddIntoSystem.Appearance.ForeColor = System.Drawing.Color.Red;
            this.btnOnAddIntoSystem.Appearance.Options.UseFont = true;
            this.btnOnAddIntoSystem.Appearance.Options.UseForeColor = true;
            this.btnOnAddIntoSystem.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnOnAddIntoSystem.Location = new System.Drawing.Point(187, 9);
            this.btnOnAddIntoSystem.Name = "btnOnAddIntoSystem";
            this.btnOnAddIntoSystem.Size = new System.Drawing.Size(168, 23);
            this.btnOnAddIntoSystem.TabIndex = 3;
            this.btnOnAddIntoSystem.Text = "Đưa về hệ thống eTraining";
            this.btnOnAddIntoSystem.Visible = false;
            //this.btnOnAddIntoSystem.Click += new System.EventHandler(this.btnOnAddIntoSystem_Click);
            // 
            // taPOffline
            // 
            this.taPOffline.Controls.Add(this.grCOffRegister);
            this.taPOffline.Controls.Add(this.panel2);
            this.taPOffline.Location = new System.Drawing.Point(4, 22);
            this.taPOffline.Name = "taPOffline";
            this.taPOffline.Padding = new System.Windows.Forms.Padding(3);
            this.taPOffline.Size = new System.Drawing.Size(998, 476);
            this.taPOffline.TabIndex = 1;
            this.taPOffline.Text = "[OFFLINE] Dữ liệu đã lấy về hệ thống eTraining";
            this.taPOffline.UseVisualStyleBackColor = true;
            // 
            // grCOffRegister
            // 
            this.grCOffRegister.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grCOffRegister.Location = new System.Drawing.Point(3, 45);
            this.grCOffRegister.MainView = this.grVOffRegister;
            this.grCOffRegister.Name = "grCOffRegister";
            this.grCOffRegister.Size = new System.Drawing.Size(992, 428);
            this.grCOffRegister.TabIndex = 1;
            this.grCOffRegister.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grVOffRegister});
            // 
            // grVOffRegister
            // 
            this.grVOffRegister.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colRegisterDetailId,
            this.colFullName,
            this.colEmail,
            this.colPhone,
            this.colAddress,
            this.colMessage,
            this.colCreatedTime,
            this.colUserName,
            this.colUpdateDateTime});
            this.grVOffRegister.GridControl = this.grCOffRegister;
            this.grVOffRegister.Name = "grVOffRegister";
            // 
            // colRegisterDetailId
            // 
            this.colRegisterDetailId.Caption = "Mã đk";
            this.colRegisterDetailId.FieldName = "RegisterDetailId";
            this.colRegisterDetailId.Name = "colRegisterDetailId";
            // 
            // colFullName
            // 
            this.colFullName.Caption = "Họ và tên";
            this.colFullName.FieldName = "FullName";
            this.colFullName.Name = "colFullName";
            this.colFullName.Visible = true;
            this.colFullName.VisibleIndex = 0;
            this.colFullName.Width = 154;
            // 
            // colEmail
            // 
            this.colEmail.Caption = "Thư điện tử";
            this.colEmail.FieldName = "Email";
            this.colEmail.Name = "colEmail";
            this.colEmail.Visible = true;
            this.colEmail.VisibleIndex = 1;
            this.colEmail.Width = 76;
            // 
            // colPhone
            // 
            this.colPhone.Caption = "Điện thoại";
            this.colPhone.FieldName = "Phone";
            this.colPhone.Name = "colPhone";
            this.colPhone.Visible = true;
            this.colPhone.VisibleIndex = 2;
            this.colPhone.Width = 76;
            // 
            // colAddress
            // 
            this.colAddress.Caption = "Địa chỉ";
            this.colAddress.FieldName = "Address";
            this.colAddress.Name = "colAddress";
            this.colAddress.Visible = true;
            this.colAddress.VisibleIndex = 3;
            this.colAddress.Width = 115;
            // 
            // colMessage
            // 
            this.colMessage.Caption = "Tin nhắn";
            this.colMessage.FieldName = "Message";
            this.colMessage.Name = "colMessage";
            this.colMessage.Visible = true;
            this.colMessage.VisibleIndex = 4;
            this.colMessage.Width = 168;
            // 
            // colCreatedTime
            // 
            this.colCreatedTime.Caption = "Ngày đk";
            this.colCreatedTime.FieldName = "CreatedTime";
            this.colCreatedTime.Name = "colCreatedTime";
            this.colCreatedTime.Visible = true;
            this.colCreatedTime.VisibleIndex = 5;
            this.colCreatedTime.Width = 82;
            // 
            // colUserName
            // 
            this.colUserName.Caption = "Người thực hiện";
            this.colUserName.FieldName = "UserName";
            this.colUserName.Name = "colUserName";
            this.colUserName.Visible = true;
            this.colUserName.VisibleIndex = 6;
            this.colUserName.Width = 74;
            // 
            // colUpdateDateTime
            // 
            this.colUpdateDateTime.Caption = "Ngày thực hiện";
            this.colUpdateDateTime.FieldName = "UpdateDateTime";
            this.colUpdateDateTime.Name = "colUpdateDateTime";
            this.colUpdateDateTime.Visible = true;
            this.colUpdateDateTime.VisibleIndex = 7;
            this.colUpdateDateTime.Width = 100;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dtOffStartTime);
            this.panel2.Controls.Add(this.dtOffEndTime);
            this.panel2.Controls.Add(this.labelControl2);
            this.panel2.Controls.Add(this.labelControl9);
            this.panel2.Controls.Add(this.btnOffLoadDataOfEtraining);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(992, 42);
            this.panel2.TabIndex = 0;
            // 
            // dtOffStartTime
            // 
            this.dtOffStartTime.EditValue = null;
            this.dtOffStartTime.Location = new System.Drawing.Point(366, 11);
            this.dtOffStartTime.Name = "dtOffStartTime";
            this.dtOffStartTime.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.dtOffStartTime.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtOffStartTime.Properties.Appearance.Options.UseBackColor = true;
            this.dtOffStartTime.Properties.Appearance.Options.UseFont = true;
            this.dtOffStartTime.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtOffStartTime.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dtOffStartTime.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.dtOffStartTime.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtOffStartTime.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dtOffStartTime.Size = new System.Drawing.Size(194, 22);
            this.dtOffStartTime.TabIndex = 18;
            // 
            // dtOffEndTime
            // 
            this.dtOffEndTime.EditValue = null;
            this.dtOffEndTime.Enabled = false;
            this.dtOffEndTime.Location = new System.Drawing.Point(599, 11);
            this.dtOffEndTime.Name = "dtOffEndTime";
            this.dtOffEndTime.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.dtOffEndTime.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtOffEndTime.Properties.Appearance.Options.UseBackColor = true;
            this.dtOffEndTime.Properties.Appearance.Options.UseFont = true;
            this.dtOffEndTime.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtOffEndTime.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dtOffEndTime.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.dtOffEndTime.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtOffEndTime.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dtOffEndTime.Size = new System.Drawing.Size(193, 22);
            this.dtOffEndTime.TabIndex = 19;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(566, 15);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(32, 16);
            this.labelControl2.TabIndex = 16;
            this.labelControl2.Text = "Đến :";
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(313, 15);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(56, 16);
            this.labelControl9.TabIndex = 17;
            this.labelControl9.Text = "Từ ngày :";
            // 
            // btnOffLoadDataOfEtraining
            // 
            this.btnOffLoadDataOfEtraining.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOffLoadDataOfEtraining.Appearance.ForeColor = System.Drawing.Color.Green;
            this.btnOffLoadDataOfEtraining.Appearance.Options.UseFont = true;
            this.btnOffLoadDataOfEtraining.Appearance.Options.UseForeColor = true;
            this.btnOffLoadDataOfEtraining.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnOffLoadDataOfEtraining.Location = new System.Drawing.Point(5, 10);
            this.btnOffLoadDataOfEtraining.Name = "btnOffLoadDataOfEtraining";
            this.btnOffLoadDataOfEtraining.Size = new System.Drawing.Size(289, 23);
            this.btnOffLoadDataOfEtraining.TabIndex = 3;
            this.btnOffLoadDataOfEtraining.Text = "Xem dữ liệu hiện có trên hệ thống eTraining";
            this.btnOffLoadDataOfEtraining.Click += new System.EventHandler(this.btnOffLoadDataOfEtraining_Click);
            // 
            // frmStudentRegisterOnline
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 502);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmStudentRegisterOnline";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmStudentRegisterOnline";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            //this.Load += new System.EventHandler(this.frmStudentRegisterOnline_Load);
            ((System.ComponentModel.ISupportInitialize)(this.msgMessage)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.taPOnline.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grCRegisterOnline)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grVRegisterOnline)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.taPOffline.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grCOffRegister)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grVOffRegister)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtOffStartTime.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtOffStartTime.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtOffEndTime.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtOffEndTime.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage taPOnline;
        private System.Windows.Forms.TabPage taPOffline;
        private DevExpress.XtraGrid.GridControl grCRegisterOnline;
        private DevExpress.XtraGrid.Views.Grid.GridView grVRegisterOnline;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton btnOnLoadDataOnline;
        private DevExpress.XtraEditors.SimpleButton btnOnAddIntoSystem;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.SimpleButton btnOffLoadDataOfEtraining;
        private DevExpress.XtraGrid.GridControl grCOffRegister;
        private DevExpress.XtraGrid.Views.Grid.GridView grVOffRegister;
        private DevExpress.XtraGrid.Columns.GridColumn colRegisterDetailId;
        private DevExpress.XtraGrid.Columns.GridColumn colFullName;
        private DevExpress.XtraGrid.Columns.GridColumn colEmail;
        private DevExpress.XtraGrid.Columns.GridColumn colPhone;
        private DevExpress.XtraGrid.Columns.GridColumn colAddress;
        private DevExpress.XtraGrid.Columns.GridColumn colMessage;
        private DevExpress.XtraGrid.Columns.GridColumn colCreatedTime;
        private DevExpress.XtraGrid.Columns.GridColumn colUserName;
        private DevExpress.XtraGrid.Columns.GridColumn colUpdateDateTime;
        private DevExpress.XtraEditors.DateEdit dtOffStartTime;
        private DevExpress.XtraEditors.DateEdit dtOffEndTime;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraGrid.Columns.GridColumn colOnRegisterDetailId;
        private DevExpress.XtraGrid.Columns.GridColumn colOnFullName;
        private DevExpress.XtraGrid.Columns.GridColumn colOnEmail;
        private DevExpress.XtraGrid.Columns.GridColumn colOnPhone;
        private DevExpress.XtraGrid.Columns.GridColumn colOnAddress;
        private DevExpress.XtraGrid.Columns.GridColumn colOnMessage;
        private DevExpress.XtraGrid.Columns.GridColumn colOnCreatedTime;
        private DevExpress.XtraEditors.LabelControl lblOnMessage;
    }
}
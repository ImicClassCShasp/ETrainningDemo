namespace eCenterTrainning
{
    partial class frmAddKhoaHoc
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
            this.actionAddKhoaHoc = new eCenterTrainning.UseControls.ActionUpdateHocVien();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.lookUpEditSubject = new DevExpress.XtraEditors.LookUpEdit();
            this.txtCourseDescription = new System.Windows.Forms.TextBox();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtTotalPrice = new DevExpress.XtraEditors.TextEdit();
            this.txtCourseName = new DevExpress.XtraEditors.TextEdit();
            this.msgError = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditSubject.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCourseName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.msgError)).BeginInit();
            this.SuspendLayout();
            // 
            // actionAddKhoaHoc
            // 
            this.actionAddKhoaHoc.Dock = System.Windows.Forms.DockStyle.Top;
            this.actionAddKhoaHoc.Location = new System.Drawing.Point(0, 0);
            this.actionAddKhoaHoc.Name = "actionAddKhoaHoc";
            this.actionAddKhoaHoc.Size = new System.Drawing.Size(374, 50);
            this.actionAddKhoaHoc.TabIndex = 0;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.lookUpEditSubject);
            this.groupControl1.Controls.Add(this.txtCourseDescription);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.txtTotalPrice);
            this.groupControl1.Controls.Add(this.txtCourseName);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 50);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(374, 173);
            this.groupControl1.TabIndex = 1;
            // 
            // lookUpEditSubject
            // 
            this.lookUpEditSubject.Location = new System.Drawing.Point(112, 57);
            this.lookUpEditSubject.Name = "lookUpEditSubject";
            this.lookUpEditSubject.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditSubject.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Id", "Id", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SubjectName", "Môn học")});
            this.lookUpEditSubject.Properties.NullText = "---Chọn môn học---";
            this.lookUpEditSubject.Size = new System.Drawing.Size(255, 20);
            this.lookUpEditSubject.TabIndex = 10;
            // 
            // txtCourseDescription
            // 
            this.txtCourseDescription.Location = new System.Drawing.Point(112, 119);
            this.txtCourseDescription.MaxLength = 1000;
            this.txtCourseDescription.Multiline = true;
            this.txtCourseDescription.Name = "txtCourseDescription";
            this.txtCourseDescription.Size = new System.Drawing.Size(256, 47);
            this.txtCourseDescription.TabIndex = 9;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(16, 127);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(34, 13);
            this.labelControl3.TabIndex = 7;
            this.labelControl3.Text = "Mô tả :";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(16, 64);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(68, 13);
            this.labelControl2.TabIndex = 8;
            this.labelControl2.Text = "Ngôn ngữ (*):";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(16, 94);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(56, 13);
            this.labelControl4.TabIndex = 5;
            this.labelControl4.Text = "Học phí (*):";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(16, 32);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(85, 13);
            this.labelControl1.TabIndex = 5;
            this.labelControl1.Text = "Tên khóa học (*):";
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.Location = new System.Drawing.Point(112, 87);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.Properties.MaxLength = 500;
            this.txtTotalPrice.Size = new System.Drawing.Size(256, 20);
            this.txtTotalPrice.TabIndex = 4;
            // 
            // txtCourseName
            // 
            this.txtCourseName.Location = new System.Drawing.Point(112, 25);
            this.txtCourseName.Name = "txtCourseName";
            this.txtCourseName.Properties.MaxLength = 500;
            this.txtCourseName.Size = new System.Drawing.Size(256, 20);
            this.txtCourseName.TabIndex = 4;
            // 
            // msgError
            // 
            this.msgError.ContainerControl = this;
            // 
            // frmAddKhoaHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 223);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.actionAddKhoaHoc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmAddKhoaHoc";
            this.Text = "frmAddKhoaHoc";
            this.Load += new System.EventHandler(this.frmAddKhoaHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditSubject.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCourseName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.msgError)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private UseControls.ActionUpdateHocVien actionAddKhoaHoc;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.TextBox txtCourseDescription;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtCourseName;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditSubject;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider msgError;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtTotalPrice;
    }
}
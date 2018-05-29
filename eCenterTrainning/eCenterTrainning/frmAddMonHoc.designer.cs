namespace eCenterTrainning
{
    partial class frmAddMonHoc
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txtSubjectDescription = new System.Windows.Forms.TextBox();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtSubjectname = new DevExpress.XtraEditors.TextEdit();
            this.msgError = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            this.actionUpdateMonHoc = new eCenterTrainning.UseControls.ActionUpdateHocVien();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSubjectname.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.msgError)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.txtSubjectDescription);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.txtSubjectname);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 48);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(354, 129);
            this.groupControl1.TabIndex = 1;
            // 
            // txtSubjectDescription
            // 
            this.txtSubjectDescription.Location = new System.Drawing.Point(99, 60);
            this.txtSubjectDescription.MaxLength = 500;
            this.txtSubjectDescription.Multiline = true;
            this.txtSubjectDescription.Name = "txtSubjectDescription";
            this.txtSubjectDescription.Size = new System.Drawing.Size(243, 45);
            this.txtSubjectDescription.TabIndex = 2;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(30, 111);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(291, 13);
            this.labelControl4.TabIndex = 1;
            this.labelControl4.Text = "( Các mục gắn dấu * là những thông tin bắt buộc phải nhập )";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(5, 68);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(34, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Mô tả :";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(5, 33);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(88, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Tên ngôn ngữ (*):";
            // 
            // txtSubjectname
            // 
            this.txtSubjectname.Location = new System.Drawing.Point(99, 26);
            this.txtSubjectname.Name = "txtSubjectname";
            this.txtSubjectname.Properties.MaxLength = 250;
            this.txtSubjectname.Size = new System.Drawing.Size(243, 20);
            this.txtSubjectname.TabIndex = 1;
            // 
            // msgError
            // 
            this.msgError.ContainerControl = this;
            // 
            // actionUpdateMonHoc
            // 
            this.actionUpdateMonHoc.Dock = System.Windows.Forms.DockStyle.Top;
            this.actionUpdateMonHoc.Location = new System.Drawing.Point(0, 0);
            this.actionUpdateMonHoc.Name = "actionUpdateMonHoc";
            this.actionUpdateMonHoc.Size = new System.Drawing.Size(354, 48);
            this.actionUpdateMonHoc.TabIndex = 0;
            // 
            // frmAddMonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 177);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.actionUpdateMonHoc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmAddMonHoc";
            this.Text = "frmAddMonHoc";
            this.Load += new System.EventHandler(this.frmAddMonHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSubjectname.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.msgError)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private UseControls.ActionUpdateHocVien actionUpdateMonHoc;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.TextBox txtSubjectDescription;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtSubjectname;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider msgError;
        private DevExpress.XtraEditors.LabelControl labelControl4;
    }
}
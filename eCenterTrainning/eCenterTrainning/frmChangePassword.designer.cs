namespace eCenterTrainning
{
    partial class frmChangePassword
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
            this.actionUpdateChangepassword = new eCenterTrainning.Base.ActionUpdate();
            this.groupControlStanUser = new DevExpress.XtraEditors.GroupControl();
            this.linkLabelChangePassword = new System.Windows.Forms.LinkLabel();
            this.btnAddMoreDepartment = new DevExpress.XtraEditors.SimpleButton();
            this.txtPasswordAfter = new DevExpress.XtraEditors.TextEdit();
            this.txtOldPassword = new DevExpress.XtraEditors.TextEdit();
            this.txtPassword = new DevExpress.XtraEditors.TextEdit();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.msgMessage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlStanUser)).BeginInit();
            this.groupControlStanUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPasswordAfter.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOldPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // actionUpdateChangepassword
            // 
            this.actionUpdateChangepassword.Dock = System.Windows.Forms.DockStyle.Top;
            this.actionUpdateChangepassword.Location = new System.Drawing.Point(0, 0);
            this.actionUpdateChangepassword.Name = "actionUpdateChangepassword";
            this.actionUpdateChangepassword.Size = new System.Drawing.Size(331, 50);
            this.actionUpdateChangepassword.TabIndex = 0;
            // 
            // groupControlStanUser
            // 
            this.groupControlStanUser.Controls.Add(this.linkLabelChangePassword);
            this.groupControlStanUser.Controls.Add(this.btnAddMoreDepartment);
            this.groupControlStanUser.Controls.Add(this.txtPasswordAfter);
            this.groupControlStanUser.Controls.Add(this.txtOldPassword);
            this.groupControlStanUser.Controls.Add(this.txtPassword);
            this.groupControlStanUser.Controls.Add(this.labelControl11);
            this.groupControlStanUser.Controls.Add(this.labelControl1);
            this.groupControlStanUser.Controls.Add(this.labelControl8);
            this.groupControlStanUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControlStanUser.Location = new System.Drawing.Point(0, 50);
            this.groupControlStanUser.Name = "groupControlStanUser";
            this.groupControlStanUser.Size = new System.Drawing.Size(331, 148);
            this.groupControlStanUser.TabIndex = 3;
            this.groupControlStanUser.Text = "Thông Tin Người Dùng";
            // 
            // linkLabelChangePassword
            // 
            this.linkLabelChangePassword.AutoSize = true;
            this.linkLabelChangePassword.Location = new System.Drawing.Point(455, 297);
            this.linkLabelChangePassword.Name = "linkLabelChangePassword";
            this.linkLabelChangePassword.Size = new System.Drawing.Size(127, 13);
            this.linkLabelChangePassword.TabIndex = 14;
            this.linkLabelChangePassword.TabStop = true;
            this.linkLabelChangePassword.Text = "Đổi mật khẩu người dùng";
            // 
            // btnAddMoreDepartment
            // 
            this.btnAddMoreDepartment.ImageOptions.Image = global::eCenterTrainning.Properties.Resources._103;
            this.btnAddMoreDepartment.Location = new System.Drawing.Point(559, 36);
            this.btnAddMoreDepartment.Name = "btnAddMoreDepartment";
            this.btnAddMoreDepartment.Size = new System.Drawing.Size(23, 20);
            this.btnAddMoreDepartment.TabIndex = 4;
            // 
            // txtPasswordAfter
            // 
            this.txtPasswordAfter.Location = new System.Drawing.Point(127, 112);
            this.txtPasswordAfter.Name = "txtPasswordAfter";
            this.txtPasswordAfter.Properties.MaxLength = 150;
            this.txtPasswordAfter.Properties.UseSystemPasswordChar = true;
            this.txtPasswordAfter.Size = new System.Drawing.Size(194, 20);
            this.txtPasswordAfter.TabIndex = 3;
            // 
            // txtOldPassword
            // 
            this.txtOldPassword.Enabled = false;
            this.txtOldPassword.Location = new System.Drawing.Point(127, 41);
            this.txtOldPassword.Name = "txtOldPassword";
            this.txtOldPassword.Properties.MaxLength = 150;
            this.txtOldPassword.Properties.UseSystemPasswordChar = true;
            this.txtOldPassword.Size = new System.Drawing.Size(194, 20);
            this.txtOldPassword.TabIndex = 1;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(127, 76);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Properties.MaxLength = 150;
            this.txtPassword.Properties.UseSystemPasswordChar = true;
            this.txtPassword.Size = new System.Drawing.Size(194, 20);
            this.txtPassword.TabIndex = 2;
            // 
            // labelControl11
            // 
            this.labelControl11.Location = new System.Drawing.Point(18, 116);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(106, 13);
            this.labelControl11.TabIndex = 3;
            this.labelControl11.Text = "Mật Khẩu nhập lại (*):";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(18, 45);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(71, 13);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Mật Khẩu Cũ  :";
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(18, 80);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(88, 13);
            this.labelControl8.TabIndex = 3;
            this.labelControl8.Text = "Mật Khẩu Mới (*) :";
            // 
            // frmChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 198);
            this.Controls.Add(this.groupControlStanUser);
            this.Controls.Add(this.actionUpdateChangepassword);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmChangePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmChangePassword";
            this.Load += new System.EventHandler(this.frmChangePassword_Load);
            ((System.ComponentModel.ISupportInitialize)(this.msgMessage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlStanUser)).EndInit();
            this.groupControlStanUser.ResumeLayout(false);
            this.groupControlStanUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPasswordAfter.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOldPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Base.ActionUpdate actionUpdateChangepassword;
        private DevExpress.XtraEditors.GroupControl groupControlStanUser;
        private System.Windows.Forms.LinkLabel linkLabelChangePassword;
        private DevExpress.XtraEditors.SimpleButton btnAddMoreDepartment;
        private DevExpress.XtraEditors.TextEdit txtPasswordAfter;
        private DevExpress.XtraEditors.TextEdit txtOldPassword;
        private DevExpress.XtraEditors.TextEdit txtPassword;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl8;

    }
}
namespace eCenterTrainning
{
    partial class frmSocialNetworkCategory
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
            this.actionUpdateSocialNetworkCategory = new eCenterTrainning.Base.ActionUpdate();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.checkEditChooseParent = new DevExpress.XtraEditors.CheckEdit();
            this.txtMota = new System.Windows.Forms.TextBox();
            this.lookUpEditNameCategory = new DevExpress.XtraEditors.LookUpEdit();
            this.txtNameCategory = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.msgMessage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditChooseParent.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditNameCategory.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNameCategory.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // actionUpdateSocialNetworkCategory
            // 
            this.actionUpdateSocialNetworkCategory.Dock = System.Windows.Forms.DockStyle.Top;
            this.actionUpdateSocialNetworkCategory.Location = new System.Drawing.Point(0, 0);
            this.actionUpdateSocialNetworkCategory.Name = "actionUpdateSocialNetworkCategory";
            this.actionUpdateSocialNetworkCategory.Size = new System.Drawing.Size(465, 50);
            this.actionUpdateSocialNetworkCategory.TabIndex = 0;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.checkEditChooseParent);
            this.groupControl1.Controls.Add(this.txtMota);
            this.groupControl1.Controls.Add(this.lookUpEditNameCategory);
            this.groupControl1.Controls.Add(this.txtNameCategory);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 50);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(465, 221);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Thông tin danh mục";
            // 
            // checkEditChooseParent
            // 
            this.checkEditChooseParent.Location = new System.Drawing.Point(394, 72);
            this.checkEditChooseParent.Name = "checkEditChooseParent";
            this.checkEditChooseParent.Properties.Caption = "Chọn";
            this.checkEditChooseParent.Size = new System.Drawing.Size(54, 19);
            this.checkEditChooseParent.TabIndex = 3;
            this.checkEditChooseParent.CheckedChanged += new System.EventHandler(this.checkEditChooseParent_CheckedChanged);
            // 
            // txtMota
            // 
            this.txtMota.Location = new System.Drawing.Point(121, 107);
            this.txtMota.MaxLength = 1000;
            this.txtMota.Multiline = true;
            this.txtMota.Name = "txtMota";
            this.txtMota.Size = new System.Drawing.Size(327, 100);
            this.txtMota.TabIndex = 4;
            // 
            // lookUpEditNameCategory
            // 
            this.lookUpEditNameCategory.Location = new System.Drawing.Point(121, 71);
            this.lookUpEditNameCategory.Name = "lookUpEditNameCategory";
            this.lookUpEditNameCategory.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditNameCategory.Properties.NullText = "--- Chọn danh mục ---";
            this.lookUpEditNameCategory.Properties.ReadOnly = true;
            this.lookUpEditNameCategory.Size = new System.Drawing.Size(267, 20);
            this.lookUpEditNameCategory.TabIndex = 2;
            // 
            // txtNameCategory
            // 
            this.txtNameCategory.Location = new System.Drawing.Point(121, 36);
            this.txtNameCategory.Name = "txtNameCategory";
            this.txtNameCategory.Properties.MaxLength = 250;
            this.txtNameCategory.Size = new System.Drawing.Size(327, 20);
            this.txtNameCategory.TabIndex = 1;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(21, 107);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(34, 13);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "Mô tả :";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(21, 40);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(94, 13);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Tên danh mục  (*) :";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(21, 75);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(74, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Danh mục cha :";
            // 
            // frmSocialNetworkCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 271);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.actionUpdateSocialNetworkCategory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmSocialNetworkCategory";
            this.Text = "frmSocialNetworkCategory";
            this.Load += new System.EventHandler(this.frmSocialNetworkCategory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.msgMessage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditChooseParent.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditNameCategory.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNameCategory.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Base.ActionUpdate actionUpdateSocialNetworkCategory;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditNameCategory;
        private DevExpress.XtraEditors.TextEdit txtNameCategory;
        private DevExpress.XtraEditors.CheckEdit checkEditChooseParent;
        private System.Windows.Forms.TextBox txtMota;
    }
}
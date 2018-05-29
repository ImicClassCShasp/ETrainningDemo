namespace eCenterTrainning
{
    partial class frmThongTinChucVu
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
            this.actionUpdateChucVu = new eCenterTrainning.Base.ActionUpdate();
            this.groupControlChucVu = new DevExpress.XtraEditors.GroupControl();
            this.btnChonLink = new DevExpress.XtraEditors.SimpleButton();
            this.txtMoTa = new System.Windows.Forms.TextBox();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtDuongDan = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtTen = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.msgMessage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlChucVu)).BeginInit();
            this.groupControlChucVu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDuongDan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTen.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // actionUpdateChucVu
            // 
            this.actionUpdateChucVu.Dock = System.Windows.Forms.DockStyle.Top;
            this.actionUpdateChucVu.Location = new System.Drawing.Point(0, 0);
            this.actionUpdateChucVu.Name = "actionUpdateChucVu";
            this.actionUpdateChucVu.Size = new System.Drawing.Size(449, 57);
            this.actionUpdateChucVu.TabIndex = 0;
            // 
            // groupControlChucVu
            // 
            this.groupControlChucVu.Controls.Add(this.btnChonLink);
            this.groupControlChucVu.Controls.Add(this.txtMoTa);
            this.groupControlChucVu.Controls.Add(this.labelControl4);
            this.groupControlChucVu.Controls.Add(this.txtDuongDan);
            this.groupControlChucVu.Controls.Add(this.labelControl3);
            this.groupControlChucVu.Controls.Add(this.txtTen);
            this.groupControlChucVu.Controls.Add(this.labelControl1);
            this.groupControlChucVu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControlChucVu.Location = new System.Drawing.Point(0, 57);
            this.groupControlChucVu.Name = "groupControlChucVu";
            this.groupControlChucVu.Size = new System.Drawing.Size(449, 198);
            this.groupControlChucVu.TabIndex = 1;
            this.groupControlChucVu.Text = "Thông tin chức vụ ";
            // 
            // btnChonLink
            // 
            this.btnChonLink.Image = global::eCenterTrainning.Properties.Resources.folder;
            this.btnChonLink.Location = new System.Drawing.Point(366, 74);
            this.btnChonLink.Name = "btnChonLink";
            this.btnChonLink.Size = new System.Drawing.Size(22, 20);
            this.btnChonLink.TabIndex = 4;
            this.btnChonLink.Click += new System.EventHandler(this.btnChonLink_Click);
            // 
            // txtMoTa
            // 
            this.txtMoTa.Location = new System.Drawing.Point(117, 108);
            this.txtMoTa.MaxLength = 500;
            this.txtMoTa.Multiline = true;
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.Size = new System.Drawing.Size(321, 80);
            this.txtMoTa.TabIndex = 5;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(26, 108);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(36, 13);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "Mô Tả :";
            // 
            // txtDuongDan
            // 
            this.txtDuongDan.Enabled = false;
            this.txtDuongDan.Location = new System.Drawing.Point(117, 74);
            this.txtDuongDan.Name = "txtDuongDan";
            this.txtDuongDan.Size = new System.Drawing.Size(237, 20);
            this.txtDuongDan.TabIndex = 3;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(26, 78);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(62, 13);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "Đường Dẫn :";
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(117, 41);
            this.txtTen.Name = "txtTen";
            this.txtTen.Properties.MaxLength = 250;
            this.txtTen.Size = new System.Drawing.Size(237, 20);
            this.txtTen.TabIndex = 1;
            //this.txtTen.Leave += new System.EventHandler(this.txtTen_Leave);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(26, 45);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(85, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Tên Chức Vụ (*) :";
            // 
            // frmThongTinChucVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 255);
            this.Controls.Add(this.groupControlChucVu);
            this.Controls.Add(this.actionUpdateChucVu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmThongTinChucVu";
            this.Text = "frmThongTinChucVu";
            this.Load += new System.EventHandler(this.frmThongTinChucVu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.msgMessage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlChucVu)).EndInit();
            this.groupControlChucVu.ResumeLayout(false);
            this.groupControlChucVu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDuongDan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTen.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Base.ActionUpdate actionUpdateChucVu;
        private DevExpress.XtraEditors.GroupControl groupControlChucVu;
        private System.Windows.Forms.TextBox txtMoTa;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtDuongDan;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtTen;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnChonLink;
    }
}
namespace eCenterTrainning
{
    partial class frmSchedulesAdd
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
            this.actionUpdate = new eCenterTrainning.Base.ActionUpdate();
            this.groupControlGiangVien = new DevExpress.XtraEditors.GroupControl();
            this.txtNoiDung = new System.Windows.Forms.TextBox();
            this.uluGiangVien = new DevExpress.XtraEditors.LookUpEdit();
            this.uluLopHoc = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.msgMessage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlGiangVien)).BeginInit();
            this.groupControlGiangVien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uluGiangVien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uluLopHoc.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // actionUpdate
            // 
            this.actionUpdate.Dock = System.Windows.Forms.DockStyle.Top;
            this.actionUpdate.Location = new System.Drawing.Point(0, 0);
            this.actionUpdate.Name = "actionUpdate";
            this.actionUpdate.Size = new System.Drawing.Size(448, 50);
            this.actionUpdate.TabIndex = 0;
            // 
            // groupControlGiangVien
            // 
            this.groupControlGiangVien.Controls.Add(this.txtNoiDung);
            this.groupControlGiangVien.Controls.Add(this.uluGiangVien);
            this.groupControlGiangVien.Controls.Add(this.uluLopHoc);
            this.groupControlGiangVien.Controls.Add(this.labelControl5);
            this.groupControlGiangVien.Controls.Add(this.labelControl2);
            this.groupControlGiangVien.Controls.Add(this.labelControl1);
            this.groupControlGiangVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControlGiangVien.Location = new System.Drawing.Point(0, 50);
            this.groupControlGiangVien.Name = "groupControlGiangVien";
            this.groupControlGiangVien.Size = new System.Drawing.Size(448, 212);
            this.groupControlGiangVien.TabIndex = 1;
            this.groupControlGiangVien.Text = "Nhập thông tin Nhật ký";
            // 
            // txtNoiDung
            // 
            this.txtNoiDung.Location = new System.Drawing.Point(106, 101);
            this.txtNoiDung.MaxLength = 1000;
            this.txtNoiDung.Multiline = true;
            this.txtNoiDung.Name = "txtNoiDung";
            this.txtNoiDung.Size = new System.Drawing.Size(332, 103);
            this.txtNoiDung.TabIndex = 13;
            // 
            // uluGiangVien
            // 
            this.uluGiangVien.Location = new System.Drawing.Point(106, 70);
            this.uluGiangVien.Name = "uluGiangVien";
            this.uluGiangVien.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.uluGiangVien.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Id", "ID", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ExpertName", "ExpertName")});
            this.uluGiangVien.Properties.NullText = "--- Chọn Giảng Viên ---";
            this.uluGiangVien.Size = new System.Drawing.Size(332, 20);
            this.uluGiangVien.TabIndex = 9;
            // 
            // uluLopHoc
            // 
            this.uluLopHoc.Location = new System.Drawing.Point(106, 38);
            this.uluLopHoc.Name = "uluLopHoc";
            this.uluLopHoc.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.uluLopHoc.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Id", "ID", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ClassName", "ClassName")});
            this.uluLopHoc.Properties.NullText = "--- Chọn Lớp Học ---";
            this.uluLopHoc.Size = new System.Drawing.Size(332, 20);
            this.uluLopHoc.TabIndex = 9;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(21, 104);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(63, 13);
            this.labelControl5.TabIndex = 8;
            this.labelControl5.Text = "Nội dung (*):";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(21, 73);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(71, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Giảng viên (*):";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(21, 41);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(58, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Lớp học (*):";
            // 
            // frmSchedulesAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 262);
            this.Controls.Add(this.groupControlGiangVien);
            this.Controls.Add(this.actionUpdate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmSchedulesAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm nhật ký cho Chuyên Gia";
            this.Load += new System.EventHandler(this.frmSchedulesAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.msgMessage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlGiangVien)).EndInit();
            this.groupControlGiangVien.ResumeLayout(false);
            this.groupControlGiangVien.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uluGiangVien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uluLopHoc.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Base.ActionUpdate actionUpdate;
        private DevExpress.XtraEditors.GroupControl groupControlGiangVien;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LookUpEdit uluLopHoc;
        private System.Windows.Forms.TextBox txtNoiDung;
        private DevExpress.XtraEditors.LookUpEdit uluGiangVien;
    }
}
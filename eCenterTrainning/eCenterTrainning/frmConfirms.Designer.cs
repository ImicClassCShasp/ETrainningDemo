namespace eCenterTrainning
{
    partial class frmConfirms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConfirms));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblMaCapPhep = new DevExpress.XtraEditors.LabelControl();
            this.lblThoiGianCapP = new DevExpress.XtraEditors.LabelControl();
            this.txtLyDo = new System.Windows.Forms.TextBox();
            this.btnCapPhepTN = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnCapPhepTN);
            this.groupControl1.Controls.Add(this.txtLyDo);
            this.groupControl1.Controls.Add(this.lblThoiGianCapP);
            this.groupControl1.Controls.Add(this.lblMaCapPhep);
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(519, 296);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Yêu cầu từ hệ thống";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(496, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "- Mã cấp phép tự động :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "- Thời gian cấp phép :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(399, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "- Lý do xin cấp phép sử dụng tính năng tìm kiếm của bạn là gì???";
            // 
            // lblMaCapPhep
            // 
            this.lblMaCapPhep.Appearance.Font = new System.Drawing.Font("Cambria", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaCapPhep.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblMaCapPhep.Appearance.Options.UseFont = true;
            this.lblMaCapPhep.Appearance.Options.UseForeColor = true;
            this.lblMaCapPhep.Location = new System.Drawing.Point(168, 86);
            this.lblMaCapPhep.Name = "lblMaCapPhep";
            this.lblMaCapPhep.Size = new System.Drawing.Size(86, 17);
            this.lblMaCapPhep.TabIndex = 2;
            this.lblMaCapPhep.Text = "Mã cấp phép";
            // 
            // lblThoiGianCapP
            // 
            this.lblThoiGianCapP.Appearance.Font = new System.Drawing.Font("Cambria", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThoiGianCapP.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblThoiGianCapP.Appearance.Options.UseFont = true;
            this.lblThoiGianCapP.Appearance.Options.UseForeColor = true;
            this.lblThoiGianCapP.Location = new System.Drawing.Point(168, 115);
            this.lblThoiGianCapP.Name = "lblThoiGianCapP";
            this.lblThoiGianCapP.Size = new System.Drawing.Size(95, 17);
            this.lblThoiGianCapP.TabIndex = 2;
            this.lblThoiGianCapP.Text = "Thời gian cấp";
            // 
            // txtLyDo
            // 
            this.txtLyDo.Location = new System.Drawing.Point(15, 171);
            this.txtLyDo.Multiline = true;
            this.txtLyDo.Name = "txtLyDo";
            this.txtLyDo.Size = new System.Drawing.Size(493, 87);
            this.txtLyDo.TabIndex = 3;
            //this.txtLyDo.TextChanged += new System.EventHandler(this.txtLyDo_TextChanged);
            // 
            // btnCapPhepTN
            // 
            this.btnCapPhepTN.Appearance.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapPhepTN.Appearance.ForeColor = System.Drawing.Color.Red;
            this.btnCapPhepTN.Appearance.Options.UseFont = true;
            this.btnCapPhepTN.Appearance.Options.UseForeColor = true;
            this.btnCapPhepTN.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnCapPhepTN.Enabled = false;
            this.btnCapPhepTN.Location = new System.Drawing.Point(320, 264);
            this.btnCapPhepTN.Name = "btnCapPhepTN";
            this.btnCapPhepTN.Size = new System.Drawing.Size(187, 23);
            this.btnCapPhepTN.TabIndex = 4;
            this.btnCapPhepTN.Text = "Xác Nhận";
            //this.btnCapPhepTN.Click += new System.EventHandler(this.btnCapPhepTN_Click);
            // 
            // frmConfirms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 296);
            this.ControlBox = false;
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmConfirms";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xác nhận xin cấp phép tìm kiếm theo thời gian";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnCapPhepTN;
        private System.Windows.Forms.TextBox txtLyDo;
        private DevExpress.XtraEditors.LabelControl lblThoiGianCapP;
        private DevExpress.XtraEditors.LabelControl lblMaCapPhep;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
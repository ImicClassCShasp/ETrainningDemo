namespace eCenterTrainning.Base
{
    partial class frmIMICBase
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
            this.msgMessage = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.msgMessage)).BeginInit();
            this.SuspendLayout();
            // 
            // msgMessage
            // 
            this.msgMessage.ContainerControl = this;
            // 
            // frmStanfordBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Name = "frmStanfordBase";
            this.Text = "frmStanfordBase";
            ((System.ComponentModel.ISupportInitialize)(this.msgMessage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ErrorProvider msgMessage;
    }
}
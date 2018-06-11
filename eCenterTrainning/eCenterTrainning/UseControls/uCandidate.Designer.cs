namespace eCenterTrainning.UseControls
{
    partial class uCandidate
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uCandidate));
            this.actionMenuCandidate = new eCenterTrainning.Base.ActionMenu();
            this.groupControlTimKiem = new DevExpress.XtraEditors.GroupControl();
            this.lookUpEditRecruiment = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.lookUpEditChucVu = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gridControlCandidates = new DevExpress.XtraGrid.GridControl();
            this.gridViewCandidates = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSex = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateSent = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRecruitment = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colViTri = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHoSo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemHyperLinkEditCV = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.groupControlTimKiem)).BeginInit();
            this.groupControlTimKiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditRecruiment.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditChucVu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCandidates)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCandidates)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHyperLinkEditCV)).BeginInit();
            this.SuspendLayout();
            // 
            // actionMenuCandidate
            // 
            this.actionMenuCandidate.Dock = System.Windows.Forms.DockStyle.Top;
            this.actionMenuCandidate.Location = new System.Drawing.Point(0, 0);
            this.actionMenuCandidate.Name = "actionMenuCandidate";
            this.actionMenuCandidate.Size = new System.Drawing.Size(809, 50);
            this.actionMenuCandidate.TabIndex = 10;
            // 
            // groupControlTimKiem
            // 
            this.groupControlTimKiem.Controls.Add(this.lookUpEditRecruiment);
            this.groupControlTimKiem.Controls.Add(this.labelControl2);
            this.groupControlTimKiem.Controls.Add(this.lookUpEditChucVu);
            this.groupControlTimKiem.Controls.Add(this.labelControl1);
            this.groupControlTimKiem.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControlTimKiem.Location = new System.Drawing.Point(0, 50);
            this.groupControlTimKiem.Name = "groupControlTimKiem";
            this.groupControlTimKiem.Size = new System.Drawing.Size(809, 65);
            this.groupControlTimKiem.TabIndex = 12;
            this.groupControlTimKiem.Text = "Thông tin tìm kiếm";
            // 
            // lookUpEditRecruiment
            // 
            this.lookUpEditRecruiment.Location = new System.Drawing.Point(113, 31);
            this.lookUpEditRecruiment.Name = "lookUpEditRecruiment";
            this.lookUpEditRecruiment.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditRecruiment.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Id", "Id", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Đợt Tuyển Dụng")});
            this.lookUpEditRecruiment.Properties.NullText = "--- Chọn Đợt Tuyển Tuyển Dụng ---";
            this.lookUpEditRecruiment.Size = new System.Drawing.Size(257, 20);
            this.lookUpEditRecruiment.TabIndex = 1;
            this.lookUpEditRecruiment.EditValueChanged += new System.EventHandler(this.lookUpEditRecruiment_EditValueChanged);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(21, 35);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(86, 13);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Đợt Tuyển Dụng :";
            // 
            // lookUpEditChucVu
            // 
            this.lookUpEditChucVu.Location = new System.Drawing.Point(441, 32);
            this.lookUpEditChucVu.Name = "lookUpEditChucVu";
            this.lookUpEditChucVu.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditChucVu.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Id", "Id", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("JobTitle1", "Vị Trí Tuyển Dụng")});
            this.lookUpEditChucVu.Properties.NullText = "--- Chọn Vị Trí  ---";
            this.lookUpEditChucVu.Size = new System.Drawing.Size(140, 20);
            this.lookUpEditChucVu.TabIndex = 2;
            //this.lookUpEditChucVu.EditValueChanged += new System.EventHandler(this.lookUpEditChucVu_EditValueChanged);
            //this.lookUpEditChucVu.TextChanged += new System.EventHandler(this.lookUpEditChucVu_TextChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(401, 35);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(33, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Vị Trí  :";
            // 
            // gridControlCandidates
            // 
            this.gridControlCandidates.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlCandidates.Location = new System.Drawing.Point(0, 115);
            this.gridControlCandidates.MainView = this.gridViewCandidates;
            this.gridControlCandidates.Name = "gridControlCandidates";
            this.gridControlCandidates.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemHyperLinkEditCV});
            this.gridControlCandidates.Size = new System.Drawing.Size(809, 384);
            this.gridControlCandidates.TabIndex = 13;
            this.gridControlCandidates.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewCandidates});
            this.gridControlCandidates.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.gridControlCandidates_MouseDoubleClick);
            // 
            // gridViewCandidates
            // 
            this.gridViewCandidates.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colName,
            this.colSex,
            this.colDateSent,
            this.colRecruitment,
            this.colViTri,
            this.colHoSo});
            this.gridViewCandidates.GridControl = this.gridControlCandidates;
            this.gridViewCandidates.Name = "gridViewCandidates";
            this.gridViewCandidates.OptionsBehavior.Editable = false;
            this.gridViewCandidates.OptionsView.ShowAutoFilterRow = true;
            this.gridViewCandidates.OptionsView.ShowFooter = true;
            this.gridViewCandidates.OptionsView.ShowGroupPanel = false;
            this.gridViewCandidates.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gridViewCandidates_RowCellClick);
            // 
            // colId
            // 
            this.colId.Caption = "Id";
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            // 
            // colName
            // 
            this.colName.Caption = "Tên";
            this.colName.FieldName = "FullName";
            this.colName.Name = "colName";
            this.colName.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colName.Visible = true;
            this.colName.VisibleIndex = 0;
            this.colName.Width = 177;
            // 
            // colSex
            // 
            this.colSex.Caption = "Giới Tính";
            this.colSex.FieldName = "SexString";
            this.colSex.Name = "colSex";
            this.colSex.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colSex.Visible = true;
            this.colSex.VisibleIndex = 1;
            this.colSex.Width = 56;
            // 
            // colDateSent
            // 
            this.colDateSent.Caption = "Ngày Gửi";
            this.colDateSent.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.colDateSent.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colDateSent.FieldName = "DateSent";
            this.colDateSent.Name = "colDateSent";
            this.colDateSent.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colDateSent.Visible = true;
            this.colDateSent.VisibleIndex = 2;
            this.colDateSent.Width = 73;
            // 
            // colRecruitment
            // 
            this.colRecruitment.Caption = "Đợt Tuyển Dụng";
            this.colRecruitment.FieldName = "Name";
            this.colRecruitment.Name = "colRecruitment";
            this.colRecruitment.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colRecruitment.Visible = true;
            this.colRecruitment.VisibleIndex = 3;
            this.colRecruitment.Width = 300;
            // 
            // colViTri
            // 
            this.colViTri.Caption = "Vị Trí";
            this.colViTri.FieldName = "JobTitle";
            this.colViTri.Name = "colViTri";
            this.colViTri.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colViTri.Visible = true;
            this.colViTri.VisibleIndex = 4;
            this.colViTri.Width = 74;
            // 
            // colHoSo
            // 
            this.colHoSo.ColumnEdit = this.repositoryItemHyperLinkEditCV;
            this.colHoSo.Name = "colHoSo";
            this.colHoSo.Visible = true;
            this.colHoSo.VisibleIndex = 5;
            this.colHoSo.Width = 111;
            // 
            // repositoryItemHyperLinkEditCV
            // 
            this.repositoryItemHyperLinkEditCV.AccessibleName = "";
            this.repositoryItemHyperLinkEditCV.AutoHeight = false;
            this.repositoryItemHyperLinkEditCV.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemHyperLinkEditCV.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Hồ sơ", null, 0)});
            this.repositoryItemHyperLinkEditCV.Name = "repositoryItemHyperLinkEditCV";
            this.repositoryItemHyperLinkEditCV.NullText = "Hồ Sơ";
            this.repositoryItemHyperLinkEditCV.NullValuePrompt = "Hồ Sơ";
            this.repositoryItemHyperLinkEditCV.SmallImages = this.imageList1;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "002.png");
            // 
            // uCandidate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControlCandidates);
            this.Controls.Add(this.groupControlTimKiem);
            this.Controls.Add(this.actionMenuCandidate);
            this.Name = "uCandidate";
            this.Size = new System.Drawing.Size(809, 499);
            this.Load += new System.EventHandler(this.uCandidate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControlTimKiem)).EndInit();
            this.groupControlTimKiem.ResumeLayout(false);
            this.groupControlTimKiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditRecruiment.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditChucVu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCandidates)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCandidates)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHyperLinkEditCV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Base.ActionMenu actionMenuCandidate;
        private DevExpress.XtraEditors.GroupControl groupControlTimKiem;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl gridControlCandidates;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewCandidates;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colSex;
        private DevExpress.XtraGrid.Columns.GridColumn colDateSent;
        private DevExpress.XtraGrid.Columns.GridColumn colRecruitment;
        private DevExpress.XtraGrid.Columns.GridColumn colViTri;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditChucVu;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditRecruiment;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraGrid.Columns.GridColumn colHoSo;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox repositoryItemHyperLinkEditCV;
        private System.Windows.Forms.ImageList imageList1;
    }
}

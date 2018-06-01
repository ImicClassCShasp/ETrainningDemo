namespace eCenterTrainning.UseControls
{
    partial class ControlLopHoc
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
            this.actionMenu1 = new eCenterTrainning.Base.ActionMenu();
            this.gridControlClass = new DevExpress.XtraGrid.GridControl();
            this.gridViewClass = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ColClassName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColStartDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColToDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColSoLuongSinhVien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColPlaceTraining = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColGiangVien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColMota = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlClass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewClass)).BeginInit();
            this.SuspendLayout();
            // 
            // actionMenu1
            // 
            this.actionMenu1.Dock = System.Windows.Forms.DockStyle.Top;
            this.actionMenu1.Location = new System.Drawing.Point(0, 0);
            this.actionMenu1.Name = "actionMenu1";
            this.actionMenu1.Size = new System.Drawing.Size(833, 51);
            this.actionMenu1.TabIndex = 0;
            // 
            // gridControlClass
            // 
            this.gridControlClass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlClass.Location = new System.Drawing.Point(0, 51);
            this.gridControlClass.MainView = this.gridViewClass;
            this.gridControlClass.Name = "gridControlClass";
            this.gridControlClass.Size = new System.Drawing.Size(833, 390);
            this.gridControlClass.TabIndex = 1;
            this.gridControlClass.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewClass});
            // 
            // gridViewClass
            // 
            this.gridViewClass.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ColClassName,
            this.ColStartDate,
            this.ColToDate,
            this.ColSoLuongSinhVien,
            this.ColPlaceTraining,
            this.ColGiangVien,
            this.ColMota});
            this.gridViewClass.GridControl = this.gridControlClass;
            this.gridViewClass.Name = "gridViewClass";
            this.gridViewClass.OptionsBehavior.Editable = false;
            this.gridViewClass.OptionsView.ShowAutoFilterRow = true;
            this.gridViewClass.OptionsView.ShowFooter = true;
            this.gridViewClass.OptionsView.ShowGroupPanel = false;
            // 
            // ColClassName
            // 
            this.ColClassName.Caption = "Lớp học";
            this.ColClassName.FieldName = "ClassName";
            this.ColClassName.Name = "ColClassName";
            this.ColClassName.Visible = true;
            this.ColClassName.VisibleIndex = 0;
            // 
            // ColStartDate
            // 
            this.ColStartDate.Caption = "Ngày bắt đầu";
            this.ColStartDate.FieldName = "FromDate";
            this.ColStartDate.Name = "ColStartDate";
            this.ColStartDate.Visible = true;
            this.ColStartDate.VisibleIndex = 1;
            // 
            // ColToDate
            // 
            this.ColToDate.Caption = "Ngày kết thúc";
            this.ColToDate.FieldName = "ToDate";
            this.ColToDate.Name = "ColToDate";
            this.ColToDate.Visible = true;
            this.ColToDate.VisibleIndex = 2;
            // 
            // ColSoLuongSinhVien
            // 
            this.ColSoLuongSinhVien.Caption = "Số lượng sinh viên";
            this.ColSoLuongSinhVien.FieldName = "NumberStudents";
            this.ColSoLuongSinhVien.Name = "ColSoLuongSinhVien";
            this.ColSoLuongSinhVien.Visible = true;
            this.ColSoLuongSinhVien.VisibleIndex = 3;
            // 
            // ColPlaceTraining
            // 
            this.ColPlaceTraining.Caption = "Nơi học";
            this.ColPlaceTraining.FieldName = "PlaceTraining";
            this.ColPlaceTraining.Name = "ColPlaceTraining";
            this.ColPlaceTraining.Visible = true;
            this.ColPlaceTraining.VisibleIndex = 4;
            // 
            // ColGiangVien
            // 
            this.ColGiangVien.Caption = "Giảng viên";
            this.ColGiangVien.FieldName = "Class.ExpertName";
            this.ColGiangVien.Name = "ColGiangVien";
            this.ColGiangVien.Visible = true;
            this.ColGiangVien.VisibleIndex = 5;
            // 
            // ColMota
            // 
            this.ColMota.Caption = "Mô tả";
            this.ColMota.FieldName = "Description";
            this.ColMota.Name = "ColMota";
            this.ColMota.Visible = true;
            this.ColMota.VisibleIndex = 6;
            // 
            // ControlLopHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControlClass);
            this.Controls.Add(this.actionMenu1);
            this.Name = "ControlLopHoc";
            this.Size = new System.Drawing.Size(833, 441);
            this.Load += new System.EventHandler(this.ControlLopHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlClass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewClass)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Base.ActionMenu actionMenu1;
        private DevExpress.XtraGrid.GridControl gridControlClass;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewClass;
        private DevExpress.XtraGrid.Columns.GridColumn ColClassName;
        private DevExpress.XtraGrid.Columns.GridColumn ColStartDate;
        private DevExpress.XtraGrid.Columns.GridColumn ColToDate;
        private DevExpress.XtraGrid.Columns.GridColumn ColSoLuongSinhVien;
        private DevExpress.XtraGrid.Columns.GridColumn ColPlaceTraining;
        private DevExpress.XtraGrid.Columns.GridColumn ColGiangVien;
        private DevExpress.XtraGrid.Columns.GridColumn ColMota;
    }
}

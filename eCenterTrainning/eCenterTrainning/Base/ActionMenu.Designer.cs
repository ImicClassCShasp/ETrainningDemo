namespace eCenterTrainning.Base
{
    partial class ActionMenu
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
            DevExpress.Utils.SuperToolTip superToolTip1 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem1 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.SuperToolTip superToolTip2 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem2 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.SuperToolTip superToolTip3 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem3 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.SuperToolTip superToolTip4 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem4 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.SuperToolTip superToolTip5 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem5 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.SuperToolTip superToolTip6 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem6 = new DevExpress.Utils.ToolTipTitleItem();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnThemMoi = new DevExpress.XtraBars.BarLargeButtonItem();
            this.btnSua = new DevExpress.XtraBars.BarLargeButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarLargeButtonItem();
            this.btnRefresh = new DevExpress.XtraBars.BarLargeButtonItem();
            this.btnDong = new DevExpress.XtraBars.BarLargeButtonItem();
            this.btnTroGiup = new DevExpress.XtraBars.BarLargeButtonItem();
            this.btnBaoCao = new DevExpress.XtraBars.BarLargeButtonItem();
            this.btnHocVienTiemNang = new DevExpress.XtraBars.BarLargeButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barLargeButtonItem1 = new DevExpress.XtraBars.BarLargeButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnThemMoi,
            this.btnSua,
            this.btnXoa,
            this.btnRefresh,
            this.btnDong,
            this.btnTroGiup,
            this.btnBaoCao,
            this.barLargeButtonItem1,
            this.barButtonItem1,
            this.btnHocVienTiemNang});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 11;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 1;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.Text = "Tools";
            this.bar1.Visible = false;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnThemMoi),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnSua),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnXoa),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnRefresh),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnDong),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnTroGiup),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnBaoCao),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnHocVienTiemNang)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.Caption = "Thêm mới";
            this.btnThemMoi.Id = 0;
            this.btnThemMoi.ImageOptions.LargeImage = global::eCenterTrainning.Properties.Resources._new;
            this.btnThemMoi.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N));
            this.btnThemMoi.MinSize = new System.Drawing.Size(80, 0);
            this.btnThemMoi.Name = "btnThemMoi";
            toolTipTitleItem1.Text = "Thêm mới (Ctrl + N)";
            superToolTip1.Items.Add(toolTipTitleItem1);
            this.btnThemMoi.SuperTip = superToolTip1;
            this.btnThemMoi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThemMoi_ItemClick);
            // 
            // btnSua
            // 
            this.btnSua.Caption = "Sửa";
            this.btnSua.Id = 1;
            this.btnSua.ImageOptions.LargeImage = global::eCenterTrainning.Properties.Resources.book_edit;
            this.btnSua.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F2);
            this.btnSua.MinSize = new System.Drawing.Size(60, 0);
            this.btnSua.Name = "btnSua";
            toolTipTitleItem2.Text = "Sửa (F2)";
            superToolTip2.Items.Add(toolTipTitleItem2);
            this.btnSua.SuperTip = superToolTip2;
            this.btnSua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSua_ItemClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xóa";
            this.btnXoa.Id = 2;
            this.btnXoa.ImageOptions.LargeImage = global::eCenterTrainning.Properties.Resources.delete;
            this.btnXoa.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.Delete);
            this.btnXoa.MinSize = new System.Drawing.Size(60, 0);
            this.btnXoa.Name = "btnXoa";
            toolTipTitleItem3.Text = "Xóa (Delete)";
            superToolTip3.Items.Add(toolTipTitleItem3);
            this.btnXoa.SuperTip = superToolTip3;
            this.btnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoa_ItemClick);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Caption = "Nạp lại";
            this.btnRefresh.Id = 3;
            this.btnRefresh.ImageOptions.LargeImage = global::eCenterTrainning.Properties.Resources.renew;
            this.btnRefresh.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F5);
            this.btnRefresh.MinSize = new System.Drawing.Size(60, 0);
            this.btnRefresh.Name = "btnRefresh";
            toolTipTitleItem4.Text = "Nạp Lại (F5)";
            superToolTip4.Items.Add(toolTipTitleItem4);
            this.btnRefresh.SuperTip = superToolTip4;
            this.btnRefresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRefresh_ItemClick);
            // 
            // btnDong
            // 
            this.btnDong.Caption = "Đóng";
            this.btnDong.Id = 4;
            this.btnDong.ImageOptions.LargeImage = global::eCenterTrainning.Properties.Resources.cancel;
            this.btnDong.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4));
            this.btnDong.MinSize = new System.Drawing.Size(60, 0);
            this.btnDong.Name = "btnDong";
            toolTipTitleItem5.Text = "Đóng (Alt + F4)";
            superToolTip5.Items.Add(toolTipTitleItem5);
            this.btnDong.SuperTip = superToolTip5;
            this.btnDong.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDong_ItemClick);
            // 
            // btnTroGiup
            // 
            this.btnTroGiup.Caption = "Trợ giúp";
            this.btnTroGiup.Id = 5;
            this.btnTroGiup.ImageOptions.LargeImage = global::eCenterTrainning.Properties.Resources.Help_16x16;
            this.btnTroGiup.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F1);
            this.btnTroGiup.MinSize = new System.Drawing.Size(60, 0);
            this.btnTroGiup.Name = "btnTroGiup";
            toolTipTitleItem6.Text = "Trợ Giúp (F1)";
            superToolTip6.Items.Add(toolTipTitleItem6);
            this.btnTroGiup.SuperTip = superToolTip6;
            this.btnTroGiup.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTroGiup_ItemClick);
            // 
            // btnBaoCao
            // 
            this.btnBaoCao.Caption = "Tìm kiếm ko Mã Hóa";
            this.btnBaoCao.Enabled = false;
            this.btnBaoCao.Id = 7;
            this.btnBaoCao.ImageOptions.LargeImage = global::eCenterTrainning.Properties.Resources._164;
            this.btnBaoCao.Name = "btnBaoCao";
            this.btnBaoCao.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBaoCao_ItemClick);
            // 
            // btnHocVienTiemNang
            // 
            this.btnHocVienTiemNang.Caption = "HV Tiềm Năng";
            this.btnHocVienTiemNang.Enabled = false;
            this.btnHocVienTiemNang.Id = 10;
            this.btnHocVienTiemNang.ImageOptions.LargeImage = global::eCenterTrainning.Properties.Resources.user1;
            this.btnHocVienTiemNang.Name = "btnHocVienTiemNang";
            this.btnHocVienTiemNang.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHocVienTiemNang_ItemClick);
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            this.bar3.Visible = false;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(721, 71);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 43);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(721, 23);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 71);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 0);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(721, 71);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 0);
            // 
            // barLargeButtonItem1
            // 
            this.barLargeButtonItem1.Caption = "HV Tiềm Năng";
            this.barLargeButtonItem1.Id = 8;
            this.barLargeButtonItem1.Name = "barLargeButtonItem1";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "HV Tiềm Năng";
            this.barButtonItem1.Id = 9;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // ActionMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "ActionMenu";
            this.Size = new System.Drawing.Size(721, 66);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarLargeButtonItem btnThemMoi;

        public DevExpress.XtraBars.BarLargeButtonItem BtnThemMoi
        {
            get { return btnThemMoi; }
            set { btnThemMoi = value; }
        }
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarLargeButtonItem btnSua;

        public DevExpress.XtraBars.BarLargeButtonItem BtnSua
        {
            get { return btnSua; }
            set { btnSua = value; }
        }
        private DevExpress.XtraBars.BarLargeButtonItem btnXoa;

        public DevExpress.XtraBars.BarLargeButtonItem BtnXoa
        {
            get { return btnXoa; }
            set { btnXoa = value; }
        }
        private DevExpress.XtraBars.BarLargeButtonItem btnRefresh;

        public DevExpress.XtraBars.BarLargeButtonItem BtnRefresh
        {
            get { return btnRefresh; }
            set { btnRefresh = value; }
        }
        private DevExpress.XtraBars.BarLargeButtonItem btnDong;

        public DevExpress.XtraBars.BarLargeButtonItem BtnDong
        {
            get { return btnDong; }
            set { btnDong = value; }
        }
        private DevExpress.XtraBars.BarLargeButtonItem btnTroGiup;
        private DevExpress.XtraBars.BarLargeButtonItem btnBaoCao;
        private DevExpress.XtraBars.BarLargeButtonItem btnHocVienTiemNang;
        private DevExpress.XtraBars.BarLargeButtonItem barLargeButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;

        public DevExpress.XtraBars.BarLargeButtonItem BtnTroGiup
        {
            get { return btnTroGiup; }
            set { btnTroGiup = value; }
        }
    }
}

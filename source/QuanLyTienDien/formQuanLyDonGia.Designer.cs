namespace QuanLyTienDien
{
    partial class formQuanLyDonGia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formQuanLyDonGia));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnMoveFirst = new DevExpress.XtraBars.BarButtonItem();
            this.btnMovePrevious = new DevExpress.XtraBars.BarButtonItem();
            this.btnMoveNext = new DevExpress.XtraBars.BarButtonItem();
            this.btnMoveLast = new DevExpress.XtraBars.BarButtonItem();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnAdd = new DevExpress.XtraBars.BarButtonItem();
            this.btnDelete = new DevExpress.XtraBars.BarButtonItem();
            this.btnSave = new DevExpress.XtraBars.BarButtonItem();
            this.btnCancel = new DevExpress.XtraBars.BarButtonItem();
            this.btnOut = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.donGiaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaDonGia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTuKW = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDenKW = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoTien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGhiChu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colChiTietHoaDons = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtGhiChu = new DevExpress.XtraEditors.TextEdit();
            this.txtDenKW = new DevExpress.XtraEditors.TextEdit();
            this.txtTuKW = new DevExpress.XtraEditors.TextEdit();
            this.txtSoTien = new DevExpress.XtraEditors.TextEdit();
            this.txtMaDonGia = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.donGiaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGhiChu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDenKW.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTuKW.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoTien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaDonGia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
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
            this.btnAdd,
            this.btnDelete,
            this.btnSave,
            this.btnCancel,
            this.btnOut,
            this.btnMoveFirst,
            this.btnMovePrevious,
            this.btnMoveNext,
            this.btnMoveLast});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 9;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 1;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnMoveFirst),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnMovePrevious),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnMoveNext),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnMoveLast)});
            this.bar1.Text = "Tools";
            // 
            // btnMoveFirst
            // 
            this.btnMoveFirst.Caption = "barButtonItem1";
            this.btnMoveFirst.Id = 5;
            this.btnMoveFirst.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnMoveFirst.ImageOptions.Image")));
            this.btnMoveFirst.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnMoveFirst.ImageOptions.LargeImage")));
            this.btnMoveFirst.Name = "btnMoveFirst";
            this.btnMoveFirst.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnMoveFirst_ItemClick);
            // 
            // btnMovePrevious
            // 
            this.btnMovePrevious.Caption = "barButtonItem2";
            this.btnMovePrevious.Id = 6;
            this.btnMovePrevious.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnMovePrevious.ImageOptions.Image")));
            this.btnMovePrevious.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnMovePrevious.ImageOptions.LargeImage")));
            this.btnMovePrevious.Name = "btnMovePrevious";
            this.btnMovePrevious.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnMovePrevious_ItemClick);
            // 
            // btnMoveNext
            // 
            this.btnMoveNext.Caption = "barButtonItem3";
            this.btnMoveNext.Id = 7;
            this.btnMoveNext.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnMoveNext.ImageOptions.Image")));
            this.btnMoveNext.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnMoveNext.ImageOptions.LargeImage")));
            this.btnMoveNext.Name = "btnMoveNext";
            this.btnMoveNext.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnMoveNext_ItemClick);
            // 
            // btnMoveLast
            // 
            this.btnMoveLast.Caption = "barButtonItem4";
            this.btnMoveLast.Id = 8;
            this.btnMoveLast.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnMoveLast.ImageOptions.Image")));
            this.btnMoveLast.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnMoveLast.ImageOptions.LargeImage")));
            this.btnMoveLast.Name = "btnMoveLast";
            this.btnMoveLast.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnMoveLast_ItemClick);
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnAdd, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnDelete, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSave, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnCancel, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnOut, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnAdd
            // 
            this.btnAdd.Caption = "Thêm mới";
            this.btnAdd.Id = 0;
            this.btnAdd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.ImageOptions.Image")));
            this.btnAdd.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnAdd.ImageOptions.LargeImage")));
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAdd_ItemClick);
            // 
            // btnDelete
            // 
            this.btnDelete.Caption = "Xóa";
            this.btnDelete.Id = 1;
            this.btnDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.ImageOptions.Image")));
            this.btnDelete.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDelete.ImageOptions.LargeImage")));
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDelete_ItemClick);
            // 
            // btnSave
            // 
            this.btnSave.Caption = "Lưu";
            this.btnSave.Id = 2;
            this.btnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.ImageOptions.Image")));
            this.btnSave.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSave.ImageOptions.LargeImage")));
            this.btnSave.Name = "btnSave";
            this.btnSave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSave_ItemClick);
            // 
            // btnCancel
            // 
            this.btnCancel.Caption = "Hủy";
            this.btnCancel.Id = 3;
            this.btnCancel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.ImageOptions.Image")));
            this.btnCancel.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnCancel.ImageOptions.LargeImage")));
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCancel_ItemClick);
            // 
            // btnOut
            // 
            this.btnOut.Caption = "Thoát";
            this.btnOut.Id = 4;
            this.btnOut.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnOut.ImageOptions.Image")));
            this.btnOut.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnOut.ImageOptions.LargeImage")));
            this.btnOut.Name = "btnOut";
            this.btnOut.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnOut_ItemClick);
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
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlTop.Size = new System.Drawing.Size(1271, 61);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 542);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlBottom.Size = new System.Drawing.Size(1271, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 61);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 481);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1271, 61);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 481);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.gridControl1);
            this.layoutControl1.Controls.Add(this.txtGhiChu);
            this.layoutControl1.Controls.Add(this.txtDenKW);
            this.layoutControl1.Controls.Add(this.txtTuKW);
            this.layoutControl1.Controls.Add(this.txtSoTien);
            this.layoutControl1.Controls.Add(this.txtMaDonGia);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 61);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(1271, 481);
            this.layoutControl1.TabIndex = 4;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.donGiaBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(12, 211);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.MenuManager = this.barManager1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1247, 239);
            this.gridControl1.TabIndex = 9;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // donGiaBindingSource
            // 
            this.donGiaBindingSource.DataSource = typeof(QuanLyTienDien.DonGia);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaDonGia,
            this.colTuKW,
            this.colDenKW,
            this.colSoTien,
            this.colGhiChu,
            this.colChiTietHoaDons});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colMaDonGia
            // 
            this.colMaDonGia.Caption = "Mã đơn giá";
            this.colMaDonGia.FieldName = "MaDonGia";
            this.colMaDonGia.MinWidth = 25;
            this.colMaDonGia.Name = "colMaDonGia";
            this.colMaDonGia.Visible = true;
            this.colMaDonGia.VisibleIndex = 0;
            this.colMaDonGia.Width = 94;
            // 
            // colTuKW
            // 
            this.colTuKW.Caption = "Từ KW";
            this.colTuKW.FieldName = "TuKW";
            this.colTuKW.MinWidth = 25;
            this.colTuKW.Name = "colTuKW";
            this.colTuKW.Visible = true;
            this.colTuKW.VisibleIndex = 1;
            this.colTuKW.Width = 94;
            // 
            // colDenKW
            // 
            this.colDenKW.Caption = "Đến KW";
            this.colDenKW.FieldName = "DenKW";
            this.colDenKW.MinWidth = 25;
            this.colDenKW.Name = "colDenKW";
            this.colDenKW.Visible = true;
            this.colDenKW.VisibleIndex = 2;
            this.colDenKW.Width = 94;
            // 
            // colSoTien
            // 
            this.colSoTien.Caption = "Số Tiền";
            this.colSoTien.FieldName = "SoTien";
            this.colSoTien.MinWidth = 25;
            this.colSoTien.Name = "colSoTien";
            this.colSoTien.Visible = true;
            this.colSoTien.VisibleIndex = 3;
            this.colSoTien.Width = 94;
            // 
            // colGhiChu
            // 
            this.colGhiChu.Caption = "Ghi Chú";
            this.colGhiChu.FieldName = "GhiChu";
            this.colGhiChu.MinWidth = 25;
            this.colGhiChu.Name = "colGhiChu";
            this.colGhiChu.Visible = true;
            this.colGhiChu.VisibleIndex = 4;
            this.colGhiChu.Width = 94;
            // 
            // colChiTietHoaDons
            // 
            this.colChiTietHoaDons.FieldName = "ChiTietHoaDons";
            this.colChiTietHoaDons.MinWidth = 25;
            this.colChiTietHoaDons.Name = "colChiTietHoaDons";
            this.colChiTietHoaDons.Width = 94;
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.donGiaBindingSource, "GhiChu", true));
            this.txtGhiChu.Location = new System.Drawing.Point(164, 154);
            this.txtGhiChu.MenuManager = this.barManager1;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(1083, 22);
            this.txtGhiChu.StyleController = this.layoutControl1;
            this.txtGhiChu.TabIndex = 8;
            // 
            // txtDenKW
            // 
            this.txtDenKW.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.donGiaBindingSource, "DenKW", true));
            this.txtDenKW.Location = new System.Drawing.Point(164, 128);
            this.txtDenKW.MenuManager = this.barManager1;
            this.txtDenKW.Name = "txtDenKW";
            this.txtDenKW.Size = new System.Drawing.Size(1083, 22);
            this.txtDenKW.StyleController = this.layoutControl1;
            this.txtDenKW.TabIndex = 7;
            this.txtDenKW.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDenKW_KeyPress);
            // 
            // txtTuKW
            // 
            this.txtTuKW.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.donGiaBindingSource, "TuKW", true));
            this.txtTuKW.Location = new System.Drawing.Point(164, 102);
            this.txtTuKW.MenuManager = this.barManager1;
            this.txtTuKW.Name = "txtTuKW";
            this.txtTuKW.Size = new System.Drawing.Size(1083, 22);
            this.txtTuKW.StyleController = this.layoutControl1;
            this.txtTuKW.TabIndex = 6;
            this.txtTuKW.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTuKW_KeyPress);
            // 
            // txtSoTien
            // 
            this.txtSoTien.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.donGiaBindingSource, "SoTien", true));
            this.txtSoTien.Location = new System.Drawing.Point(164, 76);
            this.txtSoTien.MenuManager = this.barManager1;
            this.txtSoTien.Name = "txtSoTien";
            this.txtSoTien.Size = new System.Drawing.Size(1083, 22);
            this.txtSoTien.StyleController = this.layoutControl1;
            this.txtSoTien.TabIndex = 5;
            this.txtSoTien.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoTien_KeyPress);
            // 
            // txtMaDonGia
            // 
            this.txtMaDonGia.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.donGiaBindingSource, "MaDonGia", true));
            this.txtMaDonGia.Location = new System.Drawing.Point(164, 50);
            this.txtMaDonGia.MenuManager = this.barManager1;
            this.txtMaDonGia.Name = "txtMaDonGia";
            this.txtMaDonGia.Size = new System.Drawing.Size(1083, 22);
            this.txtMaDonGia.StyleController = this.layoutControl1;
            this.txtMaDonGia.TabIndex = 4;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.emptySpaceItem1,
            this.layoutControlItem6,
            this.layoutControlGroup1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(1271, 481);
            this.Root.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 442);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(1251, 19);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.gridControl1;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 180);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(1251, 262);
            this.layoutControlItem6.Text = "Danh sách các đơn giá";
            this.layoutControlItem6.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem6.TextSize = new System.Drawing.Size(128, 16);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(1251, 180);
            this.layoutControlGroup1.Text = "Thông tin đơn giá";
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.txtMaDonGia;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(1227, 26);
            this.layoutControlItem1.Text = "Mã đơn giá";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(128, 16);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txtSoTien;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 26);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(1227, 26);
            this.layoutControlItem2.Text = "Số tiền";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(128, 16);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.txtTuKW;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 52);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(1227, 26);
            this.layoutControlItem3.Text = "Từ KW";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(128, 16);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.txtDenKW;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 78);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(1227, 26);
            this.layoutControlItem4.Text = "Đến KW";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(128, 16);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.txtGhiChu;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 104);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(1227, 26);
            this.layoutControlItem5.Text = "Ghi Chú";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(128, 16);
            // 
            // formQuanLyDonGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1271, 562);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.IconOptions.Image = global::QuanLyTienDien.Properties.Resources.money;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "formQuanLyDonGia";
            this.Text = "Quản Lý Đơn Giá";
            this.Load += new System.EventHandler(this.formQuanLyDonGia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.donGiaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGhiChu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDenKW.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTuKW.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoTien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaDonGia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnMoveFirst;
        private DevExpress.XtraBars.BarButtonItem btnMovePrevious;
        private DevExpress.XtraBars.BarButtonItem btnMoveNext;
        private DevExpress.XtraBars.BarButtonItem btnMoveLast;
        private DevExpress.XtraBars.BarButtonItem btnAdd;
        private DevExpress.XtraBars.BarButtonItem btnDelete;
        private DevExpress.XtraBars.BarButtonItem btnSave;
        private DevExpress.XtraBars.BarButtonItem btnCancel;
        private DevExpress.XtraBars.BarButtonItem btnOut;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.TextEdit txtSoTien;
        private DevExpress.XtraEditors.TextEdit txtMaDonGia;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.TextEdit txtDenKW;
        private DevExpress.XtraEditors.TextEdit txtTuKW;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraEditors.TextEdit txtGhiChu;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private System.Windows.Forms.BindingSource donGiaBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMaDonGia;
        private DevExpress.XtraGrid.Columns.GridColumn colTuKW;
        private DevExpress.XtraGrid.Columns.GridColumn colDenKW;
        private DevExpress.XtraGrid.Columns.GridColumn colSoTien;
        private DevExpress.XtraGrid.Columns.GridColumn colGhiChu;
        private DevExpress.XtraGrid.Columns.GridColumn colChiTietHoaDons;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
    }
}
namespace QuanLyTienDien
{
    partial class formChiTietHoaDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formChiTietHoaDon));
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
            this.chiTietHoaDonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSoHoaDon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaDonGia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoLuongKW = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDonGia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHoaDon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtSoluongKW = new DevExpress.XtraEditors.TextEdit();
            this.luMadongia = new DevExpress.XtraEditors.LookUpEdit();
            this.donGiaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.luSohoadon = new DevExpress.XtraEditors.LookUpEdit();
            this.hoaDonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.labelSohoadon = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chiTietHoaDonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoluongKW.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.luMadongia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.donGiaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.luSohoadon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoaDonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.labelSohoadon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
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
            this.btnMoveFirst.Caption = "barButtonItem6";
            this.btnMoveFirst.Id = 5;
            this.btnMoveFirst.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnMoveFirst.ImageOptions.Image")));
            this.btnMoveFirst.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnMoveFirst.ImageOptions.LargeImage")));
            this.btnMoveFirst.Name = "btnMoveFirst";
            this.btnMoveFirst.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnMoveFirst_ItemClick);
            // 
            // btnMovePrevious
            // 
            this.btnMovePrevious.Caption = "barButtonItem7";
            this.btnMovePrevious.Id = 6;
            this.btnMovePrevious.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnMovePrevious.ImageOptions.Image")));
            this.btnMovePrevious.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnMovePrevious.ImageOptions.LargeImage")));
            this.btnMovePrevious.Name = "btnMovePrevious";
            this.btnMovePrevious.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnMovePrevious_ItemClick);
            // 
            // btnMoveNext
            // 
            this.btnMoveNext.Caption = "barButtonItem8";
            this.btnMoveNext.Id = 7;
            this.btnMoveNext.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnMoveNext.ImageOptions.Image")));
            this.btnMoveNext.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnMoveNext.ImageOptions.LargeImage")));
            this.btnMoveNext.Name = "btnMoveNext";
            this.btnMoveNext.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnMoveNext_ItemClick);
            // 
            // btnMoveLast
            // 
            this.btnMoveLast.Caption = "barButtonItem9";
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
            this.bar2.FloatLocation = new System.Drawing.Point(239, 187);
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
            this.btnCancel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCancel_ItemClick_1);
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
            this.barDockControlTop.Size = new System.Drawing.Size(470, 61);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 580);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlBottom.Size = new System.Drawing.Size(470, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 61);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 519);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(470, 61);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 519);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.gridControl1);
            this.layoutControl1.Controls.Add(this.txtSoluongKW);
            this.layoutControl1.Controls.Add(this.luMadongia);
            this.layoutControl1.Controls.Add(this.luSohoadon);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 61);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(470, 519);
            this.layoutControl1.TabIndex = 4;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.chiTietHoaDonBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(12, 159);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.MenuManager = this.barManager1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(446, 335);
            this.gridControl1.TabIndex = 7;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // chiTietHoaDonBindingSource
            // 
            this.chiTietHoaDonBindingSource.DataSource = typeof(QuanLyTienDien.ChiTietHoaDon);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSoHoaDon,
            this.colMaDonGia,
            this.colSoLuongKW,
            this.colDonGia,
            this.colHoaDon});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colSoHoaDon
            // 
            this.colSoHoaDon.Caption = "Số hóa đơn";
            this.colSoHoaDon.FieldName = "SoHoaDon";
            this.colSoHoaDon.MinWidth = 25;
            this.colSoHoaDon.Name = "colSoHoaDon";
            this.colSoHoaDon.Visible = true;
            this.colSoHoaDon.VisibleIndex = 0;
            this.colSoHoaDon.Width = 94;
            // 
            // colMaDonGia
            // 
            this.colMaDonGia.Caption = "Mã đơn giá";
            this.colMaDonGia.FieldName = "MaDonGia";
            this.colMaDonGia.MinWidth = 25;
            this.colMaDonGia.Name = "colMaDonGia";
            this.colMaDonGia.Visible = true;
            this.colMaDonGia.VisibleIndex = 1;
            this.colMaDonGia.Width = 94;
            // 
            // colSoLuongKW
            // 
            this.colSoLuongKW.Caption = "Số lượng KW";
            this.colSoLuongKW.FieldName = "SoLuongKW";
            this.colSoLuongKW.MinWidth = 25;
            this.colSoLuongKW.Name = "colSoLuongKW";
            this.colSoLuongKW.Visible = true;
            this.colSoLuongKW.VisibleIndex = 2;
            this.colSoLuongKW.Width = 94;
            // 
            // colDonGia
            // 
            this.colDonGia.FieldName = "DonGia";
            this.colDonGia.MinWidth = 25;
            this.colDonGia.Name = "colDonGia";
            this.colDonGia.Width = 94;
            // 
            // colHoaDon
            // 
            this.colHoaDon.FieldName = "HoaDon";
            this.colHoaDon.MinWidth = 25;
            this.colHoaDon.Name = "colHoaDon";
            this.colHoaDon.Width = 94;
            // 
            // txtSoluongKW
            // 
            this.txtSoluongKW.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.chiTietHoaDonBindingSource, "SoLuongKW", true));
            this.txtSoluongKW.Location = new System.Drawing.Point(187, 102);
            this.txtSoluongKW.MenuManager = this.barManager1;
            this.txtSoluongKW.Name = "txtSoluongKW";
            this.txtSoluongKW.Size = new System.Drawing.Size(259, 22);
            this.txtSoluongKW.StyleController = this.layoutControl1;
            this.txtSoluongKW.TabIndex = 6;
            this.txtSoluongKW.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoluongKW_KeyPress);
            // 
            // luMadongia
            // 
            this.luMadongia.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.chiTietHoaDonBindingSource, "MaDonGia", true));
            this.luMadongia.Location = new System.Drawing.Point(187, 76);
            this.luMadongia.MenuManager = this.barManager1;
            this.luMadongia.Name = "luMadongia";
            this.luMadongia.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.luMadongia.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MaDonGia", "Ma Don Gia", 76, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TuKW", "Tu KW", 49, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DenKW", "Den KW", 56, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SoTien", "So Tien", 55, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.luMadongia.Properties.DataSource = this.donGiaBindingSource;
            this.luMadongia.Properties.DisplayMember = "MaDonGia";
            this.luMadongia.Properties.ValueMember = "MaDonGia";
            this.luMadongia.Size = new System.Drawing.Size(259, 22);
            this.luMadongia.StyleController = this.layoutControl1;
            this.luMadongia.TabIndex = 5;
            this.luMadongia.EditValueChanged += new System.EventHandler(this.luMadongia_EditValueChanged);
            // 
            // donGiaBindingSource
            // 
            this.donGiaBindingSource.DataSource = typeof(QuanLyTienDien.DonGia);
            // 
            // luSohoadon
            // 
            this.luSohoadon.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.chiTietHoaDonBindingSource, "SoHoaDon", true));
            this.luSohoadon.Location = new System.Drawing.Point(187, 50);
            this.luSohoadon.MenuManager = this.barManager1;
            this.luSohoadon.Name = "luSohoadon";
            this.luSohoadon.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.luSohoadon.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SoHoaDon", "So Hoa Don", 78, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ThanhTien", "Thanh Tien", 76, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Thang", "Thang", 47, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MaDienKe", "Ma Dien Ke", 75, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.luSohoadon.Properties.DataSource = this.hoaDonBindingSource;
            this.luSohoadon.Properties.DisplayMember = "SoHoaDon";
            this.luSohoadon.Properties.ValueMember = "SoHoaDon";
            this.luSohoadon.Size = new System.Drawing.Size(259, 22);
            this.luSohoadon.StyleController = this.layoutControl1;
            this.luSohoadon.TabIndex = 4;
            // 
            // hoaDonBindingSource
            // 
            this.hoaDonBindingSource.DataSource = typeof(QuanLyTienDien.HoaDon);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.emptySpaceItem1,
            this.layoutControlGroup1,
            this.layoutControlItem3});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(470, 519);
            this.Root.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 486);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(450, 13);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.labelSohoadon,
            this.layoutControlItem2,
            this.layoutControlItem1});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(450, 128);
            this.layoutControlGroup1.Text = "Thông tin chi tiết hóa đơn";
            // 
            // labelSohoadon
            // 
            this.labelSohoadon.Control = this.luSohoadon;
            this.labelSohoadon.Location = new System.Drawing.Point(0, 0);
            this.labelSohoadon.Name = "labelSohoadon";
            this.labelSohoadon.Size = new System.Drawing.Size(426, 26);
            this.labelSohoadon.Text = "Số hóa đơn";
            this.labelSohoadon.TextSize = new System.Drawing.Size(151, 16);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.luMadongia;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 26);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(426, 26);
            this.layoutControlItem2.Text = "Mã đơn giá";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(151, 16);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.txtSoluongKW;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 52);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(426, 26);
            this.layoutControlItem1.Text = "Số lượng KW";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(151, 16);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.gridControl1;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 128);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(450, 358);
            this.layoutControlItem3.Text = "Danh sách chi tiết hóa đơn";
            this.layoutControlItem3.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(151, 16);
            // 
            // formChiTietHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 600);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.IconOptions.Image = global::QuanLyTienDien.Properties.Resources.bill;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "formChiTietHoaDon";
            this.Text = "Quản Lý Chi Tiết Hóa Đơn";
            this.Load += new System.EventHandler(this.formChiTietHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chiTietHoaDonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoluongKW.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.luMadongia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.donGiaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.luSohoadon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoaDonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.labelSohoadon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
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
        private DevExpress.XtraEditors.LookUpEdit luMadongia;
        private DevExpress.XtraEditors.LookUpEdit luSohoadon;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem labelSohoadon;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.TextEdit txtSoluongKW;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private System.Windows.Forms.BindingSource chiTietHoaDonBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colSoHoaDon;
        private DevExpress.XtraGrid.Columns.GridColumn colMaDonGia;
        private DevExpress.XtraGrid.Columns.GridColumn colSoLuongKW;
        private DevExpress.XtraGrid.Columns.GridColumn colDonGia;
        private DevExpress.XtraGrid.Columns.GridColumn colHoaDon;
        private System.Windows.Forms.BindingSource donGiaBindingSource;
        private System.Windows.Forms.BindingSource hoaDonBindingSource;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
    }
}
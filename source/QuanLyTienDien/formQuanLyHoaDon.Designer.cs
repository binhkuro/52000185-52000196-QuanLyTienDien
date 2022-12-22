namespace QuanLyTienDien
{
    partial class formQuanLyHoaDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formQuanLyHoaDon));
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
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.hoaDonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSoHoaDon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colThanhTien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colThang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaDienKe = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colChiTietHoaDons = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDienKe = new DevExpress.XtraGrid.Columns.GridColumn();
            this.luMadienke = new DevExpress.XtraEditors.LookUpEdit();
            this.dienKeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtThang = new DevExpress.XtraEditors.TextEdit();
            this.txtThanhtien = new DevExpress.XtraEditors.TextEdit();
            this.txtSohoadon = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
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
            ((System.ComponentModel.ISupportInitialize)(this.hoaDonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.luMadienke.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dienKeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtThang.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtThanhtien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSohoadon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
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
            this.barButtonItem2,
            this.btnSave,
            this.btnCancel,
            this.btnOut,
            this.btnDelete,
            this.btnMoveFirst,
            this.btnMovePrevious,
            this.btnMoveNext,
            this.btnMoveLast});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 10;
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
            this.btnMoveFirst.Id = 6;
            this.btnMoveFirst.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnMoveFirst.ImageOptions.Image")));
            this.btnMoveFirst.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnMoveFirst.ImageOptions.LargeImage")));
            this.btnMoveFirst.Name = "btnMoveFirst";
            this.btnMoveFirst.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnMoveFirst_ItemClick);
            // 
            // btnMovePrevious
            // 
            this.btnMovePrevious.Caption = "barButtonItem3";
            this.btnMovePrevious.Id = 7;
            this.btnMovePrevious.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnMovePrevious.ImageOptions.Image")));
            this.btnMovePrevious.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnMovePrevious.ImageOptions.LargeImage")));
            this.btnMovePrevious.Name = "btnMovePrevious";
            this.btnMovePrevious.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnMovePrevious_ItemClick);
            // 
            // btnMoveNext
            // 
            this.btnMoveNext.Caption = "barButtonItem4";
            this.btnMoveNext.Id = 8;
            this.btnMoveNext.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnMoveNext.ImageOptions.Image")));
            this.btnMoveNext.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnMoveNext.ImageOptions.LargeImage")));
            this.btnMoveNext.Name = "btnMoveNext";
            this.btnMoveNext.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnMoveNext_ItemClick);
            // 
            // btnMoveLast
            // 
            this.btnMoveLast.Caption = "barButtonItem5";
            this.btnMoveLast.Id = 9;
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
            this.btnDelete.Id = 5;
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
            this.barDockControlTop.Size = new System.Drawing.Size(739, 61);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 611);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlBottom.Size = new System.Drawing.Size(739, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 61);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 550);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(739, 61);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 550);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "barButtonItem2";
            this.barButtonItem2.Id = 1;
            this.barButtonItem2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.Image")));
            this.barButtonItem2.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.LargeImage")));
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.gridControl1);
            this.layoutControl1.Controls.Add(this.luMadienke);
            this.layoutControl1.Controls.Add(this.txtThang);
            this.layoutControl1.Controls.Add(this.txtThanhtien);
            this.layoutControl1.Controls.Add(this.txtSohoadon);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 61);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(739, 550);
            this.layoutControl1.TabIndex = 4;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.hoaDonBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(12, 185);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.MenuManager = this.barManager1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(715, 333);
            this.gridControl1.TabIndex = 8;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // hoaDonBindingSource
            // 
            this.hoaDonBindingSource.DataSource = typeof(QuanLyTienDien.HoaDon);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSoHoaDon,
            this.colThanhTien,
            this.colThang,
            this.colMaDienKe,
            this.colChiTietHoaDons,
            this.colDienKe});
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
            // colThanhTien
            // 
            this.colThanhTien.Caption = "Thành tiền";
            this.colThanhTien.FieldName = "ThanhTien";
            this.colThanhTien.MinWidth = 25;
            this.colThanhTien.Name = "colThanhTien";
            this.colThanhTien.Visible = true;
            this.colThanhTien.VisibleIndex = 1;
            this.colThanhTien.Width = 94;
            // 
            // colThang
            // 
            this.colThang.Caption = "Tháng";
            this.colThang.FieldName = "Thang";
            this.colThang.MinWidth = 25;
            this.colThang.Name = "colThang";
            this.colThang.Visible = true;
            this.colThang.VisibleIndex = 2;
            this.colThang.Width = 94;
            // 
            // colMaDienKe
            // 
            this.colMaDienKe.Caption = "Mã điện kế";
            this.colMaDienKe.FieldName = "MaDienKe";
            this.colMaDienKe.MinWidth = 25;
            this.colMaDienKe.Name = "colMaDienKe";
            this.colMaDienKe.Visible = true;
            this.colMaDienKe.VisibleIndex = 3;
            this.colMaDienKe.Width = 94;
            // 
            // colChiTietHoaDons
            // 
            this.colChiTietHoaDons.FieldName = "ChiTietHoaDons";
            this.colChiTietHoaDons.MinWidth = 25;
            this.colChiTietHoaDons.Name = "colChiTietHoaDons";
            this.colChiTietHoaDons.Width = 94;
            // 
            // colDienKe
            // 
            this.colDienKe.FieldName = "DienKe";
            this.colDienKe.MinWidth = 25;
            this.colDienKe.Name = "colDienKe";
            this.colDienKe.Width = 94;
            // 
            // luMadienke
            // 
            this.luMadienke.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.hoaDonBindingSource, "MaDienKe", true));
            this.luMadienke.Location = new System.Drawing.Point(168, 128);
            this.luMadienke.MenuManager = this.barManager1;
            this.luMadienke.Name = "luMadienke";
            this.luMadienke.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.luMadienke.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MaDienKe", "Ma Dien Ke", 75, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HieuDienThe", "Hieu Dien The", 91, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MaKH", "Ma KH", 47, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MaKhuVuc", "Ma Khu Vuc", 78, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("NuocSanXuat", "Nuoc San Xuat", 95, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("GhiChu", "Ghi Chu", 55, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.luMadienke.Properties.DataSource = this.dienKeBindingSource;
            this.luMadienke.Properties.DisplayMember = "MaDienKe";
            this.luMadienke.Properties.ValueMember = "MaDienKe";
            this.luMadienke.Size = new System.Drawing.Size(547, 22);
            this.luMadienke.StyleController = this.layoutControl1;
            this.luMadienke.TabIndex = 7;
            // 
            // dienKeBindingSource
            // 
            this.dienKeBindingSource.DataSource = typeof(QuanLyTienDien.DienKe);
            // 
            // txtThang
            // 
            this.txtThang.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.hoaDonBindingSource, "Thang", true));
            this.txtThang.Location = new System.Drawing.Point(168, 102);
            this.txtThang.MenuManager = this.barManager1;
            this.txtThang.Name = "txtThang";
            this.txtThang.Size = new System.Drawing.Size(547, 22);
            this.txtThang.StyleController = this.layoutControl1;
            this.txtThang.TabIndex = 6;
            this.txtThang.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtThang_KeyPress);
            // 
            // txtThanhtien
            // 
            this.txtThanhtien.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.hoaDonBindingSource, "ThanhTien", true));
            this.txtThanhtien.Location = new System.Drawing.Point(168, 76);
            this.txtThanhtien.MenuManager = this.barManager1;
            this.txtThanhtien.Name = "txtThanhtien";
            this.txtThanhtien.Size = new System.Drawing.Size(547, 22);
            this.txtThanhtien.StyleController = this.layoutControl1;
            this.txtThanhtien.TabIndex = 5;
            this.txtThanhtien.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtThanhtien_KeyPress);
            // 
            // txtSohoadon
            // 
            this.txtSohoadon.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.hoaDonBindingSource, "SoHoaDon", true));
            this.txtSohoadon.Location = new System.Drawing.Point(168, 50);
            this.txtSohoadon.MenuManager = this.barManager1;
            this.txtSohoadon.Name = "txtSohoadon";
            this.txtSohoadon.Size = new System.Drawing.Size(547, 22);
            this.txtSohoadon.StyleController = this.layoutControl1;
            this.txtSohoadon.TabIndex = 4;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.emptySpaceItem1,
            this.layoutControlGroup1,
            this.layoutControlItem5});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(739, 550);
            this.Root.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 510);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(719, 20);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(719, 154);
            this.layoutControlGroup1.Text = "Thông tin hóa đơn";
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.txtSohoadon;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(695, 26);
            this.layoutControlItem1.Text = "Số hóa đơn";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(132, 16);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txtThanhtien;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 26);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(695, 26);
            this.layoutControlItem2.Text = "Thành tiền";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(132, 16);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.txtThang;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 52);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(695, 26);
            this.layoutControlItem3.Text = "Tháng";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(132, 16);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.luMadienke;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 78);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(695, 26);
            this.layoutControlItem4.Text = "Mã điện kế";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(132, 16);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.gridControl1;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 154);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(719, 356);
            this.layoutControlItem5.Text = "Danh sách các hóa đơn";
            this.layoutControlItem5.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem5.TextSize = new System.Drawing.Size(132, 16);
            // 
            // formQuanLyHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 631);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.IconOptions.Image = global::QuanLyTienDien.Properties.Resources.invoice;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "formQuanLyHoaDon";
            this.Text = "Quản Lý Hóa Đơn";
            this.Load += new System.EventHandler(this.formQuanLyHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoaDonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.luMadienke.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dienKeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtThang.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtThanhtien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSohoadon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
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
        private DevExpress.XtraBars.BarButtonItem btnAdd;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem btnSave;
        private DevExpress.XtraBars.BarButtonItem btnCancel;
        private DevExpress.XtraBars.BarButtonItem btnOut;
        private DevExpress.XtraBars.BarButtonItem btnDelete;
        private DevExpress.XtraBars.BarButtonItem btnMoveFirst;
        private DevExpress.XtraBars.BarButtonItem btnMovePrevious;
        private DevExpress.XtraBars.BarButtonItem btnMoveNext;
        private DevExpress.XtraBars.BarButtonItem btnMoveLast;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.TextEdit txtSohoadon;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraEditors.TextEdit txtThang;
        private DevExpress.XtraEditors.TextEdit txtThanhtien;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraEditors.LookUpEdit luMadienke;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private System.Windows.Forms.BindingSource hoaDonBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colSoHoaDon;
        private DevExpress.XtraGrid.Columns.GridColumn colThanhTien;
        private DevExpress.XtraGrid.Columns.GridColumn colThang;
        private DevExpress.XtraGrid.Columns.GridColumn colMaDienKe;
        private DevExpress.XtraGrid.Columns.GridColumn colChiTietHoaDons;
        private DevExpress.XtraGrid.Columns.GridColumn colDienKe;
        private System.Windows.Forms.BindingSource dienKeBindingSource;
    }
}
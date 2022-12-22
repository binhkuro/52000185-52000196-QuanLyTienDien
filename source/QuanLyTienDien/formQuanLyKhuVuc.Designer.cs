namespace QuanLyTienDien
{
    partial class formQuanLyKhuVuc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formQuanLyKhuVuc));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
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
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
            this.txtMaKV = new DevExpress.XtraEditors.TextEdit();
            this.khuVucBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaKhuVuc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenKhuVuc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuanHuyen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDienKes = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtQH = new DevExpress.XtraEditors.TextEdit();
            this.txtTenKV = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.label1 = new System.Windows.Forms.Label();
            this.xpServerModeView1 = new DevExpress.Xpo.XPServerModeView(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaKV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khuVucBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenKV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpServerModeView1)).BeginInit();
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
            this.barButtonItem1,
            this.btnAdd,
            this.btnDelete,
            this.btnCancel,
            this.btnOut,
            this.btnSave,
            this.barButtonItem2,
            this.btnMovePrevious,
            this.btnMoveNext,
            this.btnMoveLast,
            this.btnMoveFirst,
            this.barSubItem1});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 13;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 1;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem2),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnMoveFirst),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnMovePrevious),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnMoveNext),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnMoveLast)});
            this.bar1.Text = "Tools";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Id = 7;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // btnMoveFirst
            // 
            this.btnMoveFirst.Caption = "barButtonItem6";
            this.btnMoveFirst.Id = 11;
            this.btnMoveFirst.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnMoveFirst.ImageOptions.Image")));
            this.btnMoveFirst.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnMoveFirst.ImageOptions.LargeImage")));
            this.btnMoveFirst.Name = "btnMoveFirst";
            this.btnMoveFirst.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnMoveFirst_ItemClick);
            // 
            // btnMovePrevious
            // 
            this.btnMovePrevious.Caption = "barButtonItem3";
            this.btnMovePrevious.Id = 8;
            this.btnMovePrevious.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnMovePrevious.ImageOptions.Image")));
            this.btnMovePrevious.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnMovePrevious.ImageOptions.LargeImage")));
            this.btnMovePrevious.Name = "btnMovePrevious";
            this.btnMovePrevious.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnMovePrevious_ItemClick);
            // 
            // btnMoveNext
            // 
            this.btnMoveNext.Caption = "barButtonItem4";
            this.btnMoveNext.Id = 9;
            this.btnMoveNext.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnMoveNext.ImageOptions.Image")));
            this.btnMoveNext.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnMoveNext.ImageOptions.LargeImage")));
            this.btnMoveNext.Name = "btnMoveNext";
            this.btnMoveNext.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnMoveNext_ItemClick);
            // 
            // btnMoveLast
            // 
            this.btnMoveLast.Caption = "barButtonItem5";
            this.btnMoveLast.Id = 10;
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
            this.btnAdd.Id = 1;
            this.btnAdd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.ImageOptions.Image")));
            this.btnAdd.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnAdd.ImageOptions.LargeImage")));
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAdd_ItemClick);
            // 
            // btnDelete
            // 
            this.btnDelete.Caption = "Xóa";
            this.btnDelete.Id = 2;
            this.btnDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.ImageOptions.Image")));
            this.btnDelete.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDelete.ImageOptions.LargeImage")));
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDelete_ItemClick);
            // 
            // btnSave
            // 
            this.btnSave.Caption = "Lưu";
            this.btnSave.Id = 6;
            this.btnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.ImageOptions.Image")));
            this.btnSave.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSave.ImageOptions.LargeImage")));
            this.btnSave.Name = "btnSave";
            this.btnSave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSave_ItemClick_1);
            // 
            // btnCancel
            // 
            this.btnCancel.Caption = "Hủy";
            this.btnCancel.Id = 4;
            this.btnCancel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.ImageOptions.Image")));
            this.btnCancel.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnCancel.ImageOptions.LargeImage")));
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCancel_ItemClick);
            // 
            // btnOut
            // 
            this.btnOut.Caption = "Thoát";
            this.btnOut.Id = 5;
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
            this.barDockControlTop.Size = new System.Drawing.Size(808, 61);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 430);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlBottom.Size = new System.Drawing.Size(808, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 61);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 369);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(808, 61);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 369);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barSubItem1
            // 
            this.barSubItem1.Caption = "barSubItem1";
            this.barSubItem1.Id = 12;
            this.barSubItem1.Name = "barSubItem1";
            // 
            // txtMaKV
            // 
            this.txtMaKV.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.khuVucBindingSource, "MaKhuVuc", true));
            this.txtMaKV.Location = new System.Drawing.Point(166, 50);
            this.txtMaKV.MenuManager = this.barManager1;
            this.txtMaKV.Name = "txtMaKV";
            this.txtMaKV.Size = new System.Drawing.Size(618, 22);
            this.txtMaKV.StyleController = this.layoutControl1;
            this.txtMaKV.TabIndex = 4;
            // 
            // khuVucBindingSource
            // 
            this.khuVucBindingSource.DataSource = typeof(QuanLyTienDien.KhuVuc);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.txtMaKV);
            this.layoutControl1.Controls.Add(this.gridControl1);
            this.layoutControl1.Controls.Add(this.txtQH);
            this.layoutControl1.Controls.Add(this.txtTenKV);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 61);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(808, 369);
            this.layoutControl1.TabIndex = 6;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // gridControl1
            // 
            this.gridControl1.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.gridControl1.DataSource = this.khuVucBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(12, 159);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.MenuManager = this.barManager1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(784, 186);
            this.gridControl1.TabIndex = 6;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaKhuVuc,
            this.colTenKhuVuc,
            this.colQuanHuyen,
            this.colDienKes});
            this.gridView1.CustomizationFormBounds = new System.Drawing.Rectangle(969, 373, 326, 271);
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colMaKhuVuc
            // 
            this.colMaKhuVuc.Caption = "Mã khu vực";
            this.colMaKhuVuc.FieldName = "MaKhuVuc";
            this.colMaKhuVuc.MinWidth = 25;
            this.colMaKhuVuc.Name = "colMaKhuVuc";
            this.colMaKhuVuc.Visible = true;
            this.colMaKhuVuc.VisibleIndex = 0;
            this.colMaKhuVuc.Width = 221;
            // 
            // colTenKhuVuc
            // 
            this.colTenKhuVuc.Caption = "Tên khu vực";
            this.colTenKhuVuc.FieldName = "TenKhuVuc";
            this.colTenKhuVuc.MinWidth = 25;
            this.colTenKhuVuc.Name = "colTenKhuVuc";
            this.colTenKhuVuc.Visible = true;
            this.colTenKhuVuc.VisibleIndex = 1;
            this.colTenKhuVuc.Width = 289;
            // 
            // colQuanHuyen
            // 
            this.colQuanHuyen.Caption = "Địa chỉ";
            this.colQuanHuyen.FieldName = "QuanHuyen";
            this.colQuanHuyen.MinWidth = 25;
            this.colQuanHuyen.Name = "colQuanHuyen";
            this.colQuanHuyen.Visible = true;
            this.colQuanHuyen.VisibleIndex = 2;
            this.colQuanHuyen.Width = 244;
            // 
            // colDienKes
            // 
            this.colDienKes.FieldName = "DienKes";
            this.colDienKes.MinWidth = 25;
            this.colDienKes.Name = "colDienKes";
            this.colDienKes.Width = 94;
            // 
            // txtQH
            // 
            this.txtQH.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.khuVucBindingSource, "QuanHuyen", true));
            this.txtQH.Location = new System.Drawing.Point(166, 102);
            this.txtQH.MenuManager = this.barManager1;
            this.txtQH.Name = "txtQH";
            this.txtQH.Size = new System.Drawing.Size(618, 22);
            this.txtQH.StyleController = this.layoutControl1;
            this.txtQH.TabIndex = 5;
            // 
            // txtTenKV
            // 
            this.txtTenKV.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.khuVucBindingSource, "TenKhuVuc", true));
            this.txtTenKV.Location = new System.Drawing.Point(166, 76);
            this.txtTenKV.MenuManager = this.barManager1;
            this.txtTenKV.Name = "txtTenKV";
            this.txtTenKV.Size = new System.Drawing.Size(618, 22);
            this.txtTenKV.StyleController = this.layoutControl1;
            this.txtTenKV.TabIndex = 4;
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
            this.Root.Size = new System.Drawing.Size(808, 369);
            this.Root.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 337);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(788, 12);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem4});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(788, 128);
            this.layoutControlGroup1.Text = "Thông tin khu vực";
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.txtTenKV;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 26);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(764, 26);
            this.layoutControlItem1.Text = "Tên khu vực";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(130, 16);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txtQH;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 52);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(764, 26);
            this.layoutControlItem2.Text = "Quận huyện";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(130, 16);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.txtMaKV;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(764, 26);
            this.layoutControlItem4.Text = "Mã khu vực";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(130, 16);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.gridControl1;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 128);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(788, 209);
            this.layoutControlItem3.Text = "Danh sách các khu vực";
            this.layoutControlItem3.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(130, 16);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(472, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 7;
            // 
            // formQuanLyKhuVuc
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("formQuanLyKhuVuc.IconOptions.Image")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "formQuanLyKhuVuc";
            this.Text = "Quản Lý Khu Vực";
            this.Load += new System.EventHandler(this.formQuanLyKhuVuc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaKV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khuVucBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenKV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpServerModeView1)).EndInit();
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
        private DevExpress.XtraBars.BarButtonItem btnDelete;
        private DevExpress.XtraBars.BarButtonItem btnCancel;
        private DevExpress.XtraBars.BarButtonItem btnOut;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private System.Windows.Forms.BindingSource khuVucBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMaKhuVuc;
        private DevExpress.XtraGrid.Columns.GridColumn colTenKhuVuc;
        private DevExpress.XtraGrid.Columns.GridColumn colQuanHuyen;
        private DevExpress.XtraGrid.Columns.GridColumn colDienKes;
        private DevExpress.XtraEditors.TextEdit txtQH;
        private DevExpress.XtraEditors.TextEdit txtTenKV;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraEditors.TextEdit txtMaKV;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.Xpo.XPServerModeView xpServerModeView1;
        private DevExpress.XtraBars.BarButtonItem btnSave;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem btnMoveFirst;
        private DevExpress.XtraBars.BarButtonItem btnMovePrevious;
        private DevExpress.XtraBars.BarButtonItem btnMoveNext;
        private DevExpress.XtraBars.BarButtonItem btnMoveLast;
        private DevExpress.XtraBars.BarSubItem barSubItem1;
    }
}
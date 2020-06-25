namespace QL_VT
{
    partial class frmNhanVien
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
            System.Windows.Forms.Label mANVLabel;
            System.Windows.Forms.Label hOLabel;
            System.Windows.Forms.Label tENLabel;
            System.Windows.Forms.Label dIACHILabel;
            System.Windows.Forms.Label nGAYSINHLabel;
            System.Windows.Forms.Label lUONGLabel;
            System.Windows.Forms.Label mACNLabel;
            System.Windows.Forms.Label trangThaiXoaLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhanVien));
            this.bmNV = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnSua = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnGhi = new DevExpress.XtraBars.BarButtonItem();
            this.btnRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.btnPhucHoi = new DevExpress.XtraBars.BarButtonItem();
            this.btnChuyenCN = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btnDanhSach = new DevExpress.XtraBars.BarButtonItem();
            this.btnHuy = new DevExpress.XtraBars.BarButtonItem();
            this.btnTaoLogin = new DevExpress.XtraBars.BarButtonItem();
            this.babtnDatHang = new DevExpress.XtraBars.BarButtonItem();
            this.babtnPhieuNhap = new DevExpress.XtraBars.BarButtonItem();
            this.babtnPhieuXuat = new DevExpress.XtraBars.BarButtonItem();
            this.dataSet = new QL_VT.QL_VATTUDataSet();
            this.bdsNV = new System.Windows.Forms.BindingSource(this.components);
            this.taNV = new QL_VT.QL_VATTUDataSetTableAdapters.NhanVienTableAdapter();
            this.taNVManager = new QL_VT.QL_VATTUDataSetTableAdapters.TableAdapterManager();
            this.gcNV = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMANV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIACHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYSINH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLUONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMACN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTrangThaiXoa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmbCN = new System.Windows.Forms.ComboBox();
            this.bdsCN = new System.Windows.Forms.BindingSource(this.components);
            this.taCN = new QL_VT.QL_VATTUDataSetTableAdapters.ChiNhanhTableAdapter();
            this.gbNV = new System.Windows.Forms.GroupBox();
            this.txtHO = new DevExpress.XtraEditors.TextEdit();
            this.txtTEN = new DevExpress.XtraEditors.TextEdit();
            this.txtDIACHI = new DevExpress.XtraEditors.TextEdit();
            this.dtpNGAYSINH = new DevExpress.XtraEditors.DateEdit();
            this.txtLuong = new DevExpress.XtraEditors.SpinEdit();
            this.txtMACN = new DevExpress.XtraEditors.TextEdit();
            this.txtMANV = new DevExpress.XtraEditors.TextEdit();
            this.txtTRANGTHAIXOA = new DevExpress.XtraEditors.TextEdit();
            this.bdsPHIEUNHAP = new System.Windows.Forms.BindingSource(this.components);
            this.taPHIEUNHAP = new QL_VT.QL_VATTUDataSetTableAdapters.PhieuNhapTableAdapter();
            this.bdsDATHANG = new System.Windows.Forms.BindingSource(this.components);
            this.taDATHANG = new QL_VT.QL_VATTUDataSetTableAdapters.DatHangTableAdapter();
            this.txtCN = new System.Windows.Forms.Label();
            this.bdsPHIEUXUAT = new System.Windows.Forms.BindingSource(this.components);
            this.taPHIEUXUAT = new QL_VT.QL_VATTUDataSetTableAdapters.PhieuXuatTableAdapter();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitterControl1 = new DevExpress.XtraEditors.SplitterControl();
            mANVLabel = new System.Windows.Forms.Label();
            hOLabel = new System.Windows.Forms.Label();
            tENLabel = new System.Windows.Forms.Label();
            dIACHILabel = new System.Windows.Forms.Label();
            nGAYSINHLabel = new System.Windows.Forms.Label();
            lUONGLabel = new System.Windows.Forms.Label();
            mACNLabel = new System.Windows.Forms.Label();
            trangThaiXoaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bmNV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsNV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcNV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCN)).BeginInit();
            this.gbNV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtHO.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTEN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDIACHI.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpNGAYSINH.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpNGAYSINH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLuong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMACN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMANV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTRANGTHAIXOA.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPHIEUNHAP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDATHANG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPHIEUXUAT)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mANVLabel
            // 
            mANVLabel.AutoSize = true;
            mANVLabel.BackColor = System.Drawing.Color.Transparent;
            mANVLabel.Location = new System.Drawing.Point(42, 28);
            mANVLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            mANVLabel.Name = "mANVLabel";
            mANVLabel.Size = new System.Drawing.Size(178, 34);
            mANVLabel.TabIndex = 0;
            mANVLabel.Text = "Mã nhân viên";
            // 
            // hOLabel
            // 
            hOLabel.AutoSize = true;
            hOLabel.BackColor = System.Drawing.Color.Transparent;
            hOLabel.Location = new System.Drawing.Point(504, 28);
            hOLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            hOLabel.Name = "hOLabel";
            hOLabel.Size = new System.Drawing.Size(52, 34);
            hOLabel.TabIndex = 2;
            hOLabel.Text = "Họ";
            // 
            // tENLabel
            // 
            tENLabel.AutoSize = true;
            tENLabel.BackColor = System.Drawing.Color.Transparent;
            tENLabel.Location = new System.Drawing.Point(1000, 28);
            tENLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            tENLabel.Name = "tENLabel";
            tENLabel.Size = new System.Drawing.Size(62, 34);
            tENLabel.TabIndex = 4;
            tENLabel.Text = "Tên";
            // 
            // dIACHILabel
            // 
            dIACHILabel.AutoSize = true;
            dIACHILabel.BackColor = System.Drawing.Color.Transparent;
            dIACHILabel.Location = new System.Drawing.Point(42, 180);
            dIACHILabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            dIACHILabel.Name = "dIACHILabel";
            dIACHILabel.Size = new System.Drawing.Size(100, 34);
            dIACHILabel.TabIndex = 6;
            dIACHILabel.Text = "Địa chỉ";
            // 
            // nGAYSINHLabel
            // 
            nGAYSINHLabel.AutoSize = true;
            nGAYSINHLabel.BackColor = System.Drawing.Color.Transparent;
            nGAYSINHLabel.Location = new System.Drawing.Point(42, 80);
            nGAYSINHLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            nGAYSINHLabel.Name = "nGAYSINHLabel";
            nGAYSINHLabel.Size = new System.Drawing.Size(140, 34);
            nGAYSINHLabel.TabIndex = 8;
            nGAYSINHLabel.Text = "Ngày Sinh";
            // 
            // lUONGLabel
            // 
            lUONGLabel.AutoSize = true;
            lUONGLabel.BackColor = System.Drawing.Color.Transparent;
            lUONGLabel.Location = new System.Drawing.Point(504, 80);
            lUONGLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lUONGLabel.Name = "lUONGLabel";
            lUONGLabel.Size = new System.Drawing.Size(94, 34);
            lUONGLabel.TabIndex = 10;
            lUONGLabel.Text = "Lương";
            // 
            // mACNLabel
            // 
            mACNLabel.AutoSize = true;
            mACNLabel.BackColor = System.Drawing.Color.Transparent;
            mACNLabel.Location = new System.Drawing.Point(42, 132);
            mACNLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            mACNLabel.Name = "mACNLabel";
            mACNLabel.Size = new System.Drawing.Size(179, 34);
            mACNLabel.TabIndex = 12;
            mACNLabel.Text = "Mã chi nhánh";
            // 
            // trangThaiXoaLabel
            // 
            trangThaiXoaLabel.AutoSize = true;
            trangThaiXoaLabel.BackColor = System.Drawing.Color.Transparent;
            trangThaiXoaLabel.Location = new System.Drawing.Point(504, 132);
            trangThaiXoaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            trangThaiXoaLabel.Name = "trangThaiXoaLabel";
            trangThaiXoaLabel.Size = new System.Drawing.Size(186, 34);
            trangThaiXoaLabel.TabIndex = 14;
            trangThaiXoaLabel.Text = "Trạng thái xóa";
            // 
            // bmNV
            // 
            this.bmNV.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
            this.bmNV.DockControls.Add(this.barDockControlTop);
            this.bmNV.DockControls.Add(this.barDockControlBottom);
            this.bmNV.DockControls.Add(this.barDockControlLeft);
            this.bmNV.DockControls.Add(this.barDockControlRight);
            this.bmNV.Form = this;
            this.bmNV.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnThem,
            this.btnSua,
            this.btnXoa,
            this.btnRefresh,
            this.btnGhi,
            this.btnPhucHoi,
            this.btnDanhSach,
            this.btnThoat,
            this.btnHuy,
            this.btnChuyenCN,
            this.btnTaoLogin,
            this.babtnDatHang,
            this.babtnPhieuNhap,
            this.babtnPhieuXuat});
            this.bmNV.MainMenu = this.bar2;
            this.bmNV.MaxItemId = 18;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSua, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnGhi),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnRefresh),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnPhucHoi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnChuyenCN, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThoat, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnThem
            // 
            this.btnThem.Caption = "Thêm";
            this.btnThem.Id = 0;
            this.btnThem.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThem.ImageOptions.SvgImage")));
            this.btnThem.Name = "btnThem";
            this.btnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThem_ItemClick);
            // 
            // btnSua
            // 
            this.btnSua.Caption = "Sửa";
            this.btnSua.Id = 1;
            this.btnSua.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSua.ImageOptions.SvgImage")));
            this.btnSua.Name = "btnSua";
            this.btnSua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSua_ItemClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xóa";
            this.btnXoa.Id = 2;
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
            this.btnXoa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.LargeImage")));
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoa_ItemClick);
            // 
            // btnGhi
            // 
            this.btnGhi.Caption = "Ghi";
            this.btnGhi.Id = 4;
            this.btnGhi.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnGhi.ImageOptions.SvgImage")));
            this.btnGhi.Name = "btnGhi";
            this.btnGhi.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnGhi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGhi_ItemClick);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Caption = "Reload";
            this.btnRefresh.Id = 3;
            this.btnRefresh.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnRefresh.ImageOptions.SvgImage")));
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnRefresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRefresh_ItemClick);
            // 
            // btnPhucHoi
            // 
            this.btnPhucHoi.Caption = "Undo";
            this.btnPhucHoi.Id = 5;
            this.btnPhucHoi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPhucHoi.ImageOptions.Image")));
            this.btnPhucHoi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnPhucHoi.ImageOptions.LargeImage")));
            this.btnPhucHoi.Name = "btnPhucHoi";
            this.btnPhucHoi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPhucHoi_ItemClick);
            // 
            // btnChuyenCN
            // 
            this.btnChuyenCN.Caption = "Chuyển Chi Nhánh";
            this.btnChuyenCN.Id = 10;
            this.btnChuyenCN.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnChuyenCN.ImageOptions.SvgImage")));
            this.btnChuyenCN.Name = "btnChuyenCN";
            this.btnChuyenCN.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnChuyenCN_ItemClick);
            // 
            // btnThoat
            // 
            this.btnThoat.Caption = "Thoát";
            this.btnThoat.Id = 8;
            this.btnThoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.Image")));
            this.btnThoat.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.LargeImage")));
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThoat_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.bmNV;
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlTop.Size = new System.Drawing.Size(2373, 52);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 1383);
            this.barDockControlBottom.Manager = this.bmNV;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlBottom.Size = new System.Drawing.Size(2373, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 52);
            this.barDockControlLeft.Manager = this.bmNV;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 1331);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(2373, 52);
            this.barDockControlRight.Manager = this.bmNV;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 1331);
            // 
            // btnDanhSach
            // 
            this.btnDanhSach.Caption = "Danh sách nhân viên ";
            this.btnDanhSach.Id = 7;
            this.btnDanhSach.Name = "btnDanhSach";
            // 
            // btnHuy
            // 
            this.btnHuy.Caption = "Hủy";
            this.btnHuy.Id = 9;
            this.btnHuy.Name = "btnHuy";
            // 
            // btnTaoLogin
            // 
            this.btnTaoLogin.Caption = "Tạo Login";
            this.btnTaoLogin.Id = 11;
            this.btnTaoLogin.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTaoLogin.ImageOptions.Image")));
            this.btnTaoLogin.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnTaoLogin.ImageOptions.LargeImage")));
            this.btnTaoLogin.Name = "btnTaoLogin";
            // 
            // babtnDatHang
            // 
            this.babtnDatHang.Caption = "Đặt Hàng";
            this.babtnDatHang.Id = 15;
            this.babtnDatHang.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("babtnDatHang.ImageOptions.Image")));
            this.babtnDatHang.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("babtnDatHang.ImageOptions.LargeImage")));
            this.babtnDatHang.Name = "babtnDatHang";
            // 
            // babtnPhieuNhap
            // 
            this.babtnPhieuNhap.Caption = "Phiếu Nhập";
            this.babtnPhieuNhap.Id = 16;
            this.babtnPhieuNhap.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("babtnPhieuNhap.ImageOptions.SvgImage")));
            this.babtnPhieuNhap.Name = "babtnPhieuNhap";
            // 
            // babtnPhieuXuat
            // 
            this.babtnPhieuXuat.Caption = "Phiếu Xuất";
            this.babtnPhieuXuat.Id = 17;
            this.babtnPhieuXuat.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("babtnPhieuXuat.ImageOptions.SvgImage")));
            this.babtnPhieuXuat.Name = "babtnPhieuXuat";
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "QL_VATTUDataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsNV
            // 
            this.bdsNV.DataMember = "NhanVien";
            this.bdsNV.DataSource = this.dataSet;
            // 
            // taNV
            // 
            this.taNV.ClearBeforeFill = true;
            // 
            // taNVManager
            // 
            this.taNVManager.BackupDataSetBeforeUpdate = false;
            this.taNVManager.ChiNhanhTableAdapter = null;
            this.taNVManager.CTDDHTableAdapter = null;
            this.taNVManager.CTPNTableAdapter = null;
            this.taNVManager.CTPXTableAdapter = null;
            this.taNVManager.DanhSachNVTableAdapter = null;
            this.taNVManager.DatHangTableAdapter = null;
            this.taNVManager.NhanVienTableAdapter = this.taNV;
            this.taNVManager.PhieuNhapTableAdapter = null;
            this.taNVManager.PhieuXuatTableAdapter = null;
            this.taNVManager.UpdateOrder = QL_VT.QL_VATTUDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.taNVManager.VattuTableAdapter = null;
            // 
            // gcNV
            // 
            this.gcNV.DataSource = this.bdsNV;
            this.gcNV.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcNV.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gcNV.Location = new System.Drawing.Point(0, 136);
            this.gcNV.MainView = this.gridView1;
            this.gcNV.Margin = new System.Windows.Forms.Padding(4);
            this.gcNV.MenuManager = this.bmNV;
            this.gcNV.Name = "gcNV";
            this.gcNV.Size = new System.Drawing.Size(2373, 343);
            this.gcNV.TabIndex = 5;
            this.gcNV.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMANV,
            this.colHO,
            this.colTEN,
            this.colDIACHI,
            this.colNGAYSINH,
            this.colLUONG,
            this.colMACN,
            this.colTrangThaiXoa});
            this.gridView1.DetailHeight = 410;
            this.gridView1.GridControl = this.gcNV;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            // 
            // colMANV
            // 
            this.colMANV.Caption = "Mã NV";
            this.colMANV.FieldName = "MANV";
            this.colMANV.MinWidth = 45;
            this.colMANV.Name = "colMANV";
            this.colMANV.Visible = true;
            this.colMANV.VisibleIndex = 0;
            this.colMANV.Width = 169;
            // 
            // colHO
            // 
            this.colHO.Caption = "Họ";
            this.colHO.FieldName = "HO";
            this.colHO.MinWidth = 45;
            this.colHO.Name = "colHO";
            this.colHO.Visible = true;
            this.colHO.VisibleIndex = 1;
            this.colHO.Width = 169;
            // 
            // colTEN
            // 
            this.colTEN.Caption = "Tên";
            this.colTEN.FieldName = "TEN";
            this.colTEN.MinWidth = 45;
            this.colTEN.Name = "colTEN";
            this.colTEN.Visible = true;
            this.colTEN.VisibleIndex = 2;
            this.colTEN.Width = 169;
            // 
            // colDIACHI
            // 
            this.colDIACHI.Caption = "Địa chỉ";
            this.colDIACHI.FieldName = "DIACHI";
            this.colDIACHI.MinWidth = 45;
            this.colDIACHI.Name = "colDIACHI";
            this.colDIACHI.Visible = true;
            this.colDIACHI.VisibleIndex = 3;
            this.colDIACHI.Width = 169;
            // 
            // colNGAYSINH
            // 
            this.colNGAYSINH.Caption = "Ngày Sinh";
            this.colNGAYSINH.FieldName = "NGAYSINH";
            this.colNGAYSINH.MinWidth = 45;
            this.colNGAYSINH.Name = "colNGAYSINH";
            this.colNGAYSINH.Visible = true;
            this.colNGAYSINH.VisibleIndex = 4;
            this.colNGAYSINH.Width = 169;
            // 
            // colLUONG
            // 
            this.colLUONG.Caption = "Lương";
            this.colLUONG.FieldName = "LUONG";
            this.colLUONG.MinWidth = 45;
            this.colLUONG.Name = "colLUONG";
            this.colLUONG.Visible = true;
            this.colLUONG.VisibleIndex = 5;
            this.colLUONG.Width = 169;
            // 
            // colMACN
            // 
            this.colMACN.Caption = "Mã CN";
            this.colMACN.FieldName = "MACN";
            this.colMACN.MinWidth = 45;
            this.colMACN.Name = "colMACN";
            this.colMACN.Visible = true;
            this.colMACN.VisibleIndex = 6;
            this.colMACN.Width = 169;
            // 
            // colTrangThaiXoa
            // 
            this.colTrangThaiXoa.Caption = "Trạng thái xóa";
            this.colTrangThaiXoa.FieldName = "TrangThaiXoa";
            this.colTrangThaiXoa.MinWidth = 45;
            this.colTrangThaiXoa.Name = "colTrangThaiXoa";
            this.colTrangThaiXoa.Visible = true;
            this.colTrangThaiXoa.VisibleIndex = 7;
            this.colTrangThaiXoa.Width = 169;
            // 
            // cmbCN
            // 
            this.cmbCN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCN.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCN.FormattingEnabled = true;
            this.cmbCN.Location = new System.Drawing.Point(466, 26);
            this.cmbCN.Margin = new System.Windows.Forms.Padding(4);
            this.cmbCN.Name = "cmbCN";
            this.cmbCN.Size = new System.Drawing.Size(582, 42);
            this.cmbCN.TabIndex = 12;
            this.cmbCN.SelectedIndexChanged += new System.EventHandler(this.cmbCN_SelectedIndexChanged);
            // 
            // bdsCN
            // 
            this.bdsCN.DataMember = "ChiNhanh";
            this.bdsCN.DataSource = this.dataSet;
            // 
            // taCN
            // 
            this.taCN.ClearBeforeFill = true;
            // 
            // gbNV
            // 
            this.gbNV.BackgroundImage = global::QL_VT.Properties.Resources.hinh_nen_mau_hong_29;
            this.gbNV.Controls.Add(mANVLabel);
            this.gbNV.Controls.Add(hOLabel);
            this.gbNV.Controls.Add(this.txtHO);
            this.gbNV.Controls.Add(tENLabel);
            this.gbNV.Controls.Add(this.txtTEN);
            this.gbNV.Controls.Add(dIACHILabel);
            this.gbNV.Controls.Add(this.txtDIACHI);
            this.gbNV.Controls.Add(nGAYSINHLabel);
            this.gbNV.Controls.Add(this.dtpNGAYSINH);
            this.gbNV.Controls.Add(lUONGLabel);
            this.gbNV.Controls.Add(this.txtLuong);
            this.gbNV.Controls.Add(mACNLabel);
            this.gbNV.Controls.Add(this.txtMACN);
            this.gbNV.Controls.Add(trangThaiXoaLabel);
            this.gbNV.Controls.Add(this.txtMANV);
            this.gbNV.Controls.Add(this.txtTRANGTHAIXOA);
            this.gbNV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbNV.Enabled = false;
            this.gbNV.Location = new System.Drawing.Point(0, 479);
            this.gbNV.Margin = new System.Windows.Forms.Padding(4);
            this.gbNV.Name = "gbNV";
            this.gbNV.Padding = new System.Windows.Forms.Padding(4);
            this.gbNV.Size = new System.Drawing.Size(2373, 904);
            this.gbNV.TabIndex = 18;
            this.gbNV.TabStop = false;
            // 
            // txtHO
            // 
            this.txtHO.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsNV, "HO", true));
            this.txtHO.Location = new System.Drawing.Point(731, 18);
            this.txtHO.Margin = new System.Windows.Forms.Padding(4);
            this.txtHO.MenuManager = this.bmNV;
            this.txtHO.Name = "txtHO";
            this.txtHO.Size = new System.Drawing.Size(195, 44);
            this.txtHO.TabIndex = 3;
            // 
            // txtTEN
            // 
            this.txtTEN.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsNV, "TEN", true));
            this.txtTEN.Location = new System.Drawing.Point(1100, 18);
            this.txtTEN.Margin = new System.Windows.Forms.Padding(4);
            this.txtTEN.MenuManager = this.bmNV;
            this.txtTEN.Name = "txtTEN";
            this.txtTEN.Size = new System.Drawing.Size(176, 44);
            this.txtTEN.TabIndex = 5;
            // 
            // txtDIACHI
            // 
            this.txtDIACHI.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsNV, "DIACHI", true));
            this.txtDIACHI.Location = new System.Drawing.Point(260, 174);
            this.txtDIACHI.Margin = new System.Windows.Forms.Padding(4);
            this.txtDIACHI.MenuManager = this.bmNV;
            this.txtDIACHI.Name = "txtDIACHI";
            this.txtDIACHI.Size = new System.Drawing.Size(1016, 44);
            this.txtDIACHI.TabIndex = 7;
            // 
            // dtpNGAYSINH
            // 
            this.dtpNGAYSINH.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsNV, "NGAYSINH", true));
            this.dtpNGAYSINH.EditValue = null;
            this.dtpNGAYSINH.Location = new System.Drawing.Point(260, 70);
            this.dtpNGAYSINH.Margin = new System.Windows.Forms.Padding(4);
            this.dtpNGAYSINH.MenuManager = this.bmNV;
            this.dtpNGAYSINH.Name = "dtpNGAYSINH";
            this.dtpNGAYSINH.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpNGAYSINH.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpNGAYSINH.Size = new System.Drawing.Size(186, 44);
            this.dtpNGAYSINH.TabIndex = 9;
            // 
            // txtLuong
            // 
            this.txtLuong.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsNV, "LUONG", true));
            this.txtLuong.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtLuong.Location = new System.Drawing.Point(731, 70);
            this.txtLuong.Margin = new System.Windows.Forms.Padding(4);
            this.txtLuong.MenuManager = this.bmNV;
            this.txtLuong.Name = "txtLuong";
            this.txtLuong.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtLuong.Size = new System.Drawing.Size(195, 44);
            this.txtLuong.TabIndex = 11;
            // 
            // txtMACN
            // 
            this.txtMACN.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsNV, "MACN", true));
            this.txtMACN.Enabled = false;
            this.txtMACN.Location = new System.Drawing.Point(260, 122);
            this.txtMACN.Margin = new System.Windows.Forms.Padding(4);
            this.txtMACN.MenuManager = this.bmNV;
            this.txtMACN.Name = "txtMACN";
            this.txtMACN.Size = new System.Drawing.Size(186, 44);
            this.txtMACN.TabIndex = 13;
            // 
            // txtMANV
            // 
            this.txtMANV.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsNV, "MANV", true));
            this.txtMANV.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtMANV.Location = new System.Drawing.Point(260, 18);
            this.txtMANV.Margin = new System.Windows.Forms.Padding(4);
            this.txtMANV.MenuManager = this.bmNV;
            this.txtMANV.Name = "txtMANV";
            this.txtMANV.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered;
            this.txtMANV.Properties.Mask.BeepOnError = true;
            this.txtMANV.Properties.Mask.EditMask = "d";
            this.txtMANV.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtMANV.Size = new System.Drawing.Size(186, 44);
            this.txtMANV.TabIndex = 1;
            // 
            // txtTRANGTHAIXOA
            // 
            this.txtTRANGTHAIXOA.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsNV, "TrangThaiXoa", true));
            this.txtTRANGTHAIXOA.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtTRANGTHAIXOA.Enabled = false;
            this.txtTRANGTHAIXOA.Location = new System.Drawing.Point(731, 122);
            this.txtTRANGTHAIXOA.Margin = new System.Windows.Forms.Padding(4);
            this.txtTRANGTHAIXOA.MenuManager = this.bmNV;
            this.txtTRANGTHAIXOA.Name = "txtTRANGTHAIXOA";
            this.txtTRANGTHAIXOA.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered;
            this.txtTRANGTHAIXOA.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtTRANGTHAIXOA.Size = new System.Drawing.Size(195, 44);
            this.txtTRANGTHAIXOA.TabIndex = 15;
            // 
            // bdsPHIEUNHAP
            // 
            this.bdsPHIEUNHAP.DataMember = "FK_PhieuNhap_NhanVien";
            this.bdsPHIEUNHAP.DataSource = this.bdsNV;
            // 
            // taPHIEUNHAP
            // 
            this.taPHIEUNHAP.ClearBeforeFill = true;
            // 
            // bdsDATHANG
            // 
            this.bdsDATHANG.DataMember = "FK_DatHang_NhanVien";
            this.bdsDATHANG.DataSource = this.bdsNV;
            // 
            // taDATHANG
            // 
            this.taDATHANG.ClearBeforeFill = true;
            // 
            // txtCN
            // 
            this.txtCN.AutoSize = true;
            this.txtCN.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCN.Location = new System.Drawing.Point(292, 29);
            this.txtCN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtCN.Name = "txtCN";
            this.txtCN.Size = new System.Drawing.Size(145, 34);
            this.txtCN.TabIndex = 23;
            this.txtCN.Text = "Chi Nhánh";
            // 
            // bdsPHIEUXUAT
            // 
            this.bdsPHIEUXUAT.DataMember = "FK_PX_NhanVien";
            this.bdsPHIEUXUAT.DataSource = this.bdsNV;
            // 
            // taPHIEUXUAT
            // 
            this.taPHIEUXUAT.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmbCN);
            this.panel1.Controls.Add(this.txtCN);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.panel1.Location = new System.Drawing.Point(0, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2373, 84);
            this.panel1.TabIndex = 28;
            // 
            // splitterControl1
            // 
            this.splitterControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitterControl1.Location = new System.Drawing.Point(0, 479);
            this.splitterControl1.Name = "splitterControl1";
            this.splitterControl1.Size = new System.Drawing.Size(2373, 11);
            this.splitterControl1.TabIndex = 29;
            this.splitterControl1.TabStop = false;
            // 
            // frmNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 34F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2373, 1383);
            this.Controls.Add(this.splitterControl1);
            this.Controls.Add(this.gbNV);
            this.Controls.Add(this.gcNV);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmNhanVien";
            this.Text = "Nhân Viên";
            this.Load += new System.EventHandler(this.frmNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bmNV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsNV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcNV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCN)).EndInit();
            this.gbNV.ResumeLayout(false);
            this.gbNV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtHO.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTEN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDIACHI.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpNGAYSINH.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpNGAYSINH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLuong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMACN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMANV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTRANGTHAIXOA.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPHIEUNHAP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDATHANG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPHIEUXUAT)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager bmNV;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnSua;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnRefresh;
        private DevExpress.XtraBars.BarButtonItem btnGhi;
        private DevExpress.XtraBars.BarButtonItem btnPhucHoi;
        private DevExpress.XtraBars.BarButtonItem btnDanhSach;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private System.Windows.Forms.BindingSource bdsNV;
        private QL_VATTUDataSet dataSet;
        private QL_VATTUDataSetTableAdapters.NhanVienTableAdapter taNV;
        private QL_VATTUDataSetTableAdapters.TableAdapterManager taNVManager;
        private DevExpress.XtraGrid.GridControl gcNV;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMANV;
        private DevExpress.XtraGrid.Columns.GridColumn colHO;
        private DevExpress.XtraGrid.Columns.GridColumn colTEN;
        private DevExpress.XtraGrid.Columns.GridColumn colDIACHI;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYSINH;
        private DevExpress.XtraGrid.Columns.GridColumn colLUONG;
        private DevExpress.XtraGrid.Columns.GridColumn colMACN;
        private DevExpress.XtraGrid.Columns.GridColumn colTrangThaiXoa;
        private System.Windows.Forms.ComboBox cmbCN;
        private System.Windows.Forms.BindingSource bdsCN;
        private QL_VATTUDataSetTableAdapters.ChiNhanhTableAdapter taCN;
        private System.Windows.Forms.GroupBox gbNV;
        private DevExpress.XtraEditors.TextEdit txtHO;
        private DevExpress.XtraEditors.TextEdit txtTEN;
        private DevExpress.XtraEditors.TextEdit txtDIACHI;
        private DevExpress.XtraEditors.DateEdit dtpNGAYSINH;
        private DevExpress.XtraEditors.SpinEdit txtLuong;
        private DevExpress.XtraEditors.TextEdit txtMACN;
        private DevExpress.XtraEditors.TextEdit txtMANV;
        private DevExpress.XtraEditors.TextEdit txtTRANGTHAIXOA;
        private DevExpress.XtraBars.BarButtonItem btnHuy;
        private System.Windows.Forms.BindingSource bdsPHIEUNHAP;
        private QL_VATTUDataSetTableAdapters.PhieuNhapTableAdapter taPHIEUNHAP;
        private System.Windows.Forms.BindingSource bdsDATHANG;
        private QL_VATTUDataSetTableAdapters.DatHangTableAdapter taDATHANG;
        private System.Windows.Forms.Label txtCN;
        private System.Windows.Forms.BindingSource bdsPHIEUXUAT;
        private QL_VATTUDataSetTableAdapters.PhieuXuatTableAdapter taPHIEUXUAT;
        private DevExpress.XtraBars.BarButtonItem btnChuyenCN;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private DevExpress.XtraBars.BarButtonItem btnTaoLogin;
        private DevExpress.XtraBars.BarButtonItem babtnDatHang;
        private DevExpress.XtraBars.BarButtonItem babtnPhieuXuat;
        private DevExpress.XtraBars.BarButtonItem babtnPhieuNhap;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SplitterControl splitterControl1;
    }
}
using System; using System.Drawing; using System.Collections; using System.ComponentModel; using System.Windows.Forms; using System.Data; using System.Data.SqlClient; using System.IO;   namespace HRM_CHECKER { 	/// <summary> 	/// Summary description for Form1. 	/// </summary> 	public class Form1 : System.Windows.Forms.Form 	{ 		
		string SVPath = Application.StartupPath + @"\IDIMG\"; 		private System.Windows.Forms.ToolBar toolBar1; 		private System.Windows.Forms.ImageList imageList1;
		private System.Windows.Forms.StatusBar statusBar1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Splitter splitter1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.Panel panel8;
		private System.Windows.Forms.Panel panel7;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.Panel panel9;
		private System.Windows.Forms.Label label21;
		private System.Windows.Forms.Panel panel10;
		private System.Windows.Forms.Label label22;
		private System.Windows.Forms.Panel panel11;
		private System.Windows.Forms.Label label23;
		private System.Windows.Forms.GroupBox groupBox5;
		private System.Windows.Forms.Panel panel12;
		private System.Windows.Forms.Panel panel13;
		private System.Windows.Forms.Label label24;
		private System.Windows.Forms.Panel panel14;
		private System.Windows.Forms.Label label25;
		private System.Windows.Forms.Panel panel15;
		private System.Windows.Forms.Label label26;
		private System.Windows.Forms.Panel panel16;
		private System.Windows.Forms.Label label27;
		private System.Windows.Forms.GroupBox groupBox6;
		private System.Windows.Forms.Panel panel17;
		private System.Windows.Forms.Panel panel18;
		private System.Windows.Forms.Label label28;
		private System.Windows.Forms.Panel panel19;
		private System.Windows.Forms.Label label29;
		private System.Windows.Forms.TextBox textBox15;
		private System.Windows.Forms.Label label30;
		private System.Windows.Forms.Label label31;
		private System.Windows.Forms.TextBox textBox16;
		private System.Windows.Forms.Label label32;
		private System.Windows.Forms.TextBox textBox17;
		private System.Windows.Forms.GroupBox groupBox7;
		private System.Windows.Forms.Label label33;
		private System.Windows.Forms.Label label34;
		private System.Windows.Forms.TextBox txtHopThu;
		private System.Windows.Forms.TextBox txtDienThoaiDD;
		private System.Windows.Forms.TextBox txtDienThoaiNha;
		private System.Windows.Forms.TextBox txtDiaChiNuocNgoai;
		private System.Windows.Forms.TextBox txtDiaChiCuTru;
		private System.Windows.Forms.TextBox txtDiaChiLienHe;
		private System.Windows.Forms.TextBox txtSo_CMND;
		private System.Windows.Forms.TextBox txtNoiCap_CMND;
		private System.Windows.Forms.CheckBox ck_Khac_CMND;
		private System.Windows.Forms.CheckBox ck_HoChieu;
		private System.Windows.Forms.CheckBox ck_CMND;
		private System.Windows.Forms.TextBox txtQuocTich;
		private System.Windows.Forms.TextBox txtTenVietTat;
		private System.Windows.Forms.TextBox txtHoTen;
		private System.Windows.Forms.CheckBox ck_LT_Khac;
		private System.Windows.Forms.CheckBox ck_LT_DoLa;
		private System.Windows.Forms.CheckBox ck_LT_VietNam;
		private System.Windows.Forms.CheckBox ck_LTK_Khac;
		private System.Windows.Forms.CheckBox ck_LTK_DongChuTK;
		private System.Windows.Forms.CheckBox ck_LTK_GiaoDich;
		private System.Windows.Forms.Button btThemKH;
		private System.Windows.Forms.Panel panel20;
		private System.Windows.Forms.Splitter splitter2;
		private System.Windows.Forms.Panel panel21;
		private System.Windows.Forms.Panel panel22;
		private System.Windows.Forms.Splitter splitter3;
		private System.Windows.Forms.Panel panel23;
		private System.Windows.Forms.Label label35;
		private System.Windows.Forms.Label label36;
		private System.Windows.Forms.GroupBox groupBox8;
		private System.Windows.Forms.Panel panel24;
		private System.Windows.Forms.Panel panel25;
		private System.Windows.Forms.Panel panel26;
		private System.Windows.Forms.Label label37;
		private System.Windows.Forms.Panel panel27;
		private System.Windows.Forms.Label label38;
		private System.Windows.Forms.Panel panel28;
		private System.Windows.Forms.Label label39;
		private System.Windows.Forms.Panel panel29;
		private System.Windows.Forms.Label label40;
		private System.Windows.Forms.GroupBox groupBox9;
		private System.Windows.Forms.Panel panel30;
		private System.Windows.Forms.Panel panel31;
		private System.Windows.Forms.Label label41;
		private System.Windows.Forms.Panel panel32;
		private System.Windows.Forms.Label label42;
		private System.Windows.Forms.Panel panel33;
		private System.Windows.Forms.Panel panel34;
		private System.Windows.Forms.Label label43;
		private System.Windows.Forms.Panel panel35;
		private System.Windows.Forms.Label label44;
		private System.Windows.Forms.GroupBox groupBox10;
		private System.Windows.Forms.Panel panel36;
		private System.Windows.Forms.Panel panel38;
		private System.Windows.Forms.Label label46;
		private System.Windows.Forms.Panel panel39;
		private System.Windows.Forms.Panel panel41;
		private System.Windows.Forms.Label label48;
		private System.Windows.Forms.ErrorProvider errorProvider1;
		private System.Windows.Forms.Label label45;
		private System.Windows.Forms.Label label47;
		private System.Windows.Forms.DataGrid dtgKhachHang;
		private System.Windows.Forms.RadioButton rbNam;
		private System.Windows.Forms.RadioButton rbNu;
		private System.Windows.Forms.CheckBox ck_NN_NghiHuu;
		private System.Windows.Forms.CheckBox ck_NN_KinhDoanh;
		private System.Windows.Forms.CheckBox ck_NN_DiLam;
		private System.Windows.Forms.CheckBox ck_NN_DiHoc;
		private System.Windows.Forms.RadioButton rb_HN_GiaDinh;
		private System.Windows.Forms.RadioButton rb_HN_DocTHan;
		private System.Windows.Forms.RadioButton rb_HN_LyDi;
		private System.Windows.Forms.RadioButton rb_HN_Goa;
		private System.Windows.Forms.RadioButton rb_TN_Duoi12;
		private System.Windows.Forms.RadioButton rb_TN_Tu12;
		private System.Windows.Forms.RadioButton rb_TN_Tu36;
		private System.Windows.Forms.RadioButton rb_TN_Tren60;
		private System.Windows.Forms.TextBox txtNganhNghe;
		private System.Windows.Forms.TextBox txtChucVu;
		private System.Windows.Forms.TextBox txtCoQuan;
		private System.Windows.Forms.CheckBox ck_HV_DuoiTHPT;
		private System.Windows.Forms.CheckBox ck_HV_THPT;
		private System.Windows.Forms.CheckBox ck_HV_CaoDang;
		private System.Windows.Forms.CheckBox ck_HV_DaiHoc;
		private System.Windows.Forms.CheckBox ck_HV_SauDH;
		private System.Windows.Forms.DateTimePicker dtNgaySinh;
		private System.Windows.Forms.DateTimePicker dtNgayCap;
		private System.Windows.Forms.ContextMenu contextMenuGrid;
		private System.Windows.Forms.MenuItem menuItemThem;
		private System.Windows.Forms.MenuItem menuItemSua;
		private System.Windows.Forms.MenuItem menuItem3;
		private System.Windows.Forms.MenuItem menuItemLamMoi;
		private System.Windows.Forms.Label lbThongBao;
		private System.Windows.Forms.MenuItem menuItemXoa;
		private System.Windows.Forms.ToolBarButton tbbtHeThong;
		private System.Windows.Forms.ToolBarButton tbbtNhapDs;
		private System.Windows.Forms.ToolBarButton tbbtKhaiThac;
		private System.Windows.Forms.ToolBarButton tbbtBaoCao;
		private System.Windows.Forms.ToolBarButton ttbtSepe;
		private System.Windows.Forms.ToolBarButton tbbtBanQuyen;
		private System.Windows.Forms.Button btLamLai;
		private System.Windows.Forms.Button btSuaKH; 		private System.ComponentModel.IContainer components;  		private Image CMNDMoi_MatTruoc = null; 		private Image CMNDMoi_MatSau = null; 		private Image CMNDMoi_VanTay1 = null; 		private Image CMNDMoi_VanTay2 = null; 		private Image CMNDCu_MatTruoc = null; 		private Image CMNDCu_MatSau = null; 		private Image CMNDCu_VanTay1 = null;
		private Image CMNDCu_VanTay2 = null;
		private System.Windows.Forms.PictureBox picCMNDMoi_MatTruoc;
		private System.Windows.Forms.PictureBox picCMNDCu_MatTruoc;
		private System.Windows.Forms.PictureBox picCMNDCu_MatSau;
		private System.Windows.Forms.PictureBox picCMNDMoi_MatSau;
		private System.Windows.Forms.PictureBox picVanTaySong2;
		private System.Windows.Forms.PictureBox picVanTaySong1;
		private System.Windows.Forms.PictureBox picCMNDCu_VanTay2;
		private System.Windows.Forms.PictureBox picCMNDCu_VanTay1;
		private System.Windows.Forms.PictureBox picCMNDMoi_VanTay2;
		private System.Windows.Forms.PictureBox picCMNDMoi_VanTay1;
		private System.Windows.Forms.PictureBox picCMNDCu_VanTay2SS;
		private System.Windows.Forms.PictureBox picCMNDCu_VanTay1SS;
		private System.Windows.Forms.PictureBox picCMNDCu_MatSauSS;
		private System.Windows.Forms.PictureBox picCMNDMoi_VanTay2SS;
		private System.Windows.Forms.PictureBox picCMNDMoi_VanTay1SS;
		private System.Windows.Forms.PictureBox picCMNDMoi_MatSauSS;
		private System.Windows.Forms.PictureBox picCMNDMoi_MatTruocSS;
		private System.Windows.Forms.PictureBox picVanTaySong2SS;
		private System.Windows.Forms.PictureBox picVanTaySong1SS;
		private System.Windows.Forms.Button btnTimKiem;
		private System.Windows.Forms.TextBox txt_TK_SoCMND;
		private System.Windows.Forms.TextBox txt_TK_SoTaiKhoan;
		private System.Windows.Forms.TextBox txt_TK_HoTen;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.TabControl tabControl;
		private System.Windows.Forms.PictureBox picCMNDCu_MatTruocSS;
		private System.Windows.Forms.Button btnInDanhSach;
		private System.Windows.Forms.MenuItem menuItemChiTiet;  		public Form1() 		{ 			// 			// Required for Windows Form Designer support 			// 			InitializeComponent();  			// 			// TODO: Add any constructor code after InitializeComponent call 			// 		}  		/// <summary> 		/// Clean up any resources being used. 		/// </summary> 		protected override void Dispose( bool disposing ) 		{ 			if( disposing ) 			{ 				if (components != null)  				{ 					components.Dispose(); 				} 			} 			base.Dispose( disposing ); 		}  		#region Windows Form Designer generated code 		/// <summary> 		/// Required method for Designer support - do not modify 		/// the contents of this method with the code editor. 		/// </summary> 		private void InitializeComponent() 		{ 			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form1));
			this.toolBar1 = new System.Windows.Forms.ToolBar();
			this.tbbtHeThong = new System.Windows.Forms.ToolBarButton();
			this.tbbtNhapDs = new System.Windows.Forms.ToolBarButton();
			this.tbbtKhaiThac = new System.Windows.Forms.ToolBarButton();
			this.tbbtBaoCao = new System.Windows.Forms.ToolBarButton();
			this.ttbtSepe = new System.Windows.Forms.ToolBarButton();
			this.tbbtBanQuyen = new System.Windows.Forms.ToolBarButton();
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.statusBar1 = new System.Windows.Forms.StatusBar();
			this.tabControl = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel5 = new System.Windows.Forms.Panel();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.txtCoQuan = new System.Windows.Forms.TextBox();
			this.txtChucVu = new System.Windows.Forms.TextBox();
			this.txtNganhNghe = new System.Windows.Forms.TextBox();
			this.rb_HN_Goa = new System.Windows.Forms.RadioButton();
			this.rb_HN_LyDi = new System.Windows.Forms.RadioButton();
			this.rb_HN_DocTHan = new System.Windows.Forms.RadioButton();
			this.rb_HN_GiaDinh = new System.Windows.Forms.RadioButton();
			this.ck_HV_DuoiTHPT = new System.Windows.Forms.CheckBox();
			this.ck_HV_THPT = new System.Windows.Forms.CheckBox();
			this.ck_HV_CaoDang = new System.Windows.Forms.CheckBox();
			this.ck_HV_DaiHoc = new System.Windows.Forms.CheckBox();
			this.ck_HV_SauDH = new System.Windows.Forms.CheckBox();
			this.label33 = new System.Windows.Forms.Label();
			this.label34 = new System.Windows.Forms.Label();
			this.groupBox7 = new System.Windows.Forms.GroupBox();
			this.rb_TN_Tren60 = new System.Windows.Forms.RadioButton();
			this.rb_TN_Tu36 = new System.Windows.Forms.RadioButton();
			this.rb_TN_Tu12 = new System.Windows.Forms.RadioButton();
			this.rb_TN_Duoi12 = new System.Windows.Forms.RadioButton();
			this.label32 = new System.Windows.Forms.Label();
			this.label31 = new System.Windows.Forms.Label();
			this.ck_NN_NghiHuu = new System.Windows.Forms.CheckBox();
			this.ck_NN_KinhDoanh = new System.Windows.Forms.CheckBox();
			this.ck_NN_DiLam = new System.Windows.Forms.CheckBox();
			this.ck_NN_DiHoc = new System.Windows.Forms.CheckBox();
			this.label30 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.dtNgayCap = new System.Windows.Forms.DateTimePicker();
			this.dtNgaySinh = new System.Windows.Forms.DateTimePicker();
			this.rbNu = new System.Windows.Forms.RadioButton();
			this.rbNam = new System.Windows.Forms.RadioButton();
			this.txtHopThu = new System.Windows.Forms.TextBox();
			this.label19 = new System.Windows.Forms.Label();
			this.txtDienThoaiDD = new System.Windows.Forms.TextBox();
			this.label18 = new System.Windows.Forms.Label();
			this.txtDienThoaiNha = new System.Windows.Forms.TextBox();
			this.label17 = new System.Windows.Forms.Label();
			this.txtDiaChiNuocNgoai = new System.Windows.Forms.TextBox();
			this.label16 = new System.Windows.Forms.Label();
			this.txtDiaChiCuTru = new System.Windows.Forms.TextBox();
			this.label15 = new System.Windows.Forms.Label();
			this.txtDiaChiLienHe = new System.Windows.Forms.TextBox();
			this.label14 = new System.Windows.Forms.Label();
			this.txtSo_CMND = new System.Windows.Forms.TextBox();
			this.label13 = new System.Windows.Forms.Label();
			this.txtNoiCap_CMND = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.ck_Khac_CMND = new System.Windows.Forms.CheckBox();
			this.ck_HoChieu = new System.Windows.Forms.CheckBox();
			this.ck_CMND = new System.Windows.Forms.CheckBox();
			this.txtQuocTich = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.txtTenVietTat = new System.Windows.Forms.TextBox();
			this.txtHoTen = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.ck_LT_Khac = new System.Windows.Forms.CheckBox();
			this.ck_LT_DoLa = new System.Windows.Forms.CheckBox();
			this.ck_LT_VietNam = new System.Windows.Forms.CheckBox();
			this.ck_LTK_Khac = new System.Windows.Forms.CheckBox();
			this.ck_LTK_DongChuTK = new System.Windows.Forms.CheckBox();
			this.ck_LTK_GiaoDich = new System.Windows.Forms.CheckBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.panel3 = new System.Windows.Forms.Panel();
			this.btLamLai = new System.Windows.Forms.Button();
			this.btSuaKH = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.btThemKH = new System.Windows.Forms.Button();
			this.splitter1 = new System.Windows.Forms.Splitter();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel6 = new System.Windows.Forms.Panel();
			this.groupBox6 = new System.Windows.Forms.GroupBox();
			this.panel17 = new System.Windows.Forms.Panel();
			this.panel18 = new System.Windows.Forms.Panel();
			this.picVanTaySong2 = new System.Windows.Forms.PictureBox();
			this.label28 = new System.Windows.Forms.Label();
			this.panel19 = new System.Windows.Forms.Panel();
			this.picVanTaySong1 = new System.Windows.Forms.PictureBox();
			this.label29 = new System.Windows.Forms.Label();
			this.groupBox5 = new System.Windows.Forms.GroupBox();
			this.panel12 = new System.Windows.Forms.Panel();
			this.panel13 = new System.Windows.Forms.Panel();
			this.picCMNDCu_VanTay2 = new System.Windows.Forms.PictureBox();
			this.label24 = new System.Windows.Forms.Label();
			this.panel14 = new System.Windows.Forms.Panel();
			this.picCMNDCu_VanTay1 = new System.Windows.Forms.PictureBox();
			this.label25 = new System.Windows.Forms.Label();
			this.panel15 = new System.Windows.Forms.Panel();
			this.picCMNDMoi_MatSau = new System.Windows.Forms.PictureBox();
			this.label26 = new System.Windows.Forms.Label();
			this.panel16 = new System.Windows.Forms.Panel();
			this.picCMNDMoi_MatTruoc = new System.Windows.Forms.PictureBox();
			this.label27 = new System.Windows.Forms.Label();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.panel8 = new System.Windows.Forms.Panel();
			this.panel10 = new System.Windows.Forms.Panel();
			this.picCMNDMoi_VanTay2 = new System.Windows.Forms.PictureBox();
			this.label22 = new System.Windows.Forms.Label();
			this.panel11 = new System.Windows.Forms.Panel();
			this.picCMNDMoi_VanTay1 = new System.Windows.Forms.PictureBox();
			this.label23 = new System.Windows.Forms.Label();
			this.panel9 = new System.Windows.Forms.Panel();
			this.picCMNDCu_MatSau = new System.Windows.Forms.PictureBox();
			this.label21 = new System.Windows.Forms.Label();
			this.panel7 = new System.Windows.Forms.Panel();
			this.picCMNDCu_MatTruoc = new System.Windows.Forms.PictureBox();
			this.label20 = new System.Windows.Forms.Label();
			this.panel4 = new System.Windows.Forms.Panel();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.panel21 = new System.Windows.Forms.Panel();
			this.dtgKhachHang = new System.Windows.Forms.DataGrid();
			this.contextMenuGrid = new System.Windows.Forms.ContextMenu();
			this.menuItemChiTiet = new System.Windows.Forms.MenuItem();
			this.menuItemThem = new System.Windows.Forms.MenuItem();
			this.menuItemSua = new System.Windows.Forms.MenuItem();
			this.menuItemXoa = new System.Windows.Forms.MenuItem();
			this.menuItem3 = new System.Windows.Forms.MenuItem();
			this.menuItemLamMoi = new System.Windows.Forms.MenuItem();
			this.splitter2 = new System.Windows.Forms.Splitter();
			this.panel20 = new System.Windows.Forms.Panel();
			this.panel23 = new System.Windows.Forms.Panel();
			this.groupBox10 = new System.Windows.Forms.GroupBox();
			this.panel36 = new System.Windows.Forms.Panel();
			this.panel38 = new System.Windows.Forms.Panel();
			this.picVanTaySong2SS = new System.Windows.Forms.PictureBox();
			this.label46 = new System.Windows.Forms.Label();
			this.panel39 = new System.Windows.Forms.Panel();
			this.panel41 = new System.Windows.Forms.Panel();
			this.picVanTaySong1SS = new System.Windows.Forms.PictureBox();
			this.label48 = new System.Windows.Forms.Label();
			this.groupBox9 = new System.Windows.Forms.GroupBox();
			this.panel30 = new System.Windows.Forms.Panel();
			this.panel31 = new System.Windows.Forms.Panel();
			this.picCMNDMoi_VanTay2SS = new System.Windows.Forms.PictureBox();
			this.label41 = new System.Windows.Forms.Label();
			this.panel32 = new System.Windows.Forms.Panel();
			this.picCMNDMoi_VanTay1SS = new System.Windows.Forms.PictureBox();
			this.label42 = new System.Windows.Forms.Label();
			this.panel33 = new System.Windows.Forms.Panel();
			this.panel34 = new System.Windows.Forms.Panel();
			this.picCMNDMoi_MatTruocSS = new System.Windows.Forms.PictureBox();
			this.label43 = new System.Windows.Forms.Label();
			this.panel35 = new System.Windows.Forms.Panel();
			this.picCMNDMoi_MatSauSS = new System.Windows.Forms.PictureBox();
			this.label44 = new System.Windows.Forms.Label();
			this.groupBox8 = new System.Windows.Forms.GroupBox();
			this.panel25 = new System.Windows.Forms.Panel();
			this.panel29 = new System.Windows.Forms.Panel();
			this.picCMNDCu_VanTay2SS = new System.Windows.Forms.PictureBox();
			this.label40 = new System.Windows.Forms.Label();
			this.panel28 = new System.Windows.Forms.Panel();
			this.picCMNDCu_VanTay1SS = new System.Windows.Forms.PictureBox();
			this.label39 = new System.Windows.Forms.Label();
			this.panel24 = new System.Windows.Forms.Panel();
			this.panel27 = new System.Windows.Forms.Panel();
			this.picCMNDCu_MatTruocSS = new System.Windows.Forms.PictureBox();
			this.label38 = new System.Windows.Forms.Label();
			this.panel26 = new System.Windows.Forms.Panel();
			this.picCMNDCu_MatSauSS = new System.Windows.Forms.PictureBox();
			this.label37 = new System.Windows.Forms.Label();
			this.splitter3 = new System.Windows.Forms.Splitter();
			this.panel22 = new System.Windows.Forms.Panel();
			this.btnTimKiem = new System.Windows.Forms.Button();
			this.label47 = new System.Windows.Forms.Label();
			this.txt_TK_SoCMND = new System.Windows.Forms.TextBox();
			this.label45 = new System.Windows.Forms.Label();
			this.txt_TK_SoTaiKhoan = new System.Windows.Forms.TextBox();
			this.label36 = new System.Windows.Forms.Label();
			this.txt_TK_HoTen = new System.Windows.Forms.TextBox();
			this.label35 = new System.Windows.Forms.Label();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider();
			this.lbThongBao = new System.Windows.Forms.Label();
			this.btnInDanhSach = new System.Windows.Forms.Button();
			this.tabControl.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel5.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox7.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.panel3.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panel6.SuspendLayout();
			this.groupBox6.SuspendLayout();
			this.panel17.SuspendLayout();
			this.panel18.SuspendLayout();
			this.panel19.SuspendLayout();
			this.groupBox5.SuspendLayout();
			this.panel12.SuspendLayout();
			this.panel13.SuspendLayout();
			this.panel14.SuspendLayout();
			this.panel15.SuspendLayout();
			this.panel16.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.panel8.SuspendLayout();
			this.panel10.SuspendLayout();
			this.panel11.SuspendLayout();
			this.panel9.SuspendLayout();
			this.panel7.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.panel21.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dtgKhachHang)).BeginInit();
			this.panel20.SuspendLayout();
			this.panel23.SuspendLayout();
			this.groupBox10.SuspendLayout();
			this.panel36.SuspendLayout();
			this.panel38.SuspendLayout();
			this.panel39.SuspendLayout();
			this.panel41.SuspendLayout();
			this.groupBox9.SuspendLayout();
			this.panel30.SuspendLayout();
			this.panel31.SuspendLayout();
			this.panel32.SuspendLayout();
			this.panel33.SuspendLayout();
			this.panel34.SuspendLayout();
			this.panel35.SuspendLayout();
			this.groupBox8.SuspendLayout();
			this.panel25.SuspendLayout();
			this.panel29.SuspendLayout();
			this.panel28.SuspendLayout();
			this.panel24.SuspendLayout();
			this.panel27.SuspendLayout();
			this.panel26.SuspendLayout();
			this.panel22.SuspendLayout();
			this.SuspendLayout();
			// 
			// toolBar1
			// 
			this.toolBar1.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
																						this.tbbtHeThong,
																						this.tbbtNhapDs,
																						this.tbbtKhaiThac,
																						this.tbbtBaoCao,
																						this.ttbtSepe,
																						this.tbbtBanQuyen});
			this.toolBar1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.toolBar1.DropDownArrows = true;
			this.toolBar1.ImageList = this.imageList1;
			this.toolBar1.Location = new System.Drawing.Point(0, 0);
			this.toolBar1.Name = "toolBar1";
			this.toolBar1.ShowToolTips = true;
			this.toolBar1.Size = new System.Drawing.Size(984, 55);
			this.toolBar1.TabIndex = 0;
			this.toolBar1.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.toolBar1_ButtonClick);
			// 
			// tbbtHeThong
			// 
			this.tbbtHeThong.ImageIndex = 22;
			this.tbbtHeThong.Text = "Hệ thống";
			this.tbbtHeThong.ToolTipText = "Hệ thống";
			// 
			// tbbtNhapDs
			// 
			this.tbbtNhapDs.ImageIndex = 27;
			this.tbbtNhapDs.Text = "Nhập danh sách";
			this.tbbtNhapDs.ToolTipText = "Nhập danh sách";
			// 
			// tbbtKhaiThac
			// 
			this.tbbtKhaiThac.ImageIndex = 26;
			this.tbbtKhaiThac.Text = "Khai thác";
			this.tbbtKhaiThac.ToolTipText = "Khai thác";
			// 
			// tbbtBaoCao
			// 
			this.tbbtBaoCao.ImageIndex = 21;
			this.tbbtBaoCao.Text = "Báo cáo ";
			this.tbbtBaoCao.ToolTipText = "Báo cáo";
			// 
			// ttbtSepe
			// 
			this.ttbtSepe.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			// 
			// tbbtBanQuyen
			// 
			this.tbbtBanQuyen.ImageIndex = 18;
			this.tbbtBanQuyen.Text = "Bản quyền";
			this.tbbtBanQuyen.ToolTipText = "Bản quyền";
			// 
			// imageList1
			// 
			this.imageList1.ImageSize = new System.Drawing.Size(24, 24);
			this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
			this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// statusBar1
			// 
			this.statusBar1.Location = new System.Drawing.Point(0, 699);
			this.statusBar1.Name = "statusBar1";
			this.statusBar1.Size = new System.Drawing.Size(984, 22);
			this.statusBar1.TabIndex = 1;
			this.statusBar1.Text = "Hệ thống thu thập thông tin  Design By EVNIT@";
			this.statusBar1.PanelClick += new System.Windows.Forms.StatusBarPanelClickEventHandler(this.statusBar1_PanelClick);
			// 
			// tabControl
			// 
			this.tabControl.Controls.Add(this.tabPage1);
			this.tabControl.Controls.Add(this.tabPage2);
			this.tabControl.Controls.Add(this.tabPage3);
			this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl.Location = new System.Drawing.Point(0, 55);
			this.tabControl.Name = "tabControl";
			this.tabControl.SelectedIndex = 0;
			this.tabControl.Size = new System.Drawing.Size(984, 644);
			this.tabControl.TabIndex = 2;
			this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.panel2);
			this.tabPage1.Controls.Add(this.splitter1);
			this.tabPage1.Controls.Add(this.panel1);
			this.tabPage1.Location = new System.Drawing.Point(4, 27);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Size = new System.Drawing.Size(976, 613);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Nhập thông tin khách hàng";
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.panel5);
			this.panel2.Controls.Add(this.panel3);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(403, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(573, 613);
			this.panel2.TabIndex = 2;
			// 
			// panel5
			// 
			this.panel5.AutoScroll = true;
			this.panel5.Controls.Add(this.groupBox3);
			this.panel5.Controls.Add(this.groupBox2);
			this.panel5.Controls.Add(this.groupBox1);
			this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel5.Location = new System.Drawing.Point(0, 48);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(573, 565);
			this.panel5.TabIndex = 5;
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.txtCoQuan);
			this.groupBox3.Controls.Add(this.txtChucVu);
			this.groupBox3.Controls.Add(this.txtNganhNghe);
			this.groupBox3.Controls.Add(this.rb_HN_Goa);
			this.groupBox3.Controls.Add(this.rb_HN_LyDi);
			this.groupBox3.Controls.Add(this.rb_HN_DocTHan);
			this.groupBox3.Controls.Add(this.rb_HN_GiaDinh);
			this.groupBox3.Controls.Add(this.ck_HV_DuoiTHPT);
			this.groupBox3.Controls.Add(this.ck_HV_THPT);
			this.groupBox3.Controls.Add(this.ck_HV_CaoDang);
			this.groupBox3.Controls.Add(this.ck_HV_DaiHoc);
			this.groupBox3.Controls.Add(this.ck_HV_SauDH);
			this.groupBox3.Controls.Add(this.label33);
			this.groupBox3.Controls.Add(this.label34);
			this.groupBox3.Controls.Add(this.groupBox7);
			this.groupBox3.Controls.Add(this.label32);
			this.groupBox3.Controls.Add(this.label31);
			this.groupBox3.Controls.Add(this.ck_NN_NghiHuu);
			this.groupBox3.Controls.Add(this.ck_NN_KinhDoanh);
			this.groupBox3.Controls.Add(this.ck_NN_DiLam);
			this.groupBox3.Controls.Add(this.ck_NN_DiHoc);
			this.groupBox3.Controls.Add(this.label30);
			this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
			this.groupBox3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.groupBox3.Location = new System.Drawing.Point(0, 472);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(556, 264);
			this.groupBox3.TabIndex = 9;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Thông tin khác về chủ tài khoản";
			// 
			// txtCoQuan
			// 
			this.txtCoQuan.Location = new System.Drawing.Point(112, 119);
			this.txtCoQuan.Name = "txtCoQuan";
			this.txtCoQuan.Size = new System.Drawing.Size(200, 26);
			this.txtCoQuan.TabIndex = 62;
			this.txtCoQuan.Text = "textBox7";
			// 
			// txtChucVu
			// 
			this.txtChucVu.Location = new System.Drawing.Point(112, 88);
			this.txtChucVu.Name = "txtChucVu";
			this.txtChucVu.Size = new System.Drawing.Size(200, 26);
			this.txtChucVu.TabIndex = 61;
			this.txtChucVu.Text = "textBox6";
			// 
			// txtNganhNghe
			// 
			this.txtNganhNghe.Location = new System.Drawing.Point(112, 56);
			this.txtNganhNghe.Name = "txtNganhNghe";
			this.txtNganhNghe.Size = new System.Drawing.Size(200, 26);
			this.txtNganhNghe.TabIndex = 60;
			this.txtNganhNghe.Text = "textBox5";
			// 
			// rb_HN_Goa
			// 
			this.rb_HN_Goa.Location = new System.Drawing.Point(368, 176);
			this.rb_HN_Goa.Name = "rb_HN_Goa";
			this.rb_HN_Goa.Size = new System.Drawing.Size(96, 24);
			this.rb_HN_Goa.TabIndex = 59;
			this.rb_HN_Goa.Text = "Góa";
			// 
			// rb_HN_LyDi
			// 
			this.rb_HN_LyDi.Location = new System.Drawing.Point(264, 176);
			this.rb_HN_LyDi.Name = "rb_HN_LyDi";
			this.rb_HN_LyDi.Size = new System.Drawing.Size(96, 24);
			this.rb_HN_LyDi.TabIndex = 58;
			this.rb_HN_LyDi.Text = "Ly Dị";
			// 
			// rb_HN_DocTHan
			// 
			this.rb_HN_DocTHan.Location = new System.Drawing.Point(160, 176);
			this.rb_HN_DocTHan.Name = "rb_HN_DocTHan";
			this.rb_HN_DocTHan.Size = new System.Drawing.Size(96, 24);
			this.rb_HN_DocTHan.TabIndex = 57;
			this.rb_HN_DocTHan.Text = "Độc thân";
			// 
			// rb_HN_GiaDinh
			// 
			this.rb_HN_GiaDinh.Location = new System.Drawing.Point(24, 176);
			this.rb_HN_GiaDinh.Name = "rb_HN_GiaDinh";
			this.rb_HN_GiaDinh.Size = new System.Drawing.Size(128, 24);
			this.rb_HN_GiaDinh.TabIndex = 56;
			this.rb_HN_GiaDinh.Text = "Đã lập gia đình";
			// 
			// ck_HV_DuoiTHPT
			// 
			this.ck_HV_DuoiTHPT.Location = new System.Drawing.Point(456, 232);
			this.ck_HV_DuoiTHPT.Name = "ck_HV_DuoiTHPT";
			this.ck_HV_DuoiTHPT.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.ck_HV_DuoiTHPT.Size = new System.Drawing.Size(96, 24);
			this.ck_HV_DuoiTHPT.TabIndex = 55;
			this.ck_HV_DuoiTHPT.Text = "Dưới TH";
			// 
			// ck_HV_THPT
			// 
			this.ck_HV_THPT.Location = new System.Drawing.Point(320, 232);
			this.ck_HV_THPT.Name = "ck_HV_THPT";
			this.ck_HV_THPT.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.ck_HV_THPT.Size = new System.Drawing.Size(136, 24);
			this.ck_HV_THPT.TabIndex = 54;
			this.ck_HV_THPT.Text = "THPT, trung cấp";
			// 
			// ck_HV_CaoDang
			// 
			this.ck_HV_CaoDang.Location = new System.Drawing.Point(224, 232);
			this.ck_HV_CaoDang.Name = "ck_HV_CaoDang";
			this.ck_HV_CaoDang.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.ck_HV_CaoDang.Size = new System.Drawing.Size(96, 24);
			this.ck_HV_CaoDang.TabIndex = 53;
			this.ck_HV_CaoDang.Text = "Cao đẳng";
			// 
			// ck_HV_DaiHoc
			// 
			this.ck_HV_DaiHoc.Location = new System.Drawing.Point(136, 232);
			this.ck_HV_DaiHoc.Name = "ck_HV_DaiHoc";
			this.ck_HV_DaiHoc.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.ck_HV_DaiHoc.Size = new System.Drawing.Size(80, 24);
			this.ck_HV_DaiHoc.TabIndex = 52;
			this.ck_HV_DaiHoc.Text = "Đại học";
			// 
			// ck_HV_SauDH
			// 
			this.ck_HV_SauDH.Location = new System.Drawing.Point(16, 232);
			this.ck_HV_SauDH.Name = "ck_HV_SauDH";
			this.ck_HV_SauDH.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.ck_HV_SauDH.Size = new System.Drawing.Size(112, 24);
			this.ck_HV_SauDH.TabIndex = 51;
			this.ck_HV_SauDH.Text = "Sau đại học";
			// 
			// label33
			// 
			this.label33.Font = new System.Drawing.Font("Tahoma", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label33.Location = new System.Drawing.Point(16, 208);
			this.label33.Name = "label33";
			this.label33.Size = new System.Drawing.Size(128, 23);
			this.label33.TabIndex = 46;
			this.label33.Text = "Học vấn:";
			// 
			// label34
			// 
			this.label34.Font = new System.Drawing.Font("Tahoma", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label34.Location = new System.Drawing.Point(16, 152);
			this.label34.Name = "label34";
			this.label34.Size = new System.Drawing.Size(144, 23);
			this.label34.TabIndex = 45;
			this.label34.Text = "Tình trạng hôn nhân:";
			// 
			// groupBox7
			// 
			this.groupBox7.Controls.Add(this.rb_TN_Tren60);
			this.groupBox7.Controls.Add(this.rb_TN_Tu36);
			this.groupBox7.Controls.Add(this.rb_TN_Tu12);
			this.groupBox7.Controls.Add(this.rb_TN_Duoi12);
			this.groupBox7.Location = new System.Drawing.Point(320, 48);
			this.groupBox7.Name = "groupBox7";
			this.groupBox7.Size = new System.Drawing.Size(232, 100);
			this.groupBox7.TabIndex = 44;
			this.groupBox7.TabStop = false;
			this.groupBox7.Text = "Thu nhập hàng năm";
			// 
			// rb_TN_Tren60
			// 
			this.rb_TN_Tren60.Location = new System.Drawing.Point(128, 64);
			this.rb_TN_Tren60.Name = "rb_TN_Tren60";
			this.rb_TN_Tren60.Size = new System.Drawing.Size(96, 24);
			this.rb_TN_Tren60.TabIndex = 3;
			this.rb_TN_Tren60.Text = "Trên 60tr";
			// 
			// rb_TN_Tu36
			// 
			this.rb_TN_Tu36.Location = new System.Drawing.Point(16, 64);
			this.rb_TN_Tu36.Name = "rb_TN_Tu36";
			this.rb_TN_Tu36.Size = new System.Drawing.Size(96, 24);
			this.rb_TN_Tu36.TabIndex = 2;
			this.rb_TN_Tu36.Text = "36tr - 60tr";
			// 
			// rb_TN_Tu12
			// 
			this.rb_TN_Tu12.Location = new System.Drawing.Point(128, 24);
			this.rb_TN_Tu12.Name = "rb_TN_Tu12";
			this.rb_TN_Tu12.Size = new System.Drawing.Size(96, 24);
			this.rb_TN_Tu12.TabIndex = 1;
			this.rb_TN_Tu12.Text = "12tr - 36tr";
			// 
			// rb_TN_Duoi12
			// 
			this.rb_TN_Duoi12.Location = new System.Drawing.Point(16, 24);
			this.rb_TN_Duoi12.Name = "rb_TN_Duoi12";
			this.rb_TN_Duoi12.Size = new System.Drawing.Size(88, 24);
			this.rb_TN_Duoi12.TabIndex = 0;
			this.rb_TN_Duoi12.Text = "Dưới 12tr";
			// 
			// label32
			// 
			this.label32.Location = new System.Drawing.Point(16, 119);
			this.label32.Name = "label32";
			this.label32.Size = new System.Drawing.Size(96, 23);
			this.label32.TabIndex = 42;
			this.label32.Text = "Tên cơ quan:";
			// 
			// label31
			// 
			this.label31.Location = new System.Drawing.Point(40, 88);
			this.label31.Name = "label31";
			this.label31.Size = new System.Drawing.Size(72, 23);
			this.label31.TabIndex = 40;
			this.label31.Text = "Chức vụ:";
			// 
			// ck_NN_NghiHuu
			// 
			this.ck_NN_NghiHuu.Location = new System.Drawing.Point(392, 24);
			this.ck_NN_NghiHuu.Name = "ck_NN_NghiHuu";
			this.ck_NN_NghiHuu.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.ck_NN_NghiHuu.Size = new System.Drawing.Size(112, 24);
			this.ck_NN_NghiHuu.TabIndex = 21;
			this.ck_NN_NghiHuu.Text = "Nghỉ hưu";
			// 
			// ck_NN_KinhDoanh
			// 
			this.ck_NN_KinhDoanh.Location = new System.Drawing.Point(256, 24);
			this.ck_NN_KinhDoanh.Name = "ck_NN_KinhDoanh";
			this.ck_NN_KinhDoanh.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.ck_NN_KinhDoanh.Size = new System.Drawing.Size(128, 24);
			this.ck_NN_KinhDoanh.TabIndex = 20;
			this.ck_NN_KinhDoanh.Text = "Tự kinh doanh";
			// 
			// ck_NN_DiLam
			// 
			this.ck_NN_DiLam.Location = new System.Drawing.Point(136, 24);
			this.ck_NN_DiLam.Name = "ck_NN_DiLam";
			this.ck_NN_DiLam.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.ck_NN_DiLam.Size = new System.Drawing.Size(112, 24);
			this.ck_NN_DiLam.TabIndex = 19;
			this.ck_NN_DiLam.Text = "Đang đi làm";
			// 
			// ck_NN_DiHoc
			// 
			this.ck_NN_DiHoc.Location = new System.Drawing.Point(16, 24);
			this.ck_NN_DiHoc.Name = "ck_NN_DiHoc";
			this.ck_NN_DiHoc.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.ck_NN_DiHoc.Size = new System.Drawing.Size(112, 24);
			this.ck_NN_DiHoc.TabIndex = 18;
			this.ck_NN_DiHoc.Text = "Đang đi học";
			// 
			// label30
			// 
			this.label30.Location = new System.Drawing.Point(16, 56);
			this.label30.Name = "label30";
			this.label30.Size = new System.Drawing.Size(96, 23);
			this.label30.TabIndex = 38;
			this.label30.Text = "Ngành nghề:";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.dtNgayCap);
			this.groupBox2.Controls.Add(this.dtNgaySinh);
			this.groupBox2.Controls.Add(this.rbNu);
			this.groupBox2.Controls.Add(this.rbNam);
			this.groupBox2.Controls.Add(this.txtHopThu);
			this.groupBox2.Controls.Add(this.label19);
			this.groupBox2.Controls.Add(this.txtDienThoaiDD);
			this.groupBox2.Controls.Add(this.label18);
			this.groupBox2.Controls.Add(this.txtDienThoaiNha);
			this.groupBox2.Controls.Add(this.label17);
			this.groupBox2.Controls.Add(this.txtDiaChiNuocNgoai);
			this.groupBox2.Controls.Add(this.label16);
			this.groupBox2.Controls.Add(this.txtDiaChiCuTru);
			this.groupBox2.Controls.Add(this.label15);
			this.groupBox2.Controls.Add(this.txtDiaChiLienHe);
			this.groupBox2.Controls.Add(this.label14);
			this.groupBox2.Controls.Add(this.txtSo_CMND);
			this.groupBox2.Controls.Add(this.label13);
			this.groupBox2.Controls.Add(this.txtNoiCap_CMND);
			this.groupBox2.Controls.Add(this.label12);
			this.groupBox2.Controls.Add(this.label11);
			this.groupBox2.Controls.Add(this.ck_Khac_CMND);
			this.groupBox2.Controls.Add(this.ck_HoChieu);
			this.groupBox2.Controls.Add(this.ck_CMND);
			this.groupBox2.Controls.Add(this.txtQuocTich);
			this.groupBox2.Controls.Add(this.label9);
			this.groupBox2.Controls.Add(this.label8);
			this.groupBox2.Controls.Add(this.label7);
			this.groupBox2.Controls.Add(this.txtTenVietTat);
			this.groupBox2.Controls.Add(this.txtHoTen);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
			this.groupBox2.Location = new System.Drawing.Point(0, 88);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(556, 384);
			this.groupBox2.TabIndex = 8;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Thông tin về chủ tài khoản";
			// 
			// dtNgayCap
			// 
			this.dtNgayCap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtNgayCap.Location = new System.Drawing.Point(400, 152);
			this.dtNgayCap.Name = "dtNgayCap";
			this.dtNgayCap.Size = new System.Drawing.Size(136, 26);
			this.dtNgayCap.TabIndex = 42;
			// 
			// dtNgaySinh
			// 
			this.dtNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtNgaySinh.Location = new System.Drawing.Point(112, 88);
			this.dtNgaySinh.Name = "dtNgaySinh";
			this.dtNgaySinh.TabIndex = 41;
			// 
			// rbNu
			// 
			this.rbNu.Location = new System.Drawing.Point(464, 24);
			this.rbNu.Name = "rbNu";
			this.rbNu.Size = new System.Drawing.Size(56, 24);
			this.rbNu.TabIndex = 39;
			this.rbNu.Text = "Nữ";
			this.rbNu.CheckedChanged += new System.EventHandler(this.rbNu_CheckedChanged);
			// 
			// rbNam
			// 
			this.rbNam.Location = new System.Drawing.Point(400, 24);
			this.rbNam.Name = "rbNam";
			this.rbNam.Size = new System.Drawing.Size(56, 24);
			this.rbNam.TabIndex = 38;
			this.rbNam.Text = "Nam";
			this.rbNam.CheckedChanged += new System.EventHandler(this.rbNam_CheckedChanged);
			// 
			// txtHopThu
			// 
			this.txtHopThu.Location = new System.Drawing.Point(400, 328);
			this.txtHopThu.Name = "txtHopThu";
			this.txtHopThu.Size = new System.Drawing.Size(136, 26);
			this.txtHopThu.TabIndex = 37;
			this.txtHopThu.Text = "textBox14";
			// 
			// label19
			// 
			this.label19.Location = new System.Drawing.Point(320, 328);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(80, 40);
			this.label19.TabIndex = 36;
			this.label19.Text = "Hộp thư điện tử";
			// 
			// txtDienThoaiDD
			// 
			this.txtDienThoaiDD.Location = new System.Drawing.Point(400, 272);
			this.txtDienThoaiDD.Name = "txtDienThoaiDD";
			this.txtDienThoaiDD.Size = new System.Drawing.Size(136, 26);
			this.txtDienThoaiDD.TabIndex = 35;
			this.txtDienThoaiDD.Text = "textBox13";
			// 
			// label18
			// 
			this.label18.Location = new System.Drawing.Point(320, 272);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(80, 40);
			this.label18.TabIndex = 34;
			this.label18.Text = "Điện thoại di động";
			// 
			// txtDienThoaiNha
			// 
			this.txtDienThoaiNha.Location = new System.Drawing.Point(400, 216);
			this.txtDienThoaiNha.Name = "txtDienThoaiNha";
			this.txtDienThoaiNha.Size = new System.Drawing.Size(136, 26);
			this.txtDienThoaiNha.TabIndex = 33;
			this.txtDienThoaiNha.Text = "textBox12";
			// 
			// label17
			// 
			this.label17.Location = new System.Drawing.Point(320, 216);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(80, 40);
			this.label17.TabIndex = 32;
			this.label17.Text = "Điện thoại nhà riêng";
			// 
			// txtDiaChiNuocNgoai
			// 
			this.txtDiaChiNuocNgoai.AutoSize = false;
			this.txtDiaChiNuocNgoai.Location = new System.Drawing.Point(112, 328);
			this.txtDiaChiNuocNgoai.Multiline = true;
			this.txtDiaChiNuocNgoai.Name = "txtDiaChiNuocNgoai";
			this.txtDiaChiNuocNgoai.Size = new System.Drawing.Size(200, 48);
			this.txtDiaChiNuocNgoai.TabIndex = 31;
			this.txtDiaChiNuocNgoai.Text = "textBox11";
			// 
			// label16
			// 
			this.label16.Location = new System.Drawing.Point(16, 328);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(88, 40);
			this.label16.TabIndex = 30;
			this.label16.Text = "Địa chỉ nước ngoài:";
			// 
			// txtDiaChiCuTru
			// 
			this.txtDiaChiCuTru.AutoSize = false;
			this.txtDiaChiCuTru.Location = new System.Drawing.Point(112, 272);
			this.txtDiaChiCuTru.Multiline = true;
			this.txtDiaChiCuTru.Name = "txtDiaChiCuTru";
			this.txtDiaChiCuTru.Size = new System.Drawing.Size(200, 48);
			this.txtDiaChiCuTru.TabIndex = 29;
			this.txtDiaChiCuTru.Text = "textBox10";
			// 
			// label15
			// 
			this.label15.Location = new System.Drawing.Point(48, 272);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(56, 40);
			this.label15.TabIndex = 28;
			this.label15.Text = "Địa chỉ cư trú:";
			// 
			// txtDiaChiLienHe
			// 
			this.txtDiaChiLienHe.AutoSize = false;
			this.txtDiaChiLienHe.Location = new System.Drawing.Point(112, 216);
			this.txtDiaChiLienHe.Multiline = true;
			this.txtDiaChiLienHe.Name = "txtDiaChiLienHe";
			this.txtDiaChiLienHe.Size = new System.Drawing.Size(200, 48);
			this.txtDiaChiLienHe.TabIndex = 27;
			this.txtDiaChiLienHe.Text = "textBox9";
			// 
			// label14
			// 
			this.label14.Location = new System.Drawing.Point(48, 216);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(56, 40);
			this.label14.TabIndex = 26;
			this.label14.Text = "Địa chỉ liên hệ:";
			// 
			// txtSo_CMND
			// 
			this.txtSo_CMND.Location = new System.Drawing.Point(112, 184);
			this.txtSo_CMND.Name = "txtSo_CMND";
			this.txtSo_CMND.Size = new System.Drawing.Size(200, 26);
			this.txtSo_CMND.TabIndex = 25;
			this.txtSo_CMND.Text = "textBox8";
			// 
			// label13
			// 
			this.label13.Location = new System.Drawing.Point(72, 184);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(32, 23);
			this.label13.TabIndex = 24;
			this.label13.Text = "Số:";
			// 
			// txtNoiCap_CMND
			// 
			this.txtNoiCap_CMND.Location = new System.Drawing.Point(400, 184);
			this.txtNoiCap_CMND.Name = "txtNoiCap_CMND";
			this.txtNoiCap_CMND.Size = new System.Drawing.Size(136, 26);
			this.txtNoiCap_CMND.TabIndex = 23;
			this.txtNoiCap_CMND.Text = "textBox7";
			// 
			// label12
			// 
			this.label12.Location = new System.Drawing.Point(320, 184);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(64, 23);
			this.label12.TabIndex = 22;
			this.label12.Text = "Nơi cấp:";
			// 
			// label11
			// 
			this.label11.Location = new System.Drawing.Point(320, 152);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(80, 23);
			this.label11.TabIndex = 20;
			this.label11.Text = "Ngày cấp:";
			// 
			// ck_Khac_CMND
			// 
			this.ck_Khac_CMND.Location = new System.Drawing.Point(176, 152);
			this.ck_Khac_CMND.Name = "ck_Khac_CMND";
			this.ck_Khac_CMND.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.ck_Khac_CMND.Size = new System.Drawing.Size(72, 24);
			this.ck_Khac_CMND.TabIndex = 19;
			this.ck_Khac_CMND.Text = "Khác";
			// 
			// ck_HoChieu
			// 
			this.ck_HoChieu.Location = new System.Drawing.Point(88, 152);
			this.ck_HoChieu.Name = "ck_HoChieu";
			this.ck_HoChieu.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.ck_HoChieu.Size = new System.Drawing.Size(88, 24);
			this.ck_HoChieu.TabIndex = 18;
			this.ck_HoChieu.Text = "Hộ chiếu";
			// 
			// ck_CMND
			// 
			this.ck_CMND.Location = new System.Drawing.Point(8, 152);
			this.ck_CMND.Name = "ck_CMND";
			this.ck_CMND.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.ck_CMND.Size = new System.Drawing.Size(72, 24);
			this.ck_CMND.TabIndex = 17;
			this.ck_CMND.Text = "CMND";
			// 
			// txtQuocTich
			// 
			this.txtQuocTich.Location = new System.Drawing.Point(112, 120);
			this.txtQuocTich.Name = "txtQuocTich";
			this.txtQuocTich.Size = new System.Drawing.Size(200, 26);
			this.txtQuocTich.TabIndex = 13;
			this.txtQuocTich.Text = "textBox5";
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(8, 120);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(80, 23);
			this.label9.TabIndex = 12;
			this.label9.Text = "Quốc tịch:";
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(8, 88);
			this.label8.Name = "label8";
			this.label8.TabIndex = 10;
			this.label8.Text = "Ngày sinh:";
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(320, 24);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(72, 23);
			this.label7.TabIndex = 4;
			this.label7.Text = "Giới tính:";
			// 
			// txtTenVietTat
			// 
			this.txtTenVietTat.Location = new System.Drawing.Point(112, 56);
			this.txtTenVietTat.Name = "txtTenVietTat";
			this.txtTenVietTat.Size = new System.Drawing.Size(200, 26);
			this.txtTenVietTat.TabIndex = 3;
			this.txtTenVietTat.Text = "textBox3";
			// 
			// txtHoTen
			// 
			this.txtHoTen.Location = new System.Drawing.Point(112, 24);
			this.txtHoTen.Name = "txtHoTen";
			this.txtHoTen.Size = new System.Drawing.Size(200, 26);
			this.txtHoTen.TabIndex = 2;
			this.txtHoTen.Text = "";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(8, 56);
			this.label6.Name = "label6";
			this.label6.TabIndex = 1;
			this.label6.Text = "Tên viết tắt:";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(8, 24);
			this.label5.Name = "label5";
			this.label5.TabIndex = 0;
			this.label5.Text = "Họ tên:";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.ck_LT_Khac);
			this.groupBox1.Controls.Add(this.ck_LT_DoLa);
			this.groupBox1.Controls.Add(this.ck_LT_VietNam);
			this.groupBox1.Controls.Add(this.ck_LTK_Khac);
			this.groupBox1.Controls.Add(this.ck_LTK_DongChuTK);
			this.groupBox1.Controls.Add(this.ck_LTK_GiaoDich);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
			this.groupBox1.Location = new System.Drawing.Point(0, 0);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(556, 88);
			this.groupBox1.TabIndex = 7;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Thông tin về tài khoản";
			// 
			// ck_LT_Khac
			// 
			this.ck_LT_Khac.Location = new System.Drawing.Point(472, 56);
			this.ck_LT_Khac.Name = "ck_LT_Khac";
			this.ck_LT_Khac.Size = new System.Drawing.Size(64, 24);
			this.ck_LT_Khac.TabIndex = 7;
			this.ck_LT_Khac.Text = "Khác";
			// 
			// ck_LT_DoLa
			// 
			this.ck_LT_DoLa.Location = new System.Drawing.Point(312, 56);
			this.ck_LT_DoLa.Name = "ck_LT_DoLa";
			this.ck_LT_DoLa.Size = new System.Drawing.Size(160, 24);
			this.ck_LT_DoLa.TabIndex = 6;
			this.ck_LT_DoLa.Text = "Đồng đô-la Mỹ";
			// 
			// ck_LT_VietNam
			// 
			this.ck_LT_VietNam.Location = new System.Drawing.Point(136, 56);
			this.ck_LT_VietNam.Name = "ck_LT_VietNam";
			this.ck_LT_VietNam.Size = new System.Drawing.Size(184, 24);
			this.ck_LT_VietNam.TabIndex = 5;
			this.ck_LT_VietNam.Text = "Đồng Việt Nam";
			// 
			// ck_LTK_Khac
			// 
			this.ck_LTK_Khac.Location = new System.Drawing.Point(472, 24);
			this.ck_LTK_Khac.Name = "ck_LTK_Khac";
			this.ck_LTK_Khac.Size = new System.Drawing.Size(64, 24);
			this.ck_LTK_Khac.TabIndex = 4;
			this.ck_LTK_Khac.Text = "Khác";
			// 
			// ck_LTK_DongChuTK
			// 
			this.ck_LTK_DongChuTK.Location = new System.Drawing.Point(312, 24);
			this.ck_LTK_DongChuTK.Name = "ck_LTK_DongChuTK";
			this.ck_LTK_DongChuTK.Size = new System.Drawing.Size(160, 24);
			this.ck_LTK_DongChuTK.TabIndex = 3;
			this.ck_LTK_DongChuTK.Text = "Đồng chủ tài khoản";
			// 
			// ck_LTK_GiaoDich
			// 
			this.ck_LTK_GiaoDich.Location = new System.Drawing.Point(136, 24);
			this.ck_LTK_GiaoDich.Name = "ck_LTK_GiaoDich";
			this.ck_LTK_GiaoDich.Size = new System.Drawing.Size(184, 24);
			this.ck_LTK_GiaoDich.TabIndex = 2;
			this.ck_LTK_GiaoDich.Text = "Giao dịch chứng khoán";
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Tahoma", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label4.Location = new System.Drawing.Point(8, 56);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(128, 23);
			this.label4.TabIndex = 1;
			this.label4.Text = "Loại tiền:";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Tahoma", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label3.Location = new System.Drawing.Point(8, 24);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(128, 23);
			this.label3.TabIndex = 0;
			this.label3.Text = "Loại tài khoản:";
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.panel3.Controls.Add(this.btLamLai);
			this.panel3.Controls.Add(this.btSuaKH);
			this.panel3.Controls.Add(this.label1);
			this.panel3.Controls.Add(this.btThemKH);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel3.Location = new System.Drawing.Point(0, 0);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(573, 48);
			this.panel3.TabIndex = 0;
			// 
			// btLamLai
			// 
			this.btLamLai.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.btLamLai.BackColor = System.Drawing.SystemColors.ControlLight;
			this.btLamLai.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btLamLai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btLamLai.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btLamLai.ImageIndex = 32;
			this.btLamLai.ImageList = this.imageList1;
			this.btLamLai.Location = new System.Drawing.Point(481, 8);
			this.btLamLai.Name = "btLamLai";
			this.btLamLai.Size = new System.Drawing.Size(88, 32);
			this.btLamLai.TabIndex = 4;
			this.btLamLai.Text = "Làm lại";
			this.btLamLai.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btLamLai.Click += new System.EventHandler(this.btLamLai_Click);
			// 
			// btSuaKH
			// 
			this.btSuaKH.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.btSuaKH.BackColor = System.Drawing.SystemColors.ControlLight;
			this.btSuaKH.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btSuaKH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btSuaKH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btSuaKH.ImageIndex = 30;
			this.btSuaKH.ImageList = this.imageList1;
			this.btSuaKH.Location = new System.Drawing.Point(401, 8);
			this.btSuaKH.Name = "btSuaKH";
			this.btSuaKH.Size = new System.Drawing.Size(72, 32);
			this.btSuaKH.TabIndex = 3;
			this.btSuaKH.Text = "Sửa";
			this.btSuaKH.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btSuaKH.Click += new System.EventHandler(this.btSuaKH_Click);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.Location = new System.Drawing.Point(8, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(184, 23);
			this.label1.TabIndex = 2;
			this.label1.Text = "Nhập thông tin";
			// 
			// btThemKH
			// 
			this.btThemKH.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.btThemKH.BackColor = System.Drawing.SystemColors.ControlLight;
			this.btThemKH.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btThemKH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btThemKH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btThemKH.ImageIndex = 31;
			this.btThemKH.ImageList = this.imageList1;
			this.btThemKH.Location = new System.Drawing.Point(313, 8);
			this.btThemKH.Name = "btThemKH";
			this.btThemKH.Size = new System.Drawing.Size(80, 32);
			this.btThemKH.TabIndex = 1;
			this.btThemKH.Text = "Thêm";
			this.btThemKH.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btThemKH.Click += new System.EventHandler(this.btThemKH_Click);
			// 
			// splitter1
			// 
			this.splitter1.Location = new System.Drawing.Point(400, 0);
			this.splitter1.Name = "splitter1";
			this.splitter1.Size = new System.Drawing.Size(3, 613);
			this.splitter1.TabIndex = 1;
			this.splitter1.TabStop = false;
			// 
			// panel1
			// 
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.panel6);
			this.panel1.Controls.Add(this.panel4);
			this.panel1.Controls.Add(this.textBox1);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(400, 613);
			this.panel1.TabIndex = 0;
			// 
			// panel6
			// 
			this.panel6.AutoScroll = true;
			this.panel6.Controls.Add(this.groupBox6);
			this.panel6.Controls.Add(this.groupBox5);
			this.panel6.Controls.Add(this.groupBox4);
			this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel6.Location = new System.Drawing.Point(0, 146);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(398, 465);
			this.panel6.TabIndex = 3;
			// 
			// groupBox6
			// 
			this.groupBox6.Controls.Add(this.panel17);
			this.groupBox6.Dock = System.Windows.Forms.DockStyle.Top;
			this.groupBox6.Location = new System.Drawing.Point(0, 320);
			this.groupBox6.Name = "groupBox6";
			this.groupBox6.Size = new System.Drawing.Size(381, 160);
			this.groupBox6.TabIndex = 2;
			this.groupBox6.TabStop = false;
			this.groupBox6.Text = "Ảnh vân tay sống";
			// 
			// panel17
			// 
			this.panel17.AutoScroll = true;
			this.panel17.Controls.Add(this.panel18);
			this.panel17.Controls.Add(this.panel19);
			this.panel17.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel17.Location = new System.Drawing.Point(3, 22);
			this.panel17.Name = "panel17";
			this.panel17.Size = new System.Drawing.Size(375, 135);
			this.panel17.TabIndex = 0;
			// 
			// panel18
			// 
			this.panel18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel18.Controls.Add(this.picVanTaySong2);
			this.panel18.Controls.Add(this.label28);
			this.panel18.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel18.DockPadding.All = 2;
			this.panel18.Location = new System.Drawing.Point(125, 0);
			this.panel18.Name = "panel18";
			this.panel18.Size = new System.Drawing.Size(125, 135);
			this.panel18.TabIndex = 5;
			// 
			// picVanTaySong2
			// 
			this.picVanTaySong2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picVanTaySong2.BackgroundImage")));
			this.picVanTaySong2.Cursor = System.Windows.Forms.Cursors.SizeAll;
			this.picVanTaySong2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.picVanTaySong2.Location = new System.Drawing.Point(2, 2);
			this.picVanTaySong2.Name = "picVanTaySong2";
			this.picVanTaySong2.Size = new System.Drawing.Size(119, 106);
			this.picVanTaySong2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picVanTaySong2.TabIndex = 2;
			this.picVanTaySong2.TabStop = false;
			// 
			// label28
			// 
			this.label28.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.label28.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.label28.Location = new System.Drawing.Point(2, 108);
			this.label28.Name = "label28";
			this.label28.Size = new System.Drawing.Size(119, 23);
			this.label28.TabIndex = 0;
			this.label28.Text = "Trỏ phải";
			this.label28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel19
			// 
			this.panel19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel19.Controls.Add(this.picVanTaySong1);
			this.panel19.Controls.Add(this.label29);
			this.panel19.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel19.DockPadding.All = 2;
			this.panel19.Location = new System.Drawing.Point(0, 0);
			this.panel19.Name = "panel19";
			this.panel19.Size = new System.Drawing.Size(125, 135);
			this.panel19.TabIndex = 4;
			// 
			// picVanTaySong1
			// 
			this.picVanTaySong1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picVanTaySong1.BackgroundImage")));
			this.picVanTaySong1.Cursor = System.Windows.Forms.Cursors.SizeAll;
			this.picVanTaySong1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.picVanTaySong1.Location = new System.Drawing.Point(2, 2);
			this.picVanTaySong1.Name = "picVanTaySong1";
			this.picVanTaySong1.Size = new System.Drawing.Size(119, 106);
			this.picVanTaySong1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picVanTaySong1.TabIndex = 2;
			this.picVanTaySong1.TabStop = false;
			// 
			// label29
			// 
			this.label29.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.label29.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.label29.Location = new System.Drawing.Point(2, 108);
			this.label29.Name = "label29";
			this.label29.Size = new System.Drawing.Size(119, 23);
			this.label29.TabIndex = 0;
			this.label29.Text = "Trỏ trái";
			this.label29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// groupBox5
			// 
			this.groupBox5.Controls.Add(this.panel12);
			this.groupBox5.Dock = System.Windows.Forms.DockStyle.Top;
			this.groupBox5.Location = new System.Drawing.Point(0, 160);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Size = new System.Drawing.Size(381, 160);
			this.groupBox5.TabIndex = 1;
			this.groupBox5.TabStop = false;
			this.groupBox5.Text = "Ảnh CMTND mới";
			// 
			// panel12
			// 
			this.panel12.AutoScroll = true;
			this.panel12.Controls.Add(this.panel13);
			this.panel12.Controls.Add(this.panel14);
			this.panel12.Controls.Add(this.panel15);
			this.panel12.Controls.Add(this.panel16);
			this.panel12.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel12.Location = new System.Drawing.Point(3, 22);
			this.panel12.Name = "panel12";
			this.panel12.Size = new System.Drawing.Size(375, 135);
			this.panel12.TabIndex = 0;
			// 
			// panel13
			// 
			this.panel13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel13.Controls.Add(this.picCMNDCu_VanTay2);
			this.panel13.Controls.Add(this.label24);
			this.panel13.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel13.DockPadding.All = 2;
			this.panel13.Location = new System.Drawing.Point(471, 0);
			this.panel13.Name = "panel13";
			this.panel13.Size = new System.Drawing.Size(125, 118);
			this.panel13.TabIndex = 5;
			// 
			// picCMNDCu_VanTay2
			// 
			this.picCMNDCu_VanTay2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picCMNDCu_VanTay2.BackgroundImage")));
			this.picCMNDCu_VanTay2.Cursor = System.Windows.Forms.Cursors.SizeAll;
			this.picCMNDCu_VanTay2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.picCMNDCu_VanTay2.Location = new System.Drawing.Point(2, 2);
			this.picCMNDCu_VanTay2.Name = "picCMNDCu_VanTay2";
			this.picCMNDCu_VanTay2.Size = new System.Drawing.Size(119, 89);
			this.picCMNDCu_VanTay2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picCMNDCu_VanTay2.TabIndex = 2;
			this.picCMNDCu_VanTay2.TabStop = false;
			this.picCMNDCu_VanTay2.Click += new System.EventHandler(this.picCMNDCu_VanTay2_Click);
			// 
			// label24
			// 
			this.label24.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.label24.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.label24.Location = new System.Drawing.Point(2, 91);
			this.label24.Name = "label24";
			this.label24.Size = new System.Drawing.Size(119, 23);
			this.label24.TabIndex = 0;
			this.label24.Text = "Trỏ phải";
			this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel14
			// 
			this.panel14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel14.Controls.Add(this.picCMNDCu_VanTay1);
			this.panel14.Controls.Add(this.label25);
			this.panel14.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel14.DockPadding.All = 2;
			this.panel14.Location = new System.Drawing.Point(346, 0);
			this.panel14.Name = "panel14";
			this.panel14.Size = new System.Drawing.Size(125, 118);
			this.panel14.TabIndex = 4;
			// 
			// picCMNDCu_VanTay1
			// 
			this.picCMNDCu_VanTay1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picCMNDCu_VanTay1.BackgroundImage")));
			this.picCMNDCu_VanTay1.Cursor = System.Windows.Forms.Cursors.SizeAll;
			this.picCMNDCu_VanTay1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.picCMNDCu_VanTay1.Location = new System.Drawing.Point(2, 2);
			this.picCMNDCu_VanTay1.Name = "picCMNDCu_VanTay1";
			this.picCMNDCu_VanTay1.Size = new System.Drawing.Size(119, 89);
			this.picCMNDCu_VanTay1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picCMNDCu_VanTay1.TabIndex = 2;
			this.picCMNDCu_VanTay1.TabStop = false;
			this.picCMNDCu_VanTay1.Click += new System.EventHandler(this.picCMNDCu_VanTay1_Click);
			// 
			// label25
			// 
			this.label25.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.label25.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.label25.Location = new System.Drawing.Point(2, 91);
			this.label25.Name = "label25";
			this.label25.Size = new System.Drawing.Size(119, 23);
			this.label25.TabIndex = 0;
			this.label25.Text = "Trỏ trái";
			this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel15
			// 
			this.panel15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel15.Controls.Add(this.picCMNDMoi_MatSau);
			this.panel15.Controls.Add(this.label26);
			this.panel15.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel15.DockPadding.All = 2;
			this.panel15.Location = new System.Drawing.Point(173, 0);
			this.panel15.Name = "panel15";
			this.panel15.Size = new System.Drawing.Size(173, 118);
			this.panel15.TabIndex = 3;
			// 
			// picCMNDMoi_MatSau
			// 
			this.picCMNDMoi_MatSau.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picCMNDMoi_MatSau.BackgroundImage")));
			this.picCMNDMoi_MatSau.Cursor = System.Windows.Forms.Cursors.SizeAll;
			this.picCMNDMoi_MatSau.Dock = System.Windows.Forms.DockStyle.Fill;
			this.picCMNDMoi_MatSau.Location = new System.Drawing.Point(2, 2);
			this.picCMNDMoi_MatSau.Name = "picCMNDMoi_MatSau";
			this.picCMNDMoi_MatSau.Size = new System.Drawing.Size(167, 89);
			this.picCMNDMoi_MatSau.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picCMNDMoi_MatSau.TabIndex = 2;
			this.picCMNDMoi_MatSau.TabStop = false;
			this.picCMNDMoi_MatSau.Click += new System.EventHandler(this.picCMNDMoi_MatSau_Click);
			// 
			// label26
			// 
			this.label26.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.label26.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.label26.Location = new System.Drawing.Point(2, 91);
			this.label26.Name = "label26";
			this.label26.Size = new System.Drawing.Size(167, 23);
			this.label26.TabIndex = 0;
			this.label26.Text = "Ảnh sau";
			this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel16
			// 
			this.panel16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel16.Controls.Add(this.picCMNDMoi_MatTruoc);
			this.panel16.Controls.Add(this.label27);
			this.panel16.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel16.DockPadding.All = 2;
			this.panel16.Location = new System.Drawing.Point(0, 0);
			this.panel16.Name = "panel16";
			this.panel16.Size = new System.Drawing.Size(173, 118);
			this.panel16.TabIndex = 2;
			// 
			// picCMNDMoi_MatTruoc
			// 
			this.picCMNDMoi_MatTruoc.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picCMNDMoi_MatTruoc.BackgroundImage")));
			this.picCMNDMoi_MatTruoc.Cursor = System.Windows.Forms.Cursors.SizeAll;
			this.picCMNDMoi_MatTruoc.Dock = System.Windows.Forms.DockStyle.Fill;
			this.picCMNDMoi_MatTruoc.Location = new System.Drawing.Point(2, 2);
			this.picCMNDMoi_MatTruoc.Name = "picCMNDMoi_MatTruoc";
			this.picCMNDMoi_MatTruoc.Size = new System.Drawing.Size(167, 89);
			this.picCMNDMoi_MatTruoc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picCMNDMoi_MatTruoc.TabIndex = 2;
			this.picCMNDMoi_MatTruoc.TabStop = false;
			this.picCMNDMoi_MatTruoc.Click += new System.EventHandler(this.picCMNDMoi_MatTruoc_Click);
			// 
			// label27
			// 
			this.label27.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.label27.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.label27.Location = new System.Drawing.Point(2, 91);
			this.label27.Name = "label27";
			this.label27.Size = new System.Drawing.Size(167, 23);
			this.label27.TabIndex = 0;
			this.label27.Text = "Ảnh trước";
			this.label27.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.panel8);
			this.groupBox4.Dock = System.Windows.Forms.DockStyle.Top;
			this.groupBox4.Location = new System.Drawing.Point(0, 0);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(381, 160);
			this.groupBox4.TabIndex = 0;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Ảnh CMTND cũ";
			// 
			// panel8
			// 
			this.panel8.AutoScroll = true;
			this.panel8.Controls.Add(this.panel10);
			this.panel8.Controls.Add(this.panel11);
			this.panel8.Controls.Add(this.panel9);
			this.panel8.Controls.Add(this.panel7);
			this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel8.Location = new System.Drawing.Point(3, 22);
			this.panel8.Name = "panel8";
			this.panel8.Size = new System.Drawing.Size(375, 135);
			this.panel8.TabIndex = 0;
			// 
			// panel10
			// 
			this.panel10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel10.Controls.Add(this.picCMNDMoi_VanTay2);
			this.panel10.Controls.Add(this.label22);
			this.panel10.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel10.DockPadding.All = 2;
			this.panel10.Location = new System.Drawing.Point(471, 0);
			this.panel10.Name = "panel10";
			this.panel10.Size = new System.Drawing.Size(125, 118);
			this.panel10.TabIndex = 5;
			// 
			// picCMNDMoi_VanTay2
			// 
			this.picCMNDMoi_VanTay2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picCMNDMoi_VanTay2.BackgroundImage")));
			this.picCMNDMoi_VanTay2.Cursor = System.Windows.Forms.Cursors.SizeAll;
			this.picCMNDMoi_VanTay2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.picCMNDMoi_VanTay2.Location = new System.Drawing.Point(2, 2);
			this.picCMNDMoi_VanTay2.Name = "picCMNDMoi_VanTay2";
			this.picCMNDMoi_VanTay2.Size = new System.Drawing.Size(119, 89);
			this.picCMNDMoi_VanTay2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picCMNDMoi_VanTay2.TabIndex = 2;
			this.picCMNDMoi_VanTay2.TabStop = false;
			this.picCMNDMoi_VanTay2.Click += new System.EventHandler(this.picCMNDMoi_VanTay2_Click);
			// 
			// label22
			// 
			this.label22.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.label22.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.label22.Location = new System.Drawing.Point(2, 91);
			this.label22.Name = "label22";
			this.label22.Size = new System.Drawing.Size(119, 23);
			this.label22.TabIndex = 0;
			this.label22.Text = "Trỏ phải";
			this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel11
			// 
			this.panel11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel11.Controls.Add(this.picCMNDMoi_VanTay1);
			this.panel11.Controls.Add(this.label23);
			this.panel11.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel11.DockPadding.All = 2;
			this.panel11.Location = new System.Drawing.Point(346, 0);
			this.panel11.Name = "panel11";
			this.panel11.Size = new System.Drawing.Size(125, 118);
			this.panel11.TabIndex = 4;
			// 
			// picCMNDMoi_VanTay1
			// 
			this.picCMNDMoi_VanTay1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picCMNDMoi_VanTay1.BackgroundImage")));
			this.picCMNDMoi_VanTay1.Cursor = System.Windows.Forms.Cursors.SizeAll;
			this.picCMNDMoi_VanTay1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.picCMNDMoi_VanTay1.Location = new System.Drawing.Point(2, 2);
			this.picCMNDMoi_VanTay1.Name = "picCMNDMoi_VanTay1";
			this.picCMNDMoi_VanTay1.Size = new System.Drawing.Size(119, 89);
			this.picCMNDMoi_VanTay1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picCMNDMoi_VanTay1.TabIndex = 2;
			this.picCMNDMoi_VanTay1.TabStop = false;
			this.picCMNDMoi_VanTay1.Click += new System.EventHandler(this.picCMNDMoi_VanTay1_Click);
			// 
			// label23
			// 
			this.label23.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.label23.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.label23.Location = new System.Drawing.Point(2, 91);
			this.label23.Name = "label23";
			this.label23.Size = new System.Drawing.Size(119, 23);
			this.label23.TabIndex = 0;
			this.label23.Text = "Trỏ trái";
			this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel9
			// 
			this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel9.Controls.Add(this.picCMNDCu_MatSau);
			this.panel9.Controls.Add(this.label21);
			this.panel9.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel9.DockPadding.All = 2;
			this.panel9.Location = new System.Drawing.Point(173, 0);
			this.panel9.Name = "panel9";
			this.panel9.Size = new System.Drawing.Size(173, 118);
			this.panel9.TabIndex = 3;
			// 
			// picCMNDCu_MatSau
			// 
			this.picCMNDCu_MatSau.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picCMNDCu_MatSau.BackgroundImage")));
			this.picCMNDCu_MatSau.Cursor = System.Windows.Forms.Cursors.SizeAll;
			this.picCMNDCu_MatSau.Dock = System.Windows.Forms.DockStyle.Fill;
			this.picCMNDCu_MatSau.Location = new System.Drawing.Point(2, 2);
			this.picCMNDCu_MatSau.Name = "picCMNDCu_MatSau";
			this.picCMNDCu_MatSau.Size = new System.Drawing.Size(167, 89);
			this.picCMNDCu_MatSau.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picCMNDCu_MatSau.TabIndex = 2;
			this.picCMNDCu_MatSau.TabStop = false;
			this.picCMNDCu_MatSau.Click += new System.EventHandler(this.picCMNDCu_MatSau_Click);
			// 
			// label21
			// 
			this.label21.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.label21.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.label21.Location = new System.Drawing.Point(2, 91);
			this.label21.Name = "label21";
			this.label21.Size = new System.Drawing.Size(167, 23);
			this.label21.TabIndex = 0;
			this.label21.Text = "Ảnh sau";
			this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel7
			// 
			this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel7.Controls.Add(this.picCMNDCu_MatTruoc);
			this.panel7.Controls.Add(this.label20);
			this.panel7.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel7.DockPadding.All = 2;
			this.panel7.Location = new System.Drawing.Point(0, 0);
			this.panel7.Name = "panel7";
			this.panel7.Size = new System.Drawing.Size(173, 118);
			this.panel7.TabIndex = 2;
			// 
			// picCMNDCu_MatTruoc
			// 
			this.picCMNDCu_MatTruoc.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picCMNDCu_MatTruoc.BackgroundImage")));
			this.picCMNDCu_MatTruoc.Cursor = System.Windows.Forms.Cursors.SizeAll;
			this.picCMNDCu_MatTruoc.Dock = System.Windows.Forms.DockStyle.Fill;
			this.picCMNDCu_MatTruoc.Location = new System.Drawing.Point(2, 2);
			this.picCMNDCu_MatTruoc.Name = "picCMNDCu_MatTruoc";
			this.picCMNDCu_MatTruoc.Size = new System.Drawing.Size(167, 89);
			this.picCMNDCu_MatTruoc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picCMNDCu_MatTruoc.TabIndex = 2;
			this.picCMNDCu_MatTruoc.TabStop = false;
			this.picCMNDCu_MatTruoc.Click += new System.EventHandler(this.picCMNDCu_MatTruoc_Click);
			// 
			// label20
			// 
			this.label20.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.label20.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.label20.Location = new System.Drawing.Point(2, 91);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(167, 23);
			this.label20.TabIndex = 0;
			this.label20.Text = "Ảnh trước";
			this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel4
			// 
			this.panel4.BackColor = System.Drawing.SystemColors.Info;
			this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel4.Location = new System.Drawing.Point(0, 58);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(398, 88);
			this.panel4.TabIndex = 2;
			// 
			// textBox1
			// 
			this.textBox1.Dock = System.Windows.Forms.DockStyle.Top;
			this.textBox1.Location = new System.Drawing.Point(0, 32);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(398, 26);
			this.textBox1.TabIndex = 1;
			this.textBox1.Text = "textBox1";
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.label2.Dock = System.Windows.Forms.DockStyle.Top;
			this.label2.Location = new System.Drawing.Point(0, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(398, 32);
			this.label2.TabIndex = 0;
			this.label2.Text = "Tìm kiếm nhanh";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.panel21);
			this.tabPage2.Controls.Add(this.splitter2);
			this.tabPage2.Controls.Add(this.panel20);
			this.tabPage2.Location = new System.Drawing.Point(4, 27);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Size = new System.Drawing.Size(976, 613);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Kiểm tra thông tin ";
			this.tabPage2.Visible = false;
			// 
			// panel21
			// 
			this.panel21.Controls.Add(this.dtgKhachHang);
			this.panel21.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel21.Location = new System.Drawing.Point(0, 248);
			this.panel21.Name = "panel21";
			this.panel21.Size = new System.Drawing.Size(976, 365);
			this.panel21.TabIndex = 2;
			// 
			// dtgKhachHang
			// 
			this.dtgKhachHang.AllowDrop = true;
			this.dtgKhachHang.ContextMenu = this.contextMenuGrid;
			this.dtgKhachHang.DataMember = "";
			this.dtgKhachHang.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dtgKhachHang.FlatMode = true;
			this.dtgKhachHang.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dtgKhachHang.Location = new System.Drawing.Point(0, 0);
			this.dtgKhachHang.Name = "dtgKhachHang";
			this.dtgKhachHang.SelectionBackColor = System.Drawing.Color.LightGoldenrodYellow;
			this.dtgKhachHang.Size = new System.Drawing.Size(976, 365);
			this.dtgKhachHang.TabIndex = 0;
			this.dtgKhachHang.Click += new System.EventHandler(this.dtgKhachHang_Click);
			this.dtgKhachHang.CurrentCellChanged += new System.EventHandler(this.dtgKhachHang_CurrentCellChanged);
			// 
			// contextMenuGrid
			// 
			this.contextMenuGrid.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																							this.menuItemChiTiet,
																							this.menuItemThem,
																							this.menuItemSua,
																							this.menuItemXoa,
																							this.menuItem3,
																							this.menuItemLamMoi});
			// 
			// menuItemChiTiet
			// 
			this.menuItemChiTiet.Index = 0;
			this.menuItemChiTiet.Shortcut = System.Windows.Forms.Shortcut.F10;
			this.menuItemChiTiet.Text = "Xem chi tiết";
			this.menuItemChiTiet.Click += new System.EventHandler(this.menuItemChiTiet_Click);
			// 
			// menuItemThem
			// 
			this.menuItemThem.Index = 1;
			this.menuItemThem.Shortcut = System.Windows.Forms.Shortcut.Ins;
			this.menuItemThem.Text = "Thêm khách hàng";
			this.menuItemThem.Click += new System.EventHandler(this.menuItemThem_Click);
			// 
			// menuItemSua
			// 
			this.menuItemSua.Index = 2;
			this.menuItemSua.Text = "Sửa thông tin";
			this.menuItemSua.Click += new System.EventHandler(this.menuItemSua_Click);
			// 
			// menuItemXoa
			// 
			this.menuItemXoa.Index = 3;
			this.menuItemXoa.Shortcut = System.Windows.Forms.Shortcut.Del;
			this.menuItemXoa.Text = "Xóa khách hàng";
			this.menuItemXoa.Click += new System.EventHandler(this.menuItemXoa_Click);
			// 
			// menuItem3
			// 
			this.menuItem3.Index = 4;
			this.menuItem3.Text = "-";
			// 
			// menuItemLamMoi
			// 
			this.menuItemLamMoi.Index = 5;
			this.menuItemLamMoi.Text = "Làm mới dữ liệu";
			this.menuItemLamMoi.Click += new System.EventHandler(this.menuItemLamMoi_Click);
			// 
			// splitter2
			// 
			this.splitter2.Dock = System.Windows.Forms.DockStyle.Top;
			this.splitter2.Location = new System.Drawing.Point(0, 240);
			this.splitter2.MinExtra = 1;
			this.splitter2.MinSize = 1;
			this.splitter2.Name = "splitter2";
			this.splitter2.Size = new System.Drawing.Size(976, 8);
			this.splitter2.TabIndex = 1;
			this.splitter2.TabStop = false;
			// 
			// panel20
			// 
			this.panel20.Controls.Add(this.panel23);
			this.panel20.Controls.Add(this.splitter3);
			this.panel20.Controls.Add(this.panel22);
			this.panel20.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel20.Location = new System.Drawing.Point(0, 0);
			this.panel20.Name = "panel20";
			this.panel20.Size = new System.Drawing.Size(976, 240);
			this.panel20.TabIndex = 0;
			// 
			// panel23
			// 
			this.panel23.AutoScroll = true;
			this.panel23.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel23.Controls.Add(this.groupBox10);
			this.panel23.Controls.Add(this.groupBox9);
			this.panel23.Controls.Add(this.groupBox8);
			this.panel23.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel23.Location = new System.Drawing.Point(283, 0);
			this.panel23.Name = "panel23";
			this.panel23.Size = new System.Drawing.Size(693, 240);
			this.panel23.TabIndex = 2;
			// 
			// groupBox10
			// 
			this.groupBox10.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.groupBox10.Controls.Add(this.panel36);
			this.groupBox10.Controls.Add(this.panel39);
			this.groupBox10.Dock = System.Windows.Forms.DockStyle.Left;
			this.groupBox10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.groupBox10.Location = new System.Drawing.Point(704, 0);
			this.groupBox10.Name = "groupBox10";
			this.groupBox10.Size = new System.Drawing.Size(180, 221);
			this.groupBox10.TabIndex = 2;
			this.groupBox10.TabStop = false;
			this.groupBox10.Text = "Ảnh vân tay sống";
			// 
			// panel36
			// 
			this.panel36.AutoScroll = true;
			this.panel36.Controls.Add(this.panel38);
			this.panel36.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel36.Location = new System.Drawing.Point(3, 122);
			this.panel36.Name = "panel36";
			this.panel36.Size = new System.Drawing.Size(174, 96);
			this.panel36.TabIndex = 1;
			// 
			// panel38
			// 
			this.panel38.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel38.Controls.Add(this.picVanTaySong2SS);
			this.panel38.Controls.Add(this.label46);
			this.panel38.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel38.DockPadding.All = 2;
			this.panel38.Location = new System.Drawing.Point(0, 0);
			this.panel38.Name = "panel38";
			this.panel38.Size = new System.Drawing.Size(173, 96);
			this.panel38.TabIndex = 4;
			// 
			// picVanTaySong2SS
			// 
			this.picVanTaySong2SS.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picVanTaySong2SS.BackgroundImage")));
			this.picVanTaySong2SS.Cursor = System.Windows.Forms.Cursors.SizeAll;
			this.picVanTaySong2SS.Dock = System.Windows.Forms.DockStyle.Fill;
			this.picVanTaySong2SS.Location = new System.Drawing.Point(2, 2);
			this.picVanTaySong2SS.Name = "picVanTaySong2SS";
			this.picVanTaySong2SS.Size = new System.Drawing.Size(167, 67);
			this.picVanTaySong2SS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picVanTaySong2SS.TabIndex = 2;
			this.picVanTaySong2SS.TabStop = false;
			// 
			// label46
			// 
			this.label46.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.label46.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.label46.Location = new System.Drawing.Point(2, 69);
			this.label46.Name = "label46";
			this.label46.Size = new System.Drawing.Size(167, 23);
			this.label46.TabIndex = 0;
			this.label46.Text = "Vân tay";
			this.label46.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel39
			// 
			this.panel39.AutoScroll = true;
			this.panel39.Controls.Add(this.panel41);
			this.panel39.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel39.Location = new System.Drawing.Point(3, 22);
			this.panel39.Name = "panel39";
			this.panel39.Size = new System.Drawing.Size(174, 100);
			this.panel39.TabIndex = 0;
			// 
			// panel41
			// 
			this.panel41.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel41.Controls.Add(this.picVanTaySong1SS);
			this.panel41.Controls.Add(this.label48);
			this.panel41.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel41.DockPadding.All = 2;
			this.panel41.Location = new System.Drawing.Point(0, 0);
			this.panel41.Name = "panel41";
			this.panel41.Size = new System.Drawing.Size(173, 100);
			this.panel41.TabIndex = 4;
			// 
			// picVanTaySong1SS
			// 
			this.picVanTaySong1SS.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picVanTaySong1SS.BackgroundImage")));
			this.picVanTaySong1SS.Cursor = System.Windows.Forms.Cursors.SizeAll;
			this.picVanTaySong1SS.Dock = System.Windows.Forms.DockStyle.Fill;
			this.picVanTaySong1SS.Location = new System.Drawing.Point(2, 2);
			this.picVanTaySong1SS.Name = "picVanTaySong1SS";
			this.picVanTaySong1SS.Size = new System.Drawing.Size(167, 71);
			this.picVanTaySong1SS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picVanTaySong1SS.TabIndex = 2;
			this.picVanTaySong1SS.TabStop = false;
			// 
			// label48
			// 
			this.label48.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.label48.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.label48.Location = new System.Drawing.Point(2, 73);
			this.label48.Name = "label48";
			this.label48.Size = new System.Drawing.Size(167, 23);
			this.label48.TabIndex = 0;
			this.label48.Text = "Vân tay";
			this.label48.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// groupBox9
			// 
			this.groupBox9.BackColor = System.Drawing.Color.LightGray;
			this.groupBox9.Controls.Add(this.panel30);
			this.groupBox9.Controls.Add(this.panel33);
			this.groupBox9.Dock = System.Windows.Forms.DockStyle.Left;
			this.groupBox9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.groupBox9.Location = new System.Drawing.Point(352, 0);
			this.groupBox9.Name = "groupBox9";
			this.groupBox9.Size = new System.Drawing.Size(352, 221);
			this.groupBox9.TabIndex = 1;
			this.groupBox9.TabStop = false;
			this.groupBox9.Text = "Ảnh CMND mới";
			// 
			// panel30
			// 
			this.panel30.AutoScroll = true;
			this.panel30.Controls.Add(this.panel31);
			this.panel30.Controls.Add(this.panel32);
			this.panel30.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel30.Location = new System.Drawing.Point(3, 122);
			this.panel30.Name = "panel30";
			this.panel30.Size = new System.Drawing.Size(346, 96);
			this.panel30.TabIndex = 1;
			// 
			// panel31
			// 
			this.panel31.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel31.Controls.Add(this.picCMNDMoi_VanTay2SS);
			this.panel31.Controls.Add(this.label41);
			this.panel31.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel31.DockPadding.All = 2;
			this.panel31.Location = new System.Drawing.Point(173, 0);
			this.panel31.Name = "panel31";
			this.panel31.Size = new System.Drawing.Size(173, 96);
			this.panel31.TabIndex = 5;
			// 
			// picCMNDMoi_VanTay2SS
			// 
			this.picCMNDMoi_VanTay2SS.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picCMNDMoi_VanTay2SS.BackgroundImage")));
			this.picCMNDMoi_VanTay2SS.Cursor = System.Windows.Forms.Cursors.SizeAll;
			this.picCMNDMoi_VanTay2SS.Dock = System.Windows.Forms.DockStyle.Fill;
			this.picCMNDMoi_VanTay2SS.Location = new System.Drawing.Point(2, 2);
			this.picCMNDMoi_VanTay2SS.Name = "picCMNDMoi_VanTay2SS";
			this.picCMNDMoi_VanTay2SS.Size = new System.Drawing.Size(167, 67);
			this.picCMNDMoi_VanTay2SS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picCMNDMoi_VanTay2SS.TabIndex = 2;
			this.picCMNDMoi_VanTay2SS.TabStop = false;
			// 
			// label41
			// 
			this.label41.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.label41.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.label41.Location = new System.Drawing.Point(2, 69);
			this.label41.Name = "label41";
			this.label41.Size = new System.Drawing.Size(167, 23);
			this.label41.TabIndex = 0;
			this.label41.Text = "Vân tay";
			this.label41.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel32
			// 
			this.panel32.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel32.Controls.Add(this.picCMNDMoi_VanTay1SS);
			this.panel32.Controls.Add(this.label42);
			this.panel32.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel32.DockPadding.All = 2;
			this.panel32.Location = new System.Drawing.Point(0, 0);
			this.panel32.Name = "panel32";
			this.panel32.Size = new System.Drawing.Size(173, 96);
			this.panel32.TabIndex = 4;
			// 
			// picCMNDMoi_VanTay1SS
			// 
			this.picCMNDMoi_VanTay1SS.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picCMNDMoi_VanTay1SS.BackgroundImage")));
			this.picCMNDMoi_VanTay1SS.Cursor = System.Windows.Forms.Cursors.SizeAll;
			this.picCMNDMoi_VanTay1SS.Dock = System.Windows.Forms.DockStyle.Fill;
			this.picCMNDMoi_VanTay1SS.Location = new System.Drawing.Point(2, 2);
			this.picCMNDMoi_VanTay1SS.Name = "picCMNDMoi_VanTay1SS";
			this.picCMNDMoi_VanTay1SS.Size = new System.Drawing.Size(167, 67);
			this.picCMNDMoi_VanTay1SS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picCMNDMoi_VanTay1SS.TabIndex = 2;
			this.picCMNDMoi_VanTay1SS.TabStop = false;
			// 
			// label42
			// 
			this.label42.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.label42.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.label42.Location = new System.Drawing.Point(2, 69);
			this.label42.Name = "label42";
			this.label42.Size = new System.Drawing.Size(167, 23);
			this.label42.TabIndex = 0;
			this.label42.Text = "Vân tay";
			this.label42.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel33
			// 
			this.panel33.AutoScroll = true;
			this.panel33.Controls.Add(this.panel34);
			this.panel33.Controls.Add(this.panel35);
			this.panel33.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel33.Location = new System.Drawing.Point(3, 22);
			this.panel33.Name = "panel33";
			this.panel33.Size = new System.Drawing.Size(346, 100);
			this.panel33.TabIndex = 0;
			// 
			// panel34
			// 
			this.panel34.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel34.Controls.Add(this.picCMNDMoi_MatTruocSS);
			this.panel34.Controls.Add(this.label43);
			this.panel34.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel34.DockPadding.All = 2;
			this.panel34.Location = new System.Drawing.Point(173, 0);
			this.panel34.Name = "panel34";
			this.panel34.Size = new System.Drawing.Size(173, 100);
			this.panel34.TabIndex = 5;
			// 
			// picCMNDMoi_MatTruocSS
			// 
			this.picCMNDMoi_MatTruocSS.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picCMNDMoi_MatTruocSS.BackgroundImage")));
			this.picCMNDMoi_MatTruocSS.Cursor = System.Windows.Forms.Cursors.SizeAll;
			this.picCMNDMoi_MatTruocSS.Dock = System.Windows.Forms.DockStyle.Fill;
			this.picCMNDMoi_MatTruocSS.Location = new System.Drawing.Point(2, 2);
			this.picCMNDMoi_MatTruocSS.Name = "picCMNDMoi_MatTruocSS";
			this.picCMNDMoi_MatTruocSS.Size = new System.Drawing.Size(167, 71);
			this.picCMNDMoi_MatTruocSS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picCMNDMoi_MatTruocSS.TabIndex = 2;
			this.picCMNDMoi_MatTruocSS.TabStop = false;
			// 
			// label43
			// 
			this.label43.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.label43.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.label43.Location = new System.Drawing.Point(2, 73);
			this.label43.Name = "label43";
			this.label43.Size = new System.Drawing.Size(167, 23);
			this.label43.TabIndex = 0;
			this.label43.Text = "Ảnh trước";
			this.label43.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel35
			// 
			this.panel35.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel35.Controls.Add(this.picCMNDMoi_MatSauSS);
			this.panel35.Controls.Add(this.label44);
			this.panel35.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel35.DockPadding.All = 2;
			this.panel35.Location = new System.Drawing.Point(0, 0);
			this.panel35.Name = "panel35";
			this.panel35.Size = new System.Drawing.Size(173, 100);
			this.panel35.TabIndex = 4;
			// 
			// picCMNDMoi_MatSauSS
			// 
			this.picCMNDMoi_MatSauSS.BackColor = System.Drawing.Color.LightGray;
			this.picCMNDMoi_MatSauSS.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picCMNDMoi_MatSauSS.BackgroundImage")));
			this.picCMNDMoi_MatSauSS.Cursor = System.Windows.Forms.Cursors.SizeAll;
			this.picCMNDMoi_MatSauSS.Dock = System.Windows.Forms.DockStyle.Fill;
			this.picCMNDMoi_MatSauSS.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.picCMNDMoi_MatSauSS.Location = new System.Drawing.Point(2, 2);
			this.picCMNDMoi_MatSauSS.Name = "picCMNDMoi_MatSauSS";
			this.picCMNDMoi_MatSauSS.Size = new System.Drawing.Size(167, 71);
			this.picCMNDMoi_MatSauSS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picCMNDMoi_MatSauSS.TabIndex = 2;
			this.picCMNDMoi_MatSauSS.TabStop = false;
			// 
			// label44
			// 
			this.label44.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.label44.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.label44.Location = new System.Drawing.Point(2, 73);
			this.label44.Name = "label44";
			this.label44.Size = new System.Drawing.Size(167, 23);
			this.label44.TabIndex = 0;
			this.label44.Text = "Ảnh sau";
			this.label44.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// groupBox8
			// 
			this.groupBox8.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.groupBox8.Controls.Add(this.panel25);
			this.groupBox8.Controls.Add(this.panel24);
			this.groupBox8.Dock = System.Windows.Forms.DockStyle.Left;
			this.groupBox8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.groupBox8.Location = new System.Drawing.Point(0, 0);
			this.groupBox8.Name = "groupBox8";
			this.groupBox8.Size = new System.Drawing.Size(352, 221);
			this.groupBox8.TabIndex = 0;
			this.groupBox8.TabStop = false;
			this.groupBox8.Text = "Ảnh CMND cũ";
			// 
			// panel25
			// 
			this.panel25.AutoScroll = true;
			this.panel25.Controls.Add(this.panel29);
			this.panel25.Controls.Add(this.panel28);
			this.panel25.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel25.Location = new System.Drawing.Point(3, 122);
			this.panel25.Name = "panel25";
			this.panel25.Size = new System.Drawing.Size(346, 96);
			this.panel25.TabIndex = 1;
			// 
			// panel29
			// 
			this.panel29.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel29.Controls.Add(this.picCMNDCu_VanTay2SS);
			this.panel29.Controls.Add(this.label40);
			this.panel29.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel29.DockPadding.All = 2;
			this.panel29.Location = new System.Drawing.Point(173, 0);
			this.panel29.Name = "panel29";
			this.panel29.Size = new System.Drawing.Size(173, 96);
			this.panel29.TabIndex = 5;
			// 
			// picCMNDCu_VanTay2SS
			// 
			this.picCMNDCu_VanTay2SS.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picCMNDCu_VanTay2SS.BackgroundImage")));
			this.picCMNDCu_VanTay2SS.Cursor = System.Windows.Forms.Cursors.SizeAll;
			this.picCMNDCu_VanTay2SS.Dock = System.Windows.Forms.DockStyle.Fill;
			this.picCMNDCu_VanTay2SS.Location = new System.Drawing.Point(2, 2);
			this.picCMNDCu_VanTay2SS.Name = "picCMNDCu_VanTay2SS";
			this.picCMNDCu_VanTay2SS.Size = new System.Drawing.Size(167, 67);
			this.picCMNDCu_VanTay2SS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picCMNDCu_VanTay2SS.TabIndex = 2;
			this.picCMNDCu_VanTay2SS.TabStop = false;
			// 
			// label40
			// 
			this.label40.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.label40.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.label40.Location = new System.Drawing.Point(2, 69);
			this.label40.Name = "label40";
			this.label40.Size = new System.Drawing.Size(167, 23);
			this.label40.TabIndex = 0;
			this.label40.Text = "Vân tay";
			this.label40.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel28
			// 
			this.panel28.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel28.Controls.Add(this.picCMNDCu_VanTay1SS);
			this.panel28.Controls.Add(this.label39);
			this.panel28.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel28.DockPadding.All = 2;
			this.panel28.Location = new System.Drawing.Point(0, 0);
			this.panel28.Name = "panel28";
			this.panel28.Size = new System.Drawing.Size(173, 96);
			this.panel28.TabIndex = 4;
			// 
			// picCMNDCu_VanTay1SS
			// 
			this.picCMNDCu_VanTay1SS.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picCMNDCu_VanTay1SS.BackgroundImage")));
			this.picCMNDCu_VanTay1SS.Cursor = System.Windows.Forms.Cursors.SizeAll;
			this.picCMNDCu_VanTay1SS.Dock = System.Windows.Forms.DockStyle.Fill;
			this.picCMNDCu_VanTay1SS.Location = new System.Drawing.Point(2, 2);
			this.picCMNDCu_VanTay1SS.Name = "picCMNDCu_VanTay1SS";
			this.picCMNDCu_VanTay1SS.Size = new System.Drawing.Size(167, 67);
			this.picCMNDCu_VanTay1SS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picCMNDCu_VanTay1SS.TabIndex = 2;
			this.picCMNDCu_VanTay1SS.TabStop = false;
			// 
			// label39
			// 
			this.label39.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.label39.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.label39.Location = new System.Drawing.Point(2, 69);
			this.label39.Name = "label39";
			this.label39.Size = new System.Drawing.Size(167, 23);
			this.label39.TabIndex = 0;
			this.label39.Text = "Vân tay";
			this.label39.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel24
			// 
			this.panel24.AutoScroll = true;
			this.panel24.Controls.Add(this.panel27);
			this.panel24.Controls.Add(this.panel26);
			this.panel24.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel24.Location = new System.Drawing.Point(3, 22);
			this.panel24.Name = "panel24";
			this.panel24.Size = new System.Drawing.Size(346, 100);
			this.panel24.TabIndex = 0;
			// 
			// panel27
			// 
			this.panel27.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel27.Controls.Add(this.picCMNDCu_MatTruocSS);
			this.panel27.Controls.Add(this.label38);
			this.panel27.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel27.DockPadding.All = 2;
			this.panel27.Location = new System.Drawing.Point(173, 0);
			this.panel27.Name = "panel27";
			this.panel27.Size = new System.Drawing.Size(173, 100);
			this.panel27.TabIndex = 5;
			// 
			// picCMNDCu_MatTruocSS
			// 
			this.picCMNDCu_MatTruocSS.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.picCMNDCu_MatTruocSS.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picCMNDCu_MatTruocSS.BackgroundImage")));
			this.picCMNDCu_MatTruocSS.Cursor = System.Windows.Forms.Cursors.SizeAll;
			this.picCMNDCu_MatTruocSS.Dock = System.Windows.Forms.DockStyle.Fill;
			this.picCMNDCu_MatTruocSS.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.picCMNDCu_MatTruocSS.Location = new System.Drawing.Point(2, 2);
			this.picCMNDCu_MatTruocSS.Name = "picCMNDCu_MatTruocSS";
			this.picCMNDCu_MatTruocSS.Size = new System.Drawing.Size(167, 71);
			this.picCMNDCu_MatTruocSS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picCMNDCu_MatTruocSS.TabIndex = 2;
			this.picCMNDCu_MatTruocSS.TabStop = false;
			// 
			// label38
			// 
			this.label38.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.label38.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.label38.Location = new System.Drawing.Point(2, 73);
			this.label38.Name = "label38";
			this.label38.Size = new System.Drawing.Size(167, 23);
			this.label38.TabIndex = 0;
			this.label38.Text = "Ảnh trước";
			this.label38.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel26
			// 
			this.panel26.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel26.Controls.Add(this.picCMNDCu_MatSauSS);
			this.panel26.Controls.Add(this.label37);
			this.panel26.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel26.DockPadding.All = 2;
			this.panel26.Location = new System.Drawing.Point(0, 0);
			this.panel26.Name = "panel26";
			this.panel26.Size = new System.Drawing.Size(173, 100);
			this.panel26.TabIndex = 4;
			// 
			// picCMNDCu_MatSauSS
			// 
			this.picCMNDCu_MatSauSS.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picCMNDCu_MatSauSS.BackgroundImage")));
			this.picCMNDCu_MatSauSS.Cursor = System.Windows.Forms.Cursors.SizeAll;
			this.picCMNDCu_MatSauSS.Dock = System.Windows.Forms.DockStyle.Fill;
			this.picCMNDCu_MatSauSS.Location = new System.Drawing.Point(2, 2);
			this.picCMNDCu_MatSauSS.Name = "picCMNDCu_MatSauSS";
			this.picCMNDCu_MatSauSS.Size = new System.Drawing.Size(167, 71);
			this.picCMNDCu_MatSauSS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picCMNDCu_MatSauSS.TabIndex = 2;
			this.picCMNDCu_MatSauSS.TabStop = false;
			// 
			// label37
			// 
			this.label37.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.label37.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.label37.Location = new System.Drawing.Point(2, 73);
			this.label37.Name = "label37";
			this.label37.Size = new System.Drawing.Size(167, 23);
			this.label37.TabIndex = 0;
			this.label37.Text = "Ảnh sau";
			this.label37.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// splitter3
			// 
			this.splitter3.Location = new System.Drawing.Point(280, 0);
			this.splitter3.Name = "splitter3";
			this.splitter3.Size = new System.Drawing.Size(3, 240);
			this.splitter3.TabIndex = 1;
			this.splitter3.TabStop = false;
			// 
			// panel22
			// 
			this.panel22.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel22.Controls.Add(this.btnInDanhSach);
			this.panel22.Controls.Add(this.btnTimKiem);
			this.panel22.Controls.Add(this.label47);
			this.panel22.Controls.Add(this.txt_TK_SoCMND);
			this.panel22.Controls.Add(this.label45);
			this.panel22.Controls.Add(this.txt_TK_SoTaiKhoan);
			this.panel22.Controls.Add(this.label36);
			this.panel22.Controls.Add(this.txt_TK_HoTen);
			this.panel22.Controls.Add(this.label35);
			this.panel22.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel22.Location = new System.Drawing.Point(0, 0);
			this.panel22.Name = "panel22";
			this.panel22.Size = new System.Drawing.Size(280, 240);
			this.panel22.TabIndex = 0;
			// 
			// btnTimKiem
			// 
			this.btnTimKiem.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.btnTimKiem.BackColor = System.Drawing.SystemColors.ControlLight;
			this.btnTimKiem.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnTimKiem.ImageIndex = 31;
			this.btnTimKiem.ImageList = this.imageList1;
			this.btnTimKiem.Location = new System.Drawing.Point(96, 152);
			this.btnTimKiem.Name = "btnTimKiem";
			this.btnTimKiem.Size = new System.Drawing.Size(128, 32);
			this.btnTimKiem.TabIndex = 9;
			this.btnTimKiem.Text = "Tìm kiếm";
			this.btnTimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
			// 
			// label47
			// 
			this.label47.Location = new System.Drawing.Point(8, 104);
			this.label47.Name = "label47";
			this.label47.Size = new System.Drawing.Size(72, 23);
			this.label47.TabIndex = 6;
			this.label47.Text = "Số CMND";
			this.label47.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txt_TK_SoCMND
			// 
			this.txt_TK_SoCMND.Location = new System.Drawing.Point(95, 104);
			this.txt_TK_SoCMND.Name = "txt_TK_SoCMND";
			this.txt_TK_SoCMND.Size = new System.Drawing.Size(176, 26);
			this.txt_TK_SoCMND.TabIndex = 5;
			this.txt_TK_SoCMND.Text = "";
			// 
			// label45
			// 
			this.label45.Location = new System.Drawing.Point(8, 72);
			this.label45.Name = "label45";
			this.label45.Size = new System.Drawing.Size(72, 23);
			this.label45.TabIndex = 4;
			this.label45.Text = "Số TK";
			this.label45.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txt_TK_SoTaiKhoan
			// 
			this.txt_TK_SoTaiKhoan.Location = new System.Drawing.Point(96, 72);
			this.txt_TK_SoTaiKhoan.Name = "txt_TK_SoTaiKhoan";
			this.txt_TK_SoTaiKhoan.Size = new System.Drawing.Size(176, 26);
			this.txt_TK_SoTaiKhoan.TabIndex = 3;
			this.txt_TK_SoTaiKhoan.Text = "";
			// 
			// label36
			// 
			this.label36.Location = new System.Drawing.Point(8, 40);
			this.label36.Name = "label36";
			this.label36.Size = new System.Drawing.Size(72, 23);
			this.label36.TabIndex = 2;
			this.label36.Text = "Họ tên";
			this.label36.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txt_TK_HoTen
			// 
			this.txt_TK_HoTen.Location = new System.Drawing.Point(96, 40);
			this.txt_TK_HoTen.Name = "txt_TK_HoTen";
			this.txt_TK_HoTen.Size = new System.Drawing.Size(176, 26);
			this.txt_TK_HoTen.TabIndex = 1;
			this.txt_TK_HoTen.Text = "";
			// 
			// label35
			// 
			this.label35.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.label35.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label35.Dock = System.Windows.Forms.DockStyle.Top;
			this.label35.Location = new System.Drawing.Point(0, 0);
			this.label35.Name = "label35";
			this.label35.Size = new System.Drawing.Size(278, 32);
			this.label35.TabIndex = 0;
			this.label35.Text = "Tìm kiếm khách hàng";
			this.label35.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// tabPage3
			// 
			this.tabPage3.Location = new System.Drawing.Point(4, 27);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Size = new System.Drawing.Size(976, 613);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "Báo cáo ";
			this.tabPage3.Visible = false;
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// lbThongBao
			// 
			this.lbThongBao.AutoSize = true;
			this.lbThongBao.Location = new System.Drawing.Point(528, 16);
			this.lbThongBao.Name = "lbThongBao";
			this.lbThongBao.Size = new System.Drawing.Size(0, 22);
			this.lbThongBao.TabIndex = 3;
			// 
			// btnInDanhSach
			// 
			this.btnInDanhSach.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.btnInDanhSach.BackColor = System.Drawing.SystemColors.ControlLight;
			this.btnInDanhSach.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnInDanhSach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnInDanhSach.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnInDanhSach.ImageIndex = 35;
			this.btnInDanhSach.ImageList = this.imageList1;
			this.btnInDanhSach.Location = new System.Drawing.Point(96, 192);
			this.btnInDanhSach.Name = "btnInDanhSach";
			this.btnInDanhSach.Size = new System.Drawing.Size(128, 32);
			this.btnInDanhSach.TabIndex = 10;
			this.btnInDanhSach.Text = "In danh sách";
			this.btnInDanhSach.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnInDanhSach.Click += new System.EventHandler(this.btnInDanhSach_Click);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(7, 19);
			this.ClientSize = new System.Drawing.Size(984, 721);
			this.Controls.Add(this.lbThongBao);
			this.Controls.Add(this.tabControl);
			this.Controls.Add(this.statusBar1);
			this.Controls.Add(this.toolBar1);
			this.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Form1";
			this.Text = "Form1";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Closing += new System.ComponentModel.CancelEventHandler(this.Form1_Closing);
			this.Load += new System.EventHandler(this.Form1_Load);
			this.tabControl.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel5.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.groupBox7.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel6.ResumeLayout(false);
			this.groupBox6.ResumeLayout(false);
			this.panel17.ResumeLayout(false);
			this.panel18.ResumeLayout(false);
			this.panel19.ResumeLayout(false);
			this.groupBox5.ResumeLayout(false);
			this.panel12.ResumeLayout(false);
			this.panel13.ResumeLayout(false);
			this.panel14.ResumeLayout(false);
			this.panel15.ResumeLayout(false);
			this.panel16.ResumeLayout(false);
			this.groupBox4.ResumeLayout(false);
			this.panel8.ResumeLayout(false);
			this.panel10.ResumeLayout(false);
			this.panel11.ResumeLayout(false);
			this.panel9.ResumeLayout(false);
			this.panel7.ResumeLayout(false);
			this.tabPage2.ResumeLayout(false);
			this.panel21.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dtgKhachHang)).EndInit();
			this.panel20.ResumeLayout(false);
			this.panel23.ResumeLayout(false);
			this.groupBox10.ResumeLayout(false);
			this.panel36.ResumeLayout(false);
			this.panel38.ResumeLayout(false);
			this.panel39.ResumeLayout(false);
			this.panel41.ResumeLayout(false);
			this.groupBox9.ResumeLayout(false);
			this.panel30.ResumeLayout(false);
			this.panel31.ResumeLayout(false);
			this.panel32.ResumeLayout(false);
			this.panel33.ResumeLayout(false);
			this.panel34.ResumeLayout(false);
			this.panel35.ResumeLayout(false);
			this.groupBox8.ResumeLayout(false);
			this.panel25.ResumeLayout(false);
			this.panel29.ResumeLayout(false);
			this.panel28.ResumeLayout(false);
			this.panel24.ResumeLayout(false);
			this.panel27.ResumeLayout(false);
			this.panel26.ResumeLayout(false);
			this.panel22.ResumeLayout(false);
			this.ResumeLayout(false);

		} 		#endregion  		/// <summary> 		/// The main entry point for the application. 		/// </summary> 		[STAThread] 		static void Main()  		{ 			Application.Run(new Form1()); 		}

		private void statusBar1_PanelClick(object sender, System.Windows.Forms.StatusBarPanelClickEventArgs e)
		{
		
		}

		private void ZoomImage(object sender, System.EventArgs e)
		{
			PictureBox pic = (PictureBox)sender;
			System.Drawing.Image picture = pic.Image;
			frmZoomImage frmZoom = new frmZoomImage();
			frmZoom.ShowImg(picture);
			frmZoom.ShowDialog();
		}

		private void Form1_Load(object sender, System.EventArgs e)
		{
			//MessageBox.Show("OKKK");
			//			this.pictureBox1.Click+=new EventHandler(ZoomImage);
			//			this.pictureBox2.Click+=new EventHandler(ZoomImage);
			//			this.pictureBox3.Click+=new EventHandler(ZoomImage); 			//			this.pictureBox4.Click+=new EventHandler(ZoomImage); 			//			this.pictureBox5.Click+=new EventHandler(ZoomImage); 			//			this.pictureBox6.Click+=new EventHandler(ZoomImage); 			//			this.pictureBox7.Click+=new EventHandler(ZoomImage); 			//			this.pictureBox8.Click+=new EventHandler(ZoomImage); 			//			this.pictureBox9.Click+=new EventHandler(ZoomImage); 			//			this.pictureBox10.Click+=new EventHandler(ZoomImage); 			//			this.pictureBox11.Click+=new EventHandler(ZoomImage); 			//			this.pictureBox12.Click+=new EventHandler(ZoomImage);
			//			this.pictureBox13.Click+=new EventHandler(ZoomImage);
			//			this.pictureBox14.Click+=new EventHandler(ZoomImage); 			//			this.pictureBox15.Click+=new EventHandler(ZoomImage); 			//			this.pictureBox16.Click+=new EventHandler(ZoomImage); 			//			this.pictureBox17.Click+=new EventHandler(ZoomImage); 			//			this.pictureBox18.Click+=new EventHandler(ZoomImage); 			//			this.pictureBox22.Click+=new EventHandler(ZoomImage); 			//			this.pictureBox20.Click+=new EventHandler(ZoomImage);	 			dtgKhachHang.ContextMenu = contextMenuGrid; 			//dtgKhachHang.Ed 			ResetControl();			 			LoadFormData();												 		}  		 		clsBusPersonal bus = new clsBusPersonal(); 		private void LoadFormData() 		{			 			SetMessage("",false); 			//string strConn = "Provider=SQLOLEDB.1;Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=HRM_CHECKER;Data Source=QUYDA-PC;Use Procedure for Prepare=1;Auto Translate=True;Packet Size=4096;Workstation ID=QUYDA-PC;Use Encryption for Data=False;Tag with column collation when possible=False"; 			//string strConn = "Server=QUYDA-PC;Database=HRM_CHECKER;Trusted_Connection=True"; 			//SqlConnection conn = new SqlConnection(strConn);			 			//SqlDataReader reader =  SqlHelper.ExecuteReader(conn,CommandType.Text,"Select * from tblKhachHang"); 			//DataSet ds = SqlHelper.ExecuteDataset(conn,CommandType.Text,"Select * from tblKhachHang"); 			dtgKhachHang.DataSource = null; 			DataSet ds = bus.LoadPersonal(); 			if(ds!=null && ds.Tables[0].Rows.Count > 0) 			{ 				 				//dtgKhachHang.DataSource = AutoNumberedTable(ds.Tables[0]); 				DataColumn AutoNumberColumn = new DataColumn();
				AutoNumberColumn.ColumnName="STT";
				AutoNumberColumn.DataType = typeof(int);
				AutoNumberColumn.AutoIncrement = true;
				AutoNumberColumn.AutoIncrementSeed = 1;		
				AutoNumberColumn.AutoIncrementStep = 1;
				ds.Tables[0].Columns.Add(AutoNumberColumn);			 				if(ds.Tables[0].Rows.Count>0) 				{ 					int j = 1;
					for(int i=0;i<ds.Tables[0].Rows.Count;i++)
					{				
						ds.Tables[0].Rows[i]["STT"] = j;
						//ResultTable.Rows[i][30] = false;
						j++;
					}					 				} 				dtgKhachHang.DataSource = ds.Tables[0]; 				dtgKhachHang.TableStyles.Clear(); 				//dtgKhachHang.SetDataBinding(AutoNumberedTable(ds.Tables[0]),"Customer"); 				//dtgKhachHang.DataMember = "MaKhachHang";				 				if (! dtgKhachHang.TableStyles.Contains ("Style_Person"))
				{				
					DataGridTableStyle dbgStyle = new DataGridTableStyle ();
					dbgStyle.MappingName = ds.Tables[0].TableName;
					
					dbgStyle.RowHeadersVisible = false;
					dbgStyle.HeaderBackColor = Color.LightSteelBlue;
					dbgStyle.AllowSorting = false;
					dbgStyle.HeaderBackColor = Color.FromArgb (8, 36,107);					
					dbgStyle.RowHeadersVisible = false;
					dbgStyle.HeaderForeColor = Color.White;
					dbgStyle.HeaderFont = new System.Drawing.Font ( "Microsoft Sans Serif", 9F,
						System.Drawing.FontStyle.Bold,
						System.Drawing.GraphicsUnit.Point, ((System.Byte) ( 0)));
					dbgStyle.GridLineColor = Color.DarkGray;
					dbgStyle.PreferredRowHeight = 22;
					dtgKhachHang.BackgroundColor = Color.White;

					DataGridTextBoxColumn aCol1 = new DataGridTextBoxColumn();
					DataGridTextBoxColumn aCol2 = new DataGridTextBoxColumn();
					DataGridTextBoxColumn aCol3 = new DataGridTextBoxColumn();
					DataGridBoolColumn aCol4 = new DataGridBoolColumn(); 					DataGridTextBoxColumn aCol5 = new DataGridTextBoxColumn(); 					DataGridTextBoxColumn aCol6 = new DataGridTextBoxColumn(); 					DataGridTextBoxColumn aCol7 = new DataGridTextBoxColumn(); 					DataGridTextBoxColumn aCol8 = new DataGridTextBoxColumn(); 					//DataGridBoolColumn aCol8 = new DataGridBoolColumn(); 					//
					// Hide column 1 by setting its width to 0.
					//
					aCol1.MappingName = "MaKhachHang";
					aCol1.Width = 0;
					//
					// Set column 2's caption, width and disable editing.			//					
					aCol2.MappingName = "HoTen";
					aCol2.HeaderText = "Họ tên";
					aCol2.Width = 165;
					aCol2.Alignment = HorizontalAlignment.Left;
					aCol2.TextBox.Enabled = false;
					//
					// Set column 3 and 4's caption, width and enable editing.
					// Since these values are optional set their Null values.
					//
					aCol3.MappingName = "NgaySinh";
					aCol3.HeaderText = "Ngày sinh";
					aCol3.Width = 150;
					aCol3.Alignment = HorizontalAlignment.Center;
					aCol3.NullText = "";
					aCol3.TextBox.Enabled = false;
					aCol3.Format = "dd-MM-yyyy";

					aCol4.MappingName = "GioiTinh";
					aCol4.HeaderText = "Giới tính";
					aCol4.Width = 80;
					aCol4.Alignment = HorizontalAlignment.Center;
					//aCol4.NullText = "";
					//aCol4.TextBox.Enabled = false;			

					aCol5.MappingName = "CMND";
					aCol5.HeaderText = "Số CMT";
					aCol5.Width = 150;
					aCol5.Alignment = HorizontalAlignment.Left;
					aCol5.NullText = "";
					aCol5.TextBox.Enabled = false;			

					aCol6.MappingName = "DiaChiLienHe";
					aCol6.HeaderText = "Địa chỉ liên hệ";
					aCol6.Width = 200;
					aCol6.Alignment = HorizontalAlignment.Left;
					aCol6.NullText = "";
					aCol6.TextBox.Enabled = false;			

					aCol7.MappingName = "DienThoaiDiDong";
					aCol7.HeaderText = "Điện thoại";
					aCol7.Width = 170;
					aCol7.Alignment = HorizontalAlignment.Left;
					aCol7.NullText = "";
					aCol7.TextBox.Enabled = false;	
					//aCol4.Format = "#0.00";
					aCol8.MappingName = "STT";
					aCol8.HeaderText = "STT";
					aCol8.Width = 50;
					aCol8.Alignment = HorizontalAlignment.Center;
					aCol8.NullText = "";
					aCol8.TextBox.Enabled = false;					

					//					aCol8.MappingName = "TT";
					//					aCol8.HeaderText = "Chọn";
					//					aCol8.Width = 80;
					//					aCol8.Alignment = HorizontalAlignment.Center;
					//					aCol8.NullValue = false;
					//					aCol8.AllowNull = false;
					//					aCol8.ReadOnly = false;
					//aCol8.ReadOnly = false;

					dbgStyle.GridColumnStyles.Add(aCol8);
					dbgStyle.GridColumnStyles.Add(aCol1);					
					dbgStyle.GridColumnStyles.Add(aCol2);
					dbgStyle.GridColumnStyles.Add(aCol3);
					dbgStyle.GridColumnStyles.Add(aCol4);					
					dbgStyle.GridColumnStyles.Add(aCol5);
					dbgStyle.GridColumnStyles.Add(aCol6);
					dbgStyle.GridColumnStyles.Add(aCol7);
					
					dtgKhachHang.TableStyles.Add (dbgStyle);			 				} 			} 			else 			{ 				SetMessage("Có lỗi trong quá trình truy vấn dữ liệu!",true); 			}			 		}

		private DataTable AutoNumberedTable(DataTable SourceTable)
		{

			DataTable ResultTable = new DataTable();
			ResultTable = SourceTable.Copy();
			DataColumn AutoNumberColumn = new DataColumn();
			AutoNumberColumn.ColumnName="STT";
			AutoNumberColumn.DataType = typeof(int);
			AutoNumberColumn.AutoIncrement = true;
			AutoNumberColumn.AutoIncrementSeed = 1;		
			AutoNumberColumn.AutoIncrementStep = 1;
			ResultTable.Columns.Add(AutoNumberColumn);			
			//ResultTable.Merge(SourceTable);			

			//			DataColumn clTT = new DataColumn();
			//			clTT.ColumnName="TT";
			//			clTT.DataType = typeof(bool);
			//			ResultTable.Columns.Add(clTT);			

			int j = 1;
			for(int i=0;i<ResultTable.Rows.Count;i++)
			{				
				ResultTable.Rows[i]["STT"] = j;
				//ResultTable.Rows[i][30] = false;
				j++;
			}
			return ResultTable;

		}

		private void SetMessage(string msg,bool tt)
		{
			lbThongBao.Text = msg;
			if(tt)
			{
				lbThongBao.ForeColor = System.Drawing.Color.Red;					
			}
			else
			{
				lbThongBao.ForeColor = System.Drawing.Color.Blue;
			}
		}

		private void btThemKH_Click(object sender, System.EventArgs e)
		{
			try
			{
				string strHoTen = txtHoTen.Text.Trim();
				string strNgaySinh = dtNgaySinh.Text;			
				string strTenTat = txtTenVietTat.Text.Trim();
				int GioiTinh = 1;
				if(rbNam.Checked)
				{
					GioiTinh = 1;
				}
				else
				{
					GioiTinh = 0;
				}						
				string QuocTich = txtQuocTich.Text.Trim();
				string CMND = txtSo_CMND.Text.Trim();
				string HoChieu = txtSo_CMND.Text.Trim();
				string SoKhac = txtSo_CMND.Text.Trim();
				string ngayCap = dtNgayCap.Text;
				string noiCap = txtNoiCap_CMND.Text.Trim();
				string dcLienHe = txtDiaChiLienHe.Text.Trim();
				string dcThuongTru = txtDiaChiCuTru.Text.Trim();
				string dcNuocNgoai = txtDiaChiNuocNgoai.Text.Trim();
				string dtNha = txtDienThoaiNha.Text.Trim();
				string dtDiDong = txtDienThoaiDD.Text.Trim();
				string HopThu = txtHopThu.Text.Trim();
				int DiHoc = 0;
				int DiLam = 0;
				int tuKinhDoanh = 0;
				int nghiHuu = 0;
				string nganhNghe = "NV";
				string chucVu = "NV";
				string dtCoQuan = "";
				string tenCoQuan = txtCoQuan.Text.Trim();
				string ttHonNhan = "";
				string ttHocVan = "";
				string thuNhap = "";
				int maTK = 0;
				string strError = "";

				string strCMNDCu_MatTruoc ="";
				string strCMNDCu_MatSau ="";
				string strCMNDCu_VanTay1 ="";
				string strCMNDCu_VanTay2 ="";

				string strCMNDMoi_MatTruoc ="";
				string strCMNDMoi_MatSau ="";
				string strCMNDMoi_VanTay1 ="";
				string strCMNDMoi_VanTay2 ="";				

				if(CMNDCu_MatTruoc != null)
				{
					strCMNDCu_MatTruoc = CMND + "_CMNDCu_MatTruoc.jpg";
					SaveImage(CMNDCu_MatTruoc, strCMNDCu_MatTruoc);
				}
				if(CMNDCu_MatSau != null)
				{
					strCMNDCu_MatSau = CMND + "_CMNDCu_MatSau.jpg";
					SaveImage(CMNDCu_MatSau, strCMNDCu_MatSau);
				}
				if(CMNDCu_VanTay1 != null)
				{
					strCMNDCu_VanTay1 = CMND + "_CMNDCu_VanTay1.jpg";
					SaveImage(CMNDCu_VanTay1, strCMNDCu_VanTay1);
				}
				if(CMNDCu_VanTay2 != null)
				{
					strCMNDCu_VanTay2 = CMND + "_CMNDCu_VanTay2.jpg";
					SaveImage(CMNDCu_VanTay2, strCMNDCu_VanTay2);
				}
				if(CMNDMoi_MatTruoc != null)
				{
					strCMNDMoi_MatTruoc = CMND + "_CMNDMoi_MatTruoc.jpg";
					SaveImage(CMNDMoi_MatTruoc, strCMNDMoi_MatTruoc);
				}
				if(CMNDMoi_MatSau != null)
				{
					strCMNDMoi_MatSau = CMND + "_CMNDMoi_MatSau.jpg";
					SaveImage(CMNDMoi_MatSau, strCMNDMoi_MatSau);
				}
				if(CMNDMoi_VanTay1 != null)
				{
					strCMNDMoi_VanTay1 = CMND + "_CMNDMoi_VanTay1.jpg";
					SaveImage(CMNDMoi_VanTay1, strCMNDMoi_VanTay1);
				}
				if(CMNDMoi_VanTay2 != null)
				{
					strCMNDMoi_VanTay2 = CMND + "_CMNDMoi_VanTay2.jpg";
					SaveImage(CMNDMoi_VanTay2, strCMNDMoi_VanTay2);
				}

				bus.InsertPersonal(strHoTen,strTenTat,strNgaySinh,GioiTinh,QuocTich,CMND,HoChieu,SoKhac,ngayCap,noiCap,dcLienHe,dcThuongTru,dcNuocNgoai,dtNha,dtCoQuan,HopThu,DiHoc,DiLam,tuKinhDoanh,nghiHuu,nganhNghe,chucVu,dtCoQuan,tenCoQuan,ttHonNhan,ttHocVan,thuNhap,maTK,strCMNDMoi_MatTruoc, strCMNDMoi_MatSau, strCMNDMoi_VanTay1, strCMNDMoi_VanTay2, strCMNDCu_MatTruoc, strCMNDCu_MatSau, strCMNDCu_VanTay1, strCMNDCu_VanTay2, ref strError);

				if(strError =="")
				{
					SetMessage("Thêm khách hàng thành công!",false);
				}
				else
				{
					SetMessage("Có lỗi trong quá trình thêm dữ liệu:"+strError,true);
				}
			}
			catch(Exception ex)
			{
				SetMessage("Có lỗi trong quá trình thêm dữ liệu:"+ex.Message,true);
			}
		}

		private Boolean SaveImage(Image pic, string name)
		{
			try
			{
				string filename = SVPath +  name;
				Bitmap bmp = new Bitmap(pic);
				bmp.Save(filename, System.Drawing.Imaging.ImageFormat.Jpeg);
				return true;
			}
			catch
			{
				MessageBox.Show("Chưa lưu được ảnh!");
				return false;
			}
			
		}

		private void btSuaKH_Click(object sender, System.EventArgs e)
		{
			try
			{
				string strHoTen = txtHoTen.Text.Trim();
				string strNgaySinh = dtNgaySinh.Text;			
				string strTenTat = txtTenVietTat.Text.Trim();
				int GioiTinh = 1;
				if(rbNam.Checked)
				{
					GioiTinh = 1;
				}
				else
				{
					GioiTinh = 0;
				}						
				string QuocTich = txtQuocTich.Text.Trim();
				string CMND = txtSo_CMND.Text.Trim();
				string HoChieu = txtSo_CMND.Text.Trim();
				string SoKhac = txtSo_CMND.Text.Trim();
				string ngayCap = dtNgayCap.Text;
				string noiCap = txtNoiCap_CMND.Text.Trim();
				string dcLienHe = txtDiaChiLienHe.Text.Trim();
				string dcThuongTru = txtDiaChiCuTru.Text.Trim();
				string dcNuocNgoai = txtDiaChiNuocNgoai.Text.Trim();
				string dtNha = txtDienThoaiNha.Text.Trim();
				string dtDiDong = txtDienThoaiDD.Text.Trim();
				string HopThu = txtHopThu.Text.Trim();
				int DiHoc = 0;
				int DiLam = 0;
				int tuKinhDoanh = 0;
				int nghiHuu = 0;
				string nganhNghe = "NV";
				string chucVu = "NV";
				string dtCoQuan = "";
				string tenCoQuan = txtCoQuan.Text.Trim();
				string ttHonNhan = "";
				string ttHocVan = "";
				string thuNhap = "";				
				string strError = "";
				if(ma_khang_edit!="")
				{
					string strCMNDCu_MatTruoc ="";
					string strCMNDCu_MatSau ="";
					string strCMNDCu_VanTay1 ="";
					string strCMNDCu_VanTay2 ="";

					string strCMNDMoi_MatTruoc ="";
					string strCMNDMoi_MatSau ="";
					string strCMNDMoi_VanTay1 ="";
					string strCMNDMoi_VanTay2 ="";				

					if(CMNDCu_MatTruoc != null)
					{
						strCMNDCu_MatTruoc = CMND + "_CMNDCu_MatTruoc.jpg";
						SaveImage(CMNDCu_MatTruoc, strCMNDCu_MatTruoc);
					}
					if(CMNDCu_MatSau != null)
					{
						strCMNDCu_MatSau = CMND + "_CMNDCu_MatSau.jpg";
						SaveImage(CMNDCu_MatSau, strCMNDCu_MatSau);
					}
					if(CMNDCu_VanTay1 != null)
					{
						strCMNDCu_VanTay1 = CMND + "_CMNDCu_VanTay1.jpg";
						SaveImage(CMNDCu_VanTay1, strCMNDCu_VanTay1);
					}
					if(CMNDCu_VanTay2 != null)
					{
						strCMNDCu_VanTay2 = CMND + "_CMNDCu_VanTay2.jpg";
						SaveImage(CMNDCu_VanTay2, strCMNDCu_VanTay2);
					}
					if(CMNDMoi_MatTruoc != null)
					{
						strCMNDMoi_MatTruoc = CMND + "_CMNDMoi_MatTruoc.jpg";
						SaveImage(CMNDMoi_MatTruoc, strCMNDMoi_MatTruoc);
					}
					if(CMNDMoi_MatSau != null)
					{
						strCMNDMoi_MatSau = CMND + "_CMNDMoi_MatSau.jpg";
						SaveImage(CMNDMoi_MatSau, strCMNDMoi_MatSau);
					}
					if(CMNDMoi_VanTay1 != null)
					{
						strCMNDMoi_VanTay1 = CMND + "_CMNDMoi_VanTay1.jpg";
						SaveImage(CMNDMoi_VanTay1, strCMNDMoi_VanTay1);
					}
					if(CMNDMoi_VanTay2 != null)
					{
						strCMNDMoi_VanTay2 = CMND + "_CMNDMoi_VanTay2.jpg";
						SaveImage(CMNDMoi_VanTay2, strCMNDMoi_VanTay2);
					}

					bus.UpdatePersonal(ma_khang_edit,strHoTen,strTenTat,strNgaySinh,GioiTinh,QuocTich,CMND,HoChieu,SoKhac,ngayCap,noiCap,dcLienHe,dcThuongTru,dcNuocNgoai,dtNha,dtCoQuan,HopThu,DiHoc,DiLam,tuKinhDoanh,nghiHuu,nganhNghe,chucVu,dtCoQuan,tenCoQuan,ttHonNhan,ttHocVan,thuNhap,ref strError);
					if(strError =="")
					{
						SetMessage("Thêm khách hàng thành công!",false);
					}
					else
					{
						SetMessage("Có lỗi trong quá trình thêm dữ liệu:"+strError,true);
					}
				}
				else
				{
					MessageBox.Show("Chưa lấy được thông tin khách hàng!");
				}
			}
			catch(Exception ex)
			{
				SetMessage("Có lỗi trong quá trình thêm dữ liệu:"+ex.Message,true);
			}
		}

		private void btLamLai_Click(object sender, System.EventArgs e)
		{
			ResetControl();
		}

		private void ResetControl()
		{
			try	
			{
				rbNam.Checked = true;
				rbNu.Checked = false;
				//			rb_CT_Co.Checked = false;
				//			rb_CT_Khong.Checked = true;			
				foreach(Control tb in groupBox2.Controls)
				{
					if(tb is TextBox)
					{
						//here is where you access all the textboxs.
						tb.Text = "";
					}
				}
				foreach(Control tb in groupBox3.Controls)
				{
					if(tb is TextBox)
					{
						//here is where you access all the textboxs.
						tb.Text = "";
					}
				}
				CMNDMoi_MatTruoc = null; 				CMNDMoi_MatSau = null; 				CMNDMoi_VanTay1 = null; 				CMNDMoi_VanTay2 = null; 				CMNDCu_MatTruoc = null; 				CMNDCu_MatSau = null; 				CMNDCu_VanTay1 = null;
				CMNDCu_VanTay2 = null;
				//
				picCMNDMoi_MatTruoc.Image = null; 				picCMNDMoi_MatSau.Image = null; 				picCMNDMoi_VanTay1.Image = null; 				picCMNDMoi_VanTay2.Image = null; 				picCMNDCu_MatTruoc.Image = null; 				picCMNDCu_MatSau.Image = null; 				picCMNDCu_VanTay1.Image = null;
				picCMNDCu_VanTay2.Image = null;
				picVanTaySong1.Image = null;
				picVanTaySong2.Image = null;
				//
				picCMNDMoi_MatTruocSS.Image = null; 				picCMNDMoi_MatSauSS.Image = null; 				picCMNDMoi_VanTay1SS.Image = null; 				picCMNDMoi_VanTay2SS.Image = null; 				picCMNDCu_MatTruocSS.Image = null; 				picCMNDCu_MatSauSS.Image = null; 				picCMNDCu_VanTay1SS.Image = null;
				picCMNDCu_VanTay2SS.Image = null;
				picVanTaySong1SS.Image = null;
				picVanTaySong2SS.Image = null;
			}
			catch(Exception ex)
			{
				SetMessage("Có lỗi hệ thống!" + ex.Message,true);
			}
		}

		private void menuItemThem_Click(object sender, System.EventArgs e)
		{
			tabControl.SelectedIndex = 0;
			StateControl(1);
		}
		private string ma_khang_edit = "";

		private void menuItemSua_Click(object sender, System.EventArgs e)
		{			
			try
			{
				StateControl(2);
				CurrencyManager xCM = (CurrencyManager)dtgKhachHang.BindingContext[dtgKhachHang.DataSource, dtgKhachHang.DataMember];
				DataRowView xDRV = (DataRowView)xCM.Current;
				DataRow xRow	= xDRV.Row;

				if(xRow["MaKhachHang"]!=null)
				{
					tabControl.SelectedIndex = 0;
					ma_khang_edit = xRow["MaKhachHang"].ToString();
					//Load thông tin khách hàng
					DataSet dsKhachHang = bus.LoadPersonalById(xRow["MaKhachHang"].ToString());
					DataTable tblKhachHang = dsKhachHang.Tables[0];
					txtHoTen.Text =  tblKhachHang.Rows[0]["HoTen"].ToString();
					dtNgaySinh.Text = tblKhachHang.Rows[0]["NgaySinh"].ToString();			
					txtTenVietTat.Text = tblKhachHang.Rows[0]["TenVietTat"].ToString();
					int GioiTinh = 1;
					if(rbNam.Checked)
					{
						GioiTinh = 1;
					}
					else
					{
						GioiTinh = 0;
					}						
					txtQuocTich.Text = tblKhachHang.Rows[0]["QuocTich"].ToString();
					txtSo_CMND.Text = tblKhachHang.Rows[0]["CMND"].ToString();
					//txtSo_CMND.Text = tblKhachHang.Rows[0]["HoChieu"].ToString();
					//txtSo_CMND.Text = tblKhachHang.Rows[0]["SoKhac"].ToString();
					dtNgayCap.Text = tblKhachHang.Rows[0]["NgayCapCMND"].ToString();
					txtNoiCap_CMND.Text = tblKhachHang.Rows[0]["NoiCapCMND"].ToString();
					txtDiaChiLienHe.Text = tblKhachHang.Rows[0]["DiaChiLienHe"].ToString();
					txtDiaChiCuTru.Text = tblKhachHang.Rows[0]["DiaChiThuongTru"].ToString();
					txtDiaChiNuocNgoai.Text = tblKhachHang.Rows[0]["DiaChiNuocNgoai"].ToString();
					txtDienThoaiNha.Text = tblKhachHang.Rows[0]["DienThoaiNha"].ToString();
					txtDienThoaiDD.Text = tblKhachHang.Rows[0]["DienThoaiDiDong"].ToString();
					txtHopThu.Text = tblKhachHang.Rows[0]["HopThu"].ToString();
					//DiHoc = 0;
					//DiLam = 0;
					//tuKinhDoanh = 0;
					//nghiHuu = 0;
					txtNganhNghe.Text = tblKhachHang.Rows[0]["NganhNghe"].ToString();
					txtChucVu.Text = tblKhachHang.Rows[0]["ChucVu"].ToString();
					txtCoQuan.Text = tblKhachHang.Rows[0]["TenCoQuan"].ToString();;				
					//ttHonNhan = "";
					//ttHocVan = "";
					//thuNhap = "";
					//
					if(File.Exists(SVPath + tblKhachHang.Rows[0]["CMNDCu_MatTruoc"].ToString()))
					{
						using (System.IO.FileStream fs = new System.IO.FileStream(SVPath + tblKhachHang.Rows[0]["CMNDCu_MatTruoc"].ToString(), FileMode.Open))
						{
							Bitmap bmp = new Bitmap(fs);
							picCMNDCu_MatTruoc.Image = (Bitmap)bmp.Clone();
						}	
					}
					if(File.Exists(SVPath + tblKhachHang.Rows[0]["CMNDCu_MatSau"].ToString()))
					{
						using (System.IO.FileStream fs = new System.IO.FileStream(SVPath + tblKhachHang.Rows[0]["CMNDCu_MatSau"].ToString(), FileMode.Open))
						{
							Bitmap bmp = new Bitmap(fs);
							picCMNDCu_MatSau.Image = (Bitmap)bmp.Clone();
						}	
					}
					if(File.Exists(SVPath + tblKhachHang.Rows[0]["CMNDCu_VanTay1"].ToString()))
					{
						using (System.IO.FileStream fs = new System.IO.FileStream(SVPath + tblKhachHang.Rows[0]["CMNDCu_VanTay1"].ToString(), FileMode.Open))
						{
							Bitmap bmp = new Bitmap(fs);
							picCMNDCu_VanTay1.Image = (Bitmap)bmp.Clone();
						}	
					}
					if(File.Exists(SVPath + tblKhachHang.Rows[0]["CMNDCu_VanTay2"].ToString()))
					{
						using (System.IO.FileStream fs = new System.IO.FileStream(SVPath + tblKhachHang.Rows[0]["CMNDCu_VanTay2"].ToString(), FileMode.Open))
						{
							Bitmap bmp = new Bitmap(fs);
							picCMNDCu_VanTay2.Image = (Bitmap)bmp.Clone();
						}	
					}
					//
					if(File.Exists(SVPath + tblKhachHang.Rows[0]["CMNDMoi_MatTruoc"].ToString()))
					{
						using (System.IO.FileStream fs = new System.IO.FileStream(SVPath + tblKhachHang.Rows[0]["CMNDMoi_MatTruoc"].ToString(), FileMode.Open))
						{
							Bitmap bmp = new Bitmap(fs);
							picCMNDMoi_MatTruoc.Image = (Bitmap)bmp.Clone();
						}	
					}
					if(File.Exists(SVPath + tblKhachHang.Rows[0]["CMNDMoi_MatSau"].ToString()))
					{
						using (System.IO.FileStream fs = new System.IO.FileStream(SVPath + tblKhachHang.Rows[0]["CMNDMoi_MatSau"].ToString(), FileMode.Open))
						{
							Bitmap bmp = new Bitmap(fs);
							picCMNDMoi_MatSau.Image = (Bitmap)bmp.Clone();
						}	
					}
					if(File.Exists(SVPath + tblKhachHang.Rows[0]["CMNDMoi_VanTay1"].ToString()))
					{
						using (System.IO.FileStream fs = new System.IO.FileStream(SVPath + tblKhachHang.Rows[0]["CMNDMoi_VanTay1"].ToString(), FileMode.Open))
						{
							Bitmap bmp = new Bitmap(fs);
							picCMNDMoi_VanTay1.Image = (Bitmap)bmp.Clone();
						}	
					}
					if(File.Exists(SVPath + tblKhachHang.Rows[0]["CMNDMoi_VanTay2"].ToString()))
					{
						using (System.IO.FileStream fs = new System.IO.FileStream(SVPath + tblKhachHang.Rows[0]["CMNDMoi_VanTay2"].ToString(), FileMode.Open))
						{
							Bitmap bmp = new Bitmap(fs);
							picCMNDMoi_VanTay2.Image = (Bitmap)bmp.Clone();
						}
					}
				}

			}
			catch
			{

			}

			//MessageBox.Show("Sửa XXX"+xRow["MaKhachHang"]);
		}

		private void menuItemLamMoi_Click(object sender, System.EventArgs e)
		{
			LoadFormData();
		}

		private void rbNam_CheckedChanged(object sender, System.EventArgs e)
		{
			if(rbNam.Checked)
			{
				rbNu.Checked = false;
			}
			else
			{
				rbNu.Checked = true;
			}
		}

		private void rbNu_CheckedChanged(object sender, System.EventArgs e)
		{
			if(rbNam.Checked)
			{
				rbNu.Checked = false;
			}
			else
			{
				rbNu.Checked = true;
			}
		}

		private void dtgKhachHang_CurrentCellChanged(object sender, System.EventArgs e)
		{
			// if click on a discontinued row, then set currentcell to checkbox
			// String variable used to show message. 
			string myString = "CurrentCellChanged event raised, cell focus is at ";
			// Get the co-ordinates of the focussed cell. 
			string myPoint  = dtgKhachHang.CurrentCell.ColumnNumber + "," +
				dtgKhachHang.CurrentCell.RowNumber;
			// Create the alert message.
			myString = myString + "(" + myPoint + ")";
			dtgKhachHang.Select(dtgKhachHang.CurrentCell.RowNumber);
			// Show Co-ordinates when CurrentCellChanged event is raised.
			//MessageBox.Show(myString, "Current cell co-ordinates");			
			try
			{
				if(dtgKhachHang.DataSource!=null)
				{
					CurrencyManager currencyManager = (CurrencyManager) this.BindingContext [this.dtgKhachHang.DataSource, this.dtgKhachHang.DataMember];					
					string[] maKHs = new string[dtgKhachHang.VisibleRowCount];					
					DataRowView drv = (DataRowView) currencyManager.List[dtgKhachHang.CurrentRowIndex];
					DataRow dr = drv.Row;
					if(File.Exists(SVPath + dr["CMNDCu_MatTruoc"].ToString()))
					{
						using (System.IO.FileStream fs = new System.IO.FileStream(SVPath + dr["CMNDCu_MatTruoc"].ToString(), FileMode.Open))
						{
							Bitmap bmp = new Bitmap(fs);
							picCMNDCu_MatTruocSS.Image = (Bitmap)bmp.Clone();
						}	
					}
					if(File.Exists(SVPath + dr["CMNDCu_MatSau"].ToString()))
					{
						using (System.IO.FileStream fs = new System.IO.FileStream(SVPath + dr["CMNDCu_MatSau"].ToString(), FileMode.Open))
						{
							Bitmap bmp = new Bitmap(fs);
							picCMNDCu_MatSauSS.Image = (Bitmap)bmp.Clone();
						}	
					}
					if(File.Exists(SVPath + dr["CMNDCu_VanTay1"].ToString()))
					{
						using (System.IO.FileStream fs = new System.IO.FileStream(SVPath + dr["CMNDCu_VanTay1"].ToString(), FileMode.Open))
						{
							Bitmap bmp = new Bitmap(fs);
							picCMNDCu_VanTay1SS.Image = (Bitmap)bmp.Clone();
						}	
					}
					if(File.Exists(SVPath + dr["CMNDCu_VanTay2"].ToString()))
					{
						using (System.IO.FileStream fs = new System.IO.FileStream(SVPath + dr["CMNDCu_VanTay2"].ToString(), FileMode.Open))
						{
							Bitmap bmp = new Bitmap(fs);
							picCMNDCu_VanTay2SS.Image = (Bitmap)bmp.Clone();
						}	
					}
					//					 
					if(File.Exists(SVPath + dr["CMNDMoi_MatTruoc"].ToString()))
					{
						using (System.IO.FileStream fs = new System.IO.FileStream(SVPath + dr["CMNDMoi_MatTruoc"].ToString(), FileMode.Open))
						{
							Bitmap bmp = new Bitmap(fs);
							picCMNDMoi_MatTruocSS.Image = (Bitmap)bmp.Clone();
						}	
					}
					if(File.Exists(SVPath + dr["CMNDMoi_MatSau"].ToString()))
					{
						using (System.IO.FileStream fs = new System.IO.FileStream(SVPath + dr["CMNDMoi_MatSau"].ToString(), FileMode.Open))
						{
							Bitmap bmp = new Bitmap(fs);
							picCMNDMoi_MatSauSS.Image = (Bitmap)bmp.Clone();
						}	
					}
					if(File.Exists(SVPath + dr["CMNDMoi_VanTay1"].ToString()))
					{
						using (System.IO.FileStream fs = new System.IO.FileStream(SVPath + dr["CMNDMoi_VanTay1"].ToString(), FileMode.Open))
						{
							Bitmap bmp = new Bitmap(fs);
							picCMNDMoi_VanTay1SS.Image = (Bitmap)bmp.Clone();
						}	
					}
					if(File.Exists(SVPath + dr["CMNDMoi_VanTay2"].ToString()))
					{
						using (System.IO.FileStream fs = new System.IO.FileStream(SVPath + dr["CMNDMoi_VanTay2"].ToString(), FileMode.Open))
						{
							Bitmap bmp = new Bitmap(fs);
							picCMNDMoi_VanTay2SS.Image = (Bitmap)bmp.Clone();
						}
					}
				}
			}
			catch{}
		}		
		
		private void menuItemXoa_Click(object sender, System.EventArgs e)
		{		
			if(MessageBox.Show("Bạn có chắc chắn muốn xóa?","Cảnh báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
			{
				if(dtgKhachHang.DataSource!=null)
				{					
					string strError = "";

					CurrencyManager currencyManager = (CurrencyManager) this.BindingContext [this.dtgKhachHang.DataSource, this.dtgKhachHang.DataMember];					
					string[] maKHs = new string[dtgKhachHang.VisibleRowCount];
					for (int i = 0; i <dtgKhachHang.VisibleRowCount; i++)
					{
						if (this.dtgKhachHang.IsSelected(i))
						{
							DataRowView drv = (DataRowView) currencyManager.List[i];
							DataRow dr = drv.Row;
							//sb.AppendFormat("{0} {1} {2} \ n", dr[0], dr[1], dr[2]);
							//sb+= dr["MaKhachHang"]+ " --- ";
							bus.DeletePersonal(dr["MaKhachHang"].ToString(),ref strError);
							if(strError!="")
							{
								maKHs[i] = dr["MaKhachHang"].ToString();
							}
						}
					}			

					if(maKHs.Length>0)
					{
						string sMaKhang="";
						for(int i=0;i<maKHs.Length;i++)
						{
							if(maKHs[i]!= null)
							{
								sMaKhang+=maKHs[i].ToString();
							}
						}
						if(sMaKhang!="")
							SetMessage("Không xóa được dữ liệu các khách hàng sau: "+ sMaKhang,true);
						else
						{
							SetMessage("Xóa danh sách khách hàng thành công!",false);
						}
						LoadFormData();
					}							
				}
			}

		}

		private void tabControl1_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			SetMessage("",false);
		}

		private void toolBar1_ButtonClick(object sender, System.Windows.Forms.ToolBarButtonClickEventArgs e)
		{
			if(e.Button.Text.ToLower() == "khai thác")
			{
				MessageBox.Show("OK");
				frmScan scan = new frmScan();
				scan.ShowDialog();
			}

		}

		private void Form1_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			if(MessageBox.Show("Bạn có thực sự muốn thoát chương trình?","Thong Bao",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.No)
			{
				e.Cancel = true;
			}			
		}	

		private void StateControl(int stateId)
		{	
			switch(stateId)
			{
				case 1:
				{
					btThemKH.Enabled = true;
					btSuaKH.Enabled = false;
					btLamLai.Enabled = true;
					break;
				}
				case 2:
				{
					btThemKH.Enabled = false;
					btSuaKH.Enabled = true;
					break;

				}
			}	
			
		}

		private void picCMNDCu_MatTruoc_Click(object sender, System.EventArgs e)
		{
			frmScan frm = new frmScan();
			frm.SelectIndex = 1;
			EditIMG(0, frm);
			frm.ShowDialog();
			GetID(frm, 0);
		}

		private void picCMNDCu_MatSau_Click(object sender, System.EventArgs e)
		{
			frmScan frm = new frmScan();
			frm.SelectIndex = 2;
			EditIMG(0, frm);
			frm.ShowDialog();
			GetID(frm, 0);			
		}
		private void picCMNDMoi_VanTay1_Click(object sender, System.EventArgs e)
		{
			frmScan frm = new frmScan();
			frm.SelectIndex = 3;
			EditIMG(1, frm);
			frm.ShowDialog();
			GetID(frm, 0);
		}

		private void picCMNDMoi_VanTay2_Click(object sender, System.EventArgs e)
		{
			frmScan frm = new frmScan();
			frm.SelectIndex = 4;
			EditIMG(1, frm);
			frm.ShowDialog();
			GetID(frm, 0);
		}
		private void picCMNDMoi_MatTruoc_Click(object sender, System.EventArgs e)
		{
			frmScan frm = new frmScan();
			frm.SelectIndex = 1;
			EditIMG(1, frm);
			frm.ShowDialog();
			GetID(frm, 1);
		}

		private void picCMNDMoi_MatSau_Click(object sender, System.EventArgs e)
		{
			frmScan frm = new frmScan();
			frm.SelectIndex = 2;
			EditIMG(1, frm);
			frm.ShowDialog();
			GetID(frm, 1);
		}
		private void picCMNDCu_VanTay1_Click(object sender, System.EventArgs e)
		{
			frmScan frm = new frmScan();
			frm.SelectIndex = 3;
			EditIMG(0, frm);
			frm.ShowDialog();
			GetID(frm, 1);
		}

		private void picCMNDCu_VanTay2_Click(object sender, System.EventArgs e)
		{
			frmScan frm = new frmScan();
			frm.SelectIndex = 4;
			EditIMG(0, frm);
			frm.ShowDialog();
			GetID(frm, 1);
		}
		void EditIMG(int iID, frmScan frm)
		{
			if(iID == 0)
			{
				if(picCMNDCu_MatTruoc.Image != null)
					frm.IDBefore = picCMNDCu_MatTruoc.Image;
				if(picCMNDCu_MatSau.Image != null)
					frm.IDAfter = picCMNDCu_MatSau.Image;
				if(picCMNDCu_VanTay1.Image != null)
					frm.FP1 = picCMNDCu_VanTay1.Image;
				if(picCMNDCu_VanTay2.Image != null)
					frm.FP2 = picCMNDCu_VanTay2.Image;	
			}
			else
			{
				if(picCMNDMoi_MatTruoc.Image != null)
					frm.IDBefore = picCMNDMoi_MatTruoc.Image;
				if(picCMNDMoi_MatSau.Image != null)
					frm.IDAfter = picCMNDMoi_MatSau.Image;
				if(picCMNDMoi_VanTay1.Image != null)
					frm.FP1 = picCMNDMoi_VanTay1.Image;
				if(picCMNDMoi_VanTay2.Image != null)
					frm.FP2 = picCMNDMoi_VanTay2.Image;	
			}
		}
		 
		void GetID(frmScan frm, int idversion) 		{ 			if(idversion == 0)//ID cũ 			{ 				CMNDCu_MatTruoc = frm.IDBefore; 				CMNDCu_MatSau = frm.IDAfter; 				CMNDCu_VanTay1 = frm.FP1;
				CMNDCu_VanTay2 = frm.FP2; 				if(frm.IDBefore != null) 				{ 					picCMNDCu_MatTruoc.Image = frm.IDBefore; 				} 				if(frm.IDAfter != null) 				{ 					picCMNDCu_MatSau.Image = frm.IDAfter; 				} 				if(frm.FP1 != null) 				{ 					picCMNDCu_VanTay1.Image = frm.FP1; 				} 				if(frm.FP2 != null) 				{ 					picCMNDCu_VanTay2.Image = frm.FP2; 				} 			} 			else if(idversion == 1)//ID mới 			{ 				CMNDMoi_MatTruoc = frm.IDBefore; 				CMNDMoi_MatSau = frm.IDAfter; 				CMNDMoi_VanTay1 = frm.FP1;
				CMNDMoi_VanTay2 = frm.FP2; 				if(frm.IDBefore != null) 				{ 					picCMNDMoi_MatTruoc.Image = frm.IDBefore; 				} 				if(frm.IDAfter != null) 				{ 					picCMNDMoi_MatSau.Image = frm.IDAfter; 				} 				if(frm.FP1 != null) 				{ 					picCMNDMoi_VanTay1.Image = frm.FP1; 				} 				if(frm.FP2 != null) 				{ 					picCMNDMoi_VanTay2.Image = frm.FP2; 				} 			} 		}

		private void dtgKhachHang_Click(object sender, System.EventArgs e)
		{
			
		}

		private void menuItemChiTiet_Click(object sender, System.EventArgs e)
		{
			try
			{
				frmDetail_KHang frmDetailKH = new frmDetail_KHang();
				frmDetailKH.ShowDialog();
			}
			catch
			{

			}
		}

		private void btnTimKiem_Click(object sender, System.EventArgs e)
		{
			try
			{
				if(dtgKhachHang.DataSource !=null)
				{
					DataView dtvDsKhachHang = null;
					if(dtgKhachHang.DataSource is DataTable)
					{
						dtvDsKhachHang = (dtgKhachHang.DataSource as DataTable).DefaultView;
					}
					else
					{
						dtvDsKhachHang  = dtgKhachHang.DataSource as DataView;
					}
					dtvDsKhachHang.RowFilter = String.Empty;
					string strTimKiem = "";
					if(txt_TK_HoTen.Text.Trim()!="")
					{
						if(strTimKiem.Length>0)
						{
							strTimKiem += "AND HoTen LIKE '%" + txt_TK_HoTen.Text.Trim() + "%'";
						}
						else
						{
							strTimKiem += "HoTen LIKE '%" + txt_TK_HoTen.Text.Trim() + "%'";
						}
					}

					if(txtSo_CMND.Text.Trim()!="")
					{
						if(strTimKiem.Length>0)
						{
							strTimKiem += "AND CMND LIKE '%" + txt_TK_HoTen.Text.Trim() + "%'";
						}
						else
						{
							strTimKiem += "CMND LIKE '%" + txt_TK_HoTen.Text.Trim() + "%'";
						}
					}

					dtvDsKhachHang.RowFilter = string.Empty;
					dtvDsKhachHang.RowFilter = strTimKiem;				
					dtgKhachHang.DataSource = dtvDsKhachHang;

					//				if(txt_TK_HoTen.Text.Trim()!="")
					//				{
					//					if(strTimKiem.Length>0)
					//					{
					//						strTimKiem += "AND HoTen LIKE '%" + txt_TK_HoTen.Text.Trim() + "%'";
					//					}
					//					else
					//					{
					//						strTimKiem += "HoTen LIKE '%" + txt_TK_HoTen.Text.Trim() + "%'";
					//					}
					//				}			
				}
			}
			catch (Exception ex)
			{
				SetMessage("Lỗi hệ thống: " + ex.Message,true);
			}
		}

		private void btnInDanhSach_Click(object sender, System.EventArgs e)
		{
			frmShowDS_KHang frmShowDSKH = new frmShowDS_KHang();
			frmShowDSKH.ShowDialog();
		} 	} } 
using System; using System.Drawing; using System.Collections; using System.ComponentModel; using System.Windows.Forms; using System.Data; using System.Data.SqlClient;  namespace HRM_CHECKER { 	/// <summary> 	/// Summary description for Form1. 	/// </summary> 	public class Form1 : System.Windows.Forms.Form 	{ 		private System.Windows.Forms.ToolBar toolBar1; 		private System.Windows.Forms.ImageList imageList1;
		private System.Windows.Forms.ToolBarButton toolBarButton1;
		private System.Windows.Forms.ToolBarButton toolBarButton2;
		private System.Windows.Forms.ToolBarButton toolBarButton3;
		private System.Windows.Forms.ToolBarButton toolBarButton4;
		private System.Windows.Forms.ToolBarButton toolBarButton5;
		private System.Windows.Forms.ToolBarButton toolBarButton6;
		private System.Windows.Forms.StatusBar statusBar1;
		private System.Windows.Forms.TabControl tabControl1;
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
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label10;
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
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.Panel panel9;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Label label21;
		private System.Windows.Forms.Panel panel10;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.Label label22;
		private System.Windows.Forms.Panel panel11;
		private System.Windows.Forms.PictureBox pictureBox4;
		private System.Windows.Forms.Label label23;
		private System.Windows.Forms.GroupBox groupBox5;
		private System.Windows.Forms.Panel panel12;
		private System.Windows.Forms.Panel panel13;
		private System.Windows.Forms.PictureBox pictureBox5;
		private System.Windows.Forms.Label label24;
		private System.Windows.Forms.Panel panel14;
		private System.Windows.Forms.PictureBox pictureBox6;
		private System.Windows.Forms.Label label25;
		private System.Windows.Forms.Panel panel15;
		private System.Windows.Forms.PictureBox pictureBox7;
		private System.Windows.Forms.Label label26;
		private System.Windows.Forms.Panel panel16;
		private System.Windows.Forms.PictureBox pictureBox8;
		private System.Windows.Forms.Label label27;
		private System.Windows.Forms.GroupBox groupBox6;
		private System.Windows.Forms.Panel panel17;
		private System.Windows.Forms.Panel panel18;
		private System.Windows.Forms.PictureBox pictureBox9;
		private System.Windows.Forms.Label label28;
		private System.Windows.Forms.Panel panel19;
		private System.Windows.Forms.PictureBox pictureBox10;
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
		private System.Windows.Forms.Button txtLamLai;
		private System.Windows.Forms.Button txtSuaKH;
		private System.Windows.Forms.Button btThemKH;
		private System.Windows.Forms.Panel panel20;
		private System.Windows.Forms.Splitter splitter2;
		private System.Windows.Forms.Panel panel21;
		private System.Windows.Forms.Panel panel22;
		private System.Windows.Forms.Splitter splitter3;
		private System.Windows.Forms.Panel panel23;
		private System.Windows.Forms.Label label35;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label36;
		private System.Windows.Forms.GroupBox groupBox8;
		private System.Windows.Forms.Panel panel24;
		private System.Windows.Forms.Panel panel25;
		private System.Windows.Forms.Panel panel26;
		private System.Windows.Forms.PictureBox pictureBox11;
		private System.Windows.Forms.Label label37;
		private System.Windows.Forms.Panel panel27;
		private System.Windows.Forms.PictureBox pictureBox12;
		private System.Windows.Forms.Label label38;
		private System.Windows.Forms.Panel panel28;
		private System.Windows.Forms.PictureBox pictureBox13;
		private System.Windows.Forms.Label label39;
		private System.Windows.Forms.Panel panel29;
		private System.Windows.Forms.PictureBox pictureBox14;
		private System.Windows.Forms.Label label40;
		private System.Windows.Forms.GroupBox groupBox9;
		private System.Windows.Forms.Panel panel30;
		private System.Windows.Forms.Panel panel31;
		private System.Windows.Forms.PictureBox pictureBox15;
		private System.Windows.Forms.Label label41;
		private System.Windows.Forms.Panel panel32;
		private System.Windows.Forms.PictureBox pictureBox16;
		private System.Windows.Forms.Label label42;
		private System.Windows.Forms.Panel panel33;
		private System.Windows.Forms.Panel panel34;
		private System.Windows.Forms.PictureBox pictureBox17;
		private System.Windows.Forms.Label label43;
		private System.Windows.Forms.Panel panel35;
		private System.Windows.Forms.PictureBox pictureBox18;
		private System.Windows.Forms.Label label44;
		private System.Windows.Forms.GroupBox groupBox10;
		private System.Windows.Forms.Panel panel36;
		private System.Windows.Forms.Panel panel38;
		private System.Windows.Forms.PictureBox pictureBox20;
		private System.Windows.Forms.Label label46;
		private System.Windows.Forms.Panel panel39;
		private System.Windows.Forms.Panel panel41;
		private System.Windows.Forms.PictureBox pictureBox22;
		private System.Windows.Forms.Label label48;
		private System.Windows.Forms.ErrorProvider errorProvider1;
		private System.Windows.Forms.Label label45;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Label label47;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.DataGrid dtgKhachHang;
		private System.Windows.Forms.RadioButton rbNam;
		private System.Windows.Forms.RadioButton rbNu;
		private System.Windows.Forms.RadioButton rb_CT_Co;
		private System.Windows.Forms.RadioButton rb_CT_Khong;
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
		private System.Windows.Forms.Label lbThongBao; 		private System.ComponentModel.IContainer components;  		public Form1() 		{ 			// 			// Required for Windows Form Designer support 			// 			InitializeComponent();  			// 			// TODO: Add any constructor code after InitializeComponent call 			// 		}  		/// <summary> 		/// Clean up any resources being used. 		/// </summary> 		protected override void Dispose( bool disposing ) 		{ 			if( disposing ) 			{ 				if (components != null)  				{ 					components.Dispose(); 				} 			} 			base.Dispose( disposing ); 		}  		#region Windows Form Designer generated code 		/// <summary> 		/// Required method for Designer support - do not modify 		/// the contents of this method with the code editor. 		/// </summary> 		private void InitializeComponent() 		{ 			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form1));
			this.toolBar1 = new System.Windows.Forms.ToolBar();
			this.toolBarButton1 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton2 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton3 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton4 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton5 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton6 = new System.Windows.Forms.ToolBarButton();
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.statusBar1 = new System.Windows.Forms.StatusBar();
			this.tabControl1 = new System.Windows.Forms.TabControl();
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
			this.rb_CT_Khong = new System.Windows.Forms.RadioButton();
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
			this.label10 = new System.Windows.Forms.Label();
			this.txtQuocTich = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.txtTenVietTat = new System.Windows.Forms.TextBox();
			this.txtHoTen = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.rb_CT_Co = new System.Windows.Forms.RadioButton();
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
			this.txtLamLai = new System.Windows.Forms.Button();
			this.txtSuaKH = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.btThemKH = new System.Windows.Forms.Button();
			this.splitter1 = new System.Windows.Forms.Splitter();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel6 = new System.Windows.Forms.Panel();
			this.groupBox6 = new System.Windows.Forms.GroupBox();
			this.panel17 = new System.Windows.Forms.Panel();
			this.panel18 = new System.Windows.Forms.Panel();
			this.pictureBox9 = new System.Windows.Forms.PictureBox();
			this.label28 = new System.Windows.Forms.Label();
			this.panel19 = new System.Windows.Forms.Panel();
			this.pictureBox10 = new System.Windows.Forms.PictureBox();
			this.label29 = new System.Windows.Forms.Label();
			this.groupBox5 = new System.Windows.Forms.GroupBox();
			this.panel12 = new System.Windows.Forms.Panel();
			this.panel13 = new System.Windows.Forms.Panel();
			this.pictureBox5 = new System.Windows.Forms.PictureBox();
			this.label24 = new System.Windows.Forms.Label();
			this.panel14 = new System.Windows.Forms.Panel();
			this.pictureBox6 = new System.Windows.Forms.PictureBox();
			this.label25 = new System.Windows.Forms.Label();
			this.panel15 = new System.Windows.Forms.Panel();
			this.pictureBox7 = new System.Windows.Forms.PictureBox();
			this.label26 = new System.Windows.Forms.Label();
			this.panel16 = new System.Windows.Forms.Panel();
			this.pictureBox8 = new System.Windows.Forms.PictureBox();
			this.label27 = new System.Windows.Forms.Label();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.panel8 = new System.Windows.Forms.Panel();
			this.panel10 = new System.Windows.Forms.Panel();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.label22 = new System.Windows.Forms.Label();
			this.panel11 = new System.Windows.Forms.Panel();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			this.label23 = new System.Windows.Forms.Label();
			this.panel9 = new System.Windows.Forms.Panel();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.label21 = new System.Windows.Forms.Label();
			this.panel7 = new System.Windows.Forms.Panel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label20 = new System.Windows.Forms.Label();
			this.panel4 = new System.Windows.Forms.Panel();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.panel21 = new System.Windows.Forms.Panel();
			this.dtgKhachHang = new System.Windows.Forms.DataGrid();
			this.splitter2 = new System.Windows.Forms.Splitter();
			this.panel20 = new System.Windows.Forms.Panel();
			this.panel23 = new System.Windows.Forms.Panel();
			this.groupBox10 = new System.Windows.Forms.GroupBox();
			this.panel36 = new System.Windows.Forms.Panel();
			this.panel38 = new System.Windows.Forms.Panel();
			this.pictureBox20 = new System.Windows.Forms.PictureBox();
			this.label46 = new System.Windows.Forms.Label();
			this.panel39 = new System.Windows.Forms.Panel();
			this.panel41 = new System.Windows.Forms.Panel();
			this.pictureBox22 = new System.Windows.Forms.PictureBox();
			this.label48 = new System.Windows.Forms.Label();
			this.groupBox9 = new System.Windows.Forms.GroupBox();
			this.panel30 = new System.Windows.Forms.Panel();
			this.panel31 = new System.Windows.Forms.Panel();
			this.pictureBox15 = new System.Windows.Forms.PictureBox();
			this.label41 = new System.Windows.Forms.Label();
			this.panel32 = new System.Windows.Forms.Panel();
			this.pictureBox16 = new System.Windows.Forms.PictureBox();
			this.label42 = new System.Windows.Forms.Label();
			this.panel33 = new System.Windows.Forms.Panel();
			this.panel34 = new System.Windows.Forms.Panel();
			this.pictureBox17 = new System.Windows.Forms.PictureBox();
			this.label43 = new System.Windows.Forms.Label();
			this.panel35 = new System.Windows.Forms.Panel();
			this.pictureBox18 = new System.Windows.Forms.PictureBox();
			this.label44 = new System.Windows.Forms.Label();
			this.groupBox8 = new System.Windows.Forms.GroupBox();
			this.panel25 = new System.Windows.Forms.Panel();
			this.panel29 = new System.Windows.Forms.Panel();
			this.pictureBox14 = new System.Windows.Forms.PictureBox();
			this.label40 = new System.Windows.Forms.Label();
			this.panel28 = new System.Windows.Forms.Panel();
			this.pictureBox13 = new System.Windows.Forms.PictureBox();
			this.label39 = new System.Windows.Forms.Label();
			this.panel24 = new System.Windows.Forms.Panel();
			this.panel27 = new System.Windows.Forms.Panel();
			this.pictureBox12 = new System.Windows.Forms.PictureBox();
			this.label38 = new System.Windows.Forms.Label();
			this.panel26 = new System.Windows.Forms.Panel();
			this.pictureBox11 = new System.Windows.Forms.PictureBox();
			this.label37 = new System.Windows.Forms.Label();
			this.splitter3 = new System.Windows.Forms.Splitter();
			this.panel22 = new System.Windows.Forms.Panel();
			this.button1 = new System.Windows.Forms.Button();
			this.label47 = new System.Windows.Forms.Label();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.label45 = new System.Windows.Forms.Label();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.label36 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label35 = new System.Windows.Forms.Label();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider();
			this.contextMenuGrid = new System.Windows.Forms.ContextMenu();
			this.menuItemThem = new System.Windows.Forms.MenuItem();
			this.menuItemSua = new System.Windows.Forms.MenuItem();
			this.menuItem3 = new System.Windows.Forms.MenuItem();
			this.menuItemLamMoi = new System.Windows.Forms.MenuItem();
			this.lbThongBao = new System.Windows.Forms.Label();
			this.tabControl1.SuspendLayout();
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
																						this.toolBarButton1,
																						this.toolBarButton2,
																						this.toolBarButton3,
																						this.toolBarButton4,
																						this.toolBarButton5,
																						this.toolBarButton6});
			this.toolBar1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.toolBar1.DropDownArrows = true;
			this.toolBar1.ImageList = this.imageList1;
			this.toolBar1.Location = new System.Drawing.Point(0, 0);
			this.toolBar1.Name = "toolBar1";
			this.toolBar1.ShowToolTips = true;
			this.toolBar1.Size = new System.Drawing.Size(984, 55);
			this.toolBar1.TabIndex = 0;
			// 
			// toolBarButton1
			// 
			this.toolBarButton1.ImageIndex = 22;
			this.toolBarButton1.Text = "Hệ thống";
			this.toolBarButton1.ToolTipText = "Hệ thống";
			// 
			// toolBarButton2
			// 
			this.toolBarButton2.ImageIndex = 27;
			this.toolBarButton2.Text = "Nhập danh sách";
			this.toolBarButton2.ToolTipText = "Nhập danh sách";
			// 
			// toolBarButton3
			// 
			this.toolBarButton3.ImageIndex = 26;
			this.toolBarButton3.Text = "Khai thác";
			this.toolBarButton3.ToolTipText = "Khai thác";
			// 
			// toolBarButton4
			// 
			this.toolBarButton4.ImageIndex = 21;
			this.toolBarButton4.Text = "Báo cáo ";
			this.toolBarButton4.ToolTipText = "Báo cáo";
			// 
			// toolBarButton5
			// 
			this.toolBarButton5.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			// 
			// toolBarButton6
			// 
			this.toolBarButton6.ImageIndex = 18;
			this.toolBarButton6.Text = "Bản quyền";
			this.toolBarButton6.ToolTipText = "Bản quyền";
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
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Controls.Add(this.tabPage3);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.Location = new System.Drawing.Point(0, 55);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(984, 644);
			this.tabControl1.TabIndex = 2;
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
			this.groupBox2.Controls.Add(this.rb_CT_Khong);
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
			this.groupBox2.Controls.Add(this.label10);
			this.groupBox2.Controls.Add(this.txtQuocTich);
			this.groupBox2.Controls.Add(this.label9);
			this.groupBox2.Controls.Add(this.label8);
			this.groupBox2.Controls.Add(this.label7);
			this.groupBox2.Controls.Add(this.txtTenVietTat);
			this.groupBox2.Controls.Add(this.txtHoTen);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.rb_CT_Co);
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
			// rb_CT_Khong
			// 
			this.rb_CT_Khong.Location = new System.Drawing.Point(464, 120);
			this.rb_CT_Khong.Name = "rb_CT_Khong";
			this.rb_CT_Khong.Size = new System.Drawing.Size(72, 24);
			this.rb_CT_Khong.TabIndex = 40;
			this.rb_CT_Khong.Text = "Không";
			// 
			// rbNu
			// 
			this.rbNu.Location = new System.Drawing.Point(464, 24);
			this.rbNu.Name = "rbNu";
			this.rbNu.Size = new System.Drawing.Size(56, 24);
			this.rbNu.TabIndex = 39;
			this.rbNu.Text = "Nữ";
			// 
			// rbNam
			// 
			this.rbNam.Location = new System.Drawing.Point(400, 24);
			this.rbNam.Name = "rbNam";
			this.rbNam.Size = new System.Drawing.Size(56, 24);
			this.rbNam.TabIndex = 38;
			this.rbNam.Text = "Nam";
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
			// label10
			// 
			this.label10.Location = new System.Drawing.Point(320, 120);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(72, 23);
			this.label10.TabIndex = 14;
			this.label10.Text = "Cư trú:";
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
			this.txtHoTen.Text = "textBox2";
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
			// rb_CT_Co
			// 
			this.rb_CT_Co.Location = new System.Drawing.Point(400, 120);
			this.rb_CT_Co.Name = "rb_CT_Co";
			this.rb_CT_Co.Size = new System.Drawing.Size(56, 24);
			this.rb_CT_Co.TabIndex = 38;
			this.rb_CT_Co.Text = "Có";
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
			this.panel3.Controls.Add(this.txtLamLai);
			this.panel3.Controls.Add(this.txtSuaKH);
			this.panel3.Controls.Add(this.label1);
			this.panel3.Controls.Add(this.btThemKH);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel3.Location = new System.Drawing.Point(0, 0);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(573, 48);
			this.panel3.TabIndex = 0;
			// 
			// txtLamLai
			// 
			this.txtLamLai.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.txtLamLai.BackColor = System.Drawing.SystemColors.ControlLight;
			this.txtLamLai.Cursor = System.Windows.Forms.Cursors.Hand;
			this.txtLamLai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.txtLamLai.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.txtLamLai.ImageIndex = 32;
			this.txtLamLai.ImageList = this.imageList1;
			this.txtLamLai.Location = new System.Drawing.Point(481, 8);
			this.txtLamLai.Name = "txtLamLai";
			this.txtLamLai.Size = new System.Drawing.Size(88, 32);
			this.txtLamLai.TabIndex = 4;
			this.txtLamLai.Text = "Làm lại";
			this.txtLamLai.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.txtLamLai.Click += new System.EventHandler(this.txtLamLai_Click);
			// 
			// txtSuaKH
			// 
			this.txtSuaKH.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.txtSuaKH.BackColor = System.Drawing.SystemColors.ControlLight;
			this.txtSuaKH.Cursor = System.Windows.Forms.Cursors.Hand;
			this.txtSuaKH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.txtSuaKH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.txtSuaKH.ImageIndex = 30;
			this.txtSuaKH.ImageList = this.imageList1;
			this.txtSuaKH.Location = new System.Drawing.Point(401, 8);
			this.txtSuaKH.Name = "txtSuaKH";
			this.txtSuaKH.Size = new System.Drawing.Size(72, 32);
			this.txtSuaKH.TabIndex = 3;
			this.txtSuaKH.Text = "Sửa";
			this.txtSuaKH.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.txtSuaKH.Click += new System.EventHandler(this.txtSuaKH_Click);
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
			this.panel18.Controls.Add(this.pictureBox9);
			this.panel18.Controls.Add(this.label28);
			this.panel18.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel18.DockPadding.All = 2;
			this.panel18.Location = new System.Drawing.Point(125, 0);
			this.panel18.Name = "panel18";
			this.panel18.Size = new System.Drawing.Size(125, 135);
			this.panel18.TabIndex = 5;
			// 
			// pictureBox9
			// 
			this.pictureBox9.Cursor = System.Windows.Forms.Cursors.SizeAll;
			this.pictureBox9.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBox9.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox9.Image")));
			this.pictureBox9.Location = new System.Drawing.Point(2, 2);
			this.pictureBox9.Name = "pictureBox9";
			this.pictureBox9.Size = new System.Drawing.Size(119, 106);
			this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox9.TabIndex = 2;
			this.pictureBox9.TabStop = false;
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
			this.panel19.Controls.Add(this.pictureBox10);
			this.panel19.Controls.Add(this.label29);
			this.panel19.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel19.DockPadding.All = 2;
			this.panel19.Location = new System.Drawing.Point(0, 0);
			this.panel19.Name = "panel19";
			this.panel19.Size = new System.Drawing.Size(125, 135);
			this.panel19.TabIndex = 4;
			// 
			// pictureBox10
			// 
			this.pictureBox10.Cursor = System.Windows.Forms.Cursors.SizeAll;
			this.pictureBox10.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBox10.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox10.Image")));
			this.pictureBox10.Location = new System.Drawing.Point(2, 2);
			this.pictureBox10.Name = "pictureBox10";
			this.pictureBox10.Size = new System.Drawing.Size(119, 106);
			this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox10.TabIndex = 2;
			this.pictureBox10.TabStop = false;
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
			this.panel13.Controls.Add(this.pictureBox5);
			this.panel13.Controls.Add(this.label24);
			this.panel13.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel13.DockPadding.All = 2;
			this.panel13.Location = new System.Drawing.Point(471, 0);
			this.panel13.Name = "panel13";
			this.panel13.Size = new System.Drawing.Size(125, 118);
			this.panel13.TabIndex = 5;
			// 
			// pictureBox5
			// 
			this.pictureBox5.Cursor = System.Windows.Forms.Cursors.SizeAll;
			this.pictureBox5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
			this.pictureBox5.Location = new System.Drawing.Point(2, 2);
			this.pictureBox5.Name = "pictureBox5";
			this.pictureBox5.Size = new System.Drawing.Size(119, 89);
			this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox5.TabIndex = 2;
			this.pictureBox5.TabStop = false;
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
			this.panel14.Controls.Add(this.pictureBox6);
			this.panel14.Controls.Add(this.label25);
			this.panel14.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel14.DockPadding.All = 2;
			this.panel14.Location = new System.Drawing.Point(346, 0);
			this.panel14.Name = "panel14";
			this.panel14.Size = new System.Drawing.Size(125, 118);
			this.panel14.TabIndex = 4;
			// 
			// pictureBox6
			// 
			this.pictureBox6.Cursor = System.Windows.Forms.Cursors.SizeAll;
			this.pictureBox6.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
			this.pictureBox6.Location = new System.Drawing.Point(2, 2);
			this.pictureBox6.Name = "pictureBox6";
			this.pictureBox6.Size = new System.Drawing.Size(119, 89);
			this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox6.TabIndex = 2;
			this.pictureBox6.TabStop = false;
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
			this.panel15.Controls.Add(this.pictureBox7);
			this.panel15.Controls.Add(this.label26);
			this.panel15.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel15.DockPadding.All = 2;
			this.panel15.Location = new System.Drawing.Point(173, 0);
			this.panel15.Name = "panel15";
			this.panel15.Size = new System.Drawing.Size(173, 118);
			this.panel15.TabIndex = 3;
			// 
			// pictureBox7
			// 
			this.pictureBox7.Cursor = System.Windows.Forms.Cursors.SizeAll;
			this.pictureBox7.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
			this.pictureBox7.Location = new System.Drawing.Point(2, 2);
			this.pictureBox7.Name = "pictureBox7";
			this.pictureBox7.Size = new System.Drawing.Size(167, 89);
			this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox7.TabIndex = 2;
			this.pictureBox7.TabStop = false;
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
			this.panel16.Controls.Add(this.pictureBox8);
			this.panel16.Controls.Add(this.label27);
			this.panel16.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel16.DockPadding.All = 2;
			this.panel16.Location = new System.Drawing.Point(0, 0);
			this.panel16.Name = "panel16";
			this.panel16.Size = new System.Drawing.Size(173, 118);
			this.panel16.TabIndex = 2;
			// 
			// pictureBox8
			// 
			this.pictureBox8.Cursor = System.Windows.Forms.Cursors.SizeAll;
			this.pictureBox8.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
			this.pictureBox8.Location = new System.Drawing.Point(2, 2);
			this.pictureBox8.Name = "pictureBox8";
			this.pictureBox8.Size = new System.Drawing.Size(167, 89);
			this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox8.TabIndex = 2;
			this.pictureBox8.TabStop = false;
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
			this.panel10.Controls.Add(this.pictureBox3);
			this.panel10.Controls.Add(this.label22);
			this.panel10.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel10.DockPadding.All = 2;
			this.panel10.Location = new System.Drawing.Point(471, 0);
			this.panel10.Name = "panel10";
			this.panel10.Size = new System.Drawing.Size(125, 118);
			this.panel10.TabIndex = 5;
			// 
			// pictureBox3
			// 
			this.pictureBox3.Cursor = System.Windows.Forms.Cursors.SizeAll;
			this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
			this.pictureBox3.Location = new System.Drawing.Point(2, 2);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(119, 89);
			this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox3.TabIndex = 2;
			this.pictureBox3.TabStop = false;
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
			this.panel11.Controls.Add(this.pictureBox4);
			this.panel11.Controls.Add(this.label23);
			this.panel11.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel11.DockPadding.All = 2;
			this.panel11.Location = new System.Drawing.Point(346, 0);
			this.panel11.Name = "panel11";
			this.panel11.Size = new System.Drawing.Size(125, 118);
			this.panel11.TabIndex = 4;
			// 
			// pictureBox4
			// 
			this.pictureBox4.Cursor = System.Windows.Forms.Cursors.SizeAll;
			this.pictureBox4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
			this.pictureBox4.Location = new System.Drawing.Point(2, 2);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(119, 89);
			this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox4.TabIndex = 2;
			this.pictureBox4.TabStop = false;
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
			this.panel9.Controls.Add(this.pictureBox2);
			this.panel9.Controls.Add(this.label21);
			this.panel9.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel9.DockPadding.All = 2;
			this.panel9.Location = new System.Drawing.Point(173, 0);
			this.panel9.Name = "panel9";
			this.panel9.Size = new System.Drawing.Size(173, 118);
			this.panel9.TabIndex = 3;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Cursor = System.Windows.Forms.Cursors.SizeAll;
			this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(2, 2);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(167, 89);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 2;
			this.pictureBox2.TabStop = false;
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
			this.panel7.Controls.Add(this.pictureBox1);
			this.panel7.Controls.Add(this.label20);
			this.panel7.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel7.DockPadding.All = 2;
			this.panel7.Location = new System.Drawing.Point(0, 0);
			this.panel7.Name = "panel7";
			this.panel7.Size = new System.Drawing.Size(173, 118);
			this.panel7.TabIndex = 2;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Cursor = System.Windows.Forms.Cursors.SizeAll;
			this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(2, 2);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(167, 89);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 2;
			this.pictureBox1.TabStop = false;
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
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Size = new System.Drawing.Size(976, 618);
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
			this.panel21.Size = new System.Drawing.Size(976, 370);
			this.panel21.TabIndex = 2;
			// 
			// dtgKhachHang
			// 
			this.dtgKhachHang.DataMember = "";
			this.dtgKhachHang.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dtgKhachHang.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dtgKhachHang.Location = new System.Drawing.Point(0, 0);
			this.dtgKhachHang.Name = "dtgKhachHang";
			this.dtgKhachHang.Size = new System.Drawing.Size(976, 370);
			this.dtgKhachHang.TabIndex = 0;
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
			this.groupBox10.Size = new System.Drawing.Size(180, 238);
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
			this.panel36.Size = new System.Drawing.Size(174, 113);
			this.panel36.TabIndex = 1;
			// 
			// panel38
			// 
			this.panel38.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel38.Controls.Add(this.pictureBox20);
			this.panel38.Controls.Add(this.label46);
			this.panel38.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel38.DockPadding.All = 2;
			this.panel38.Location = new System.Drawing.Point(0, 0);
			this.panel38.Name = "panel38";
			this.panel38.Size = new System.Drawing.Size(173, 113);
			this.panel38.TabIndex = 4;
			// 
			// pictureBox20
			// 
			this.pictureBox20.Cursor = System.Windows.Forms.Cursors.SizeAll;
			this.pictureBox20.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBox20.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox20.Image")));
			this.pictureBox20.Location = new System.Drawing.Point(2, 2);
			this.pictureBox20.Name = "pictureBox20";
			this.pictureBox20.Size = new System.Drawing.Size(167, 84);
			this.pictureBox20.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox20.TabIndex = 2;
			this.pictureBox20.TabStop = false;
			// 
			// label46
			// 
			this.label46.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.label46.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.label46.Location = new System.Drawing.Point(2, 86);
			this.label46.Name = "label46";
			this.label46.Size = new System.Drawing.Size(167, 23);
			this.label46.TabIndex = 0;
			this.label46.Text = "Ảnh sau";
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
			this.panel41.Controls.Add(this.pictureBox22);
			this.panel41.Controls.Add(this.label48);
			this.panel41.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel41.DockPadding.All = 2;
			this.panel41.Location = new System.Drawing.Point(0, 0);
			this.panel41.Name = "panel41";
			this.panel41.Size = new System.Drawing.Size(173, 100);
			this.panel41.TabIndex = 4;
			// 
			// pictureBox22
			// 
			this.pictureBox22.Cursor = System.Windows.Forms.Cursors.SizeAll;
			this.pictureBox22.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBox22.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox22.Image")));
			this.pictureBox22.Location = new System.Drawing.Point(2, 2);
			this.pictureBox22.Name = "pictureBox22";
			this.pictureBox22.Size = new System.Drawing.Size(167, 71);
			this.pictureBox22.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox22.TabIndex = 2;
			this.pictureBox22.TabStop = false;
			// 
			// label48
			// 
			this.label48.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.label48.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.label48.Location = new System.Drawing.Point(2, 73);
			this.label48.Name = "label48";
			this.label48.Size = new System.Drawing.Size(167, 23);
			this.label48.TabIndex = 0;
			this.label48.Text = "Ảnh sau";
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
			this.groupBox9.Size = new System.Drawing.Size(352, 238);
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
			this.panel30.Size = new System.Drawing.Size(346, 113);
			this.panel30.TabIndex = 1;
			// 
			// panel31
			// 
			this.panel31.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel31.Controls.Add(this.pictureBox15);
			this.panel31.Controls.Add(this.label41);
			this.panel31.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel31.DockPadding.All = 2;
			this.panel31.Location = new System.Drawing.Point(173, 0);
			this.panel31.Name = "panel31";
			this.panel31.Size = new System.Drawing.Size(173, 113);
			this.panel31.TabIndex = 5;
			// 
			// pictureBox15
			// 
			this.pictureBox15.Cursor = System.Windows.Forms.Cursors.SizeAll;
			this.pictureBox15.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBox15.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox15.Image")));
			this.pictureBox15.Location = new System.Drawing.Point(2, 2);
			this.pictureBox15.Name = "pictureBox15";
			this.pictureBox15.Size = new System.Drawing.Size(167, 84);
			this.pictureBox15.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox15.TabIndex = 2;
			this.pictureBox15.TabStop = false;
			// 
			// label41
			// 
			this.label41.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.label41.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.label41.Location = new System.Drawing.Point(2, 86);
			this.label41.Name = "label41";
			this.label41.Size = new System.Drawing.Size(167, 23);
			this.label41.TabIndex = 0;
			this.label41.Text = "Ảnh sau";
			this.label41.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel32
			// 
			this.panel32.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel32.Controls.Add(this.pictureBox16);
			this.panel32.Controls.Add(this.label42);
			this.panel32.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel32.DockPadding.All = 2;
			this.panel32.Location = new System.Drawing.Point(0, 0);
			this.panel32.Name = "panel32";
			this.panel32.Size = new System.Drawing.Size(173, 113);
			this.panel32.TabIndex = 4;
			// 
			// pictureBox16
			// 
			this.pictureBox16.Cursor = System.Windows.Forms.Cursors.SizeAll;
			this.pictureBox16.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBox16.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox16.Image")));
			this.pictureBox16.Location = new System.Drawing.Point(2, 2);
			this.pictureBox16.Name = "pictureBox16";
			this.pictureBox16.Size = new System.Drawing.Size(167, 84);
			this.pictureBox16.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox16.TabIndex = 2;
			this.pictureBox16.TabStop = false;
			// 
			// label42
			// 
			this.label42.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.label42.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.label42.Location = new System.Drawing.Point(2, 86);
			this.label42.Name = "label42";
			this.label42.Size = new System.Drawing.Size(167, 23);
			this.label42.TabIndex = 0;
			this.label42.Text = "Ảnh sau";
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
			this.panel34.Controls.Add(this.pictureBox17);
			this.panel34.Controls.Add(this.label43);
			this.panel34.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel34.DockPadding.All = 2;
			this.panel34.Location = new System.Drawing.Point(173, 0);
			this.panel34.Name = "panel34";
			this.panel34.Size = new System.Drawing.Size(173, 100);
			this.panel34.TabIndex = 5;
			// 
			// pictureBox17
			// 
			this.pictureBox17.Cursor = System.Windows.Forms.Cursors.SizeAll;
			this.pictureBox17.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBox17.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox17.Image")));
			this.pictureBox17.Location = new System.Drawing.Point(2, 2);
			this.pictureBox17.Name = "pictureBox17";
			this.pictureBox17.Size = new System.Drawing.Size(167, 71);
			this.pictureBox17.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox17.TabIndex = 2;
			this.pictureBox17.TabStop = false;
			// 
			// label43
			// 
			this.label43.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.label43.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.label43.Location = new System.Drawing.Point(2, 73);
			this.label43.Name = "label43";
			this.label43.Size = new System.Drawing.Size(167, 23);
			this.label43.TabIndex = 0;
			this.label43.Text = "Ảnh sau";
			this.label43.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel35
			// 
			this.panel35.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel35.Controls.Add(this.pictureBox18);
			this.panel35.Controls.Add(this.label44);
			this.panel35.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel35.DockPadding.All = 2;
			this.panel35.Location = new System.Drawing.Point(0, 0);
			this.panel35.Name = "panel35";
			this.panel35.Size = new System.Drawing.Size(173, 100);
			this.panel35.TabIndex = 4;
			// 
			// pictureBox18
			// 
			this.pictureBox18.Cursor = System.Windows.Forms.Cursors.SizeAll;
			this.pictureBox18.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBox18.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox18.Image")));
			this.pictureBox18.Location = new System.Drawing.Point(2, 2);
			this.pictureBox18.Name = "pictureBox18";
			this.pictureBox18.Size = new System.Drawing.Size(167, 71);
			this.pictureBox18.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox18.TabIndex = 2;
			this.pictureBox18.TabStop = false;
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
			this.groupBox8.Size = new System.Drawing.Size(352, 238);
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
			this.panel25.Size = new System.Drawing.Size(346, 113);
			this.panel25.TabIndex = 1;
			// 
			// panel29
			// 
			this.panel29.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel29.Controls.Add(this.pictureBox14);
			this.panel29.Controls.Add(this.label40);
			this.panel29.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel29.DockPadding.All = 2;
			this.panel29.Location = new System.Drawing.Point(173, 0);
			this.panel29.Name = "panel29";
			this.panel29.Size = new System.Drawing.Size(173, 113);
			this.panel29.TabIndex = 5;
			// 
			// pictureBox14
			// 
			this.pictureBox14.Cursor = System.Windows.Forms.Cursors.SizeAll;
			this.pictureBox14.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBox14.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox14.Image")));
			this.pictureBox14.Location = new System.Drawing.Point(2, 2);
			this.pictureBox14.Name = "pictureBox14";
			this.pictureBox14.Size = new System.Drawing.Size(167, 84);
			this.pictureBox14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox14.TabIndex = 2;
			this.pictureBox14.TabStop = false;
			// 
			// label40
			// 
			this.label40.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.label40.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.label40.Location = new System.Drawing.Point(2, 86);
			this.label40.Name = "label40";
			this.label40.Size = new System.Drawing.Size(167, 23);
			this.label40.TabIndex = 0;
			this.label40.Text = "Ảnh sau";
			this.label40.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel28
			// 
			this.panel28.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel28.Controls.Add(this.pictureBox13);
			this.panel28.Controls.Add(this.label39);
			this.panel28.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel28.DockPadding.All = 2;
			this.panel28.Location = new System.Drawing.Point(0, 0);
			this.panel28.Name = "panel28";
			this.panel28.Size = new System.Drawing.Size(173, 113);
			this.panel28.TabIndex = 4;
			// 
			// pictureBox13
			// 
			this.pictureBox13.Cursor = System.Windows.Forms.Cursors.SizeAll;
			this.pictureBox13.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBox13.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox13.Image")));
			this.pictureBox13.Location = new System.Drawing.Point(2, 2);
			this.pictureBox13.Name = "pictureBox13";
			this.pictureBox13.Size = new System.Drawing.Size(167, 84);
			this.pictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox13.TabIndex = 2;
			this.pictureBox13.TabStop = false;
			// 
			// label39
			// 
			this.label39.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.label39.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.label39.Location = new System.Drawing.Point(2, 86);
			this.label39.Name = "label39";
			this.label39.Size = new System.Drawing.Size(167, 23);
			this.label39.TabIndex = 0;
			this.label39.Text = "Ảnh sau";
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
			this.panel27.Controls.Add(this.pictureBox12);
			this.panel27.Controls.Add(this.label38);
			this.panel27.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel27.DockPadding.All = 2;
			this.panel27.Location = new System.Drawing.Point(173, 0);
			this.panel27.Name = "panel27";
			this.panel27.Size = new System.Drawing.Size(173, 100);
			this.panel27.TabIndex = 5;
			// 
			// pictureBox12
			// 
			this.pictureBox12.Cursor = System.Windows.Forms.Cursors.SizeAll;
			this.pictureBox12.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBox12.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox12.Image")));
			this.pictureBox12.Location = new System.Drawing.Point(2, 2);
			this.pictureBox12.Name = "pictureBox12";
			this.pictureBox12.Size = new System.Drawing.Size(167, 71);
			this.pictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox12.TabIndex = 2;
			this.pictureBox12.TabStop = false;
			// 
			// label38
			// 
			this.label38.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.label38.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.label38.Location = new System.Drawing.Point(2, 73);
			this.label38.Name = "label38";
			this.label38.Size = new System.Drawing.Size(167, 23);
			this.label38.TabIndex = 0;
			this.label38.Text = "Ảnh sau";
			this.label38.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel26
			// 
			this.panel26.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel26.Controls.Add(this.pictureBox11);
			this.panel26.Controls.Add(this.label37);
			this.panel26.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel26.DockPadding.All = 2;
			this.panel26.Location = new System.Drawing.Point(0, 0);
			this.panel26.Name = "panel26";
			this.panel26.Size = new System.Drawing.Size(173, 100);
			this.panel26.TabIndex = 4;
			// 
			// pictureBox11
			// 
			this.pictureBox11.Cursor = System.Windows.Forms.Cursors.SizeAll;
			this.pictureBox11.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBox11.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox11.Image")));
			this.pictureBox11.Location = new System.Drawing.Point(2, 2);
			this.pictureBox11.Name = "pictureBox11";
			this.pictureBox11.Size = new System.Drawing.Size(167, 71);
			this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox11.TabIndex = 2;
			this.pictureBox11.TabStop = false;
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
			this.panel22.Controls.Add(this.button1);
			this.panel22.Controls.Add(this.label47);
			this.panel22.Controls.Add(this.textBox4);
			this.panel22.Controls.Add(this.label45);
			this.panel22.Controls.Add(this.textBox3);
			this.panel22.Controls.Add(this.label36);
			this.panel22.Controls.Add(this.textBox2);
			this.panel22.Controls.Add(this.label35);
			this.panel22.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel22.Location = new System.Drawing.Point(0, 0);
			this.panel22.Name = "panel22";
			this.panel22.Size = new System.Drawing.Size(280, 240);
			this.panel22.TabIndex = 0;
			// 
			// button1
			// 
			this.button1.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.button1.BackColor = System.Drawing.SystemColors.ControlLight;
			this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button1.ImageIndex = 31;
			this.button1.ImageList = this.imageList1;
			this.button1.Location = new System.Drawing.Point(96, 152);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(104, 32);
			this.button1.TabIndex = 9;
			this.button1.Text = "Tìm kiếm";
			this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(95, 104);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(176, 26);
			this.textBox4.TabIndex = 5;
			this.textBox4.Text = "textBox4";
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
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(96, 72);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(176, 26);
			this.textBox3.TabIndex = 3;
			this.textBox3.Text = "textBox3";
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
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(96, 40);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(176, 26);
			this.textBox2.TabIndex = 1;
			this.textBox2.Text = "textBox2";
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
			this.tabPage3.Location = new System.Drawing.Point(4, 22);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Size = new System.Drawing.Size(976, 618);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "Báo cáo ";
			this.tabPage3.Visible = false;
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// contextMenuGrid
			// 
			this.contextMenuGrid.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																							this.menuItemThem,
																							this.menuItemSua,
																							this.menuItem3,
																							this.menuItemLamMoi});
			// 
			// menuItemThem
			// 
			this.menuItemThem.Index = 0;
			this.menuItemThem.Text = "Thêm khách hàng";
			this.menuItemThem.Click += new System.EventHandler(this.menuItemThem_Click);
			// 
			// menuItemSua
			// 
			this.menuItemSua.Index = 1;
			this.menuItemSua.Text = "Sửa thông tin";
			this.menuItemSua.Click += new System.EventHandler(this.menuItemSua_Click);
			// 
			// menuItem3
			// 
			this.menuItem3.Index = 2;
			this.menuItem3.Text = "-";
			// 
			// menuItemLamMoi
			// 
			this.menuItemLamMoi.Index = 3;
			this.menuItemLamMoi.Text = "Làm mới dữ liệu";
			this.menuItemLamMoi.Click += new System.EventHandler(this.menuItemLamMoi_Click);
			// 
			// lbThongBao
			// 
			this.lbThongBao.Location = new System.Drawing.Point(528, 16);
			this.lbThongBao.Name = "lbThongBao";
			this.lbThongBao.TabIndex = 3;
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(7, 19);
			this.ClientSize = new System.Drawing.Size(984, 721);
			this.Controls.Add(this.lbThongBao);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.statusBar1);
			this.Controls.Add(this.toolBar1);
			this.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Form1";
			this.Text = "Form1";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.Form1_Load);
			this.tabControl1.ResumeLayout(false);
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
			this.pictureBox1.Click+=new EventHandler(ZoomImage);
			this.pictureBox2.Click+=new EventHandler(ZoomImage);
			this.pictureBox3.Click+=new EventHandler(ZoomImage); 			this.pictureBox4.Click+=new EventHandler(ZoomImage); 			this.pictureBox5.Click+=new EventHandler(ZoomImage); 			this.pictureBox6.Click+=new EventHandler(ZoomImage); 			this.pictureBox7.Click+=new EventHandler(ZoomImage); 			this.pictureBox8.Click+=new EventHandler(ZoomImage); 			this.pictureBox9.Click+=new EventHandler(ZoomImage); 			this.pictureBox10.Click+=new EventHandler(ZoomImage); 			this.pictureBox11.Click+=new EventHandler(ZoomImage); 			this.pictureBox12.Click+=new EventHandler(ZoomImage);
			this.pictureBox13.Click+=new EventHandler(ZoomImage);
			this.pictureBox14.Click+=new EventHandler(ZoomImage); 			this.pictureBox15.Click+=new EventHandler(ZoomImage); 			this.pictureBox16.Click+=new EventHandler(ZoomImage); 			this.pictureBox17.Click+=new EventHandler(ZoomImage); 			this.pictureBox18.Click+=new EventHandler(ZoomImage); 			this.pictureBox22.Click+=new EventHandler(ZoomImage); 			this.pictureBox20.Click+=new EventHandler(ZoomImage);	 			LoadFormData(); 			dtgKhachHang.ContextMenu = contextMenuGrid; 		}  		clsBusPersonal bus = new clsBusPersonal(); 		private void LoadFormData() 		{			 			SetMessage("",false); 			//string strConn = "Provider=SQLOLEDB.1;Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=HRM_CHECKER;Data Source=QUYDA-PC;Use Procedure for Prepare=1;Auto Translate=True;Packet Size=4096;Workstation ID=QUYDA-PC;Use Encryption for Data=False;Tag with column collation when possible=False"; 			//string strConn = "Server=QUYDA-PC;Database=HRM_CHECKER;Trusted_Connection=True"; 			//SqlConnection conn = new SqlConnection(strConn);			 			//SqlDataReader reader =  SqlHelper.ExecuteReader(conn,CommandType.Text,"Select * from tblKhachHang"); 			//DataSet ds = SqlHelper.ExecuteDataset(conn,CommandType.Text,"Select * from tblKhachHang"); 			DataSet ds = bus.LoadPersonal(); 			if(ds!=null) 			{ 				dtgKhachHang.DataSource = ds.Tables[0]; 			} 			else 			{ 				SetMessage("Có lỗi trong quá trình truy vấn dữ liệu!",true); 			} 			  		}

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
		
		}

		private void txtSuaKH_Click(object sender, System.EventArgs e)
		{
		
		}

		private void txtLamLai_Click(object sender, System.EventArgs e)
		{
		
		}

		private void menuItemThem_Click(object sender, System.EventArgs e)
		{
			tabControl1.SelectedIndex = 0;
		}

		private void menuItemSua_Click(object sender, System.EventArgs e)
		{
		
		}

		private void menuItemLamMoi_Click(object sender, System.EventArgs e)
		{
		
		} 	} } 
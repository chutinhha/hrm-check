using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace HRM_CHECKER
{
	/// <summary>
	/// Summary description for frmScan
	/// </summary>
	public class frmScan : System.Windows.Forms.Form
	{
		public Image IDBefore = null;
		public Image IDAfter = null;
		public Image FP1 = null;
		public Image FP2 = null;
		public int SelectIndex = 0;
		public Boolean Edit = false;

		string mt = Application.StartupPath + @"\ScanSelect\MT.jpg";
		string ms = Application.StartupPath + @"\ScanSelect\MS.jpg";
		string ScanPath = Application.StartupPath + @"\Scan";

		bool Loading = false;
		bool Killing = false;
		Image FileSelected = null;
		FileInfo[] fileArray;
		long fileCreateLong = 0;
		//
		int FP1_Width = 270;
		int FP1_Height = 200;
		int FP1_X = 25;
		int FP1_Y = 105;
		//
		int FP2_Width = 290;
		int FP2_Height = 220;
		int FP2_X = 30;
		int FP2_Y = 340;

		private System.Windows.Forms.Panel pnControl;
		private System.Windows.Forms.Panel pnMain;
		private System.Windows.Forms.Button btnEnter;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.PictureBox picBefore;
		private System.Windows.Forms.PictureBox picAfter;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.PictureBox picIMG1;
		private System.Windows.Forms.PictureBox picIMG2;
		private System.Windows.Forms.PictureBox picIMG3;
		private System.Windows.Forms.PictureBox picIMG4;
		private System.Windows.Forms.PictureBox picFP1;
		private System.Windows.Forms.PictureBox picFP2;
		private System.Windows.Forms.Timer timerLoadIMG;
		private System.Windows.Forms.LinkLabel lkF5;
		private System.Windows.Forms.LinkLabel lkF6;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.LinkLabel lkNoneBefore;
		private System.Windows.Forms.LinkLabel lkNoneAfter;
		private System.Windows.Forms.Timer timerClosePaint;
		private System.Windows.Forms.Panel pnFP2;
		private System.Windows.Forms.Panel pnFP1;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Button btnScan;
		private System.Windows.Forms.Timer timerScan;
		private System.Windows.Forms.CheckBox ckbMT;
		private System.Windows.Forms.CheckBox ckbMS;
		private System.ComponentModel.IContainer components;

		public frmScan()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmScan));
			this.pnControl = new System.Windows.Forms.Panel();
			this.ckbMT = new System.Windows.Forms.CheckBox();
			this.btnEnter = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnScan = new System.Windows.Forms.Button();
			this.ckbMS = new System.Windows.Forms.CheckBox();
			this.pnMain = new System.Windows.Forms.Panel();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.pnFP2 = new System.Windows.Forms.Panel();
			this.pnFP1 = new System.Windows.Forms.Panel();
			this.lkNoneAfter = new System.Windows.Forms.LinkLabel();
			this.lkNoneBefore = new System.Windows.Forms.LinkLabel();
			this.lkF6 = new System.Windows.Forms.LinkLabel();
			this.lkF5 = new System.Windows.Forms.LinkLabel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.picIMG4 = new System.Windows.Forms.PictureBox();
			this.picIMG3 = new System.Windows.Forms.PictureBox();
			this.picIMG1 = new System.Windows.Forms.PictureBox();
			this.picIMG2 = new System.Windows.Forms.PictureBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.picAfter = new System.Windows.Forms.PictureBox();
			this.picBefore = new System.Windows.Forms.PictureBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.picFP1 = new System.Windows.Forms.PictureBox();
			this.picFP2 = new System.Windows.Forms.PictureBox();
			this.timerLoadIMG = new System.Windows.Forms.Timer(this.components);
			this.timerClosePaint = new System.Windows.Forms.Timer(this.components);
			this.timerScan = new System.Windows.Forms.Timer(this.components);
			this.pnControl.SuspendLayout();
			this.pnMain.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnControl
			// 
			this.pnControl.BackColor = System.Drawing.SystemColors.Control;
			this.pnControl.Controls.Add(this.ckbMT);
			this.pnControl.Controls.Add(this.btnEnter);
			this.pnControl.Controls.Add(this.btnDelete);
			this.pnControl.Controls.Add(this.btnScan);
			this.pnControl.Controls.Add(this.ckbMS);
			this.pnControl.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnControl.Location = new System.Drawing.Point(0, 0);
			this.pnControl.Name = "pnControl";
			this.pnControl.Size = new System.Drawing.Size(904, 72);
			this.pnControl.TabIndex = 0;
			// 
			// ckbMT
			// 
			this.ckbMT.Checked = true;
			this.ckbMT.CheckState = System.Windows.Forms.CheckState.Checked;
			this.ckbMT.Location = new System.Drawing.Point(752, 16);
			this.ckbMT.Name = "ckbMT";
			this.ckbMT.Size = new System.Drawing.Size(48, 16);
			this.ckbMT.TabIndex = 3;
			this.ckbMT.Text = "MT";
			this.ckbMT.CheckedChanged += new System.EventHandler(this.ckbMT_CheckedChanged);
			// 
			// btnEnter
			// 
			this.btnEnter.Image = ((System.Drawing.Image)(resources.GetObject("btnEnter.Image")));
			this.btnEnter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnEnter.Location = new System.Drawing.Point(8, 8);
			this.btnEnter.Name = "btnEnter";
			this.btnEnter.Size = new System.Drawing.Size(88, 56);
			this.btnEnter.TabIndex = 0;
			this.btnEnter.Text = "Enter";
			this.btnEnter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
			this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnDelete.Location = new System.Drawing.Point(104, 8);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(80, 56);
			this.btnDelete.TabIndex = 0;
			this.btnDelete.Text = "Delete";
			this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnScan
			// 
			this.btnScan.Image = ((System.Drawing.Image)(resources.GetObject("btnScan.Image")));
			this.btnScan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnScan.Location = new System.Drawing.Point(808, 8);
			this.btnScan.Name = "btnScan";
			this.btnScan.Size = new System.Drawing.Size(88, 56);
			this.btnScan.TabIndex = 2;
			this.btnScan.Text = "Scan";
			this.btnScan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnScan.Click += new System.EventHandler(this.btnScan_Click);
			// 
			// ckbMS
			// 
			this.ckbMS.Checked = true;
			this.ckbMS.CheckState = System.Windows.Forms.CheckState.Checked;
			this.ckbMS.Location = new System.Drawing.Point(752, 40);
			this.ckbMS.Name = "ckbMS";
			this.ckbMS.Size = new System.Drawing.Size(48, 16);
			this.ckbMS.TabIndex = 3;
			this.ckbMS.Text = "MS";
			this.ckbMS.CheckedChanged += new System.EventHandler(this.ckbMS_CheckedChanged);
			// 
			// pnMain
			// 
			this.pnMain.BackColor = System.Drawing.Color.White;
			this.pnMain.Controls.Add(this.label10);
			this.pnMain.Controls.Add(this.label11);
			this.pnMain.Controls.Add(this.pnFP2);
			this.pnMain.Controls.Add(this.pnFP1);
			this.pnMain.Controls.Add(this.lkNoneAfter);
			this.pnMain.Controls.Add(this.lkNoneBefore);
			this.pnMain.Controls.Add(this.lkF6);
			this.pnMain.Controls.Add(this.lkF5);
			this.pnMain.Controls.Add(this.panel1);
			this.pnMain.Controls.Add(this.label2);
			this.pnMain.Controls.Add(this.label1);
			this.pnMain.Controls.Add(this.picAfter);
			this.pnMain.Controls.Add(this.picBefore);
			this.pnMain.Controls.Add(this.label3);
			this.pnMain.Controls.Add(this.label4);
			this.pnMain.Controls.Add(this.label5);
			this.pnMain.Controls.Add(this.picFP1);
			this.pnMain.Controls.Add(this.picFP2);
			this.pnMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnMain.Location = new System.Drawing.Point(0, 72);
			this.pnMain.Name = "pnMain";
			this.pnMain.Size = new System.Drawing.Size(904, 562);
			this.pnMain.TabIndex = 1;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.BackColor = System.Drawing.Color.Yellow;
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label10.Location = new System.Drawing.Point(800, 280);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(18, 16);
			this.label10.TabIndex = 16;
			this.label10.Text = "F8";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.BackColor = System.Drawing.Color.Yellow;
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label11.Location = new System.Drawing.Point(616, 280);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(18, 16);
			this.label11.TabIndex = 15;
			this.label11.Text = "F7";
			this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// pnFP2
			// 
			this.pnFP2.Location = new System.Drawing.Point(640, 288);
			this.pnFP2.Name = "pnFP2";
			this.pnFP2.Size = new System.Drawing.Size(176, 8);
			this.pnFP2.TabIndex = 14;
			// 
			// pnFP1
			// 
			this.pnFP1.Location = new System.Drawing.Point(456, 288);
			this.pnFP1.Name = "pnFP1";
			this.pnFP1.Size = new System.Drawing.Size(168, 8);
			this.pnFP1.TabIndex = 13;
			// 
			// lkNoneAfter
			// 
			this.lkNoneAfter.AutoSize = true;
			this.lkNoneAfter.Location = new System.Drawing.Point(872, 288);
			this.lkNoneAfter.Name = "lkNoneAfter";
			this.lkNoneAfter.Size = new System.Drawing.Size(24, 16);
			this.lkNoneAfter.TabIndex = 9;
			this.lkNoneAfter.TabStop = true;
			this.lkNoneAfter.Text = "Null";
			this.lkNoneAfter.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lkNoneAfter_LinkClicked);
			// 
			// lkNoneBefore
			// 
			this.lkNoneBefore.AutoSize = true;
			this.lkNoneBefore.Location = new System.Drawing.Point(424, 288);
			this.lkNoneBefore.Name = "lkNoneBefore";
			this.lkNoneBefore.Size = new System.Drawing.Size(24, 16);
			this.lkNoneBefore.TabIndex = 8;
			this.lkNoneBefore.TabStop = true;
			this.lkNoneBefore.Text = "Null";
			this.lkNoneBefore.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lkNoneBefore_LinkClicked);
			// 
			// lkF6
			// 
			this.lkF6.AutoSize = true;
			this.lkF6.Location = new System.Drawing.Point(824, 312);
			this.lkF6.Name = "lkF6";
			this.lkF6.Size = new System.Drawing.Size(75, 16);
			this.lkF6.TabIndex = 7;
			this.lkF6.TabStop = true;
			this.lkF6.Text = "Select up (F6)";
			this.lkF6.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lkF6_LinkClicked);
			// 
			// lkF5
			// 
			this.lkF5.AutoSize = true;
			this.lkF5.Location = new System.Drawing.Point(376, 312);
			this.lkF5.Name = "lkF5";
			this.lkF5.Size = new System.Drawing.Size(75, 16);
			this.lkF5.TabIndex = 6;
			this.lkF5.TabStop = true;
			this.lkF5.Text = "Select up (F5)";
			this.lkF5.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lkF5_LinkClicked);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.Control;
			this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
			this.panel1.Controls.Add(this.label9);
			this.panel1.Controls.Add(this.label8);
			this.panel1.Controls.Add(this.label7);
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.picIMG4);
			this.panel1.Controls.Add(this.picIMG3);
			this.panel1.Controls.Add(this.picIMG1);
			this.panel1.Controls.Add(this.picIMG2);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new System.Drawing.Point(0, 426);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(904, 136);
			this.panel1.TabIndex = 5;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.BackColor = System.Drawing.Color.Yellow;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label9.Location = new System.Drawing.Point(256, 104);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(18, 16);
			this.label9.TabIndex = 10;
			this.label9.Text = "F4";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.BackColor = System.Drawing.Color.Yellow;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label8.Location = new System.Drawing.Point(424, 104);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(18, 16);
			this.label8.TabIndex = 9;
			this.label8.Text = "F3";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.BackColor = System.Drawing.Color.Yellow;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label7.Location = new System.Drawing.Point(592, 104);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(18, 16);
			this.label7.TabIndex = 8;
			this.label7.Text = "F2";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.BackColor = System.Drawing.Color.Yellow;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label6.Location = new System.Drawing.Point(760, 104);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(18, 16);
			this.label6.TabIndex = 7;
			this.label6.Text = "F1";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// picIMG4
			// 
			this.picIMG4.BackColor = System.Drawing.SystemColors.Control;
			this.picIMG4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.picIMG4.Location = new System.Drawing.Point(120, 8);
			this.picIMG4.Name = "picIMG4";
			this.picIMG4.Size = new System.Drawing.Size(160, 120);
			this.picIMG4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picIMG4.TabIndex = 6;
			this.picIMG4.TabStop = false;
			this.picIMG4.Click += new System.EventHandler(this.picIMG4_Click);
			// 
			// picIMG3
			// 
			this.picIMG3.BackColor = System.Drawing.SystemColors.Control;
			this.picIMG3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.picIMG3.Location = new System.Drawing.Point(288, 8);
			this.picIMG3.Name = "picIMG3";
			this.picIMG3.Size = new System.Drawing.Size(160, 120);
			this.picIMG3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picIMG3.TabIndex = 5;
			this.picIMG3.TabStop = false;
			this.picIMG3.Click += new System.EventHandler(this.picIMG3_Click);
			// 
			// picIMG1
			// 
			this.picIMG1.BackColor = System.Drawing.SystemColors.Control;
			this.picIMG1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.picIMG1.Location = new System.Drawing.Point(624, 8);
			this.picIMG1.Name = "picIMG1";
			this.picIMG1.Size = new System.Drawing.Size(160, 120);
			this.picIMG1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picIMG1.TabIndex = 5;
			this.picIMG1.TabStop = false;
			this.picIMG1.Click += new System.EventHandler(this.picIMG1_Click);
			// 
			// picIMG2
			// 
			this.picIMG2.BackColor = System.Drawing.SystemColors.Control;
			this.picIMG2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.picIMG2.Location = new System.Drawing.Point(456, 8);
			this.picIMG2.Name = "picIMG2";
			this.picIMG2.Size = new System.Drawing.Size(160, 120);
			this.picIMG2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picIMG2.TabIndex = 6;
			this.picIMG2.TabStop = false;
			this.picIMG2.Click += new System.EventHandler(this.picIMG2_Click);
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label2.Location = new System.Drawing.Point(16, 320);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(432, 16);
			this.label2.TabIndex = 3;
			this.label2.Text = "Nguyen Thanh Thuy";
			this.label2.Visible = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(16, 296);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(116, 16);
			this.label1.TabIndex = 2;
			this.label1.Text = "Them anh CMND cho:";
			this.label1.Visible = false;
			// 
			// picAfter
			// 
			this.picAfter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picAfter.BackgroundImage")));
			this.picAfter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.picAfter.Location = new System.Drawing.Point(456, 8);
			this.picAfter.Name = "picAfter";
			this.picAfter.Size = new System.Drawing.Size(440, 272);
			this.picAfter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picAfter.TabIndex = 1;
			this.picAfter.TabStop = false;
			this.picAfter.Click += new System.EventHandler(this.picAfter_Click);
			// 
			// picBefore
			// 
			this.picBefore.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picBefore.BackgroundImage")));
			this.picBefore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.picBefore.Location = new System.Drawing.Point(8, 8);
			this.picBefore.Name = "picBefore";
			this.picBefore.Size = new System.Drawing.Size(440, 272);
			this.picBefore.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picBefore.TabIndex = 0;
			this.picBefore.TabStop = false;
			this.picBefore.Click += new System.EventHandler(this.picBefore_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(16, 344);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(62, 16);
			this.label3.TabIndex = 3;
			this.label3.Text = "20-11-1989";
			this.label3.Visible = false;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(96, 344);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(158, 16);
			this.label4.TabIndex = 3;
			this.label4.Text = "Hoang Dieu, Tu Loc, Hai Duon";
			this.label4.Visible = false;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label5.Location = new System.Drawing.Point(136, 296);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(63, 16);
			this.label5.TabIndex = 3;
			this.label5.Text = "145565445";
			this.label5.Visible = false;
			// 
			// picFP1
			// 
			this.picFP1.BackColor = System.Drawing.SystemColors.Control;
			this.picFP1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picFP1.BackgroundImage")));
			this.picFP1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.picFP1.Location = new System.Drawing.Point(456, 296);
			this.picFP1.Name = "picFP1";
			this.picFP1.Size = new System.Drawing.Size(176, 120);
			this.picFP1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picFP1.TabIndex = 4;
			this.picFP1.TabStop = false;
			this.picFP1.Click += new System.EventHandler(this.picFP1_Click);
			// 
			// picFP2
			// 
			this.picFP2.BackColor = System.Drawing.SystemColors.Control;
			this.picFP2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picFP2.BackgroundImage")));
			this.picFP2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.picFP2.Location = new System.Drawing.Point(640, 296);
			this.picFP2.Name = "picFP2";
			this.picFP2.Size = new System.Drawing.Size(176, 120);
			this.picFP2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picFP2.TabIndex = 4;
			this.picFP2.TabStop = false;
			this.picFP2.Click += new System.EventHandler(this.picFP2_Click);
			// 
			// timerLoadIMG
			// 
			this.timerLoadIMG.Enabled = true;
			this.timerLoadIMG.Interval = 1000;
			this.timerLoadIMG.Tick += new System.EventHandler(this.timerLoadIMG_Tick);
			// 
			// timerClosePaint
			// 
			this.timerClosePaint.Enabled = true;
			this.timerClosePaint.Interval = 500;
			this.timerClosePaint.Tick += new System.EventHandler(this.timerClosePaint_Tick);
			// 
			// timerScan
			// 
			this.timerScan.Interval = 1000;
			this.timerScan.Tick += new System.EventHandler(this.timerScan_Tick);
			// 
			// frmScan
			// 
			this.AcceptButton = this.btnEnter;
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(904, 634);
			this.Controls.Add(this.pnMain);
			this.Controls.Add(this.pnControl);
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.Name = "frmScan";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frmScan";
			this.Load += new System.EventHandler(this.frmScan_Load);
			this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmScan_KeyUp);
			this.pnControl.ResumeLayout(false);
			this.pnMain.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion
		private void timerLoadIMG_Tick(object sender, System.EventArgs e)
		{
			if(Loading == false)
			{
				Loading = true;
				timerLoadIMG.Enabled = false;
				try
				{
					string[] filePaths = Directory.GetFiles(ScanPath);
					if(filePaths.Length > 0)
					{
						fileArray = new FileInfo[filePaths.Length];
						for(int i= 0; i < filePaths.Length; i ++)
						{
							fileArray[i]= new FileInfo(filePaths[i]);
						}

						ArraySort(ref fileArray);

						long fileCreate_Temp_Long = long.Parse(fileArray[0].CreationTimeUtc.ToString("yyyyMMddHHmmssff"));
						if(fileCreate_Temp_Long > fileCreateLong)
						{
							fileCreateLong = fileCreate_Temp_Long;
							for(int i= 0; i < fileArray.Length; i ++)
							{
								if(i == 0)
								{
									try
									{
										using (System.IO.FileStream fs = new System.IO.FileStream(fileArray[i].FullName, FileMode.Open))
										{
											Bitmap bmp = new Bitmap(fs);
											picIMG1.Image = (Bitmap)bmp.Clone();
										}
									}
									catch{}
								}
								else if(i == 1)
								{
									try
									{
										using (System.IO.FileStream fs = new System.IO.FileStream(fileArray[i].FullName, FileMode.Open))
										{
											Bitmap bmp = new Bitmap(fs);
											picIMG2.Image = (Bitmap)bmp.Clone();
										}
									}
									catch{}
								}
								else if(i == 2)
								{
									try
									{
										using (System.IO.FileStream fs = new System.IO.FileStream(fileArray[i].FullName, FileMode.Open))
										{
											Bitmap bmp = new Bitmap(fs);
											picIMG3.Image = (Bitmap)bmp.Clone();
										}
									}
									catch{}
								}
								else if(i == 3)
								{
									try
									{
										using (System.IO.FileStream fs = new System.IO.FileStream(fileArray[i].FullName, FileMode.Open))
										{
											Bitmap bmp = new Bitmap(fs);
											picIMG4.Image = (Bitmap)bmp.Clone();
										}
									}
									catch{}
								}
								else if(i > 29)
								{
									try
									{
										File.Delete(fileArray[i].FullName);
									}
									catch{ }
								}
							}
							SetFileSelected(1);
							picIMG1.BorderStyle = BorderStyle.Fixed3D;
							Application.DoEvents();
						}
					}
					
				}
				catch{}
				timerLoadIMG.Enabled = true;
				Loading = false;
			}
		}

		private void timerClosePaint_Tick(object sender, System.EventArgs e)
		{
			try
			{
				if(Killing == false)
				{
					Killing = true;
					KillPaint();
					Killing = false;
				}
			}
			catch{}
		}

		private void ArraySort(ref FileInfo[] files)
		{
			for (int i = 0; i < files.Length; i++)
			{
				for (int j = i + 1; j < files.Length; j++)
				{
					if (j <= files.Length - 1)
					{
						if (files[i].CreationTimeUtc < files[j].CreationTimeUtc)
						{
							FileInfo temp = files[i];
							files[i] = files[j];
							files[j] = temp;
						}
					}
				}
			}
		}

		private void frmScan_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (e.KeyCode == Keys.F1)
			{
				SetFileSelected(1);
				return;
			}
			if (e.KeyCode == Keys.F2)
			{
				SetFileSelected(2);
				return;
			}
			if (e.KeyCode == Keys.F3)
			{
				SetFileSelected(3);
				return;
			}
			if (e.KeyCode == Keys.F4)
			{
				SetFileSelected(4);
				return;
			}
			if (e.KeyCode == Keys.F5)
			{
				if(FileSelected != null)
				{
					picBefore.Image = FileSelected;
					picIDSelect(0);
				}
				return;
			}
			if (e.KeyCode == Keys.F6)
			{
				if(FileSelected != null)
				{
					picAfter.Image = FileSelected;
					picIDSelect(1);
					GetFP(1, FP1_Width, FP1_Height, FP1_X, FP1_Y);
					GetFP(2, FP2_Width, FP2_Height, FP2_X, FP2_Y);
					picFP1_Click(sender, e);
				}
				return;
			}
	
			if (e.KeyCode == Keys.F7)
			{
				if(pnFP1.BackColor == Color.White)
				{
					pnFP1.BackColor = Color.Blue;
					pnFP2.BackColor = Color.White;
				}
			}
			if (e.KeyCode == Keys.F8)
			{
				if(pnFP2.BackColor == Color.White)
				{
					pnFP1.BackColor = Color.White;
					pnFP2.BackColor = Color.Blue;
				}
			}

			if (e.KeyCode == Keys.Delete)
			{
				DeleteImage();
				return;
			}
			if(e.KeyCode == Keys.Left)
			{
				if(pnFP1.BackColor == Color.Blue)
				{
					FP1_X -=10;
					GetFP(1, FP1_Width, FP1_Height, FP1_X, FP1_Y);
				}
				if(pnFP2.BackColor == Color.Blue)
				{
					FP2_X -=10;
					GetFP(2, FP2_Width, FP2_Height, FP2_X, FP2_Y);
				}
			}
			if(e.KeyCode == Keys.Right)
			{
				if(pnFP1.BackColor == Color.Blue)
				{
					FP1_X +=10;
					GetFP(1, FP1_Width, FP1_Height, FP1_X, FP1_Y);
				}
				if(pnFP2.BackColor == Color.Blue)
				{
					FP2_X +=10;
					GetFP(2, FP2_Width, FP2_Height, FP2_X, FP2_Y);
				}
			}
			if(e.KeyCode == Keys.Up)
			{
				if(pnFP1.BackColor == Color.Blue)
				{
					FP1_Y -=10;
					GetFP(1, FP1_Width, FP1_Height, FP1_X, FP1_Y);
				}
				if(pnFP2.BackColor == Color.Blue)
				{
					FP2_Y -=10;
					GetFP(2, FP2_Width, FP2_Height, FP2_X, FP2_Y);
				}
			}
			if(e.KeyCode == Keys.Down)
			{
				if(pnFP1.BackColor == Color.Blue)
				{
					FP1_Y +=10;
					GetFP(1, FP1_Width, FP1_Height, FP1_X, FP1_Y);
				}
				if(pnFP2.BackColor == Color.Blue)
				{
					FP2_Y +=10;
					GetFP(2, FP2_Width, FP2_Height, FP2_X, FP2_Y);
				}
			}
			if(e.KeyCode == Keys.PageUp)
			{
				if(pnFP1.BackColor == Color.Blue)
				{
					FP1_X +=5;
					FP1_Y += 5;
					FP1_Width -=10;
					FP1_Height -= 10;
					GetFP(1, FP1_Width, FP1_Height, FP1_X, FP1_Y);
				}
				if(pnFP2.BackColor == Color.Blue)
				{
					FP2_X +=5;
					FP2_Y += 5;
					FP2_Width -=10;
					FP2_Height -= 10;
					GetFP(2, FP2_Width, FP2_Height, FP2_X, FP2_Y);
				}
			}
			if(e.KeyCode == Keys.PageDown)
			{
				if(pnFP1.BackColor == Color.Blue)
				{
					FP1_X -=5;
					FP1_Y -= 5;
					FP1_Width +=10;
					FP1_Height += 10;
					GetFP(1, FP1_Width, FP1_Height, FP1_X, FP1_Y);
				}
				if(pnFP2.BackColor == Color.Blue)
				{
					FP2_X -=5;
					FP2_Y -= 5;
					FP2_Width +=10;
					FP2_Height += 10;
					GetFP(2, FP2_Width, FP2_Height, FP2_X, FP2_Y);
				}
			}
			
			if(e.KeyCode == Keys.F9)
			{
				btnScan_Click(sender, e);
			}				
		}

		private void GetFP(int fpIndex, int XwidthThird, int XheightThird, int FP1_X, int FP1_Y)
		{
			if(picAfter.Image != null)
			{
				Image img = picAfter.Image;
				int widthThird = XwidthThird;
				int heightThird = XheightThird;
				Bitmap bmps = new Bitmap(widthThird, heightThird);
				Graphics g = Graphics.FromImage(bmps);
				g.DrawImage(img, new Rectangle(0, 0, XwidthThird, XheightThird), new Rectangle(FP1_X, FP1_Y, XwidthThird, XheightThird), GraphicsUnit.Pixel);
				g.Dispose();
				if(fpIndex == 1)
				{
					picFP1.Image = bmps;
				}
				else
				{
					picFP2.Image = bmps;
				}
			}
		}
		
		private void DeleteImage()
		{
			if(MessageBox.Show("Delete image?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				try
				{
					if(picIMG4.BorderStyle == BorderStyle.Fixed3D)
					{
						picIMG4.Image = null;
						if(fileArray != null)
						{
							if(fileArray.Length > 0)
							{
								File.Delete(fileArray[0].FullName);
							}
						}
					}
					if(picIMG3.BorderStyle == BorderStyle.Fixed3D)
					{
						picIMG3.Image = null;
						if(fileArray != null)
						{
							if(fileArray.Length > 1)
							{
								File.Delete(fileArray[1].FullName);
							}
						}
					}
					if(picIMG2.BorderStyle == BorderStyle.Fixed3D)
					{
						picIMG2.Image = null;
						if(fileArray != null)
						{
							if(fileArray.Length > 2)
							{
								File.Delete(fileArray[2].FullName);
							}
						}
					}
					if(picIMG1.BorderStyle == BorderStyle.Fixed3D)
					{
						picIMG1.Image = null;
						if(fileArray != null)
						{
							if(fileArray.Length > 3)
							{
								File.Delete(fileArray[3].FullName);
							}
						}
					}
					fileCreateLong = 0;
				}
				catch{}
			}
		}
		private void RefreshBorderImage()
		{
			picIMG1.BorderStyle = BorderStyle.FixedSingle;
			picIMG1.Width = 145;
			picIMG1.Height = 105;
			picIMG2.BorderStyle = BorderStyle.FixedSingle;
			picIMG2.Width = 145;
			picIMG2.Height = 105;
			picIMG3.BorderStyle = BorderStyle.FixedSingle;
			picIMG3.Width = 145;
			picIMG3.Height = 105;
			picIMG4.BorderStyle = BorderStyle.FixedSingle;
			picIMG4.Width = 145;
			picIMG4.Height = 105;
		}
		private void SetFileSelected(int file)
		{
			RefreshBorderImage();
			if(file == 1)
			{
				FileSelected =  picIMG1.Image;
				picIMG1.BorderStyle = BorderStyle.Fixed3D;
				picIMG1.Height = 120;
				picIMG1.Width = 160;
			}
			else if(file == 2)
			{
				FileSelected =  picIMG2.Image;
				picIMG2.BorderStyle = BorderStyle.Fixed3D;
				picIMG2.Height = 120;
				picIMG2.Width = 160;
			}
			else if(file == 3)
			{
				FileSelected =  picIMG3.Image;
				picIMG3.BorderStyle = BorderStyle.Fixed3D;
				picIMG3.Height = 120;
				picIMG3.Width = 160;
			}
			else if(file == 4)
			{
				FileSelected =  picIMG4.Image;
				picIMG4.BorderStyle = BorderStyle.Fixed3D;
				picIMG4.Height = 120;
				picIMG4.Width = 160;
			}
		}

		private void picIMG4_Click(object sender, System.EventArgs e)
		{
			SetFileSelected(4);
		}

		private void picIMG3_Click(object sender, System.EventArgs e)
		{
			SetFileSelected(3);
		}

		private void picIMG2_Click(object sender, System.EventArgs e)
		{
			SetFileSelected(2);
		}

		private void picIMG1_Click(object sender, System.EventArgs e)
		{
			SetFileSelected(1);
		}

		private void picBefore_Click(object sender, System.EventArgs e)
		{
			picIDSelect(0);
		}

		private void picAfter_Click(object sender, System.EventArgs e)
		{
			picIDSelect(1);
		}
		private void lkF5_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			if(FileSelected != null)
				picBefore.Image = FileSelected;
		}
		void CutFP()
		{
			if(picAfter.Image != null)
			{
				GetFP(1, FP1_Width, FP1_Height, FP1_X, FP1_Y);
				GetFP(2, FP2_Width, FP2_Height, FP2_X, FP2_Y);				
			}
		}
		private void lkF6_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			if(FileSelected != null)
			{
				picAfter.Image = FileSelected;
				GetFP(1, FP1_Width, FP1_Height, FP1_X, FP1_Y);
				GetFP(2, FP2_Width, FP2_Height, FP2_X, FP2_Y);
				picFP1_Click(sender, e);
			}
		}

		private void btnDelete_Click(object sender, System.EventArgs e)
		{
			DeleteImage();
		}
		private void lkNoneBefore_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			picBefore.Image = null;
		}

		private void lkNoneAfter_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			picAfter.Image = null;
			picFP1.Image = null;
			picFP2.Image = null;
		}

		private void btnEnter_Click(object sender, System.EventArgs e)
		{
			IDBefore = picBefore.Image;
			IDAfter = picAfter.Image;
			FP1 = picFP1.Image;
			FP2 = picFP2.Image;
			this.Close();
		}
		public void KillPaint()
		{
			try
			{
				// User phai quyen adminstrator moi getduoc process :(
				// ALo anh oi.
//				System.Diagnostics.Process[] procs = Process.GetProcesses();
//				for(int i = 0 ; i < procs.Length; i++)
//				{
//					if(procs[i].ProcessName.IndexOf("mspaint") > -1)
//						procs[i].Kill();
//				}				
			}
			catch
			{ }
			finally
			{ }
		}
		
		private void picIDSelect(int IDImg)
		{
			picBefore.BorderStyle = BorderStyle.FixedSingle;
			picAfter.BorderStyle = BorderStyle.FixedSingle;
			if(IDImg == 0)
			{
				picBefore.BorderStyle = BorderStyle.Fixed3D;
				picBefore.Select();
			}
			else if(IDImg == 1)

			{
				picAfter.BorderStyle = BorderStyle.Fixed3D;
				picAfter.Select();
			}
		}

		private void frmScan_Load(object sender, System.EventArgs e)
		{
			DeleteImageScaned();
			try
			{
				if(IDBefore != null)
					picBefore.Image = IDBefore;
				if(IDAfter != null)
					picAfter.Image = IDAfter;
				if(FP1 != null)
					picFP1.Image = FP1;
				if(FP2 != null)
					picFP2.Image = FP2;
			}
			catch
			{ }
			finally
			{ }
		}

		private void picFP1_Click(object sender, System.EventArgs e)
		{
			if(pnFP1.BackColor == Color.White)
			{
				pnFP1.BackColor = Color.Blue;
				pnFP2.BackColor = Color.White;
			}
		}

		private void picFP2_Click(object sender, System.EventArgs e)
		{
			if(pnFP2.BackColor == Color.White)
			{
				pnFP1.BackColor = Color.White;
				pnFP2.BackColor = Color.Blue;
			}
		}

		private void btnScan_Click(object sender, System.EventArgs e)
		{
			btnEnter.Focus();
			btnScan.Enabled = false;
			Application.DoEvents();
			this.Cursor = Cursors.WaitCursor;
			try
			{
				foreach (Process processKill in Process.GetProcessesByName("ScanQ2"))
				{
					processKill.Kill();
				}
			}
			catch{}

			DeleteImageScaned();
			string filename = Application.StartupPath + @"\ScanQ2.exe";
			System.Diagnostics.Process.Start(filename);
			timerScan.Enabled = true;
			btnScan.Enabled = true;
		}

		void DeleteImageScaned()
		{
			if (File.Exists(mt))
			{
				File.Delete(mt);
			}
			if (File.Exists(ms))
			{
				File.Delete(ms);
			}
		}
		private void timerScan_Tick(object sender, System.EventArgs e)
		{
			try
			{
				if (File.Exists(mt))
				{
					if(ckbMT.Checked)
					{
						using (System.IO.FileStream fs = new System.IO.FileStream(mt, FileMode.Open))
						{
							Bitmap bmp = new Bitmap(fs);
							picBefore.Image = (Bitmap)bmp.Clone();
						}
					}
				}
				if (File.Exists(ms))
				{
					if(ckbMS.Checked)
					{
						using (System.IO.FileStream fs = new System.IO.FileStream(ms, FileMode.Open))
						{
							Bitmap bmp = new Bitmap(fs);
							picAfter.Image = (Bitmap)bmp.Clone();
							CutFP();
							picFP1_Click(sender, e);
						}
					}
					timerScan.Enabled = false;
					this.Cursor = Cursors.Default;
				}
			}
			catch
			{
				timerScan.Enabled = false;
			}
		}

		private void ckbMT_CheckedChanged(object sender, System.EventArgs e)
		{
			if(ckbMT.Checked == false)
			{
				if(ckbMS.Checked == false)
				{
					ckbMS.Checked = true;
				}
			}
		}
		private void ckbMS_CheckedChanged(object sender, System.EventArgs e)
		{
			if(ckbMS.Checked == false)
			{
				if(ckbMT.Checked == false)
				{
					ckbMT.Checked = true;
				}
			}
		}
	}
}

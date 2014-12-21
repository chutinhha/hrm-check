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

		string ScanPath =@"C:\Users\Public\Documents\ScanDoc";

		bool Loading = false;
		bool Killing = false;
		Image FileSelected = null;
		FileInfo[] fileArray;
		long fileCreateLong = 0;

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
		private System.Windows.Forms.Button btnNext;
		private System.Windows.Forms.Button btnPrevious;
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
			this.btnEnter = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.pnMain = new System.Windows.Forms.Panel();
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
			this.btnPrevious = new System.Windows.Forms.Button();
			this.btnNext = new System.Windows.Forms.Button();
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
			this.pnControl.SuspendLayout();
			this.pnMain.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnControl
			// 
			this.pnControl.BackColor = System.Drawing.SystemColors.Control;
			this.pnControl.Controls.Add(this.btnEnter);
			this.pnControl.Controls.Add(this.btnDelete);
			this.pnControl.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnControl.Location = new System.Drawing.Point(0, 0);
			this.pnControl.Name = "pnControl";
			this.pnControl.Size = new System.Drawing.Size(904, 72);
			this.pnControl.TabIndex = 0;
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
			// pnMain
			// 
			this.pnMain.BackColor = System.Drawing.Color.White;
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
			this.pnMain.Size = new System.Drawing.Size(904, 550);
			this.pnMain.TabIndex = 1;
			// 
			// lkNoneAfter
			// 
			this.lkNoneAfter.AutoSize = true;
			this.lkNoneAfter.Location = new System.Drawing.Point(784, 288);
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
			this.lkNoneBefore.Location = new System.Drawing.Point(344, 288);
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
			this.lkF6.Location = new System.Drawing.Point(816, 288);
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
			this.lkF5.Location = new System.Drawing.Point(376, 288);
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
			this.panel1.Controls.Add(this.btnPrevious);
			this.panel1.Controls.Add(this.btnNext);
			this.panel1.Controls.Add(this.picIMG1);
			this.panel1.Controls.Add(this.picIMG2);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new System.Drawing.Point(0, 414);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(904, 136);
			this.panel1.TabIndex = 5;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.BackColor = System.Drawing.Color.Yellow;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label9.Location = new System.Drawing.Point(744, 96);
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
			this.label8.Location = new System.Drawing.Point(576, 96);
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
			this.label7.Location = new System.Drawing.Point(408, 96);
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
			this.label6.Location = new System.Drawing.Point(240, 96);
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
			this.picIMG4.Location = new System.Drawing.Point(624, 12);
			this.picIMG4.Name = "picIMG4";
			this.picIMG4.Size = new System.Drawing.Size(145, 105);
			this.picIMG4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picIMG4.TabIndex = 6;
			this.picIMG4.TabStop = false;
			this.picIMG4.Click += new System.EventHandler(this.picIMG4_Click);
			// 
			// picIMG3
			// 
			this.picIMG3.BackColor = System.Drawing.SystemColors.Control;
			this.picIMG3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.picIMG3.Location = new System.Drawing.Point(456, 12);
			this.picIMG3.Name = "picIMG3";
			this.picIMG3.Size = new System.Drawing.Size(145, 105);
			this.picIMG3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picIMG3.TabIndex = 5;
			this.picIMG3.TabStop = false;
			this.picIMG3.Click += new System.EventHandler(this.picIMG3_Click);
			// 
			// btnPrevious
			// 
			this.btnPrevious.Font = new System.Drawing.Font("Microsoft Sans Serif", 55F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btnPrevious.Location = new System.Drawing.Point(8, 8);
			this.btnPrevious.Name = "btnPrevious";
			this.btnPrevious.Size = new System.Drawing.Size(80, 120);
			this.btnPrevious.TabIndex = 0;
			this.btnPrevious.Text = "<";
			this.btnPrevious.Visible = false;
			// 
			// btnNext
			// 
			this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 55F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btnNext.Location = new System.Drawing.Point(816, 8);
			this.btnNext.Name = "btnNext";
			this.btnNext.Size = new System.Drawing.Size(80, 120);
			this.btnNext.TabIndex = 0;
			this.btnNext.Text = ">";
			this.btnNext.Visible = false;
			// 
			// picIMG1
			// 
			this.picIMG1.BackColor = System.Drawing.SystemColors.Control;
			this.picIMG1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.picIMG1.Location = new System.Drawing.Point(120, 12);
			this.picIMG1.Name = "picIMG1";
			this.picIMG1.Size = new System.Drawing.Size(145, 105);
			this.picIMG1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picIMG1.TabIndex = 5;
			this.picIMG1.TabStop = false;
			this.picIMG1.Click += new System.EventHandler(this.picIMG1_Click);
			// 
			// picIMG2
			// 
			this.picIMG2.BackColor = System.Drawing.SystemColors.Control;
			this.picIMG2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.picIMG2.Location = new System.Drawing.Point(288, 12);
			this.picIMG2.Name = "picIMG2";
			this.picIMG2.Size = new System.Drawing.Size(145, 105);
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
			this.picFP1.Location = new System.Drawing.Point(456, 288);
			this.picFP1.Name = "picFP1";
			this.picFP1.Size = new System.Drawing.Size(121, 112);
			this.picFP1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picFP1.TabIndex = 4;
			this.picFP1.TabStop = false;
			// 
			// picFP2
			// 
			this.picFP2.BackColor = System.Drawing.SystemColors.Control;
			this.picFP2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picFP2.BackgroundImage")));
			this.picFP2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.picFP2.Location = new System.Drawing.Point(584, 288);
			this.picFP2.Name = "picFP2";
			this.picFP2.Size = new System.Drawing.Size(121, 112);
			this.picFP2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picFP2.TabIndex = 4;
			this.picFP2.TabStop = false;
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
			// frmScan
			// 
			this.AcceptButton = this.btnEnter;
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(904, 622);
			this.Controls.Add(this.pnMain);
			this.Controls.Add(this.pnControl);
			this.KeyPreview = true;
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
									using (System.IO.FileStream fs = new System.IO.FileStream(fileArray[i].FullName, FileMode.Open))
									{
										Bitmap bmp = new Bitmap(fs);
										picIMG1.Image = (Bitmap)bmp.Clone();
									}
								}
								else if(i == 1)
								{
									using (System.IO.FileStream fs = new System.IO.FileStream(fileArray[i].FullName, FileMode.Open))
									{
										Bitmap bmp = new Bitmap(fs);
										picIMG2.Image = (Bitmap)bmp.Clone();
									}
								}
								else if(i == 2)
								{
									using (System.IO.FileStream fs = new System.IO.FileStream(fileArray[i].FullName, FileMode.Open))
									{
										Bitmap bmp = new Bitmap(fs);
										picIMG3.Image = (Bitmap)bmp.Clone();
									}
								}
								else if(i == 3)
								{
									using (System.IO.FileStream fs = new System.IO.FileStream(fileArray[i].FullName, FileMode.Open))
									{
										Bitmap bmp = new Bitmap(fs);
										picIMG4.Image = (Bitmap)bmp.Clone();
									}
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
			if(Killing == false)
			{
				Killing = true;
				KillPaint();
				Killing = false;
			}
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
				}
				return;
			}			
			if (e.KeyCode == Keys.Delete)
			{
				DeleteImage();
				return;
			}
		}
		
		private void DeleteImage()
		{
			if(MessageBox.Show("Delete image?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				if(picIMG4.BorderStyle == BorderStyle.Fixed3D)
				{
					picIMG4.Image = null;
					if(fileArray != null)
					{
						if(fileArray.Length > 0)
						{
							fileArray[0].Delete();
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
							fileArray[1].Delete();
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
							fileArray[2].Delete();
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
							fileArray[3].Delete();
						}
					}
				}
				fileCreateLong = 0;
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

		private void lkF6_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			if(FileSelected != null)
				picAfter.Image = FileSelected;
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
			System.Diagnostics.Process[] procs = null;
			try
			{
				procs = Process.GetProcessesByName("mspaint");
				if(procs != null)
					if(procs.Length > 0)
					{
						for(int i = 0; i < procs.Length; i ++)
						{
							Process mspaintProc = procs[i];
							mspaintProc.Kill();
						}
					}
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
			if(IDBefore != null)
				picBefore.Image = IDBefore;
			if(IDAfter != null)
				picAfter.Image = IDAfter;
			if(FP1 != null)
				picFP1.Image = FP1;
			if(FP2 != null)
				picFP2.Image = FP2;
		}
	}
}

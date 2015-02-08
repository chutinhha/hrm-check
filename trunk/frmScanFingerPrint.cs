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
	public class frmScanFingerPrint : System.Windows.Forms.Form
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
		private System.Windows.Forms.Panel pnMain;
		private System.Windows.Forms.PictureBox picAfter;
		private System.Windows.Forms.PictureBox picFP1;
		private System.Windows.Forms.PictureBox picFP2;
		private System.Windows.Forms.Timer timerClosePaint;
		private System.Windows.Forms.Panel pnFP2;
		private System.Windows.Forms.Panel pnFP1;
		private System.Windows.Forms.Timer timerScan;
		private System.ComponentModel.IContainer components;

		public frmScanFingerPrint()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmScanFingerPrint));
			this.pnMain = new System.Windows.Forms.Panel();
			this.pnFP2 = new System.Windows.Forms.Panel();
			this.pnFP1 = new System.Windows.Forms.Panel();
			this.picFP1 = new System.Windows.Forms.PictureBox();
			this.picFP2 = new System.Windows.Forms.PictureBox();
			this.picAfter = new System.Windows.Forms.PictureBox();
			this.timerClosePaint = new System.Windows.Forms.Timer(this.components);
			this.timerScan = new System.Windows.Forms.Timer(this.components);
			this.pnMain.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnMain
			// 
			this.pnMain.BackColor = System.Drawing.Color.White;
			this.pnMain.Controls.Add(this.pnFP2);
			this.pnMain.Controls.Add(this.pnFP1);
			this.pnMain.Controls.Add(this.picFP1);
			this.pnMain.Controls.Add(this.picFP2);
			this.pnMain.Controls.Add(this.picAfter);
			this.pnMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnMain.Location = new System.Drawing.Point(0, 0);
			this.pnMain.Name = "pnMain";
			this.pnMain.Size = new System.Drawing.Size(392, 154);
			this.pnMain.TabIndex = 1;
			// 
			// pnFP2
			// 
			this.pnFP2.Location = new System.Drawing.Point(200, 16);
			this.pnFP2.Name = "pnFP2";
			this.pnFP2.Size = new System.Drawing.Size(176, 8);
			this.pnFP2.TabIndex = 14;
			// 
			// pnFP1
			// 
			this.pnFP1.Location = new System.Drawing.Point(16, 16);
			this.pnFP1.Name = "pnFP1";
			this.pnFP1.Size = new System.Drawing.Size(176, 8);
			this.pnFP1.TabIndex = 13;
			// 
			// picFP1
			// 
			this.picFP1.BackColor = System.Drawing.SystemColors.Control;
			this.picFP1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picFP1.BackgroundImage")));
			this.picFP1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.picFP1.Location = new System.Drawing.Point(16, 24);
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
			this.picFP2.Location = new System.Drawing.Point(200, 24);
			this.picFP2.Name = "picFP2";
			this.picFP2.Size = new System.Drawing.Size(176, 120);
			this.picFP2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picFP2.TabIndex = 4;
			this.picFP2.TabStop = false;
			this.picFP2.Click += new System.EventHandler(this.picFP2_Click);
			// 
			// picAfter
			// 
			this.picAfter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picAfter.BackgroundImage")));
			this.picAfter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.picAfter.Location = new System.Drawing.Point(0, 0);
			this.picAfter.Name = "picAfter";
			this.picAfter.Size = new System.Drawing.Size(440, 272);
			this.picAfter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picAfter.TabIndex = 1;
			this.picAfter.TabStop = false;
			this.picAfter.Visible = false;
			// 
			// timerClosePaint
			// 
			this.timerClosePaint.Enabled = true;
			this.timerClosePaint.Interval = 500;
			// 
			// timerScan
			// 
			this.timerScan.Interval = 1000;
			this.timerScan.Tick += new System.EventHandler(this.timerScan_Tick);
			// 
			// frmScanFingerPrint
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(392, 154);
			this.Controls.Add(this.pnMain);
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmScanFingerPrint";
			this.Opacity = 0;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frmScan";
			this.Load += new System.EventHandler(this.frmScan_Load);
			this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmScan_KeyUp);
			this.pnMain.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

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
			
			if (e.KeyCode == Keys.F5)
			{
				
				return;
			}
			if (e.KeyCode == Keys.F6)
			{
				
				return;
			}

			if (e.KeyCode == Keys.Delete)
			{
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
		
		void CutFP()
		{
			if(picAfter.Image != null)
			{
				GetFP(1, FP1_Width, FP1_Height, FP1_X, FP1_Y);
				GetFP(2, FP2_Width, FP2_Height, FP2_X, FP2_Y);
				FP1 = picFP1.Image;
				FP2 = picFP2.Image;
			}
		}

		private void frmScan_Load(object sender, System.EventArgs e)
		{
			picAfter.Image = null;
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
					
				}
				if (File.Exists(ms))
				{
					using (System.IO.FileStream fs = new System.IO.FileStream(ms, FileMode.Open))
					{
						Bitmap bmp = new Bitmap(fs);
						picAfter.Image = (Bitmap)bmp.Clone();
						CutFP();
						picFP1_Click(sender, e);
					}					
					timerScan.Enabled = false;
					this.Close();
				}
			}
			catch
			{
				timerScan.Enabled = false;
				this.Close();
			}
		}

	}
}

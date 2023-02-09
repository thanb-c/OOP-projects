/*
 * Created by SharpDevelop.
 * User: ACER
 * Date: 2/17/2022
 * Time: 11:37 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace thansuda_6213841
{
	partial class StorePage
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StorePage));
			this.btnBack = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.lblNum = new System.Windows.Forms.Label();
			this.myoder = new System.Windows.Forms.PictureBox();
			this.btnFind = new System.Windows.Forms.Button();
			this.txtSearch = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panelChannel = new System.Windows.Forms.Panel();
			this.btnLookup = new System.Windows.Forms.Button();
			this.btnFigure = new System.Windows.Forms.Button();
			this.btnStandy = new System.Windows.Forms.Button();
			this.btnNenrodriod = new System.Windows.Forms.Button();
			this.btnHome = new System.Windows.Forms.Button();
			this.btnNoru = new System.Windows.Forms.Button();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.myoder)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.panelChannel.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnBack
			// 
			this.btnBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBack.BackgroundImage")));
			this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnBack.FlatAppearance.BorderSize = 0;
			this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnBack.Location = new System.Drawing.Point(1078, 0);
			this.btnBack.Name = "btnBack";
			this.btnBack.Size = new System.Drawing.Size(39, 42);
			this.btnBack.TabIndex = 0;
			this.btnBack.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnBack.UseVisualStyleBackColor = true;
			this.btnBack.Click += new System.EventHandler(this.BtnBackClick);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.GhostWhite;
			this.panel1.Controls.Add(this.lblNum);
			this.panel1.Controls.Add(this.myoder);
			this.panel1.Controls.Add(this.btnFind);
			this.panel1.Controls.Add(this.txtSearch);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Controls.Add(this.btnBack);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1120, 59);
			this.panel1.TabIndex = 1;
			// 
			// lblNum
			// 
			this.lblNum.BackColor = System.Drawing.Color.Red;
			this.lblNum.ForeColor = System.Drawing.Color.White;
			this.lblNum.Location = new System.Drawing.Point(1033, 3);
			this.lblNum.Name = "lblNum";
			this.lblNum.Size = new System.Drawing.Size(23, 25);
			this.lblNum.TabIndex = 10;
			this.lblNum.Text = "0";
			this.lblNum.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// myoder
			// 
			this.myoder.Image = ((System.Drawing.Image)(resources.GetObject("myoder.Image")));
			this.myoder.Location = new System.Drawing.Point(997, 3);
			this.myoder.Name = "myoder";
			this.myoder.Size = new System.Drawing.Size(49, 51);
			this.myoder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.myoder.TabIndex = 9;
			this.myoder.TabStop = false;
			this.myoder.Click += new System.EventHandler(this.MyoderClick);
			// 
			// btnFind
			// 
			this.btnFind.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFind.BackgroundImage")));
			this.btnFind.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnFind.FlatAppearance.BorderSize = 0;
			this.btnFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnFind.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnFind.Location = new System.Drawing.Point(935, 9);
			this.btnFind.Name = "btnFind";
			this.btnFind.Size = new System.Drawing.Size(39, 42);
			this.btnFind.TabIndex = 4;
			this.btnFind.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnFind.UseVisualStyleBackColor = true;
			// 
			// txtSearch
			// 
			this.txtSearch.Location = new System.Drawing.Point(633, 16);
			this.txtSearch.Name = "txtSearch";
			this.txtSearch.Size = new System.Drawing.Size(296, 31);
			this.txtSearch.TabIndex = 3;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(81, 19);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(147, 23);
			this.label1.TabIndex = 2;
			this.label1.Text = "AniMe Shop";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(3, 3);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(100, 50);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// panelChannel
			// 
			this.panelChannel.BackColor = System.Drawing.Color.GhostWhite;
			this.panelChannel.Controls.Add(this.btnLookup);
			this.panelChannel.Controls.Add(this.btnFigure);
			this.panelChannel.Controls.Add(this.btnStandy);
			this.panelChannel.Controls.Add(this.btnNenrodriod);
			this.panelChannel.Controls.Add(this.btnHome);
			this.panelChannel.Controls.Add(this.btnNoru);
			this.panelChannel.Dock = System.Windows.Forms.DockStyle.Left;
			this.panelChannel.Location = new System.Drawing.Point(0, 59);
			this.panelChannel.Name = "panelChannel";
			this.panelChannel.Size = new System.Drawing.Size(170, 556);
			this.panelChannel.TabIndex = 2;
			// 
			// btnLookup
			// 
			this.btnLookup.BackColor = System.Drawing.SystemColors.HotTrack;
			this.btnLookup.FlatAppearance.BorderSize = 0;
			this.btnLookup.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnLookup.ForeColor = System.Drawing.Color.White;
			this.btnLookup.Location = new System.Drawing.Point(0, 210);
			this.btnLookup.Name = "btnLookup";
			this.btnLookup.Size = new System.Drawing.Size(170, 45);
			this.btnLookup.TabIndex = 8;
			this.btnLookup.Text = "Look-Up";
			this.btnLookup.UseVisualStyleBackColor = false;
			this.btnLookup.Click += new System.EventHandler(this.BtnLookupClick);
			// 
			// btnFigure
			// 
			this.btnFigure.BackColor = System.Drawing.SystemColors.HotTrack;
			this.btnFigure.FlatAppearance.BorderSize = 0;
			this.btnFigure.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnFigure.ForeColor = System.Drawing.Color.White;
			this.btnFigure.Location = new System.Drawing.Point(0, 124);
			this.btnFigure.Name = "btnFigure";
			this.btnFigure.Size = new System.Drawing.Size(170, 45);
			this.btnFigure.TabIndex = 7;
			this.btnFigure.Text = "Figure";
			this.btnFigure.UseVisualStyleBackColor = false;
			this.btnFigure.Click += new System.EventHandler(this.BtnFigureClick);
			// 
			// btnStandy
			// 
			this.btnStandy.BackColor = System.Drawing.SystemColors.HotTrack;
			this.btnStandy.FlatAppearance.BorderSize = 0;
			this.btnStandy.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnStandy.ForeColor = System.Drawing.Color.White;
			this.btnStandy.Location = new System.Drawing.Point(0, 165);
			this.btnStandy.Name = "btnStandy";
			this.btnStandy.Size = new System.Drawing.Size(170, 45);
			this.btnStandy.TabIndex = 5;
			this.btnStandy.Text = "Standy";
			this.btnStandy.UseVisualStyleBackColor = false;
			this.btnStandy.Click += new System.EventHandler(this.BtnStandyClick);
			// 
			// btnNenrodriod
			// 
			this.btnNenrodriod.BackColor = System.Drawing.SystemColors.HotTrack;
			this.btnNenrodriod.FlatAppearance.BorderSize = 0;
			this.btnNenrodriod.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnNenrodriod.ForeColor = System.Drawing.Color.White;
			this.btnNenrodriod.Location = new System.Drawing.Point(0, 84);
			this.btnNenrodriod.Name = "btnNenrodriod";
			this.btnNenrodriod.Size = new System.Drawing.Size(170, 45);
			this.btnNenrodriod.TabIndex = 4;
			this.btnNenrodriod.Text = "Nendoroid";
			this.btnNenrodriod.UseVisualStyleBackColor = false;
			this.btnNenrodriod.Click += new System.EventHandler(this.BtnNenrodriodClick);
			// 
			// btnHome
			// 
			this.btnHome.BackColor = System.Drawing.SystemColors.HotTrack;
			this.btnHome.FlatAppearance.BorderSize = 0;
			this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnHome.ForeColor = System.Drawing.Color.White;
			this.btnHome.Location = new System.Drawing.Point(0, 0);
			this.btnHome.Name = "btnHome";
			this.btnHome.Size = new System.Drawing.Size(170, 45);
			this.btnHome.TabIndex = 3;
			this.btnHome.Text = "Home";
			this.btnHome.UseVisualStyleBackColor = false;
			this.btnHome.Click += new System.EventHandler(this.BtnHomeClick);
			// 
			// btnNoru
			// 
			this.btnNoru.BackColor = System.Drawing.SystemColors.HotTrack;
			this.btnNoru.FlatAppearance.BorderSize = 0;
			this.btnNoru.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnNoru.ForeColor = System.Drawing.Color.White;
			this.btnNoru.Location = new System.Drawing.Point(0, 42);
			this.btnNoru.Name = "btnNoru";
			this.btnNoru.Size = new System.Drawing.Size(170, 45);
			this.btnNoru.TabIndex = 3;
			this.btnNoru.Text = "Noru";
			this.btnNoru.UseVisualStyleBackColor = false;
			this.btnNoru.Click += new System.EventHandler(this.BtnNoruClick);
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.AutoScroll = true;
			this.flowLayoutPanel1.BackColor = System.Drawing.Color.GhostWhite;
			this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flowLayoutPanel1.Location = new System.Drawing.Point(170, 59);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(950, 556);
			this.flowLayoutPanel1.TabIndex = 2;
			// 
			// StorePage
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1120, 615);
			this.Controls.Add(this.flowLayoutPanel1);
			this.Controls.Add(this.panelChannel);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
			this.Name = "StorePage";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "StorePage";
			this.Load += new System.EventHandler(this.StorePageLoad);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.myoder)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.panelChannel.ResumeLayout(false);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.Label lblNum;
		private System.Windows.Forms.PictureBox myoder;
		private System.Windows.Forms.Button btnLookup;
		private System.Windows.Forms.Panel panelChannel;
		private System.Windows.Forms.TextBox txtSearch;
		private System.Windows.Forms.Button btnFind;
		private System.Windows.Forms.Button btnStandy;
		private System.Windows.Forms.Button btnNenrodriod;
		private System.Windows.Forms.Button btnHome;
		private System.Windows.Forms.Button btnNoru;
		private System.Windows.Forms.Button btnFigure;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btnBack;
	}
}

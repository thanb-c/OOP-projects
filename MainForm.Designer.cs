/*
 * Created by SharpDevelop.
 * User: ACER
 * Date: 2/16/2022
 * Time: 4:15 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace thansuda_6213841
{
	partial class MainForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.btnProduct = new System.Windows.Forms.Button();
			this.btnOrder = new System.Windows.Forms.Button();
			this.btnCustomer = new System.Windows.Forms.Button();
			this.btnSaleReport = new System.Windows.Forms.Button();
			this.btnProfile = new System.Windows.Forms.Button();
			this.btnStore = new System.Windows.Forms.Button();
			this.btnLogout = new System.Windows.Forms.Button();
			this.lblWelcome = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.lblName = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
			this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pictureBox1.Location = new System.Drawing.Point(4, 1);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(111, 83);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// btnProduct
			// 
			this.btnProduct.BackColor = System.Drawing.Color.DarkOrchid;
			this.btnProduct.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnProduct.BackgroundImage")));
			this.btnProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.btnProduct.FlatAppearance.BorderSize = 0;
			this.btnProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnProduct.ForeColor = System.Drawing.Color.White;
			this.btnProduct.Location = new System.Drawing.Point(28, 113);
			this.btnProduct.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.btnProduct.Name = "btnProduct";
			this.btnProduct.Size = new System.Drawing.Size(172, 374);
			this.btnProduct.TabIndex = 1;
			this.btnProduct.Text = "\r\n\r\n\r\n\r\n\r\n\r\n\r\nProduct";
			this.btnProduct.UseVisualStyleBackColor = false;
			this.btnProduct.Click += new System.EventHandler(this.BtnProductClick);
			// 
			// btnOrder
			// 
			this.btnOrder.BackColor = System.Drawing.Color.DarkOrchid;
			this.btnOrder.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOrder.BackgroundImage")));
			this.btnOrder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.btnOrder.FlatAppearance.BorderSize = 0;
			this.btnOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnOrder.ForeColor = System.Drawing.Color.White;
			this.btnOrder.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnOrder.Location = new System.Drawing.Point(208, 113);
			this.btnOrder.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.btnOrder.Name = "btnOrder";
			this.btnOrder.Size = new System.Drawing.Size(179, 188);
			this.btnOrder.TabIndex = 2;
			this.btnOrder.Text = "\r\n\r\n\r\n\r\n\r\nOrder";
			this.btnOrder.UseVisualStyleBackColor = false;
			this.btnOrder.Click += new System.EventHandler(this.BtnOrderClick);
			// 
			// btnCustomer
			// 
			this.btnCustomer.BackColor = System.Drawing.Color.DarkOrchid;
			this.btnCustomer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCustomer.BackgroundImage")));
			this.btnCustomer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.btnCustomer.FlatAppearance.BorderSize = 0;
			this.btnCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCustomer.ForeColor = System.Drawing.Color.White;
			this.btnCustomer.Location = new System.Drawing.Point(395, 113);
			this.btnCustomer.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.btnCustomer.Name = "btnCustomer";
			this.btnCustomer.Size = new System.Drawing.Size(245, 188);
			this.btnCustomer.TabIndex = 3;
			this.btnCustomer.Text = "\r\n\r\n\r\n\r\n\r\nCustomer Information";
			this.btnCustomer.UseVisualStyleBackColor = false;
			this.btnCustomer.Click += new System.EventHandler(this.BtnCustomerClick);
			// 
			// btnSaleReport
			// 
			this.btnSaleReport.BackColor = System.Drawing.Color.DarkOrchid;
			this.btnSaleReport.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSaleReport.BackgroundImage")));
			this.btnSaleReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.btnSaleReport.FlatAppearance.BorderSize = 0;
			this.btnSaleReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSaleReport.ForeColor = System.Drawing.Color.White;
			this.btnSaleReport.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnSaleReport.Location = new System.Drawing.Point(208, 310);
			this.btnSaleReport.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.btnSaleReport.Name = "btnSaleReport";
			this.btnSaleReport.Size = new System.Drawing.Size(221, 177);
			this.btnSaleReport.TabIndex = 4;
			this.btnSaleReport.Text = "\r\n\r\n\r\n\r\n\r\nReport";
			this.btnSaleReport.UseVisualStyleBackColor = false;
			this.btnSaleReport.Click += new System.EventHandler(this.BtnSaleReportClick);
			// 
			// btnProfile
			// 
			this.btnProfile.BackColor = System.Drawing.Color.DarkOrchid;
			this.btnProfile.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnProfile.BackgroundImage")));
			this.btnProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.btnProfile.FlatAppearance.BorderSize = 0;
			this.btnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnProfile.ForeColor = System.Drawing.Color.White;
			this.btnProfile.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnProfile.Location = new System.Drawing.Point(437, 310);
			this.btnProfile.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.btnProfile.Name = "btnProfile";
			this.btnProfile.Size = new System.Drawing.Size(203, 177);
			this.btnProfile.TabIndex = 5;
			this.btnProfile.Text = "\r\n\r\n\r\n\r\n\r\nProfile";
			this.btnProfile.UseVisualStyleBackColor = false;
			this.btnProfile.Click += new System.EventHandler(this.BtnProfileClick);
			// 
			// btnStore
			// 
			this.btnStore.BackColor = System.Drawing.Color.DarkOrchid;
			this.btnStore.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnStore.BackgroundImage")));
			this.btnStore.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.btnStore.FlatAppearance.BorderSize = 0;
			this.btnStore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnStore.ForeColor = System.Drawing.Color.White;
			this.btnStore.Location = new System.Drawing.Point(648, 113);
			this.btnStore.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.btnStore.Name = "btnStore";
			this.btnStore.Size = new System.Drawing.Size(172, 374);
			this.btnStore.TabIndex = 6;
			this.btnStore.Text = "\r\n\r\n\r\n\r\n\r\n\r\n\r\nStore";
			this.btnStore.UseVisualStyleBackColor = false;
			this.btnStore.Click += new System.EventHandler(this.BtnStoreClick);
			// 
			// btnLogout
			// 
			this.btnLogout.BackColor = System.Drawing.Color.PowderBlue;
			this.btnLogout.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLogout.BackgroundImage")));
			this.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnLogout.FlatAppearance.BorderSize = 0;
			this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnLogout.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLogout.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnLogout.Location = new System.Drawing.Point(810, 0);
			this.btnLogout.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.btnLogout.Name = "btnLogout";
			this.btnLogout.Size = new System.Drawing.Size(36, 44);
			this.btnLogout.TabIndex = 7;
			this.btnLogout.UseVisualStyleBackColor = false;
			this.btnLogout.Click += new System.EventHandler(this.BtnLogoutClick);
			// 
			// lblWelcome
			// 
			this.lblWelcome.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblWelcome.Location = new System.Drawing.Point(554, 44);
			this.lblWelcome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblWelcome.Name = "lblWelcome";
			this.lblWelcome.Size = new System.Drawing.Size(245, 24);
			this.lblWelcome.TabIndex = 8;
			this.lblWelcome.Text = "label1";
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(122, 11);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(76, 61);
			this.label1.TabIndex = 10;
			this.label1.Text = "Anime\r\nShop";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// lblName
			// 
			this.lblName.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblName.Location = new System.Drawing.Point(554, 11);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(245, 23);
			this.lblName.TabIndex = 9;
			this.lblName.Text = "label2";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.PowderBlue;
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Controls.Add(this.lblName);
			this.panel1.Controls.Add(this.lblWelcome);
			this.panel1.Controls.Add(this.btnLogout);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(0, 3);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(847, 86);
			this.panel1.TabIndex = 11;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 21F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.GhostWhite;
			this.ClientSize = new System.Drawing.Size(848, 509);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.btnStore);
			this.Controls.Add(this.btnProfile);
			this.Controls.Add(this.btnSaleReport);
			this.Controls.Add(this.btnCustomer);
			this.Controls.Add(this.btnOrder);
			this.Controls.Add(this.btnProduct);
			this.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ForeColor = System.Drawing.Color.MidnightBlue;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Main Page";
			this.Load += new System.EventHandler(this.MainFormLoad);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label lblName;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblWelcome;
		private System.Windows.Forms.Button btnLogout;
		private System.Windows.Forms.Button btnStore;
		private System.Windows.Forms.Button btnProfile;
		private System.Windows.Forms.Button btnSaleReport;
		private System.Windows.Forms.Button btnCustomer;
		private System.Windows.Forms.Button btnOrder;
		private System.Windows.Forms.Button btnProduct;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}

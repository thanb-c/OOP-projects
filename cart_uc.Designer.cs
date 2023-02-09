/*
 * Created by SharpDevelop.
 * User: ACER
 * Date: 3/5/2022
 * Time: 10:41 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace thansuda_6213841
{
	partial class cart_uc
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the control.
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cart_uc));
			this.picture = new System.Windows.Forms.PictureBox();
			this.lblQty = new System.Windows.Forms.Label();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.btnInc = new System.Windows.Forms.Button();
			this.lblCategory = new System.Windows.Forms.Label();
			this.lblName = new System.Windows.Forms.Label();
			this.btnDec = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.lblPrice = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// picture
			// 
			this.picture.Location = new System.Drawing.Point(3, 3);
			this.picture.Name = "picture";
			this.picture.Size = new System.Drawing.Size(157, 92);
			this.picture.TabIndex = 0;
			this.picture.TabStop = false;
			// 
			// lblQty
			// 
			this.lblQty.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblQty.Location = new System.Drawing.Point(65, 3);
			this.lblQty.Name = "lblQty";
			this.lblQty.Size = new System.Drawing.Size(65, 22);
			this.lblQty.TabIndex = 11;
			this.lblQty.Text = "Add to cart";
			this.lblQty.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pictureBox2
			// 
			this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(40, 3);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(22, 22);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox2.TabIndex = 10;
			this.pictureBox2.TabStop = false;
			// 
			// btnInc
			// 
			this.btnInc.BackColor = System.Drawing.Color.OliveDrab;
			this.btnInc.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnInc.BackgroundImage")));
			this.btnInc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnInc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnInc.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnInc.ForeColor = System.Drawing.Color.White;
			this.btnInc.Location = new System.Drawing.Point(137, 3);
			this.btnInc.Name = "btnInc";
			this.btnInc.Size = new System.Drawing.Size(20, 20);
			this.btnInc.TabIndex = 9;
			this.btnInc.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnInc.UseVisualStyleBackColor = false;
			this.btnInc.Click += new System.EventHandler(this.BtnIncClick);
			// 
			// lblCategory
			// 
			this.lblCategory.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCategory.Location = new System.Drawing.Point(9, 130);
			this.lblCategory.Name = "lblCategory";
			this.lblCategory.Size = new System.Drawing.Size(146, 22);
			this.lblCategory.TabIndex = 8;
			this.lblCategory.Text = "label2";
			this.lblCategory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblName
			// 
			this.lblName.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.lblName.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblName.Location = new System.Drawing.Point(3, 95);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(161, 46);
			this.lblName.TabIndex = 7;
			this.lblName.Text = "label1";
			this.lblName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// btnDec
			// 
			this.btnDec.BackColor = System.Drawing.Color.Crimson;
			this.btnDec.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDec.BackgroundImage")));
			this.btnDec.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnDec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDec.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDec.ForeColor = System.Drawing.Color.White;
			this.btnDec.Location = new System.Drawing.Point(5, 3);
			this.btnDec.Name = "btnDec";
			this.btnDec.Size = new System.Drawing.Size(20, 20);
			this.btnDec.TabIndex = 12;
			this.btnDec.UseVisualStyleBackColor = false;
			this.btnDec.Click += new System.EventHandler(this.BtnDecClick);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.GhostWhite;
			this.panel1.Controls.Add(this.btnInc);
			this.panel1.Controls.Add(this.btnDec);
			this.panel1.Controls.Add(this.pictureBox2);
			this.panel1.Controls.Add(this.lblQty);
			this.panel1.Location = new System.Drawing.Point(-2, 181);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(166, 25);
			this.panel1.TabIndex = 13;
			// 
			// lblPrice
			// 
			this.lblPrice.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPrice.Location = new System.Drawing.Point(9, 154);
			this.lblPrice.Name = "lblPrice";
			this.lblPrice.Size = new System.Drawing.Size(146, 24);
			this.lblPrice.TabIndex = 14;
			this.lblPrice.Text = "label2";
			this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// cart_uc
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.GhostWhite;
			this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Controls.Add(this.lblPrice);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.lblCategory);
			this.Controls.Add(this.lblName);
			this.Controls.Add(this.picture);
			this.Name = "cart_uc";
			this.Size = new System.Drawing.Size(163, 215);
			((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label lblPrice;
		private System.Windows.Forms.PictureBox picture;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btnDec;
		private System.Windows.Forms.Label lblName;
		private System.Windows.Forms.Label lblCategory;
		private System.Windows.Forms.Button btnInc;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Label lblQty;
	}
}

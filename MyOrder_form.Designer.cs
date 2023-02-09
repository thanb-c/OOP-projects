/*
 * Created by SharpDevelop.
 * User: ACER
 * Date: 3/24/2022
 * Time: 8:45 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace thansuda_6213841
{
	partial class MyOrder_form
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
			this.btnConfirm = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txtCid = new System.Windows.Forms.TextBox();
			this.label13 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.cmbSipMet = new System.Windows.Forms.ComboBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.txtPerAmount = new System.Windows.Forms.TextBox();
			this.txtTotalAmount = new System.Windows.Forms.TextBox();
			this.txtShipFee = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.cmbPayMet = new System.Windows.Forms.ComboBox();
			this.cmbDisCode = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtPhone = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtShipAd = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtCname = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.grid1 = new System.Windows.Forms.DataGridView();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.label11 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.txtPrice = new System.Windows.Forms.TextBox();
			this.txtQty = new System.Windows.Forms.TextBox();
			this.txtCategory = new System.Windows.Forms.TextBox();
			this.txtPname = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.lblToday = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.grid1)).BeginInit();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnConfirm
			// 
			this.btnConfirm.BackColor = System.Drawing.Color.Green;
			this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnConfirm.ForeColor = System.Drawing.Color.White;
			this.btnConfirm.Location = new System.Drawing.Point(739, 405);
			this.btnConfirm.Name = "btnConfirm";
			this.btnConfirm.Size = new System.Drawing.Size(146, 42);
			this.btnConfirm.TabIndex = 0;
			this.btnConfirm.Text = "Confirm";
			this.btnConfirm.UseVisualStyleBackColor = false;
			this.btnConfirm.Click += new System.EventHandler(this.BtnConfirmClick);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.txtCid);
			this.groupBox1.Controls.Add(this.label13);
			this.groupBox1.Controls.Add(this.label12);
			this.groupBox1.Controls.Add(this.cmbSipMet);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.txtPerAmount);
			this.groupBox1.Controls.Add(this.txtTotalAmount);
			this.groupBox1.Controls.Add(this.txtShipFee);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.cmbPayMet);
			this.groupBox1.Controls.Add(this.cmbDisCode);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.txtPhone);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.txtShipAd);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.txtCname);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(465, 35);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(420, 364);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Fill Infomation";
			// 
			// txtCid
			// 
			this.txtCid.Enabled = false;
			this.txtCid.Location = new System.Drawing.Point(124, 19);
			this.txtCid.Name = "txtCid";
			this.txtCid.Size = new System.Drawing.Size(290, 27);
			this.txtCid.TabIndex = 19;
			// 
			// label13
			// 
			this.label13.Location = new System.Drawing.Point(7, 27);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(85, 23);
			this.label13.TabIndex = 18;
			this.label13.Text = "ID";
			// 
			// label12
			// 
			this.label12.Location = new System.Drawing.Point(7, 249);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(85, 43);
			this.label12.TabIndex = 17;
			this.label12.Text = "Shipping Method";
			this.label12.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// cmbSipMet
			// 
			this.cmbSipMet.FormattingEnabled = true;
			this.cmbSipMet.Items.AddRange(new object[] {
									"Registered",
									"EMS"});
			this.cmbSipMet.Location = new System.Drawing.Point(124, 249);
			this.cmbSipMet.Name = "cmbSipMet";
			this.cmbSipMet.Size = new System.Drawing.Size(182, 27);
			this.cmbSipMet.TabIndex = 16;
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(6, 331);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(111, 23);
			this.label7.TabIndex = 15;
			this.label7.Text = "Total Amount";
			this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(6, 296);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(111, 23);
			this.label6.TabIndex = 14;
			this.label6.Text = "Shipping Fee";
			this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// txtPerAmount
			// 
			this.txtPerAmount.Enabled = false;
			this.txtPerAmount.Location = new System.Drawing.Point(332, 175);
			this.txtPerAmount.Name = "txtPerAmount";
			this.txtPerAmount.Size = new System.Drawing.Size(77, 27);
			this.txtPerAmount.TabIndex = 13;
			// 
			// txtTotalAmount
			// 
			this.txtTotalAmount.Location = new System.Drawing.Point(124, 329);
			this.txtTotalAmount.Name = "txtTotalAmount";
			this.txtTotalAmount.Size = new System.Drawing.Size(182, 27);
			this.txtTotalAmount.TabIndex = 12;
			// 
			// txtShipFee
			// 
			this.txtShipFee.Enabled = false;
			this.txtShipFee.Location = new System.Drawing.Point(124, 293);
			this.txtShipFee.Name = "txtShipFee";
			this.txtShipFee.Size = new System.Drawing.Size(182, 27);
			this.txtShipFee.TabIndex = 11;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(7, 207);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(85, 43);
			this.label5.TabIndex = 10;
			this.label5.Text = "Payment Method";
			this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// cmbPayMet
			// 
			this.cmbPayMet.FormattingEnabled = true;
			this.cmbPayMet.Items.AddRange(new object[] {
									"Bank",
									"Paypal",
									"VISA",
									"Master Card"});
			this.cmbPayMet.Location = new System.Drawing.Point(124, 210);
			this.cmbPayMet.Name = "cmbPayMet";
			this.cmbPayMet.Size = new System.Drawing.Size(182, 27);
			this.cmbPayMet.TabIndex = 9;
			// 
			// cmbDisCode
			// 
			this.cmbDisCode.FormattingEnabled = true;
			this.cmbDisCode.Items.AddRange(new object[] {
									"FOM-999",
									"Hot-Item",
									"Freeshipping"});
			this.cmbDisCode.Location = new System.Drawing.Point(124, 175);
			this.cmbDisCode.Name = "cmbDisCode";
			this.cmbDisCode.Size = new System.Drawing.Size(182, 27);
			this.cmbDisCode.TabIndex = 8;
			this.cmbDisCode.SelectedIndexChanged += new System.EventHandler(this.CmbDisCodeSelectedIndexChanged);
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(7, 165);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(85, 47);
			this.label4.TabIndex = 6;
			this.label4.Text = "Discount Code";
			this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// txtPhone
			// 
			this.txtPhone.Location = new System.Drawing.Point(124, 142);
			this.txtPhone.Name = "txtPhone";
			this.txtPhone.Size = new System.Drawing.Size(290, 27);
			this.txtPhone.TabIndex = 5;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(7, 145);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(85, 23);
			this.label3.TabIndex = 4;
			this.label3.Text = "Phone";
			// 
			// txtShipAd
			// 
			this.txtShipAd.Location = new System.Drawing.Point(124, 85);
			this.txtShipAd.Multiline = true;
			this.txtShipAd.Name = "txtShipAd";
			this.txtShipAd.Size = new System.Drawing.Size(290, 51);
			this.txtShipAd.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(7, 88);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(85, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "Address";
			// 
			// txtCname
			// 
			this.txtCname.Location = new System.Drawing.Point(124, 52);
			this.txtCname.Name = "txtCname";
			this.txtCname.Size = new System.Drawing.Size(290, 27);
			this.txtCname.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(7, 55);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(85, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Name";
			// 
			// grid1
			// 
			this.grid1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.grid1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.grid1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.grid1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
			this.grid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grid1.Location = new System.Drawing.Point(6, 26);
			this.grid1.Name = "grid1";
			this.grid1.Size = new System.Drawing.Size(435, 207);
			this.grid1.TabIndex = 1;
			this.grid1.SelectionChanged += new System.EventHandler(this.Grid1SelectionChanged);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.label11);
			this.groupBox2.Controls.Add(this.label10);
			this.groupBox2.Controls.Add(this.label9);
			this.groupBox2.Controls.Add(this.txtPrice);
			this.groupBox2.Controls.Add(this.txtQty);
			this.groupBox2.Controls.Add(this.txtCategory);
			this.groupBox2.Controls.Add(this.txtPname);
			this.groupBox2.Controls.Add(this.label8);
			this.groupBox2.Controls.Add(this.grid1);
			this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox2.Location = new System.Drawing.Point(14, 35);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(445, 364);
			this.groupBox2.TabIndex = 3;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Order Detail";
			// 
			// label11
			// 
			this.label11.Location = new System.Drawing.Point(245, 330);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(68, 23);
			this.label11.TabIndex = 9;
			this.label11.Text = "Price";
			this.label11.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// label10
			// 
			this.label10.Location = new System.Drawing.Point(9, 331);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(100, 23);
			this.label10.TabIndex = 8;
			this.label10.Text = "Quantity";
			this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(9, 291);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(100, 23);
			this.label9.TabIndex = 7;
			this.label9.Text = "Category";
			this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// txtPrice
			// 
			this.txtPrice.Location = new System.Drawing.Point(319, 328);
			this.txtPrice.Name = "txtPrice";
			this.txtPrice.Size = new System.Drawing.Size(111, 27);
			this.txtPrice.TabIndex = 6;
			// 
			// txtQty
			// 
			this.txtQty.Location = new System.Drawing.Point(115, 329);
			this.txtQty.Name = "txtQty";
			this.txtQty.Size = new System.Drawing.Size(124, 27);
			this.txtQty.TabIndex = 5;
			// 
			// txtCategory
			// 
			this.txtCategory.Location = new System.Drawing.Point(115, 292);
			this.txtCategory.Name = "txtCategory";
			this.txtCategory.Size = new System.Drawing.Size(315, 27);
			this.txtCategory.TabIndex = 4;
			// 
			// txtPname
			// 
			this.txtPname.Location = new System.Drawing.Point(115, 251);
			this.txtPname.Name = "txtPname";
			this.txtPname.Size = new System.Drawing.Size(315, 27);
			this.txtPname.TabIndex = 3;
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(9, 245);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(100, 46);
			this.label8.TabIndex = 2;
			this.label8.Text = "Product Name";
			this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// lblToday
			// 
			this.lblToday.Location = new System.Drawing.Point(739, 9);
			this.lblToday.Name = "lblToday";
			this.lblToday.Size = new System.Drawing.Size(146, 23);
			this.lblToday.TabIndex = 4;
			this.lblToday.Text = "label13";
			this.lblToday.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// MyOrder_form
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.GhostWhite;
			this.ClientSize = new System.Drawing.Size(897, 459);
			this.Controls.Add(this.lblToday);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.btnConfirm);
			this.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ForeColor = System.Drawing.Color.Black;
			this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
			this.Name = "MyOrder_form";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "My Oder";
			this.Load += new System.EventHandler(this.MyOder_formLoad);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.grid1)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.TextBox txtPerAmount;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.TextBox txtCid;
		private System.Windows.Forms.DataGridView grid1;
		private System.Windows.Forms.Label lblToday;
		private System.Windows.Forms.Button btnConfirm;
		private System.Windows.Forms.ComboBox cmbSipMet;
		private System.Windows.Forms.TextBox txtTotalAmount;
		private System.Windows.Forms.TextBox txtShipFee;
		private System.Windows.Forms.ComboBox cmbPayMet;
		private System.Windows.Forms.ComboBox cmbDisCode;
		private System.Windows.Forms.TextBox txtPhone;
		private System.Windows.Forms.TextBox txtShipAd;
		private System.Windows.Forms.TextBox txtCname;
		private System.Windows.Forms.TextBox txtPrice;
		private System.Windows.Forms.TextBox txtQty;
		private System.Windows.Forms.TextBox txtCategory;
		private System.Windows.Forms.TextBox txtPname;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.GroupBox groupBox1;
	}
}

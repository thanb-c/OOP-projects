/*
 * Created by SharpDevelop.
 * User: ACER
 * Date: 2/17/2022
 * Time: 11:35 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace thansuda_6213841
{
	partial class Order
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Order));
			this.btnBack = new System.Windows.Forms.Button();
			this.listView1 = new System.Windows.Forms.ListView();
			this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader11 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader15 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader12 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader13 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader14 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader9 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader8 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader10 = new System.Windows.Forms.ColumnHeader();
			this.btnLook = new System.Windows.Forms.Button();
			this.lblDate = new System.Windows.Forms.Label();
			this.btnConfirmOrd = new System.Windows.Forms.Button();
			this.btnCheckProduct = new System.Windows.Forms.Button();
			this.btnCheckCust = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.txtPname = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.txtPrice = new System.Windows.Forms.TextBox();
			this.txtQty = new System.Windows.Forms.TextBox();
			this.txtPCode = new System.Windows.Forms.TextBox();
			this.txtShipAdd = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txtBillDate = new System.Windows.Forms.TextBox();
			this.txtCname = new System.Windows.Forms.TextBox();
			this.txtBillNo = new System.Windows.Forms.TextBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.cmbEmpId = new System.Windows.Forms.ComboBox();
			this.cmbOrdStatus = new System.Windows.Forms.ComboBox();
			this.label15 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.cmbPayMet = new System.Windows.Forms.ComboBox();
			this.label11 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.cmbShipMet = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtDiscountCode = new System.Windows.Forms.TextBox();
			this.txtTotalAmount = new System.Windows.Forms.TextBox();
			this.txtShipFee = new System.Windows.Forms.TextBox();
			this.btnCancel = new System.Windows.Forms.Button();
			this.label16 = new System.Windows.Forms.Label();
			this.txtSearch = new System.Windows.Forms.TextBox();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnBack
			// 
			this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnBack.FlatAppearance.BorderSize = 0;
			this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
			this.btnBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnBack.Location = new System.Drawing.Point(2, -4);
			this.btnBack.Name = "btnBack";
			this.btnBack.Size = new System.Drawing.Size(118, 53);
			this.btnBack.TabIndex = 0;
			this.btnBack.Text = "BACK";
			this.btnBack.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnBack.UseVisualStyleBackColor = true;
			this.btnBack.Click += new System.EventHandler(this.BtnBackClick);
			// 
			// listView1
			// 
			this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
									this.columnHeader1,
									this.columnHeader11,
									this.columnHeader2,
									this.columnHeader15,
									this.columnHeader3,
									this.columnHeader4,
									this.columnHeader5,
									this.columnHeader6,
									this.columnHeader12,
									this.columnHeader13,
									this.columnHeader14,
									this.columnHeader9,
									this.columnHeader8,
									this.columnHeader7,
									this.columnHeader10});
			this.listView1.FullRowSelect = true;
			this.listView1.GridLines = true;
			this.listView1.Location = new System.Drawing.Point(13, 55);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(822, 212);
			this.listView1.TabIndex = 1;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = System.Windows.Forms.View.Details;
			this.listView1.SelectedIndexChanged += new System.EventHandler(this.ListView1SelectedIndexChanged);
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Bill NO.";
			this.columnHeader1.Width = 79;
			// 
			// columnHeader11
			// 
			this.columnHeader11.Text = "Date";
			this.columnHeader11.Width = 134;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Customer ";
			this.columnHeader2.Width = 130;
			// 
			// columnHeader15
			// 
			this.columnHeader15.Text = "Shipping Address";
			this.columnHeader15.Width = 293;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Product ID";
			this.columnHeader3.Width = 106;
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "Product Description";
			this.columnHeader4.Width = 199;
			// 
			// columnHeader5
			// 
			this.columnHeader5.Text = "Quantity";
			this.columnHeader5.Width = 96;
			// 
			// columnHeader6
			// 
			this.columnHeader6.Text = "Price";
			this.columnHeader6.Width = 64;
			// 
			// columnHeader12
			// 
			this.columnHeader12.Text = "Discount Code";
			// 
			// columnHeader13
			// 
			this.columnHeader13.Text = "Shipping Fee";
			// 
			// columnHeader14
			// 
			this.columnHeader14.Text = "Total Amount";
			// 
			// columnHeader9
			// 
			this.columnHeader9.Text = "Status";
			this.columnHeader9.Width = 80;
			// 
			// columnHeader8
			// 
			this.columnHeader8.DisplayIndex = 13;
			this.columnHeader8.Text = "Shipping Method";
			this.columnHeader8.Width = 56;
			// 
			// columnHeader7
			// 
			this.columnHeader7.DisplayIndex = 12;
			this.columnHeader7.Text = "Payment method";
			this.columnHeader7.Width = 82;
			// 
			// columnHeader10
			// 
			this.columnHeader10.Text = "Employee ID";
			// 
			// btnLook
			// 
			this.btnLook.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLook.BackgroundImage")));
			this.btnLook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnLook.Location = new System.Drawing.Point(589, 12);
			this.btnLook.Name = "btnLook";
			this.btnLook.Size = new System.Drawing.Size(55, 33);
			this.btnLook.TabIndex = 2;
			this.btnLook.UseVisualStyleBackColor = true;
			// 
			// lblDate
			// 
			this.lblDate.Location = new System.Drawing.Point(841, 13);
			this.lblDate.Name = "lblDate";
			this.lblDate.Size = new System.Drawing.Size(210, 72);
			this.lblDate.TabIndex = 4;
			this.lblDate.Text = "Date and Time";
			this.lblDate.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// btnConfirmOrd
			// 
			this.btnConfirmOrd.BackColor = System.Drawing.Color.Green;
			this.btnConfirmOrd.FlatAppearance.BorderSize = 0;
			this.btnConfirmOrd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnConfirmOrd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnConfirmOrd.ForeColor = System.Drawing.Color.White;
			this.btnConfirmOrd.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnConfirmOrd.Location = new System.Drawing.Point(864, 473);
			this.btnConfirmOrd.Name = "btnConfirmOrd";
			this.btnConfirmOrd.Size = new System.Drawing.Size(183, 48);
			this.btnConfirmOrd.TabIndex = 7;
			this.btnConfirmOrd.Text = "Confirm Order";
			this.btnConfirmOrd.UseVisualStyleBackColor = false;
			this.btnConfirmOrd.Click += new System.EventHandler(this.BtnConfirmOrdClick);
			// 
			// btnCheckProduct
			// 
			this.btnCheckProduct.BackColor = System.Drawing.Color.DarkBlue;
			this.btnCheckProduct.FlatAppearance.BorderSize = 0;
			this.btnCheckProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCheckProduct.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCheckProduct.ForeColor = System.Drawing.Color.White;
			this.btnCheckProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnCheckProduct.Location = new System.Drawing.Point(864, 326);
			this.btnCheckProduct.Name = "btnCheckProduct";
			this.btnCheckProduct.Size = new System.Drawing.Size(183, 48);
			this.btnCheckProduct.TabIndex = 8;
			this.btnCheckProduct.Text = "Check Product";
			this.btnCheckProduct.UseVisualStyleBackColor = false;
			this.btnCheckProduct.Click += new System.EventHandler(this.BtnCheckProductClick);
			// 
			// btnCheckCust
			// 
			this.btnCheckCust.BackColor = System.Drawing.Color.DarkBlue;
			this.btnCheckCust.FlatAppearance.BorderSize = 0;
			this.btnCheckCust.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCheckCust.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCheckCust.ForeColor = System.Drawing.Color.White;
			this.btnCheckCust.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnCheckCust.Location = new System.Drawing.Point(864, 389);
			this.btnCheckCust.Name = "btnCheckCust";
			this.btnCheckCust.Size = new System.Drawing.Size(183, 68);
			this.btnCheckCust.TabIndex = 9;
			this.btnCheckCust.Text = "Check customer information";
			this.btnCheckCust.UseVisualStyleBackColor = false;
			this.btnCheckCust.Click += new System.EventHandler(this.BtnCheckCustClick);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label9);
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.txtPname);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.txtPrice);
			this.groupBox1.Controls.Add(this.txtQty);
			this.groupBox1.Controls.Add(this.txtPCode);
			this.groupBox1.Controls.Add(this.txtShipAdd);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.txtBillDate);
			this.groupBox1.Controls.Add(this.txtCname);
			this.groupBox1.Controls.Add(this.txtBillNo);
			this.groupBox1.Location = new System.Drawing.Point(13, 274);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(460, 353);
			this.groupBox1.TabIndex = 10;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Order Details";
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(222, 300);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(66, 23);
			this.label9.TabIndex = 29;
			this.label9.Text = "Price";
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(6, 300);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(67, 23);
			this.label8.TabIndex = 28;
			this.label8.Text = "QTY\r\n";
			this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(6, 242);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(91, 53);
			this.label7.TabIndex = 27;
			this.label7.Text = "Product\r\nName";
			this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// txtPname
			// 
			this.txtPname.Location = new System.Drawing.Point(100, 251);
			this.txtPname.Name = "txtPname";
			this.txtPname.Size = new System.Drawing.Size(354, 31);
			this.txtPname.TabIndex = 26;
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(7, 211);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(145, 23);
			this.label6.TabIndex = 25;
			this.label6.Text = "Product Code";
			// 
			// txtPrice
			// 
			this.txtPrice.Location = new System.Drawing.Point(294, 295);
			this.txtPrice.Name = "txtPrice";
			this.txtPrice.Size = new System.Drawing.Size(152, 31);
			this.txtPrice.TabIndex = 24;
			// 
			// txtQty
			// 
			this.txtQty.Location = new System.Drawing.Point(100, 297);
			this.txtQty.Name = "txtQty";
			this.txtQty.Size = new System.Drawing.Size(108, 31);
			this.txtQty.TabIndex = 23;
			// 
			// txtPCode
			// 
			this.txtPCode.Location = new System.Drawing.Point(158, 208);
			this.txtPCode.Name = "txtPCode";
			this.txtPCode.Size = new System.Drawing.Size(103, 31);
			this.txtPCode.TabIndex = 22;
			// 
			// txtShipAdd
			// 
			this.txtShipAdd.Location = new System.Drawing.Point(7, 148);
			this.txtShipAdd.Multiline = true;
			this.txtShipAdd.Name = "txtShipAdd";
			this.txtShipAdd.Size = new System.Drawing.Size(447, 54);
			this.txtShipAdd.TabIndex = 21;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(13, 120);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(176, 23);
			this.label5.TabIndex = 20;
			this.label5.Text = "Shipping Address";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(7, 61);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(163, 23);
			this.label4.TabIndex = 19;
			this.label4.Text = "Customer Name";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(195, 30);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(55, 23);
			this.label3.TabIndex = 18;
			this.label3.Text = "Date";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(7, 30);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(73, 23);
			this.label1.TabIndex = 17;
			this.label1.Text = "Bill No.";
			// 
			// txtBillDate
			// 
			this.txtBillDate.Location = new System.Drawing.Point(256, 27);
			this.txtBillDate.Multiline = true;
			this.txtBillDate.Name = "txtBillDate";
			this.txtBillDate.Size = new System.Drawing.Size(198, 54);
			this.txtBillDate.TabIndex = 16;
			// 
			// txtCname
			// 
			this.txtCname.Location = new System.Drawing.Point(7, 87);
			this.txtCname.Name = "txtCname";
			this.txtCname.Size = new System.Drawing.Size(447, 31);
			this.txtCname.TabIndex = 15;
			// 
			// txtBillNo
			// 
			this.txtBillNo.Location = new System.Drawing.Point(86, 27);
			this.txtBillNo.Name = "txtBillNo";
			this.txtBillNo.Size = new System.Drawing.Size(103, 31);
			this.txtBillNo.TabIndex = 14;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.cmbEmpId);
			this.groupBox2.Controls.Add(this.cmbOrdStatus);
			this.groupBox2.Controls.Add(this.label15);
			this.groupBox2.Controls.Add(this.label14);
			this.groupBox2.Controls.Add(this.label13);
			this.groupBox2.Controls.Add(this.label12);
			this.groupBox2.Controls.Add(this.cmbPayMet);
			this.groupBox2.Controls.Add(this.label11);
			this.groupBox2.Controls.Add(this.label10);
			this.groupBox2.Controls.Add(this.cmbShipMet);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Controls.Add(this.txtDiscountCode);
			this.groupBox2.Controls.Add(this.txtTotalAmount);
			this.groupBox2.Controls.Add(this.txtShipFee);
			this.groupBox2.Location = new System.Drawing.Point(479, 274);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(356, 353);
			this.groupBox2.TabIndex = 18;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Confirm order";
			// 
			// cmbEmpId
			// 
			this.cmbEmpId.FormattingEnabled = true;
			this.cmbEmpId.Items.AddRange(new object[] {
									"EMP-0143",
									"EMP-0187",
									"EMP-0290",
									"EMP-0199",
									"EMP-0322"});
			this.cmbEmpId.Location = new System.Drawing.Point(188, 300);
			this.cmbEmpId.Name = "cmbEmpId";
			this.cmbEmpId.Size = new System.Drawing.Size(156, 31);
			this.cmbEmpId.TabIndex = 22;
			// 
			// cmbOrdStatus
			// 
			this.cmbOrdStatus.FormattingEnabled = true;
			this.cmbOrdStatus.Items.AddRange(new object[] {
									"Shipped",
									"Not Ready",
									"     "});
			this.cmbOrdStatus.Location = new System.Drawing.Point(188, 257);
			this.cmbOrdStatus.Name = "cmbOrdStatus";
			this.cmbOrdStatus.Size = new System.Drawing.Size(156, 31);
			this.cmbOrdStatus.TabIndex = 29;
			// 
			// label15
			// 
			this.label15.Location = new System.Drawing.Point(12, 303);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(170, 23);
			this.label15.TabIndex = 28;
			this.label15.Text = "Employee Id";
			// 
			// label14
			// 
			this.label14.Location = new System.Drawing.Point(12, 216);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(170, 23);
			this.label14.TabIndex = 26;
			this.label14.Text = "Total Amount";
			// 
			// label13
			// 
			this.label13.Location = new System.Drawing.Point(11, 126);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(170, 23);
			this.label13.TabIndex = 25;
			this.label13.Text = "Shipping fee";
			// 
			// label12
			// 
			this.label12.Location = new System.Drawing.Point(13, 260);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(135, 23);
			this.label12.TabIndex = 22;
			this.label12.Text = "Order Status\r\n";
			// 
			// cmbPayMet
			// 
			this.cmbPayMet.FormattingEnabled = true;
			this.cmbPayMet.Items.AddRange(new object[] {
									"Bank",
									"VISA",
									"Master card",
									"Paypal",
									"     "});
			this.cmbPayMet.Location = new System.Drawing.Point(188, 171);
			this.cmbPayMet.Name = "cmbPayMet";
			this.cmbPayMet.Size = new System.Drawing.Size(156, 31);
			this.cmbPayMet.TabIndex = 21;
			// 
			// label11
			// 
			this.label11.Location = new System.Drawing.Point(13, 174);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(170, 23);
			this.label11.TabIndex = 20;
			this.label11.Text = "Payment method";
			// 
			// label10
			// 
			this.label10.Location = new System.Drawing.Point(12, 40);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(170, 23);
			this.label10.TabIndex = 19;
			this.label10.Text = "Discount Code";
			// 
			// cmbShipMet
			// 
			this.cmbShipMet.FormattingEnabled = true;
			this.cmbShipMet.Items.AddRange(new object[] {
									"Registered",
									"EMS",
									"     "});
			this.cmbShipMet.Location = new System.Drawing.Point(188, 76);
			this.cmbShipMet.Name = "cmbShipMet";
			this.cmbShipMet.Size = new System.Drawing.Size(156, 31);
			this.cmbShipMet.TabIndex = 18;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(12, 79);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(170, 23);
			this.label2.TabIndex = 17;
			this.label2.Text = "Shipping method";
			// 
			// txtDiscountCode
			// 
			this.txtDiscountCode.Location = new System.Drawing.Point(188, 32);
			this.txtDiscountCode.Name = "txtDiscountCode";
			this.txtDiscountCode.Size = new System.Drawing.Size(155, 31);
			this.txtDiscountCode.TabIndex = 16;
			// 
			// txtTotalAmount
			// 
			this.txtTotalAmount.Location = new System.Drawing.Point(188, 216);
			this.txtTotalAmount.Name = "txtTotalAmount";
			this.txtTotalAmount.Size = new System.Drawing.Size(156, 31);
			this.txtTotalAmount.TabIndex = 15;
			// 
			// txtShipFee
			// 
			this.txtShipFee.Location = new System.Drawing.Point(188, 123);
			this.txtShipFee.Name = "txtShipFee";
			this.txtShipFee.Size = new System.Drawing.Size(155, 31);
			this.txtShipFee.TabIndex = 14;
			// 
			// btnCancel
			// 
			this.btnCancel.BackColor = System.Drawing.Color.Red;
			this.btnCancel.FlatAppearance.BorderSize = 0;
			this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCancel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCancel.ForeColor = System.Drawing.Color.White;
			this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnCancel.Location = new System.Drawing.Point(864, 538);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(183, 49);
			this.btnCancel.TabIndex = 19;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = false;
			this.btnCancel.Click += new System.EventHandler(this.BtnCancelClick);
			// 
			// label16
			// 
			this.label16.Location = new System.Drawing.Point(745, 14);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(77, 23);
			this.label16.TabIndex = 20;
			this.label16.Text = "Today :";
			// 
			// txtSearch
			// 
			this.txtSearch.Location = new System.Drawing.Point(251, 11);
			this.txtSearch.Name = "txtSearch";
			this.txtSearch.Size = new System.Drawing.Size(332, 31);
			this.txtSearch.TabIndex = 3;
			this.txtSearch.TextChanged += new System.EventHandler(this.TxtSearchTextChanged);
			// 
			// Order
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.BackColor = System.Drawing.Color.GhostWhite;
			this.ClientSize = new System.Drawing.Size(1059, 639);
			this.Controls.Add(this.label16);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.btnCheckCust);
			this.Controls.Add(this.btnConfirmOrd);
			this.Controls.Add(this.btnCheckProduct);
			this.Controls.Add(this.lblDate);
			this.Controls.Add(this.txtSearch);
			this.Controls.Add(this.btnLook);
			this.Controls.Add(this.listView1);
			this.Controls.Add(this.btnBack);
			this.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
			this.Name = "Order";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Order";
			this.Load += new System.EventHandler(this.OrderLoad);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.ComboBox cmbEmpId;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.ComboBox cmbOrdStatus;
		private System.Windows.Forms.ColumnHeader columnHeader14;
		private System.Windows.Forms.ColumnHeader columnHeader13;
		private System.Windows.Forms.ColumnHeader columnHeader12;
		private System.Windows.Forms.ColumnHeader columnHeader15;
		private System.Windows.Forms.Button btnLook;
		private System.Windows.Forms.Button btnConfirmOrd;
		private System.Windows.Forms.Button btnCheckProduct;
		private System.Windows.Forms.Button btnCheckCust;
		private System.Windows.Forms.TextBox txtPname;
		private System.Windows.Forms.TextBox txtPrice;
		private System.Windows.Forms.TextBox txtQty;
		private System.Windows.Forms.TextBox txtPCode;
		private System.Windows.Forms.TextBox txtShipAdd;
		private System.Windows.Forms.TextBox txtBillDate;
		private System.Windows.Forms.TextBox txtCname;
		private System.Windows.Forms.TextBox txtBillNo;
		private System.Windows.Forms.TextBox txtDiscountCode;
		private System.Windows.Forms.TextBox txtTotalAmount;
		private System.Windows.Forms.TextBox txtShipFee;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.ComboBox cmbShipMet;
		private System.Windows.Forms.ComboBox cmbPayMet;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label lblDate;
		private System.Windows.Forms.TextBox txtSearch;
		private System.Windows.Forms.ColumnHeader columnHeader10;
		private System.Windows.Forms.ColumnHeader columnHeader8;
		private System.Windows.Forms.ColumnHeader columnHeader7;
		private System.Windows.Forms.ColumnHeader columnHeader9;
		private System.Windows.Forms.ColumnHeader columnHeader6;
		private System.Windows.Forms.ColumnHeader columnHeader5;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.ColumnHeader columnHeader11;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.Button btnBack;
	}
}

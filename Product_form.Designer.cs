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
	partial class Product
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Product));
			this.btnBack = new System.Windows.Forms.Button();
			this.listView1 = new System.Windows.Forms.ListView();
			this.colCode = new System.Windows.Forms.ColumnHeader();
			this.colName = new System.Windows.Forms.ColumnHeader();
			this.colCategory = new System.Windows.Forms.ColumnHeader();
			this.colCost = new System.Windows.Forms.ColumnHeader();
			this.colPrice = new System.Windows.Forms.ColumnHeader();
			this.colQty = new System.Windows.Forms.ColumnHeader();
			this.txtName = new System.Windows.Forms.TextBox();
			this.btnNew = new System.Windows.Forms.Button();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnClear = new System.Windows.Forms.Button();
			this.txtSellingPrice = new System.Windows.Forms.TextBox();
			this.txtQuantity = new System.Windows.Forms.TextBox();
			this.txtCost = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.cmbcategory = new System.Windows.Forms.ComboBox();
			this.label6 = new System.Windows.Forms.Label();
			this.txtsearch = new System.Windows.Forms.TextBox();
			this.button2 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.txtProductCode = new System.Windows.Forms.TextBox();
			this.txtpic = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnBack
			// 
			this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnBack.FlatAppearance.BorderSize = 0;
			this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnBack.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
			this.btnBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnBack.Location = new System.Drawing.Point(12, 13);
			this.btnBack.Name = "btnBack";
			this.btnBack.Size = new System.Drawing.Size(133, 42);
			this.btnBack.TabIndex = 2;
			this.btnBack.Text = "BACK";
			this.btnBack.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnBack.UseVisualStyleBackColor = true;
			this.btnBack.Click += new System.EventHandler(this.BtnBackClick);
			// 
			// listView1
			// 
			this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
									this.colCode,
									this.colName,
									this.colCategory,
									this.colCost,
									this.colPrice,
									this.colQty});
			this.listView1.FullRowSelect = true;
			this.listView1.GridLines = true;
			this.listView1.Location = new System.Drawing.Point(12, 81);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(1025, 266);
			this.listView1.TabIndex = 4;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = System.Windows.Forms.View.Details;
			this.listView1.SelectedIndexChanged += new System.EventHandler(this.ListView1SelectedIndexChanged);
			// 
			// colCode
			// 
			this.colCode.Text = "Product ID";
			this.colCode.Width = 112;
			// 
			// colName
			// 
			this.colName.Text = "Product Description";
			this.colName.Width = 385;
			// 
			// colCategory
			// 
			this.colCategory.Text = "Category";
			this.colCategory.Width = 117;
			// 
			// colCost
			// 
			this.colCost.Text = "Unit Cost";
			this.colCost.Width = 126;
			// 
			// colPrice
			// 
			this.colPrice.Text = "Selling Price";
			this.colPrice.Width = 130;
			// 
			// colQty
			// 
			this.colQty.Text = "Quantity In Stock";
			this.colQty.Width = 182;
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(27, 445);
			this.txtName.Multiline = true;
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(339, 34);
			this.txtName.TabIndex = 5;
			// 
			// btnNew
			// 
			this.btnNew.BackColor = System.Drawing.Color.Green;
			this.btnNew.FlatAppearance.BorderSize = 0;
			this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnNew.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnNew.ForeColor = System.Drawing.Color.White;
			this.btnNew.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnNew.Location = new System.Drawing.Point(854, 368);
			this.btnNew.Name = "btnNew";
			this.btnNew.Size = new System.Drawing.Size(183, 48);
			this.btnNew.TabIndex = 6;
			this.btnNew.Text = "Add New Product";
			this.btnNew.UseVisualStyleBackColor = false;
			this.btnNew.Click += new System.EventHandler(this.BtnNewClick);
			// 
			// btnUpdate
			// 
			this.btnUpdate.BackColor = System.Drawing.Color.Sienna;
			this.btnUpdate.FlatAppearance.BorderSize = 0;
			this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnUpdate.ForeColor = System.Drawing.Color.White;
			this.btnUpdate.Location = new System.Drawing.Point(854, 431);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(183, 48);
			this.btnUpdate.TabIndex = 7;
			this.btnUpdate.Text = "Edit";
			this.btnUpdate.UseVisualStyleBackColor = false;
			this.btnUpdate.Click += new System.EventHandler(this.BtnUpdateClick);
			// 
			// btnDelete
			// 
			this.btnDelete.BackColor = System.Drawing.Color.Red;
			this.btnDelete.FlatAppearance.BorderSize = 0;
			this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDelete.ForeColor = System.Drawing.Color.White;
			this.btnDelete.Location = new System.Drawing.Point(854, 496);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(183, 48);
			this.btnDelete.TabIndex = 8;
			this.btnDelete.Text = "Delete";
			this.btnDelete.UseVisualStyleBackColor = false;
			this.btnDelete.Click += new System.EventHandler(this.BtnDeleteClick);
			// 
			// btnClear
			// 
			this.btnClear.BackColor = System.Drawing.Color.DarkBlue;
			this.btnClear.FlatAppearance.BorderSize = 0;
			this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnClear.ForeColor = System.Drawing.Color.White;
			this.btnClear.Location = new System.Drawing.Point(854, 562);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(183, 48);
			this.btnClear.TabIndex = 9;
			this.btnClear.Text = "Clear";
			this.btnClear.UseVisualStyleBackColor = false;
			this.btnClear.Click += new System.EventHandler(this.BtnClearClick);
			// 
			// txtSellingPrice
			// 
			this.txtSellingPrice.Location = new System.Drawing.Point(421, 522);
			this.txtSellingPrice.Name = "txtSellingPrice";
			this.txtSellingPrice.Size = new System.Drawing.Size(396, 31);
			this.txtSellingPrice.TabIndex = 10;
			// 
			// txtQuantity
			// 
			this.txtQuantity.Location = new System.Drawing.Point(641, 448);
			this.txtQuantity.Name = "txtQuantity";
			this.txtQuantity.Size = new System.Drawing.Size(176, 31);
			this.txtQuantity.TabIndex = 11;
			// 
			// txtCost
			// 
			this.txtCost.Location = new System.Drawing.Point(423, 448);
			this.txtCost.Name = "txtCost";
			this.txtCost.Size = new System.Drawing.Size(194, 31);
			this.txtCost.TabIndex = 12;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(421, 360);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(196, 23);
			this.label2.TabIndex = 13;
			this.label2.Text = "Category :";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(423, 421);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 14;
			this.label3.Text = "Cost :";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(27, 419);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(339, 25);
			this.label4.TabIndex = 15;
			this.label4.Text = "Name :";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(421, 491);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(134, 28);
			this.label5.TabIndex = 16;
			this.label5.Text = "Selling Price :";
			// 
			// cmbcategory
			// 
			this.cmbcategory.FormattingEnabled = true;
			this.cmbcategory.Items.AddRange(new object[] {
									"Noru",
									"Nendoroid",
									"Figure",
									"Standy"});
			this.cmbcategory.Location = new System.Drawing.Point(421, 385);
			this.cmbcategory.Name = "cmbcategory";
			this.cmbcategory.Size = new System.Drawing.Size(396, 31);
			this.cmbcategory.TabIndex = 17;
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(641, 419);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 23);
			this.label6.TabIndex = 18;
			this.label6.Text = "Qauntity :";
			// 
			// txtsearch
			// 
			this.txtsearch.Location = new System.Drawing.Point(740, 24);
			this.txtsearch.Name = "txtsearch";
			this.txtsearch.Size = new System.Drawing.Size(253, 31);
			this.txtsearch.TabIndex = 22;
			this.txtsearch.TextChanged += new System.EventHandler(this.txtsearchTextChanged);
			// 
			// button2
			// 
			this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
			this.button2.Location = new System.Drawing.Point(999, 24);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(38, 32);
			this.button2.TabIndex = 23;
			this.button2.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(27, 359);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(160, 23);
			this.label1.TabIndex = 25;
			this.label1.Text = "Product Code :";
			// 
			// txtProductCode
			// 
			this.txtProductCode.Enabled = false;
			this.txtProductCode.Location = new System.Drawing.Point(27, 385);
			this.txtProductCode.Name = "txtProductCode";
			this.txtProductCode.Size = new System.Drawing.Size(339, 31);
			this.txtProductCode.TabIndex = 24;
			// 
			// txtpic
			// 
			this.txtpic.Location = new System.Drawing.Point(27, 522);
			this.txtpic.Multiline = true;
			this.txtpic.Name = "txtpic";
			this.txtpic.Size = new System.Drawing.Size(339, 34);
			this.txtpic.TabIndex = 26;
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(27, 491);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(134, 28);
			this.label7.TabIndex = 27;
			this.label7.Text = "Picture file :";
			// 
			// Product
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.GhostWhite;
			this.ClientSize = new System.Drawing.Size(1059, 639);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.txtpic);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtProductCode);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.txtsearch);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.cmbcategory);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtCost);
			this.Controls.Add(this.txtQuantity);
			this.Controls.Add(this.txtSellingPrice);
			this.Controls.Add(this.btnClear);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.btnNew);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.listView1);
			this.Controls.Add(this.btnBack);
			this.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(6);
			this.Name = "Product";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Product";
			this.Load += new System.EventHandler(this.ProductLoad);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button btnClear;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtpic;
		private System.Windows.Forms.TextBox txtsearch;
		private System.Windows.Forms.ColumnHeader colCode;
		private System.Windows.Forms.ColumnHeader colName;
		private System.Windows.Forms.ColumnHeader colCategory;
		private System.Windows.Forms.ColumnHeader colCost;
		private System.Windows.Forms.ColumnHeader colPrice;
		private System.Windows.Forms.ColumnHeader colQty;
		private System.Windows.Forms.TextBox txtQuantity;
		private System.Windows.Forms.TextBox txtProductCode;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cmbcategory;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.TextBox txtSellingPrice;
		private System.Windows.Forms.TextBox txtCost;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button btnNew;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.Button btnBack;
	}
}

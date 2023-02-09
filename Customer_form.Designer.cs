/*
 * Created by SharpDevelop.
 * User: ACER
 * Date: 2/17/2022
 * Time: 11:36 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace thansuda_6213841
{
	partial class Customer
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customer));
			this.btnBack = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label8 = new System.Windows.Forms.Label();
			this.txtZipcode = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtAddress = new System.Windows.Forms.TextBox();
			this.txtFirstname = new System.Windows.Forms.TextBox();
			this.txtPhonenumber = new System.Windows.Forms.TextBox();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.txtLastname = new System.Windows.Forms.TextBox();
			this.cmbStatus = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtCustomerId = new System.Windows.Forms.TextBox();
			this.btnClear = new System.Windows.Forms.Button();
			this.bynDelete = new System.Windows.Forms.Button();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.btnAdd = new System.Windows.Forms.Button();
			this.txtsearch = new System.Windows.Forms.TextBox();
			this.btnSearch = new System.Windows.Forms.Button();
			this.listView1 = new System.Windows.Forms.ListView();
			this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader8 = new System.Windows.Forms.ColumnHeader();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnBack
			// 
			this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnBack.FlatAppearance.BorderSize = 0;
			this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
			this.btnBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnBack.Location = new System.Drawing.Point(13, 14);
			this.btnBack.Name = "btnBack";
			this.btnBack.Size = new System.Drawing.Size(114, 49);
			this.btnBack.TabIndex = 0;
			this.btnBack.Text = "BACK";
			this.btnBack.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnBack.UseVisualStyleBackColor = true;
			this.btnBack.Click += new System.EventHandler(this.BtnBackClick);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.txtZipcode);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.txtAddress);
			this.groupBox1.Controls.Add(this.txtFirstname);
			this.groupBox1.Controls.Add(this.txtPhonenumber);
			this.groupBox1.Controls.Add(this.txtEmail);
			this.groupBox1.Controls.Add(this.txtLastname);
			this.groupBox1.Controls.Add(this.cmbStatus);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.txtCustomerId);
			this.groupBox1.Controls.Add(this.btnClear);
			this.groupBox1.Controls.Add(this.bynDelete);
			this.groupBox1.Controls.Add(this.btnUpdate);
			this.groupBox1.Controls.Add(this.btnAdd);
			this.groupBox1.Location = new System.Drawing.Point(25, 352);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(1007, 275);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Customer Information";
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(512, 170);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(115, 23);
			this.label8.TabIndex = 19;
			this.label8.Text = "Zip Code :";
			// 
			// txtZipcode
			// 
			this.txtZipcode.Location = new System.Drawing.Point(512, 196);
			this.txtZipcode.Name = "txtZipcode";
			this.txtZipcode.Size = new System.Drawing.Size(129, 31);
			this.txtZipcode.TabIndex = 18;
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(18, 98);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(100, 23);
			this.label7.TabIndex = 17;
			this.label7.Text = "Status :";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(163, 163);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 23);
			this.label6.TabIndex = 16;
			this.label6.Text = "Address :";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(512, 98);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(172, 23);
			this.label5.TabIndex = 15;
			this.label5.Text = "Phone Number :";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(163, 98);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(157, 23);
			this.label4.TabIndex = 14;
			this.label4.Text = "Email :";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(512, 27);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(184, 23);
			this.label3.TabIndex = 13;
			this.label3.Text = "Last name :";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(163, 28);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(143, 23);
			this.label2.TabIndex = 12;
			this.label2.Text = "First name :";
			// 
			// txtAddress
			// 
			this.txtAddress.Location = new System.Drawing.Point(163, 196);
			this.txtAddress.Multiline = true;
			this.txtAddress.Name = "txtAddress";
			this.txtAddress.Size = new System.Drawing.Size(301, 31);
			this.txtAddress.TabIndex = 11;
			// 
			// txtFirstname
			// 
			this.txtFirstname.Location = new System.Drawing.Point(163, 56);
			this.txtFirstname.Name = "txtFirstname";
			this.txtFirstname.Size = new System.Drawing.Size(301, 31);
			this.txtFirstname.TabIndex = 10;
			// 
			// txtPhonenumber
			// 
			this.txtPhonenumber.Location = new System.Drawing.Point(512, 124);
			this.txtPhonenumber.Name = "txtPhonenumber";
			this.txtPhonenumber.Size = new System.Drawing.Size(301, 31);
			this.txtPhonenumber.TabIndex = 9;
			// 
			// txtEmail
			// 
			this.txtEmail.Location = new System.Drawing.Point(163, 124);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(301, 31);
			this.txtEmail.TabIndex = 8;
			// 
			// txtLastname
			// 
			this.txtLastname.Location = new System.Drawing.Point(512, 56);
			this.txtLastname.Name = "txtLastname";
			this.txtLastname.Size = new System.Drawing.Size(301, 31);
			this.txtLastname.TabIndex = 7;
			// 
			// cmbStatus
			// 
			this.cmbStatus.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbStatus.FormattingEnabled = true;
			this.cmbStatus.Items.AddRange(new object[] {
									"Membership",
									"Non-membership"});
			this.cmbStatus.Location = new System.Drawing.Point(18, 124);
			this.cmbStatus.Name = "cmbStatus";
			this.cmbStatus.Size = new System.Drawing.Size(121, 24);
			this.cmbStatus.TabIndex = 6;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(18, 30);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 5;
			this.label1.Text = "ID :";
			// 
			// txtCustomerId
			// 
			this.txtCustomerId.Enabled = false;
			this.txtCustomerId.Location = new System.Drawing.Point(18, 56);
			this.txtCustomerId.Name = "txtCustomerId";
			this.txtCustomerId.Size = new System.Drawing.Size(100, 31);
			this.txtCustomerId.TabIndex = 4;
			// 
			// btnClear
			// 
			this.btnClear.BackColor = System.Drawing.Color.Goldenrod;
			this.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.Goldenrod;
			this.btnClear.FlatAppearance.BorderSize = 3;
			this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnClear.ForeColor = System.Drawing.Color.White;
			this.btnClear.Location = new System.Drawing.Point(865, 196);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(126, 45);
			this.btnClear.TabIndex = 3;
			this.btnClear.Text = "Clear";
			this.btnClear.UseVisualStyleBackColor = false;
			this.btnClear.Click += new System.EventHandler(this.BtnClearClick);
			// 
			// bynDelete
			// 
			this.bynDelete.BackColor = System.Drawing.Color.Red;
			this.bynDelete.FlatAppearance.BorderColor = System.Drawing.Color.Red;
			this.bynDelete.FlatAppearance.BorderSize = 3;
			this.bynDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.bynDelete.ForeColor = System.Drawing.Color.White;
			this.bynDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.bynDelete.Location = new System.Drawing.Point(865, 140);
			this.bynDelete.Name = "bynDelete";
			this.bynDelete.Size = new System.Drawing.Size(126, 46);
			this.bynDelete.TabIndex = 2;
			this.bynDelete.Text = "Delete";
			this.bynDelete.UseVisualStyleBackColor = false;
			this.bynDelete.Click += new System.EventHandler(this.BynDeleteClick);
			// 
			// btnUpdate
			// 
			this.btnUpdate.BackColor = System.Drawing.Color.SteelBlue;
			this.btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnUpdate.FlatAppearance.BorderSize = 3;
			this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnUpdate.ForeColor = System.Drawing.Color.White;
			this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnUpdate.Location = new System.Drawing.Point(865, 84);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(126, 46);
			this.btnUpdate.TabIndex = 1;
			this.btnUpdate.Text = "Edit";
			this.btnUpdate.UseVisualStyleBackColor = false;
			this.btnUpdate.Click += new System.EventHandler(this.BtnUpdateClick);
			// 
			// btnAdd
			// 
			this.btnAdd.BackColor = System.Drawing.Color.Green;
			this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.Green;
			this.btnAdd.FlatAppearance.BorderSize = 3;
			this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAdd.ForeColor = System.Drawing.Color.White;
			this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnAdd.Location = new System.Drawing.Point(865, 28);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(126, 46);
			this.btnAdd.TabIndex = 0;
			this.btnAdd.Text = " Add";
			this.btnAdd.UseVisualStyleBackColor = false;
			this.btnAdd.Click += new System.EventHandler(this.BtnAddClick);
			// 
			// txtsearch
			// 
			this.txtsearch.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtsearch.Location = new System.Drawing.Point(733, 14);
			this.txtsearch.Name = "txtsearch";
			this.txtsearch.Size = new System.Drawing.Size(242, 31);
			this.txtsearch.TabIndex = 3;
			this.txtsearch.Text = "...";
			this.txtsearch.TextChanged += new System.EventHandler(this.TxtsearchTextChanged);
			// 
			// btnSearch
			// 
			this.btnSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.BackgroundImage")));
			this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnSearch.Location = new System.Drawing.Point(981, 14);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(51, 30);
			this.btnSearch.TabIndex = 4;
			this.btnSearch.UseVisualStyleBackColor = true;
			// 
			// listView1
			// 
			this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
									this.columnHeader1,
									this.columnHeader2,
									this.columnHeader3,
									this.columnHeader4,
									this.columnHeader5,
									this.columnHeader6,
									this.columnHeader7,
									this.columnHeader8});
			this.listView1.FullRowSelect = true;
			this.listView1.GridLines = true;
			this.listView1.Location = new System.Drawing.Point(25, 86);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(1007, 260);
			this.listView1.TabIndex = 5;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = System.Windows.Forms.View.Details;
			this.listView1.SelectedIndexChanged += new System.EventHandler(this.ListView1SelectedIndexChanged);
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Customer ID";
			this.columnHeader1.Width = 139;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "First Name";
			this.columnHeader2.Width = 202;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Last Name";
			this.columnHeader3.Width = 185;
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "Email";
			this.columnHeader4.Width = 196;
			// 
			// columnHeader5
			// 
			this.columnHeader5.Text = "Phone number";
			this.columnHeader5.Width = 195;
			// 
			// columnHeader6
			// 
			this.columnHeader6.Text = "Status";
			this.columnHeader6.Width = 114;
			// 
			// columnHeader7
			// 
			this.columnHeader7.Text = "Address";
			this.columnHeader7.Width = 300;
			// 
			// columnHeader8
			// 
			this.columnHeader8.Text = "Zip code";
			this.columnHeader8.Width = 150;
			// 
			// Customer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.GhostWhite;
			this.ClientSize = new System.Drawing.Size(1059, 639);
			this.Controls.Add(this.listView1);
			this.Controls.Add(this.btnSearch);
			this.Controls.Add(this.txtsearch);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.btnBack);
			this.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
			this.Name = "Customer";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Customer";
			this.Load += new System.EventHandler(this.CustomerLoad);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button btnClear;
		private System.Windows.Forms.TextBox txtsearch;
		private System.Windows.Forms.TextBox txtCustomerId;
		private System.Windows.Forms.TextBox txtAddress;
		private System.Windows.Forms.ColumnHeader columnHeader8;
		private System.Windows.Forms.ColumnHeader columnHeader7;
		private System.Windows.Forms.ColumnHeader columnHeader6;
		private System.Windows.Forms.ColumnHeader columnHeader5;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.Button bynDelete;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cmbStatus;
		private System.Windows.Forms.TextBox txtLastname;
		private System.Windows.Forms.TextBox txtEmail;
		private System.Windows.Forms.TextBox txtPhonenumber;
		private System.Windows.Forms.TextBox txtFirstname;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtZipcode;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Button btnSearch;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnBack;
	}
}

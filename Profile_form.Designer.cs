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
	partial class Profile
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Profile));
			this.btnBack = new System.Windows.Forms.Button();
			this.photobox = new System.Windows.Forms.PictureBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label9 = new System.Windows.Forms.Label();
			this.txtDateofBirth = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.txtPhonenumber = new System.Windows.Forms.TextBox();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.txtAddress = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.txtGender = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtRole = new System.Windows.Forms.TextBox();
			this.txtFirstname = new System.Windows.Forms.TextBox();
			this.txtUsername = new System.Windows.Forms.TextBox();
			this.txtEmpid = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnChangePassword = new System.Windows.Forms.Button();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.lblUsername = new System.Windows.Forms.Label();
			this.txtLastname = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.photobox)).BeginInit();
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
			this.btnBack.Location = new System.Drawing.Point(12, 12);
			this.btnBack.Name = "btnBack";
			this.btnBack.Size = new System.Drawing.Size(114, 48);
			this.btnBack.TabIndex = 0;
			this.btnBack.Text = "BACK";
			this.btnBack.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnBack.UseVisualStyleBackColor = true;
			this.btnBack.Click += new System.EventHandler(this.BtnBackClick);
			// 
			// photobox
			// 
			this.photobox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.photobox.Location = new System.Drawing.Point(65, 77);
			this.photobox.Name = "photobox";
			this.photobox.Size = new System.Drawing.Size(173, 147);
			this.photobox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.photobox.TabIndex = 1;
			this.photobox.TabStop = false;
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.LightSkyBlue;
			this.groupBox1.Controls.Add(this.label10);
			this.groupBox1.Controls.Add(this.txtLastname);
			this.groupBox1.Controls.Add(this.label9);
			this.groupBox1.Controls.Add(this.txtDateofBirth);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.txtPhonenumber);
			this.groupBox1.Controls.Add(this.txtEmail);
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.txtAddress);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.txtGender);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.txtRole);
			this.groupBox1.Controls.Add(this.txtFirstname);
			this.groupBox1.Controls.Add(this.txtUsername);
			this.groupBox1.Controls.Add(this.txtEmpid);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.ForeColor = System.Drawing.Color.DarkBlue;
			this.groupBox1.Location = new System.Drawing.Point(288, 77);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(749, 449);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Profile";
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(364, 193);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(133, 23);
			this.label9.TabIndex = 21;
			this.label9.Text = "Date of Birth :";
			// 
			// txtDateofBirth
			// 
			this.txtDateofBirth.Location = new System.Drawing.Point(499, 190);
			this.txtDateofBirth.Name = "txtDateofBirth";
			this.txtDateofBirth.Size = new System.Drawing.Size(186, 31);
			this.txtDateofBirth.TabIndex = 20;
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(24, 384);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(153, 23);
			this.label6.TabIndex = 19;
			this.label6.Text = "Phone number :";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(24, 344);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(127, 23);
			this.label5.TabIndex = 18;
			this.label5.Text = "Email :";
			// 
			// txtPhonenumber
			// 
			this.txtPhonenumber.Location = new System.Drawing.Point(183, 384);
			this.txtPhonenumber.Name = "txtPhonenumber";
			this.txtPhonenumber.Size = new System.Drawing.Size(502, 31);
			this.txtPhonenumber.TabIndex = 17;
			// 
			// txtEmail
			// 
			this.txtEmail.Location = new System.Drawing.Point(183, 336);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(502, 31);
			this.txtEmail.TabIndex = 16;
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(24, 239);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(153, 23);
			this.label8.TabIndex = 11;
			this.label8.Text = "Address :";
			// 
			// txtAddress
			// 
			this.txtAddress.Location = new System.Drawing.Point(183, 239);
			this.txtAddress.Multiline = true;
			this.txtAddress.Name = "txtAddress";
			this.txtAddress.Size = new System.Drawing.Size(502, 73);
			this.txtAddress.TabIndex = 10;
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(24, 190);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(139, 23);
			this.label7.TabIndex = 9;
			this.label7.Text = "Gender :";
			// 
			// txtGender
			// 
			this.txtGender.Location = new System.Drawing.Point(183, 190);
			this.txtGender.Name = "txtGender";
			this.txtGender.Size = new System.Drawing.Size(175, 31);
			this.txtGender.TabIndex = 8;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(24, 140);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(139, 23);
			this.label4.TabIndex = 7;
			this.label4.Text = "First name :";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(24, 90);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(153, 23);
			this.label3.TabIndex = 6;
			this.label3.Text = "Username :";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(364, 50);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(62, 23);
			this.label2.TabIndex = 5;
			this.label2.Text = "Role :";
			// 
			// txtRole
			// 
			this.txtRole.Location = new System.Drawing.Point(508, 47);
			this.txtRole.Name = "txtRole";
			this.txtRole.Size = new System.Drawing.Size(177, 31);
			this.txtRole.TabIndex = 4;
			// 
			// txtFirstname
			// 
			this.txtFirstname.Location = new System.Drawing.Point(183, 137);
			this.txtFirstname.Name = "txtFirstname";
			this.txtFirstname.Size = new System.Drawing.Size(175, 31);
			this.txtFirstname.TabIndex = 3;
			// 
			// txtUsername
			// 
			this.txtUsername.Location = new System.Drawing.Point(183, 87);
			this.txtUsername.Name = "txtUsername";
			this.txtUsername.Size = new System.Drawing.Size(502, 31);
			this.txtUsername.TabIndex = 2;
			// 
			// txtEmpid
			// 
			this.txtEmpid.AcceptsReturn = true;
			this.txtEmpid.Location = new System.Drawing.Point(183, 44);
			this.txtEmpid.Name = "txtEmpid";
			this.txtEmpid.Size = new System.Drawing.Size(175, 31);
			this.txtEmpid.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(24, 47);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Emp ID :";
			// 
			// btnChangePassword
			// 
			this.btnChangePassword.FlatAppearance.BorderSize = 3;
			this.btnChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnChangePassword.ForeColor = System.Drawing.Color.MidnightBlue;
			this.btnChangePassword.Location = new System.Drawing.Point(854, 553);
			this.btnChangePassword.Name = "btnChangePassword";
			this.btnChangePassword.Size = new System.Drawing.Size(183, 74);
			this.btnChangePassword.TabIndex = 9;
			this.btnChangePassword.Text = "Change password";
			this.btnChangePassword.UseVisualStyleBackColor = true;
			this.btnChangePassword.Click += new System.EventHandler(this.BtnChangePasswordClick);
			// 
			// btnUpdate
			// 
			this.btnUpdate.FlatAppearance.BorderSize = 3;
			this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnUpdate.ForeColor = System.Drawing.Color.DarkGreen;
			this.btnUpdate.Location = new System.Drawing.Point(643, 553);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(183, 74);
			this.btnUpdate.TabIndex = 10;
			this.btnUpdate.Text = "Edit Profile";
			this.btnUpdate.UseVisualStyleBackColor = true;
			this.btnUpdate.Click += new System.EventHandler(this.BtnUpdateClick);
			// 
			// lblUsername
			// 
			this.lblUsername.Location = new System.Drawing.Point(67, 247);
			this.lblUsername.Name = "lblUsername";
			this.lblUsername.Size = new System.Drawing.Size(171, 23);
			this.lblUsername.TabIndex = 11;
			this.lblUsername.Text = "username";
			this.lblUsername.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// txtLastname
			// 
			this.txtLastname.Location = new System.Drawing.Point(499, 132);
			this.txtLastname.Name = "txtLastname";
			this.txtLastname.Size = new System.Drawing.Size(186, 31);
			this.txtLastname.TabIndex = 22;
			// 
			// label10
			// 
			this.label10.Location = new System.Drawing.Point(375, 137);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(118, 23);
			this.label10.TabIndex = 23;
			this.label10.Text = "Last name :";
			// 
			// Profile
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.GhostWhite;
			this.ClientSize = new System.Drawing.Size(1059, 639);
			this.Controls.Add(this.lblUsername);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.btnChangePassword);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.photobox);
			this.Controls.Add(this.btnBack);
			this.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
			this.Name = "Profile";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Profile";
			this.Load += new System.EventHandler(this.ProfileLoad);
			((System.ComponentModel.ISupportInitialize)(this.photobox)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.TextBox txtFirstname;
		private System.Windows.Forms.TextBox txtLastname;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Button btnChangePassword;
		private System.Windows.Forms.PictureBox photobox;
		private System.Windows.Forms.TextBox txtEmpid;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.TextBox txtPhonenumber;
		private System.Windows.Forms.TextBox txtEmail;
		private System.Windows.Forms.TextBox txtRole;
		private System.Windows.Forms.TextBox txtUsername;
		private System.Windows.Forms.TextBox txtDateofBirth;
		private System.Windows.Forms.TextBox txtAddress;
		private System.Windows.Forms.TextBox txtGender;
		private System.Windows.Forms.Label lblUsername;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnBack;
	}
}

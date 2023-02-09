/*
 * Created by SharpDevelop.
 * User: ACER
 * Date: 3/22/2022
 * Time: 7:44 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace thansuda_6213841
{
	partial class Password_form
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
			this.button1 = new System.Windows.Forms.Button();
			this.btnConfirm = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.txtUsername = new System.Windows.Forms.TextBox();
			this.txtOldPass = new System.Windows.Forms.TextBox();
			this.txtNewPass = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(484, 387);
			this.button1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(138, 41);
			this.button1.TabIndex = 0;
			this.button1.Text = "button1";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// btnConfirm
			// 
			this.btnConfirm.BackColor = System.Drawing.Color.Green;
			this.btnConfirm.FlatAppearance.BorderSize = 0;
			this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnConfirm.ForeColor = System.Drawing.Color.White;
			this.btnConfirm.Location = new System.Drawing.Point(134, 211);
			this.btnConfirm.Name = "btnConfirm";
			this.btnConfirm.Size = new System.Drawing.Size(198, 44);
			this.btnConfirm.TabIndex = 1;
			this.btnConfirm.Text = "Confirm";
			this.btnConfirm.UseVisualStyleBackColor = false;
			this.btnConfirm.Click += new System.EventHandler(this.btnConfirmClick);
			// 
			// btnCancel
			// 
			this.btnCancel.BackColor = System.Drawing.Color.Red;
			this.btnCancel.FlatAppearance.BorderSize = 0;
			this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnCancel.ForeColor = System.Drawing.Color.White;
			this.btnCancel.Location = new System.Drawing.Point(352, 211);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(198, 44);
			this.btnCancel.TabIndex = 2;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = false;
			this.btnCancel.Click += new System.EventHandler(this.btnCancelClick);
			// 
			// txtUsername
			// 
			this.txtUsername.Enabled = false;
			this.txtUsername.Location = new System.Drawing.Point(247, 44);
			this.txtUsername.Name = "txtUsername";
			this.txtUsername.Size = new System.Drawing.Size(303, 31);
			this.txtUsername.TabIndex = 3;
			// 
			// txtOldPass
			// 
			this.txtOldPass.Enabled = false;
			this.txtOldPass.Location = new System.Drawing.Point(247, 97);
			this.txtOldPass.Name = "txtOldPass";
			this.txtOldPass.Size = new System.Drawing.Size(303, 31);
			this.txtOldPass.TabIndex = 4;
			// 
			// txtNewPass
			// 
			this.txtNewPass.Location = new System.Drawing.Point(247, 149);
			this.txtNewPass.Name = "txtNewPass";
			this.txtNewPass.Size = new System.Drawing.Size(303, 31);
			this.txtNewPass.TabIndex = 5;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(89, 44);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(152, 23);
			this.label1.TabIndex = 6;
			this.label1.Text = "Username :";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(89, 100);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(152, 23);
			this.label2.TabIndex = 7;
			this.label2.Text = "Old Password :";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(89, 152);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(152, 23);
			this.label3.TabIndex = 8;
			this.label3.Text = "New Password :";
			// 
			// Password_form
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.GhostWhite;
			this.ClientSize = new System.Drawing.Size(640, 276);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtNewPass);
			this.Controls.Add(this.txtOldPass);
			this.Controls.Add(this.txtUsername);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnConfirm);
			this.Controls.Add(this.button1);
			this.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
			this.Name = "Password_form";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Password_form";
			this.Load += new System.EventHandler(this.Password_formLoad);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button btnConfirm;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtNewPass;
		private System.Windows.Forms.TextBox txtOldPass;
		private System.Windows.Forms.TextBox txtUsername;
		private System.Windows.Forms.Button button1;
	}
}

/*
 * Created by SharpDevelop.
 * User: ACER
 * Date: 3/22/2022
 * Time: 7:44 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace thansuda_6213841
{
	/// <summary>
	/// Description of Password_form.
	/// </summary>
	public partial class Password_form : Form
	{
		DataManager m1 = new DataManager("localhost", "thansuda", "root","1234");
		public Password_form()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Password_formLoad(object sender, EventArgs e)
		{
			txtUsername.Text = Global.member.username;
			txtOldPass.Text = Global.member.password;
		}//ef
		
		void btnConfirmClick(object sender, EventArgs e)
		{
			string sql = "update member set password = 'n1' where firstname = 'n2'";
			sql = sql.Replace("n1", txtNewPass.Text);
			sql = sql.Replace("n2", Global.member.firstname);
			m1.ExecuteNonQuery(sql);
			MessageBox.Show("Are you sure to change password to be " +txtNewPass.Text + "?");
			MessageBox.Show("Password have changed!");
		}//ef
		
		void btnCancelClick(object sender, EventArgs e)
		{
			txtNewPass.Clear();
			this.Close();
		}//ef
	}//en
}//ec

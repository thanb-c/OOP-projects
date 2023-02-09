/*
 * Created by SharpDevelop.
 * User: ACER
 * Date: 2/17/2022
 * Time: 11:37 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace thansuda_6213841
{
	/// <summary>
	/// Description of Profile.
	/// </summary>
	public partial class Profile : Form
	{
		DataManager m1 = new DataManager("localhost", "thansuda", "root","1234");
		
		public Profile()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void BtnBackClick(object sender, EventArgs e)
		{
			this.Close();
		}//ef
		
		
		void ProfileLoad(object sender, EventArgs e)
		{ 
			lblUsername.Text = Global.member.firstname;
			//display profile detail of each member who loging in to the system
			displayProfileDetail();
		}//ef
		
		private void displayProfileDetail(){
			
			string sql = "select * from profile where firstname = 'p1'";
			sql = sql.Replace("p1",Global.member.firstname);
			DataTable result = m1.GetDataTable(sql);
			if (result.Rows.Count > 0) {
			string empId 			= result.Rows[0][0].ToString();
			string username 		= result.Rows[0][1].ToString();
			string fname 			= result.Rows[0][2].ToString();
			string lname			= result.Rows[0][3].ToString();
			string gender 			= result.Rows[0][7].ToString();
			DateTime dateOfBirth	= DateTime.Parse(result.Rows[0][9].ToString());
			string address 			= result.Rows[0][8].ToString();
			string email 			= result.Rows[0][5].ToString();
			string phone 			= result.Rows[0][6].ToString();
			string role 			= result.Rows[0][4].ToString();
			string photo 			= result.Rows[0][10].ToString();
			profile_class profile = new profile_class(empId,role,username,fname,lname,gender,dateOfBirth,address,email,phone,photo);
			Global.profile = profile;
			
			txtAddress.Text 	= address;
			txtDateofBirth.Text = dateOfBirth.ToString("yyyy-MM-dd");
			txtEmail.Text 		= email;
			txtEmpid.Text 		= empId;
			txtFirstname.Text 	= fname;
			txtLastname.Text	= lname;
			txtGender.Text		= gender;
			txtPhonenumber.Text = phone;
			txtRole.Text 		= role;
			txtUsername.Text 	= username;
			photobox.Image 		= Image.FromFile(@"people\"+photo);
			}//eif
		}//ef
		
		void BtnUpdateClick(object sender, EventArgs e)
		{
			string sql = "update profile set username = 'd1',firstname = 'd2',lastname = 'd3',role = 'd4',email = 'd5',phonenumber = 'd6',gender = 'd7',dateOfBirth = 'd8',address = 'd9' ";
			sql += "where empId = 'd0';";
			sql = sql.Replace("d0",txtEmpid.Text);
			sql = sql.Replace("d1",txtUsername.Text);
			sql = sql.Replace("d2",txtFirstname.Text);
			sql = sql.Replace("d3",txtLastname.Text);
			sql = sql.Replace("d4",txtRole.Text);
			sql = sql.Replace("d5",txtEmail.Text);
			sql = sql.Replace("d6",txtPhonenumber.Text);
			sql = sql.Replace("d7",txtGender.Text);
			sql = sql.Replace("d8",txtDateofBirth.Text);
			sql = sql.Replace("d9",txtAddress.Text);
			m1.ExecuteNonQuery(sql);
			displayProfileDetail();
			MessageBox.Show("Your profile alredy update!!");
		}//ef
		
		void BtnChangePasswordClick(object sender, EventArgs e)
		{
			Password_form changepassword = new Password_form();
			changepassword.ShowDialog();
		}//ef
		

	}//ec
}//en

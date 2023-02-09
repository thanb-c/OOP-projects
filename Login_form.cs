/*
 * Created by SharpDevelop.
 * User: ACER
 * Date: 2/18/2022
 * Time: 11:01 PM
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
	/// Description of Login.
	/// </summary>
	public partial class Login : Form
	{
		DataManager m1 = new DataManager("localhost", "thansuda", "root","1234");
		public Login()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		
		void BtnCloseClick(object sender, EventArgs e)
		{
			this.Close();
		}//ef
		
		void BtnLoginClick(object sender, EventArgs e)
		{
			string username = txtUsername.Text;
			string password = txtPassword.Text;

			string sql = "select * from member where username = 'p1' and password= 'p2' ";
			sql = sql.Replace("p1", username);
			sql = sql.Replace("p2", password);
			DataTable result=  m1.GetDataTable(sql);
			
			if (result.Rows.Count > 0) {
				string firstname 	= result.Rows[0][3].ToString();
				string lastname	 	= result.Rows[0][4].ToString();
				string role 		= result.Rows[0][5].ToString();
				Member member = new Member(firstname,lastname,role,username,password);
				Global.member = member;
				if(role =="customer"){
					sql = "select * from customer where firstname = 'p1' and lastname='p2' ";
					sql = sql.Replace("p1",  firstname);
					sql = sql.Replace("p2", lastname);
					result=  m1.GetDataTable(sql);
					int id 				= int.Parse(result.Rows[0][0].ToString());
					firstname 			= result.Rows[0][1].ToString();
					lastname	 		= result.Rows[0][2].ToString();
					string phone 		= result.Rows[0][4].ToString();
					string address 		= result.Rows[0][6].ToString();
					Global.customer = new customer_class(id,firstname,lastname,phone,address); 
				}//eif
				
				//if login as customer directly to storepage form
				//if login as employee then go to management system
				if(Global.member.role == "customer"){
					StorePage store = new StorePage();
					store.ShowDialog();
				}//eif
				else {
					MainForm mainform = new MainForm();
					mainform.ShowDialog();
				}//eif
			}//eif
		
			else {
				Notification alert = new Notification();
				alert.ShowDialog();
			}//eif
		}//ef
	
		
		private void ShowPassCheckedChanged(object sender, EventArgs e)
		{
			if (ShowPass.Checked == true) {
				txtPassword.UseSystemPasswordChar = false;
			}//eif
			else {
				txtPassword.UseSystemPasswordChar = true;
			}//eif
		}//ef
		
	}//ec
}//en

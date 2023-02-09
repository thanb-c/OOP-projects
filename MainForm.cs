/*
 * Created by SharpDevelop.
 * User: ACER
 * Date: 2/16/2022
 * Time: 4:15 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace thansuda_6213841
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		DataManager m1 = new DataManager("localhost", "thansuda", "root","1234");
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void MainFormLoad(object sender, EventArgs e)
		{
			lblWelcome.Text = "Login as : " + Global.member.role;
			lblName.Text = "Welcome " + Global.member.firstname;
		}//ef
		
		void BtnLogoutClick(object sender, EventArgs e)
		{
			this.Close();
		}//ef
		
		void BtnProductClick(object sender, EventArgs e)
		{
			Product product = new Product();
			product.ShowDialog();
		}//ef
		
		void BtnOrderClick(object sender, EventArgs e)
		{
			Order order = new Order();
			order.ShowDialog();
		}//ef
		
		void BtnCustomerClick(object sender, EventArgs e)
		{
			Customer customerInfo = new Customer();
			customerInfo.ShowDialog();
		}//ef
		
		void BtnSaleReportClick(object sender, EventArgs e)
		{
			//only manager can access to report page
			SaleReport report = new SaleReport();
			if (Global.member.role == "staff"){
				report.Enabled = false;
				MessageBox.Show("You not allow to view this");
			}//eif
			else{
				report.ShowDialog();
			}//eif
		}//ef
		
		void BtnProfileClick(object sender, EventArgs e)
		{
			Profile profile = new Profile();
			profile.ShowDialog();
		}//ef
		
		void BtnStoreClick(object sender, EventArgs e)
		{
			StorePage store = new StorePage();
			store.ShowDialog();
		}//ef
	}//ec
}//en

/*
 * Created by SharpDevelop.
 * User: ACER
 * Date: 2/17/2022
 * Time: 11:36 PM
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
	/// Description of Customer.
	/// </summary>
	public partial class Customer : Form
	{
		DataManager m1 = new DataManager("localhost", "thansuda", "root","1234");
		public Customer()
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
		
		void CustomerLoad(object sender, EventArgs e)
		{
			displayCustomerInformation();
		}//ef
		
		private void displayCustomerInformation(){
			string sql = "select * from customer";
			DataTable table = m1.GetDataTable(sql);
			foreach(DataRow row in table.Rows){
				string no 			= row[0].ToString();
				string firstname	= row[1].ToString();
				string lastname		= row[2].ToString();
				string email 		= row[3].ToString();
				string phonenumber	= row[4].ToString();
				string status 		= row[5].ToString();
				string address 		= row[6].ToString();
				string zipcode 		= row[7].ToString();
				//creat new listview row
				ListViewItem newrow = new ListViewItem(no);
				newrow.SubItems.Add(firstname); newrow.SubItems.Add(lastname); 
				newrow.SubItems.Add(email); newrow.SubItems.Add(phonenumber); 
				newrow.SubItems.Add(status); newrow.SubItems.Add(address);
				newrow.SubItems.Add(zipcode);
				listView1.Items.Add(newrow);
			}//eloop
			if (table.Rows.Count > 0){
				int no 				= int.Parse(table.Rows[0][0].ToString());
				string firstname	= table.Rows[0][1].ToString();
				string lastname		= table.Rows[0][2].ToString();
				string phonenumber	= table.Rows[0][4].ToString();
				string address 		= table.Rows[0][6].ToString();
				Global.customer = new customer_class(no,firstname,lastname,phonenumber,address);
			}//eif
		}//ef
		
		#region click
		void BtnAddClick(object sender, EventArgs e)
		{
			listView1.Items.Clear();
			string customerId		= txtCustomerId.Text;
			string firstname 		= txtFirstname.Text;
			string lastname 		= txtLastname.Text;
			string email 			= txtEmail.Text;
			string phone			= txtPhonenumber.Text;
			string customerType		= cmbStatus.Text;
			string address			= txtAddress.Text;
			string zipcode			= txtZipcode.Text;
			
			string sql = "insert into customer(id, firstname, lastname, email,phonenumber, status, address, zipcode) ";
			sql += "values(null,'p1','p2','p3','p4','p5','p5','p7');";
			sql = sql.Replace("p1", firstname);
			sql = sql.Replace("p2", lastname);
			sql = sql.Replace("p3", email);
			sql = sql.Replace("p4", phone);
			sql = sql.Replace("p5", customerType);
			sql = sql.Replace("p6", address);
			sql = sql.Replace("p7", zipcode);
		
			m1.ExecuteNonQuery(sql);
			displayCustomerInformation();
			MessageBox.Show("New customer have been added");
		}//ef
		
		
		void BtnUpdateClick(object sender, EventArgs e)
		{
			listView1.Items.Clear();
			string customerId		= txtCustomerId.Text;
			string firstname 		= txtFirstname.Text;
			string lastname 		= txtLastname.Text;
			string email 			= txtEmail.Text;
			string phone			= txtPhonenumber.Text;
			string customerType		= cmbStatus.Text;
			string address			= txtAddress.Text;
			string zipcode			= txtZipcode.Text;
			
			string sql = "update customer set firstname = 'p1', lastname = 'p2', email = 'p3',phonenumber = 'p4', status = 'p5', address = 'p6', zipcode = 'p7' ";
			sql += "where id = 'p0';";
			sql = sql.Replace("p0", customerId);
			sql = sql.Replace("p1", firstname);
			sql = sql.Replace("p2", lastname);
			sql = sql.Replace("p3", email);
			sql = sql.Replace("p4", phone);
			sql = sql.Replace("p5", customerType);
			sql = sql.Replace("p6", address);
			sql = sql.Replace("p7", zipcode);
		
			m1.ExecuteNonQuery(sql);
			displayCustomerInformation();
			MessageBox.Show("The information have been updated!");
		}//ef
		
		void BynDeleteClick(object sender, EventArgs e)
		{
			string customerId		= txtCustomerId.Text;
			string firstname 		= txtFirstname.Text;
			string lastname 		= txtLastname.Text;
			string email 			= txtEmail.Text;
			string phone			= txtPhonenumber.Text;
			string customerType		= cmbStatus.Text;
			string address			= txtAddress.Text;
			string zipcode			= txtZipcode.Text;
			
			string sql = "delete from customer where id = 'd0'";
			sql = sql.Replace("d0", customerId);
			m1.ExecuteNonQuery(sql);
			displayCustomerInformation();
			MessageBox.Show("Deleted succuess");
		}//ef
		
		void BtnClearClick(object sender, EventArgs e)
		{
			txtCustomerId.Clear();
			txtFirstname.Clear();
			txtLastname.Clear();
			txtEmail.Clear();
			txtAddress.Clear();
			cmbStatus.SelectedItem = null;
			txtPhonenumber.Clear();
			txtZipcode.Clear();
		}//ef
		#endregion
		
		
		void ListView1SelectedIndexChanged(object sender, EventArgs e)
		{
			if (listView1.SelectedItems.Count > 0){
				txtCustomerId.Text		= listView1.SelectedItems[0].SubItems[0].Text;
				txtFirstname.Text		= listView1.SelectedItems[0].SubItems[1].Text;
				txtLastname.Text 		= listView1.SelectedItems[0].SubItems[2].Text;
				txtEmail.Text 			= listView1.SelectedItems[0].SubItems[3].Text;
				txtPhonenumber.Text		= listView1.SelectedItems[0].SubItems[4].Text;
				cmbStatus.Text			= listView1.SelectedItems[0].SubItems[5].Text;
				txtAddress.Text			= listView1.SelectedItems[0].SubItems[6].Text;
				txtZipcode.Text			= listView1.SelectedItems[0].SubItems[7].Text;
			}//eif
		}//ef
		
		
		void TxtsearchTextChanged(object sender, EventArgs e)
		{
			listView1.Items.Clear();
			string search = txtsearch.Text;
			string sql = "select * from customer where ";
			sql += "firstname like '%x1%' or lastname like '%x1%';";
			sql = sql.Replace("x1", search);
			DataTable table = m1.GetDataTable(sql);
			foreach(DataRow row in table.Rows){
				string no 			= row[0].ToString();
				string firstname	= row[1].ToString();
				string lastname		= row[2].ToString();
				string email 		= row[3].ToString();
				string phonenumber	= row[4].ToString();
				string status 		= row[5].ToString();
				string address 		= row[6].ToString();
				string zipcode 		= row[7].ToString();
				//creat new listview row
				ListViewItem newrow = new ListViewItem(no);
				newrow.SubItems.Add(firstname); newrow.SubItems.Add(lastname); 
				newrow.SubItems.Add(email); newrow.SubItems.Add(phonenumber); 
				newrow.SubItems.Add(status); newrow.SubItems.Add(address);
				newrow.SubItems.Add(zipcode);
				listView1.Items.Add(newrow);
			}//eloop
		}//ef
	}//ec
}//en

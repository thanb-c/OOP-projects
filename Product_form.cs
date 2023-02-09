/*
 * Created by SharpDevelop.
 * User: ACER
 * Date: 2/17/2022
 * Time: 11:35 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace thansuda_6213841
{
	/// <summary>
	/// Description of Product.
	/// </summary>
	public partial class Product : Form
	{
		DataManager m1 = new DataManager("localhost", "thansuda", "root","1234");
		List<Product_class> products = new List<Product_class>();
		
		public Product()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}

		void ProductLoad(object sender, EventArgs e)
		{
			fillform();
		}//ef
		
		private void fillform(){
			//create a query string to take product information form db
			listView1.Items.Clear();
			string sql = "select * from product";
			DataTable result = m1.GetDataTable(sql);
			//loop throug each row to from a new listviewitem/listview
			//add new row into the listview
			foreach(DataRow row in result.Rows){
				string productCode 		= row[0].ToString();
				string name 			= row[1].ToString();
				string category 		= row[2].ToString();
				string cost 			= row[3].ToString();
				string price 			= row[4].ToString();
				string qty 				= row[5].ToString();
				string pic 				= row[6].ToString();
	
				ListViewItem newrow = new ListViewItem(productCode); 
				newrow.SubItems.Add(name); newrow.SubItems.Add(category);
				newrow.SubItems.Add(cost); newrow.SubItems.Add(price); 
				newrow.SubItems.Add(qty); newrow.SubItems.Add(pic);
				listView1.Items.Add(newrow);
			}//eloop
			
		}//ef
		
		#region click
		void BtnBackClick(object sender, EventArgs e)
		{
			this.Close();
		}//ef
	
		void BtnNewClick(object sender, EventArgs e)
		{
			listView1.Items.Clear();
			
			string productCode 	= txtProductCode.Text;
			string name			= txtName.Text;
			string category 	= cmbcategory.Text;
			string cost 		= txtCost.Text;
			string price		= txtSellingPrice.Text;
			string qty			= txtQuantity.Text;
			string pic 			= txtpic.Text;
			string sql = "insert into product (id, name, category, unitCost, sellingPrice, numberInStock,picture) ";
			sql += "values(null,'p1','p2','p3','p4','p5','p6');";
			sql = sql.Replace("p1", name);
			sql = sql.Replace("p2", category);
			sql = sql.Replace("p3", cost);
			sql = sql.Replace("p4", price);
			sql = sql.Replace("p5", qty);
			sql = sql.Replace("p6", pic);

			m1.ExecuteNonQuery(sql);
			fillform();
			MessageBox.Show("Add new product success");
		}//ef
		
		void BtnUpdateClick(object sender, EventArgs e)
		{
			listView1.Items.Clear();
			string productCode 	= txtProductCode.Text;
			string name			= txtName.Text;
			string category 	= cmbcategory.Text;
			string cost 		= txtCost.Text;
			string price		= txtSellingPrice.Text;
			string qty			= txtQuantity.Text;
			string pic 			= txtpic.Text;
			string sql = "update product set name = 'd1' , category = 'd2' , unitCost = 'd3' , sellingPrice = 'd4', numberInStock = 'd5', picture = 'd6'";
			sql += " where id = 'd0'";
			sql = sql.Replace("d0",productCode);
			sql = sql.Replace("d1",name);
			sql = sql.Replace("d2",category);
			sql = sql.Replace("d3",cost);
			sql = sql.Replace("d4",price);
			sql = sql.Replace("d5",qty);
			sql = sql.Replace("d6", pic);
			m1.ExecuteNonQuery(sql);
			fillform();
			MessageBox.Show("Update Information Success");
		}//ef
		
		void BtnDeleteClick(object sender, EventArgs e)
		{
			
			string productCode 	= txtProductCode.Text;
			string name			= txtName.Text;
			string category 	= cmbcategory.Text;
			string cost 		= txtCost.Text;
			string price		= txtSellingPrice.Text;
			string qty			= txtQuantity.Text;
			
			string sql = "delete from product where id = 'd0'";
			sql = sql.Replace("d0", productCode);
			m1.ExecuteNonQuery(sql);
			fillform();
			MessageBox.Show("Deleted succuess");
		}//ef
		
		void BtnClearClick(object sender, EventArgs e)
		{
			txtProductCode.Clear();
			txtName.Clear();
			cmbcategory.SelectedItem = null;
			txtCost.Clear();
			txtSellingPrice.Clear();
			txtQuantity.Clear();
			txtpic.Clear();
		}//ef
		#endregion
		
		
		void ListView1SelectedIndexChanged(object sender, EventArgs e)
		{
			if (listView1.SelectedItems.Count > 0){
				txtProductCode.Text		= listView1.SelectedItems[0].SubItems[0].Text;
				txtName.Text			= listView1.SelectedItems[0].SubItems[1].Text;
				cmbcategory.Text 		= listView1.SelectedItems[0].SubItems[2].Text;
				txtCost.Text 			= listView1.SelectedItems[0].SubItems[3].Text;
				txtSellingPrice.Text	= listView1.SelectedItems[0].SubItems[4].Text;
				txtQuantity.Text		= listView1.SelectedItems[0].SubItems[5].Text;
				txtpic.Text				= listView1.SelectedItems[0].SubItems[6].Text;
			}//eif
		}//ef
		
		void txtsearchTextChanged(object sender, EventArgs e)
		{
			listView1.Items.Clear();
			
			string search = txtsearch.Text;
			string sql = "select * from product where name like '%x%';";
			sql = sql.Replace("x",search);
			DataTable result = m1.GetDataTable(sql);
			foreach(DataRow row in result.Rows){
				string productCode 		= row[0].ToString();
				string name 			= row[1].ToString();
				string category 		= row[2].ToString();
				string cost 			= row[3].ToString();
				string price 			= row[4].ToString();
				string qty 				= row[5].ToString();
				string pic				= row[6].ToString();
				ListViewItem newrow = new ListViewItem(productCode); 
				newrow.SubItems.Add(name); newrow.SubItems.Add(category);
				newrow.SubItems.Add(cost); newrow.SubItems.Add(price); 
				newrow.SubItems.Add(qty); newrow.SubItems.Add(pic);
				listView1.Items.Add(newrow);
			}//eloop
		}//ef
		
	}//ec
}//en

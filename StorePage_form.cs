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
	/// Description of StorePage.
	/// </summary>
	public partial class StorePage : Form
	{
		DataManager m1 = new DataManager("localhost", "thansuda", "root","1234");
		public StorePage()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			string sql = "select * from product";
			DataTable result = m1.GetDataTable(sql);
			foreach(DataRow row in result.Rows){
				int productCode 		= int.Parse(row[0].ToString());
				string name 			= row[1].ToString();
				string category 		= row[2].ToString();
				double price 			= double.Parse(row[4].ToString());
				string photo 			= row[6].ToString();
				Global.products.Add(new Product_class(productCode,name,category,price,photo));
			}//eloop
		}
		
		void BtnBackClick(object sender, EventArgs e)
		{
			this.Close();
		}//ef
		
		void StorePageLoad(object sender, EventArgs e)
		{
			foreach(Product_class p in Global.products) {
				cart_uc c = new cart_uc(p);
				c.incClicked += new EventHandler(c_incClicked);
				c.decClicked += new EventHandler(c_decClicked);
				flowLayoutPanel1.Controls.Add(c);
			}//eloop
		}//ef
		
		void c_decClicked(object sender, EventArgs e)
		{
			//if the product is already in the cart just do nothing  
			//if it is not in the cart lett add the product to the cart and update item count
			cart_uc cart = (cart_uc)sender;
			Product_class found = null;
			foreach(Product_class product in Global.cart){
				if(cart.products.productCode == product.productCode){
					found = product;
					break;
				}//eif
			}//eloop
			if(found != null && found.qty == 0){
				Global.cart.Remove(found);
			}//eif
			
			updateCount();
		}//ef

		void c_incClicked(object sender, EventArgs e)
		{
			cart_uc cart = (cart_uc)sender;
			Product_class found = null;
			foreach(Product_class product in Global.cart){
				if(cart.products.productCode == product.productCode){
					found = product;
					break;
				}//eif
			}//eloop
			if(found == null){
				Global.cart.Add(cart.products);
			}//eif
			
			updateCount();
		}//ef
		
		void updateCount(){
			int totalCount = 0;
			foreach(Product_class p in Global.cart){
				totalCount += p.qty;
			}//eloop
			lblNum.Text = totalCount.ToString();
		}//ef
		
		void BtnHomeClick(object sender, EventArgs e)
		{
			foreach(cart_uc cart in flowLayoutPanel1.Controls){
				cart.Visible = true;
			}//eloop
		}//ef
		
		void BtnNoruClick(object sender, EventArgs e)
		{
			foreach(cart_uc cart in flowLayoutPanel1.Controls){
				if (cart.products.category == "Noru"){
					cart.Visible = true;
				}//eif
				else {
					cart.Visible = false;
				}//ef
			}//eloop
		}//ef
		
		void BtnNenrodriodClick(object sender, EventArgs e)
		{
			foreach(cart_uc cart in flowLayoutPanel1.Controls){
				if (cart.products.category == "Nendoroid"){
					cart.Visible = true;
				}//eif
				else {
					cart.Visible = false;
				}//ef
			}//eloop
		}//ef
		
		void BtnFigureClick(object sender, EventArgs e)
		{
			foreach(cart_uc cart in flowLayoutPanel1.Controls){
				if (cart.products.category == "Figure"){
					cart.Visible = true;
				}//eif
				else {
					cart.Visible = false;
				}//ef
			}//eloop
		}//ef
		
		void BtnStandyClick(object sender, EventArgs e)
		{
			foreach(cart_uc cart in flowLayoutPanel1.Controls){
				if (cart.products.category == "Standy"){
					cart.Visible = true;
				}//eif
				else {
					cart.Visible = false;
				}//ef
			}//eloop
		}//ef
		
		void BtnLookupClick(object sender, EventArgs e)
		{
			foreach(cart_uc cart in flowLayoutPanel1.Controls){
				if (cart.products.category == "Lookup"){
					cart.Visible = true;
				}//eif
				else {
					cart.Visible = false;
				}//ef
			}//eloop
		}//ef
		
		void MyoderClick(object sender, EventArgs e)
		{
			MyOrder_form myorder = new MyOrder_form();
			myorder.ShowDialog();
		}//ef
	}//ec
}//en

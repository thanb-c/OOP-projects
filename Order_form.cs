/*
 * Created by SharpDevelop.
 * User: ACER
 * Date: 2/17/2022
 * Time: 11:35 PM
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
	/// Description of Order.
	/// </summary>
	public partial class Order : Form
	{
		DataManager m1 = new DataManager("localhost", "thansuda", "root","1234");
		public Order()
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
		
		void OrderLoad(object sender, EventArgs e)
		{
			lblDate.Text = DateTime.Today.Date.ToLongDateString();
			loadOrder();
		}//ef
		
		private void loadOrder(){
			listView1.Items.Clear();
			string sql = "select a.billNo, a.orderDate, a.customerName, a.shippingAddress, b.productCode, b.productName, b.qty, b.price, b.discountCode, b.shippingFee, ";
			sql += " case when discountCode = 'FreeShipping' then (b.price*b.qty) + shippingFee - 120 else round(((b.price*b.qty)-((b.price*b.qty)* b.percentAmount) + shippingFee)) end as 'Total Amount',";
			sql += " a.orderStatus, a.shipmentMethod, a.paymentMethod, a.employeeId from orderform as a, orderdetail as b where a.billNo = b.billNo";
			DataTable result = m1.GetDataTable(sql);
			foreach(DataRow row in result.Rows){
				string billNo 			= row[0].ToString();
				string orderDate 		= row[1].ToString();
				string customer 		= row[2].ToString();
				string shippingAddress 	= row[3].ToString();
				string productId 		= row[4].ToString();
				string productName 		= row[5].ToString();
				string qty 				= row[6].ToString();
				string price 			= row[7].ToString();
				string discountCode 	= row[8].ToString();
				string ShippingFee 		= row[9].ToString();
				string total 			= row[10].ToString();
				string status 			= row[11].ToString();
				string shipMethod 		= row[12].ToString();
				string payment 			= row[13].ToString();
				string empId 			= row[14].ToString();
				
				ListViewItem newrow = new ListViewItem(billNo); 
				newrow.SubItems.Add(orderDate); newrow.SubItems.Add(customer);
				newrow.SubItems.Add(shippingAddress); newrow.SubItems.Add(productId); newrow.SubItems.Add(productName);
				newrow.SubItems.Add(qty); newrow.SubItems.Add(price); newrow.SubItems.Add(discountCode);
				newrow.SubItems.Add(ShippingFee); newrow.SubItems.Add(total); newrow.SubItems.Add(status);
				newrow.SubItems.Add(shipMethod); newrow.SubItems.Add(payment); newrow.SubItems.Add(empId);
				
				listView1.Items.Add(newrow);  
			}//eloop
		}//ef
		
		void ListView1SelectedIndexChanged(object sender, EventArgs e)
		{
			if (listView1.SelectedItems.Count > 0){
				txtBillNo.Text 			= listView1.SelectedItems[0].SubItems[0].Text;
				txtBillDate.Text 		= listView1.SelectedItems[0].SubItems[1].Text;
				txtCname.Text 			= listView1.SelectedItems[0].SubItems[2].Text;
				txtShipAdd.Text 		= listView1.SelectedItems[0].SubItems[3].Text;
				txtPCode.Text 			= listView1.SelectedItems[0].SubItems[4].Text;
				txtPname.Text 			= listView1.SelectedItems[0].SubItems[5].Text;
				txtQty.Text 			= listView1.SelectedItems[0].SubItems[6].Text;
				txtPrice.Text 			= listView1.SelectedItems[0].SubItems[7].Text;
				txtDiscountCode.Text 	= listView1.SelectedItems[0].SubItems[8].Text;
				txtShipFee.Text 		= listView1.SelectedItems[0].SubItems[9].Text;
				txtTotalAmount.Text 	= listView1.SelectedItems[0].SubItems[10].Text;
				cmbOrdStatus.Text	 	= listView1.SelectedItems[0].SubItems[11].Text;
				cmbShipMet.Text 		= listView1.SelectedItems[0].SubItems[12].Text;
				cmbPayMet.Text 			= listView1.SelectedItems[0].SubItems[13].Text;
				cmbEmpId.Text 			= listView1.SelectedItems[0].SubItems[14].Text;
			}//eif
		}//ef
		
		void BtnCheckProductClick(object sender, EventArgs e)
		{
			Product product = new Product();
			product.ShowDialog();
			
		}//ef
		
		void BtnCheckCustClick(object sender, EventArgs e)
		{
			Customer customerInfo = new Customer();
			customerInfo.ShowDialog();
		}//ef
		
		void BtnConfirmOrdClick(object sender, EventArgs e)
		{
			listView1.Items.Clear();
			
			string sql = "update orderform set orderStatus = 'o1', employeeId = 'o2' where billNo = 'o3';";
			sql = sql.Replace("o1",cmbOrdStatus.Text);
			sql = sql.Replace("o2",cmbEmpId.Text);
			sql = sql.Replace("o3",txtBillNo.Text);
			m1.ExecuteNonQuery(sql);
			loadOrder();
			MessageBox.Show("Oder Confirm Success!!");
		}//ef
		
		void BtnCancelClick(object sender, EventArgs e)
		{
			//set all textbox to be blank
			txtBillNo.Clear(); txtBillDate.Clear(); txtCname.Clear(); txtShipAdd.Clear();
			txtPCode.Clear(); txtPname.Clear(); txtQty.Clear(); txtPrice.Clear(); txtDiscountCode.Clear();
			txtShipFee.Clear(); txtTotalAmount.Clear();
			cmbOrdStatus.SelectedItem = null;
			cmbShipMet.SelectedItem = null;
			cmbPayMet.SelectedItem = null;
			cmbEmpId.SelectedItem = null;
			loadOrder();
		}//ef
		
		//searching by date and product name
		void TxtSearchTextChanged(object sender, EventArgs e)
		{
			string search = txtSearch.Text;
			listView1.Items.Clear();
			string sql = "select a.billNo, a.orderDate, a.customerName, a.shippingAddress, b.productCode, b.productName, b.qty, b.price, b.discountCode, b.shippingFee, ";
			sql += " case when discountCode = 'FreeShipping' then (b.price*b.qty) + shippingFee - 120 else round(((b.price*b.qty)-((b.price*b.qty)* b.percentAmount) + shippingFee),2) end as 'Total Amount',";
			sql += " a.orderStatus, a.shipmentMethod, a.paymentMethod, a.employeeId from orderform as a, orderdetail as b where a.billNo = b.billNo and (a.orderDate like '%x1%' or a.productName like '%x1%' or a.orderStatus like '%x1%')";
			sql = sql.Replace("x1",search);
			DataTable result = m1.GetDataTable(sql);
			foreach(DataRow row in result.Rows){
				string billNo 			= row[0].ToString();
				string orderDate 		= row[1].ToString();
				string customer 		= row[2].ToString();
				string shippingAddress 	= row[3].ToString();
				string productId 		= row[4].ToString();
				string productName 		= row[5].ToString();
				string qty 				= row[6].ToString();
				string price 			= row[7].ToString();
				string discountCode 	= row[8].ToString();
				string ShippingFee 		= row[9].ToString();
				string total 			= row[10].ToString();
				string status 			= row[11].ToString();
				string shipMethod 		= row[12].ToString();
				string payment 			= row[13].ToString();
				string empId 			= row[14].ToString();
				
				ListViewItem newrow = new ListViewItem(billNo); 
				newrow.SubItems.Add(orderDate); newrow.SubItems.Add(customer);
				newrow.SubItems.Add(shippingAddress); newrow.SubItems.Add(productId); newrow.SubItems.Add(productName);
				newrow.SubItems.Add(qty); newrow.SubItems.Add(price); newrow.SubItems.Add(discountCode);
				newrow.SubItems.Add(ShippingFee); newrow.SubItems.Add(total); newrow.SubItems.Add(status);
				newrow.SubItems.Add(shipMethod); newrow.SubItems.Add(payment); newrow.SubItems.Add(empId);
				
				listView1.Items.Add(newrow);  
			}//eloop
		}//ef
	}//ec
}//en

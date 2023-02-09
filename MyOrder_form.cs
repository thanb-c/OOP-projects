/*
 * Created by SharpDevelop.
 * User: ACER
 * Date: 3/24/2022
 * Time: 8:45 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace thansuda_6213841
{
	/// <summary>
	/// Description of MyOder_form.
	/// </summary>
	public partial class MyOrder_form : Form
	{
		DataManager m1 = new DataManager("localhost", "thansuda", "root","1234");
		List<Product_class> list = new List<Product_class>();
		public MyOrder_form()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void MyOder_formLoad(object sender, EventArgs e)
		{
			lblToday.Text = DateTime.Today.ToShortDateString();
			txtShipFee.Text = "120";
			txtCid.Text = Global.customer.cid.ToString();
			txtCname.Text = Global.customer.firstname +" "+ Global.customer.lastname;
			txtPhone.Text = Global.customer.phone;
			txtShipAd.Text = Global.customer.address;
		
			var result = Global.cart.Select(p => new {
			                               p.productCode,
			                               p.productName,
			                               p.category,
			                               p.qty,
			                               p.price,
			                               total = p.price*p.qty
			                                      }).ToList();
			grid1.DataSource = result;
			
			double total = 0;
			foreach(Product_class p in Global.cart){
				total += p.price*p.qty;
					total = total+120;
			}//eloop
			txtTotalAmount.Text = total.ToString();
			}//ef
		
		
		void BtnConfirmClick(object sender, EventArgs e)
		{
			string sql1 = "insert into orderform (billNo, orderDate, customerId, customerName, shippingAddress, employeeId, orderStatus, shipmentMethod, paymentMethod)";
			sql1 += " values(null, 'p1','p2', 'p3','p4','p5','p6','p7','p8');";
			sql1 = sql1.Replace("p1",lblToday.Text);
			sql1 = sql1.Replace("p2",txtCid.Text);
			sql1 = sql1.Replace("p3",txtCname.Text);
			sql1 = sql1.Replace("p4",txtShipAd.Text);
			sql1 = sql1.Replace("p5","");
			sql1 = sql1.Replace("p6","Not Ready");
			sql1 = sql1.Replace("p7",cmbSipMet.Text);
			sql1 = sql1.Replace("p8",cmbPayMet.Text);
			m1.ExecuteNonQuery(sql1);
			
			//transaction to get lastest billNo
			string sql4 = "SELECT billNo from orderform order by billNo desc limit 0,1";
			DataTable t = m1.GetDataTable(sql4);
			string billNo = t.Rows[0][0].ToString();
			
			string sql2 = "insert into orderdetail (number,billNo, date, productCode, productName, category, price, qty, discountCode, percentAmount, shippingFee) values ";
			foreach(Product_class p in Global.cart){
					string template = "(null,'d0', 'd1','d2', 'd3','d4','d5','d6','d7','d8','d9'),";
					string r = template;
						r = r.Replace("d0",billNo);
						r = r.Replace("d1",lblToday.Text);
						r = r.Replace("d2",p.productCode.ToString());
						r = r.Replace("d3",p.productName);
						r = r.Replace("d4",p.category);
						r = r.Replace("d5",p.price.ToString());
						r = r.Replace("d6",p.qty.ToString());
						r = r.Replace("d7",cmbDisCode.Text);
						r = r.Replace("d8",txtPerAmount.Text);
						r = r.Replace("d9",txtShipFee.Text);
						sql2 += r;
						}//eloop
			sql2 = sql2.Substring(0, sql2.Length-1);
			m1.ExecuteNonQuery(sql2);
			
			//update product stock
			string sql3 = "";
			foreach(Product_class p in Global.cart){
				sql3 += string.Format("update product set numberInStock = (numberInStock - {0}) where id = {1};", 
				                    p.qty,p.productCode );
			}//eloop
			sql3 = sql3.Substring(0, sql3.Length-1);
			m1.ExecuteNonQuery(sql3);
			
			MessageBox.Show("Your Ordered Success!!");
		}//ef
		
		void Grid1SelectionChanged(object sender, EventArgs e)
		{
			txtPname.Text = grid1.CurrentRow.Cells[1].Value.ToString();
			txtCategory.Text = grid1.CurrentRow.Cells[2].Value.ToString();
			txtQty.Text = grid1.CurrentRow.Cells[3].Value.ToString();
			txtPrice.Text = grid1.CurrentRow.Cells[4].Value.ToString();
		}//ef
		
		void CmbDisCodeSelectedIndexChanged(object sender, EventArgs e)
		{ 
			string sql = "select percentAmount from discount where dcode = 'd1'";
			sql = sql.Replace("d1",cmbDisCode.Text);
			DataTable result = m1.GetDataTable(sql);
			txtPerAmount.Text = result.Rows[0][0].ToString();
			
			//calculate total amount
			double total = 0;
			foreach(Product_class p in Global.cart){
				if(cmbDisCode.Text == "FOM-999"){
					total += p.price*p.qty;
					total = total-(total*0.15)+120;
					total = Math.Round(total,2);
				}//eif
				else if (cmbDisCode.Text == "Hot-Item"){
					total += p.price*p.qty;
					total = total-(total*0.25)+120;
					total = Math.Round(total,2);
				}//eif
				else if (cmbDisCode.Text == "Freeshipping"){
					total += p.price*p.qty;
					total = total-120+120;
					total = Math.Round(total,2);
				}//eif
				else{
					total += p.price*p.qty;
					total = total+120;
					total = Math.Round(total,2);
				}//eif
			txtTotalAmount.Text = total.ToString();
			}//eloop	
		}//ef
				
	}//ec
}//en

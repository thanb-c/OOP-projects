/*
 * Created by SharpDevelop.
 * User: ACER
 * Date: 2/17/2022
 * Time: 11:36 PM
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
	/// Description of SaleReport.
	/// </summary>
	public partial class SaleReport : Form
	{
		DataManager m1 = new DataManager("localhost", "thansuda", "root","1234");
		List<MonthReport_class> monthly = new List<MonthReport_class>();
		List<ReportCategory_class> catRe = new List<ReportCategory_class>();
		public SaleReport()
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
		
		void SaleReportLoad(object sender, EventArgs e)
		{
			lblToday.Text = DateTime.Today.ToLongDateString();
			displayReport();
			
			//report monthly sales in chart1
			foreach(MonthReport_class m in monthly){
				chart1.Series["Month Sale"].Points.AddXY(m.month, m.totalSales);
			}//eloop
			
			//report sales of each category in chart2
			foreach(ReportCategory_class c in catRe){
				chart2.Series["Category Sales"].Points.AddXY(c.category, c.numberOfSales);
			}//eloop
		}//ef
		
		private void displayReport(){
			string sql = "select month(date) as 'Month',Count(price*qty) as 'Sales', Sum(price*qty) as 'Value' from orderdetail group by month(date);";
			DataTable table1 	= m1.GetDataTable(sql);
			grid1.DataSource 	= table1;
			foreach(DataRow row in table1.Rows){
				int month = int.Parse(row[0].ToString());
				int numberOfSales = int.Parse(row[1].ToString());
				double values = double.Parse(row[2].ToString());
				monthly.Add(new MonthReport_class(month,numberOfSales,values));
			}//eloop
			
			sql = "SELECT b.category as 'Category',count(a.productCode) as 'Number of Sales'";
			sql += " from orderdetail as a, product as b where a.productCode = b.id group by b.category;";
			DataTable table2 	= m1.GetDataTable(sql);
			grid2.DataSource 	= table2;
			foreach(DataRow row in table2.Rows){
				string categoty = row[0].ToString();
				int numberOfSales = int.Parse(row[1].ToString());
				catRe.Add(new ReportCategory_class(categoty,numberOfSales));
			}//eloop
		}//ef
		
	}//ec
}//en

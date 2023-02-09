/*
 * Created by SharpDevelop.
 * User: ACER
 * Date: 3/24/2022
 * Time: 4:01 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace thansuda_6213841
{
	/// <summary>
	/// Description of MonthReport_class.
	/// </summary>
	public class MonthReport_class
	{
		public int month;
		public int totalSales;
		public double salesValue;
		public MonthReport_class(int month, int totalSales, double salesValue)
		{
			this.month = month;
			this.totalSales = totalSales;
			this.salesValue = salesValue;
		}
		
		public MonthReport_class()
		{
		}
	}//ec
}//en

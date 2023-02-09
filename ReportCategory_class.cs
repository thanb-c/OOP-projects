/*
 * Created by SharpDevelop.
 * User: ACER
 * Date: 3/24/2022
 * Time: 4:02 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace thansuda_6213841
{
	/// <summary>
	/// Description of ReportCategory_class.
	/// </summary>
	public class ReportCategory_class
	{
		public string category;
		public int numberOfSales;
		public ReportCategory_class(string category, int numberOfSales)
		{
			this.category = category;
			this.numberOfSales = numberOfSales;
		}
		
		public ReportCategory_class()
		{
		}
	}//ec
}//en

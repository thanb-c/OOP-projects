/*
 * Created by SharpDevelop.
 * User: ACER
 * Date: 2/23/2022
 * Time: 3:23 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace thansuda_6213841
{
	/// <summary>
	/// Description of Product_class.
	/// </summary>
	public class Product_class
	{
		public int productCode;
		public string productName;
		public string category;
		public double price;
		public int qty;
		public string pic;
		
		public Product_class(int productCode, string productName, string category, double price, string pic)
		{
			this.productCode = productCode;
			this.productName = productName;
			this.category = category;
			this.price = price;
			this.pic = pic;
		}
		
		
		public Product_class()
		{
		}
	}//ec
}//en

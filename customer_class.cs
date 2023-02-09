/*
 * Created by SharpDevelop.
 * User: ACER
 * Date: 3/25/2022
 * Time: 10:57 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace thansuda_6213841
{
	/// <summary>
	/// Description of customer_class.
	/// </summary>
	public class customer_class
	{
		public int cid;
		public string firstname;
		public string lastname;
		public string phone;
		public string address;
		public customer_class(int cid, string firstname, string lastname, string phone, string address)
		{
			this.cid = cid;
			this.firstname = firstname;
			this.lastname = lastname;
			this.phone = phone;
			this.address = address;
		}
		
		public customer_class()
		{
		}
	}//ec
}//en

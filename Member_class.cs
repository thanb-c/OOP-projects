/*
 * Created by SharpDevelop.
 * User: ACER
 * Date: 2/17/2022
 * Time: 11:18 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace thansuda_6213841
{
	/// <summary>
	/// Description of Member.
	/// </summary>
	public class Member
	{
		public string firstname;
		public string lastname;
		public string role;
		public string username;
		public string password;
	
		public Member(string firstname, string lastname, string role, string username, string password)
		{
			this.firstname = firstname;
			this.lastname = lastname;
			this.role = role;
			this.username = username;
			this.password = password;
		}
		
		public Member()
		{
		}
	}//ec
}//en

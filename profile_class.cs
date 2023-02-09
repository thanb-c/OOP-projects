/*
 * Created by SharpDevelop.
 * User: ACER
 * Date: 3/5/2022
 * Time: 4:33 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace thansuda_6213841
{
	/// <summary>
	/// Description of profile_class.
	/// </summary>
	public class profile_class
	{
		public string empId;
		public string role;
		public string username;
		public string firstname;
		public string lastname;
		public string gender;
		public DateTime dateOfBirth;
		public string address;
		public string email;
		public string phonenumber;
		public string photo;

		public profile_class(string empId, string role, string username, string firstname, string lastname, string gender, DateTime dateOfBirth, string address, string email, string phonenumber,
		string photo)
		{
			this.empId = empId;
			this.role = role;
			this.username = username;
			this.firstname = firstname;
			this.lastname = lastname;
			this.gender = gender;
			this.dateOfBirth = dateOfBirth;
			this.address = address;
			this.email = email;
			this.phonenumber = phonenumber;
			this.photo = photo;
		}
		
		
		public profile_class()
		{
		}
		
	}//ec
}//en

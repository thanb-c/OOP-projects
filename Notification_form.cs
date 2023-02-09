/*
 * Created by SharpDevelop.
 * User: ACER
 * Date: 2/19/2022
 * Time: 1:41 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace thansuda_6213841
{
	/// <summary>
	/// Description of Notification.
	/// </summary>
	public partial class Notification : Form
	{
		public Notification()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Label1Click(object sender, EventArgs e)
		{
			this.Close();
		}//ef
	}//ec
}//en

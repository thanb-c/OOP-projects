/*
 * Created by SharpDevelop.
 * User: ACER
 * Date: 3/5/2022
 * Time: 10:41 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace thansuda_6213841
{
	/// <summary>
	/// Description of cart_uc.
	/// </summary>
	public partial class cart_uc : UserControl
	{
		public Product_class products = null;
		public event EventHandler incClicked;
		public event EventHandler decClicked;
		public cart_uc(Product_class product)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			this.products = product;
			//load the picture for the user control
			string dir1 = Directory.GetCurrentDirectory();
			string picFileName = dir1 + "\\items\\"+ this.products.pic;
			picture.Image = Image.FromFile(picFileName);
			picture.SizeMode = PictureBoxSizeMode.Zoom;
			
			string name = this.products.productName;
			lblName.Text = name;
			
			string category = this.products.category;
			lblCategory.Text = category;
			
			string price = this.products.price.ToString();
			lblPrice.Text = price;
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void BtnIncClick(object sender, EventArgs e)
		{
			products.qty += 1;
			lblQty.Text = "x " +products.qty.ToString();
			//inform the parent form 
			incClicked(this,e);
		}//ef
		
		void BtnDecClick(object sender, EventArgs e)
		{
			products.qty -= 1;
			lblQty.Text = "x " +products.qty.ToString();
			if (products.qty == 0){
				lblQty.Text = "Add to cart";
			}//eif
			decClicked(this,e);
		}//ef
	}//ec
}//en

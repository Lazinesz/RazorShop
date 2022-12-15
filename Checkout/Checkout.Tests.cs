using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using RazorShop.Data;
using RazorShop.Models;
using RazorShop.Pages.Checkout;

namespace Checkout.Tests
{
	public class Tests
	{
		[Test]
		public void SetInfo_ItemNameisEmpty_Custom()
		{
			string expectedItemName = "Custom";

			Info checkoutModel = new Info();
			ItemOrder item = new ItemOrder();
			string image = "Image";
			item = Info.SetInfo("", ref image, 0);
			string actualItemName = item.ItemName;
			Assert.AreEqual(expectedItemName, actualItemName);
		}
		[Test]
		public void SetInfo_ItemNameIsitem_Item()
		{
			string expectedItemName = "Item";

			Info checkoutModel = new Info();
			ItemOrder item = new ItemOrder();
			string image = "Image";
			item = Info.SetInfo("Item", ref image, 0);
			string actualItemName = item.ItemName;
			Assert.AreEqual(expectedItemName, actualItemName);
		}
		[Test]
		public void SetInfo_ImagenotEmpty_Image()
		{
			string expectedImage = "Image";

			Info checkoutModel = new Info();
			ItemOrder item = new ItemOrder();
			string imageName = "Image";
			item = Info.SetInfo("", ref imageName, 0);
			string actualImage = imageName;
			//string actualPizaName = pizza.PizzaName;
			Assert.AreEqual(expectedImage, actualImage);
		}

	}
}

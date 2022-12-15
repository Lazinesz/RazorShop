using Azure.Core;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RazorShop.Models;
using RazorShop.Pages.Forms;
using System.Runtime.CompilerServices;

namespace RazorShop.Tests
{

	public class Tests
	{


		[Test]
		public void Orders_RepairKitIstrue_Price3()
		{
			ItemModel item = new ItemModel()
			{
				BasePrice = 1,
				ItemName = "",
				RepairKit = true
			};

			OrdersModel ordersModel = new OrdersModel();

			float expectedPrice = 2;
			float actualPrice = ordersModel.Orde(item);
			Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(expectedPrice, actualPrice);
		}
		[Test]
		public void Orders_RepairKitAndAditionalDetailsIstrue_Price4()
		{
			ItemModel item = new ItemModel()
			{
				BasePrice = 1,
				AditionalDetails = true,
				ItemName = "",
				RepairKit = true
			};

			OrdersModel ordersModel = new OrdersModel();

			float expectedPrice = 3;
			float actualPrice = ordersModel.Orde(item);
			Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(expectedPrice, actualPrice);
		}
		[Test]
		public void Orders_RepairKitAndAditionalDetailsAndGooglesIstrue_Price5()
		{
			ItemModel item = new ItemModel()
			{
				BasePrice = 1,
				RepairKit = true,
				AditionalDetails = true,
				ItemName = "",
				Googles = true
			};

			OrdersModel ordersModel = new OrdersModel();

			float expectedPrice = 4;
			float actualPrice = ordersModel.Orde(item);
			Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(expectedPrice, actualPrice);
		}
		[Test]
		public void Orders_ProtectCostume_CoollerGoogles_GlovesAndReperatorIstrue_Price12()
		{
			ItemModel item = new ItemModel()
			{
				BasePrice = 2,
				ProtectCostume = true,
				Googles2 = true,
				ItemName = "",
				Gloves = true,
				Resperator2 = true
			};

			OrdersModel ordeModel = new OrdersModel();

			float expectedPrice = 12;
			float actualPrice = ordeModel.Orde(item);
			Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(expectedPrice, actualPrice);
		}
		[Test]
		public void Orders_AllItemsAretrue_Price10()
		{
			ItemModel item = new ItemModel()
			{
				BasePrice = 2,
				Resperator2 = true,
				AditionalDetails = true,
				ItemName = "",
				Googles2 = true,
				ProtectCostume = true,
				RepairKit = true,
				Gasmask = true,
				Gloves = true,
				Helmet = true
			};

			OrdersModel ordeModel = new OrdersModel();

			float expectedPrice = 22;
			float actualPrice = ordeModel.Orde(item);
			Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(expectedPrice, actualPrice);
		}

		[Test]
		public void OnPost_Correct_Direction()
		{
			string expectedUrl = "/Checkout/Checkout";
			OrdersModel ordeModel = new OrdersModel();
			ordeModel.Items = new ItemModel() { Googles2 = true };
			RedirectToPageResult result = (RedirectToPageResult)ordeModel.OnPost();

			//customePizzaModel.OnPost();
			string actualUrl = result.PageName;
			Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(expectedUrl, actualUrl);
		}
	}
}
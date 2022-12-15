using Microsoft.AspNetCore.Mvc;
using RazorShop.Models;
using RazorShop.Pages.Account;
using RazorShop.Pages.Forms;
using RazorShop.Pages.Account;

namespace LoginAndErrorLogin
{
	public class Tests
	{

		[Test]
		public void Page_userNameIsCorrectAndPasswordIsIncorrect()
		{
			string expectedPage = "ErrorLogin";
			LoginModel loginModel = new LoginModel();
			string actualPage = loginModel.Page("admin", "weqwe");
			Assert.AreEqual(expectedPage, actualPage);
		}


		[Test]
		public void Page_userNameIsIncorrectAndPasswordIsCorrect()
		{
			string expectedPage = "ErrorLogin";
			LoginModel loginModel = new LoginModel();
			string actualPage = loginModel.Page("Vlad", "qwerty");
			Assert.AreEqual(expectedPage, actualPage);
		}
		[Test]
		public void Page_userNameIsIncorrectAndPasswordIsIncorrect()
		{
			string expectedPage = "ErrorLogin";
			LoginModel loginModel = new LoginModel();
			string actualPage = loginModel.Page("Vlad", "12345");
			Assert.AreEqual(expectedPage, actualPage);
		}
		[Test]
		public void Page_userNameIsCorrectAndPasswordIsCorrect()
		{
			string expectedPage = "/Orders";
			LoginModel loginModel = new LoginModel();
			string actualPage = loginModel.Page("admin", "12345");
			Assert.AreEqual(expectedPage, actualPage);
		}
		[Test]
		public void OnPost_UserNameIsIncorrect()
		{
			string expectedUrl = "ErrorLogin";
			LoginModel loginModel = new LoginModel();
			loginModel.Credentials = new Credential() { UserName = "Vlad", Password = "" };
			RedirectToPageResult result = (RedirectToPageResult)loginModel.OnPost();

			//customePizzaModel.OnPost();
			string actualUrl = result.PageName;
			Assert.AreEqual(expectedUrl, actualUrl);
		}

		[Test]
		public void OnPost_DataIsCorrect()
		{
			string expectedUrl = "/Orders";
			LoginModel loginModel = new LoginModel();
			loginModel.Credentials = new Credential() { UserName = "admin", Password = "12345" };
			RedirectToPageResult result = (RedirectToPageResult)loginModel.OnPost();

			//customePizzaModel.OnPost();
			string actualUrl = result.PageName;
			Assert.AreEqual(expectedUrl, actualUrl);
		}
	}
}
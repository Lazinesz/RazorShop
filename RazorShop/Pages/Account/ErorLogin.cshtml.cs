using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Identity.Client.Platforms.Features.DesktopOs.Kerberos;
using System.ComponentModel.DataAnnotations;

//namespace Pizzeria.Pages.Account
//{
//	public class ErrorLoginModel : PageModel
//	{
//		[BindProperty]
//		public Credential Credentials { get; set; }

//		public void OnGet()
//		{

//		}
//		public string Page(string userName, string password)
//		{
//			if (userName != "admin" && password != "qwerty")
//				return "ErrorLogin";

//			return "/Orders";
//		}
//		public IActionResult OnPost()
//		{
//			return RedirectToPage(Page(Credentials.UserName, Credentials.Password));
//		}
//	}

//}
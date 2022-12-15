using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace RazorShop.Pages.Account
{
    public class LoginModel : PageModel
    {
		[BindProperty]
		public Credential Credentials { get; set; }

		public void OnGet()
		{

		}
		public string Page(string userName, string password)
		{
			if (userName != "admin" || password != "12345")
				return "ErrorLogin";

			return "/Orders";
		}
		public IActionResult OnPost()
		{
			return RedirectToPage(Page(Credentials.UserName, Credentials.Password));
		}
	}
	public class Credential
	{
		[Required]
		[Display(Name = "User Name")]
		public string UserName { get; set; }

		[Required]
		[DataType(DataType.Password)]
		public string Password { get; set; }

	}
}


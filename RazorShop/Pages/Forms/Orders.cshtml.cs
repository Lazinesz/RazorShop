using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorShop.Data;
using RazorShop.Models;
using System.ComponentModel;

namespace RazorShop.Pages.Forms
{
    public class OrdersModel : PageModel
    {
       
        [BindProperty]
        public ItemModel Items { get; set; }
        public float OrderPrice { get; set; }
        public void OnGet()
        {           
        }
        public float Orde(ItemModel item)
        {
			float price = item.BasePrice;
			
            if (item.RepairKit) price += 1;
            if (item.AditionalDetails) price += 1;
            if (item.Googles) price += 1;
            if (item.Googles2) price += 2;
            if (item.MedGloves) price += 1;
            if (item.Gloves) price += 1;
            if (item.Helmet) price += 4;
            if (item.Gasmask) price += 4;
            if (item.ProtectCostume) price += 5;
            if (item.Resperator) price += 1;
            if (item.Resperator2) price += 2;
            return price;

        }
		public IActionResult OnPost()
		{
			OrderPrice = Orde(Items);

			return RedirectToPage("/Checkout/Checkout", new { Items.ItemName, OrderPrice });
		}
	}
}

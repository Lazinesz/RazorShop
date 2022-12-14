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
        public IActionResult OnPost()
        {
            OrderPrice = Items.BasePrice;

            if (Items.RepairKit) OrderPrice += 1;

            if (Items.AditionalDetails) OrderPrice += 1;

            if (Items.Googles) OrderPrice += 1;

            if (Items.Googles2) OrderPrice += 2;

            if (Items.MedGloves) OrderPrice += 1;

            if (Items.Gloves) OrderPrice += 1;

            if (Items.Helmet) OrderPrice += 4;

            if (Items.Gasmask) OrderPrice += 4;

            if (Items.ProtectCostume) OrderPrice += 5;

            if (Items.Resperator) OrderPrice += 1;

            if (Items.Resperator2) OrderPrice += 2;

            return RedirectToPage("/Checkout/Checkout", new { Items.ItemName, OrderPrice});
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorShop.Data;
using RazorShop.Models;

namespace RazorShop.Pages.Checkout
{

	public class Info
	{
        public static ItemOrder SetInfo(string name, ref string image, float itemPrice)
        {
            if (string.IsNullOrWhiteSpace(name)) { name = "Custom"; }
            if (string.IsNullOrWhiteSpace(image)) { image = "Create"; }
			ItemOrder itemOrder = new ItemOrder();
			itemOrder.ItemName = name;
			itemOrder.BasePrise = itemPrice;

			return itemOrder;
    }

		}
		[BindProperties (SupportsGet =true)]
    public class CheckoutModel : PageModel
    {       
        public string ItemName { get; set; }
        public float OrderPrice {get; set;}
        public string ImageTitle { get; set; }

        private readonly ApplicationDbContext _context;
        public CheckoutModel(ApplicationDbContext context)
        {
            _context= context;
        }
        public void OnGet()
        {
			string image = ImageTitle;
			ItemOrder itemOrder= new ItemOrder();
			itemOrder = Info.SetInfo(ItemName, ref image, OrderPrice);
			ImageTitle = image;
			_context.ItemOrders.Add(itemOrder); 
            _context.SaveChanges();
        }
    }
}

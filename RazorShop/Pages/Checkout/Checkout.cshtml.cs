using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorShop.Data;
using RazorShop.Models;

namespace RazorShop.Pages.Checkout
{
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
            if (string.IsNullOrWhiteSpace(ItemName))
            {
                ItemName = "Custom";
            }
            if (string.IsNullOrWhiteSpace(ImageTitle))
            {
                ImageTitle = "Create";
            }

            ItemOrder itemOrder= new ItemOrder(); 
            itemOrder.ItemName = ItemName;
            itemOrder.BasePrise = OrderPrice;

            _context.ItemOrders.Add(itemOrder); 
            _context.SaveChanges();
        }
    }
}

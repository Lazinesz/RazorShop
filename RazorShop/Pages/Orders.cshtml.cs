using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorShop.Data;
using RazorShop.Models;

namespace RazorShop.Pages
{
    public class OrdersModel : PageModel
    {
        public List<ItemOrder> ItemOrders = new List<ItemOrder>();

        private readonly ApplicationDbContext _context;
        public OrdersModel(ApplicationDbContext context)
        {
            _context = context;
        }
        public void OnGet()
        {
            ItemOrders = _context.ItemOrders.ToList();
        }
    }
}

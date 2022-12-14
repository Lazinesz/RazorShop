using Microsoft.EntityFrameworkCore;
using RazorShop.Models;

namespace RazorShop.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<ItemOrder> ItemOrders { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {

        }
    }
}

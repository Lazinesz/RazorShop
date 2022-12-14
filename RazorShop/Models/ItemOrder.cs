using System.Security.Principal;

namespace RazorShop.Models
{
    public class ItemOrder
    {
        public int Id { get; set; }
        public string ItemName { get; set; }
        public float BasePrise { get; set; }
    }
}

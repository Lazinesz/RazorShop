using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorShop.Models;

namespace RazorShop.Pages
{
    public class ItemsModel : PageModel
    {
        public List<ItemModel> fakeItemsDB = new List<ItemModel>()
        {
            new ItemModel(){ ImageTitle="Respirator", ItemName="Respirator", BasePrice= 1, Resperator=true, FinalPrice=1 },
            new ItemModel(){ ImageTitle="Profecional Respirator", ItemName="Profecional Respirator", BasePrice= 2, Resperator2=true, FinalPrice=2 },
            new ItemModel(){ ImageTitle="Repare Kit", ItemName="Repare kit", BasePrice= 1, RepairKit=true, FinalPrice=1 },
            new ItemModel(){ ImageTitle="Medicine Gloves", ItemName="Medicine Gloves", BasePrice= 1, MedGloves=true, FinalPrice=1 },
            new ItemModel(){ ImageTitle="Worker Gloves", ItemName="Worker Gloves", BasePrice= 1, Gloves=true, FinalPrice=1 },
            new ItemModel(){ ImageTitle="Googels", ItemName="Googles", BasePrice= 1, Googles=true, FinalPrice=1 },
            new ItemModel(){ ImageTitle="Cooller Googels", ItemName="Cooler Googles", BasePrice= 2, Googles2=true, FinalPrice=2 },
            new ItemModel(){ ImageTitle="Gasmask", ItemName="Gasmask", BasePrice= 4, Gasmask=true, FinalPrice=4 },
            new ItemModel(){ ImageTitle="Ditales", ItemName="Ditales", BasePrice= 1, AditionalDetails=true, FinalPrice=1 },
            new ItemModel(){ ImageTitle="Defence Costume", ItemName="Defence Kostume", BasePrice= 5, ProtectCostume=true, FinalPrice=5},
            new ItemModel(){ ImageTitle="Helmet", ItemName="Helmet", BasePrice= 4, Helmet=true, FinalPrice=4},
        };
        public void OnGet()
        {
        }
    }
}

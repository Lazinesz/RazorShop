namespace RazorShop.Models
{
    public class ItemModel
    {
        public string ImageTitle { get; set; }
        public string ItemName { get; set; }
        public float BasePrice { get; set; } = 2;
        public bool AditionalDetails { get; set; }
        public bool RepairKit { get; set; }
        public bool Resperator { get; set; }
        public bool Resperator2 { get; set; }
        public bool Gasmask { get; set; }
        public bool Helmet { get; set; }
        public bool MedGloves { get; set; }
        public bool ProtectCostume { get; set; }
        public bool Googles { get; set; }
        public bool Googles2 { get; set; }
        public bool Gloves{ get; set; }
        public float FinalPrice { get; set; }
    }
}

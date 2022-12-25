namespace Apex.GameZone.UI.Models
{
    public class ProductModel : CommonModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public decimal GrossPrice { get; set; }
        public int Balance { get; set; }
        public GameZoneModel GameZoneModel { get; set; }

        public ProductModel() { }
    }
}

namespace Apex.GameZone.UI.Models
{
    public class GameZoneModel: CommonModel
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public List<SectionModel> Sections { get; set; }
        public List<ItemModel> Items { get; set; }
        public List<ProductModel> Products { get; set; }

        public GameZoneModel() { }
    }
}

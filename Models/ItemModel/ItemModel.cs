namespace Apex.GameZone.UI.Models
{
    public class ItemModel : CommonModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal PricePerHour { get; set; }

        public GameZoneModel GameZoneEntity { get; set; }

        public ItemModel() { }
    }
}

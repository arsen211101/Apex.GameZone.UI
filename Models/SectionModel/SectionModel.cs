using Apex.GameZone.UI.Enums;

namespace Apex.GameZone.UI.Models
{
    public class SectionModel : CommonModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public DeviceTypes Type { get; set; }
        public decimal PricePerHour { get; set; }
        public bool IsVip { get; set; }
        public GameZoneModel GameZoneModel { get; set; }

        public SectionModel() { }
    }
}

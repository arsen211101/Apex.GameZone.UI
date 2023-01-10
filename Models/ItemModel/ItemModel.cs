namespace Apex.GameZone.UI.Models;

public class ItemModel : CommonModel.CommonModel
{
    public string Name { get; set; }
    public string Description { get; set; }
    public int PricePerHour { get; set; }
    public int? GameZoneId { get; set; }
}
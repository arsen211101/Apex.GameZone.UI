namespace Apex.GameZone.UI.Models.CheckoutModel;

public class CheckoutModel : CommonModel.CommonModel
{
    public int? GameZoneId { get; set; }
    public int? SectionId { get; set; }
    public DateTime Start { get; set; }
    public DateTime? ExpectedEnd { get; set; }
    public DateTime? End { get; set; }
    public int Bill { get; set; }

    public IEnumerable<ItemCheckoutModel> ConnectedItems { get; set; }
    public IEnumerable<ProductCheckoutModel> ConnectedProducts { get; set; }
}

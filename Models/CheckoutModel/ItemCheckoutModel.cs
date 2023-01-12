namespace Apex.GameZone.UI.Models.CheckoutModel
{
    public class ItemCheckoutModel : CommonModel.CommonModel
    {
        public int CheckoutId { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public int Bill { get; set; }
    }
}

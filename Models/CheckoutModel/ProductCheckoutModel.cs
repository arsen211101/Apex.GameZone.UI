namespace Apex.GameZone.UI.Models.CheckoutModel
{
    public class ProductCheckoutModel : CommonModel.CommonModel
    {
        public int CheckoutId { get; set; }
        public CheckoutModel check { get; set; }

        public int ProductId { get; set; }
        public ProductModel product { get; set; }

        public int Quantity { get; set; }
    }
}

using Apex.GameZone.UI.Models.CheckoutModel;

namespace Apex.GameZone.UI.Services.CheckServices;

public interface ICheckService
{
    Task<List<CheckoutModel>> GetAllChecks();
    Task<CheckoutModel> GetCheckoutById(int? id);
    Task<CheckoutModel> GetCheckoutBySectionId(int? sectionId);
    Task<int> CreateCheckout(CheckoutModel check);

    Task UpdateCheckout(CheckoutModel model);
    Task DeleteCheckout(CheckoutModel model);
}
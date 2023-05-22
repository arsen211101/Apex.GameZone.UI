using Apex.GameZone.UI.Models.CheckoutModel;
using Apex.GameZone.UI.Services.CommonServices;

namespace Apex.GameZone.UI.Services.CheckServices;

public class CheckService : ICheckService
{
    private readonly ICommonService _commonService;

    public CheckService(ICommonService commonService)
    {
        _commonService = commonService;
    }

    public async Task<List<CheckoutModel>> GetAllChecks()
    {
        var requestUrl = "checkout";
        return await _commonService.HttpRequest<string, List<CheckoutModel>>(HttpMethod.Get, "", requestUrl, null);
    }

    public async Task<CheckoutModel> GetCheckoutById(int? id)
    {
        var requestUrl = $"checkout/{id}";
        return await _commonService.HttpRequest<string, CheckoutModel>(HttpMethod.Get, "", requestUrl, null);
    }

    public async Task<CheckoutModel> GetCheckoutBySectionId(int? sectionId)
    {
        var requestUrl = $"checkout/sectionId/{sectionId}";
        return await _commonService.HttpRequest<string, CheckoutModel>(HttpMethod.Get, "", requestUrl, null);
    }

    public async Task<int> CreateCheckout(CheckoutModel check)
    {
        var requestUrl = "checkout";
        return await _commonService.HttpRequest<CheckoutModel, int>(HttpMethod.Post, "", requestUrl, check);
    }

    public async Task UpdateCheckout(CheckoutModel model)
    {
        var requestUrl = "checkout";
        await _commonService.HttpRequest<CheckoutModel, string>(HttpMethod.Put, "", requestUrl, model);
    }

    public async Task DeleteCheckout(CheckoutModel model)
    {
        var requestUrl = "checkout";
        await _commonService.HttpRequest<CheckoutModel, string>(HttpMethod.Delete, "", requestUrl, model);
    }
    public async Task<int> AddProductToCheck(ProductCheckoutModel productCheckout)
    {
        var requestUrl = "productCheckout";
        return await _commonService.HttpRequest<ProductCheckoutModel, int>(HttpMethod.Post, "", requestUrl, productCheckout);
    }
}
using Apex.GameZone.UI.Models;
using Apex.GameZone.UI.Services.CommonServices;

namespace Apex.GameZone.UI.Services.ItemServices;

public class ItemService : IItemService
{
    private readonly ICommonService _commonService;

    public ItemService(ICommonService commonService)
    {
        _commonService = commonService;
    }

    public async Task<ItemModel> GetItemById(Guid id)
    {
        var requestUrl = $"item/{id}";
        return await _commonService.HttpRequest<string, ItemModel>(HttpMethod.Get, "", requestUrl, null);
    }

    public async Task<List<ItemModel>> GetAllItems()
    {
        var requestUrl = "item";
        return await _commonService.HttpRequest<string, List<ItemModel>>(HttpMethod.Get, "", requestUrl, null);
    }

    public async Task<int> SaveItem(ItemModel model)
    {
        var requestUrl = "item";
        return await _commonService.HttpRequest<ItemModel, int>(HttpMethod.Post, "", requestUrl, model);
    }

    public async Task UpdateItem(ItemModel model)
    {
        var requestUrl = "item";
        await _commonService.HttpRequest<ItemModel, string>(HttpMethod.Put, "", requestUrl, model);
    }

    public async Task DeleteItem(ItemModel model)
    {
        var requestUrl = "item";
        await _commonService.HttpRequest<ItemModel, int>(HttpMethod.Delete, "", requestUrl, model);
    }
}
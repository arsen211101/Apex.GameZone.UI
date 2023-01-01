using Apex.GameZone.UI.Models;

namespace Apex.GameZone.UI.Services.ItemServices;

public interface IItemService
{
    /// <summary>
    ///     Retrieves Items information based on id
    /// </summary>
    /// <param name="id">Item's Id</param>
    /// <returns>ItemModel for the requested Item</returns>
    Task<ItemModel> GetItemById(Guid id);

    /// <summary>
    ///     Retrieves Items from DB
    /// </summary>
    /// <returns> List of Items </returns>
    Task<List<ItemModel>> GetAllItems();

    /// <summary>
    ///     Save Item functionality
    /// </summary>
    /// <param name="model"></param>
    /// <returns>Record count</returns>
    Task<int> SaveItem(ItemModel model);

    /// <summary>
    ///     Update Item
    /// </summary>
    /// <param name="model">model</param>
    /// <returns>Updated items count</returns>
    Task UpdateItem(ItemModel model);

    /// <summary>
    ///     Delete Item
    /// </summary>
    /// <param name="model">ItemModel for delate</param>
    /// <returns></returns>
    Task DeleteItem(ItemModel model);
}
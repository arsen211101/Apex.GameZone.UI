using Apex.GameZone.UI.Models;

namespace Apex.GameZone.UI.Services.GamezoneServices;

public interface IGamezoneService
{
    /// <summary>
    ///     Retrieves Gasmezone information based on id
    /// </summary>
    /// <param name="id">Gamezone's Id</param>
    /// <returns>GameZoneModel for the requested GameZone</returns>
    Task<GameZoneModel> GetGameZoneById(int id);

    /// <summary>
    ///     Retrieves GameZones from DB
    /// </summary>
    /// <returns> List of GameZoneModels </returns>
    Task<List<GameZoneModel>> GetAllGameZones();

    /// <summary>
    ///     Create GameZone
    /// </summary>
    /// <returns> Created GameZone </returns>
    Task<int> CreateGameZone(GameZoneModel gameZone);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="model"></param>
    /// <returns></returns>
    Task UpdateGamezone(GameZoneModel model);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    Task DeleteGameZone(GameZoneModel model);
}
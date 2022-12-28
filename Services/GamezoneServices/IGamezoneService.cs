using Apex.GameZone.UI.Models;

namespace Apex.GameZone.UI.Services.GamezoneServices
{
    public interface IGamezoneService
    {
        /// <summary>
        /// Retrieves Gasmezone information based on id
        /// </summary>
        /// <param name="id">Gamezone's Id</param>
        /// <returns>GameZoneModel for the requested GameZone</returns>
        Task<GameZoneModel> GetGameZoneById(int id);

        /// <summary>
        /// Retrieves GameZones from DB
        /// </summary>
        /// <returns> List of GameZoneModels </returns>
        Task<List<GameZoneModel>> GetAllGameZones();

        /// <summary>
        /// Create GameZone
        /// </summary>
        /// <returns> Created GameZone </returns>
        Task<GameZoneModel> CreateGameZone(GameZoneModel gameZone);
    }
}
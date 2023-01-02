using Apex.GameZone.UI.Models;

namespace Apex.GameZone.UI.Services.SectionServices;

public interface ISectionService
{
    /// <summary>
    ///     Retrieves Section information based on id
    /// </summary>
    /// <param name="id">Sections Id</param>
    /// <returns>SectionModel for the requested Section</returns>
    Task<SectionModel> GetSectionById(int id);

    /// <summary>
    ///     Retrieves Sections from DB
    /// </summary>
    /// <returns> List of Sections </returns>
    Task<List<SectionModel>> GetAllSections();

    /// <summary>
    ///    Retrieves Sections from DB based on GameZoneId
    /// </summary>
    /// <param name="gameZoneId"></param>
    /// <returns></returns>
    Task<List<SectionModel>> GetAllSectionsByGameZoneId(int gameZoneId);

    /// <summary>
    ///     Save Section functionality
    /// </summary>
    /// <param name="model"></param>
    /// <returns>Record count</returns>
    Task<int> SaveSection(SectionModel model);

    /// <summary>
    ///     Update Section
    /// </summary>
    /// <param name="model">model</param>
    /// <returns>Updated sections count</returns>
    Task UpdateSection(SectionModel model);

    /// <summary>
    ///     Delete Section
    /// </summary>
    /// <param name="model">SectionModel for delate</param>
    /// <returns></returns>
    Task DeleteSection(SectionModel model);
}
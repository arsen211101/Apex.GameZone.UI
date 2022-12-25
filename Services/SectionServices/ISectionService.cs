using Apex.GameZone.UI.Models;

namespace Apex.GameZone.UI.Services.SectionServices
{
    public interface ISectionService
    {
        /// <summary>
        ///   Retrieves Section information based on id
        /// </summary>
        /// <param name="id">Sections's Id</param>
        /// <returns>SectionModel for the requested Section</returns>
        Task<SectionModel> GetSectionById(Guid id);

        /// <summary>
        ///   Retrieves Sections from DB
        /// </summary>
        /// <returns> List of Sections </returns>
        Task<List<SectionModel>> GetAllSections();
    }
}
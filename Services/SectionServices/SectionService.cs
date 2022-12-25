using Apex.GameZone.UI.Models;
using Apex.GameZone.UI.Services.CommonServices;

namespace Apex.GameZone.UI.Services.SectionServices
{
    public class SectionService : ISectionService
    {
        private readonly ICommonService _commonService;
        public SectionService(ICommonService commonService)
        {
            _commonService = commonService;
        }

        public async Task<SectionModel> GetSectionById(Guid id)
        {
            var requestUrl = $"section/{id}";
            return await _commonService.HttpRequest<string, SectionModel>(HttpMethod.Get, "", requestUrl, null);
        }

        public async Task<List<SectionModel>> GetAllSections()
        {
            var requestUrl = $"section";
            return await _commonService.HttpRequest<string, List<SectionModel>>(HttpMethod.Get, "", requestUrl, null);
        }
    }
}
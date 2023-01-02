using Apex.GameZone.UI.Models;
using Apex.GameZone.UI.Services.CommonServices;

namespace Apex.GameZone.UI.Services.SectionServices;

public class SectionService : ISectionService
{
    private readonly ICommonService _commonService;

    public SectionService(ICommonService commonService)
    {
        _commonService = commonService;
    }

    public async Task<SectionModel> GetSectionById(int id)
    {
        var requestUrl = $"section/{id}";
        return await _commonService.HttpRequest<string, SectionModel>(HttpMethod.Get, "", requestUrl, null);
    }

    public async Task<List<SectionModel>> GetAllSections()
    {
        var requestUrl = "section";
        return await _commonService.HttpRequest<string, List<SectionModel>>(HttpMethod.Get, "", requestUrl, null);
    }

    public async Task<List<SectionModel>> GetAllSectionsByGameZoneId(int gameZoneId)
    {
        var requestUrl = $"section/gamezone/{gameZoneId}";
        return await _commonService.HttpRequest<string, List<SectionModel>>(HttpMethod.Get, "", requestUrl, null);
    }

    public async Task<int> SaveSection(SectionModel model)
    {
        var requestUrl = "section";
        return await _commonService.HttpRequest<SectionModel, int>(HttpMethod.Post, "", requestUrl, model);
    }

    public async Task UpdateSection(SectionModel model)
    {
        var requestUrl = "section";
        await _commonService.HttpRequest<SectionModel, string>(HttpMethod.Put, "", requestUrl, model);
    }

    public async Task DeleteSection(SectionModel model)
    {
        var requestUrl = "section";
        await _commonService.HttpRequest<SectionModel, int>(HttpMethod.Delete, "", requestUrl, model);
    }
}
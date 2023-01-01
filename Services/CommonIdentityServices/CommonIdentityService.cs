using Apex.GameZone.UI.Helpers;
using Apex.GameZone.UI.Models.Auth;

namespace Apex.GameZone.UI.Services.CommonIdentityServices;

public class CommonIdentityService : HttpServiceBase, ICommonIdentityService
{
    public CommonIdentityService(HttpClient httpClient, TokenModel tokenModel) : base(httpClient, tokenModel)
    {
    }

    public override string UrlPath { get; set; } = "/api/v1";
}
using Apex.GameZone.UI.Helpers;
using Apex.GameZone.UI.Models.Auth;

namespace Apex.GameZone.UI.Services.CommonServices
{
    public class CommonService : HttpServiceBase, ICommonService
    {
        public CommonService(HttpClient httpClient, TokenModel tokenModel) : base(httpClient, tokenModel)
        {

        }
        public override string UrlPath { get; set; } = "/api/v1";
    }
}
using Apex.GameZone.UI.Models.Auth;
using Apex.GameZone.UI.Services.CommonServices;
using System.Configuration;

namespace Apex.GameZone.UI.ServiceExtensions.RegisterExtension
{
    public static class RegisterExtension
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            services.AddHttpClient();
            services.AddScoped<TokenModel>();
            services.AddScoped<ICommonService, CommonService>();
        }
    }
}


using Apex.GameZone.UI.Models.Auth;
using Apex.GameZone.UI.Services.CommonServices;
using Apex.GameZone.UI.Services.GamezoneServices;
using Apex.GameZone.UI.Services.ItemServices;
using Apex.GameZone.UI.Services.ProductServices;
using Apex.GameZone.UI.Services.SectionServices;

namespace Apex.GameZone.UI.ServiceExtensions.RegisterExtension
{
    public static class RegisterExtension
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            services.AddHttpClient();
            services.AddScoped<TokenModel>();
            services.AddScoped<ICommonService, CommonService>();
            services.AddScoped<IGamezoneService, GamezoneService>();
            services.AddScoped<ISectionService, SectionService>();
            services.AddScoped<IProductService, ProductServices>();
            services.AddScoped<IItemService, ItemService>();
        }
    }
}


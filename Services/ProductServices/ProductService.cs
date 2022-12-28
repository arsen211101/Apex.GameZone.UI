using Apex.GameZone.UI.Models;
using Apex.GameZone.UI.Services.CommonServices;

namespace Apex.GameZone.UI.Services.ProductServices
{
    public class ProductServices : IProductService
    {
        private readonly ICommonService _commonService;
        public ProductServices(ICommonService commonService)
        {
            _commonService = commonService;
        }

        public async Task<List<ProductModel>> GetAllProducts()
        {
            var requestUrl = $"product";
            return await _commonService.HttpRequest<string, List<ProductModel>>(HttpMethod.Get, "", requestUrl, null);
        }

        public async Task<ProductModel> GetProductById(int id)
        {
            var requestUrl = $"product/{id}";
            return await _commonService.HttpRequest<string, ProductModel>(HttpMethod.Get, "", requestUrl, null);
        }

        public async Task<int> CreateProduct(ProductModel model)
        {
            var requestUrl = $"product";
            return await _commonService.HttpRequest<ProductModel, int>(HttpMethod.Post, "", requestUrl, model);
        }

        public async Task UpdateProduct(ProductModel model)
        {
            var requestUrl = $"product";
            await _commonService.HttpRequest<ProductModel, ProductModel>(HttpMethod.Put, "", requestUrl, model);
        }

        public async Task DeleteProduct(ProductModel model)
        {
            var requestUrl = $"product";
            await _commonService.HttpRequest<ProductModel, ProductModel>(HttpMethod.Delete, "", requestUrl, model);
        }
    }
}
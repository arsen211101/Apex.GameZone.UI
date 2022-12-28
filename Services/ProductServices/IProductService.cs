using Apex.GameZone.UI.Models;
using System.Threading.Tasks;

namespace Apex.GameZone.UI.Services.ProductServices
{
    public interface IProductService
    {
        /// <summary>
        /// Retrieves Product information based on id
        /// </summary>
        /// <param name="id">Products Id</param>
        /// <returns>ProductModel for the requested GameZone</returns>
        Task<List<ProductModel>> GetAllProducts();

        /// <summary>
        /// Retrieves Products from DB
        /// </summary>
        /// <returns> List of Products </returns>
        Task<ProductModel> GetProductById(int id);

        /// <summary>
        /// Create Product
        /// </summary>
        /// <returns> Created Product </returns>
        Task<ProductModel> CreateProduct(ProductModel productModel);

        /// <summary>
        ///  Update Product 
        /// </summary>
        /// <param name="model"></param>
        Task UpdateProduct(ProductModel model);

        /// <summary>
        /// Delete Product
        /// </summary>
        Task DeleteProduct(ProductModel model);
    }
}
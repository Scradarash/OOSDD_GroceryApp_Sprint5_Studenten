using Grocery.Core.Models;

namespace Grocery.Core.Interfaces.Services
{
    public interface IProductCategoryService : IService<ProductCategory>
    {
        List<ProductCategory> GetProductCategoriesByProductId(int productId);
        List<ProductCategory> GetProductCategoriesByCategoryId(int categoryId);
    }
}
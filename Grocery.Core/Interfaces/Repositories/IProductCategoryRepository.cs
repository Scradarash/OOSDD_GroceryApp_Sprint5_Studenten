using Grocery.Core.Models;

namespace Grocery.Core.Interfaces.Repositories
{
    public interface IProductCategoryRepository : IRepository<ProductCategory>
    {
        List<ProductCategory> GetByProductId(int productId);
        List<ProductCategory> GetByCategoryId(int categoryId);
    }
}
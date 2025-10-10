using Grocery.Core.Interfaces.Repositories;
using Grocery.Core.Models;

namespace Grocery.Core.Data.Repositories
{
    public class ProductCategoryRepository : IProductCategoryRepository
    {
        private readonly List<ProductCategory> productCategories;

        public ProductCategoryRepository()
        {
            productCategories = [
                new ProductCategory(1, productId: 1, categoryId: 1),
                new ProductCategory(2, productId: 2, categoryId: 1),
                new ProductCategory(3, productId: 3, categoryId: 2),
                new ProductCategory(4, productId: 4, categoryId: 2)
            ];
        }

        public List<ProductCategory> GetAll() => productCategories;

        public ProductCategory? Get(int id) => productCategories.FirstOrDefault(pc => pc.Id == id);

        public List<ProductCategory> GetByProductId(int productId)
        {
            return productCategories.Where(pc => pc.ProductId == productId).ToList();
        }

        public List<ProductCategory> GetByCategoryId(int categoryId)
        {
            return productCategories.Where(pc => pc.CategoryId == categoryId).ToList();
        }

        public ProductCategory Add(ProductCategory item)
        {
            throw new NotImplementedException();
        }

        public ProductCategory? Update(ProductCategory item)
        {
            throw new NotImplementedException();
        }

        public ProductCategory? Delete(ProductCategory item)
        {
            throw new NotImplementedException();
        }

    }
}
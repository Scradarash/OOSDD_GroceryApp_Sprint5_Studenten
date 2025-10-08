using Grocery.Core.Interfaces.Repositories;
using Grocery.Core.Interfaces.Services;
using Grocery.Core.Models;

namespace Grocery.Core.Services
{
    public class ProductCategoryService : IProductCategoryService
    {
        private readonly IProductCategoryRepository _productCategoryRepository;

        public ProductCategoryService(IProductCategoryRepository productCategoryRepository)
        {
            _productCategoryRepository = productCategoryRepository;
        }

        public List<ProductCategory> GetAll() => _productCategoryRepository.GetAll();

        public ProductCategory? Get(int id) => _productCategoryRepository.Get(id);

        public List<ProductCategory> GetProductCategoriesByProductId(int productId)
        {
            return _productCategoryRepository.GetByProductId(productId);
        }

        public List<ProductCategory> GetProductCategoriesByCategoryId(int categoryId)
        {
            return _productCategoryRepository.GetByCategoryId(categoryId);
        }

        public ProductCategory Add(ProductCategory item) => _productCategoryRepository.Add(item);
        public ProductCategory? Update(ProductCategory item) => _productCategoryRepository.Update(item);
        public ProductCategory? Delete(ProductCategory item) => _productCategoryRepository.Delete(item);
    }
}
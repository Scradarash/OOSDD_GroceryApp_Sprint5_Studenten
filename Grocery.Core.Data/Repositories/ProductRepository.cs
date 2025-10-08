using Grocery.Core.Interfaces.Repositories;
using Grocery.Core.Models;

namespace Grocery.Core.Data.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly List<Product> products;
        public ProductRepository()
        {
            products = [
                // id, name, stock, shelfLife, price (Toegevoegd)
                new Product(1, "Melk", 300, new DateOnly(2025, 9, 25), 1.89m),
                new Product(2, "Kaas", 100, new DateOnly(2025, 9, 30), 4.16m),
                new Product(3, "Brood", 400, new DateOnly(2025, 9, 12), 0.99m),
                new Product(4, "Bier", 250, new DateOnly(2025, 12, 31), 1.19m),
                new Product(5, "Hamburgers", 100, new DateOnly(2025, 12, 31), 5.49m),
                new Product(6, "IJsklontjes", 50, new DateOnly(2025, 12, 31), 0.99m),
                new Product(7, "Cornflakes", 0, new DateOnly(2025, 12, 31), 2.29m)];
        }
        public List<Product> GetAll()
        {
            return products;
        }

        public Product? Get(int id)
        {
            return products.FirstOrDefault(p => p.Id == id);
        }

        public Product Add(Product item)
        {
            throw new NotImplementedException();
        }

        public Product? Delete(Product item)
        {
            throw new NotImplementedException();
        }

        public Product? Update(Product item)
        {
            Product? product = products.FirstOrDefault(p => p.Id == item.Id);
            if (product == null) return null;
            product.Id = item.Id;
            return product;
        }
    }
}

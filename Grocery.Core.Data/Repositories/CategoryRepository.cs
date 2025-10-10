using Grocery.Core.Interfaces.Repositories;
using Grocery.Core.Models;

namespace Grocery.Core.Data.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly List<Category> categories;

        public CategoryRepository()
        {
            categories = [
                new Category(1, "Zuivel"),
                new Category(2, "Graanproducten"),
                new Category(3, "Dranken"),
                new Category(4, "Vlees"),
                new Category(5, "Overig")
            ];
        }
        public List<Category> GetAll() => categories;

        public Category? Get(int id) => categories.FirstOrDefault(c => c.Id == id);

        public Category Add(Category item)
        {
            throw new NotImplementedException();
        }

        public Category? Update(Category item)
        {
            throw new NotImplementedException();
        }

        public Category? Delete(Category item)
        {
            throw new NotImplementedException();
        }

    }
}
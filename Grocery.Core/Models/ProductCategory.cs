using CommunityToolkit.Mvvm.ComponentModel;

namespace Grocery.Core.Models
{
    public partial class ProductCategory : Model
    {
        [ObservableProperty]
        private int productId;

        [ObservableProperty]
        private int categoryId;
        public ProductCategory(int id, int productId, int categoryId) : base(id, string.Empty)
        {
            ProductId = productId;
            CategoryId = categoryId;
        }

        public override string? ToString()
        {
            return $"Product ID: {ProductId} - Category ID: {CategoryId}";
        }
    }
}
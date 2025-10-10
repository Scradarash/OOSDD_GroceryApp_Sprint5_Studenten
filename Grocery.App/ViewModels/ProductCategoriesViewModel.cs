using CommunityToolkit.Mvvm.ComponentModel;
using Grocery.Core.Interfaces.Services;
using Grocery.Core.Models;
using System.Collections.ObjectModel;

namespace Grocery.App.ViewModels
{
    [QueryProperty(nameof(CategoryId), "categoryId")]
    public partial class ProductCategoriesViewModel : BaseViewModel
    {
        private readonly IProductCategoryService _productCategoryService;
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;

        public ObservableCollection<Product> Products { get; set; } = new ObservableCollection<Product>();

        [ObservableProperty]
        private int categoryId;

        public ProductCategoriesViewModel(
            IProductCategoryService productCategoryService,
            IProductService productService,
            ICategoryService categoryService)
        {
            _productCategoryService = productCategoryService;
            _productService = productService;
            _categoryService = categoryService;
        }
        partial void OnCategoryIdChanged(int value)
        {
            LoadProducts(value);
        }

        private void LoadProducts(int categoryId)
        {
            Products.Clear();

            Category? category = _categoryService.Get(categoryId);
            if (category != null)
            {
                Title = $"Producten in: {category.Name}";
            }

            List<ProductCategory> productLinks = _productCategoryService.GetProductCategoriesByCategoryId(categoryId);

            foreach (ProductCategory link in productLinks)
            {
                Product? product = _productService.Get(link.ProductId);
                if (product != null)
                {
                    Products.Add(product);
                }
            }
        }
    }
}
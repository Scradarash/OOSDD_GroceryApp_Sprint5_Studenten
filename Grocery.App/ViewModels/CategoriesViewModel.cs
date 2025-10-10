using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Grocery.Core.Interfaces.Services;
using Grocery.Core.Models;
using System.Collections.ObjectModel;

namespace Grocery.App.ViewModels
{
    public partial class CategoriesViewModel : BaseViewModel
    {
        private readonly ICategoryService _categoryService;

        public ObservableCollection<Category> Categories { get; set; } = new ObservableCollection<Category>();

        [ObservableProperty]
        private Category? selectedCategory;

        public CategoriesViewModel(ICategoryService categoryService)
        {
            Title = "Productcategorieën";
            _categoryService = categoryService;
            LoadCategories();
        }

        private void LoadCategories()
        {
            Categories.Clear();
            foreach (Category c in _categoryService.GetAll())
            {
                Categories.Add(c);
            }
        }

        [RelayCommand]
        private async Task GoToCategoryProducts(Category category)
        {
            if (category == null)
                return;

            await Shell.Current.GoToAsync($"ProductCategoriesView?categoryId={category.Id}");

            SelectedCategory = null;
        }
    }
}
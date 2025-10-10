namespace Grocery.App.Views
{
    public partial class CategoriesView : ContentPage
    {
        public CategoriesView(ViewModels.CategoriesViewModel viewModel)
        {
            InitializeComponent();
            this.BindingContext = viewModel;
        }
    }
}
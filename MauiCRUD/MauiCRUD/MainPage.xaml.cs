using Android.App;
using Java.Lang;
using MauiCRUD.ViewModels;

namespace MauiCRUD
{
    public partial class MainPage : ContentPage
    {
        private readonly ProductsViewModel _productViewModel;

        public MainPage(ProductsViewModel productsViewModel)
        {
            InitializeComponent();
            BindingContext = productsViewModel;
            _productViewModel = productsViewModel;
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await _productViewModel.LoadProductsAsync();
        }
    }

}

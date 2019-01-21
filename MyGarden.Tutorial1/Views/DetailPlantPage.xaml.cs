using System;
using MyGarden.Tutorial1.ViewModels;
using Xamarin.Forms;

namespace MyGarden.Tutorial1.Views
{
    public partial class DetailPlantPage : ContentPage
    {
        DetailPlantViewModel _viewModel;

        public DetailPlantPage(DetailPlantViewModel viewModel)
        {
            InitializeComponent();

            BindingContext = _viewModel = viewModel;
        }

        async void OnModifyPlantClicked(object sender, EventArgs args)
        { 
            await Navigation.PushAsync(new SavePlantPage(new SavePlantViewModel(_viewModel.Plant)));
        }
    }
}

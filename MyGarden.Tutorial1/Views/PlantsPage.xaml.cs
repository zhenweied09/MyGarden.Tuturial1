using System;
using MyGarden.Tutorial1.Models;
using MyGarden.Tutorial1.ViewModels;
using Xamarin.Forms;

namespace MyGarden.Tutorial1.Views
{
    public partial class PlantsPage : ContentPage
    {
        PlantListViewModel _viewModel;

        public PlantsPage()
        {
            InitializeComponent();
            BindingContext = _viewModel = new PlantListViewModel();

        }

        async void OnAddPlantClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SavePlantPage(new SavePlantViewModel()));
        }

        async void OnItemSelected(object sender, SelectedItemChangedEventArgs args)
        {
            if (!(args.SelectedItem is Plant plant))
                return;

            await Navigation.PushAsync(new DetailPlantPage(new DetailPlantViewModel(plant)));

            // Manually deselect item.
            PlantsListView.SelectedItem = null;
        }

        async void OnDeletePlantClicked(object sender, EventArgs e)
        {
            var menuItem = (MenuItem)sender;
            var plant = (Plant)menuItem.CommandParameter;

            bool isDelete = await DisplayAlert("删除植物", $"你确定要删除'{plant.Name}'吗？", "确定", "取消");
            if (isDelete)
            {
                _viewModel.DeletePlantCommand.Execute(plant);
            }
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (_viewModel.Plants.Count == 0)
            {
                _viewModel.LoadPlantsCommand.Execute(null);
            }
        }
    }
}

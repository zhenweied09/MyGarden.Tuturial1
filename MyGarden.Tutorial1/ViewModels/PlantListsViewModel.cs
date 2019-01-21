using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Xamarin.Forms;

using MyGarden.Tutorial1.Models;
using MyGarden.Tutorial1.Views;
using MvvmHelpers;

namespace MyGarden.Tutorial1.ViewModels
{

    public class PlantListViewModel : BaseViewModel
    {
        public ObservableCollection<Plant> Plants { get; set; }
        public Command LoadPlantsCommand { get; set; }
        public Command LoadPlantPhotoCommand { get; set; }
        public Command DeletePlantCommand { get; set; }

        public PlantListViewModel()
        {
            Title = "我的花园";
            Plants = new ObservableCollection<Plant>();
            LoadPlantsCommand = new Command(async () => await RefreshPlants());
            LoadPlantPhotoCommand = new Command<Plant>(async (Plant plant) => await LoadPlantPhoto(plant));
            DeletePlantCommand = new Command<Plant>(async (Plant plant) => await DeletePlant(plant));

            MessagingCenter.Subscribe<SavePlantPage, Plant>(
                this, "AddNewPlant", async (sender, plant) => await AddNewPlant(sender, plant));

            MessagingCenter.Subscribe<SavePlantPage, Plant>(
                this, "UpdatePlant",async (sender, plant) => await UpdatePlant(sender, plant));
        }

        async Task RefreshPlants()
        {
            if (IsBusy)
                return;

            IsBusy = true;
            Plants.Clear();
            List<Plant> plants = await App.PlantService.GetAllPlantsAsync();
            foreach (var plant in plants)
            {
                await LoadPlantPhoto(plant);
                Plants.Add(plant);
            }
            IsBusy = false;
        }

        async Task DeletePlant(Plant plant)
        {
            if (IsBusy)
                return;

            IsBusy = true;

            if (plant != null)
            {
                await App.PlantService.RemovePlantAsync(plant.Id);
                Plants.Remove(plant);
            }

            IsBusy = false;
        }

        async Task UpdatePlant(object sender, Plant plant)
        {
            if (IsBusy)
                return;

            IsBusy = true;

            if (plant != null)
            {
                await App.PlantService.UpdatePlantAsync(plant.Id, plant);
                var oldPlant = Plants.SingleOrDefault(x => x.Id == plant.Id);
                if (oldPlant != null)
                {
                    Plants.Remove(oldPlant);
                    Plants.Add(plant);
                }
            }

            IsBusy = false;
        }

        async Task AddNewPlant(object sender, Plant plant)
        {
            if (IsBusy)
                return;

            IsBusy = true;

            if (plant != null)
            {
                await App.PlantService.AddPlantAsync(plant);
                Plants.Add(plant);
            }

            IsBusy = false;
        }

        async Task LoadPlantPhoto(Plant plant)
        {
            if (plant.DisplayPhoto != null) return;

            if (plant.PlantPhotos.Count > 0)
            {
                try
                {
                    var imageSource = await App.PlantService.GetImageAsync(plant.PlantPhotos[0].Path);
                    plant.DisplayPhoto = imageSource;
                }
                catch (Exception)
                {
                    plant.DisplayPhoto = ImageSource.FromResource("MyGarden.Tutorial1.Resources.Photos.sample-flower.jpeg");
                }

            }
        }

    }
}

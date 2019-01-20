using System;
using System.Diagnostics;
using System.Threading.Tasks;
using MyGarden.Tutorial1.Models;
using Xamarin.Forms;

namespace MyGarden.Tutorial1.Views
{
    public partial class SavePlantPage : ContentPage
    {
        public Plant Plant { get; set; }
        bool isNewPlant = true;

        public SavePlantPage(Plant plant = null)
        {
            InitializeComponent();

            if (plant == null)
            {
                Title = "新增植物";
                Plant = new Plant();
            }
            else
            {
                Title = "修改植物";
                Plant = plant;
                isNewPlant = false;

                if (plant.PlantPhotos == null) return;

                foreach (var photos in plant.PlantPhotos)
                {
                    var image = new Image
                    {
                        HeightRequest = 50,
                        WidthRequest = 50,
                        Aspect = Aspect.AspectFill,
                        Margin = new Thickness(1)
                    };
                    PhotoList.Children.Add(image);

                    Task.Run(async () =>
                    {
                        var imageSource = await App.PlantService.GetImageAsync(photos.Path);
                        Device.BeginInvokeOnMainThread(() =>
                        {
                            image.Source = imageSource;
                        });
                    });
                }
            }

            BindingContext = this;
        }

        async void OnSaveClicked(object sender, EventArgs e)
        {
            if (isNewPlant)
            {
                MessagingCenter.Send(this, "AddNewPlant", Plant);
            }

            await Navigation.PopAsync();
        }

        async void OnLoadImagePicker(object sender, EventArgs e)
        {
            var action = await DisplayActionSheet("从哪里添加图片？", "取消", null, "照片库", "拍照");
            Debug.WriteLine("你选择了: " + action);
        }
    }
}

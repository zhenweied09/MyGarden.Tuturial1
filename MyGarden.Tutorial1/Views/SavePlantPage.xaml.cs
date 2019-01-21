using System;
using System.IO;
using System.Threading.Tasks;
using MyGarden.Tutorial1.ViewModels;
using Xamarin.Forms;

namespace MyGarden.Tutorial1.Views
{
    public partial class SavePlantPage : ContentPage
    {
        SavePlantViewModel _viewModel;

        public SavePlantPage(SavePlantViewModel viewModel)
        {
            InitializeComponent();

            BindingContext = _viewModel = viewModel;

            LoadPlantPhotos();

            MessagingCenter.Subscribe<SavePlantViewModel,Stream>(this, "AddImage", (sender,stream)=>AddImageControl(stream));
        }

        async void OnSavePlant(object sender, EventArgs e)
        {
            if (_viewModel.IsNewPlant)
            {
                MessagingCenter.Send(this, "AddNewPlant", _viewModel.Plant);
            }

            await Navigation.PopAsync();
        }

        async void OnLoadImagePicker(object sender, EventArgs e)
        {
            var action = await DisplayActionSheet("从哪里添加图片？", "取消", null, "照片库", "拍照");
            switch (action)
            {
                case "照片库":
                    _viewModel.LoadImageCommand.Execute(null);
                    break;
                case "拍照":
                    _viewModel.TaskPhotoCommand.Execute(null);
                    break;
            }
        }

        void LoadPlantPhotos()
        {
            if (_viewModel.Plant.PlantPhotos == null) return;

            foreach (var photos in _viewModel.Plant.PlantPhotos)
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

        //添加图片控件
        void AddImageControl(Stream stream)
        {
            PhotoList.Children.Add(new Image
            {
                Source = ImageSource.FromStream(() => { return stream; }),
                WidthRequest = 50,
                HeightRequest = 50,
                Aspect = Aspect.AspectFill,
                Margin = new Thickness(1)
            });
        }
    }
}

using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using MvvmHelpers;
using MyGarden.Tutorial1.Models;
using Plugin.Media;
using Plugin.Media.Abstractions;
using Plugin.Permissions;
using Plugin.Permissions.Abstractions;
using Xamarin.Forms;

namespace MyGarden.Tutorial1.ViewModels
{
    public class SavePlantViewModel : BaseViewModel
    {

        Plant _plant;
        public Plant Plant
        {
            get { return _plant; }
            set { SetProperty(ref _plant, value); }
        }
        public bool IsNewPlant { get; } = true;

        public Command LoadImageCommand { get; set; }
        public Command TaskPhotoCommand { get; set; }

        public SavePlantViewModel(Plant plant = null)
        {
            if (plant == null)
            {
                Title = "新增植物";
                Plant = new Plant();
            }
            else
            {
                Title = "修改植物";
                Plant = plant;
                IsNewPlant = false;
            }

            LoadImageCommand = new Command(async ()=> await SelectImageFromLibrary());
            TaskPhotoCommand = new Command(async ()=> await TakePhotoFromCamera());
        }


        async Task SelectImageFromLibrary()
        {
            await CrossMedia.Current.Initialize();

            if (!CrossMedia.Current.IsPickPhotoSupported)
            {
                await App.Current.MainPage.DisplayAlert("无法打开照片库", "设备不支持", "OK");
                return;
            }

            //检查是否有读取照片的权限，如果没有则请求一次权限
            var photosStatus = await CrossPermissions.Current.CheckPermissionStatusAsync(Permission.Photos);
            if (photosStatus != PermissionStatus.Granted)
            {
                var results = await CrossPermissions.Current.RequestPermissionsAsync(new[] { Permission.Photos });
                photosStatus = results[Permission.Photos];
            }

            if (photosStatus == PermissionStatus.Granted)
            {
                var file = await CrossMedia.Current.PickPhotoAsync(
                            new PickMediaOptions
                            {
                                PhotoSize = PhotoSize.Small,
                                CompressionQuality = 92
                            });

                if (file == null)
                    return;
                    
                MessagingCenter.Send(this, "AddImage", file.GetStream());
                AddPlantPhotoObject(file.Path, file.GetStream());
                file.Dispose();
            }
            else
            {
                await App.Current.MainPage.DisplayAlert("没有权限", "没有权限访问照片库", "OK");

                //iOS客户端时打开设置界面
                if (Device.RuntimePlatform == Device.iOS)
                {
                    CrossPermissions.Current.OpenAppSettings();
                }
            }
        }

        async Task TakePhotoFromCamera()
        {
            await CrossMedia.Current.Initialize();

            if (!CrossMedia.Current.IsCameraAvailable || !CrossMedia.Current.IsTakePhotoSupported)
            {
                await App.Current.MainPage.DisplayAlert("无法访问摄像头", "设备不支持", "OK");
                return;
            }

            //检查照相机和存储权限，没有的话进行一次请求
            var cameraStatus = await CrossPermissions.Current.CheckPermissionStatusAsync(Permission.Camera);
            var storageStatus = await CrossPermissions.Current.CheckPermissionStatusAsync(Permission.Storage);

            if (cameraStatus != PermissionStatus.Granted || storageStatus != PermissionStatus.Granted)
            {
                var results = await CrossPermissions.Current.RequestPermissionsAsync(new[] { Permission.Camera, Permission.Storage });
                cameraStatus = results[Permission.Camera];
                storageStatus = results[Permission.Storage];
            }

            if (cameraStatus == PermissionStatus.Granted && storageStatus == PermissionStatus.Granted)
            {
                var file = await CrossMedia.Current.TakePhotoAsync(new StoreCameraMediaOptions
                {
                    SaveToAlbum = true //保存到照片库
                });

                if (file == null)
                    return;

                //Debug.WriteLine(file.AlbumPath); //公共照片库路径
                //Debug.WriteLine(file.Path); // 私有路径

                MessagingCenter.Send(this, "AddImage", file.GetStream());
                AddPlantPhotoObject(file.AlbumPath, file.GetStream());
                file.Dispose();
            }
            else
            {
                await App.Current.MainPage.DisplayAlert("没有权限", "没有权限访问摄像头或进行文件存储", "OK");

                //iOS客户端时打开设置界面
                if (Device.RuntimePlatform == Device.iOS)
                {
                    CrossPermissions.Current.OpenAppSettings();
                }
            }
        }

        //添加PlantPhoto对象到Plant.Photos
        void AddPlantPhotoObject(string path, Stream stream)
        {
            if (Plant.PlantPhotos == null)
                Plant.PlantPhotos = new List<PlantPhoto>();

            Plant.PlantPhotos.Add(new PlantPhoto
            {
                Path = Path.GetFileName(path),
                PlantId = Plant.Id,
                FileStream = stream
            });
        }

        
    }
}


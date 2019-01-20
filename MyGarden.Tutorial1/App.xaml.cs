using System;
using MyGarden.Tutorial1.Services;
using MyGarden.Tutorial1.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace MyGarden.Tutorial1
{
    public partial class App : Application
    {
        public static IPlantService PlantService { get; set; }

        public App()
        {
            InitializeComponent();

            PlantService = new MockPlantService();
            MainPage = new NavigationPage(new PlantsPage());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}

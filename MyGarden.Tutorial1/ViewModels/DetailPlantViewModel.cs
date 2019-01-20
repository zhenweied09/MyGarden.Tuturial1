
using MvvmHelpers;
using MyGarden.Tutorial1.Models;

namespace MyGarden.Tutorial1.ViewModels
{
    public class DetailPlantViewModel : BaseViewModel
    {
        Plant _plant;   
        public Plant Plant
        { 
            get { return _plant; }
            set { SetProperty(ref _plant, value); }
        }

        public DetailPlantViewModel(Plant plant)
        {
            Title = "植物详情";
            Plant = plant;
        }
    }
}

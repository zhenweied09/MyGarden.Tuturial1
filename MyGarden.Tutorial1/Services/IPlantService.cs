using System.Collections.Generic;
using System.Threading.Tasks;
using MyGarden.Tutorial1.Models;
using Xamarin.Forms;

namespace MyGarden.Tutorial1.Services
{
    public interface IPlantService
    {
        Task<List<Plant>> GetAllPlantsAsync();
        Task<Plant> GetPlantByIdAsync(long id);
        Task AddPlantAsync(Plant plant);
        Task UpdatePlantAsync(long id, Plant plant);
        Task RemovePlantAsync(long id);
        Task UploadPlantPhotosAsync(List<PlantPhoto> photos);
        Task<ImageSource> GetImageAsync(string path);
    }
}

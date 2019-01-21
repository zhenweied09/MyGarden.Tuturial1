using System.IO;
using MvvmHelpers;

namespace MyGarden.Tutorial1.Models
{
    public class PlantPhoto
    {
        public long Id { get; set; }
        public string Path { get; set; }        //图片路径名称
        public long PlantId { get; set; }
        public Stream FileStream { get; set; }
    }
}

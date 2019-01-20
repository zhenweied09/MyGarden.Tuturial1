using MvvmHelpers;

namespace MyGarden.Tutorial1.Models
{
    //花色
    public class FlowerColor
    {
        public long Id { get; set; }
        public string Color { get; set; }       //颜色代码(#faf3e6)
        public long PlantId { get; set; }
    }
}

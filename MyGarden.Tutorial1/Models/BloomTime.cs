using MvvmHelpers;

namespace MyGarden.Tutorial1.Models
{
    //花期
    public class BloomTime
    {
        public long Id { get; set; }
        public int Month { get; set; }          //开花的月份
        public long PlantId { get; set; }
    }
}

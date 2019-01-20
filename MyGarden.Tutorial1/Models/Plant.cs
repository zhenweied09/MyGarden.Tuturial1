using System.Collections.Generic;
using System.Text;
using MvvmHelpers;
using Xamarin.Forms;

namespace MyGarden.Tutorial1.Models
{
    public class Plant:ObservableObject
    {
        public long Id { get; set; }

        private string _name; 
        public string Name
        {
            get { return _name; }
            set { SetProperty(ref _name, value); }
        }

        private string _type;   //类型：一年生、两年生、多年生
        public string Type
        {
            get { return _type; }
            set { SetProperty(ref _type, value); }
        }

        private int? _hZoneMin, _hZoneMax;  //最小、最大耐寒区
        public int? HardinessZoneMin
        {
            get { return _hZoneMin; }
            set
            {
                SetProperty(ref _hZoneMin, value);
                OnPropertyChanged("HardinessZone");
            }
        }

        public int? HardinessZoneMax
        {
            get { return _hZoneMax; }
            set
            {
                SetProperty(ref _hZoneMax, value);
                OnPropertyChanged("HardinessZone");
            }
        }

        private string _height="-";         //植物高度
        public string PlantHeight
        {
            get { return _height; }
            set { SetProperty(ref _height, value); }
        }

        private string _desc;
        public string Description
        {
            get { return _desc; }
            set { SetProperty(ref _desc, value); }
        }

        private ImageSource _displayPhoto;
        public ImageSource DisplayPhoto
        {
            get { return _displayPhoto; }
            set { SetProperty(ref _displayPhoto, value); }
        }

        public List<BloomTime> BloomTimes { get; set; }         //花期
        public List<FlowerColor> FlowerColors { get; set; }     //花色
        public List<PlantPhoto> PlantPhotos { get; set; }       //图片


        public string HardinessZone
        {
            get
            {
                if (HardinessZoneMin.HasValue && HardinessZoneMax.HasValue)
                {
                    return $"{HardinessZoneMin.Value}-{HardinessZoneMax.Value}";
                }
                return "-";
            }
        }

        public string FlowerDate
        {
            get
            {
                StringBuilder date = new StringBuilder(20);
                if (BloomTimes != null)
                {
                    foreach (var time in BloomTimes)
                    {
                        date.Append(time.Month + ",");
                    }
                    if (date.Length > 0)
                    {
                        date.Remove(date.Length - 1, 1);
                    }
                }
                else
                {
                    date.Append("-");
                }
                return date.ToString();

            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyGarden.Tutorial1.Models;
using Xamarin.Forms;

namespace MyGarden.Tutorial1.Services
{
    public class MockPlantService : IPlantService
    {

        public List<Plant> Plants { get; private set; }

        public MockPlantService()
        {
            Plants = new List<Plant>()
            {
                new Plant
                    {
                        Id = 1,
                        Name = "玛格丽特-乳白",
                        Type = "多年生",
                        HardinessZoneMin = 6,
                        HardinessZoneMax = 11,
                        Description = "原名：木茼蒿，又名木春菊、法兰西菊，拉丁文名：Argyranthemum frutescens (L.) Sch.-Bip.，原产北非加那利群岛。菊科，木茼蒿属灌木，高达1米，枝条大部木质化。",
                        PlantPhotos = new List<PlantPhoto> { new PlantPhoto { Path = "sample-magelite-white.jpg" } },
                        BloomTimes = new List<BloomTime> { new BloomTime { Month = 3 }, new BloomTime { Month = 4 }, new BloomTime { Month = 5 } },
                        FlowerColors = new List<FlowerColor> { new FlowerColor { Color = "#faf3e6" } }
                    },
                    new Plant
                    {
                        Id = 2,
                        Name = "玛格丽特-粉",
                        Type = "多年生",
                        HardinessZoneMin = 6,
                        HardinessZoneMax = 11,
                        Description = "原名：木茼蒿，又名木春菊、法兰西菊，拉丁文名：Argyranthemum frutescens (L.) Sch.-Bip.，原产北非加那利群岛。菊科，木茼蒿属灌木，高达1米，枝条大部木质化。",
                        PlantPhotos = new List<PlantPhoto> { new PlantPhoto { Path = "sample-magelite-pink.jpg" } },
                        BloomTimes = new List<BloomTime> { new BloomTime { Month = 3 }, new BloomTime { Month = 4 }, new BloomTime { Month = 5 } },
                        FlowerColors = new List<FlowerColor> { new FlowerColor { Color = "#fca4b3" } }
                    },
                    new Plant
                    {
                        Id = 3,
                        Name = "藤本月季-欢迎",
                        Type = "多年生",
                        HardinessZoneMin = 4,
                        HardinessZoneMax = 9,
                        Description = "多季节重复开花，重瓣，强香, 成熟规格：65*250cm",
                        PlantPhotos = new List<PlantPhoto> { new PlantPhoto { Path = "sample-rose-bienvenue.jpeg" } },
                        BloomTimes = new List<BloomTime> { new BloomTime { Month = 3 }, new BloomTime { Month = 4 }, new BloomTime { Month = 5 } },
                        FlowerColors = new List<FlowerColor> { new FlowerColor { Color = "#f72fd9" } }
                    },
                    new Plant
                    {
                        Id = 4,
                        Name = "藤本月季-小伊甸园",
                        Type = "多年生",
                        HardinessZoneMin = 4,
                        HardinessZoneMax = 9,
                        Description = "小伊甸园(Mimi Eden)，也叫迷你伊甸，分灌木和藤本，灌木多季开花，藤本春季开花，有藤小伊之称。",
                        PlantPhotos = new List<PlantPhoto> { new PlantPhoto { Path = "sample-rose-littleedan.jpg" } },
                        BloomTimes = new List<BloomTime> { new BloomTime { Month = 3 }, new BloomTime { Month = 4 }, new BloomTime { Month = 5 } },
                        FlowerColors = new List<FlowerColor> { new FlowerColor { Color = "#f73bc8" }, new FlowerColor { Color = "#f4faf2" } }
                    },
                    new Plant
                    {
                        Id = 5,
                        Name = "藤本月季-焦糖蜜蜂",
                        Type = "多年生",
                        HardinessZoneMin = 4,
                        HardinessZoneMax = 9,
                        PlantPhotos = new List<PlantPhoto> { new PlantPhoto { Path = "sample-rose-honeycaramel.jpg" } },
                        BloomTimes = new List<BloomTime> { new BloomTime { Month = 3 }, new BloomTime { Month = 4 }, new BloomTime { Month = 5 } },
                        FlowerColors = new List<FlowerColor> { new FlowerColor { Color = "#fa6e0a" } }
                    },
                    new Plant
                    {
                        Id = 6,
                        Name = "藤本月季-弗罗伦蒂娜",
                        Type = "多年生",
                        HardinessZoneMin = 4,
                        HardinessZoneMax = 9,
                        Description = "佛罗伦蒂娜(佛罗伦萨、Florentina),德国, 2002,红色花，黄色花蕊。大花复瓣(26-40)，杯型过渡至平坦花，多季开放。约两米，宽度约一米，耐寒。",
                        PlantPhotos = new List<PlantPhoto> { new PlantPhoto { Path = "sample-rose-florentina.jpg" } },
                        BloomTimes = new List<BloomTime> { new BloomTime { Month = 3 }, new BloomTime { Month = 4 }, new BloomTime { Month = 5 } },
                        FlowerColors = new List<FlowerColor> { new FlowerColor { Color = "#e3051b" } }
                    },
                    new Plant
                    {
                        Id=7,
                        Name = "灌木月季-火热巧克力",
                        Type = "多年生",
                        HardinessZoneMin = 4,
                        HardinessZoneMax = 9,
                        Description = "2002年美国 赤褐色。温和水果香味。花瓣25到30个。平均直径10厘米，大型，双瓣（17 - 25花瓣），簇花，小群，竖起开花形式。多季节重复盛开。高度105厘米，宽度135厘米。",
                        PlantPhotos = new List<PlantPhoto> { new PlantPhoto { Path = "sample-rose-hotchocolate.jpg" } },
                        BloomTimes = new List<BloomTime> { new BloomTime { Month = 3 }, new BloomTime { Month = 4 }, new BloomTime { Month = 5 } },
                        FlowerColors = new List<FlowerColor> { new FlowerColor { Color = "#d12f02" } }
                    },
                    new Plant
                    {
                        Id = 8,
                        Name = "微型月季-甜蜜马车",
                        Type = "多年生",
                        HardinessZoneMin = 4,
                        HardinessZoneMax = 9,
                        Description = "甜蜜马车(Sweet Chariot) 也叫爆香紫，1984年美国培育的品种，紫色或紫色混合，微型月季,多头,强香",
                        PlantPhotos = new List<PlantPhoto> { new PlantPhoto { Path = "sample-rose-sweetchariot.jpg" } },
                        BloomTimes = new List<BloomTime> { new BloomTime { Month = 3 }, new BloomTime { Month = 4 }, new BloomTime { Month = 5 } },
                        FlowerColors = new List<FlowerColor> { new FlowerColor { Color = "#e870fa" } }
                    },
                    new Plant
                    {
                        Id = 9,
                        Name = "绣球花-无尽夏",
                        Type = "多年生",
                        HardinessZoneMin = 4,
                        HardinessZoneMax = 9,
                        Description = "碱性：深粉色，酸性：蓝色，中性：粉色和蓝色；成熟规格：1.5*1.5m",
                        PlantPhotos = new List<PlantPhoto>{
                            new PlantPhoto{Path="sample-endlesssummer.jpeg"}},
                        BloomTimes = new List<BloomTime>{
                            new BloomTime{Month=6},
                            new BloomTime{Month=7},
                            new BloomTime{Month=8},
                        new BloomTime{Month=9}},
                        FlowerColors = new List<FlowerColor>{
                        new FlowerColor{Color="#439df7"},
                        new FlowerColor{Color="#e870fa"}
                    }
                    },
                    new Plant
                    {
                        Id = 10,
                        Name = "羽扇豆-鲁冰花",
                        Type = "一年生",
                        HardinessZoneMin = 4,
                        HardinessZoneMax = 9,
                        Description = "羽扇豆（学名：Lupinus micranthus Guss.）一年生草本，高可达70厘米。茎基部分枝，掌状复叶，小叶披针型至倒披针型，叶质厚，总状花序顶生，花序轴纤细，花梗甚短，萼二唇形，被硬毛，花冠蓝色，旗瓣和龙骨瓣具白色斑纹。荚果长圆状线形，种子卵形，扁平，斑纹，光滑。3-5月开花，4-7月结果。",
                        PlantPhotos = new List<PlantPhoto>{
                        new PlantPhoto{Path="sample-lupinus.jpg"}},
                        BloomTimes = new List<BloomTime> { new BloomTime { Month = 3 }, new BloomTime { Month = 4 }, new BloomTime { Month = 5 } },
                        FlowerColors = new List<FlowerColor>{
                        new FlowerColor{Color="#fae525"},
                        new FlowerColor{Color="#fa2542"},
                        new FlowerColor{Color="#f325fa"},
                        new FlowerColor{Color="#25b0fa"}}
                    },
                    new Plant
                    {
                        Id = 11,
                        Name = "大花金光菊",
                        Type = "多年生",
                        HardinessZoneMin = 4,
                        HardinessZoneMax = 9,
                        Description = "金光菊（学名：Rudbeckia laciniata L.）：又名黑眼菊、黄菊、黄菊花、假向日葵等，属桔梗目、菊科多年生草本，茎无毛或稍有短糙毛。叶互生，无毛或被疏短毛。头状花序单生于枝端，具长花序梗。总苞半球形；花托球形；舌状花金黄色；舌片倒披针形；管状花黄色或黄绿色。瘦果无毛，稍有4棱。花期7-10月。",
                        PlantPhotos = new List<PlantPhoto>{
                        new PlantPhoto{Path="sample-rudbeckia.jpeg"}},
                        FlowerColors = new List<FlowerColor> { new FlowerColor { Color = "#fac825" } },
                        BloomTimes = new List<BloomTime> { new BloomTime { Month = 7 }, new BloomTime { Month = 8 }, new BloomTime { Month = 9 }, new BloomTime { Month = 10 } }
                    },
                    new Plant
                    {
                        Id = 12,
                        Name = "矾根-红色信号",
                        Type = "多年生",
                        HardinessZoneMin = 4,
                        HardinessZoneMax = 9,
                        PlantPhotos = new List<PlantPhoto> { new PlantPhoto { Path = "sample-heuchera.jpg" } }
                    },
                    new Plant
                    {
                        Id = 13,
                        Name = "矾根-摩卡咖啡",
                        Type = "多年生",
                        HardinessZoneMin = 4,
                        HardinessZoneMax = 9,
                        PlantPhotos = new List<PlantPhoto> { new PlantPhoto { Path = "sample-heuchera.jpg" } }
                    },
                    new Plant
                    {
                        Id = 14,
                        Name = "矾根-花毯",
                        Type = "多年生",
                        HardinessZoneMin = 4,
                        HardinessZoneMax = 9,
                        PlantPhotos = new List<PlantPhoto> { new PlantPhoto { Path = "sample-heuchera.jpg" } }
                    },
                    new Plant
                    {
                        Id = 15,
                        Name = "矾根-栀子黄",
                        Type = "多年生",
                        HardinessZoneMin = 4,
                        HardinessZoneMax = 9,
                        PlantPhotos = new List<PlantPhoto> { new PlantPhoto { Path = "sample-heuchera.jpg" } }
                    },
                    new Plant
                    {
                        Id = 16,
                        Name = "矾根-饴糖",
                        Type = "多年生",
                        HardinessZoneMin = 4,
                        HardinessZoneMax = 9,
                        PlantPhotos = new List<PlantPhoto> { new PlantPhoto { Path = "sample-heuchera.jpg" } }
                    },
                    new Plant
                    {
                        Id = 17,
                        Name = "矾根-秋枫",
                        Type = "多年生",
                        HardinessZoneMin = 4,
                        HardinessZoneMax = 9,
                        PlantPhotos = new List<PlantPhoto> { new PlantPhoto { Path = "sample-heuchera.jpg" } }
                    },
                    new Plant
                    {
                        Id = 18,
                        Name = "蜀葵",
                        Type = "一年或两年生",
                        HardinessZoneMin = 4,
                        HardinessZoneMax = 1,
                        Description = "蜀葵（学名：Althaea rosea (Linn.) Cavan.），别称一丈红、大蜀季、戎葵。二年生直立草本，高达2米，茎枝密被刺毛。花呈总状花序顶生单瓣或重瓣，有紫、粉、红、白等色；花期6月至8月，蒴果，种子扁圆，肾脏形。喜阳光充足，耐半阴，但忌涝。原产中国四川，在中国分布很广，华东、华中、华北均有。",
                        PlantPhotos = new List<PlantPhoto> { new PlantPhoto { Path = "sample-shukui.jpg" } },
                        BloomTimes = new List<BloomTime> { new BloomTime { Month = 6 }, new BloomTime { Month = 7 }, new BloomTime { Month = 8 } },
                        FlowerColors = new List<FlowerColor> { new FlowerColor { Color = "#f71e66" }, new FlowerColor { Color = "#fa55fa" } }
                    },
                    new Plant
                    {
                        Id = 19,
                        Name = "铁线莲-哈尼亚",
                        Type = "多年生",
                        HardinessZoneMin = 4,
                        HardinessZoneMax = 9,
                        Description = "修剪方式：二类（轻剪）",
                        PlantPhotos = new List<PlantPhoto>{
                        new PlantPhoto{Path="sample-clematis-hania.jpg"}},
                        BloomTimes = new List<BloomTime>{
                        new BloomTime{Month=3},
                        new BloomTime{Month=4},
                        new BloomTime{Month=5}},
                        FlowerColors = new List<FlowerColor>{
                        new FlowerColor{Color="#bd26eb"},
                        new FlowerColor{Color="#d92bb3"}}
                    },
                    new Plant
                    {
                        Id = 20,
                        Name = "铁线莲-科尔蒙迪利女士",
                        Type = "多年生",
                        HardinessZoneMin = 4,
                        HardinessZoneMax = 9,
                        Description = "修剪方式：二类（轻剪）",
                        PlantPhotos = new List<PlantPhoto>{
                        new PlantPhoto{Path="sample-clematis-mrscholmondeley.jpeg"}},
                        BloomTimes = new List<BloomTime>{
                        new BloomTime{Month=3},
                        new BloomTime{Month=4},
                        new BloomTime{Month=5}},
                        FlowerColors = new List<FlowerColor>{
                        new FlowerColor{Color="#aa00ff"},
                        new FlowerColor{Color="#be86f7"}}
                    },
                    new Plant
                    {
                        Id = 21,
                        Name = "油橄榄",
                        Type = "多年生",
                        Description = "油橄榄（Olea europaea.）是木犀科木犀榄属常绿乔木，是世界著名的木本油料兼果用树种，栽培品种有较高食用价值，含丰富优质食用植物油——油橄榄油，为著名亚热带果树和重要经济林木，主要分布于地中海国家，希腊、意大利、突尼斯、西班牙为集中产地",
                        PlantPhotos = new List<PlantPhoto> { new PlantPhoto { Path = "sample-youganlan.jpg" } }
                    },
                    new Plant
                    {
                        Id = 22,
                        Name = "柠檬-美国由力克",
                        Type = "多年生",
                        PlantPhotos = new List<PlantPhoto> { new PlantPhoto { Path = "sample-lemon-youlike.jpg" } }
                    },
                    new Plant
                    {
                        Id = 23,
                        Name = "葡萄-赤霞珠",
                        Type = "多年生",
                        Description = "赤霞珠（Cabernet Sauvignon)是一种用于酿造葡萄酒的红葡萄品种，原产自法国波尔多(Bordeaux)地区，生长容易，适合多种不同气候，已于各地普遍种植。",
                        PlantPhotos = new List<PlantPhoto> { new PlantPhoto { Path = "sample-chixiazhu.jpg" } }
                    },
                    new Plant
                    {
                        Id = 24,
                        Name = "海南青柑桔",
                        Type = "多年生",
                        PlantPhotos = new List<PlantPhoto> { new PlantPhoto { Path = "sample-qingganji.jpg" } }
                    },
                    new Plant
                    {
                        Id = 25,
                        Name = "蓝莓-奥尼尔",
                        Type = "多年生",
                        Description = "奥尼尔(O'Neal)是于1987年由美国选育的南高丛蓝莓品种。该品种果实风味足，品质佳。果实成熟期早，需冷量低。",
                        PlantPhotos = new List<PlantPhoto> { new PlantPhoto { Path = "sample-blueberry.jpg" } }
                    },
                    new Plant
                    {
                        Id = 26,
                        Name = "树莓-秋苹",
                        Type = "多年生",
                        Description = "树莓“秋萍”：秋福二代升级品种，双季树莓，硬度中等，浆果汁液鲜红色，酸甜，有香味。抗寒性强，沈阳及周边地区种植冬季不用埋土防寒。植株生长健壮，枝茎粗壮，直立性强。该品种品质优，果实大，硬度好，早熟，产量高。",
                        PlantPhotos = new List<PlantPhoto> { new PlantPhoto { Path = "sample-raspberry.jpg" } }
                    },
                    new Plant
                    {
                        Id = 27,
                        Name = "无花果-小甜心",
                        Type = "多年生",
                        PlantPhotos = new List<PlantPhoto> { new PlantPhoto { Path = "sample-wuhuaguo-xiaotianxin.jpg" } }
                    },
                    new Plant
                    {
                        Id = 28,
                        Name = "多肉-丽晃",
                        Type = "多年生",
                        Description = "丽晃（学名：Delosperma cooperi ），番杏科露子花属植物。夏季耐热，耐干旱，不耐寒。肉质叶片生长非常强健，可以迅速覆盖花园裸露地面。",
                        PlantPhotos = new List<PlantPhoto> { new PlantPhoto { Path = "sample-lihuang.jpg" } },
                        FlowerColors = new List<FlowerColor> { new FlowerColor { Color = "#d926fc" } }
                    },
                    new Plant
                    {
                        Id = 29,
                        Name = "多肉-黄金薄雪",
                        Type = "多年生",
                        Description = "金万年草是景天科景天属植物，光照充足时金黄的颜色非常靓丽是作为花盆边缘的点缀的很好选择。黄金万年草据说原种叶片浓绿色，本种是叶片黄化的园艺品种，所以会出现返祖的现象。",
                        PlantPhotos = new List<PlantPhoto> { new PlantPhoto { Path = "sample-goldenboxue.jpg" } }
                    },
                    new Plant
                    {
                        Id = 30,
                        Name = "匍匐迷迭香",
                        Type = "多年生",
                        PlantPhotos = new List<PlantPhoto> { new PlantPhoto { Path = "sample-pufumidiexiang.jpg" } }
                    },
                    new Plant
                    {
                        Id = 31,
                        Name = "巧克力薄荷",
                        Type = "多年生",
                        PlantPhotos = new List<PlantPhoto> { new PlantPhoto { Path = "sample-chocolatemint.jpg" } }
                    },
                    new Plant
                    {
                        Id = 32,
                        Name = "朝雾草",
                        Type = "多年生",
                        Description = "朝雾草（Artemisia schmidtianai），别名银叶草，菊科。原产尼泊尔、中国西藏等地区，为菊科多年生草本植物。在高山或岩石缝间自然生长，茎叶纤细、柔软，植株通体呈银白色绢毛，茎常分枝，横向伸展，高约10厘米左右，7月至8月间开白色小花，优美动人。",
                        PlantPhotos = new List<PlantPhoto> { new PlantPhoto { Path = "sample-chaowucao.jpg" } }
                    },
                    new Plant
                    {
                        Id = 33,
                        Name = "法国百里香",
                        Type = "多年生",
                        Description = "法国百里香，别名： 麝香草，多年生亚灌木，百里香属。法国百里香为立性麝香味百里香，香味较英国百里香浓。叶为深绿色至深青绿，小而尖，茎分枝茂盛，为木质花小淡紫色至白色，有浓郁芳香。",
                        PlantPhotos = new List<PlantPhoto> { new PlantPhoto { Path = "sample-bailixiang.JPG" } },
                    },
                    new Plant
                    {
                        Id = 34,
                        Name = "香叶天竺葵",
                        Type = "多年生",
                        Description = "香叶天竺葵（学名：Pelargonium graveolens L'Herit.），为多年生草本或灌木状，高可达1米。茎直立，基部木质化，上部肉质，密被具光泽的柔毛，有香味。",
                        PlantPhotos = new List<PlantPhoto> { new PlantPhoto { Path = "sample-tianzukui.jpg" } },
                        BloomTimes = new List<BloomTime> { new BloomTime { Month = 5 }, new BloomTime { Month = 6 }, new BloomTime { Month = 7 } },
                        FlowerColors = new List<FlowerColor> { new FlowerColor { Color = "#eca7fa" } }
                    },
                    new Plant
                    {
                        Id = 35,
                        Name = "香茅",
                        Type = "多年生",
                        Description = "香茅，是禾本科、香茅属的约55种芳香性植物的统称，亦称为香茅草，为常见的香草之一。因有柠檬香气，故又被称为柠檬草。",
                        PlantPhotos = new List<PlantPhoto> { new PlantPhoto { Path = "sample-xiangmao.jpeg" } }
                    },
                    new Plant
                    {
                        Id = 36,
                        Name = "百子莲",
                        Type = "多年生",
                        HardinessZoneMin = 8,
                        HardinessZoneMax = 11,
                        Description = "百子莲（学名：Agapanthus africanus Hoffmgg.）是石蒜科百子莲属植物。宿根植物，盛夏至初秋开花，花色深蓝色或白色。叶线状披针形，近革质；花茎直立，高达60厘米；伞形花序，花10朵～50朵，花漏斗状，深蓝色或白色，花药初为黄色，后变成黑色；花期7月～8月。",
                        PlantPhotos = new List<PlantPhoto> { new PlantPhoto { Path = "sample-baizilian.png" } },
                        FlowerColors = new List<FlowerColor> { new FlowerColor { Color = "#6735fc" }, new FlowerColor { Color = "#f2f0fa" } },
                        BloomTimes = new List<BloomTime> { new BloomTime { Month = 7 }, new BloomTime { Month = 8 } }
                }
            };
        }

        public async Task AddPlantAsync(Plant plant)
        {
            await Task.Delay(TimeSpan.FromMilliseconds(100));
            long newId = Plants.Max(x => x.Id);
            plant.Id = ++newId;
            Plants.Add(plant);
        }

        public async Task<List<Plant>> GetAllPlantsAsync()
        {
            await Task.Delay(TimeSpan.FromMilliseconds(100));
            return Plants;
        }

        public async Task<Plant> GetPlantByIdAsync(long id)
        {
            await Task.Delay(TimeSpan.FromMilliseconds(100));
            var plant = Plants.SingleOrDefault(x => x.Id == id);
            return plant;
        }

        public async Task RemovePlantAsync(long id)
        {
            await Task.Delay(TimeSpan.FromMilliseconds(100));
            var plant = Plants.SingleOrDefault(x => x.Id == id);
            if (plant != null)
            {
                Plants.Remove(plant);
            }
        }

        public async Task UpdatePlantAsync(long id, Plant plant)
        {
            await Task.Delay(TimeSpan.FromMilliseconds(100));
            var oldPlant = Plants.SingleOrDefault(x => x.Id == id);
            if (oldPlant != null)
            {
                Plants.Remove(oldPlant);
                Plants.Add(plant);
            }
        }

        public async Task UploadPlantPhotosAsync(List<PlantPhoto> photos)
        {
            await Task.Delay(TimeSpan.FromMilliseconds(100));
        }

        public async Task<ImageSource> GetImageAsync(string path)
        {
            await Task.Delay(TimeSpan.FromMilliseconds(100));
            return ImageSource.FromResource("MyGarden.Tutorial1.Resources.Photos." + path);
        }
    }
}

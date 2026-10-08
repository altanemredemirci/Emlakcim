using AutoMapper;
using Emlakcim.BLL.DTOs.AgencyDTO;
using Emlakcim.BLL.DTOs.ProductDTO;
using Emlakcim.BLL.DTOs.ProductTypeDTO;
using Emlakcim.BLL.DTOs.SliderDTO;
using Emlakcim.BLL.DTOs.WhoWeAreDTO;
using Emlakcim.Entity;

namespace Emlakcim.UI.Mapping
{
    public class MapProfile:Profile
    {
        public MapProfile()
        {
            CreateMap<Product, ResultProductDTO>().ReverseMap();
            CreateMap<ProductType, ResultProductTypeDTO>().ReverseMap();
            CreateMap<Slider, ResultSliderDTO>().ReverseMap();
            CreateMap<WhoWeAre, ResultWhoWeAreDTO>().ReverseMap();
            CreateMap<Agency, ResultAgencyDTO>().ReverseMap();
        }
    }
}

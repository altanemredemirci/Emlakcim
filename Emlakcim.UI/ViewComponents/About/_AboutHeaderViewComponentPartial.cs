using AutoMapper;
using Emlakcim.BLL.Abstract;
using Emlakcim.BLL.DTOs.SliderDTO;
using Microsoft.AspNetCore.Mvc;

namespace Emlakcim.UI.ViewComponents.About
{
    public class _AboutHeaderViewComponentPartial:ViewComponent
    {
        private readonly ISliderService _sliderService;
        private readonly IMapper _mapper;

        public _AboutHeaderViewComponentPartial(ISliderService sliderService, IMapper mapper)
        {
            _sliderService = sliderService;
            _mapper = mapper;
        }

        public IViewComponentResult Invoke()
        {
            var sliders = _sliderService.GetByPage(i=>i.Page == "About");
            var models = _mapper.Map<ResultSliderDTO>(sliders);
            return View(models);
        }
    }
}

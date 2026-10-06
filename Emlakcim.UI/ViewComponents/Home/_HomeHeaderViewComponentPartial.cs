using AutoMapper;
using Emlakcim.BLL.Abstract;
using Emlakcim.BLL.DTOs.SliderDTO;
using Microsoft.AspNetCore.Mvc;

namespace Emlakcim.UI.ViewComponents.Home
{
    public class _HomeHeaderViewComponentPartial : ViewComponent
    {
        private readonly ISliderService _sliderService;
        private readonly IMapper _mapper;

        public _HomeHeaderViewComponentPartial(ISliderService sliderService, IMapper mapper)
        {
            _sliderService=sliderService;
            _mapper = mapper;
        }

        public IViewComponentResult Invoke()
        {
            var models = _sliderService.GetByPage(i => i.Page == "Index");

            return View(_mapper.Map<ResultSliderDTO>(models));
        }
    }
}


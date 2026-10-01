using Emlakcim.BLL.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Emlakcim.UI.ViewComponents.Home
{
    public class _HomeHeaderViewComponentPartial : ViewComponent
    {
        private ISliderService _sliderService;

        public _HomeHeaderViewComponentPartial(ISliderService sliderService)
        {
            _sliderService=sliderService;
        }
        public IViewComponentResult Invoke()
        {
            var models = _sliderService.GetByPage(i => i.Page == "Index");

            return View(models);
        }
    }
}


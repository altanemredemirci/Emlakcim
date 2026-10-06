using AutoMapper;
using Emlakcim.BLL.Abstract;
using Emlakcim.BLL.DTOs.WhoWeAreDTO;
using Microsoft.AspNetCore.Mvc;

namespace Emlakcim.UI.ViewComponents.Home
{
    public class _HomeAboutViewComponentPartial : ViewComponent
    {
        private readonly IWhoWeAreService _whoWeAreService;
        private readonly IMapper _mapper;

        public _HomeAboutViewComponentPartial(IWhoWeAreService whoWeAreService,IMapper mapper)
        {
            _whoWeAreService = whoWeAreService;
            _mapper = mapper;
        }

        public IViewComponentResult Invoke()
        {

            var model = _whoWeAreService.GetOne();

            return View(_mapper.Map<ResultWhoWeAreDTO>(model));
        }
    }
}
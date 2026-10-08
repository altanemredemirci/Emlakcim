using AutoMapper;
using Emlakcim.BLL.Abstract;
using Emlakcim.BLL.DTOs.AgencyDTO;
using Microsoft.AspNetCore.Mvc;

namespace Emlakcim.UI.ViewComponents.Home
{
    public class _HomeTeamStartViewComponentPartial : ViewComponent
    {
        private readonly IAgencyService _agencyService;
        private readonly IMapper _mapper;

        public _HomeTeamStartViewComponentPartial(IAgencyService agencyService, IMapper mapper)
        {
            _agencyService = agencyService;
            _mapper = mapper;
        }


        public IViewComponentResult Invoke()
        {
            var agencies = _agencyService.GetAll(i => i.Status == true);

            var models = _mapper.Map<List<ResultAgencyDTO>>(agencies);

            return View(models);
        }
    }
}
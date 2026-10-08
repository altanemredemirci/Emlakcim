using AutoMapper;
using Emlakcim.BLL.Abstract;
using Emlakcim.BLL.DTOs.ClientDTO;
using Microsoft.AspNetCore.Mvc;

namespace Emlakcim.UI.ViewComponents.Home
{
    public class _HomeTestimonialViewComponentPartial : ViewComponent
    {
        private readonly IClientService _clientService;
        private readonly IMapper _mapper;

        public _HomeTestimonialViewComponentPartial(IClientService clientService, IMapper mapper)
        {
            _clientService = clientService;
            _mapper = mapper;
        }

        public IViewComponentResult Invoke()
        {
            var clients = _clientService.GetAll();
            var models = _mapper.Map<List<ResultClientDTO>>(clients);
            return View(models);
        }
    }
}

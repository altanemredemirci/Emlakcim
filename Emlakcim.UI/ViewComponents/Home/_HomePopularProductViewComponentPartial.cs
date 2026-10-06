using AutoMapper;
using Emlakcim.BLL.Abstract;
using Emlakcim.BLL.DTOs.ProductDTO;
using Microsoft.AspNetCore.Mvc;

namespace Emlakcim.UI.ViewComponents.Home
{
    public class _HomePopularProductViewComponentPartial:ViewComponent
    {
        private readonly IProductService _productService;
        private readonly IMapper _mapper;

        public _HomePopularProductViewComponentPartial(IProductService productService, IMapper mapper)
        {
            _mapper = mapper;
            _productService = productService;
        }


        public IViewComponentResult Invoke()
        {
            return View(_mapper.Map<List<ResultProductDTO>>(_productService.GetPopularAll()));
        }
    }
}

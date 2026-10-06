using AutoMapper;
using Emlakcim.BLL.Abstract;
using Emlakcim.BLL.DTOs.ProductDTO;
using Microsoft.AspNetCore.Mvc;

namespace Emlakcim.UI.ViewComponents.Home
{
    public class _HomePropertyListViewComponentPartial : ViewComponent
    {
        private readonly IProductService _productService;
        private readonly IMapper _mapper;

        public _HomePropertyListViewComponentPartial(IProductService productService, IMapper mapper)
        {
            _productService = productService;
            _mapper = mapper;
        }
        public IViewComponentResult Invoke()
        {
            var products = _productService.GetAll(i => i.Status == true);

            var resultProducts = _mapper.Map<List<ResultProductDTO>>(products); 
            return View(resultProducts);
        }
    }
}

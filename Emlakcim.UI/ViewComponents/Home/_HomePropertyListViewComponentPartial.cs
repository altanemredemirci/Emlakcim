using Emlakcim.BLL.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Emlakcim.UI.ViewComponents.Home
{
    public class _HomePropertyListViewComponentPartial : ViewComponent
    {
        private readonly IProductService _productService;

        public _HomePropertyListViewComponentPartial(IProductService productService)
        {
            _productService = productService;
        }
        public IViewComponentResult Invoke()
        {
            var model = _productService.GetAll();
            return View(model);
        }
    }
}

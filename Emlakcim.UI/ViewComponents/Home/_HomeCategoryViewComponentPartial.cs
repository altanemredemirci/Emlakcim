using Emlakcim.BLL.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Emlakcim.UI.ViewComponents.Home
{
    public class _HomeCategoryViewComponentPartial : ViewComponent
    {
        private readonly IProductTypeService _productTypeService;

        public _HomeCategoryViewComponentPartial(IProductTypeService productTypeService)
        {
            _productTypeService = productTypeService;
        }
        public IViewComponentResult Invoke()
        {
            var models = _productTypeService.GetAll();
            return View(models);
        }
    }
}
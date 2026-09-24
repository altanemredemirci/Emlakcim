using Microsoft.AspNetCore.Mvc;

namespace Emlakcim.UI.ViewComponents.Layout
{
    public class _LayoutFooterViewComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
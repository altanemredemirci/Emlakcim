using Microsoft.AspNetCore.Mvc;

namespace Emlakcim.UI.ViewComponents.Layout
{
    public class _LayoutNavbarViewComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke() 
        {
            return View();
        }
    }
}

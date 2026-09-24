using Microsoft.AspNetCore.Mvc;

namespace Emlakcim.UI.ViewComponents.Layout
{
    public class _LayoutHeaderViewComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke() //Çağırmak
        {
            return View();
        }
    }
}

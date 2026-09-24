using Microsoft.AspNetCore.Mvc;

namespace Emlakcim.UI.ViewComponents.Layout
{
    public class _LayoutScriptViewComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}

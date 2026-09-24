using Emlakcim.UI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Emlakcim.UI.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }       
    }
}

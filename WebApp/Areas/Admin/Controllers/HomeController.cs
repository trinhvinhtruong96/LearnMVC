using Microsoft.AspNetCore.Mvc;

namespace WebApp.Areas.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
using Microsoft.AspNetCore.Mvc;

namespace HopestoneApp.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
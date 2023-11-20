using Microsoft.AspNetCore.Mvc;

namespace sinemaotomasyonu.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

using Microsoft.AspNetCore.Mvc;

namespace sinemaotomasyonu.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

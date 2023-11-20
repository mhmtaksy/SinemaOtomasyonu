using Microsoft.AspNetCore.Mvc;
using sinemaotomasyonu.Models;
using System.Linq;

namespace sinemaotomasyonu.Controllers
{
    public class KoltukController : Controller
    {
        public readonly ApplicationDbContext dbContext;

        public KoltukController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public IActionResult Index()
        {
            var result = dbContext.koltuklars.ToList();
            return View(result);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Koltuklar koltuklar)
        {
            dbContext.Add(koltuklar);
            dbContext.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Edit(int id)
        {
            var update = dbContext.koltuklars.Find(id);
            return View(update);
        }
        [HttpPost]
        public IActionResult Edit(Koltuklar koltuklar)
        {
            dbContext.Update(koltuklar);
            dbContext.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            var update = dbContext.koltuklars.Find(id);
            return View(update);
        }
        [HttpPost]
        public IActionResult Delete(Koltuklar koltuklar)
        {
            dbContext.Remove(koltuklar);
            dbContext.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using sinemaotomasyonu.Models;
using System.Linq;

namespace sinemaotomasyonu.Controllers
{
    public class MekanController : Controller
    {
        public readonly ApplicationDbContext dbContext;

        public MekanController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public IActionResult Index()
        {
            var result = dbContext.mekanlars.ToList();
            return View(result);
        }
        public IActionResult Create() 
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Mekan mekan)
        {
            dbContext.Add(mekan);
            dbContext.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            var update = dbContext.mekanlars.Find(id);
            return View(update);
        }
        [HttpPost]
        public IActionResult Edit(Mekan mekan)
        {
            dbContext.Update(mekan);
            dbContext.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            var update = dbContext.mekanlars.Find(id);
            return View(update);
        }
        [HttpPost]
        public IActionResult Delete(Mekan mekan)
        {
            dbContext.Remove(mekan);
            dbContext.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using sinemaotomasyonu.Models;
using System.Linq;

namespace sinemaotomasyonu.Controllers
{
    public class FilmController : Controller
    {
        public readonly ApplicationDbContext dbContext;

        public FilmController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public IActionResult Index()
        {
            var result = dbContext.filmlers.ToList();
            return View(result);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Filmler filmler)
        {
            dbContext.Add(filmler);
            dbContext.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Edit(int id)
        {
            var update = dbContext.filmlers.Find(id);
            return View(update);
        }
        [HttpPost]
        public IActionResult Edit(Filmler filmler)
        {
            dbContext.Update(filmler);
            dbContext.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            var update = dbContext.filmlers.Find(id);
            return View(update);
        }
        [HttpPost]
        public IActionResult Delete(Filmler filmler)
        {
            dbContext.Remove(filmler);
            dbContext.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}

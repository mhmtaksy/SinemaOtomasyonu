using Microsoft.AspNetCore.Mvc;
using sinemaotomasyonu.Models;
using System.Linq;

namespace sinemaotomasyonu.Controllers
{
    public class SeansController : Controller
    {
        public readonly ApplicationDbContext dbContext;

        public SeansController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public IActionResult Index()
        {
            var result = dbContext.seanslars.ToList();
            return View(result);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Seanslar seanslar)
        {
            dbContext.Add(seanslar);
            dbContext.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Edit(int id)
        {
            var update = dbContext.seanslars.Find(id);
            return View(update);
        }
        [HttpPost]
        public IActionResult Edit(Seanslar seanslar)
        {
            dbContext.Update(seanslar);
            dbContext.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            var update = dbContext.seanslars.Find(id);
            return View(update);
        }
        [HttpPost]
        public IActionResult Delete(Seanslar seanslar)
        {
            dbContext.Remove(seanslar);
            dbContext.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}

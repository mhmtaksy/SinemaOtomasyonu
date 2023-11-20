using Microsoft.AspNetCore.Mvc;
using sinemaotomasyonu.Models;
using System.Linq;

namespace sinemaotomasyonu.Controllers
{
    public class İzleyiciController : Controller
    {
        public readonly ApplicationDbContext dbContext;

        public İzleyiciController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public IActionResult Index()
        {
            var result = dbContext.izleyicilers.ToList();
            return View(result);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(İzleyiciler izleyiciler)
        {
            dbContext.Add(izleyiciler);
            dbContext.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Edit(int id)
        {
            var update = dbContext.izleyicilers.Find(id);
            return View(update);
        }
        [HttpPost]
        public IActionResult Edit(İzleyiciler izleyiciler)
        {
            dbContext.Update(izleyiciler);
            dbContext.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            var update = dbContext.izleyicilers.Find(id);
            return View(update);
        }
        [HttpPost]
        public IActionResult Delete(İzleyiciler izleyiciler)
        {
            dbContext.Remove(izleyiciler);
            dbContext.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}

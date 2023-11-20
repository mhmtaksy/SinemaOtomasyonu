using Microsoft.AspNetCore.Mvc;
using sinemaotomasyonu.Models;
using System.Linq;

namespace sinemaotomasyonu.Controllers
{
    public class GörevliController : Controller
    {
        
            public readonly ApplicationDbContext dbContext;

            public GörevliController(ApplicationDbContext dbContext)
            {
                this.dbContext = dbContext;
            }
            public IActionResult Index()
            {
                var result = dbContext.görevlis.ToList();
                return View(result);
            }
            public IActionResult Create()
            {
                return View();
            }
            [HttpPost]
            public ActionResult Create(Görevli görevli) 
            {
                dbContext.Add(görevli);
                dbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            public ActionResult Edit(int id)
            {
                var update = dbContext.görevlis.Find(id);
                return View(update);
            }
            [HttpPost]
            public ActionResult Edit(Görevli görevli)
            {
               dbContext.Update(görevli);
               dbContext.SaveChanges();
               return RedirectToAction("Index");
            }
            public ActionResult Delete(int id)
            {
               var update = dbContext.görevlis.Find(id);
               return View(update);
            }
            [HttpPost]
            public ActionResult Delete(Görevli görevli)
            {
               dbContext.Remove(görevli);
               dbContext.SaveChanges();
               return RedirectToAction("Index");
            }
    }
}

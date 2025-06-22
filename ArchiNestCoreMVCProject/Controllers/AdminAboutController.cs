using ArchiNestCoreMVCProject.Context;
using ArchiNestCoreMVCProject.Entities;
using Microsoft.AspNetCore.Mvc;

namespace ArchiNestCoreMVCProject.Controllers
{
    public class AdminAboutController : Controller
    {
        private DatabaseContext _context;

        public AdminAboutController(DatabaseContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var values = _context.Abouts.FirstOrDefault();
            return View(values);
        }

        public IActionResult Delete(int id)
        {
            var value = _context.Abouts.Find(id);
            _context.Abouts.Remove(value);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            var value = _context.Abouts.Find(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult Update(About updatedAbout)
        {
            _context.Abouts.Update(updatedAbout);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }


    }
}

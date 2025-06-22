using ArchiNestCoreMVCProject.Context;
using ArchiNestCoreMVCProject.Entities;
using Microsoft.AspNetCore.Mvc;

namespace ArchiNestCoreMVCProject.Controllers
{
    public class AdminHomeController : Controller
    {
        private readonly DatabaseContext _context;

        public AdminHomeController(DatabaseContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var values = _context.Homes.ToList();
            return View(values);
        }

        public IActionResult Delete(int id)
        {
            var value = _context.Homes.Find(id);
            _context.Homes.Remove(value);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            var value = _context.Homes.Find(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult Update(Home updatedHome)
        {
            _context.Homes.Update(updatedHome);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}

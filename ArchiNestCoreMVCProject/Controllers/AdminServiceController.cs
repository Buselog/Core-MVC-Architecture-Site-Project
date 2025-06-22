using ArchiNestCoreMVCProject.Context;
using ArchiNestCoreMVCProject.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ArchiNestCoreMVCProject.Controllers
{
    public class AdminServiceController : Controller
    {
        private readonly DatabaseContext _context;

        public AdminServiceController(DatabaseContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var values = _context.Services.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Services newService)
        {
            _context.Services.Add(newService);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var value = _context.Services.Find(id);
            _context.Services.Remove(value);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            var value = _context.Services.Find(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult Update(Services updatedService)
        {
            _context.Services.Update(updatedService);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}

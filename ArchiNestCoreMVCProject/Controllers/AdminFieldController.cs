using ArchiNestCoreMVCProject.Context;
using ArchiNestCoreMVCProject.Entities;
using Microsoft.AspNetCore.Mvc;

namespace ArchiNestCoreMVCProject.Controllers
{
    public class AdminFieldController : Controller
    {
        private readonly DatabaseContext _context;

        public AdminFieldController(DatabaseContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var values = _context.Fields.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Field newField)
        {
            _context.Fields.Add(newField);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var value = _context.Fields.Find(id);
            _context.Fields.Remove(value);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            var value = _context.Fields.Find(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult Update(Field updatedField)
        {
            _context.Fields.Update(updatedField);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}

using ArchiNestCoreMVCProject.Context;
using ArchiNestCoreMVCProject.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ArchiNestCoreMVCProject.Controllers
{
    public class AdminTestimonialController : Controller
    {
        private readonly DatabaseContext _context;

        public AdminTestimonialController(DatabaseContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var values = _context.Testimonials.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Testimonial newTestimonial)
        {
            _context.Testimonials.Add(newTestimonial);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var value = _context.Testimonials.Find(id);
            _context.Testimonials.Remove(value);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            var value = _context.Testimonials.Find(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult Update(Testimonial updatedTestimonial)
        {
            _context.Testimonials.Update(updatedTestimonial);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}

using ArchiNestCoreMVCProject.Context;
using ArchiNestCoreMVCProject.Entities;
using Microsoft.AspNetCore.Mvc;

namespace ArchiNestCoreMVCProject.Controllers
{
    public class AdminAddressController : Controller
    {

        private readonly DatabaseContext _context;

        public AdminAddressController(DatabaseContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var value = _context.Addresses.FirstOrDefault();
            return View(value);
        }

        public IActionResult Delete(int id)
        {
            var value = _context.Addresses.Find(id);
            _context.Addresses.Remove(value);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            var value = _context.Addresses.Find(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult Update(Address updatedAddress)
        {
            _context.Addresses.Update(updatedAddress);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}

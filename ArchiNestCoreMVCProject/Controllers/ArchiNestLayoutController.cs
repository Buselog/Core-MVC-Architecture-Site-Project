using ArchiNestCoreMVCProject.Context;
using ArchiNestCoreMVCProject.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ArchiNestCoreMVCProject.Controllers
{
    public class ArchiNestLayoutController : Controller
    {
        private readonly DatabaseContext _context;

        public ArchiNestLayoutController(DatabaseContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ContactAdd(Contact newContactRequest)
        {
            _context.Contacts.Add(newContactRequest);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}

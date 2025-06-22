using ArchiNestCoreMVCProject.Context;
using Microsoft.AspNetCore.Mvc;

namespace ArchiNestCoreMVCProject.Controllers
{
    public class AdminContactController : Controller
    {

        private readonly DatabaseContext _context;

        public AdminContactController(DatabaseContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var values = _context.Contacts.ToList();
            return View(values);
        }
    }
}

using ArchiNestCoreMVCProject.Context;
using ArchiNestCoreMVCProject.Entities;
using Microsoft.AspNetCore.Mvc;

namespace ArchiNestCoreMVCProject.Controllers
{
    public class AdminPortfolioController : Controller
    {
        private readonly DatabaseContext _context;

        public AdminPortfolioController(DatabaseContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var values = _context.Portfolios.ToList();
            return View(values);
        }

        public IActionResult Delete(int id)
        {
            var value = _context.Portfolios.Find(id);
            _context.Portfolios.Remove(value);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            var value = _context.Portfolios.Find(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult Update(Portfolio updatedPortfolio)
        {
            _context.Portfolios.Update(updatedPortfolio);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}

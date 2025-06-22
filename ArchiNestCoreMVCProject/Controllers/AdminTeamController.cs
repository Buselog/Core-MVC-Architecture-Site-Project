using ArchiNestCoreMVCProject.Context;
using ArchiNestCoreMVCProject.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ArchiNestCoreMVCProject.Controllers
{
    public class AdminTeamController : Controller
    {
        private readonly DatabaseContext _context;

        public AdminTeamController(DatabaseContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var values = _context.Teams.Include(x=>x.Field).ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Team newTeamMember)
        {
            _context.Teams.Add(newTeamMember);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var value = _context.Teams.Find(id);
            _context.Teams.Remove(value);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            var value = _context.Teams.Find(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult Update(Team updatedTeam)
        {
            _context.Teams.Update(updatedTeam);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}

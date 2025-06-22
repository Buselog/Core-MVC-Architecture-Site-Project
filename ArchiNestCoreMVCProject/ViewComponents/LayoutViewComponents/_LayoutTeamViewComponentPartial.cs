using ArchiNestCoreMVCProject.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ArchiNestCoreMVCProject.ViewComponents.LayoutViewComponents
{
    public class _LayoutTeamViewComponentPartial : ViewComponent
    {
        private readonly DatabaseContext _context;

        public _LayoutTeamViewComponentPartial(DatabaseContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            var values = _context.Teams.Include(x=>x.Field).ToList();
            return View(values);
        }
    }
}

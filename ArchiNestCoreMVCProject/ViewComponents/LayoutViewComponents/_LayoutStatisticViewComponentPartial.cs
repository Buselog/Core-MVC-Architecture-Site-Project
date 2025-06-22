using ArchiNestCoreMVCProject.Context;
using Microsoft.AspNetCore.Mvc;
using System.Globalization;

namespace ArchiNestCoreMVCProject.ViewComponents.LayoutViewComponents
{
    public class _LayoutStatisticViewComponentPartial : ViewComponent
    {

        private readonly DatabaseContext _context;

        public _LayoutStatisticViewComponentPartial(DatabaseContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            ViewBag.FieldCount = _context.Fields.Count();
            ViewBag.TeamMemberCount = _context.Teams.Count();
            ViewBag.ProjectCount = _context.Portfolios.Count() + _context.Services.Count();
            ViewBag.RatingAvg = _context.Testimonials.Select(x => x.Rating).Average();
            return View();
        }
    }
}

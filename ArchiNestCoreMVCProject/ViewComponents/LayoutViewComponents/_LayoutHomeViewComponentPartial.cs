using ArchiNestCoreMVCProject.Context;
using Microsoft.AspNetCore.Mvc;

namespace ArchiNestCoreMVCProject.ViewComponents.LayoutViewComponents
{
    public class _LayoutHomeViewComponentPartial : ViewComponent
    {
        private readonly DatabaseContext _context;

        public _LayoutHomeViewComponentPartial(DatabaseContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            ViewBag.Title = _context.Homes.Select(x => x.Title).FirstOrDefault();
            ViewBag.Subtitle = _context.Homes.Select(x => x.Subtitle).FirstOrDefault();
            return View();
        }
             
    }
}

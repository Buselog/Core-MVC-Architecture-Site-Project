using ArchiNestCoreMVCProject.Context;
using Microsoft.AspNetCore.Mvc;
using System.Drawing.Text;

namespace ArchiNestCoreMVCProject.ViewComponents.LayoutViewComponents
{
    public class _LayoutAboutViewComponentPartial : ViewComponent
    {

        private readonly DatabaseContext _context;

        public _LayoutAboutViewComponentPartial(DatabaseContext context)
        {
            _context = context;
        }
        public IViewComponentResult Invoke()
        {
            ViewBag.Title = _context.Abouts.Select(x => x.Title).FirstOrDefault();
            ViewBag.Description1 = _context.Abouts.Select(x => x.Description1).FirstOrDefault();
            ViewBag.Description2 = _context.Abouts.Select(x => x.Description2).FirstOrDefault();
            ViewBag.ImageUrl = _context.Abouts.Select(x => x.ImageUrl).FirstOrDefault();
            ViewBag.VideoUrl = _context.Abouts.Select(x => x.VideoUrl).FirstOrDefault();

            return View();
        }
    }
}

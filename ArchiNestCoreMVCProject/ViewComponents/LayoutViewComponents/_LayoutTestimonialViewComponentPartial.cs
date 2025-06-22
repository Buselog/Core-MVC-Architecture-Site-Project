using ArchiNestCoreMVCProject.Context;
using Microsoft.AspNetCore.Mvc;

namespace ArchiNestCoreMVCProject.ViewComponents.LayoutViewComponents
{
    public class _LayoutTestimonialViewComponentPartial : ViewComponent
    {
        private readonly DatabaseContext _context;

        public _LayoutTestimonialViewComponentPartial(DatabaseContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            var values = _context.Testimonials.ToList();
            return View(values);
        }
    }
}

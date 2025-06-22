using ArchiNestCoreMVCProject.Context;
using Microsoft.AspNetCore.Mvc;

namespace ArchiNestCoreMVCProject.ViewComponents.LayoutViewComponents
{
    public class _LayoutServicesViewComponentPartial : ViewComponent
    {

        private readonly DatabaseContext _context;

        public _LayoutServicesViewComponentPartial(DatabaseContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            var values = _context.Services.ToList();
            return View(values);
        }
    }
}

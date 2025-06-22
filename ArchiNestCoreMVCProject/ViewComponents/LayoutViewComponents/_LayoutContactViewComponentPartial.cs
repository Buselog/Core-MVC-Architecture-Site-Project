using ArchiNestCoreMVCProject.Context;
using ArchiNestCoreMVCProject.Entities;
using Microsoft.AspNetCore.Mvc;

namespace ArchiNestCoreMVCProject.ViewComponents.LayoutViewComponents
{
    public class _LayoutContactViewComponentPartial : ViewComponent
    {
        private readonly DatabaseContext _context;

        public _LayoutContactViewComponentPartial(DatabaseContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            return View();
        }

      
    }
}

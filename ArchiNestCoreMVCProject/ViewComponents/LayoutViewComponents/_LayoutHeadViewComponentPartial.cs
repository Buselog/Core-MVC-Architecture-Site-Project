using ArchiNestCoreMVCProject.Context;
using Microsoft.AspNetCore.Mvc;

namespace ArchiNestCoreMVCProject.ViewComponents.LayoutViewComponents
{
    public class _LayoutHeadViewComponentPartial : ViewComponent
    {
        private readonly DatabaseContext _context;

        public _LayoutHeadViewComponentPartial(DatabaseContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            return View();
        }

    }
}

using ArchiNestCoreMVCProject.Context;
using Microsoft.AspNetCore.Mvc;

namespace ArchiNestCoreMVCProject.ViewComponents.LayoutViewComponents
{
    public class _LayoutPortfolioViewComponentPartial : ViewComponent
    {

        private DatabaseContext _context;

        public _LayoutPortfolioViewComponentPartial(DatabaseContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            var values = _context.Portfolios.ToList();
            return View(values);
        }
    }
}

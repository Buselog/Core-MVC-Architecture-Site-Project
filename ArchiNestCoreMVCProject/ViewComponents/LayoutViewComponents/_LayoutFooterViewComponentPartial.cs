using ArchiNestCoreMVCProject.Context;
using Microsoft.AspNetCore.Mvc;

namespace ArchiNestCoreMVCProject.ViewComponents.LayoutViewComponents
{
    public class _LayoutFooterViewComponentPartial : ViewComponent
    {

        private readonly DatabaseContext _context;

        public _LayoutFooterViewComponentPartial(DatabaseContext context)
        {
            _context = context;
        }
        public IViewComponentResult Invoke()
        {
            ViewBag.Address = _context.Addresses.Select(x => x.FullAddress).FirstOrDefault();
            ViewBag.Phone = _context.Addresses.Select(x => x.Phone).FirstOrDefault();
            ViewBag.Email = _context.Addresses.Select(x => x.Email).FirstOrDefault();

            var values = _context.Fields.OrderByDescending(x => x.FieldId).Take(5).ToList();
            return View(values);
        }
    }
}

using ArchiNestCoreMVCProject.Context;
using Microsoft.AspNetCore.Mvc;

namespace ArchiNestCoreMVCProject.ViewComponents.LayoutViewComponents
{
    public class _LayoutAddressViewComponentPartial : ViewComponent
    {

        private readonly DatabaseContext _context;

        public _LayoutAddressViewComponentPartial(DatabaseContext context)
        {
            _context = context;

        }

        public IViewComponentResult Invoke()
        {
            ViewBag.Address = _context.Addresses.Select(x => x.FullAddress).FirstOrDefault();
            ViewBag.Phone = _context.Addresses.Select(x => x.Phone).FirstOrDefault();
            ViewBag.Email = _context.Addresses.Select(x => x.Email).FirstOrDefault();
            return View();
        }
    }
}

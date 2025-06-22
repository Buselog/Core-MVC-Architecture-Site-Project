using Microsoft.AspNetCore.Mvc;

namespace ArchiNestCoreMVCProject.ViewComponents.AdminViewComponents
{
    public class _AdminFooterComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}

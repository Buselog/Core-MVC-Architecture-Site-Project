using Microsoft.AspNetCore.Mvc;

namespace ArchiNestCoreMVCProject.ViewComponents.AdminViewComponents
{
    public class _AdminSidebarComponentPartial : ViewComponent
    {

        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}

using Microsoft.AspNetCore.Mvc;

namespace ArchiNestCoreMVCProject.ViewComponents.AdminViewComponents
{
    public class _AdminHeadComponentPartial :ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}

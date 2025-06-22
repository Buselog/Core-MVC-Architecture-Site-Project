using Microsoft.AspNetCore.Mvc;

namespace ArchiNestCoreMVCProject.ViewComponents.LayoutViewComponents
{
    public class _LayoutHeaderViewComponentPartial : ViewComponent
    {

        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}

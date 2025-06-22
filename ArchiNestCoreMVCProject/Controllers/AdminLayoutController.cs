using Microsoft.AspNetCore.Mvc;

namespace ArchiNestCoreMVCProject.Controllers
{
    public class AdminLayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

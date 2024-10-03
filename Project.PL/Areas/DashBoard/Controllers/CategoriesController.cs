using Microsoft.AspNetCore.Mvc;

namespace Project.PL.Areas.DashBoard.Controllers
{
    public class CategoriesController : Controller
    {
        [Area("DashBoard")]
        public IActionResult Index()
        {
            return View();
        }
    }
}

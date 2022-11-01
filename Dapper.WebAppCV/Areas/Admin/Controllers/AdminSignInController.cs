using Microsoft.AspNetCore.Mvc;

namespace Dapper.WebAppCV.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminSignInController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

using Microsoft.AspNetCore.Mvc;

namespace Dockerprojectdemo.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

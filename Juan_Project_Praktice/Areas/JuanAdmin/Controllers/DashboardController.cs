using Microsoft.AspNetCore.Mvc;

namespace Juan_Project_Praktice.Areas.JuanAdmin.Controllers
{
    public class DashboardController : Controller
    {
        [Area("JuanAdmin")]
        public IActionResult Index()
        {
            return View();
        }
    }
}

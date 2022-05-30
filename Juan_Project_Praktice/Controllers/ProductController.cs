using Microsoft.AspNetCore.Mvc;

namespace Juan_Project_Praktice.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

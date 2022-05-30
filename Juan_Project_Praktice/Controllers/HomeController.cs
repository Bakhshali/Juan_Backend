using Juan_Project_Praktice.DAL;
using Juan_Project_Praktice.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Juan_Project_Praktice.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public async Task<IActionResult> Index()
        {
            HomeVM model = new HomeVM
            {
                Sliders = await _context.Slider.ToListAsync(),
                Sellings = await _context.Selling.ToListAsync(),
                Shoeses = await _context.Shoes.ToListAsync(),
                ProductImages = await _context.ProductImages.ToListAsync()
               
            };
            return View(model);
        }
        public HomeController(AppDbContext context)
        {

            _context = context;
        }
    }
}

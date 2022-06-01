using Juan_Project_Praktice.Areas.Extensions;
using Juan_Project_Praktice.DAL;
using Juan_Project_Praktice.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace Juan_Project_Praktice.Areas.JuanAdmin.Controllers
{
    [Area("JuanAdmin")]
    public class SliderController : Controller
    {
       

        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;

        public SliderController(AppDbContext context,IWebHostEnvironment env)
        {
            _context = context;
           _env = env;
        }

        public async Task<IActionResult> Index()
        {
            List<Slider> slider = await _context.Slider.ToListAsync();

            return View(slider);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]

        public async Task<IActionResult> Create(Slider slider)
        {
            if (!ModelState.IsValid) return View();

            if (slider.Photo!=null)
            {
                if (!slider.Photo.IsOkay(1))
                {
                    ModelState.AddModelError("Photo", "Please  choose correct image file, (you can choose only image file and 1MB and less)");
                    return View();
                }

                string filename = slider.Photo.FileName;
                string path = Path.Combine(_env.WebRootPath, "assets", "img", "slider");
                string fullpath = Path.Combine(path, filename);

                using (FileStream st = new FileStream(fullpath, FileMode.Create))
                {
                    await slider.Photo.CopyToAsync(st);
                }

                slider.Image = filename;
                await _context.Slider.AddAsync(slider);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));

            }

            else
            {
                ModelState.AddModelError("Photo", "Please choose file");
                return View();  
            }






        }
    }
}

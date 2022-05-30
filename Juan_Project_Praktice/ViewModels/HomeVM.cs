using Juan_Project_Praktice.Models;
using System.Collections.Generic;

namespace Juan_Project_Praktice.ViewModels
{
    public class HomeVM
    {
        public List<Slider> Sliders { get; set; }
        public List<Selling> Sellings { get; set; }
        public List<Shoes> Shoeses { get; set; }
        public List<Category> Categories { get; set; }
        public List<Product> Products { get; set; }
        public List<ProductImage> ProductImages { get; set; }
    }
}

using Juan_Project_Praktice.Models;
using Microsoft.EntityFrameworkCore;

namespace Juan_Project_Praktice.DAL
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Slider>Slider { get; set; }

        public DbSet<Selling>Selling { get; set; }

        public DbSet<Shoes>Shoes { get; set; }

        public DbSet<Product> Products{ get; set; }

        public DbSet<Category>Categories { get; set; }

        public DbSet<ProductImage>ProductImages { get; set; }



        
    }
}

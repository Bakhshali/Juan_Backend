using System.Collections.Generic;

namespace Juan_Project_Praktice.Models
{
    public class Product
    {
        public int Id { get; set; }

        public string Image { get; set; }

        public string Name { get; set; }

        public string Text { get; set; }

        public int RegularPrice { get; set; }

        public int OldPrice { get; set; }

        public int CategoryId { get; set; }

        public Category Category { get; set; }

        public List<ProductImage> ProductImage { get; set; }

    }
}

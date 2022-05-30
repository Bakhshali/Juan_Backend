namespace Juan_Project_Praktice.Models
{
    public class ProductImage
    {
        public int Id { get; set; }

        public string  ImageName { get; set; }

        public Product Product { get; set; }

        public int ProductId { get; set; }
    }
}

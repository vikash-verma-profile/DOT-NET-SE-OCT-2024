namespace Ecommerce.Webapp.Models
{
    public class Product
    {
        public int Id { get; set; }

        public string ProductName { get; set; } = null!;

        public string ProductDescription { get; set; } = null!;

        public int Quantity { get; set; }

        public double Price { get; set; }
    }

}

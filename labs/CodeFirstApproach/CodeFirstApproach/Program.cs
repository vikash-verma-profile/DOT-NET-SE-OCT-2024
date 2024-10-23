using CodeFirstApproach.Model;

namespace CodeFirstApproach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ApplicationDbContext db = new ApplicationDbContext();
            Product product = new Product();
            product.Name = "Sample";
            product.Price = 1000;
            product.Qunatity = 20;
            db.Products.Add(product);
            db.SaveChanges();
            foreach (var item in db.Products)
            {
                Console.WriteLine($"id: {item.ProductId} ,Name: {item.Name} Price: {item.Price}");
            }
        }
    }
}

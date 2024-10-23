using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectConsolewithDB
{
    /// <summary>
    /// where ,sleect ,order by,group by,join distinct take skip sum count 
    /// </summary>
    /// 
    class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }
    }

    public class ProductComparer : IEqualityComparer<Product>
    {
        bool IEqualityComparer<Product>.Equals(Product? x, Product? y)
        {
            return x.ProductId == y.ProductId;
        }

        int IEqualityComparer<Product>.GetHashCode(Product obj)
        {
            return obj.ProductId.GetHashCode();
        }
    }
    class ProductReviews
    {
        public int ProductId { get; set; }
        public List<string> Reviews { get; set; }
    }

    public class Category
    {
        public string CategoryName { get; set; }
    }
    internal class Class1
    {
        public static void Main1()
        {
            var productlist = new List<Product>()
            {
                new Product{ProductId=1,Name="Laptop",Price=1200,Category="Electronics"},
                new Product{ProductId=2,Name="Smartphone",Price=800,Category="Electronics"},
                new Product{ProductId=3,Name="Desk",Price=300,Category="Furniture"},
                new Product{ProductId=4,Name="Chair",Price=150,Category="Furniture"},
                new Product{ProductId=5,Name="Headpones",Price=1200,Category="Electronics"},
                new Product{ProductId=6,Name="Speakers",Price=1400,Category="Electronics"},
                new Product{ProductId=7,Name="Notebook",Price=10,Category="Stationary"}

            };

            var productReviews = new List<ProductReviews> {
            new ProductReviews{ ProductId=1,Reviews=new List<string>{"Great !","Excellent !"}},
             new ProductReviews{ ProductId=2,Reviews=new List<string>{"Good !","Average !"}},
               new ProductReviews{ ProductId=3,Reviews=new List<string>{"Bad !","Average !"}}
            };

            //1.where (Filtering)
            IEnumerable<Product> expensiveProducts = productlist.Where(p => p.Price > 500);
            Console.WriteLine("Expensive Products");
            foreach (var item in expensiveProducts)
            {
                Console.WriteLine(item.Name);
            }

            //2.Select (Projection)
            var productNames = productlist.Select(x => x.Name);
            Console.WriteLine("\nProduct Names");
            foreach (var item in productNames)
            {
                Console.WriteLine(item);
            }

            //3.Order by (Sorting)
            var orderbyPrice = productlist.OrderBy(x => x.Price);
            Console.WriteLine("\nProduct Order by Price");
            foreach (var item in orderbyPrice)
            {
                Console.WriteLine($"{item.Name}: {item.Price}");
            }

            //4.Group by (GroupBy)
            var groupbyCategory= productlist.GroupBy(x => x.Category);
            Console.WriteLine("\nProduct Grouped by Category");
            foreach (var item in groupbyCategory)
            {
                Console.WriteLine($"\nCategory {item.Key}");
                foreach (var p in item)
                {
                    Console.WriteLine($"{p.Name}: {p.Price}");
                }
                
            }

            //5.JOIn
            var categories = new List<Category> { 
            
                new Category{CategoryName="Electronics"},
                new Category{CategoryName="Furniture"}
            };

            var productwithCategories = productlist.Join(categories, p => p.Category, c => c.CategoryName, (p, c) => new { p.Name, p.Price, c.CategoryName });

            foreach (var item in productwithCategories)
            {
                Console.WriteLine($"{item.Name} ({item.CategoryName}): {item.Price}");
            }

            //6.Disticnt
            var distinctCategories = productlist.Select(p => p.Category).Distinct();
            Console.WriteLine("\nDistinct Categories");
            foreach (var item in distinctCategories)
            {
                Console.WriteLine(item);
            }

            //Take
            var topTwoProducts = productlist.Take(2);
            Console.WriteLine("\n Top 2 Products");
            foreach (var item in topTwoProducts)
            {
                Console.WriteLine(item.Name);
            }

            //Skip
            var skipTwoProducts = productlist.Skip(2);
            Console.WriteLine("\n Skip 2 Products");
            foreach (var item in skipTwoProducts)
            {
                Console.WriteLine(item.Name);
            }
            //Sum
            var totalPrice = productlist.Sum(p=>p.Price);
            Console.WriteLine($"\nTotal Price of products {totalPrice}");

            //Count 
            var totalCount = productlist.Count();
            Console.WriteLine($"\nTotal Count of products {totalCount}");

            //ANy

            var hasCheapProduct = productlist.Any(x => x.Price < 100);
            Console.WriteLine($"\n Are there any cheap product? {hasCheapProduct}");

            //ALL 
            var allElctromics = productlist.All(p => p.Category == "Electronics");
            Console.WriteLine($"\n Are all product Electronics? {allElctromics}");

            //First

            var firstProduct = productlist.First();
            Console.WriteLine($"\nFirst Product {firstProduct.Name}");

            //Last

            var lastProduct = productlist.Last();
            Console.WriteLine($"\nLast Product {lastProduct.Name}");

            //OfType
            var mixedList = new List<object> { 1, "Hello", 2, "World" };
            var stringValues = mixedList.OfType<string>();
            Console.WriteLine("\nStrings in mixed list");
            foreach (var item in stringValues)
            {
                Console.WriteLine(item);
            }

            //ThenBy
            var sortedproducts = orderbyPrice.ThenBy(p => p.Category);
            Console.WriteLine("\nOrder by category");
            foreach (var item in sortedproducts)
            {
                Console.WriteLine($"{item.Category}-{item.Name}:{item.Price}");
            }


            //selectMany

            var allReviews = productReviews.SelectMany(x => x.Reviews);
            Console.WriteLine("\n All Product Reviews");
            foreach (var item in allReviews)
            {
                Console.WriteLine(item);
            }

            //TakeWhile
            var cheaProducts = productlist.TakeWhile(x=>x.Price>150);
            Console.WriteLine("\nCheap Products");
            foreach (var item in cheaProducts)
            {
                Console.WriteLine(item.Name);
            }
            //SIngle
            var singleProduct = productlist.Single(x => x.ProductId == 1);
            Console.WriteLine($"\n Single Product with id 1: {singleProduct.Name}");

            //inserct
            var electronics = new List<Product> { 
            new Product{ProductId=1,Name="Laptop",Price=1200,Category="Electronics"},
             new Product{ProductId=2,Name="Smartphone",Price=800,Category="Electronics"}
            };
            var commonproducts = productlist.Intersect(electronics,new ProductComparer());
            Console.WriteLine("\nCommon products Intersect");
            foreach (var item in commonproducts)
            {
                Console.WriteLine(item.Name);
            }

            //Except
            var furniture = new List<Product> {
            new Product{ProductId=3,Name="Desk",Price=300,Category="Furniture"},
             new Product{ProductId=4,Name="Chair",Price=150,Category="Furniture"}
            };
            var Exceptproducts = productlist.Except(furniture, new ProductComparer());
            Console.WriteLine("\n exceptproducts are :");
            foreach (var item in Exceptproducts)
            {
                Console.WriteLine(item.Name);
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        private const int ProductId = 1;
        private const string ProductName = "PS4";
        private const string ProductDescription = "This is a good gaming console";

        static void Main(string[] args)
        {
            var product = new Product(ProductId, ProductName, ProductDescription);
            Console.WriteLine($"{product.Name}: {product.Description}");
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_5
{
    internal class Program
    {
        class Product
        {
            public string Name;
            public int Price;
        }
        static void Main(string[] args)
        {
            Product product = new Product();

            product.Name = "감자";
            product.Price = 5000;
            Console.WriteLine(product.Name + " : " + product.Price + "원");
            Console.WriteLine();

            Product productA = new Product() { Name = "감  자", Price = 5000 };
            Product productB = new Product() { Name = "고구마", Price = 6000 };
            Product productC = new Product() { Name = "호  박", Price = 4000 };

            Console.WriteLine($"{productA.Name} : {productA.Price}원");
            Console.WriteLine($"{productB.Name} : {productB.Price}원");
            Console.WriteLine($"{productC.Name} : {productC.Price}원");
        }
    }
}

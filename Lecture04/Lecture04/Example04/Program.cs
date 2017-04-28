using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example04
{
    internal class Program
    {
        private static void Main(string[] args)     //foreach 進階
        {
            Random random = new Random();
            Product[] products = new Product[]
            {
                new Product(){ Name = "iPhone7", Price = 7000 },
                new Product(){ Name = "iPhone6", Price = 6000 },
                new Product(){ Name = "iPhone5", Price = 5000 },
                new Product(){ Name = "iPhone4", Price = 4000 },
                new Product(){ Name = "iPhone3", Price = 3000 }
            };
            Product[] ShoppingCart = new Product[5];

            for (int index = 0; index < products.Length; index++)
            {
                ShoppingCart[index] = products[random.Next(0, products.Length)];
            }
            foreach (Product xxx in ShoppingCart)
            {
                Console.WriteLine("{0}:{1}", xxx.Name, xxx.Price);
            }
        }
    }
}
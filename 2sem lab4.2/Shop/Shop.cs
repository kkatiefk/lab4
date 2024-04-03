using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;


namespace _2sem_lab4._2.Shop
{
    public class Shop
    {
        public string Name { get; set; }
        public List<Product> Products = new List<Product>();

        public void AddProduct(Product product)
        {
            Products.Add(product);
        }

        public void SortByType()
        {
            Console.WriteLine();
            Console.WriteLine("Water Products:");
            foreach (var product in Products)
            {
                if (product is Water)
                {
                    Console.WriteLine(product);

                }
            }
            Console.WriteLine();
            Console.WriteLine("Cereals Products:");
            foreach (var product in Products)
            {
                if (product is Cereals)
                {

                    Console.WriteLine(product);
                }
            }
            Console.WriteLine();
            Console.WriteLine("Sweets Products:");
            foreach (var product in Products)
            {
                if (product is Sweets)
                {
                    Console.WriteLine(product);
                }
            }
        }

        public void SortByPrice()
        {
            var sortedProducts = Products.OrderBy(p => p.Price);
            Console.WriteLine();
            Console.WriteLine("Products Sorted by Price:");
            foreach (var product in sortedProducts)
            {

                Console.WriteLine(product);
            }
        }

        public void ExpiryDateRange(string startExpiryDate, string endExpiryDate)
        {
            Console.WriteLine();
            Console.WriteLine($"Products with Expiry Date between {startExpiryDate} and {endExpiryDate}:");
            foreach (var product in Products)
            {
                if (string.Compare(product.ExpiryDate, startExpiryDate) >= 0 && string.Compare(product.ExpiryDate, endExpiryDate) <= 0)
                {
                    Console.WriteLine(product);
                }
            }
        }

        public void FindExpiredProducts(string todayDate)
        {
            Console.WriteLine();
            Console.WriteLine("Expired Products:");

            foreach (var product in Products)
            {
                if (string.Compare(product.ExpiryDate, todayDate) < 0)
                {
                    Console.WriteLine(product);
                }
            }
        }

        public void Manufactured2020()
        {
            Console.WriteLine();
            Console.WriteLine("Manufactured in January 2020:");
            foreach (var product in Products)
            {
                if (product.ManufactureDate.StartsWith("2020-01"))
                {
                    Console.WriteLine(product);
                }
            }
        }

        public void ShowAllProducts()
        {
            Console.WriteLine();
            Console.WriteLine("All Products:");
            foreach (var product in Products)
            {
                Console.WriteLine(product);
            }
        }

    }
}

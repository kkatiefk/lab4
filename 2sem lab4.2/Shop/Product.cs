using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2sem_lab4._2.Shop
{
    public class Product
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public string ExpiryDate { get; set; }
        public string ManufactureDate { get; set; }


        public override string ToString()
        {
            return $"Name: {Name}, Price: {Price}, Manufacture Date: {ManufactureDate}, Expiry Date: {ExpiryDate}";
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public override bool Equals(object? obj)
        {
            if (obj is Product product)
                return Name == product.Name && Price == product.Price && ExpiryDate == product.ExpiryDate && ManufactureDate == product.ManufactureDate;
            return false;
        }
    }
}

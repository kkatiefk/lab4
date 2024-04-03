using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2sem_lab4._2.Shop
{
    public class Sweets : Product
    {
        public string Sort { get; set; }
        public Sweets(string name, int price, string manufactureDate, string expiryDate, string sort)
        {
            Name = name;
            Price = price;
            ExpiryDate = expiryDate;
            Sort = sort;
            ManufactureDate = manufactureDate;
        }
        public override string ToString()
        {
            return $"Name: {Name}, Price: {Price}, Manufacture Date: {ManufactureDate}, Expiry Date: {ExpiryDate}, Sort: {Sort}";
        }
        public override bool Equals(object? obj)
        {
            if (obj is Sweets sweets)
                return Name == sweets.Name && Price == sweets.Price && ManufactureDate == sweets.ManufactureDate && ExpiryDate == sweets.ExpiryDate;
            return false;
        }
    }
}

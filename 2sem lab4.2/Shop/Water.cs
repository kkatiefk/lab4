using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2sem_lab4._2.Shop
{
    public class Water : Product
    {
        public string Kind { get; set; }

        public Water(string name, int price, string manufactureDate, string expiryDate, string kind)
        {
            Name = name;
            Price = price;
            ExpiryDate = expiryDate;
            Kind = kind;
            ManufactureDate = manufactureDate;
        }
        public override string ToString()
        {
            return $"Name: {Name}, Price: {Price}, Manufacture Date: {ManufactureDate}, Expiry Date: {ExpiryDate}, Kind: {Kind}";
        }

        public override bool Equals(object? obj)
        {
            if (obj is Water water)
                return Name == water.Name && Price == water.Price && ManufactureDate == water.ManufactureDate && ExpiryDate == water.ExpiryDate && Kind == water.Kind;
            return false;
        }
    }
}

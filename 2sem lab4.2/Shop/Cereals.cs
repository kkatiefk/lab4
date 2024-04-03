using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2sem_lab4._2.Shop
{
    public class Cereals : Product
    {
        public bool Packaged { get; set; }
        public Cereals(string name, int price, string manufactureDate, string expiryDate, bool packaged)
        {
            Name = name;
            Price = price;
            ExpiryDate = expiryDate;
            Packaged = packaged;
            ManufactureDate = manufactureDate;
        }
        public override string ToString()
        {
            return $"Name: {Name}, Price: {Price}, Manufacture Date: {ManufactureDate}, Expiry Date: {ExpiryDate}, Packaged: {Packaged}";
        }
        public override bool Equals(object? obj)
        {
            if (obj is Cereals cereals)
                return Name == cereals.Name && Price == cereals.Price && ManufactureDate == cereals.ManufactureDate && ExpiryDate == cereals.ExpiryDate && Packaged == cereals.Packaged;
            return false;
        }
    }
}

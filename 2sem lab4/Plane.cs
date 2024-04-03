using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Створити об'єкт класу Літак, використовуючи класи Крило, Шасі, Двигун. 
//Методи: літати, задавати маршрут, вивести на консоль маршрут.
namespace _2sem_lab4
{
    public class Plane
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public int Width { get; set; }
        public int Length { get; set; }
        public string Color { get; set; }
       
        public override string ToString()
        {
            return $"Name = {Name}, Type = {Type}, Width = {Width}, Length = {Length}, Color = {Color}";
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public override bool Equals(object? obj)
        {
            if (obj is Plane plane)
                return Name == plane.Name && Type == plane.Type && Width == plane.Width && Length == plane.Length
                    && Color == plane.Color;
            return false;
        }
        public void Fly()
        {
            Console.WriteLine("\nThe plane is taking off!");
        }
        public void Route(string route)
        {
            if (string.IsNullOrEmpty(route))
            {
                Console.WriteLine("We don't have route.");
            }
            else
            {
                Console.WriteLine("Route: " + route);

            }
        }
    }
      
    public class Wing : Plane
    {
        public string Shape { get; set; }
        public override string ToString()
        {
           return $"Name = {Name}, Type = {Type}, Width = {Width}, Length = {Length}, Color = {Color}, Shape = {Shape}";
        }
        public override bool Equals(object? obj)
        {
           if (obj is Wing wing)
           return Name == wing.Name && Type == wing.Type && Width == wing.Width && Length == wing.Length
                        && Color == wing.Color && Shape == wing.Shape;
           return false;
        }
    }
    public class Chassis : Plane
    {
        
        public bool IsPresent { get; set; }

        public override string ToString()
        {
                return $"Name = {Name}, Type = {Type}, Width = {Width}, Length = {Length}, Color = {Color}, Is present = {IsPresent}";
        }
        public override bool Equals(object? obj)
        {
                if (obj is Chassis chassis)
                    return Name == chassis.Name && Type == chassis.Type && Width == chassis.Width && Length == chassis.Length
                        && Color == chassis.Color && IsPresent == chassis.IsPresent;
                return false;
        }
    }
    public class Engine : Plane
    {
        public int HorsePower { get; set; }
        public string Model { get; set; }
        public override string ToString()
        {
                return $"Name = {Name}, Type = {Type}, Width = {Width}, Length = {Length}, Color = {Color}, Horse Power = {HorsePower}, Model = {Model}";
        }
        public override bool Equals(object? obj)
        {
                if (obj is Engine engine)
                    return Name == engine.Name && Type == engine.Type && Width == engine.Width && Length == engine.Length
                        && Color == engine.Color && HorsePower == engine.HorsePower && Model == engine.Model;
                return false;
        }
    }
}

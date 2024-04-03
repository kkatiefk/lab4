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
        public Wings Wings { get; set; }
        public Chassis Chassis { get; set; }
        public Engine Engine { get; set; }

        public Plane(string name, Wings wings, Chassis chassis, Engine engine)
        {
            Name = name;
            Wings = wings;
            Chassis = chassis;
            Engine = engine;
        }

        public override string ToString()
        {
            return $"Name = {Name}, Wings = {Wings}, Chassis = {Chassis}, Engine = {Engine}";
        }

        public override bool Equals(object? obj)
        {
            if (obj is Plane plane)
                return Name == plane.Name && Wings.Equals(plane.Wings) && Chassis.Equals(plane.Chassis) && Engine.Equals(plane.Engine);
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
                Console.WriteLine("We don't have a route.");
            }
            else
            {
                Console.WriteLine("Route: " + route);
            }
        }
    }

    public class Wings
    {
        public string Shape { get; set; }

        public override string ToString()
        {
            return $"Shape = {Shape}";
        }

        public override bool Equals(object? obj)
        {
            if (obj is Wings wing)
                return Shape == wing.Shape;
            return false;
        }
    }

    public class Chassis
    {
        public bool IsPresent { get; set; }

        public override string ToString()
        {
            return $"IsPresent = {IsPresent}";
        }

        public override bool Equals(object? obj)
        {
            if (obj is Chassis chassis)
                return IsPresent == chassis.IsPresent;
            return false;
        }
    }

    public class Engine
    {
        public int HorsePower { get; set; }
        public string Model { get; set; }

        public override string ToString()
        {
            return $"HorsePower = {HorsePower}, Model = {Model}";
        }

        public override bool Equals(object? obj)
        {
            if (obj is Engine engine)
                return HorsePower == engine.HorsePower && Model == engine.Model;
            return false;
        }
    }
}

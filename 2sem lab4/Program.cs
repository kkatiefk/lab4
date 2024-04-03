//Створити об'єкт класу Літак, використовуючи класи Крило, Шасі, Двигун. 
//Методи: літати, задавати маршрут, вивести на консоль маршрут.
using _2sem_lab4;

Plane plane = new Plane
{
    Name = "Boeing 777",
    Type = "For passengers",
    Width = 4,
    Length = 10,
    Color = "White"
};
Console.WriteLine("Plane: " + plane);

Wing wing = new Wing
{
    Name = "Long wings",
    Type = "For planes",
    Width = 2,
    Length = 15,
    Color = "White",
    Shape = "Oval"
};
Console.WriteLine("Wings: " + wing);

Chassis chassis = new Chassis
{
    Name = "Special",
    Type = "For planes",
    Width = 1,
    Length = 5,
    Color = "Grey",
    IsPresent = true
};
Console.WriteLine("Chassis: " + chassis);

Engine engine = new Engine
{
    Name = "GHZ7777",
    Type = "For planes",
    Width = 2,
    Length = 3,
    Color = "Black",
    Model = "WRJ1990",
    HorsePower = 5000
};
Console.WriteLine("Engine: " + engine);

plane.Fly();
Console.WriteLine();
plane.Route("Kyiv - New York");
Console.WriteLine($"\n{plane.Route}");
Console.ReadLine();
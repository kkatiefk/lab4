//Створити об'єкт класу Літак, використовуючи класи Крило, Шасі, Двигун. 
//Методи: літати, задавати маршрут, вивести на консоль маршрут.
using _2sem_lab4;

Wings wings = new Wings
{
    Shape = "Long wings"
};
Console.WriteLine("Wings: " + wings);

Chassis chassis = new Chassis
{
    IsPresent = true
};
Console.WriteLine("Chassis: " + chassis);

Engine engine = new Engine
{
    HorsePower = 5000,
    Model = "WRJ1990"
};
Console.WriteLine("Engine: " + engine);

Plane plane = new Plane("Boeing 777", wings, chassis, engine);
Console.WriteLine("Plane: " + plane);

plane.Fly();

Console.WriteLine();

plane.Route("Kyiv - New York");

Console.ReadKey();
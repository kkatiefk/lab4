//Продуктовий магазин. Визначити ієрархію товарів. 
//Відсортувати товари по типах та по вартості. 
//Знайти товари, термін придатності яких відповідає вказаному діапазону. 
//Знайти прострочені товари, та товари, виготовлені у січні 2020.
using _2sem_lab4._2.Shop;

Shop shop = new Shop();
shop.AddProduct(new Water("Morshinska", 19, "2021-02-01", "2023-01-01", "With gas"));
shop.AddProduct(new Water("Aqua", 15, "2023-01-05", "2024-05-01", "Sparkling"));
shop.AddProduct(new Cereals("Oats", 20, "2024-05-02", "2024-08-01", true));
shop.AddProduct(new Sweets("Chocolate", 30, "2020-01-01", "2024-04-05", "Dark"));

bool exit = false;
while (!exit)
{
    Console.WriteLine("1. All products");
    Console.WriteLine("2. Sort by type");
    Console.WriteLine("3. Sort by price");
    Console.WriteLine("4. Expired products");
    Console.WriteLine("5. Products manufactured in January 2020");
    Console.WriteLine("6. Expiry range");
    Console.WriteLine("7. Exit");

    Console.Write("Choose the number: ");
    string choice = Console.ReadLine();

    switch (choice)
    {
        case "1":
            shop.ShowAllProducts();
            break;
        case "2":
            shop.SortByType();
            break;
        case "3":
            shop.SortByPrice();
            break;
        case "4":
            string todayDate = "2024-04-03";
            shop.FindExpiredProducts(todayDate);
            break;
        case "5":
            shop.Manufactured2020();
            break;
        case "6":
            string startExpiryDate = "2024-04-01";
            string endExpiryDate = "2024-04-31";
            shop.ExpiryDateRange(startExpiryDate, endExpiryDate);
            break;
        case "7":
            exit = true;
            break;
        default:
            Console.WriteLine("Error");
            break;
    }

    if (!exit)
    {
        Console.WriteLine();
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
        Console.Clear();
    }
}
//shop.SortByType();

//shop.SortByPrice();

//string startExpiryDate = "2024-04-01";
//string endExpiryDate = "2024-04-31";
//shop.ExpiryDateRange(startExpiryDate, endExpiryDate);

//string todayDate = "2024-04-03";
//shop.FindExpiredProducts(todayDate);

//shop.Manufactured2020();

Console.ReadKey();
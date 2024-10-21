public class Program
{
    // Kahve menüsü oluşturur
    public static List<string> CreateCoffeeMenu()
    {
        List<string> coffeeNames = new List<string>(); // List oluşturuldu

        Console.Write($"Bir kahve çeşidi girin: "); // Kullanıcıdan girdi iste
        string coffee1 = Console.ReadLine();

        coffeeNames.Add(coffee1 ); // Girdiyi listeye ekle

        Console.Write($"Bir kahve çeşidi girin: "); // Kullanıcıdan girdi iste
        string coffee2 = Console.ReadLine();

        coffeeNames.Add(coffee2); // Girdiyi listeye ekle

        Console.Write($"Bir kahve çeşidi girin: "); // Kullanıcıdan girdi iste
        string coffee3 = Console.ReadLine();

        coffeeNames.Add(coffee3); // Girdiyi listeye ekle

        Console.Write($"Bir kahve çeşidi girin: "); // Kullanıcıdan girdi iste
        string coffee4 = Console.ReadLine();

        coffeeNames.Add(coffee4); // Girdiyi listeye ekle

        Console.Write($"Bir kahve çeşidi girin: "); // Kullanıcıdan girdi iste
        string coffee5 = Console.ReadLine();

        coffeeNames.Add(coffee5); // Girdiyi listeye ekle

        return coffeeNames; // Listeyi döndür
    }

    // Kahve menüsünü ekrana yazdırır
    public static void DisplayCoffeeMenu(List<string> menu)
    {
        foreach(string coffee in menu)
        {
            Console.WriteLine($"===>>> {coffee}");
        }

    }

    public static void Main(string[] args)
    {

        List<string> menuCoffee = CreateCoffeeMenu(); // List oluşturuldu

        DisplayCoffeeMenu(menuCoffee); // List okundu



    }
}
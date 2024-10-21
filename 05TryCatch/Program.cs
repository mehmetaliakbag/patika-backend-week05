public class Program
{
    // Girilen değerin 2. kuvvetini hesaplayan metot
    public static void CalculateSquare()
    {

        try // Hata yönetimi
        {
            Console.Write("Bir sayı girin: ");
            string input = Console.ReadLine();
            double number = double.Parse(input);
            double square = Math.Pow(number, 2);
            Console.WriteLine($"{number} karesi => {square}");
        }
        catch(FormatException) // Exception fırlatırsa yakala
        {
            Console.WriteLine("Geçersiz giriş! Lütfen bir sayı giriniz");
        }
        finally // Exception fırlatsa da fırlatmasa da bunu yazdır
        {
            Console.WriteLine("İşlem sonlandırıldı.");
        }

    }

    public static void Main(string[] args)
    {

        CalculateSquare(); // Başlangıç


    }

}
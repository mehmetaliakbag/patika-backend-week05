public class Program
{
    // Davetli listesi oluştur
    public static List<string> CreateVisitorList()
    {
        List<string> visitorList = new List<string>
        {"Bülent Ersoy",
         "Ajda Pekkan",
         "Ebru Gündeş",
         "Hadise",
         "Hande Yener",
         "Tarkan",
         "Funda Arar",
         "Demet Akalın"};

        return visitorList;

    }

    // Davetlilerin ismini ekrana yazdırır
    public static void DisplayVisitors(List<string> visitors) 
    {
        foreach (var visitor in visitors)
        {
            Console.WriteLine(visitor);
        }
    }

    public static void Main(string[] args)

    {

        List<string> visitors = CreateVisitorList(); // Davetli listesi oluşturuldu

        DisplayVisitors(visitors); // Davetli listesi yazdırıldı





    }
}
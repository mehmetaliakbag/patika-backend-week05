using System.Diagnostics.Metrics;

public class Program
{
    // Yeni film ekler
    public static List<(string name, double score)> AddMovie(List<(string name, double score)> movies) 
    {
        Console.Write("Eklemek istediğiniz filmin adı: ");
        string name = Console.ReadLine();

        Console.Write($"Eklemek istediğiniz {name} adlı filmin IMDB puanı: ");
        double score = double.Parse( Console.ReadLine() );

        movies.Add((name, score));

        return movies;
    }

    //Bütün filmleri listeler
    public static void ListAllMovie(List<(string name, double score)> movies)
    {
        foreach (var movie in movies)
            Console.WriteLine(movie);
    }

    //Imdb Puanı 4 ile 9 arası olan filmleri listeler
    public static void ListBetweenFourAndNine(List<(string name, double score)> movies)
    {
        foreach(var movie in movies)
        {
            if(movie.score >= 4 && movie.score <= 9)
                Console.WriteLine(movie);
        }
    }

    //İlk harfi 'A' olan filmleri listeler
    public static void firstLetterA(List<(string name, double score)> movies)
    {
        foreach( var movie in movies)
        {
            if(movie.name.StartsWith('A') || movie.name.StartsWith('a'))
            {
                Console.WriteLine(movie);
            }
        }
    }

    // Programı başlatan metot
    public static void StartProgram()
    {
        List<(string Name, double score)> movies = new List<(string name, double score)>();
       
        bool isContinue = false;

        while(!isContinue)
        {
            AddMovie(movies);

            Console.Write($"Başka bir film eklemek isterseniz \"Evet\" yazın: ");
            string answer = Console.ReadLine();

            if (answer.ToLower() != "evet")
            {
                isContinue = true;
            }
        }

        ListAllMovie(movies);

        Console.WriteLine("\r\n**************\r\n");

        firstLetterA(movies);

        Console.ReadKey();

    }


    public static void Main(string[] args)
    {

        StartProgram(); // Başla







    }

}
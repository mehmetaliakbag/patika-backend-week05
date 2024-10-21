namespace _01Array
{
    public class Program
    {

        // 10 indeksli random değer tutan int tipinde bir array oluşturur
        public static int[] CreateNumberArray()
        {
            int[] numberArray = new int[10];  // Indeks sayısı belirlenir

            for(int i = 0; i < numberArray.Length; i++)  // Indexlere değer atamak için döngüye girer
            {
                Random random = new Random();
                int randomNumer = random.Next(1, 100);  // Random 1 - 100 arası sayı üretir
                numberArray[i] = randomNumer;  // Belirtilen indekslere değerleri atar
            }

            return numberArray;
        }

        // Girilen arrayin indeksini bir arttırır, kulanıcıdan gelen veriyi o indekse atar
        public static int[] IncreaseRoomCount(int[] currentArray)
        {
            Console.Write("Bir sayı girin: ");  // Kullanıcıdan veri iste
            int newElement = int.Parse(Console.ReadLine());

            int[] expandedArray = new int[currentArray.Length + 1];  // Indexi 1 artan yeni array oluştur

            for(int i = 0; i < currentArray.Length;i++)  // Eski arrayi yeni arraye klonla
            {
                expandedArray[i] = currentArray[i];
            }

            expandedArray[expandedArray.Length - 1] = newElement; // Son indexe kullanıcı verisini gir

            return expandedArray;  // Diziyi döndür

        }

        //Girilen arrayi okur
        public static void DisplayNumbers(int[] numbers)
        {
            Console.WriteLine("Dizi okunmaya başladı\r\n");
            foreach(int number in numbers)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine("\r\nDizi okunması bitti\r\n");
        }

        public static void DisplayArrayInDescendingOrder(int[] array)
        {
            Array.Sort(array);
            Array.Reverse(array);
            Console.WriteLine(string.Join(",", array)); // Join() bir arraydeki elemanları belirtilen bir ayırıcı ile birleştirirek tek bir eleman oluşturur
        }

        public static void Main(string[] args)
        { 

            int[] myArray = CreateNumberArray(); // Yeni bir dizi oluşturuldu

            DisplayNumbers(myArray); // Dizi okundu

            int[] expendedMyArray = IncreaseRoomCount(myArray); // Yeni bir dizi oluştu, eski dizi + 1 şekilde klonlandı, kullanıcı değeri son indexe girildi

            DisplayNumbers(expendedMyArray); // Yeni dizi okundu


            DisplayArrayInDescendingOrder(myArray);

        }




    }
}
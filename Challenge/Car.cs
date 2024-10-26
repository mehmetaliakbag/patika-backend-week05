using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge
{

    public class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        private int _numberOfDoors;

        public int NumberOfDoors
        {
            get
            {
                return _numberOfDoors; // Doğru değişken döndürülmeli
            }

            set
            {
                try
                {
                    // İlk değer atamasını burada yapıyoruz.
                    if (value != 2 && value != 4)
                    {
                        throw new FormatException("Geçersiz kapı sayısı!"); // Hata fırlat
                    }

                    _numberOfDoors = value; // Geçerli değeri atama
                }
                catch (FormatException)
                {
                    Console.WriteLine("Lütfen 2 veya 4 kapılı bir araba girin:");
                    // Kullanıcıdan yeni bir değer iste
                    if (int.TryParse(Console.ReadLine(), out int newValue))
                    {
                        // Yeni değeri tekrar ayarla
                        NumberOfDoors = newValue; // Burada setter'ı tekrar çağırıyoruz
                    }
                    else
                    {
                        Console.WriteLine("Lütfen geçerli bir sayı girin.");
                    }
                }
            }
        }
        public string SerialNumber { get; set; }
        public DateTime DateTime { get; private set; }


        public Car()
        {
            DateTime = DateTime.Now;
        }



    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Challenge
{
    public class Product
    {
        private List<Car> listCars = new List<Car>();

        public void StartMyProgrammm()
        {

            bool isValid = false;

            while (!isValid)
            {
                Console.Write("Do you want to produce a car?" +
                              "\r\nPress 'y' for yes" +
                              "\r\nPress 'n' for no" +
                              "\r\nAnswer: ");

                string chose = Console.ReadLine();


                switch (chose.ToLower())
                {
                    case "y":
                        bool isContinue = false;
                        while (!isContinue)
                        {
                            Car car = CreateCarFromInput();
                            listCars.Add(car);

                            Console.Write("Do you want to produce a car?" +
                                          "\r\nPress 'y' for yes" +
                                          "\r\nPress 'anyone button' for no" +
                                          "\r\nAnswer: ");


                            string answer = Console.ReadLine();

                            if (answer.ToLower() == "y")
                                Console.WriteLine("Yeni arabanız hazırlanıyor");
                            else
                            {
                                DisplayCarSerialNumbersAndBrands();
                                isContinue = true;
                            }

                        }
                        break;

                    case "n":
                        Console.WriteLine("Çıkış yapılıyor");
                        isValid = true;
                        break;

                    default:
                        Console.WriteLine("Hatalı işlem, tekrar deneyin");
                        break;
                }
            }

            Console.WriteLine("Çıkış yapıldı");
        }

        public Car CreateCarFromInput()
        {
            Car car = new Car();

            Console.Write("Enter Brand: ");
            car.Brand = Console.ReadLine();

            Console.Write("Enter Model: ");
            car.Model = Console.ReadLine();

            Console.Write("Enter Color: ");
            car.Color = Console.ReadLine();

            Console.Write("Number of Doors ");
            car.NumberOfDoors = int.Parse(Console.ReadLine());

            Console.Write("Enter Serial Number: ");
            car.SerialNumber = Console.ReadLine();
            return car;
        }

        public void AddCarList(Car car)
        {
            listCars.Add(car);
        }

        public void DisplayCarSerialNumbersAndBrands()
        {
            foreach (Car element in listCars)
            {
                Console.WriteLine($"{element.Brand} ===> {element.SerialNumber}");
            }
        }



    }
}

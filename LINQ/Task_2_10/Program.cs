using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2_9
{
    public class Car
    {
        public string Manufacturer { get; set; }
        public string CountryCode { get; set; }

        public Car(string manufacturer, string countryCode)
        {
            Manufacturer = manufacturer;
            CountryCode = countryCode;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Подготовка данных
            var cars = new List<Car>()
            {
               new Car("Suzuki", "JP"),
               new Car("Toyota", "JP"),
               new Car("Opel", "DE"),
               new Car("Kamaz", "RUS"),
               new Car("Lada", "RUS"),
               new Car("Lada", "RUS"),
               new Car("Honda", "JP"),
            };

            Console.WriteLine("Пропустим все японские машины в начале списка");
            var notJapanCars = cars.SkipWhile(car => car.CountryCode == "JP").TakeWhile(car => car.CountryCode != "JP");

            foreach (var notJapanCar in notJapanCars)
                Console.WriteLine(notJapanCar.Manufacturer);

            //Console.WriteLine();

            //Console.WriteLine("Теперь выберем только японские машины из начала списка");
            //var japanCars = cars.TakeWhile(car => car.CountryCode == "JP");

            //foreach (var japanCar in japanCars)
            //    Console.WriteLine(japanCar.Manufacturer);

            Console.ReadKey();
        }
    }
}

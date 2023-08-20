using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Добавим Россию с её городами
            var russianCities = new List<City>();
            russianCities.Add(new City("Москва", 11900000));
            russianCities.Add(new City("Санкт-Петербург", 4991000));
            russianCities.Add(new City("Волгоград", 1099000));
            russianCities.Add(new City("Казань", 1169000));
            russianCities.Add(new City("Севастополь", 449138));

            //var bigCities = from p in russianCities
            //                where p.Population > 1000000
            //                orderby p.Population descending
            //                select p;

            //var bigCities = russianCities.Where(p => p.Population > 1000000).OrderByDescending(p => p.Population);

            var bigCities = russianCities.Where(p => p.Name.Length <= 10).OrderBy(p => p.Name.Length).ThenBy(p => p.Name);

            foreach (var bigCity in bigCities)
                Console.WriteLine($"{bigCity.Name} - {bigCity.Population}");

            Console.ReadKey();
        }
    }
}

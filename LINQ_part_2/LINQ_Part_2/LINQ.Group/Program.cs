namespace LINQ.Group
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var cars = new List<Car>()
            {
               new Car("Suzuki", "JP"),
               new Car("Toyota", "JP"),
               new Car("Opel", "DE"),
               new Car("Kamaz", "RUS"),
               new Car("Lada", "RUS"),
               new Car("Honda", "JP"),
            };

            var carsByCountry = from car in cars
                                group car by car.CountryCode;
            //var carsByCountry = cars.GroupBy(c => c.CountryCode)
            //                        .Select(group => new
            //                        {
            //                            Name = group.Key,
            //                            Amount = group.Count()
            //                        }
            //                        );
            //var carsByCountry2 = from car in cars
            //                     group car by car.CountryCode into grouping
            //                     select new
            //                     {
            //                         Name = grouping.Key,
            //                         Count = grouping.Count(),
            //                         Cars = from p in grouping select p
            //                    };
            var carsByCountry2 = cars.GroupBy(c => c.CountryCode)
                                    .Select(g => new
                                    {
                                        Name = g.Key,
                                        Count = g.Count(),
                                        Cars = g.Select(c => c)
                                    }
                                    );

            foreach (var group in carsByCountry2)
            {
                Console.WriteLine($"{group.Name} {group.Count}");

                foreach (var car in group.Cars)
                {
                    Console.WriteLine(car.Manufacturer);
                }
            }

            foreach (var grouping in carsByCountry)
            {
                Console.WriteLine(grouping.Key + ":");

                // внутри каждой группы пробежимся по элементам
                foreach (var car in grouping)
                    Console.WriteLine(car.Manufacturer);

                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
namespace LINQ.Join
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Список моделей
            var cars = new List<Car>()
            {
               new Car() { Model  = "SX4", Manufacturer = "Suzuki"},
               new Car() { Model  = "Grand Vitara", Manufacturer = "Suzuki"},
               new Car() { Model  = "Jimny", Manufacturer = "Suzuki"},
               new Car() { Model  = "Land Cruiser Prado", Manufacturer = "Toyota"},
               new Car() { Model  = "Camry", Manufacturer = "Toyota"},
               new Car() { Model  = "Polo", Manufacturer = "Volkswagen"},
               new Car() { Model  = "Passat", Manufacturer = "Volkswagen"},
            };

            // Список автопроизводителей
            var manufacturers = new List<Manufacturer>()
            {
               new Manufacturer() { Country = "Japan", Name = "Suzuki" },
               new Manufacturer() { Country = "Japan", Name = "Toyota" },
               new Manufacturer() { Country = "Germany", Name = "Volkswagen" },
            };
            var result = from car in cars
                         join m in manufacturers on car.Manufacturer equals m.Name
                         select new
                         {
                             Name = car.Model,
                             Manufacturer = m.Name,
                             Country = m.Country
                         };
            //var result2 = cars.Join(manufacturers, // передаем в качестве параметра вторую коллекцию
            //               car => car.Manufacturer, // указываем общее свойство для первой коллекции
            //               m => m.Name, // указываем общее свойство для второй коллекции
            //               (car, m) =>
            //                   new // проекция в новый тип
            //                   {
            //                       Name = car.Model,
            //                       Manufacturer = m.Name,
            //                       Country = m.Country
            //                   });
            foreach (var item in result)
                Console.WriteLine($"{item.Name} - {item.Manufacturer} ({item.Country})");
            Console.ReadKey();
        }
    }
}
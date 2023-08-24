namespace LINQ_Part_2.Tasks_2_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //15.2.1
            //Console.WriteLine(Fact(10));

            //15.2.2
            //var contacts = new List<Contact>()
            //{
            //   new Contact() { Name = "Андрей", Phone = 79994500508 },
            //   new Contact() { Name = "Сергей", Phone = 799990455 },
            //   new Contact() { Name = "Иван", Phone = 79999675334 },
            //   new Contact() { Name = "Игорь", Phone = 8884994 },
            //   new Contact() { Name = "Анна", Phone = 665565656 },
            //   new Contact() { Name = "Василий", Phone = 3434 }
            //};
            //Console.WriteLine(contacts.Count(s => s.Phone.ToString().StartsWith("7") && s.Phone.ToString().Length == 11));
            //var invalidContacts =
            //   (from contact in contacts // пробегаемся по контактам
            //    let phoneString = contact.Phone.ToString() // сохраняем в промежуточную переменную строку номера телефона
            //    where !phoneString.StartsWith('7') || phoneString.Length != 11 // выполняем выборку по условиям
            //    select contact) // добавляем объект в выборку
            //   .Count(); // считаем количество объектов в выборке

            //15.2.3
            //var nums = new[] { 1, 2, 3, 5, 7, 8, 11 };
            //Console.WriteLine(Average(nums));

            //15.2.8
            var nums = new List<int>();
            int n;

            Console.WriteLine("Введите число:");
            while (true)
            {
                if (Int32.TryParse(Console.ReadLine(), out n))
                {
                    nums.Add(n);
                    Console.WriteLine($"Количество чисел: {nums.Count} " +
                                      $"Сумма: {nums.Sum()} " +
                                      $"Максимум: {nums.Max()} " +
                                      $"Минимум: {nums.Min()} " +
                                      $"Среднее: {nums.Average()}");
                }
                else
                    Console.WriteLine("Введите число!");
            }
        }
        //15.2.1
        static long Fact(int n)
        {
            var nums = new List<int>();
            for(int i = 1; i <= n; i++ )
                nums.Add(i);

            return nums.Aggregate((x,y) => x * y);
        }
        //15.2.3
        static double Average(int[] numbers)
        {
            return numbers.Sum() / (double)numbers.Length;
        }
    }
}
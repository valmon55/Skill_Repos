namespace LINQ_Part_2.Tasks_1_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //15.1.4
            //Console.WriteLine("Введите 1-ю строку: ");
            //var str1 = Console.ReadLine();

            //Console.WriteLine("Введите 2-ю строку: ");
            //var str2 = Console.ReadLine();

            //Console.WriteLine("Обие буквы:");
            //Console.WriteLine(CommonLetters(str1,str2));

            //15.1.5
            //var softwareManufacturers = new List<string>()
            //{
            //   "Microsoft", "Apple", "Oracle"
            //};

            //            var hardwareManufacturers = new List<string>()
            //{
            //   "Apple", "Samsung", "Intel"
            //};

            //var itCompanies = softwareManufacturers.Union(hardwareManufacturers);
            //var itCompanies1 = hardwareManufacturers.Union(softwareManufacturers);

            //15.1.6
            Console.WriteLine("Введите строку: ");
            var str1 = Console.ReadLine();
            if (String.IsNullOrEmpty(str1))
            { 
                Console.WriteLine("Пустая строка!");
                return;
            }

            var noPunct = " .,;:?!";

            Console.WriteLine();
            Console.WriteLine("Текст без знаков препинания: ");

            Console.WriteLine(str1.Except(noPunct).ToArray());
        }
        //15.1.4
        static int CommonLetters(string s1, string s2)
        {
            var c = s1.Intersect(s2).Count();
            return c;
        }
    }
}
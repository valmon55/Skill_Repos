namespace CS_Basic.Module_5_Task_3_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var some_name = "Jane";
            var age = 23;

            Console.WriteLine("Вам {0} {1}  лет.",some_name,age);

            GetName(ref some_name);
            ChangeAge(age);
            Console.WriteLine("Вам {0} {1}  лет.", some_name, age);
        }
        static void GetName(ref string name)
        {
            Console.WriteLine("Введите имя");
            name = Console.ReadLine();

        }
        static void ChangeAge(int age)
        { 
            age = Convert.ToInt32(Console.ReadLine());
        }
    }
}
namespace Task_4_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            (string Name, string LastName, string Login, int LoginLen, bool HasPet, int Age, string[] Colors) User;

            for (int k = 0; k < 3; k++)
            {
                Console.WriteLine("Введите имя: ");
                User.Name = Console.ReadLine();
                Console.WriteLine("Введите фамилию: ");
                User.LastName = Console.ReadLine();
                Console.WriteLine("Введите логин: ");
                User.Login = Console.ReadLine();

                User.LoginLen = User.Login.Length;
                Console.WriteLine("У вас есть животные? (Да или Нет) ");
                if (Console.ReadLine() == "Да")
                    User.HasPet = true;
                else
                    User.HasPet = false;

                Console.WriteLine("Укажите возраст: ");
                User.Age = Convert.ToInt16(Console.ReadLine());

                Console.WriteLine("Укажите ваши 3 любимых цвета: ");
                User.Colors = new string[3];
                for (int i = 0; i < User.Colors.Length; i++)
                    User.Colors[i] = Console.ReadLine();
            }
        }
    }
}
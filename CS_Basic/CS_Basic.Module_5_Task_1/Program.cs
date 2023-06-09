namespace CS_Basic.Module_5_Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            (string? Name, string?[] Dishes) User;
            Console.WriteLine("Ваше имя?");
            User.Name = Console.ReadLine();
            User.Dishes = new string[5];
            for(int i = 0; i < User.Dishes.Length; i++)
            {
                Console.WriteLine("Ваше любимое блюдо?");
                User.Dishes[i] = Console.ReadLine();
            }
        }
    }
}
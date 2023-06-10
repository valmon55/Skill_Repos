namespace CS_Basic.Module_5_Task_1_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string?[] favcolor = new string[3];
            for (int i = 0; i < favcolor.Length; i++)
            {
                Console.WriteLine("Введите ваш цвет #" + i.ToString() + " ");
                favcolor[i] = ShowColor();
            }

            for (int i = 0; i < favcolor.Length; i++)
            {
                Console.WriteLine("Ваш цвет #" + i.ToString() + " " + favcolor[i]);
            }
            
        }
        static string? ShowColor()
        {
            Console.Write("Введите ваш цвет ");
            return Console.ReadLine();
        }
    }
}
namespace CS_Basic.Module_5_Task_5_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Factorial(20));
            //Task 5.5.8
            Console.WriteLine(PowerUp(2,4));
        }
        static decimal Factorial(int x)
        {
            if (x == 0)
            {
                return 1;
            }
            else
            {
                return x * Factorial(x - 1);
            }
        }
        /// <summary>
        /// Task 5.5.8
        /// </summary>
        /// <param name="N"></param>
        /// <param name="pow"></param>
        /// <returns></returns>
        private static decimal PowerUp(int N, byte pow)
        {
            if (pow == 0)
            { 
                return 1; 
            }
            { 
               return N * PowerUp(N, (byte)(pow - 1));
            }
            
        }
    }
}
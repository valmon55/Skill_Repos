namespace CS_Basic.Module_13_Tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text;
            using (StreamReader sr = new StreamReader(@"D:\Temp\module13_task_1_6.txt"))
            {
                text = sr.ReadToEnd();
                Console.WriteLine(text);
            }
            Console.ReadLine();
        }

        /// <summary>
        /// Task 13.1.6
        /// </summary>
        /// <param name="ints"></param>
        /// <returns></returns>
        static int CountWords(string text)
        {
            return 0;
        }

        static bool IsSorted(int[] ints)
        {
            if(ints.Length == 0) 
                return false;
            //int i = ints[0];
            for(int i = 1; i < ints.Length; i++) 
            {
                if (ints[i] <= ints[i-1])
                    return false;
            }
            return true;
        }
    }
}
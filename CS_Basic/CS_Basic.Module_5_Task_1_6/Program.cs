namespace CS_Basic.Module_5_Task_1_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static int[] GetArrayFromConsole()
            {
                var result = new int[5];

                for (int i = 0; i < result.Length; i++)
                {
                    Console.WriteLine("Введите элемент массива номер {0}", i + 1);
                    result[i] = int.Parse(Console.ReadLine());
                }

                Sort(result);

                for (int i = 0; i < result.Length; i++)
                {
                    Console.WriteLine("Элемент массива номер {0} = {1}", i + 1, result[i]);
                }

                return result;
            }

            Sort(GetArrayFromConsole());
        }
        static void Sort(int[] array) 
        { 
            if(array.Length == 0) return;

            for (int k = 0; k < array.Length; k++)
            {
                int t = array[0];
                for (int i = 1; i < array.Length; i++)
                {
                    if (t > array[i])
                    {
                        array[i - 1] = array[i];
                        array[i] = t;
                    }
                }
            }
        }
    }
}
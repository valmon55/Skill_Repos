namespace CS_Basic.Module_5_Task_2_8
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
              
                return result;
            }
            var array = GetArrayFromConsole();
            array = SortArray(array);
            //Sort(GetArrayFromConsole());
        }
        static int[] SortArray(int[] array)
        {
            if (array.Length == 0) return array;

            int t = array[0];
            for (int k = 0; k < array.Length; k++)
            {
                for (int i = k + 1; i < array.Length; i++)
                {
                    if (array[k] > array[i])
                    {
                        t = array[k];
                        array[k] = array[i];
                        array[i] = t;
                    }
                }
            }
            return array;
        }
    }
}
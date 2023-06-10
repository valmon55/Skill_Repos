namespace CS_Basic.Module_5_Task_2_17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static int[] GetArrayFromConsole(int num = 5) //5.2.14
            {
                var result = new int[num];

                for (int i = 0; i < result.Length; i++)
                {
                    Console.WriteLine("Введите элемент массива номер {0}", i + 1);
                    result[i] = int.Parse(Console.ReadLine());
                }

                return result;
            }
            var array = GetArrayFromConsole(10);
            ShowArray(array,true);
            //var sortedarray = SortArray(array);
            //Sort(GetArrayFromConsole());
        }
        static void ShowArray(int[] array, bool is_sorted = false)
        {
            var temp = array;
            if (is_sorted)
                temp = SortArray(array);
            foreach(int k in temp)
            {
                Console.WriteLine(k);
            }

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
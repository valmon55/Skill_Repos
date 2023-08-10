using BenchmarkDotNet.Running;
using System.Diagnostics;

namespace CS_Basic.Module_12_Tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Оценка времени выполнения Медиана
            Estimate(20);
            //var summary = BenchmarkRunner.Run<Testing>();
            Console.ReadKey();
        }
        /// <summary>
        /// StopWatch
        /// </summary>
        /// <param name="n"></param>
        static void CreateMatrix(int n)
        {
            var matrix = new int[n][];

            for (int i = 0; i < n; i++)
            {
                matrix[i] = new int[n];
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix[i][j] = i + j;
                }
            }
        }

        static void Estimate(int n)
        {
            var timer = new Stopwatch();
            timer.Start();

            for (int i = 0; i < n; i++)
            {
                timer.Restart();

                CreateMatrix(10000);

                timer.Stop();
                Console.WriteLine(timer.ElapsedMilliseconds);
            }
        }
        //12.3.1
        static int BinarySearch(int value, int[] array, int left, int right)
        {
            while (left <= right)
            {
                var middle = (left + right) / 2;

                var midElement = array[middle];

                if (midElement == value)
                {
                    return middle;
                }
                else if (value < midElement)
                {
                    right = middle - 1;
                }
                else
                {
                    left = middle + 1;
                }
            }

            return -1;
        }
        static int BinarySearchRecursive(int value, int[] array, int left, int right)
        {

            var middle = (left + right) / 2;

            var midElement = array[middle];

            if (midElement == value)
            {
                return middle;
            }
            else if (left < right)
            {
                if (value < midElement)
                {
                    return BinarySearch(value, array, left, middle - 1);
                }
                else
                {
                    return BinarySearch(value, array, middle + 1, right);
                }
            }
            else
            {
                return -1;
            }
        }
        //12.3.3
        static int GetIndex(int[] array, int element)
        {
            int index;
            for (index = 0; index < array.Length; index++)
            {
                if (array[index] > element)
                    return index;
            }

            return index;
        }
    }
}
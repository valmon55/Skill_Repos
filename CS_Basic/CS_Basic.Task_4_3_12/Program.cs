namespace CS_Basic.Task_4_3_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task 4.3.13");
            var arr = new int[] { 5, 6, 9, 1, 2, 3, 4 };
            for (int i=0; i < arr.Length; i++)
                Console.Write(arr[i].ToString() + " ");

            Console.WriteLine();

            //int idx = 0;
            int v;
            for( int k=0;k<arr.Length;k++)
                for(int i=k+1; i < arr.Length; i++)
                    if (arr[i] < arr[k])
                    {
                        v = arr[k];
                        arr[k] = arr[i];
                        arr[i] = v;
                    }

            for (int i = 0; i < arr.Length; i++)
                Console.Write(arr[i].ToString() + " ");
            Console.WriteLine();

            Console.WriteLine("Task 4.3.13");
            //task 4.3.13
            int s =arr[0];
            for (int i = 1; i < arr.Length; i++)
                s+=arr[i];

            Console.Write("Summ = " + s.ToString());

            Console.WriteLine();

            Console.WriteLine("Task 4.3.14");
            int[][] array = new int[3][];
            array[0] = new int[2] { 1, 2 };
            array[1] = new int[3] { 1, 2, 3 };
            array[2] = new int[5] { 1, 2, 3, 4, 5 };

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                    Console.Write(array[i][j]);
                Console.WriteLine();
            }
            Console.WriteLine();

            Console.WriteLine("Task 4.3.15");
            int[] ar = { -1,0,2,3,-10,-8,9};
            int c = 0;
            for (int i = 0; i < ar.Length; i++)
                if (ar[i] >= 0)
                    c++;
            Console.WriteLine(c);

            Console.WriteLine("Task 4.3.16");
            c = 0;
            int[,] ar2 = { { -5, 6, 9, 1, 2, -3 }, { -8, 8, 1, 1, 2, -3 } };
            for (int i = 0; i <= ar2.GetUpperBound(0); i++)
            {
                for (int j = 0; j < ar2.GetUpperBound(1); j++)
                    if (ar2[i,j] >= 0)
                        c++;

                //Console.WriteLine(c);
            }
            Console.WriteLine(c);

            Console.WriteLine("Task 4.3.17");
            int[,] ar3 = { { -5, 6, 9, 1, 2, -3 }, { -8, 8, 1, 1, 2, -3 } };

            for(int d = 0; d <= ar3.GetUpperBound(0); d++)
            for (int k = 0; k <= ar3.GetUpperBound(1); k++)
                for (int i = k + 1; i <= ar3.GetUpperBound(1); i++)
                    if (ar3[d,i] < ar3[d,k])
                    {
                        v = ar3[d,k];
                        ar3[d,k] = ar3[d,i];
                        ar3[d,i] = v;
                    }

            for (int i = 0; i <= ar3.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= ar3.GetUpperBound(1); j++)
                    Console.Write(ar3[i,j]);
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
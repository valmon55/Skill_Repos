namespace CS_Basic.Task_4_3_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
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
            //task 4.3.13
            int s=arr[0];
            for (int i = 1; i < arr.Length; i++)
                s+=arr[i];

            Console.Write("Summ = " + s.ToString());

        }
    }
}
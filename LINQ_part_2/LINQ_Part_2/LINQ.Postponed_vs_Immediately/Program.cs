namespace LINQ.Postponed_vs_Immediately
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var nums = new List<int>() { 1, 2, 3, 4 };
            var num_check = from n in nums
                            where (n < 3)
                            select n;
            var num_count = (from n in nums
                             where (n < 3)
                             select n).ToArray();
            nums.Add(-1);
            Console.WriteLine("num_check:");
            foreach (var s in num_check)
                Console.WriteLine(s);

            Console.WriteLine("num_count:");
            foreach (var s in num_count)
                Console.WriteLine(s);

            Console.ReadKey();
        }
    }
}
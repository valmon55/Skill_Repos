using System;

class MainClass
{
    public static void Main(string[] args)
    {

        var arr = new int[] { 1, 2, 3 };
        BigDataOperation(arr);

        Console.WriteLine(arr[0]);

    }

    static void BigDataOperation(in int[] arr)
    {
        arr[0] = 4;
    }
    int SumNumbers(out int num1, ref in int num2, int num3 = num1 + num2, int num4) 
        =>

}

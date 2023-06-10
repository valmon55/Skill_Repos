using System;
using System.Reflection.Metadata.Ecma335;

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
    ///
    /// 5.3.11 ответ:
    ///
    //int SumNumbers(ref int num1, in int num2, out int num3, int num4)
    //{ num3 = num1+ num2;
    //    return num3 * num4; }

}

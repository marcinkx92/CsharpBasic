using System;

public class ArrayToFunction
{
    // simple examples passing arrays to functions

    private static void ArrayPrint(int[,] arr)
    {
        Console.WriteLine("ArrayPrint()");
        for (int i = 0; i < arr.Rank; i++)
        {             // Array.Rank -> ilość "wymiarów" (wierszy)
            for (int j = 0; j < arr.GetLength(i); j++)  // Array.GetLength(i) -> ilość elementów w wierszu i
            {
                Console.Write(arr[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    private static void FindMinimum(int[] arr)
    {
        Console.WriteLine("\nFindMinimum()");
        Array.Sort(arr);
        Console.WriteLine("Minimum value of arr: " + arr[0]);
    }

    public static void Test()
    {
        int[,] a = {
               {1,2,3},
               {4,5,6}
           };
        ArrayPrint(a);
        FindMinimum(new int[] { 10, 20, 3, 5, 1, 6, 13 });
    }
}

/*  ***NOTES***
    - 
    -
 */

//Class runner - class name must be the same as filename!
public class PassingArrayToFunction : IBasic
{
    public void Test()
    {
        ArrayToFunction.Test();
    }
}
using System;

public class ArrayClass
{
    private static int[] ArraySort(int[] arr)
    {
        Array.Sort(arr); // sortowanie tablicy podanej jako parametr - nie tworzymy nowego obiektu !!!
        return arr;
    }

    private static void ArrayPrint(int[] arr)
    {
        Console.Write(">ArrayPrint():[");
        foreach (int p in arr) Console.Write(p + ",");
        Console.Write("]");
    }

    private static void ArrayCopy()
    {
        Console.WriteLine(" >ArrayCopy()");
        int[] a = new int[] { 5, 4, 3 };
        int[] b = new int[a.Length]; //empty array of the same length as a
        a.CopyTo(b, 0);
        Console.WriteLine("b: " + string.Join(",", b));
        b[0] = 1000; // kopia i oryginał odnoszą się do różnych obiektów
        Console.WriteLine("a: " + string.Join(",", a));
    }

    private static void ArrayClone()
    {
        Console.WriteLine(" >ArrayClone()");
        int[] a = { 1, 2, 3, 4, 5, 6, 7 };
        int[] b = (int[])a.Clone(); //rzutowanie bo domyślnym typem Clone() jest Object[]
        Console.WriteLine("b: " + string.Join(",", b));
        b[0] = 1000; // kopia i oryginał odnoszą się do różnych obiektów
        Console.WriteLine("a: " + string.Join(",", a));
    }


    /* Różnica między Copy a Clone:
    -przy Copy trzeba mieć wcześniej stworzoną zmienną tablicową o takim samym wymiarze
    -Clone tworzy nową zmienną typu Object[] a następnie kopiuje elementy
    (koniecznie jest RZUTOWANIE na właściwy typ tablicy) 

    DEEP COPY VS SHALLOW COPY
    -np.mamy tablicę, która w swoich komórkach zawiera referencję; deep copy stworzy kopię każdego obiektu dla każdej
    referencji, natomiast Shallow Copy tylko skopiuje referencje

    */

    private static void ArrayIndexOf(int[] arr, int x)
    {
        Console.WriteLine("\n>ArrayIndexOf()");
        //find index of int x in array arr
        int index = Array.IndexOf(arr, x);
        Console.WriteLine(index);
    }

    private static int[] ArrayReverse(int[] arr)
    {
        Array.Reverse(arr);
        return arr;
    }



    public static void Test()
    {
        Console.WriteLine(">ArrayClassTest()");
        ArraySort(new int[] { 5, 3, 1, 90, 2 });
        ArrayCopy();
        ArrayClone();
        ArrayPrint(new int[] { 7, 9, 9, 10, 11, 12 });
        ArrayIndexOf(new int[] { 7, 25, 2, 1, 100, 9, 21 }, 100);
        Console.WriteLine("ArrayReverse():" + string.Join(",", ArrayReverse(new int[] { 7, 8, 9, 10 })));




        // Array Class Properties: Length, Rank

    }
}

/*  ***NOTES***
    - 
    -
 */

//Class runner - class name must be the same as filename!
public class ArrayEmbedClass : IBasic
{
    public void Test()
    {
        ArrayClass.Test();
    }
}
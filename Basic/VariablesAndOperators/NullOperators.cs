using System;
using System.Text;
public class NullOperatorsExample
{
    static string str;
    public static void Test()
    {
        Console.WriteLine(">NULL-COALESCING OPERATOR");
        //  NULL-COALESCING OPERATOR
        //Unikamy przypisania wartości NULL - gdy zmienna=null, przypisujemy wartość alternatywną
        string str2 = str ?? "Wartość zamiast null";
        Console.WriteLine("Str2: " + str2);
        Console.WriteLine("\n>NULL-CONDITIONAL OPERATOR (Elvis)");
        //NULL-CONDITIONAL OPERATOR (Elvis)
        //Jeżeli str=null to wartością całego wyrażenia będzie null a nie wyjątek
        var len = str?.Length;
        Console.WriteLine("len: " + len); //null zamiast NullReferenceException
        var isNull = str?.Contains(str?.Substring(0, 1)); //2 x null
        Console.WriteLine("isNull: " + isNull);
    }
}

/*  ***NOTES***
    - 
    -
 */

//Class runner - class name must be the same as filename!
public class NullOperators : IBasic
{
    public void Test()
    {
        NullOperatorsExample.Test();
    }
}
using System;

public class Conversions
{
    public void ImplicitConversion()
    {
        /* Implicit converion is performed automatically by the compiler
         */
        //konwersja int do double (bezstratna)
        Console.WriteLine("Implicit");
        double a1 = 10.11;
        int a2 = 2;
        a1 = a1 + a2;
        Console.WriteLine("a=" + a1); //12.11

        //konwersja double do int (odcina część dziesiętną)
        int c1 = 2;
        int c2 = 5;
        int c = c1 / c2; //wynik jest typu double
        double d = c1 / c2;
        Console.WriteLine("c=" + c); //0 (odcięło część dziesiętną)
        Console.WriteLine("d=" + d); //jw. ponieważ kompilator widzi z prawej strony: int/int (a zatem nie konweruje do double)

        /* gdy jeden ze składnikow jest double, to nie trzeba konwertować  */
        int e1 = 2;
        double e2 = 5;
        double e = e1 / e2;
        Console.WriteLine("e=" + e);
        //0,4 (całe wyrażenie jest promowane do największego typu, jaki jest wśród składowych)
        /*Data types promotion rules:
        - rozpatrywane są 2 składniki działania
        - następuje promocja do większego z typów
        - domyślnie zmienne promowane są do int */

        byte byte1 = 10;
        byte1 = (byte)(byte1 * byte1); //wymagane rzutowanie, bo wynik jest promowany do int
        Console.WriteLine("byte1=" + byte1);

    }

    public void ExplicitConversion()
    {
        Console.WriteLine("\nExplicit");

        //rzutowanie
        int f1 = 2;
        int f2 = 5;
        double f = (double) (f1 / f2); //rzutujemy wynik f1/f2
        double ff = (double) f1 / f2; //(rzutujemy f1)
        Console.WriteLine("f=" + f); //0,2 (nie odcięło części dziesiętnej)
        Console.WriteLine("ff=" + ff); //0,2 (nie odcięło części dziesiętnej)

        //convert class
        int g=10;
        string str=g.ToString();
        string str2 = Convert.ToString(g);
        Console.WriteLine($"str={str}, st2={str2}");

    }
}

/*  ***NOTES***
    - 
    -
 */

//Class runner - class name must be the same as filename!
public class DataConversion : IBasic
{
    public void Test()
    {
        Conversions obj = new Conversions();
        obj.ImplicitConversion();
        obj.ExplicitConversion();
    }
}
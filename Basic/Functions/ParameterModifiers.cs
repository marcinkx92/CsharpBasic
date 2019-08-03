using System;

public class ParamModifiers
{
    public static int Suma(params int[] ints)
    {
        int suma = 0;
        foreach (var x in ints)
        {
            suma += x;
        }

        return suma;
    }

    // Parametry opcjonalne - posiadają wartość default
    // Zasada - najpierw deklarujemy parametry wymagane, później opcjonalne
    public static int OptionalParameters(int a, int b = 10, int c = 20) //param. opcjonalne podajemy po zwykłych
    {
        return a + b + c;
    }

    public static int NamedParameters(int x = 1, int y = 2, int z = 3)
    {
        return x * (y + z);
    }

    public static void Test()
    {
        // Do metody z argumentem params można przekazać dowolną liczbę argumentów danego typu lub tablicę
        Console.WriteLine("Suma: ");
        Console.WriteLine(Suma(1));
        Console.WriteLine(Suma(1, 2, 3));
        int[] tab = new int[] { 10, 200, 300, 500 };
        Console.WriteLine(Suma(tab));

        // Parametry opcjonalne - posiadają wartość defaultową
        Console.WriteLine("Optional Parameters: " + OptionalParameters(100, 40)); //a=100.b=40, c=20 (default) -> przydziela wartości po kolei do parametrów

        // Parametry nazwane - można podawać argumenty w wywołaniu w dowolnej kolejności
        Console.WriteLine("Named Parameters: " + NamedParameters(z: 10, y: 20, x: 1)); //1*(10+20)
                                                                                       //named+optional: pomijamy dowolny parametr:
        Console.WriteLine("Named Parameters: " + NamedParameters(z: 10)); //1*(2+10)
    }

}
/*  ***NOTES***
    - 
    -
 */

//Class runner - class name must be the same as filename!
public class ParameterModifiers : IBasic
{
    public void Test()
    {
        ParamModifiers.Test();
    }
}
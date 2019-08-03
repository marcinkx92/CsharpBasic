using System;
using System.Text;

// Słowa kluczowe   REF i OUT

public class CallByReference
{
    public static void CallingRef(ref int a, ref StringBuilder stb) //przekazujemy referencję
    {
        a++;
        stb.Append("To jest napis dodany przez metodę");
        stb = null;
        Console.WriteLine("Wewnątrz metody (parametry): ");
        Console.WriteLine($"a: {a}. stb: {stb}");

    }

    //out - referencja do zwracanej zmiennej jest przekazywana jako parametr do metody
    public static int CallingOut(out int wynik, int int1, int int2)
    {
        wynik = int1 + int2;
        return wynik;
    }

    public static void Test()
    {
        int value1 = 10;
        StringBuilder stb = new StringBuilder("Default");
        CallingRef(ref value1, ref stb); // w wywołaniu tez trzeba dopisać ref do parametrów
        Console.WriteLine("Poza metodą (oryginalne zmienne): ");
        Console.WriteLine($"value1: {value1}, stb: {stb}");


        //metoda z OUT: nie musimy przekazywać na wejściu parametru out, ale musi on być na wyjściu (również referencja)
        int wynik = 0;
        Console.WriteLine("Wynik dodawania: " + CallingOut(out wynik, 100, 101));
        Console.WriteLine("Oryginalna zmienna wynik: " + wynik);
    }


}
/*Wniosek: przekazując zmienne jako referenję:
 -przekazujemy oryginalne zmienne: zmienną wartościową jako referencję do wartości, zm. referencyjną jako nią samą
 -pracujemy na oryginalnych zmiennych
 */

//Class runner - class name must be the same as filename!
public class PassingVariableAsReference : IBasic
{
    public void Test()
    {
        CallByReference.Test();
    }
}
using System;

using System;
using System.Data;
using System.IO;
using System.Text;

public class FunctionParameters
{
    public static void Method1(int a, StringBuilder stb)
    {
        a += 1;
        stb.Append("Tekst1");
        Console.WriteLine($"a={a}, stb={stb}");
        stb = null; //zeruję zmienną referencyjną (argument metody)
    }

    public static void Method2(ref int b, ref StringBuilder stb2)
    {
        b += 1;
        stb2.Append("Tekst1");
        Console.WriteLine($"a={b}, stb={stb2}");
        stb2 = null; //zeruję zmienną referencyjną
    }

    public static string MethodOut(string name, out string subname)
    {
        subname = name.Substring(0, 3);
        return subname;
    }

    public static void MethodParams(params int[] c)
    {
        int suma = 0;
        foreach (int x in c)
        {
            suma += x;
        }
        Console.WriteLine(suma);
    }

    public static void OptionalParameters(int a, int b, int c = 10) //parametry opcjonalne muszą być za wymaganymi
    {
        int suma = a + b + c;
        Console.WriteLine("a+b+c=" + suma);
    }

    public static void NamedParameters(int a = 10, int b = 100, int c = 1000)
    {
        int suma = a + b + c;
        Console.WriteLine("a+b+c=" + suma);
    }


    public static void Test()
    {
        Console.WriteLine("\n >Test 1: przekazywanie parametrów przez wartość (tryb domyślny)");
        int liczba1 = 1;
        StringBuilder pusty = new StringBuilder("pusty");
        Method1(liczba1, pusty); //wynik: a=2, stb=pustyTekst1 (wynik działania metody)
        Console.WriteLine($"Oryginalne zmienne: liczba1={liczba1}, pusty={pusty} "); //liczba1=1, pusty=pustyTekst1 

        Console.WriteLine("\n >Test 2: przekazywanie parametrów przez referencje");
        int liczba2 = 1;
        StringBuilder pusty2 = new StringBuilder("pusty");
        Method2(ref liczba2, ref pusty2);//wynik: a=2, stb=pustyTekst1
        Console.WriteLine($"Oryginalne zmienne: liczba2={liczba2}, pusty={pusty2} "); //liczba1=2, pusty=""
                                                                                      //(zmienna pusty otrzymała wartość null, obiekt pusty2 zostal zmodyfikowany tak samo jak w Test 1)

        Console.WriteLine("\n >Test 3: Pzekazywanie wielu argumentów: PARAMS");
        MethodParams(1); //1
        MethodParams(1, 10, 100); //111
        MethodParams(new int[] { 1, 2, 3, 4, 5, 6 }); //21
                                                      //jako argument params mogę podać dowolną ilość argumentów danego typu lub tablice

        Console.WriteLine("\n >Test 4: Parametry opcjonalne");
        OptionalParameters(1, 2, 3); //a=1,b=2,c=3
        OptionalParameters(10, 100); //a=10, b=100, c=10 (wartość domyślna)

        Console.WriteLine("\n >Test 5: Parametry opcjonalne + nazwane");
        NamedParameters(b: 2, a: 1, c: 2); //można dzięki temu zamienić kolejność
        NamedParameters(b: 2, a: 1); //a=10, b=100, c=10 (wartość domyślna)
                                     //NamedParameters(30, b:2, a:1); //błąd kompilacji - a zostanie przypisana wartośc 30
        NamedParameters(30, b: 2);

        // -> dzięki arg. nazwanym można pomijać niektóre argumenty
        void wd(int a = 10, int b = 20, int c = 30)
        {
            Console.WriteLine(a + b + c);
        }
        wd(b: 100); //a=10, b=100, c=30;
                    //

        void fdgkj(int a, int b = 10, int c = 20, params int[] ints) // najpierw zwykłe, później opcjonalne, na końcu params
        {
            Console.WriteLine(a + b + c);
        }
        //fdgkj(10,c:20,new int[] {3,3,3});
    }
}


/*  ***NOTES***
    - 
    -
 */

//Class runner - class name must be the same as filename!
public class Parameters : IBasic
{
    public void Test()
    {
        FunctionParameters.Test();
    }
}
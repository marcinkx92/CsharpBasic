using System;

public class Constructors
{
    private int level;

    private string name;

    private char sign;

    //każda klasa może mieć wiele konstruktoróœ różniących się ilością parametrów   
    public Constructors(string name, int level)
    {
        this.name = name; //dzięki słowu klucozwemu THIS można nazwać parametr metody(konstruktora) tak samo jak pole w klasie
        this.level = level;
        //THIS odosi się do obiektu, na rzecz którego wywołujemy metodę
        Console.WriteLine($"Parametrized constructor invoked. name={name}, level={level}, sign={sign}");
    }

    //jeżeli napisaliśmy konstruktor parametryczny a chcemy wywołać domyślny, to trzeba go napisać (jeśli nie napiszemy żadnego konstruktora to domyślnego nie trzeba pisać)
    public Constructors()
    {
        Console.WriteLine($"Default constructor invoked. name={name}, level={level}, sign={sign}");
    }

    ~Constructors()
    {
        Console.WriteLine($"Destructor invoked");
    }


    public static void Test()
    {
        Constructors ork = new Constructors();
        Constructors mag = new Constructors("ork", 10);

        /*Moze się nie wyświetlić tekst destruktora:
         * Finalizers in C# are not guaranteed to run. On my machine with above code (VS 2017, Debug, Any CPU),
         * the finalizer is run and "Destructor is called" gets printed. 
         * 
         */


    }
}

/*  ***NOTES***
    - 
    -
 */

//Class runner - class name must be the same as filename!
public class ClassConstructors : IBasic
{
    public void Test()
    {
        Constructors.Test();
    }
}
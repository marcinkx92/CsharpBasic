using System;

public class HermetizationExample
{
    public static int x;
    private static int y;
    protected static int z;

    public static void Test()
    {
        //tutaj mamy dostęp do wszystkich składowych klasy
        Console.WriteLine($"Wewnątrz klasy Hermetization:x={x}, y={y}, z={z}");
    }
}

public class Class1
{
    public static void Test()
    {
        Console.WriteLine("x="+HermetizationExample.x);
        //Console.WriteLine("y="+Hermetization.y); //brak dostępu
        //Console.WriteLine("z="+Hermetization.z); //brak dostępu
    }
}

public class Class2 : HermetizationExample //class2 dziedziczy po Hermetization
{
    public static void Class2Test()
    {
        Console.WriteLine("z="+HermetizationExample.z); //tutaj mamy dostęp do składowej PROTECTED
    }

}
/*HERMETYZACJA
-jeżeli brak modyfikatora, domyślnie ustawiany jest dostęp PRIVATE
-PUBLIC: dostęp dla wszystkich klas w przestrzeni nazw
-PRIVATE: dostęp spoza klasy niemożliwy
-PROTECTED: dostęp dla klas dziedziczących
-INTERNAL: dostęp tylko wewnątrz BIBLIOTEKI DLL
-PROTECTED INTERNAL: dostęp dla klas potomych w BIBLIOTECE DLL
*/

//Class runner - class name must be the same as filename!
 public class Hermetization : IBasic
 {
    public void Test()
    {
        HermetizationExample.Test();
        Class1.Test();
        Class2.Test();
    }
 }
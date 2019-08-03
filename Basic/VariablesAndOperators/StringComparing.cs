using System;
using System.Text;

public class Strings
{
    int a=1, b=1;
    string str1="To jest przykład", str2="To jest przykład";

    StringBuilder string1 = new StringBuilder("Example");
    StringBuilder string2 = new StringBuilder("Example");

    public void Compare()
    {
        //comparing value types
        Console.WriteLine(a==b); //true

        //comparing references
        Console.WriteLine(str1==str2); //true
        /*zadziała, ponieważ są to tzw. String literals - po utworzeniu str1 łańcuch trafia do
         specjalnej przestrzeni nazw, gdy tworzymy str2 o takim samym łańcuchu,
          kompilator nie tworzy nowego obiektu tylko przypisuje zmienną do istenijącego łańcucha*/

        //comparing reference types': references vs values
        Console.WriteLine(string1==string2); //false
        Console.WriteLine(string1.Equals(string2)); //true
    }
}

/*  ***NOTES***
    - 
    -
 */

//Class runner - class name must be the same as filename!
 public class StringComparing : IBasic
 {
    public void Test()
    {
        Strings obj = new Strings();
        obj.Compare();
    }
 }
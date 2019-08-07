using System;

public class Example
{
    public void ExampleMethod()
    {
        Console.WriteLine("");
    }
}

/*  ***NOTES***
    - CTRL+SHIFT+A (komentarz blokowy)
    - alt+x+up/down (kopiuj linię)
    - alt+up/down (przenieś linię)
 */

//Class runner - class name must be the same as filename!
 public class EmptyClass : IBasic
 {
    public void Test()
    {
        Example obj = new Example();
        obj.ExampleMethod();
    }
 }
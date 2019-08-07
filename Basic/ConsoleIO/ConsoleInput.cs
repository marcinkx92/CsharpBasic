using System;

public class _ConsoleInput
{
    public void SumOfIntegers()
    {
        Console.WriteLine("Write first integer");
        int first = Convert.ToInt32(Console.ReadLine()); //ReadLine() zwraca string
        Console.WriteLine("Write second integer");
        int second = Convert.ToInt32(Console.ReadLine());
        int sum= first + second;
        Console.WriteLine("Sum:"+sum);        
    }
}

/*  ***NOTES***
    - 
    -
 */

//Class runner - class name must be the same as filename!
 public class ConsoleInput : IBasic
 {
    public void Test()
    {
        _ConsoleInput obj = new _ConsoleInput();
        obj.SumOfIntegers();
    }
 }
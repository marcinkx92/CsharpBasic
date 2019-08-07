using System;
using System.Linq;

public class StringClassMethods
{
    public void StringMethodsTest()
    {
        string str = "The string type represents a character array, and its length is determined by the Length property.";

        //Substring
        Console.WriteLine(" Substring");
        Console.WriteLine(str.Substring(10)); //Substring(int startIndex)
        Console.WriteLine(str.Substring(10,4)); //Substring(int startIndex, int Length)

        //IndexOf, LastInsexOf - zwraca pozycję pierwszego/ostatniego wystąpienia
        Console.WriteLine("\n IndexOf, LastIndexOf");
        Console.WriteLine(str.IndexOf('s')); //IndexOf(char character)
        Console.WriteLine(str.IndexOf('s',10)); //IndexOf(char character, int startIndex)
        Console.WriteLine(str.IndexOf("character")); //IndexOf(string str)
        Console.WriteLine(str.LastIndexOf('p')); //29
        Console.WriteLine(str.LastIndexOf('x')); //-1 (character not found)

        //Contains
        Console.WriteLine("\nContains");
        Console.WriteLine(str.Contains("array")); //true
        //Console.WriteLine(String.Contains(str, "array")); //nie zadziała, bo metody w klasie String nie są statyczne (a w Javie tak)

        //StartsWith, EndsWith
        Console.WriteLine("\n StartsWith, EndWith");
        Console.WriteLine(str.StartsWith("The")); //true
        Console.WriteLine(str.StartsWith('T')); //true
        Console.WriteLine(str.StartsWith("Thc")); //false
        Console.WriteLine(str.EndsWith("y")); //false

        //Remove
        Console.WriteLine("\n Remove");
        Console.WriteLine(str.Remove(3)); //remove from 3 to the end
        Console.WriteLine(str.Remove(3,50)); //remove from 3 to 50

        //Replace
        Console.WriteLine("\n Replace");
        Console.WriteLine(str.Replace("string", "AUTOMOBIL")); //old string, new string
        Console.WriteLine(str.Remove(3,50)); 

        //Insert
        Console.WriteLine("\n Insert");
        Console.WriteLine(str.Insert(3, " BEST")); //position, string to insert

        //ToLower, ToUpper
        Console.WriteLine("\n ToLower, ToUpper");
        Console.WriteLine(str.ToUpper()); 

        //Clone, CompareTo (comparing length)
        string str2 = (string)str.Clone();//rzutowanie niezbędne, bo Clone zwraca typ Object
        string longer = str2+" ";
        string shorter = str2.Remove(40);
        Console.WriteLine("\nClone, CompareTo");
        Console.WriteLine(str.CompareTo(str2));  //0 (the same length)
        Console.WriteLine(str.CompareTo(longer));  //-1 (str is shorter)
        Console.WriteLine(str.CompareTo(shorter));  //-1 9str is longer

        //Equals (comparing contents)
        Console.WriteLine("\n Equals");
        Console.WriteLine(str.Equals(str2));  //true
        Console.WriteLine(str.Equals(longer));  //false
        string replaced = str.Replace("The", "Dhe");
        Console.WriteLine(str.Equals(replaced));  //false

/*
        //Split to array
        Console.WriteLine("\n Split");
        string[] splitArray = str.Split(' '); //split by separator
        //splitArray.ToList().ForEach(Console.WriteLine); //print using System.Linq;

        //GetHashCode (unikalny kod obiektu)
        Console.WriteLine("\n GetHashCode");
        Console.WriteLine(str.GetHashCode()); */

        //IsNormalized (sprawdza czy jest to format Unicode)
        Console.WriteLine("\n IsNormalized");
        Console.WriteLine(str.IsNormalized());  //true
    }
}

/*  ***NOTES***
    - CTRL+SHIFT+A (komentarz blokowy)
    - alt+x+up/down (kopiuj linię)
    - alt+up/down (przenieś linię)
 */

//Class runner - class name must be the same as filename!
 public class StringClass : IBasic
 {
    public void Test()
    {
        StringClassMethods obj = new StringClassMethods();
        obj.StringMethodsTest();
    }
 }
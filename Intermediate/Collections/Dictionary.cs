using System;
using System.Text;
using System.Collections.Generic;

public class DictionaryExample
{
    /*Słowniki to kolekcja przechwująca pary klucz-wartość 
    W definicji słownika deklarujemy typ klucza oraz typ wartości
    Główne zalety: metody służące do przezukiwania słownika po kluczu, po wartości
     */
    Dictionary<string, string> MyDictionary;
    public DictionaryExample()
    {
        MyDictionary = new Dictionary<string, string>();
    }
    public void AddValues()
    {
        MyDictionary.Add("McCayne", "1001");
        MyDictionary.Add("Smith", "9902");
        MyDictionary.Add("O'Neil", "7890");
        MyDictionary.Add("Ulrich", "8221");
    }
    public bool CheckKey(string key)
    {
        return (MyDictionary.ContainsKey(key));
    }
    public bool CheckValue(string value)
    {
        return (MyDictionary.ContainsValue(value));
    }
    public string FindValue(string key)
    {
        if (MyDictionary.ContainsKey(key))
        {
            return MyDictionary[key];
        }
        else return "null";
    }

    public void ListElements()
    {
        Console.WriteLine("MyDictionary elements: ");
        foreach (KeyValuePair<string, string> val in MyDictionary)
        {
            Console.Write("Key:{0}, Value:{1} | ", val.Key, val.Value);
        }
    }

    public static void Test()
    {
        DictionaryExample dc = new DictionaryExample();
        dc.AddValues();
        Console.WriteLine("Smith? " + dc.CheckKey("Smith"));
        Console.WriteLine("9999? " + dc.CheckValue("9999"));
        Console.WriteLine("Key: Smith, Value:" + dc.FindValue("Smith"));
        dc.ListElements();
    }

}

/*  ***NOTES***
    - 
    -
 */

//Class runner - class name must be the same as filename!
public class Dictionary : IIntermediate
{
    public void Test()
    {
        DictionaryExample.Test();
    }
}
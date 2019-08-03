using System;
using System.Text;
public class ThisKeywordExample
{
    public class Subclass
    {

    }
    private Subclass sb = null;
    private int x;

    //THIS pozwala uniknąć konfliktu nazw
    public ThisKeywordExample(int x)
    {
        this.x = x;
    }

}

//INDEKSATORY - przykład użycia THIS
//INDEKSATOR pozwala używać indeksów [] jak w tablicach dla własnej klasy-kolekcji
public class SimpleCollection<T> //klasa mająca właściwość tworzenia tablic
{
    private T[] arr = new T[100]; // tablica klasy T

    public T this[int i]
    {
        get { return arr[i]; }
        set { arr[i] = value; }
    }

}

/*  ***NOTES***
    - 
    -
 */

//Class runner - class name must be the same as filename!
public class ThisKeyword : IBasic
{
    public void Test()
    {
        var ind = new SimpleCollection<string>();
        Console.WriteLine("ind[0]="+ind[0]);
    }
}
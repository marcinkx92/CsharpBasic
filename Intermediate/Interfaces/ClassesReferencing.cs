using System;

/*Referencing classes through interfaces

- można utworzyć zmienną typu interfejsu (tak samo jak dla zwykłej klasy)
- do takiej zmiennej można przypisać obiekt dowolnej klasy implementującej interfejs
 */

public class ClaReferencing
{
    public void ClassesReferencingExample()
    {
        JsonWriter json = new JsonWriter();
        json.WriteFile();
        json.CopyFile();

        //wykorzystanie zmiennej interfejsowej
        IWriter _json = new JsonWriter();
        IWriter _xml = new XmlWriter();
        _json.WriteFile();
        _xml.WriteFile();
        //_json.CopyFile(); nie można użyć metody spoza interfejsu na zmiennej typu interfesjowego
    }
}

/*  ***NOTES***
    - 
    -
 */

//Class runner - class name must be the same as filename!
 public class ClassesReferencing : IIntermediate
 {
    public void Test()
    {
        ClaReferencing obj = new ClaReferencing();
        obj.ClassesReferencingExample();
    }
 }
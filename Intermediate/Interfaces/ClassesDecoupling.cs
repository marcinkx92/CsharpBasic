using System;
/*
- When one class depends on another class those classes are coupled -> it is better to decouple classes (loosely couple)
- gdy zmieniamy częśc kodu, nie tzeba zmieniać wszystkich klas zależnych
 */

 //strong coupling example
public class XmlFileWriter
{
    private XmlWriter _xmlWriter;
    public XmlFileWriter(XmlWriter xmlWriter)
    {
        this._xmlWriter = xmlWriter;
    }
    public void Write()
    {
        _xmlWriter.WriteFile();
    }
}

//loose coupling example
public class UniversalWriter
{
    private IWriter _fileWriter; //uniwersalna zmienna typu IWriter
    public UniversalWriter(IWriter fileWriter) //do argumentu konstr. można wrzucić obiekt każdej klasy implementującej interfejs IWriter
    {
        this._fileWriter = fileWriter;
    }
    public void Write()
    {
        _fileWriter.WriteFile();
    }

}

/*  ***NOTES***
    - 
    -
 */

//Class runner - class name must be the same as filename!
 public class ClassesDecoupling : IIntermediate
 {
    public void Test()
    {
        //strong coupling - na obiekcie klasy XmFileWriter można wykonać tylko metodę klasy XmlWriter
        XmlFileWriter obj = new XmlFileWriter(new XmlWriter());
        obj.Write();

        //decoupling - teraz na tym samym obiekcie można wykonywać metody różnych klas
        UniversalWriter uni = new UniversalWriter(new XmlWriter());
        uni.Write();
        UniversalWriter uni2 = new UniversalWriter(new JsonWriter());
        uni2.Write();
        /*ponadto zmieniając metodę WriteFile() np. w klasie XmlWriter, wszystko nadal zadziała dla JsonWriter - nie musze nic zmieniać w klasie UniversalDriver */
    }
 }
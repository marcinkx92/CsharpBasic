using System;

//definicja interfejsu
public interface IWriter
{
    void WriteFile(); //tutaj nie ma składowej dostępu
}

//jedna z implementacji interfejsu
public class XmlWriter : IWriter //klasa XmlWriter implementuje interfejs IWriter
{
    public void WriteFile()
    {
        Console.WriteLine("Write XML file");
    }
}

public class FileBase
{
    string inputFormat;
}


//klasa może dziedziczyć z innej klasy i równocześnie implementować interfejs
//generalna zasada: najpierw piszemy klasę bazową, następnie implementowane interfejsy
public class JsonWriter : FileBase, IWriter
{
    public void WriteFile() //implementacja metody zadeklarowanej w interfejsie
    {
        Console.WriteLine("Write JSON file");
    }
    public void CopyFile() //tej metody nie ma w onterfejsie
    {
        Console.WriteLine("Copy JSON file");
    }
}


/*
- interfejs działa jak "kontrakt": kompilator ma pewność, że klasy implementujące interfejs MUSZĄ zawierać definicję określonych składowych interfejsu
- każda klasa implementująca interfejs musi zawierać wszystkie składowe interfejs + opcjonalnie dodatkowe składowe
- każda z implementaji interfejsu jest niezależna od pozostałych - nie wie o nich i nie zależy od nich
 */


 public class Interfaces : IIntermediate
 {
    public void Test()
    {
        XmlWriter _XmlWiter = new XmlWriter();
        _XmlWiter.WriteFile();

        JsonWriter _JsonWriter = new JsonWriter();
        _JsonWriter.WriteFile();
        _JsonWriter.CopyFile();
    }

 }
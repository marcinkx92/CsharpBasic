using System;

public interface IFormatter
{
    void FormatFile();
}

public class MultiInterfaces : FileBase, IWriter, IFormatter
{
    public void WriteFile()
    {
        Console.WriteLine("Write file");
    }
    public void FormatFile()
    {
        Console.WriteLine("Format file");
    }
}

/*  ***NOTES***
    - klasa może implementować kilka interfejsów
    - należy je wypisać po klasie bazowej (jeśli dziedziczmy)
 */

//Class runner - class name must be the same as filename!
 public class MultipleInterfaces : IIntermediate
 {
    public void Test()
    {
        MultiInterfaces obj = new MultiInterfaces();
        obj.WriteFile();
        obj.FormatFile();
    }
 }
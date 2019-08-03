using System;

/*
    - Każdą klasę, którą chcemy przetestować należy wpisać do poniższej metody Test w argumencie konstruktora jn.
    - Dodatkowo, aby poprawić czytelność klasy z danego folderu umieszczamy między nagłówkami (WriteLine's) wg schematu
 */
public class IntermediateRunner
{
    public static void Test()
    {
        Console.WriteLine(" >>Interfaces\n");
        IntermediateRunner.Run(new Interfaces());
        IntermediateRunner.Run(new ClassesReferencing());
        IntermediateRunner.Run(new ClassesDecoupling());
        IntermediateRunner.Run(new MultipleInterfaces());
        IntermediateRunner.Run(new ExplicitInterfaces());
        Console.WriteLine(" \nInterfaces<<");

        Console.WriteLine(" >>Collections\n");
        IntermediateRunner.Run(new Dictionary());
        Console.WriteLine(" \nCollections<<");

    }



    public static void Run(IIntermediate className)
    {
        Console.WriteLine($"-------{className}-----------------");
        className.Test();
        Console.WriteLine("------- ------ ------ ------ -------");
    }
}

/*
Ciekawostka:
- Dzięki wykorzystaniu interfejsu IIntermediate można w parametrze utworzyć obiekt, a następnie uzyć jego metody Test()
- gdyby w parametrze zamiast 'IIntermediate className' użyć 'object className', nie można by było wykonać metody classname.Test:
ERROR: 
'object' does not contain a definition for 'X'

- jest tak, ponieważ gdy podamy interfejs, jest gwarancja, że obiekt przekazany w parametrze zawiera metodę Test()
 */

using System;

/*
    - Każdą klasę, którą chcemy przetestować należy wpisać do poniższej metody Test w argumencie konstruktora jn.
    - Dodatkowo, aby poprawić czytelność klasy z danego folderu umieszczamy między nagłówkami (WriteLine's) wg schematu
 */
public class BasicRunner
{
    public static void Test()
    {   /* 
        Console.WriteLine(" >>Arrays\n");
        //BasicRunner.Run(new Arrays());
        //BasicRunner.Run(new PassingArrayToFunction());
        //BasicRunner.Run(new ArrayEmbedClass());
        Console.WriteLine(" \nArrays<<");
        */
        /* 
        Console.WriteLine(" >>Functions\n");
        BasicRunner.Run(new Parameters());
        BasicRunner.Run(new PassingVariableAsValue());
        BasicRunner.Run(new PassingVariableAsReference());
        BasicRunner.Run(new ParameterModifiers());
        Console.WriteLine(" \nFunctions<<");
        */
/*         Console.WriteLine(" >>Variables&Operators\n");
        BasicRunner.Run(new NullOperators());*/
        BasicRunner.Run(new StringComparing());   
        BasicRunner.Run(new DataConversion());   

        Console.WriteLine(" \nVariables&Operators<<"); 
        /* 
        Console.WriteLine(" >>Objects\n");
        BasicRunner.Run(new ClassExample());
        BasicRunner.Run(new ClassConstructors());
        BasicRunner.Run(new Hermetization());
        BasicRunner.Run(new ThisKeyword());        
        Console.WriteLine(" \nObjects<<");
        */
/*         Console.WriteLine(" >>Console Input&Output\n");
        BasicRunner.Run(new ConsoleInput()); //odpalać przez dotnet run
        Console.WriteLine(" \nVConsole Input&Output<<"); */
    }



    public static void Run(IBasic className)
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


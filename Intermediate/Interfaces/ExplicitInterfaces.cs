using System;
/*
- gdy klasa implementuje kilka interfejsów może się zdarzyć tak, że w rożnych interfejsach powtarzają się nazwy metod
 */
public interface Interface1
{
    void MethodExample();
}

public interface Interface2
{
    void MethodExample();
}

public class BaseClass1
{

}

public class ImplicitIn : BaseClass1, Interface1
{
    //metoda implementująca interfejs musi być publiczna
    public void MethodExample() //implicit interface implementation (niejawna)
    {

    }
}

public class ExplicitIn : BaseClass1, Interface1, Interface2
{
    //explicit interface implementations (jawna)
    void Interface1.MethodExample() //nie można używać modyfikatora dostępu
    {
        Console.WriteLine("Method example from Interface1");
    }
    void Interface2.MethodExample()
    {
        Console.WriteLine("Method example from Interface2");
    }
}

/*  ***NOTES***
    - 
    -
 */

//Class runner - class name must be the same as filename!
 public class ExplicitInterfaces : IIntermediate
 {
    public void Test()
    {
        ExplicitIn obj = new ExplicitIn();
        //obj.MethodExample(); //Compiler error (bo nie wiadomo, o który interfejs chodzi)

        //implementacje jawne interfejsu można wywołać tylko ze zmiennej typu interfejsowego !
        Interface1 i1 = obj;
        i1.MethodExample();

        Interface2 i2 = obj;
        i2.MethodExample();
    }
 }
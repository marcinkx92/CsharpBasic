using System;

public class SimpleClass
{
        private int x;
        private string str;

        private SimpleClass(int x, string str)
        {
            this.x = x;
            this.str = str;
        }

        private void Concat()
        {
            Console.WriteLine(x+str);
        }

        // utworzymy obiekt klasy SimpleClass z metody zmajdującej się w tej samej klasie
        public static void Test()
        {
            SimpleClass simple = new SimpleClass(10, "simpleObject");
            simple.Concat();
        }
 }

/*  ***NOTES***
    - 
    -
 */

//Class runner - class name must be the same as filename!
 public class ClassExample : IBasic
 {
    public void Test()
    {
        SimpleClass.Test();
    }
 }
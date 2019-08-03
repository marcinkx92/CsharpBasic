using System;

public class ArrayBasics
{
// ONE-DIMENSION ARRAYS //
        public static void ArraysInitialization(){
            //Deklaracja i inicjalizacja osobno
            Console.WriteLine(" >ArraysInitialization()");
            int[] tab1; //deklaracja zmiennej tablicowej
            tab1 = new int[2]; //inicjalizacja - fixed size (nie można zmienić wielkości)
            tab1[0]=10;
            tab1[1]=222;
            foreach (var item in tab1) //traverse through the matrix
            {
                Console.WriteLine(item);
            }

            //Inne sposoby inicjalizacji
            int[] tab2 = new int[2] {1,3};
            int[] tab3 = new int[] {9,0,99};
            int[] tab4 = {900,200,11};
            //Traversal by string.Join() method
            Console.WriteLine($"tab2:[{string.Join(",",tab2)}]"); //string.Join(separator, tablica)
            Console.WriteLine($"tab3:[{string.Join(";",tab3)}]"); 
            Console.WriteLine($"tab4:[{string.Join(".",tab4)}]"); 
        }

// RECTANGULAR ARRAYS //
        public static void RectangularArrays(){
            Console.WriteLine(" \n>RectangularArrays()");
            Console.WriteLine("Rectangular Arrays");
            int[,] rect1 = new int[2,2] {
                {1,2}, 
                {4,5}
            };

            int[,] rect2 = new int[,] { //można pomninąć wymiary gdy inicjalizujemy od razu
                {1,2}, 
                {4,5}
            };

            int[,] rect3 =  { //jeszcze większe uproszczenie
                {1,2}, 
                {4,5}
            };

            int [,] rect4 = new int[2,3]; //koniecznie podajemy wymiary
            for (int i = 0; i<2;i++){ // inicjalizacja pętlą
                for (int j=0; j<3; j++){
                    rect4[i,j]=i+1;
                }
            }
            foreach (int v in rect1) Console.Write(" "+v);
            Console.WriteLine();
            foreach (int v in rect2) Console.Write(" "+v);
        }
        
// JAGGED ARRAYS //
        public static void JaggedArrays(){
            Console.WriteLine(" \n>JaggedArrays()");
            int[][] jagg1 = new int[3][]{ //
                new int[] {1,2}, //w każdym wierszu inicjalizujemy nową tablicę
                new int[] {2},
                new int[5] {1,2,3,4,5}
            };
            for (int i=0; i<3; i++){ // wypisujemy tablice nieregularną - kompinacja pętli i Join
                Console.WriteLine(string.Join(",",jagg1[i]));
            }            
        }    
}



/*  ***NOTES***
    - 
    -
 */

//Class runner - class name must be the same as filename!
 public class Arrays : IBasic
 {
    public void Test()
    {
        ArrayBasics.ArraysInitialization();
        ArrayBasics.RectangularArrays();
        ArrayBasics.JaggedArrays();       
    }
 }
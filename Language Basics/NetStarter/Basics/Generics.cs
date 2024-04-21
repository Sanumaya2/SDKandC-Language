using System;
using System.Collections.Generic; 
public class Generics
{
    // public void Print (int x)
    // {
    //     Console.WriteLine(x);
    // }
    //   public void Print (float x)
    // {
    //     Console.WriteLine(x);
    // }
      public void Print<T> (T x)  //generic method
    {
        Console.WriteLine(x);
    }
    public void Test()
    {
        Print<string>("34567");
        Print<int>(34567);
        Print<decimal>(3456.67m);
              
        List<int> marks = new List<int> {67,45,89,23};
        marks.Add(57);      
    }
}
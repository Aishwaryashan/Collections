
using System;  
using System.Collections.Generic;  
  
public class StackExample  
{  
    public static void Main(string[] args)  
    {  
        Stack<string> names = new Stack<string>();

        names.Push("Aish");  
        names.Push("Rajesh");  
        names.Push("Prabhu");  
        names.Push("Radha");  
        names.Push("Karthik");
  
        foreach (string name in names)  
        {  
            Console.WriteLine(name);  
        }  
  
        Console.WriteLine("Peek element: "+names.Peek());  
        Console.WriteLine("Pop: "+ names.Pop());  
        Console.WriteLine("Peek element present: " + names.Peek());  
  
    }  
}  

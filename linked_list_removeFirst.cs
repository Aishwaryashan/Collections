using System;  
using System.Collections.Generic;  
  
public class LinkedListExample  
{  
    public static void Main(string[] args)  
    {  
       
        var names = new LinkedList<string>();  
        names.AddLast("Sonoo Jaiswal");  
        names.AddLast("Ankit");  
        names.AddLast("Peter");  
        names.AddLast("Irfan");  
        names.AddFirst("John");
   
        foreach (var name in names)  
        {  
            Console.WriteLine(name);  
        }  

        names.RemoveFirst();
        Console.WriteLine("Elements after removefirst:");

        foreach (string str in names)
        {
            Console.WriteLine(str);
        }

    }  
} 

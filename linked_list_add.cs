using System;  
using System.Collections.Generic;  
  
public class LinkedListExample  
{  
    public static void Main(string[] args)  
    {  
        // Create a list of strings  
        var names = new LinkedList<string>();  
        names.AddLast("Sonoo Jaiswal");  
        names.AddLast("Ankit");  
        names.AddLast("Peter");  
        names.AddLast("Irfan");  
        names.AddFirst("John");//added to first index  
  
        // Iterate list element using foreach loop  
        foreach (var name in names)  
        {  
            Console.WriteLine(name);  
        }  
    }  
} 

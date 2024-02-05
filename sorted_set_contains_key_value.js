using System;  
using System.Collections.Generic;  
  
public class SortedSetExample  
{  
    public static void Main(string[] args)  
    {  
  
        var names = new SortedSet<string>();  
        names.Add("Sonoo");  
        names.Add("Ankit");  
        names.Add("Peter");  
        names.Add("Irfan");  
        names.Add("Ankit");
           
        foreach (var name in names)  
        {  
            Console.WriteLine(name);  
        }  
    }  
}  

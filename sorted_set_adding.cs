using System;  
using System.Collections.Generic;  
  
public class SortedSetExample  
{  
    public static void Main(string[] args)  
    {  
     
        var names = new SortedSet<string>();  
        names.Add("Thrish");  
        names.Add("Tara");  
        names.Add("Aara");  
        names.Add("Lallu");  
        names.Add("Balu");
          
        foreach (var name in names)  
        {  
            Console.WriteLine(name);  
        }  
    }  
}  

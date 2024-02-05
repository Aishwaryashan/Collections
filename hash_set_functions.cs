
using System;  
using System.Collections.Generic;  
  
public class HashSetExample  
{  
    public static void Main(string[] args)  
    {  

        var names = new HashSet<string>();  
        names.Add("Aish");  
        names.Add("Thrish");  
        names.Add("Chandu");  
        names.Add("Dwarak");  
        names.Add("Nishi");  
      
        foreach (var name in names)  
        {  
            Console.WriteLine(name);  
        }  
      names.Remove("Chandu");
      Console.WriteLine("Hash_set after removing element:");
         foreach (var name in names)  
        {  
            Console.WriteLine(name);  
        }
        int count = names.Count;
         Console.WriteLine("The number of elements in hashset is :");
         Console.WriteLine(count);
         names.Clear();
         count = names.Count;
             Console.WriteLine("\nThe number of elements in hashset after clear is :");
         Console.WriteLine(count);
         
    }  
} 

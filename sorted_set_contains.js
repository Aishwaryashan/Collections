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

        bool containsAara = names.Contains("Aara");
        if (containsAara)
        {
            Console.WriteLine("\nSet contains 'Aara'");
        }
        else
        {
            Console.WriteLine("\nSet does not contain 'Aara'");
        }

        bool containsBalu = names.Contains("Balu");
        if (containsBalu)
        {
            Console.WriteLine("\nSet contains 'Balu'");
        }
        else
        {
            Console.WriteLine("\nSet does not contain 'Balu'");
        }
    }
}

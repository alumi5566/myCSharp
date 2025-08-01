using System;
using System.Collections.Generic;
namespace Samples;

public class ListSample
{
    public static void Run()
    {
        List<string> fruits = new List<string> { "Apple", "Banana" };
        fruits.Add("Orange");
        fruits.Remove("Banana");

        Console.WriteLine("Fruits in the list:");
        foreach (var fruit in fruits)
        {
            Console.WriteLine(fruit);
        }
    }
}
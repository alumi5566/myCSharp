using System;
using System.Collections.Generic;

namespace Samples;

public class DictionarySample
{
    public static void Run()
    {
        Dictionary<string, int> ages = new Dictionary<string, int>();
        ages["Alice"] = 25;
        ages["Bob"] = 30;

        foreach (var kv in ages)
        {
            Console.WriteLine($"{kv.Key} is {kv.Value} years old.");
        }
    }
}
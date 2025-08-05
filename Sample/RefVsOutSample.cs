using System;

namespace Samples
{
    public class RefVsOutSample
    {
        public static void Run()
        {
            Console.WriteLine("=== REF Example ===");
            int refValue = 10; // Must be initialized
            Console.WriteLine($"Before: {refValue}");
            AddFive(ref refValue); // Pass by reference
            Console.WriteLine($"After: {refValue}"); // 15

            Console.WriteLine("\n=== OUT Example ===");
            int outValue; // No initialization needed
            InitializeValue(out outValue);
            Console.WriteLine($"After OUT: {outValue}"); // 42
        }

        // ref: can read and modify the passed variable
        static void AddFive(ref int number)
        {
            number += 5;
        }

        // out: must assign value before returning
        static void InitializeValue(out int number)
        {
            number = 42;
        }
    }
}
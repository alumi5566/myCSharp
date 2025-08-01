using System;

namespace Samples;

public struct PointStruct
{
    public int X, Y;
}

public class PointClass
{
    public int X, Y;
}

public class StructVsClassSample
{
    public static void Run()
    {
        Console.WriteLine("=== Struct vs Class Demo ===");

        // Struct: VALUE COPY
        PointStruct ps1 = new PointStruct { X = 1, Y = 2 };
        PointStruct ps2 = ps1; // Copies values
        ps2.X = 99;
        Console.WriteLine($"Struct ps1.X: {ps1.X} (unchanged)");
        Console.WriteLine($"Struct ps2.X: {ps2.X} (changed)");

        // Class: REFERENCE COPY
        PointClass pc1 = new PointClass { X = 1, Y = 2 };
        PointClass pc2 = pc1; // Copies reference
        pc2.X = 99;
        Console.WriteLine($"Class pc1.X: {pc1.X} (changed!)");
        Console.WriteLine($"Class pc2.X: {pc2.X} (changed)");

        // Nullability difference
        PointClass pcNull = null; // OK
        // PointStruct psNull = null; // ❌ Compile error
        // That’s because in C# a struct is a value type, and value types cannot be null by default.
        // Only reference types (like classes) can be null.

        Console.WriteLine("\nStruct is VALUE type → stored on stack, copied by value");
        Console.WriteLine("Class is REFERENCE type → stored on heap, copied by reference");
    }
}

using System;

namespace Samples;
// namespace Samples
// This seems so redundant, but this is what C# separate the namespace
// In C# 10+, we can also use "namespace Samples;" instead of extra layer of bracket
// The namespace aims to separate the scope of class
// {
public class ArraysSample
{
    public static void Run()
    {
        int[] arr = { 1, 2, 3, 4 };
        Console.WriteLine("First element: " + arr[0]);
        arr[2] = 99;
        Console.WriteLine(string.Join(", ", arr));
    }
}
// }
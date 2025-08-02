using System;

namespace Samples;

public unsafe class PointerSample
{
    public static void Run()
    {
        Console.WriteLine("=== Pointer Sample in C# ===");

        // Example 1: Basic struct pointer
        Point p = new Point { X = 10, Y = 20 };
        Point* ptr = &p;
        Console.WriteLine($"[Example 1] Original: X={ptr->X}, Y={ptr->Y}");
        ptr->X = 100;
        ptr->Y = 200;
        Console.WriteLine($"[Example 1] Modified: X={ptr->X}, Y={ptr->Y}");
        Console.WriteLine();

        // Example 2: Pointer arithmetic with struct array
        Point[] points = new Point[3];
        points[0] = new Point { X = 1, Y = 2 };
        points[1] = new Point { X = 3, Y = 4 };
        points[2] = new Point { X = 5, Y = 6 };
        fixed (Point* arrPtr = points)
        {
            for (int i = 0; i < points.Length; i++)
            {
                Point* current = arrPtr + i;
                Console.WriteLine($"[Example 2] Point {i}: X={current->X}, Y={current->Y}");
            }
        }
        Console.WriteLine();

        // Example 3: Passing pointer to a method
        Console.WriteLine($"[Example 3] Before: X={p.X}, Y={p.Y}");
        UpdatePoint(&p, 42, 99);
        Console.WriteLine($"[Example 3] After: X={p.X}, Y={p.Y}");
        Console.WriteLine();

        // Example 4: Mixing pointers and normal references
        Console.WriteLine($"[Example 4] Normal access: X={p.X}, Y={p.Y}");
        Point* mixedPtr = &p;
        mixedPtr->X += 5;
        mixedPtr->Y += 5;
        Console.WriteLine($"[Example 4] Pointer modified: X={p.X}, Y={p.Y}");
    }

    private static void UpdatePoint(Point* p, int newX, int newY)
    {
        p->X = newX;
        p->Y = newY;
    }

    public struct Point
    {
        public int X;
        public int Y;
    }
}
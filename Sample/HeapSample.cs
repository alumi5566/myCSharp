using System;
using System.Collections.Generic;

namespace Samples;

public class HeapSample
{
    public static void Run()
    {
        // Min-heap: smallest element comes first
        PriorityQueue<string, int> minHeap = new PriorityQueue<string, int>();

        minHeap.Enqueue("Apple", 3);
        minHeap.Enqueue("Banana", 1);
        minHeap.Enqueue("Cherry", 2);

        Console.WriteLine("Min-Heap order:");
        while (minHeap.Count > 0)
        {
            Console.WriteLine(minHeap.Dequeue());
        }
    }
}
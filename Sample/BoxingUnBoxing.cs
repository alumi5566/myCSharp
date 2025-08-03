using System;
using System.Collections.Generic;

namespace Samples;

public class BoxingUnBoxingSample
{
    public static void Run()
    {
        // Boxing  
        int anum = 123;  
        Object obj = anum;  
        Console.WriteLine("anum: " + anum);  
        Console.WriteLine("obj: " + obj);

        // Unboxing
        Object obj2 = 456; 
        int anum2 = (int)obj2; 
        Console.WriteLine("anum2: " + anum2); 
        Console.WriteLine("obj2: " + obj2);
    }
}
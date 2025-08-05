using System;
using System.Collections.Generic;
namespace Samples;


public class ParkingLotsSample
{
    public static void Run()
    {
        var p = new PersonGS();
        p.Name = "Bob";                  // set
        Console.WriteLine(p.Name);       // get

        var p2 = new PersonGS_v2();
        p2.Age = 30;                       // ✅ works
        // p.Age = -5;                    // ❌ throws exception
        Console.WriteLine(p2.Age);         // 30
    }
}
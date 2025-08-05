using System;
using System.Collections.Generic;
namespace Samples;

public class PersonGS
{
    public string Name { get; set; } // Auto-property
}

public class PersonGS_v2
{
    private int age;

    public int Age
    {
        get { return age; }
        set
        {
            if (value < 0)
                throw new ArgumentException("Age cannot be negative");
            age = value;
        }
    }
}

public class GetterSetterSample
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
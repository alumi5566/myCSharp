using System;
using System.Collections.Generic;

namespace Samples;

enum Day
{
    Sunday,     // 0
    Monday,     // 1
    Tuesday,    // 2
    Wednesday,  // 3
    Thursday,   // 4
    Friday,     // 5
    Saturday    // 6
}

enum ErrorCode
{
    None = 0,
    NotFound = 404,
    Unauthorized = 401,
    InternalServerError = 500
}

public class EnumSample
{
    public static void Run()
    {
        Day today = Day.Monday;
        
        Console.WriteLine(today); // Output: Monday
        Console.WriteLine((int)today); // Output: 1

        // Strong typing:
        // today = 5;  // ❌ Compile error
        today = (Day)5; // ✅ Allowed only with explicit cast
        Console.WriteLine(today); // Output: Friday

        ErrorCode code = ErrorCode.NotFound;
        Console.WriteLine(code); // NotFound
        Console.WriteLine((int)code); // 404
        
        code = ErrorCode.Unauthorized;
        Console.WriteLine(code); // Unauthorized
        Console.WriteLine((int)code); // 401
    }
}
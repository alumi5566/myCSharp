using System;
using System.Collections.Generic;

namespace Samples;

class Test {    
    readonly int read = 10;    
    const int cons = 10;    
    // Const是static，compile的時候就賦值，之後不能改動。
    // ReadOnly可以改動，但是要用非靜態constructor。
    public Test() {    
        read = 100;    
        // cons = 100; // 加這一行會編譯錯誤
    }    
    public void Check() {    
        Console.WriteLine("Read only : {0}", read);    
        Console.WriteLine("const : {0}", cons);    
    }    
}

public class ConstReadonlySample
{
    public static void Run()
    {
        Test t = new Test();
        t.Check();
    }
}
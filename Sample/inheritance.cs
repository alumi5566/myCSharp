using System;

namespace Samples;

public class Animal {
    public void Speak() => Console.WriteLine("Animal sound");
}
// In C#, class can inherit from another class, or implement another interface
// Dog class inheritance Animal
public class Dog : Animal {
    public void Bark() => Console.WriteLine("Woof");
}

// In C#, struct CANNOT inherit from another class
// can implement another interface
// Structs are value types — their memory layout is fixed, so they don’t support class-style inheritance.
// They can implement interfaces, so you can still have polymorphism.
public struct PointStructImplement : IComparable<PointStruct> {
    public int X, Y;

    public int CompareTo(PointStruct other) {
        return X.CompareTo(other.X);
    }
}

// ❌ This is illegal:
// public struct MyStruct : PointStructImplement { } // compile error

public class Inheritance
{
    public static void Run()
    {
        Console.WriteLine("Inheritance");
    }
}

using System;

namespace Samples;

public class Car 
{
    public string Brand { get; set; }
    public int Year { get; set; }

    public Car(string brand, int year)
    {
        Brand = brand;
        Year = year;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Car: {Brand}, Year: {Year}");
    }
}

public class ClassObjectSample
{
    public static void Run()
    {
        Car myCar = new Car("Toyota", 2020);
        myCar.DisplayInfo();
    }
}

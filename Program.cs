using System; // System is a namespace, like import java.lang.*; in Java. Allow you to use Console / String / Math / DateTime
// If you don't using System, you need to write Console.WriteLine("Hello");
using Samples; // So we can access your samples ns
// You can still use Samples.ArraysSample.Run(); with this using

class Program
// In C#, the class name does NOT have to match the filename. (In Java, public classes must match the filename.)
// C# is more flexible because compilation happens per project, not per file.
// You can name the filename and class anything you like, C# compiler will look for static void Main(string[] args) to execute
{
    static void Main(string[] args)
    {
        Console.WriteLine("Choose a sample to run:");
        Console.WriteLine("1 = Arrays");
        Console.WriteLine("2 = Lists");
        Console.WriteLine("3 = Dictionary");
        Console.WriteLine("4 = Class & Object");
        Console.WriteLine("5 = Heap");
        Console.WriteLine("6 = Struct vs Class");
        Console.WriteLine("7 = StructPointer");
        Console.WriteLine("8 = Boxing vs UnBoxing");
        Console.WriteLine("9 = Enum");
        Console.WriteLine("10 = ConstVsReadOnly");
        Console.WriteLine("11 = Ref vs Out");
        Console.WriteLine("12 = GetterSetter");
        Console.WriteLine("13 = ParkingLots");

        Console.Write("Enter number: ");
        string choice = Console.ReadLine();

        switch (choice)
        {
            case "1": ArraysSample.Run(); break;
            case "2": ListSample.Run(); break;
            case "3": DictionarySample.Run(); break;
            case "4": ClassObjectSample.Run(); break;
            case "5": HeapSample.Run(); break;
            case "6": StructVsClassSample.Run(); break;
            case "7": PointerSample.Run(); break;
            case "8": BoxingUnBoxingSample.Run(); break;
            case "9": EnumSample.Run(); break;
            case "10": ConstReadonlySample.Run(); break;
            case "11": RefVsOutSample.Run(); break;
            case "12": GetterSetterSample.Run(); break;
            case "13": ParkingLotsSample.Run(); break;
            default: Console.WriteLine("Invalid choice."); break;
        }
    }
}
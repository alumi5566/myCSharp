# C# Samples Project

This project contains various C# syntax and data structure samples, 
organized in separate files and runnable from a main menu in `Program.cs`.

## 📌 How to Run

1. **Navigate to the project folder**
```bash
cd /MyApp
```

2. **Run the C# program**
```bash
dotnet run
```

## Why I use dotnet to run this program?
C# is a programming language, while .NET is a runtime and framework that runs C# code.
Usually if you want to compile and run the C# code, you need to

1. **Compile C# code with the C# compiler (csc) which produces IL (Intermediate Language).**
```bash
csc Program.cs # Compiles to Program.dll or Program.exe (IL)
# This is like $ javac MyProgram.java to generate bytecode in Java
```
2. **Use the .NET runtime (CoreCLR) executes that IL.**
```bash
dotnet Program.dll # .NET runtime executes the IL
# This is like $ java MyProgram to use JVM to execute the bytecode
```

Essentially when you run the `$ dotnet run`, it equals
```bash
dotnet build # which calls csc under the hood
dotnet bin/Debug/net8.0/MyApp.dll
```

## CLR? .NET runtime?

Common Language Runtime (CLR) is equilivant with JVM, will manage the compile / memory management / thread handling...

When we talk about .NET runtime, it refers to CLR + Base Class Library (BCL). BCL is a built-in libraries for strings, collections, I/O, networking, LINQ, etc. .NET runtime is equilivant with Java Runtime Environment (JRE).
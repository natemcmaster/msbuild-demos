using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine($"Working directory : { Directory.GetCurrentDirectory() }")
        Console.WriteLine($"Base directory    : { new Class1().BaseDirectory }");
    }
}

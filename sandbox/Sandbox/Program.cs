using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Sandbox World!");

        Console.WriteLine("What is your favorite color? ");
        string  color = Console.ReadLine();
        Console.WriteLine(color);
        Console.WriteLine($"Your color is {color} ");
    }
}
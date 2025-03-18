// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main(string[] args)
    {
        if (args.Length > 0)
        {
            string name = args[0];
            Console.WriteLine($"Hello, {name}!");
        }
        else
        {
            Console.WriteLine("No username provided.");
        }
    }
}
//We have to declare arguments at the start of the creation of the project.

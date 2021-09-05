using System;

namespace Primitive_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Belmy Semape Maripane\n");

            Console.WriteLine("What is your name(s)?");
            var name = Console.ReadLine();

            Console.WriteLine("What is yous surname?");
            var surname = Console.ReadLine();

            var currentDate = DateTime.Now;

            Console.WriteLine($"\nHello\nName: {name}\nSurname: {surname}\n\nOn {currentDate:d} at {currentDate:t}!");
            
            Console.WriteLine($"\nEND OF THE PROGRAM!...    Press any key to exit...");
            Console.ReadKey(true);
        }
    }
}
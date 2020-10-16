using System;
using System.IO;

namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            File.Create("1.txt");
            Console.WriteLine("!!!!! I did it!!!!");
            Console.ReadKey();
        }
    }
}

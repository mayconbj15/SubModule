using System;
using System.IO;

namespace SubModule
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = File.ReadAllText("./Text.txt");
            Console.WriteLine(text);
        }
    }
}

using System;
using System.IO;
using System.Linq;

namespace KASDLab07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] rows = File.ReadAllLines("../../Data/input.txt");

            Finder finder = new Finder();

            MyVector<string> result = finder.Find(rows);

            result.Print();

            File.AppendAllLines("../../Data/output.txt", result.ToArray().Select(t => t?.ToString()));

            Console.ReadKey();
        }
    }
}

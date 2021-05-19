using System;
using System.Collections.Generic;

namespace Start
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>
            {
                "priyanka",
                "priyank",
                "Suraj",
                "vishu",
                "Raj",
                "sunita"
            };
            Console.WriteLine("Not sorted list :");
            foreach (var item in list)
            {
                Console.Write(item);
                Console.Write("  ");
            }
            Console.WriteLine("\n\nSorted list :");
            list.Sort((left, right) => left.CompareTo(right));
            foreach (var item in list)
            {
                Console.Write(item);
                Console.Write("  ");
            }
            Console.WriteLine();
        }
    }
}

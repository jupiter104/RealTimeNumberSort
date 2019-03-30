using System;
using System.Collections.Generic;
using System.Linq;

namespace RealTimeNumberSort
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>();
            var unique = new List<int>();

            while (true)
            {
                Console.WriteLine("Enter a number or type 'quit' to exit");
                string input = Console.ReadLine();

                if (input == "quit")
                {
                    break;
                }

                int num = int.Parse(input);

                numbers.Add(num);
                numbers.Sort();
                unique = numbers.Distinct().ToList();

                Console.Write("Sorted and unique numbers: ");
                foreach (var n in unique)
                {
                    Console.Write(n + ", ");
                }
                Console.WriteLine();
            }
        }
    }
}

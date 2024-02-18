using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListsAndLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new [] { 5, 6, 7, 17, 22 };

            //Console.WriteLine($"Index 0, value {numbers[0]}");
            //Console.WriteLine($"Index 1, value {numbers[1]}");
            //Console.WriteLine($"Index 2, value {numbers[2]}");

            //int firstFromEnd = numbers[numbers.Length-1];
            //int secondFromEnd = numbers[numbers.Length-2];
            //Console.WriteLine($"firstFromEnd {firstFromEnd}");
            //Console.WriteLine($"secondFromEnd {secondFromEnd}");

            var sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            Console.WriteLine($"Sum: {sum}");

            Console.ReadKey();
        }
    }
}

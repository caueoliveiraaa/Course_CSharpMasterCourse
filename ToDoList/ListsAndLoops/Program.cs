using System;

namespace ListsAndLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            // One dimensional array
            var numbers = new[] { 5, 6, 7, 17, 22 };

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

            // Two-dimensional array
            char[,] letters = new char[2, 3];

            letters[0, 0] = 'A';
            letters[0, 1] = 'B';
            letters[0, 2] = 'C';
            letters[1, 0] = 'D';
            letters[1, 1] = 'E';
            letters[1, 2] = 'F';

            char[,] letters2 = new char[,]
            {
                { 'A', 'B', 'C' },
                { 'D', 'E', 'F'}
            };

            for (int i = 0; i < letters.GetLength(0); i++)
            {
                for (int j = 0; j < letters.GetLength(1); j++)
                {
                    Console.WriteLine($"(letters) - Element in row {i} and col {j}: {letters[i, j]}");
                }
            }

            for (int i = 0; i < letters2.GetLength(0); i++)
            {
                for (int j= 0; j < letters2.GetLength(1); j++)
                {
                    Console.WriteLine($"(letters2) - Element in row {i} and col {j}: {letters2[i, j]}");
                }
            };

            var words = new [] { "one", "two", "three", "four" };
            foreach(var word in words)
            {
                Console.WriteLine(word);
            }


            Console.ReadKey();
        }
    }
}

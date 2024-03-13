using System;
using System.Collections.Generic; // Import for List

namespace ListsAndLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            // Arrays vs Lists
            Arrays();
            Console.WriteLine("------------------------");
            Lists();
            Console.WriteLine("------------------------");

            // GetOnlyPositive
            var numbers = new[] { 10, -18, 5, -7, 13 };
            int nonPositive;
            var onlyPositives = GetOnlyPositive(numbers, out nonPositive);
            foreach (var positiveNumber in onlyPositives)
            {
                Console.WriteLine(positiveNumber);
            }
            Console.WriteLine($"Amount of non-positives is {nonPositive}");

            // TryParse
            Console.WriteLine("------------------------");
            UsingTryParse();

            Console.WriteLine("Press any key to end the program!");
            Console.ReadKey();
        }

        static void Arrays()
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

            Console.WriteLine();
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
                for (int j = 0; j < letters2.GetLength(1); j++)
                {
                    Console.WriteLine($"(letters2) - Element in row {i} and col {j}: {letters2[i, j]}");
                }
            };

            Console.WriteLine();
            //string[] wordsExample = { "one", "two", "three", "four" };
            var words = new[] { "one", "two", "three", "four" };
            foreach (var word in words)
            {
                Console.WriteLine(word);
            }
        }

        static void Lists()
        {
            // Working with lists
            var words = new List<string>
            {
                "one",
                "two"
            };

            //words.Add("Hello"); // adding new elements
            Console.WriteLine();
            Console.WriteLine($"Count of the elements Add {words.Count}");

            foreach (var word in words)
            {
                Console.WriteLine(word);
            }

            words.Remove("two"); // removing an element
            Console.WriteLine();
            Console.WriteLine($"Count of the elements Remove {words.Count}");

            foreach (var word in words)
            {
                Console.WriteLine(word);
            }

            words.RemoveAt(0); // removing an element via index
            Console.WriteLine();
            Console.WriteLine($"Count of the elements after RemoveAt {words.Count}");

            var moreWords = new[] { "three", "four", "five" };
            words.AddRange(moreWords); // adding more than one item at once

            Console.WriteLine();
            Console.WriteLine($"Count of the elements after AddRange {words.Count}");

            foreach (var word in words)
            {
                Console.WriteLine(word);
            }

            Console.WriteLine();
            Console.WriteLine($"Index of 'three' {words.IndexOf("three")}"); // getting the index
            Console.WriteLine($"Index of 'five' {words.IndexOf("five")}");
            Console.WriteLine($"List contains 'five' {words.Contains("five")}"); // veryfing if element exists

            words.Clear();
            Console.WriteLine();
            Console.WriteLine($"Count of the elements after Clear {words.Count}");
        }
        
        static List<int> GetOnlyPositive(int[] numbers, out int nonPositive)
        {   
            var result = new List<int>();
            nonPositive = 0;

            foreach (var number in numbers)
            {
                if (number > 0)
                    result.Add(number);
                else
                    nonPositive++;
            }

            return result;
        }
          
        static void UsingTryParse()
        {
            bool inputIsNumber;
            do
            {
                Console.WriteLine("Enter a number: ");
                var userInput = Console.ReadLine();

                inputIsNumber = int.TryParse(userInput, out int number);
                if (inputIsNumber)
                {
                    Console.WriteLine("Parsing worked. Number: " + number);
                }
                else
                {
                    Console.WriteLine("Parsing did not work. Try again");
                }
            } while (!inputIsNumber);
        }
    }
}

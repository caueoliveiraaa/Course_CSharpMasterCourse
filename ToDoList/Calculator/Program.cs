using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            long GetFirstNumber()
            {
                Console.WriteLine("\nInput the first number: ");
                string firstNumberAsText = Console.ReadLine();
                long firstNumberConverted = long.Parse(firstNumberAsText);
                Console.WriteLine($"You have informed {firstNumberConverted}");

                return firstNumberConverted;
            }

            long GetSecondNumber()
            {
                Console.WriteLine("\nInput the second number: ");
                string secondNumberAsText = Console.ReadLine();
                long secondNumberConverted = long.Parse(secondNumberAsText);
                Console.WriteLine($"You have informed {secondNumberConverted}");

                return secondNumberConverted;
            }

            string SelectOption()
            {
                Console.WriteLine("\nWhat do you want to do next?");
                Console.WriteLine("[A]dd numebrs");
                Console.WriteLine("[S]ubtract numbers");
                Console.WriteLine("[M]ultiply numbers");
                string optionSelected = Console.ReadLine();
                string optionUpper = optionSelected.ToUpper();
                Console.WriteLine($"You have selected {optionUpper}");

                return optionUpper;
            }

            long Add(long number1, long number2)
            {
                return number1 + number2;
            }

            long Subtract(long number1, long number2)
            {
                return number1 - number2;
            }

            long Multiply(long number1, long number2)
            {
                return number1 * number2;
            }

            void ShowResult(long num1, long num2, string @operator, long result)
            {
                Console.WriteLine($"Result of {num1} {@operator} {num2} is {result}");
            }

            // Program starts here
            Console.WriteLine(">>>>>>> Calculator <<<<<<<");
            long firstNumber = GetFirstNumber();
            long secondNumber = GetSecondNumber();
            string option = SelectOption();

            if (option == "A")
            {
                ShowResult(firstNumber, secondNumber, "+", Add(firstNumber, secondNumber));
            }
            else if (option == "S")
            {
                ShowResult(firstNumber, secondNumber, "-", Subtract(firstNumber, secondNumber));
            }
            else if (option == "M")
            {
                ShowResult(firstNumber, secondNumber, "x", Multiply(firstNumber, secondNumber));
            }
            else
            {
                Console.WriteLine($"{option} is not a valid option!");
            }

            Console.WriteLine($"Press any key to end the program:");
            Console.ReadKey(true);
        }
    }
}   

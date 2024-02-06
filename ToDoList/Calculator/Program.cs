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

            // Program starts here
            Console.WriteLine(">>>>>>> Calculator <<<<<<<");
            long firstNumber = GetFirstNumber();
            long secondNumber = GetSecondNumber();
            string option = SelectOption();

            if (option == "A")
            {
                long result1 = Add(firstNumber, secondNumber);
                Console.WriteLine($"Result of {firstNumber} + {secondNumber} = {result1}");
            }
            else if (option == "S")
            {
                long result2 = Subtract(firstNumber, secondNumber);
                Console.WriteLine($"Result of {firstNumber} - {secondNumber} = {result2}");
            }
            else if (option == "M")
            {
                long result3 = Multiply(firstNumber, secondNumber);
                Console.WriteLine($"Result of {firstNumber} x {secondNumber} = {result3}");
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

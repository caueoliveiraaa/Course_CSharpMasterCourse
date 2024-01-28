using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("[S]ee all TODOs");
            Console.WriteLine("[A]dd a TODO");
            Console.WriteLine("[R]emove a TODO");
            Console.WriteLine("[E]xit");

            string userChoice = Console.ReadLine();
            Console.WriteLine("User input " + userChoice);
            Console.WriteLine($"Input {userChoice} is long: {IsLong(userChoice)}");
            Console.WriteLine($"10 + {userChoice.Length} = {Add(10, userChoice.Length)}");

            if (userChoice == "S")
            {
                PrintSelectedOption("see all TODOs");
            }
            else if (userChoice == "A")
            {
                PrintSelectedOption("add a TODO");
            }
            else if (userChoice == "R")
            {
                PrintSelectedOption("remove a TODO");
            }
            else if (userChoice == "E")
            {
                PrintSelectedOption("exit");
            }

            int Add(int a, int b)
            {
                return a + b;
            }

            bool IsLong(string input)
            {
                return input.Length > 10;
            }

            void PrintSelectedOption(string option)
            {
                Console.WriteLine("Selected option " + option);
            }

            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    class Program
    {
        static void Main(string[] args)
        {
            char ConvertPointsToGrade(int points)
            {
                switch (points)
                {
                    case 10:
                    case 9:
                        return 'A';
                    case 8:
                    case 7:
                    case 6:
                        return 'B';
                    case 5:
                    case 4:
                    case 3:
                        return 'C';
                    case 2:
                    case 1:
                        return 'D';
                    case 0:
                        return 'E';
                    default:
                        return '!';
                }
            }

            void PrintOption(string option)
            {
                Console.WriteLine($"You have chosen {option}");
            }

            Console.WriteLine("[A]dd a todo");
            Console.WriteLine("[S]ee a todo");
            Console.WriteLine("[R]remove a todo");
            Console.WriteLine("[E]xit todo");

            string userChoice = Console.ReadLine();

            if (userChoice.ToUpper() == "A")
            {
                PrintOption("Add a todo");
            }
            else if (userChoice.ToUpper() == "S")
            {
                PrintOption("See todo list");
            }
            else if (userChoice.ToUpper() == "A")
            {
                PrintOption("Remove a todo");
            }
            else if (userChoice.ToUpper() == "E")
            {
                PrintOption("Exit app");
            }
            else
            {
                Console.WriteLine("Invalid option!");
            }

            Console.WriteLine("Press any key to stop");
            Console.ReadKey();
        }
    }
}

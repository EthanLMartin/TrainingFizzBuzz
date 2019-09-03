using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int min = 1;
                int max = -1;
                UserChoice selection = PromptSelection();
                if (selection == UserChoice.Exit)
                {
                    return;
                } else if (selection == UserChoice.Range)
                {
                    min = PromptNumber("Select a minimum number");
                    max = PromptNumber("Select a maximum number");
                } else if (selection == UserChoice.SingleValue)
                {
                    min = max = PromptNumber("Select a number");
                }
                Console.WriteLine("------------");

                for (int number = min; number <= max; number++)
                {
                    string result = BuildString(number);
                    Console.WriteLine(result);
                }
                Console.WriteLine("------------");
            }
        }

        static string BuildString(int number)
        {
            List<string> codes = new List<string>();

            CheckForRule3(codes, number);
            CheckForRule5(codes, number);
            CheckForRule7(codes, number);
            CheckForRule11(codes, number);
            CheckForRule13(codes, number);
            CheckForRule17(codes, number);

            string result = string.Join("", codes);

            if (result == "")
            {
                result = number.ToString();
            }
            return result;
        }

        static UserChoice PromptSelection()
        {
            bool validSelection = false;
            UserChoice selection = UserChoice.None;
            while (!validSelection)
            {
                Console.WriteLine("Type \"1\" for range, \"2\" for singular value, \"3\" to exit");
                string input = Console.ReadLine();
                validSelection = true;
                if (input == "1")
                {
                    selection = UserChoice.Range;
                } else if (input == "2")
                {
                    selection = UserChoice.SingleValue;
                } else if (input == "Q")
                {
                    selection = UserChoice.Exit;
                } else
                {
                    validSelection = false;
                    Console.WriteLine("Invalid selection, please try again.");
                }
            }
            return selection;
        }

        static int PromptNumber(string message)
        {
            bool validSelection = false;
            int selection = 0;
            while (!validSelection)
            {
                Console.WriteLine(message);
                string input = Console.ReadLine();

                try
                {
                    selection = Int32.Parse(input);
                    validSelection = true;
                }
                catch
                {
                    Console.WriteLine("Please input a valid integer.");
                }
            }
            return selection;
        }

        static void CheckForRule3(List<string> codes, int number)
        {
            if (IsDivisibleBy(number, 3))
            {
                codes.Add("Fizz");
            }
        }
        static void CheckForRule5(List<string> codes, int number)
        {
            if (IsDivisibleBy(number, 5))
            {
                codes.Add("Buzz");
            }
        }
        static void CheckForRule7(List<string> codes, int number)
        {
            if (IsDivisibleBy(number, 7))
            {
                codes.Add("Bang");
            }
        }
        static void CheckForRule11(List<string> codes, int number)
        {
            if (IsDivisibleBy(number, 11))
            {
                codes.Clear();
                codes.Add("Bong");
            }
        }
        static void CheckForRule13(List<string> codes, int number)
        {
            if (IsDivisibleBy(number, 13))
            {
                string code = "Fezz";
                int index = codes.FindIndex(elem => (elem[0] == 'B'));
                if (index == -1)
                {
                    codes.Add(code);
                } else
                {
                    codes.Insert(index, code);
                };
            };
        }
        static void CheckForRule17(List<string> codes, int number)
        {
            if (IsDivisibleBy(number, 17))
            {
                codes.Reverse();
            }
        }

        static bool IsDivisibleBy(int divisend, int divisor)
        {
            return ((divisend % divisor) == 0);
        }
    }
}

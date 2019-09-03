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
            for (int number = 1; number <= 100; number++)
            {
                string result = BuildString(number);
                Console.WriteLine(result);
            }
            Console.ReadLine();
        }

        static string BuildString(int number)
        {
            List<string> codes = new List<string>();
            if (IsDivisibleBy(number, 3))
            {
                codes.Add("Fizz");
            }
            if (IsDivisibleBy(number, 13))
            {
                // Goes immediately in front of any B phrase 
                codes.Add("Fezz");
            }
            if (IsDivisibleBy(number, 5))
            {
                codes.Add("Buzz");
            }
            if (IsDivisibleBy(number, 7))
            {
                codes.Add("Bang");
            }
            if (IsDivisibleBy(number, 11))
            {
                return "Bong";
            }
            if (IsDivisibleBy(number, 17))
            {
                codes.Reverse();
            }

            string result = String.Join("", codes);

            if (result == "")
            {
                result = number.ToString();
            }
            return result;
        }

        static bool IsDivisibleBy(int divisend, int divisor)
        {
            return ((divisend % divisor) == 0);
        }
    }
}

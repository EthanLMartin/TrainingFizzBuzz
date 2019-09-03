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
                string result = "";
                if (IsDivisibleBy(number, 3))
                {
                    result += "Fizz";
                }
                if (IsDivisibleBy(number, 5))
                {
                    result += "Bang";
                }
                if (result == "")
                {
                    result = number.ToString();
                }
                Console.WriteLine(result);
            }
            Console.WriteLine("end");
        }

        static bool IsDivisibleBy(int divisend, int divisor)
        {
            return ((divisend % divisor) == 0);
        }
    }
}

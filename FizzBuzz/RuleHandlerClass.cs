using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class RuleHandlerClass
    {
        public void ApplyRules(List<string> codes, int number)
        {
            CheckForRule3(codes, number);
            CheckForRule5(codes, number);
            CheckForRule7(codes, number);
            CheckForRule11(codes, number);
            CheckForRule13(codes, number);
            CheckForRule17(codes, number);
        }

        private void CheckForRule3(List<string> codes, int number)
        {
            if (IsDivisibleBy(number, 3))
            {
                codes.Add("Fizz");
            }
        }
        private void CheckForRule5(List<string> codes, int number)
        {
            if (IsDivisibleBy(number, 5))
            {
                codes.Add("Buzz");
            }
        }
        private void CheckForRule7(List<string> codes, int number)
        {
            if (IsDivisibleBy(number, 7))
            {
                codes.Add("Bang");
            }
        }
        private void CheckForRule11(List<string> codes, int number)
        {
            if (IsDivisibleBy(number, 11))
            {
                codes.Clear();
                codes.Add("Bong");
            }
        }
        private void CheckForRule13(List<string> codes, int number)
        {
            if (IsDivisibleBy(number, 13))
            {
                string code = "Fezz";
                int index = codes.FindIndex(elem => (elem[0] == 'B'));
                if (index == -1)
                {
                    codes.Add(code);
                }
                else
                {
                    codes.Insert(index, code);
                };
            };
        }
        private void CheckForRule17(List<string> codes, int number)
        {
            if (IsDivisibleBy(number, 17))
            {
                codes.Reverse();
            }
        }
        private bool IsDivisibleBy(int divisend, int divisor)
        {
            return ((divisend % divisor) == 0);
        }
    }
}

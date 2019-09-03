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
            PromptHandlerClass promptHandler = new PromptHandlerClass();
            while (true)
            {
                int min = 1;
                int max = -1;
                UserChoice selection = promptHandler.PromptSelection();
                if (selection == UserChoice.Exit)
                {
                    return;
                } else if (selection == UserChoice.Range)
                {
                    min = promptHandler.PromptNumber("Select a minimum number");
                    max = promptHandler.PromptNumber("Select a maximum number");
                } else if (selection == UserChoice.SingleValue)
                {
                    min = max = promptHandler.PromptNumber("Select a number");
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
            RuleHandlerClass ruleHandler = new RuleHandlerClass();

            List<string> codes = new List<string>();

            ruleHandler.ApplyRules(codes, number);

            string result = string.Join("", codes);

            if (result == "")
            {
                result = number.ToString();
            }
            return result;
        }
    }
}

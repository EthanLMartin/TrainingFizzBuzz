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
                UserChoice selection = promptHandler.PromptSelection();

                switch (selection)
                {
                    case UserChoice.Exit:
                        return;
                    case UserChoice.Range:
                        MainLoop(
                            promptHandler.PromptNumber("Select a minimum number"),
                            promptHandler.PromptNumber("Select a maximum number")
                        );
                        break;
                    case UserChoice.SingleValue:
                        int choice = promptHandler.PromptNumber("Select a number");
                        MainLoop(choice, choice);
                        break;
                }
            }
        }

        static void MainLoop(int min, int max)
        {
            Console.WriteLine("------------");

            for (int number = min; number <= max; number++)
            {
                string result = BuildString(number);
                Console.WriteLine(result);
            }
            Console.WriteLine("------------");
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

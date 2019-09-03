using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class PromptHandlerClass
    {
        public UserChoice PromptSelection()
        {
            while (true)
            {
                Console.WriteLine("Type \"1\" for range, \"2\" for singular value, \"Q\" to exit");
                string input = Console.ReadLine();
                if (input == "1")
                {
                    return UserChoice.Range;
                }
                else if (input == "2")
                {
                    return UserChoice.SingleValue;
                }
                else if (input == "Q")
                {
                    return UserChoice.Exit;
                }
                else
                {
                    Console.WriteLine("Invalid selection, please try again.");
                }
            }
        }
        public int PromptNumber(string message)
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
    }
}

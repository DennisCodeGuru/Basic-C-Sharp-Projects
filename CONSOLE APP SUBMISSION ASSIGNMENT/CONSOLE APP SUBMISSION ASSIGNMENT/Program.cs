using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONSOLE_APP_SUBMISSION_ASSIGNMENT
{
    class Program
    {
        static void Main(string[] args)
        {
            bool guessAgain = false;

            do
            {
                Console.WriteLine("Guess my favorite color: red, green, purple, yellow, gray, blue, or orange.");
                string guess = Console.ReadLine();
                switch (guess.ToLower())
                {
                    case "gray":
                    case "grey":
                        Console.WriteLine("You have chosen ... wisely.");
                        guessAgain = false;
                        break;
                    default:
                        Console.WriteLine("You chose ... poorly.");
                        Console.WriteLine("Do you want to guess again? Y or N");
                        string playAgain = Console.ReadLine();
                        guessAgain = playAgain.ToLower() == "y";
                        break;
                }
            } while (guessAgain);
            Console.WriteLine("Good-bye!");

            int whileTrigger = 0;
            while (whileTrigger < 10)
            {
                Console.WriteLine(whileTrigger.ToString());
                whileTrigger++;
            }

            Console.Read();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parsingEnums
{
    public enum DaysOfTheWeek
    {
        Sunday,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday
    }

    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the current day of the week: ");
            bool askAgain = false;

            do
            {
                string dayOfTheWeekInput = Console.ReadLine();

                DaysOfTheWeek dayOfTheWeek;

                try
                {
                    askAgain = false;
                    dayOfTheWeek = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), dayOfTheWeekInput.FirstCharToUpper());
                }
                catch (Exception ex)
                {
                    askAgain = true;
                    Console.WriteLine("Please enter an actual day of the week.");
                }
            } while (askAgain);

            Console.ReadLine();
        }
    }
}

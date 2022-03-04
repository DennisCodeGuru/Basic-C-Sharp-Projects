using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car_insurance
{
    class Program
    {
        static void Main(string[] args)
        {
            // Age
            Console.WriteLine("Car Insurance");
            Console.WriteLine("What is your age?");
            string ageInput = Console.ReadLine();
            int userAge = Convert.ToInt32(ageInput);
            bool ageQualified = userAge >= 15;
            // DUI
            Console.WriteLine("Have your ever had a DUI?");
            string hadDuiInput = Console.ReadLine();
            bool duiQualified = hadDuiInput == "yes" || hadDuiInput == "yes";
            // Tickets
            Console.WriteLine("How many speeding tickets do you have?");
            string ticketsInput = Console.ReadLine();
            int ticketsNumber = Convert.ToInt32(ticketsInput);
            bool ticketsQualified = ticketsNumber <= 3;
            // Boolean
            Console.WriteLine("Qualified?");
            bool userQualified = userAge >= 15 && ticketsNumber <= 3 && duiQualified == false;
            Console.WriteLine(userQualified);


            Console.ReadLine();

        }
    }
}

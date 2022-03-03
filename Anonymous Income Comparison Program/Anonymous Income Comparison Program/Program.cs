using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anonymous_Income_Comparison_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income.");
            //Person 1.
            Console.WriteLine("Person 1.");
            Console.WriteLine("Hourly Rate?");
            string hourRate = Console.ReadLine();
            Console.WriteLine("Your rate is: " + hourRate);

            Console.WriteLine("Hours worked per week?");
            string hourWeek = Console.ReadLine();
            Console.WriteLine("Hours worked per week: " + hourWeek);

            //Person 2.
            Console.WriteLine("Person 2.");
            Console.WriteLine("Hourly Rate?");
            string hourRate1 = Console.ReadLine();
            Console.WriteLine("Your rate is: " + hourRate1);

            Console.WriteLine("Hours worked per week?");
            string hourWeek1 = Console.ReadLine();
            Console.WriteLine("Hours worked per week: " + hourWeek1);

            //Annual salary.
            Console.WriteLine("Annual salary of Person 1.\n42,700");
            Console.WriteLine("Annual salary of Person 2.\n56,400");

            Console.WriteLine("Does Person 1 make more money than Person 2?");
            double salaryPerson1 = 42.700;
            double salaryPerson2 = 56.400;
            bool isSalary = salaryPerson1 > salaryPerson2;
            Console.WriteLine(isSalary);
            Console.ReadLine();

            Console.ReadLine();
        }
    }
}

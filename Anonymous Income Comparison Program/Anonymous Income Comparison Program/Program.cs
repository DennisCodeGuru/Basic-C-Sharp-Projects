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
            // Person 1.
            Console.WriteLine("Anonymus Income Comparison Program");
            Console.WriteLine("Person 1");
            Console.WriteLine("Hourly Rate?");
            string hourlyRateInput1 = Console.ReadLine();
            int rateInput1 = Convert.ToInt32(hourlyRateInput1);
            Console.WriteLine("Hours Worked per week?");
            string hoursWorkInput = Console.ReadLine();
            int workInput1 = Convert.ToInt32(hoursWorkInput);
            int annualSalary1 = rateInput1 * workInput1 * 52;

            //Person 2.
            Console.WriteLine("Person 2");
            Console.WriteLine("Hourly Rate?");
            string hourlyRateInput2 = Console.ReadLine();
            int rateInput2 = Convert.ToInt32(hourlyRateInput2);
            Console.WriteLine("Hours Worked per week?");
            string hoursWorkInput2 = Console.ReadLine();
            int workInput2 = Convert.ToInt32(hoursWorkInput);
            int annualSalary2 = rateInput2 * workInput2 * 52;

            // Annual Salary.
            Console.WriteLine("Annual Salary Person1:");
            Console.WriteLine(annualSalary1);

            Console.WriteLine("Annual Salary Person2:");
            Console.WriteLine(annualSalary2);

            //True or False
            bool moreSalary = annualSalary1 > annualSalary2;
            Console.WriteLine("Does Person 1 make more money than Person 2?");
            Console.WriteLine(moreSalary.ToString());

            Console.ReadLine();
        }
    }
}

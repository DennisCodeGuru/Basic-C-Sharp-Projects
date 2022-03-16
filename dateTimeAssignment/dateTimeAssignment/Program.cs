using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dateTimeAssignment
{
    public class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = DateTime.Now;
            Console.WriteLine("Current time: " + dt.ToString());

            Console.WriteLine("\nEnter a number of hours: ");
            int x = Convert.ToInt32(Console.ReadLine());

            DateTime modifiedDateTime = dt.AddHours(x);

            Console.WriteLine("\nIn " + x + " hours: " + modifiedDateTime.ToString());

            Console.ReadLine();
        }
    }
}

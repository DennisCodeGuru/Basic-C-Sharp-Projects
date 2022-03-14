using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee
            {
                firstName = "Sample",
                lastName = "Student"
            };
            employee.SayName();

            IQuittable polyEmployee = new Employee();
            polyEmployee.Quit();

            Console.ReadLine();
        }
    }
}

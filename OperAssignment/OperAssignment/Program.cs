using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperAssignment
{
    public class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee
            {
                firstName = "James",
                lastName = "Bond"
            };
            employee.ListName();

            Employee employee2 = new Employee
            {
                firstName = "Steve",
                lastName = "Rogers"
            };
            employee2.ListName();

            employee.Id = 1;
            employee2.Id = 2;

            bool AreTheyEqual = employee == employee2;
            Console.WriteLine("Are they equal? " + AreTheyEqual);

            employee2.Id = 1;

            AreTheyEqual = employee == employee2;
            Console.WriteLine("Now, are they equal? " + AreTheyEqual);

            Console.ReadLine();
        }
    }
}

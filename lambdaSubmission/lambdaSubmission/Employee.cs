using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lambdaSubmission
{
    public class Employee
    {
        /// <summary>
        /// constructor: makes an object of class
        /// </summary>
        public Employee()
        {

        }

        /// <summary>
        /// constructor: takes firstName, lastName and id as input parameters, returns object with
        /// the properties set
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="id"></param>
        public Employee(string firstName, string lastName, int id)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Id = id;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Id { get; set; }
    }
}

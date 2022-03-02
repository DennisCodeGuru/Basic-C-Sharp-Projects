using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Tech_Academy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Tech Academy.");
            Console.WriteLine("Student Daily Report.");
            Console.WriteLine("What is your name?");
            string yourName = Console.ReadLine();
            Console.WriteLine("Your name is: " + yourName);

            Console.WriteLine("What course are you on?");
            string yourCourse = Console.ReadLine();
            Console.WriteLine("Your corse is: " + yourCourse);

            Console.WriteLine("What page number?");
            string yourPage = Console.ReadLine();
            int Page = Convert.ToInt32(yourPage);

            Console.WriteLine("Do you need help with anything? Please answer “true” or “false“ ");                        
            string Help = Console.ReadLine();
            bool Help1 = Convert.ToBoolean(Help); 

            Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics.");
            string yourExperiences = Console.ReadLine();
            Console.WriteLine("Answer: " + yourExperiences);

            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
            string yourFeedback = Console.ReadLine();
            Console.WriteLine("Answer: " + yourFeedback);

            Console.WriteLine("How many hours did you study today?");
            string yourHours = Console.ReadLine();
            int Hours = Convert.ToInt32(yourHours);

            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");

            Console.ReadLine();
        }
    }
}

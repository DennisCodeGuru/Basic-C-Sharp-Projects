using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classSubmission
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a whole number:");
            int numInput = Convert.ToInt32(Console.ReadLine());

            int numOutput;
            myMath myClass = new myMath();
            myClass.DivideMethod(numInput, out numOutput);
            Console.WriteLine(numOutput);

            Console.ReadLine();
        }
    }
}

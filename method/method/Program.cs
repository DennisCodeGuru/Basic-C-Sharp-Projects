using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace method
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input two integers: ");
            Console.WriteLine("Enter integer One:");
            int inputOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter integer Two (optional):");
            string rawInputTwo = Console.ReadLine();
            int inputTwo = int.MinValue;
            try
            {
                inputTwo = Convert.ToInt32(rawInputTwo);
            }

            catch
            {
                //nothing
            }

            myMath myClass = new myMath();
            if (inputTwo == int.MinValue)
                Console.WriteLine(myClass.MultiplicationMethod(inputOne));
            else
            {
                Console.WriteLine(myClass.MultiplicationMethod(inputOne, inputTwo));
            }

            Console.ReadLine();
        }
    }
}

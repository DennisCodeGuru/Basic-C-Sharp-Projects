using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("User, what number do you want to do math operations on?");
            int userNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(math.myNum + " + " + userNum + " = " + math.Addition(userNum));
            Console.WriteLine(math.myNum + " - " + userNum + " = " + math.Subtraction(userNum));
            Console.WriteLine(math.myNum + " x " + userNum + " = " + math.Multiplication(userNum));

            Console.ReadLine();
        }
    }
}

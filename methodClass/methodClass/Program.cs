using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodClass
{
    public class Program
    {
        public static int numOne = 1995;
        public static int numTwo = 2022;
        static void Main(string[] args)
        {
            myMath myClass = new myMath();
            myClass.SubtractionMethod(18, 22);
            myClass.SubtractionMethod(numOne, numTwo);

            Console.ReadLine();
        }
    }
}

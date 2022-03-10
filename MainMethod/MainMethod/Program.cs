using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input integer:");
            int intInput = Convert.ToInt32(Console.ReadLine());

            myMath myClass = new myMath();
            Console.WriteLine(myClass.AdditionMethod(intInput));

            decimal myDecimal = 15.7m;
            myMath myClass2 = new myMath();
            Console.WriteLine(myClass2.AdditionMethod(myDecimal));

            string strNum = "42";
            myMath myClass3 = new myMath();
            Console.WriteLine(myClass3.AdditionMethod(strNum));
        }
    }
}

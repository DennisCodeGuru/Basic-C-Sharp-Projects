using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethods
{
    public class math
    {
        public static int myNum = 50;

        public static int Multiplication(int userNum)
        {
            return myNum * userNum;
        }

        public static int Subtraction(int userNum)
        {
            return myNum - userNum;
        }

        public static int Addition(int userNum)
        {
            return myNum + userNum;
        }
    }
}

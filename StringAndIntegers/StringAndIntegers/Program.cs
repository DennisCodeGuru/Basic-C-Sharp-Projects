using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAndIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<int> numbers = new List<int> { 73, 175, 295, 396, 498, 507 };
                Console.WriteLine("Enter a number to divide by:");
                int inputNum = Convert.ToInt32(Console.ReadLine());

                foreach (int item in numbers)
                {
                    int divideNum = item / inputNum;
                    Console.WriteLine(item + " divided by " + inputNum + " = " + divideNum);
                }
            }

            catch (FormatException)
            {
                Console.WriteLine("Please enter a whole number.");
            }

            catch (DivideByZeroException)
            {
                Console.WriteLine("Please do not divide by 0.");
            }

            finally
            {
                Console.ReadLine();
            }
        }
    }
}

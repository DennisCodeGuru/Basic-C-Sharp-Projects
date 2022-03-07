using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BRANCHING_SUBMISSION_ASSIGNMENT
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instraction below.");
            Console.WriteLine("Please enter the packege weight:");
            string pkgWeightInput = Console.ReadLine();
            float pkgWeight = float.Parse(pkgWeightInput);
            if (pkgWeight > 50)
            {
                Console.WriteLine("Packege too heavy to be shipped via Packege Express. Have a good day.");
            }
            else
            {
                Console.WriteLine("Please enter the package width:");
                string pkgWightInput = Console.ReadLine();
                float pkgWidth = float.Parse(pkgWightInput);

                Console.WriteLine("Please enter the packege height:");
                string pkgHeightInput = Console.ReadLine();
                float pkgHeight = float.Parse(pkgHeightInput);

                Console.WriteLine("Please enter the packege length:");
                string pkgLengthInput = Console.ReadLine();
                float pkgLength = float.Parse(pkgLengthInput);

                float pkgTotalDimensions = pkgWidth + pkgHeight + pkgLength;

                if (pkgTotalDimensions >= 50)
                {
                    Console.WriteLine("Package too big to be shipped via Packege Express.");
                }
                else
                {
                    float pkgDimensionsProduct = pkgWidth * pkgHeight * pkgLength;
                    float pkgAmount = pkgDimensionsProduct * pkgWeight;
                    float pkgTotal = pkgAmount / 100;
                    float pkgTotalDollar = pkgTotal;
                    Console.WriteLine("Your estimated total for shipping is: " + pkgTotalDollar.ToString("C2") + "\n" + "Thank you!");
                }
            }
            Console.ReadLine();
        }
    }
}

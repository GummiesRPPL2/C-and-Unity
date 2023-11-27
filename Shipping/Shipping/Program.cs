using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Authentication;
using System.Text;
using System.Threading.Tasks;

namespace Shipping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below");
            Console.ReadLine();

            Console.WriteLine("Please enter the package weight.");
            int weight = Convert.ToInt32(Console.ReadLine());

            if (weight > 50)
            {
                Console.WriteLine("The package is too heavy to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Please enter the package width:");
                int width = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter the package height:");
                int height = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter the package length:");
                int length = Convert.ToInt32(Console.ReadLine());

                int total = width + height + length;

                if (total > 50)
                {
                    Console.WriteLine("The package is too big to be shipped via Package Express. Have a good day.");
                    Console.ReadLine();
                }
                else
                {
                    decimal quote = ((height * width * length) * weight) / 100;

                    Console.WriteLine("Package weight: " + weight);
                    Console.WriteLine("Package width: " + width);
                    Console.WriteLine("Package height: " + height);
                    Console.WriteLine("Package length: " + length);
                    Console.WriteLine("Your estimated total for shipping this package is: $" + quote);
                    Console.WriteLine("Thank you!");
                    Console.ReadLine();
                }
            }
        }
    }
}

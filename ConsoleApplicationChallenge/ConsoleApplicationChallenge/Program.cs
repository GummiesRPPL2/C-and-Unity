using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationChallenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me a random number to multiply by 50.");
            long ranNum1 = long.Parse(Console.ReadLine());
            Console.WriteLine(ranNum1 * 50);
            Console.ReadLine();

            Console.WriteLine("Give me a random number to add 25 to.");
            long ranNum2 = long.Parse(Console.ReadLine());
            Console.WriteLine(ranNum2 + 25);
            Console.ReadLine();

            Console.WriteLine("Give me a random number to divide by 12.5");
            long ranNum3 = long.Parse(Console.ReadLine());
            Console.WriteLine(ranNum3 / 12.5);
            Console.ReadLine();

            Console.WriteLine("Give me a random number to check if it is greater than 50");
            long ranNum4 = long.Parse(Console.ReadLine());
            bool biggerthan50 = ranNum4 > 50;
            Console.WriteLine(biggerthan50);
            Console.ReadLine();

            Console.WriteLine("Give me a random number to divide by 7 and I will give you the remainder.");
            long ranNum5 = long.Parse(Console.ReadLine());
            Console.WriteLine(ranNum5 % 7);
            Console.ReadLine();
        }
    }
}

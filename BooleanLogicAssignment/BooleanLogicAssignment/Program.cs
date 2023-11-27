using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanLogicAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Have you ever had a DUI?");
            string dui = Console.ReadLine();
            Console.WriteLine("How many speeding tickets do you have?");
            int tickets = int.Parse(Console.ReadLine());
            Console.ReadLine();

            Console.WriteLine("Qualified?");
            Console.WriteLine(age > 15 && dui == "no" && tickets <= 3);
            Console.ReadLine();
        }
    }
}

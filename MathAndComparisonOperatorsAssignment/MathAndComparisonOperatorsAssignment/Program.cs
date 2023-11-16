using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathAndComparisonOperatorsAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the hourly rate of Person 1? Please input numbers only please.");
            int hourlyRate1 = int.Parse(Console.ReadLine());
            Console.WriteLine("How many hours does Person 1 work per week. Please input numbers only please.");
            int hoursWorked1 = int.Parse(Console.ReadLine());

            Console.WriteLine("What is the hourly rate of Person 2? Please input numbers only please.");
            int hourlyRate2 = int.Parse(Console.ReadLine());
            Console.WriteLine("How many hours does Person 2 work per week. Please input numbers only please.");
            int hoursWorked2 = int.Parse(Console.ReadLine());

            int salary1 = (hourlyRate1 * hoursWorked1) * 52;
            int salary2 = (hourlyRate2 * hoursWorked2) * 52;

            Console.WriteLine("The annual salary of Person 1: " + salary1);
            Console.WriteLine("The annual salary of Person 2: " + salary2);
            bool comparing = salary1 > salary2;
            Console.WriteLine("Does Person 1 make more money than Person 2?");
            Console.WriteLine(comparing);
            Console.ReadLine();



        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Branching
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int currentTemp = 80;
            //int roomTemp = 70;

            ////if (currentTemp == roomTemp)
            ////{
            ////    Console.WriteLine("It is exactly room temperature");
            ////}
            ////else if (currentTemp > roomTemp)
            ////{
            ////    Console.Write("It is warmer than room temperature");
            ////}
            ////else if (currentTemp < roomTemp)
            ////{
            ////    Console.WriteLine("It is colder than room temperature");
            ////}
            ////else
            ////{
            ////    Console.WriteLine("It is not room temperature");
            ////}
            ////Console.ReadLine();

            //string comparisonResult = currentTemp == roomTemp ? "It is room temperature" : "It is not room temperature";
            //Console.WriteLine(comparisonResult);
            //Console.ReadLine();

            //int roomTemp = 70;
            //Console.WriteLine("What is your name?");
            //string name = Console.ReadLine();

            //Console.WriteLine("Hi, " + name + ", what is the current temperature?");
            //int currentTemp = Convert.ToInt32(Console.ReadLine());

            //if (currentTemp == roomTemp)
            //{
            //    Console.WriteLine("It is exactly room temperature");
            //}
            //else if (currentTemp > roomTemp)
            //{
            //    Console.WriteLine("It is warmer than room temperature.");
            //}
            //else if (currentTemp < roomTemp)
            //{
            //    Console.WriteLine("It is colder than room temperature.");
            //}
            //else
            //{ Console.WriteLine("Uhhhh.... something went wrong."); }
            //Console.ReadLine();

            Console.WriteLine("What is your favorite number?");
            int favNum = Convert.ToInt32(Console.ReadLine());

            string result = favNum == 12 ? "You have an awesome favorite number." : "You do not have an awesome favorite number.";
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}

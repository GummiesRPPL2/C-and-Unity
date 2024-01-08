using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFunction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string name = "Jesse";
            //string quote = "The man said \"Hello, Jesse.\" \n Hello on a new line. \n \t Hello on a tab.";
            //string quote2 = "The man said \\Hello, Jesse. \n Hello on a new line. \n \t Hello on a tab.";
            //string fileName = "C://Users//Jesse";
            //string fileName2 = @"C:/Users/Jesse";

            //bool trueOrFalse = name.Contains("s");
            //trueOrFalse = name.EndsWith("s");

            //int length = name.Length;

            //name = name.ToUpper();
            //name = name.ToLower();

            //Console.WriteLine(trueOrFalse);
            //Console.ReadLine();

            StringBuilder sb = new StringBuilder();
            sb.Append("My name is Joseph");

            Console.WriteLine(sb);
            Console.ReadLine();

        }
    }
}

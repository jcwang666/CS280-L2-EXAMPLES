using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example04
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("plz enter 1st number");
            int number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("plz enter 2st number");
            int number2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Sum of 1 and 2 = {0}", number1 + number2);

            //string str = "100.3";
            //float number = 0.0;
            //float.TryParse(str, out number);

            //double a = 3.1415926;
            //float b = (float)a;
        }
    }
}
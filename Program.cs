using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Line_Length
{
    internal class Length
    {
        public static void Main(string[] args)
        {
            double line1Length = LineLength();
            Console.WriteLine($"The length of line is {line1Length}");
        }
        public static double LineLength()
        {
            Console.Write("Enter 1st X co-ordinate of Line: ");
            double x11 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter 1st Y co-ordinate of Line: ");
            double y11 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter 2nd X co-ordinate of Line: ");
            double x12 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter 2nd Y co-ordinate of Line: ");
            double y12 = Convert.ToDouble(Console.ReadLine());
            double lengthOfLine1 = Math.Pow(Math.Pow(x12 - x11, 2) + Math.Pow(y12 - y11, 2), 0.5);
            return lengthOfLine1;
        }
    }
}
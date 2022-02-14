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
            Console.WriteLine("Enter Co-ordinates of 1st Line");
            double line1Length = LineLength();
            Console.WriteLine("Enter Co-ordinates of 2nd Line");
            double line2Length = LineLength();
            string result = line1Length.Equals(line2Length) == true ? "Two lines are equal" : "Two lines are not equal";
            Console.WriteLine(result);
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
            double lengthOfLine = Math.Pow(Math.Pow(x12 - x11, 2) + Math.Pow(y12 - y11, 2), 0.5);
            return lengthOfLine;
        }
    }
}
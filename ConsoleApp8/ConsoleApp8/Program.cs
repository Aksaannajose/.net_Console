using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int l, b, a;
            float h, b1;

            Console.WriteLine("Enter the length and breadth of a rectangle");

            l = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the sides of a square");

            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the base and height of a triangle");

            b1 = float.Parse(Console.ReadLine());
            h = float.Parse(Console.ReadLine());

            Console.WriteLine("Area of a rectangle is = "+ l*b);

            Console.WriteLine("Area of a square is ="+ a*a);

            Console.WriteLine("Area of a triangle is ="+ 0.5*b1*h);

            Console.Read();









        }
    }
}

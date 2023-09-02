using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    internal class Areas
    {
        static void Main(string[] args)
        {
            int l, b, a;
            double b1, h;

            Console.WriteLine("Enter the length and breadth of a Rectangle");

            l = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the sides of a square");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the base and height of a triangle");
            b1 = double.Parse(Console.ReadLine());
            h =  double.Parse(Console.ReadLine());

            Arear(l, b);
            Areasq(a);
            Areat(h, b1);

            Console.Read();




        }
        static void Arear(int l, int b)
        {
            Console.WriteLine("Area is =" + l * b);

        }

        static void Areasq(int a)
        {
            Console.WriteLine("Area is ="+ a*a);

        }

        static void Areat(double b1, double h)
        {
            Console.WriteLine("Area is ="+ 0.5*b1*h);

        }
    }
}

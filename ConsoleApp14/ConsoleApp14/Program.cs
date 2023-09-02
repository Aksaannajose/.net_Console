using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    internal class Program
    {
        public static void Main()
        {
            int a, b;
            double c, d;

            Console.WriteLine("Enter the numbers");

            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());

            c = double.Parse(Console.ReadLine());
            d = double.Parse(Console.ReadLine());


            sum(a, b);
            sum(c, d);
            sum(a, d);

        }


        static void sum(int a,int b)
        {
            Console.WriteLine("Sum is ="+ (a+b));

        }
        static void sum(double c, double d)
        {
            Console.WriteLine("Sum is ="+ (c+d));

        }

        static void sum(int a, double d)
        {
            Console.WriteLine("Sum is ="+ (a+d));
            Console.Read();

        }
        



    }
}

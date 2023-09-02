using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    internal class Program
    {


        static void Main(string[] args)
        {
           Console.WriteLine("Enter the numbers");
           int a = int.Parse(Console.ReadLine());
           int b = int.Parse(Console.ReadLine());

           double c = double.Parse(Console.ReadLine());
           double d = double.Parse(Console.ReadLine());

            int s1 = sum(a, b);
            double s2 = sum(c, d);
            double s3 = sum(a, d);

            Console.WriteLine("Sum of" + a + "and" + b + "=" +s1);


            Console.WriteLine("Sum of" + c + "and" + d + "=" + s2);

            Console.WriteLine("Sum of" + a + "and" + d + "=" + s3);

            Console.Read();

        }

        static int sum(int a, int b)
        {
            return (a + b);

        }

        static double sum(double c, double d)
        {
            return (c + d);

        }

        static double sum(int a, double d)
        {
            return (a + d);

        }
            
           

    }
}

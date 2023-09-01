using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int a, b;
            double c, d;

            Console.WriteLine("Enter the nos.");

            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = double.Parse(Console.ReadLine());
            d = double.Parse(Console.ReadLine());

            Console.WriteLine("sum is ="+ (a+b));

            Console.WriteLine("sum is ="+ (c+d));

            Console.WriteLine("sum is ="+ (a+d));

            Console.Read();












        }
    }
}

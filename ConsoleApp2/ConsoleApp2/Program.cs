using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int a, b;

            Console.WriteLine("Enter two numbers");

            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("Sum is =" + (a + b) + "\n Difference=" + (a - b));

            Console.Read();


        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    class Program
    {
        static void Main()
        {
            int a = 5;
            int b = 10;

            //Console.WriteLine("Enter the first number");
            //a = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter the second number");

            //b = int.Parse(Console.ReadLine());



            Console.WriteLine("Before swapping:");
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);

            // Swapping using a temporary variable
            int temp = a;
            a = b;
            b = temp;

            Console.WriteLine("\nAfter swapping:");
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
            //Console.WriteLine("temp = "+ temp);

            Console.Read();

        }
    }






}


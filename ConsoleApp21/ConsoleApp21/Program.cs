using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21
{
    class Program
    {
        static void Main()
        {
            int a = 5;
            int b = 10;

            Console.WriteLine("Before swapping:");
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);

            // Swapping without a temporary variable using arithmetic operations
            a = a + b;
            b = a - b;
            a = a - b;

            Console.WriteLine("\nAfter swapping:");
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);

            Console.Read();

        
        }
    }









}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, c = 0;

            Console.WriteLine("Enter the number");
            n = int.Parse(Console.ReadLine());

            if (n <= 1)
            {
                Console.WriteLine("The number is not prime.");
            }
            else
            {
                for (int i = 1; i <= n; i++)
                {
                    if (n % i == 0)
                    {
                        c++;
                    }
                }

                if (c == 2)
                {
                    Console.WriteLine("The number is prime.");
                }
                else
                {
                    Console.WriteLine("The number is not prime.");
                }



            }
            Console.Read();

        }
    }
}

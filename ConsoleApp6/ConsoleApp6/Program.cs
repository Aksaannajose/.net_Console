using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;

            Console.WriteLine("Enter the number");

            n = int.Parse(Console.ReadLine());

            if(n%2 == 0)
            
                Console.WriteLine("Even number");
            
            else if(n%2 == 1)
            
                Console.WriteLine("Odd Number");

            

            Console.Read();




        }
    }
}

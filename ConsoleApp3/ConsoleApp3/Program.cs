using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n;
            Console.WriteLine("Enter the limit");
            n = int.Parse(Console.ReadLine());

            int[] a = new int[n];

            for(int i =0; i < n; i++)
            {
                a[i] = int.Parse(Console.ReadLine());


            }

            Console.WriteLine("Reverse array is");

            for(int i = n-1; i>=0; i--)
            {
                Console.WriteLine(a[i]);


            }
            Console.Read();



        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int l, s, temp, n, i, y = 0, x = 0;

            Console.WriteLine("Enter the limit");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the nos.");
            l = int.Parse(Console.ReadLine());

            s = int.Parse(Console.ReadLine());

            int [] a = new int[n];

            for (i = 0; i <= n; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            for (i = 0; i <= n; i++)
            {
                if (a[i] > l)

                l = a[i];
                y = i;
            }

            if (a[i] < s)
            {
                s = a[i];
                x = i;



                temp = a[y];
                a[y] = a[x];
                a[x] = temp;
            }
                for (i = 0; i < n; i++)


            
                Console.WriteLine("Largest is =" + l);
                Console.WriteLine("Smallest is =" + s);


            




            



        }
    }
}

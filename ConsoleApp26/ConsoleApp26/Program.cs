using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26
{

    class Program
    {
        static void Main()
        {
            int n;
            Console.WriteLine("Enter the limit");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the values");
            int[] a = new int[n];

            for (int i = 0; i < n; i++)

                a[i] = int.Parse(Console.ReadLine());

            // sorting starts here,descending
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (a[j] < a[j + 1])
                    {
                        int temp = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = temp;
                    }
                }
            }

            Console.WriteLine("Sorted array is:");
            for (int i = 0; i < n; i++)
                Console.WriteLine(a[i] + " ");

            Console.Read();


        }




    }
}







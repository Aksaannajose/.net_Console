using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    internal class add

    {
      public static void Main()
     {
            int a, b;
            double c, d;

            Console.WriteLine("Enter the  number");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());

            c = double.Parse(Console.ReadLine());
            d = double.Parse(Console.ReadLine());

            add obj = new add();
            obj.sum(a, b);
            obj.sum(c, d);
            obj.sum(a, d);



     }

        void sum(int a, int b)
        {
            Console.WriteLine("Sum is =" + (a + b));
        }

        void sum(double c, double d)
        {
            Console.WriteLine("Sum is ="+ (c+d));

        }

        void sum(int a, double d)
        {
            Console.WriteLine("Sum is = "+ (a+d));
            Console.Read();
        }


    }
}

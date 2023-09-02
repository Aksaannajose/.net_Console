using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class sum
    {

        static int a, b;

        static void accept()

        {
            Console.WriteLine("Enter the number");

            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
        }

        static void display()
        {
            Console.WriteLine("Sum is = " + (a + b));



        }
        class calculation //seperate class
        {
            static void Main()
            {
                sum.accept();
                sum.display();

                Console.Read();

            }
        }

    }
    

}

         


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
     class Sum
      {

        int a, b;

        public void accept()
        {
            Console.WriteLine("Enter the numbers");

            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());


        }

        public void display()
        {
            Console.WriteLine("Sum is ="+ (a+b));
        }

        static void Main()

        {
            Sum obj = new Sum();
            obj.accept();
            obj.display();
            Console.Read();



        }
       
        





        
      }
}

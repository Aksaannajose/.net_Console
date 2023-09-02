using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
     class EvenOdd
      {

        int n;

        public void accept()
        {
            Console.WriteLine("Enter the number");
            n = int.Parse(Console.ReadLine());


        }

        public void dispaly()
        {
            if(n % 2 == 0)
            {
                Console.WriteLine("Even  number");
            
            }
            else if(n % 2 == 1)

            {
                Console.WriteLine("Odd  number");
            }
        }

        static void Main()
        {
            EvenOdd obj = new EvenOdd();
            obj.accept();
            obj.dispaly();

            Console.Read();

        }
    
    
    }
}

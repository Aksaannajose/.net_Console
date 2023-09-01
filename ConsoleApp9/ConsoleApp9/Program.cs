using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {

           
            int m1, m2, m3;
            

            Console.WriteLine("Enter the three subject marks");
            m1 = int.Parse(Console.ReadLine());
            m2 = int.Parse(Console.ReadLine());
            m3 = int.Parse(Console.ReadLine());
          
            
            Console.WriteLine("The total is ="+ (m1+m2+m3));


            Console.Read();



        }
    }
}

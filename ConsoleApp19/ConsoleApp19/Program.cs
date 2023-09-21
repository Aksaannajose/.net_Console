using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;


// Create an interface for address
interface Address
{
    void getdata1();
    void printdata2();
}

// Create an interface for marks
interface Marks
{
    void GetMarksData();
    void PrintMarksData();
}


class Student : Address, Marks
{
    string name, place;
    int m1, m2, m3, total;

    public void getdata1()
    {
        Console.WriteLine("Enter Name:");
        name = Console.ReadLine();
        Console.WriteLine("Enter Place:");
        place = Console.ReadLine();
    }

    public void GetMarksData()
    {
        Console.WriteLine("Enter Marks  1:");
        m1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter Marks  2:");
        m2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter Marks  3:");
        m3 = int.Parse(Console.ReadLine());
        total = m1 + m2 + m3;
    }

    public void printdata2()
    {
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Place: " + place);
    }

    public void PrintMarksData()
    {
        Console.WriteLine("Total Marks: " + total);
    }
}

class Program
{
    public static void Main(string[] args)
    {
        Student Obj = new Student();
        Obj.getdata1();
        Obj.GetMarksData();
        Obj.printdata2();
        Obj.PrintMarksData();

        Console.Read();
    }
}













using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第一周_编程题_4
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b;
            string s;
            Console.Write("Please input a number: ");
            s = Console.ReadLine();
            a = Double.Parse(s);
            Console.Write("Please input another number: ");
            s = Console.ReadLine();
            b = Double.Parse(s);
            Console.WriteLine("The product of these two numbers: " + (a * b));
        }
    }
}

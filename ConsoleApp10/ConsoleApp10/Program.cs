using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.Write("Enter the number: ");
            a = int.Parse(Console.ReadLine());

            if(a > 0)
            {
                Console.WriteLine("The number is positive.");
            }
            else if (a < 0)
            {
                Console.WriteLine("The number is negative.");
            }
            else
            {
                Console.WriteLine("The number is zero.");
            }

        }
    }
}

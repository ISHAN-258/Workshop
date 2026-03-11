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
            int num, x, t;
            Console.Write("Enter a number: ");
            num=int.Parse(Console.ReadLine());
            Console.WriteLine("Table is shown below: ");
            for (x = 1; x <= 10; x++)
            {
                t = num * x;
                Console.WriteLine(num + "*" + x + "=" + t);
            } 
        }
    }
}

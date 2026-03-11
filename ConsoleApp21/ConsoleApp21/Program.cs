using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21
{
    class MethodOverloading
    {
        internal void Area(int a)
        {
            Console.WriteLine("Area of Square: " + (a * a));
        }
        internal void Area(int l, int b)
        {
            Console.WriteLine("Area of Rectangle: " + (l * b));
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MethodOverloading m = new MethodOverloading();
            m.Area(5);
            m.Area(5, 10);
        }
    }
}

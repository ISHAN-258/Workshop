using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Program
    {
        void GetArea(int len, int wid)
        {
            int res = len * wid;
            Console.WriteLine("Area of Rectangle:" + res);
        }
        static void Main(string[] args)
        {
            int l, w;
            Console.Write("Enter value:");
            l=int.Parse(Console.ReadLine());
            w=int.Parse(Console.ReadLine());
            r=GetArea(l, w);
            Console.WriteLine("Area:" + r);
        }
    }
}

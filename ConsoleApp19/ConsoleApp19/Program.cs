using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    internal class Program
    {
        class Rectangle
        {
            int width,length;
            internal void Area()
            {
                Console.WriteLine("Enter the width and length of rectangle");
                width = int.Parse(Console.ReadLine());
                length = int.Parse(Console.ReadLine()); 
                Console.WriteLine("Area of Rectangle is : "+(width*length));
            }
             
        }
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle();
            r.Area();
             Console.ReadLine();
        }
    }
}

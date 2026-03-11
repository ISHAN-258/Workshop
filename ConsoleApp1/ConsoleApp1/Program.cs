using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const float PI = 3.14f;
            float radius, area;
            Console.WriteLine("Enter the radius of the circle:");
           radius = float.Parse(Console.ReadLine());
            area = PI * radius * radius;
            Console.WriteLine("The area of the circle is: " + area);2
        }
    }
}

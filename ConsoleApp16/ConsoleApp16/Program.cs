using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    class Addition
    {
        internal void Add(int num1, int num2)
        {
            int r = num1 + num2;
            Console.WriteLine("Addition is: " + r);
        }
        internal void Add(int num1, int num2, int num3)
        {
            int r = num1 + num2 + num3;
            Console.WriteLine("Addition is: " + r);
        }
        internal void Add(float num1, float num2, float num3)
        {
            float r = num1 + num2 + num3;
            Console.WriteLine("Addition is: " + r);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Addition a = new Addition();
            a.Add(1, 2);
            a.Add(2, 3, 5);
            a.Add(2.7f, 3.5f, 5.3f);
        }
    }
}

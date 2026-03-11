using Microsoft.SqlServer.Server;
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
            float num1, num2;

            Console.Write("Enter the first number: ");
            num1 = float.Parse(Console.ReadLine());

            Console.Write("Enter the second number: ");
            num2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Addition : " + num1 + num2);
            Console.WriteLine("Subtraction : " + (num1 - num2));
            Console.WriteLine("Multiplication : " + (num1 * num2));
            if (num2 != 0)
            {
                Console.WriteLine("Division : " + (num1 / num2));

            }
            else
            {
                Console.Write("Division : Cannot divide by zero");
            }
        }
    }
}


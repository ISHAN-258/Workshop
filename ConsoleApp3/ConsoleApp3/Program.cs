using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;
            Console.WriteLine("Enter three numbers:");
            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());
            num3 = int.Parse(Console.ReadLine());

            if (num1 > num2 && num1 > num3)
            {
                Console.WriteLine("The largest number is: " + num1);
            }
            else if (num2 > num1 && num2 > num3)
            {
                Console.WriteLine("The largest number is: " + num2);
            }
            else if (num3 > num1 && num3 > num2)
            {
                Console.WriteLine("The largest number is: " + num3);
            }
            else
            {
                Console.WriteLine("All numbers are Equal");
            }
        }
    }
}

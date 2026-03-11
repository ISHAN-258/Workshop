using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckNumber
{
    internal class Program
    {
        string CheckNumber(int n)
        {
            if (n % 2 == 0)
            {
                return "Even";
            }
            else
                return "Odd";
        }
        static void Main(string[] args)
        {
            int num;
            string r;
            Program p = new Program();
            Console.Write("Enter anu no. : ");
            num = int.Parse(Console.ReadLine());
            r = p.CheckNumber(num);
            Console.WriteLine("The no. is : " + r);
        }
    }
}
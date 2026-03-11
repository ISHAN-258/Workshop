using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str;
            Console.Write("Enter a string:");
            str=Console.ReadLine();
            Console.WriteLine("Entered string is:" +str);
            Console.WriteLine("Uppercase of string is:" + str.ToUpper());
            Console.WriteLine("Lowercase of string is:" + str.ToLower());
            Console.WriteLine("Length of string is:" + str.Length);
            Console.WriteLine("First occurence index of i:" + str.IndexOf('i'));
            Console.WriteLine("Last occurence index of i:" + str.LastIndexOf('i'));
        }
    }
}
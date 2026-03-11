using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            int age;
            float salary;

            Console.Write("Enter Name:");
            name = Console.ReadLine();
            Console.Write("Enter Age:");
            age = int.Parse(Console.ReadLine());
            Console.Write("Enter Salary:");
            salary = float.Parse(Console.ReadLine());

            Console.WriteLine("Name: {0}, Age: {1}, Salary: {2}", name, age, salary);

        }
    }
}

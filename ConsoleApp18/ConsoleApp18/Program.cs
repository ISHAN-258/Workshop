using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    internal class Program
    {
        class Student
        {
            int id;
            string name;
            string course;

            internal void GetStuDetails()
            {
                Console.WriteLine("Enter the id");
                id = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the name");
                name = Console.ReadLine();
                Console.WriteLine("Enter the course");
                course = Console.ReadLine();
            }
             internal void PrintStuDetails()
            {
                Console.WriteLine("Id: " + id);
                Console.WriteLine("Name: " + name);
                Console.WriteLine("Course: " + course);
            }


        }
        static void Main(string[] args)
        {
            Student s1 = new Student();
            s1.GetStuDetails();
            Console.Clear();
            s1.PrintStuDetails();
        }
    }
}

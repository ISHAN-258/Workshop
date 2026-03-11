using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
        class Student
        {
            int rollNo;
            string name;
            internal void GetStudent()
            {
                Console.WriteLine("Enter Roll No:");
                rollNo = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Name:");
                name = Console.ReadLine();
            }
            class Marks : Student
            {
                int marks1, marks2,total;
                internal void GetMarks()
                {
                    Console.WriteLine("Enter 1st sub Marks:");
                    marks1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter 2nd sub marks:");
                    marks2 = int.Parse(Console.ReadLine());
                    total = marks1 + marks2;    
            }
                internal void Display()
                {
                    Console.WriteLine("Roll No: " + rollNo);
                    Console.WriteLine("Name: " + name);
                Console.WriteLine("Total Marks: " + total);
                }
            }
        static void Main(string[] args)
        {
            Marks student = new Marks();
            student.GetStudent();
            student.GetMarks();
            student.Display();
        }
    }
}

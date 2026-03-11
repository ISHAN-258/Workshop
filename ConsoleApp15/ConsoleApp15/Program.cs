using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 

namespace ConsoleApp15
{
    class Student
    {
        int RollNo;
        string Name,Course;
        int Age;
        internal void SetStudentDetails()
        {            
            Console.WriteLine("Enter Roll No.");
            RollNo = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Name");
            Name = Console.ReadLine();
            Console.WriteLine("Enter Course");
            Course = Console.ReadLine();
            Console.WriteLine("Enter Age");
            Age = int.Parse(Console.ReadLine());
        }
        internal void GetStudentDetails()
        {
            Console.WriteLine("Roll No. : " + RollNo);
            Console.WriteLine("Name : " + Name);
            Console.WriteLine("Course : " + Course);
            Console.WriteLine("Age : " + Age);
        }
    }
    class Fees:Student 
    {
        int Amount;
        string FeeSemester;
        internal void SetFeesDetails()
        {
            Console.WriteLine("Enter Fees Amount");
            Amount = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Fees Semester");
            FeeSemester = Console.ReadLine();
        }
        internal void GetFeesDetails()
        {
            Console.WriteLine("Fees Amount : " + Amount);
            Console.WriteLine("Fees Semester : " + FeeSemester);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Fees f = new Fees();
            f.SetStudentDetails();
            f.SetFeesDetails();
            Console.Clear();
            Console.WriteLine("Student Details");
            f.GetStudentDetails();
            Console.WriteLine("Fees Details");
            f.GetFeesDetails();
        }
    }
}

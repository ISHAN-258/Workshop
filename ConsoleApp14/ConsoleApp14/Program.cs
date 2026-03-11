using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    internal class Program
    {
        class Employee
        {
            int Empno;
            internal string EmpName, Designation;
            internal double Salary;
            internal void ReadEmpData()
            {
                Console.WriteLine("Enter Employee Number: ");
                Empno = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Employee Name: ");
                EmpName = Console.ReadLine();
                Console.WriteLine("Enter Designation of Employee: ");
                Designation = Console.ReadLine();
                Console.WriteLine("Enter Salary of Employee: ");
                Salary = double.Parse(Console.ReadLine());
            }
            internal void DisplayEmpData()
            {
                Console.WriteLine("Employee Number: " + Empno);
                Console.WriteLine("Employee Name: " + EmpName);
                Console.WriteLine("Designation of Employee: " + Designation);
                Console.WriteLine("Salary of Employee: " + Salary);
            }
        }
            
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            Employee emp2 = new Employee();
            emp.ReadEmpData();
            emp2.ReadEmpData();
            Console.Clear();
            if(emp.Salary > emp2.Salary)
            {
                Console.WriteLine("Employee with higher salary is: "+emp.EmpName);
               
            }
            else
            {
                Console.WriteLine("Employee with higher salary is: "+emp.EmpName);
                
            }
           
        }
    }
}

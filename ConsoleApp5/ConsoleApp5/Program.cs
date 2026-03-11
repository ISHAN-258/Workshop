using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[]nums= new int[10];
            int x;
            Console.Write("Enter any 10 numbers:");
            for (x = 0; x < nums.Length; x++)
            {
                nums[x] = int.Parse(Console.ReadLine());
            }
            Array.Sort(nums);
            Console.WriteLine("Sorted Items are: ");
            for (x = 0; x < nums.Length; x++)
            {
                Console.WriteLine(nums[x]);
            }
        }
    } 
}

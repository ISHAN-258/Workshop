using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    internal class Program
    {
        int CountVowels()
        {
            int count = 0;
            Console.WriteLine("Enter a string: ");
            string str = Console.ReadLine().ToLower();
            foreach (char c in str)
            {
                if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
                {
                    count++;
                }
            }
                return count;
            
        }
        static void Main(string[] args)
        {
            Program p=new Program();
            int result = p.CountVowels();
            Console.WriteLine("Count of Vowel is: " + result);

        }
    }
}

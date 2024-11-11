using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_Vowels
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string :");
            string str = Console.ReadLine().ToLower();
            int count = 0;
            foreach(int c in str)
            {
                if(c=='a'||c=='e'||c=='i'||c=='o'||c=='u')
                {
                    count++;
                }
            }
            if(count>0)
            {
                Console.WriteLine("No of vowels " + count);
            }
            else
            {
                Console.WriteLine("no vowels ");
            }
        }
    }
}

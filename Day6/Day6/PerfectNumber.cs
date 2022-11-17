using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    internal class PerfectNumber
    {
        public static void Perfectnumber()
        {
            int number, Sum = 0, n;
            Console.Write("Enter the Number to check :");
            number = int.Parse(Console.ReadLine());
            n = number;
            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                {
                    Sum = Sum + i;
                }
            }
            if (Sum == n)
            {
                Console.WriteLine("\n Entered number is a perfect number");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("\n Entered number is not a perfect number");
                Console.ReadLine();
            }
        }
    }
}

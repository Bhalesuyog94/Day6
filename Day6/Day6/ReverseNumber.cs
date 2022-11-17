using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    internal class ReverseNumber
    {
        public static void Reversenumber()
        {
            int num, reverse = 0;
            Console.WriteLine("Enter a Number : ");
            num = int.Parse(Console.ReadLine());
            int reminder;
            while (num > 0)
            {
                reminder = num % 10;
                num = num / 10;
                reverse = reverse * 10 + reminder;
            }
            Console.WriteLine(reverse);
        }
    }
}

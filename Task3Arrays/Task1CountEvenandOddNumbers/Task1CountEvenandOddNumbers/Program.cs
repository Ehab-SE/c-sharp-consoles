using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1CountEvenandOddNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = {32,55,20,13,12,10,17,45,22,6};
            int countEven = 0;
            int countOdd = 0;
            foreach (int i in numbers) {
                if (i % 2 == 0)
                {
                    countEven++;
                }
                else
                {
                    countOdd++;
                }

            }
            Console.WriteLine($"Count of Even numbers = {countEven}\nCount of odd numbers = {countOdd}");
        }
    }
}

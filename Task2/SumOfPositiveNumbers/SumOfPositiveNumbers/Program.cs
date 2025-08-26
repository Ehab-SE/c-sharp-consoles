using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace SumOfPositiveNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            int total = 0;
            do
            {
                Console.WriteLine("Enter a number");
                num = int.Parse(Console.ReadLine());
                if(num < 0)
                {
                    continue;
                }
                else
                {
                    total += num;
                }

            } while (num != 0);
            Console.WriteLine($"\nTotal = {total}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenOrOddCounter
{
    internal class Program
    {
        static void Main(string[] args)
        {
        start: Console.WriteLine("please enter an intger number > 0");
            int number= int.Parse(Console.ReadLine());
            if (number < 1) {  
                goto start;
            }
            if (number % 2 == 0)
            {
                Console.WriteLine($"{number} Is even number");
            }
            else
            {
                Console.WriteLine($"{number} Is odd number");
            }
        }
    }
}

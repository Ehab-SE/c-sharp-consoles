using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplicationTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer number");
            int num = int.Parse(Console.ReadLine());
            if (num < 0)
            {
                Console.WriteLine("Invalid input");
            }
            else
            {
                Console.WriteLine($"\nMultiplication table of number {num}\n");
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine($"{num} * {i} = {num * i}");
                }
            }
        }
    }
}

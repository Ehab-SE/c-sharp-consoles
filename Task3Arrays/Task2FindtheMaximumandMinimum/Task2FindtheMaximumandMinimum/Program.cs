using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2FindtheMaximumandMinimum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5];

            for (int i = 0; i < numbers.Length; i++) {
                Console.WriteLine("Enter an integer number");
                numbers[i] = int.Parse(Console.ReadLine());
            }
            int max = numbers[0];
            int min = numbers[0];
            foreach (var item in numbers)
            {
                if (item > max) { max = item; }
                if (item < min) { min = item; }
            }
            Console.WriteLine($"\nMax = {max} \nMin = {min}");
        }
    }
}
